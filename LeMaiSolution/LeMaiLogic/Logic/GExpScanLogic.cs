using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LeMaiDomain;

namespace LeMaiLogic.Logic
{
    public class GExpScanLogic : BaseLogic
    {
        public GExpScanLogic(BaseLogicConnectionData data) : base(data)
        {
        }
        /// <summary>
        /// Ký nhận đơn hàng nội mạng
        /// </summary>
        /// <param name="BillCode">Mã đơn hàng</param>
        /// <param name="UserId">Người ký nhận</param>
        /// <param name="FullName">Tên đầy đủ</param>
        /// <param name="scanPost">Mã bưu cục - Tính toán chi phí nữa</param>
        /// <returns></returns>
        public string AddSigned(string BillCode, string UserId, string FullName, string phone, string scanPost)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                DateTime currentDate = dc.CurrentTime();
                GExpBill bill = dc.GExpbill.GetObject(base.ConnectionData.Schema, BillCode);
                if (bill != null)
                {
                    if (bill.BillStatus == 6 || bill.BillStatus == 8)
                    {
                        return "Đơn hàng đã được ký nhận hoặc hoàn trả.";
                    }
                    GExpProvider provider = dc.GExpprovider.GetObject(base.ConnectionData.Schema, bill.FK_ProviderAccount);
                    if (provider.ManualSign == false)
                    {
                        return "Loại kiện không cho phép ký nhận thủ công, không thể ký nhận!";
                    }
                    // Thêm vào hành trình
                    GExpScanSign scan = new GExpScanSign();
                    scan.FK_Post = scanPost;
                    scan.FK_Account = UserId;
                    scan.Id = Guid.NewGuid().ToString();
                    scan.BillCode = BillCode;
                    scan.CreateDate = currentDate;
                    bool isDeliverySucess = true;
                    // Cập nhật trạng thái đơn hàng
                    if (scanPost != bill.RegisterSiteCode || provider.Post == bill.RegisterSiteCode)
                    {
                        // Giao hàng thành công.
                        bill.IsSigned = true;
                        bill.IsReturn = false;
                        bill.SignedDate = currentDate;
                        bill.BillStatus = (int)enumGExpBillStatus.DA_GIAO_6;
                        scan.Note = "[" + FullName + " - " + phone + "] - Ký nhận giao hàng thành công cho người nhận là " + bill.AcceptMan;
                    }
                    else
                    {
                        isDeliverySucess = false;
                        bill.IsSigned = true;
                        bill.IsReturn = true;
                        bill.SignedDate = currentDate;
                        bill.BillStatus = (int)enumGExpBillStatus.DA_HOAN_8;
                        scan.Note = "[" + FullName + " - " + phone + "] - Ký nhận hoàn trả đơn hàng cho người gửi là " + bill.SendMan;
                    }
                    dc.GExpscansign.InsertOnSubmit(base.ConnectionData.Schema, scan);
                    dc.GExpbill.Update(base.ConnectionData.Schema, bill);

                    // Cập nhật chi tiết kết toán
                    ExpPost postFrom = dc.EXppost.GetObject(ConnectionData.Schema, bill.RegisterSiteCode);
                    ExpPost postTo = dc.EXppost.GetObject(ConnectionData.Schema, scanPost);
                    ExpPost postSys = dc.EXppost.GetObject(ConnectionData.Schema, "0000");
                    if (postFrom == null || postTo == null || postSys == null)
                    {
                        return "Mã bưu cục không tồn tại. Vui lòng liên hệ quản trị";
                    }
                    if (isDeliverySucess == true && postFrom.Id != postTo.Id)
                    {
                        string caseId = string.Empty;
                        if (postFrom.ParrentPost == postTo.ParrentPost && postFrom.ParrentPost != "0000")
                        {
                            // 2 cấp 2 cùng thuộc nhóm Cấp 1
                            caseId = "C2A_C2A";
                        }
                        else if (postFrom.ParrentPost == postTo.Id && postFrom.ParrentPost != "0000")
                        {
                            // Cấp 2 gửi hàng về cấp 1 phát cùng thuộc nhóm cấp 1
                            caseId = "C2A_C1A";
                        }
                        else if (postTo.ParrentPost == postFrom.Id && postTo.ParrentPost != "0000")
                        {
                            // Cấp 1 gửi hàng về cấp 2 phát cùng thuộc nhóm cấp 1
                            caseId = "C1A_C2A";
                        }
                        else if (postFrom.ParrentPost == "0000" && postTo.ParrentPost == "0000" && postFrom.Id != postTo.Id)
                        {
                            // Cấp 1 gửi hàng về cấp 1 phát, khác nhóm cấp 1
                            caseId = "C1A_C1B";
                        }
                        else if (postFrom.ParrentPost == "0000" && postTo.ParrentPost != "0000")
                        {
                            // Cấp 1 gửi hàng về cấp 2 phát, khác nhóm cấp 1
                            caseId = "C1A_C2B";
                        }
                        else if (postFrom.ParrentPost != "0000" && postTo.ParrentPost == "0000")
                        {
                            // Cấp 2 gửi hàng về cấp 1 phát, khác nhóm cấp 1
                            caseId = "C2A_C1B";
                        }
                        else if (postFrom.ParrentPost != "0000" && postTo.ParrentPost != "0000")
                        {
                            // Cấp 2 gửi hàng về cấp 2 phát, khác nhóm cấp 1
                            caseId = "C2A_C2B";
                        }

                        switch (caseId)
                        {
                            case "C2A_C2A":
                                {
                                    // Chỉ + - tiền ở cấp 2, không thay đổi cấp 1.
                                    postSys = dc.EXppost.GetObject(ConnectionData.Schema, postFrom.ParrentPost);
                                    // 1. Tính toán cước giao hàng
                                    int DeliveryFee = CalculatorFeeWithWeight((int)bill.BillWeight, provider.DeliveryInitPrice, provider.DeliveryInitWeight, provider.DeliveryStepWeight, provider.DeliveryStepPrice);
                                    if (DeliveryFee > 0)
                                    {
                                        // A. Gửi trả giao
                                        GExpBalanceDetail syscash = new GExpBalanceDetail();
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postFrom.Id;
                                        syscash.CurrentExtPostFrom = postFrom.ValueBlance;
                                        syscash.AfterPostFrom = postFrom.ValueBlance - DeliveryFee;
                                        syscash.FK_ExtPostTo = postTo.Id;
                                        syscash.CurrentExtPostTo = postTo.ValueBlance;
                                        syscash.AfterPostTo = postTo.ValueBlance + DeliveryFee;
                                        syscash.Value = DeliveryFee;
                                        syscash.CreateDate = currentDate.AddSeconds(1);
                                        syscash.CreateBy = UserId;
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "DELIVERY";
                                        syscash.Note = "Phí giao hàng [" + postFrom.TenDaiLy + "] trả cho [" + postTo.TenDaiLy + "]. Cân nặng: " + bill.BillWeight.ToString("N0") + " Gr";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        // Cập nhật số tiền hiện tại
                                        postTo.ValueBlance += syscash.Value;
                                        postFrom.ValueBlance -= syscash.Value;
                                    }
                                    // 2. Tính toán cước trung chuyển
                                    int TransFee = CalculatorFeeWithWeight((int)bill.BillWeight, provider.TranInitPrice, provider.TranInitWeight, provider.TranStepWeight, provider.TranStepPrice);
                                    if (TransFee > 0)
                                    {
                                        // B. Gửi trả system
                                        GExpBalanceDetail syscash = new GExpBalanceDetail();
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postFrom.Id;
                                        syscash.CurrentExtPostFrom = postFrom.ValueBlance;
                                        syscash.AfterPostFrom = postFrom.ValueBlance;
                                        syscash.FK_ExtPostTo = postSys.Id;
                                        syscash.CurrentExtPostTo = postSys.ValueBlance;
                                        syscash.AfterPostTo = postSys.ValueBlance;
                                        syscash.Value = TransFee;
                                        syscash.CreateDate = currentDate.AddSeconds(2);
                                        syscash.CreateBy = "SYS";
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "TRANSIT";
                                        syscash.Note = "Phí trung chuyển [" + postFrom.TenDaiLy + "] trả cho [" + postSys.TenDaiLy + "]";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        // Cập nhật số tiền hiện tại
                                        postFrom.ValueBlance -= syscash.Value;
                                    }
                                    // 3. Tính cước hệ thống
                                    int SysFee = CalculatorFeeWithWeight((int)bill.BillWeight, provider.SysInitPrice, provider.SysInitWeight, provider.SysStepWeight, provider.SysStepPrice);
                                    if (SysFee > 0)
                                    {
                                        // C. Gửi trả system
                                        GExpBalanceDetail syscash = new GExpBalanceDetail();
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postFrom.Id;
                                        syscash.CurrentExtPostFrom = postFrom.ValueBlance;
                                        syscash.AfterPostFrom = postFrom.ValueBlance - SysFee;
                                        syscash.FK_ExtPostTo = postSys.Id;
                                        syscash.CurrentExtPostTo = postSys.ValueBlance;
                                        syscash.AfterPostTo = postSys.ValueBlance;
                                        syscash.Value = SysFee;
                                        syscash.CreateDate = currentDate.AddSeconds(3);
                                        syscash.CreateBy = "SYS";
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "OPER";
                                        syscash.Note = "Phí hệ thống [" + postFrom.TenDaiLy + "] trả cho [" + postSys.TenDaiLy + "]";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        // Cập nhật số tiền hiện tại
                                        postFrom.ValueBlance -= syscash.Value;
                                    }
                                    // Thu hộ giao trả cho gửi
                                    decimal ThuHo = bill.COD;
                                    string temp = "Tiền thu hộ khách hàng ";
                                    if (bill.FK_PaymentType == "NTT")
                                    {
                                        ThuHo = bill.COD + bill.Freight;
                                        temp += "+ Phí nhận trả ";
                                    }
                                    temp = temp.Trim() + ". ";
                                    if (ThuHo > 0)
                                    {
                                        // D. Giao trả cho gửi
                                        GExpBalanceDetail syscash = new GExpBalanceDetail();
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postTo.Id;
                                        syscash.CurrentExtPostFrom = postTo.ValueBlance;
                                        syscash.AfterPostFrom = postTo.ValueBlance - (int)ThuHo;
                                        syscash.FK_ExtPostTo = postFrom.Id;
                                        syscash.CurrentExtPostTo = postFrom.ValueBlance;
                                        syscash.AfterPostTo = postFrom.ValueBlance + (int)ThuHo;
                                        syscash.Value = (int)ThuHo;
                                        syscash.CreateDate = currentDate.AddSeconds(4);
                                        syscash.CreateBy = UserId;
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "COD";
                                        syscash.Note = temp + "Đại lý [" + postTo.TenDaiLy + "] trả cho [" + postFrom.TenDaiLy + "]";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        // Cập nhật số tiền hiện tại
                                        postFrom.ValueBlance += syscash.Value;
                                        postTo.ValueBlance -= syscash.Value;
                                    }
                                    dc.EXppost.Update(ConnectionData.Schema, postTo);
                                    dc.EXppost.Update(ConnectionData.Schema, postFrom);
                                }
                                break;
                            case "C2A_C1A":
                                {
                                    // Đối tượng nhận tiền ở đây là nhóm cấp 1
                                    postSys = dc.EXppost.GetObject(ConnectionData.Schema, postFrom.ParrentPost);
                                    // Chỉ + - tiền ở cấp 2, không thay đổi cấp 1.
                                    // 1. Tính toán cước giao hàng
                                    int DeliveryFee = CalculatorFeeWithWeight((int)bill.BillWeight, provider.DeliveryInitPrice, provider.DeliveryInitWeight, provider.DeliveryStepWeight, provider.DeliveryStepPrice);
                                    if (DeliveryFee > 0)
                                    {
                                        // A. Gửi trả giao
                                        GExpBalanceDetail syscash = new GExpBalanceDetail();
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postFrom.Id;
                                        syscash.CurrentExtPostFrom = postFrom.ValueBlance;
                                        syscash.AfterPostFrom = postFrom.ValueBlance - DeliveryFee;
                                        syscash.FK_ExtPostTo = postTo.Id;
                                        syscash.CurrentExtPostTo = postTo.ValueBlance;
                                        syscash.AfterPostTo = postTo.ValueBlance;
                                        syscash.Value = DeliveryFee;
                                        syscash.CreateDate = currentDate.AddSeconds(1);
                                        syscash.CreateBy = UserId;
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "DELIVERY";
                                        syscash.Note = "Phí giao hàng [" + postFrom.TenDaiLy + "] trả cho [" + postTo.TenDaiLy + "]. Cân nặng: " + bill.BillWeight.ToString("N0") + " Gr";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        // Cập nhật số tiền hiện tại
                                        postFrom.ValueBlance -= syscash.Value;
                                    }
                                    // 2. Tính toán cước trung chuyển
                                    int TransFee = CalculatorFeeWithWeight((int)bill.BillWeight, provider.TranInitPrice, provider.TranInitWeight, provider.TranStepWeight, provider.TranStepPrice);
                                    if (TransFee > 0)
                                    {
                                        // B. Gửi trả system
                                        GExpBalanceDetail syscash = new GExpBalanceDetail();
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postFrom.Id;
                                        syscash.CurrentExtPostFrom = postFrom.ValueBlance;
                                        syscash.AfterPostFrom = postFrom.ValueBlance - TransFee;
                                        syscash.FK_ExtPostTo = postSys.Id;
                                        syscash.CurrentExtPostTo = postSys.ValueBlance;
                                        syscash.AfterPostTo = postSys.ValueBlance;
                                        syscash.Value = TransFee;
                                        syscash.CreateDate = currentDate.AddSeconds(2);
                                        syscash.CreateBy = "SYS";
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "TRANSIT";
                                        syscash.Note = "Phí trung chuyển [" + postFrom.TenDaiLy + "] trả cho [" + postSys.TenDaiLy + "]";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        // Cập nhật số tiền hiện tại
                                        postFrom.ValueBlance -= syscash.Value;
                                    }
                                    // 3. Tính cước hệ thống
                                    int SysFee = CalculatorFeeWithWeight((int)bill.BillWeight, provider.SysInitPrice, provider.SysInitWeight, provider.SysStepWeight, provider.SysStepPrice);
                                    if (SysFee > 0)
                                    {
                                        // C. Gửi trả system
                                        GExpBalanceDetail syscash = new GExpBalanceDetail();
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postFrom.Id;
                                        syscash.CurrentExtPostFrom = postFrom.ValueBlance;
                                        syscash.AfterPostFrom = postFrom.ValueBlance - SysFee;
                                        syscash.FK_ExtPostTo = postSys.Id;
                                        syscash.CurrentExtPostTo = postSys.ValueBlance;
                                        syscash.AfterPostTo = postSys.ValueBlance;
                                        syscash.Value = SysFee;
                                        syscash.CreateDate = currentDate.AddSeconds(3);
                                        syscash.CreateBy = "SYS";
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "OPER";
                                        syscash.Note = "Phí hệ thống [" + postFrom.TenDaiLy + "] trả cho [" + postSys.TenDaiLy + "]";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        // Cập nhật số tiền hiện tại
                                        postFrom.ValueBlance -= syscash.Value;
                                    }
                                    // Thu hộ giao trả cho gửi
                                    decimal ThuHo = bill.COD;
                                    string temp = "Tiền thu hộ khách hàng ";
                                    if (bill.FK_PaymentType == "NTT")
                                    {
                                        ThuHo = bill.COD + bill.Freight;
                                        temp += "+ Phí nhận trả ";
                                    }
                                    temp = temp.Trim() + ". ";
                                    if (ThuHo > 0)
                                    {
                                        // D. Giao trả cho gửi
                                        GExpBalanceDetail syscash = new GExpBalanceDetail();
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postTo.Id;
                                        syscash.CurrentExtPostFrom = postTo.ValueBlance;
                                        syscash.AfterPostFrom = postTo.ValueBlance;
                                        syscash.FK_ExtPostTo = postFrom.Id;
                                        syscash.CurrentExtPostTo = postFrom.ValueBlance;
                                        syscash.AfterPostTo = postFrom.ValueBlance + (int)ThuHo;
                                        syscash.Value = (int)ThuHo;
                                        syscash.CreateDate = currentDate.AddSeconds(4);
                                        syscash.CreateBy = UserId;
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "COD";
                                        syscash.Note = temp + "Đại lý [" + postTo.TenDaiLy + "] trả cho [" + postFrom.TenDaiLy + "]";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        // Cập nhật số tiền hiện tại
                                        postFrom.ValueBlance += syscash.Value;
                                    }
                                    dc.EXppost.Update(ConnectionData.Schema, postFrom);
                                }
                                break;
                            case "C1A_C2A":
                                {
                                    // Chỉ + - tiền ở cấp 2, không thay đổi cấp 1.
                                    // 1. Tính toán cước giao hàng
                                    int DeliveryFee = CalculatorFeeWithWeight((int)bill.BillWeight, provider.DeliveryInitPrice, provider.DeliveryInitWeight, provider.DeliveryStepWeight, provider.DeliveryStepPrice);
                                    if (DeliveryFee > 0)
                                    {
                                        // A. Gửi trả giao
                                        GExpBalanceDetail syscash = new GExpBalanceDetail();
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postFrom.Id;
                                        syscash.CurrentExtPostFrom = postFrom.ValueBlance;
                                        syscash.AfterPostFrom = postFrom.ValueBlance;
                                        syscash.FK_ExtPostTo = postTo.Id;
                                        syscash.CurrentExtPostTo = postTo.ValueBlance;
                                        syscash.AfterPostTo = postTo.ValueBlance + DeliveryFee;
                                        syscash.Value = DeliveryFee;
                                        syscash.CreateDate = currentDate.AddSeconds(1);
                                        syscash.CreateBy = UserId;
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "DELIVERY";
                                        syscash.Note = "Phí giao hàng [" + postFrom.TenDaiLy + "] trả cho [" + postTo.TenDaiLy + "]. Cân nặng: " + bill.BillWeight.ToString("N0") + " Gr";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        // Cập nhật số tiền hiện tại
                                        postTo.ValueBlance += syscash.Value;
                                    }
                                    // Thu hộ giao trả cho gửi
                                    decimal ThuHo = bill.COD;
                                    string temp = "Tiền thu hộ khách hàng ";
                                    if (bill.FK_PaymentType == "NTT")
                                    {
                                        ThuHo = bill.COD + bill.Freight;
                                        temp += "+ Phí nhận trả ";
                                    }
                                    temp = temp.Trim() + ". ";

                                    if (ThuHo > 0)
                                    {
                                        // D. Giao trả cho gửi
                                        GExpBalanceDetail syscash = new GExpBalanceDetail();
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postTo.Id;
                                        syscash.CurrentExtPostFrom = postTo.ValueBlance;
                                        syscash.AfterPostFrom = postTo.ValueBlance - (int)ThuHo;
                                        syscash.FK_ExtPostTo = postFrom.Id;
                                        syscash.CurrentExtPostTo = postFrom.ValueBlance;
                                        syscash.AfterPostTo = postFrom.ValueBlance;
                                        syscash.Value = (int)ThuHo;
                                        syscash.CreateDate = currentDate.AddSeconds(4);
                                        syscash.CreateBy = UserId;
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "COD";
                                        syscash.Note = temp + "Đại lý [" + postTo.TenDaiLy + "] trả cho [" + postFrom.TenDaiLy + "]";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        // Cập nhật số tiền hiện tại
                                        postTo.ValueBlance -= syscash.Value;
                                    }
                                    dc.EXppost.Update(ConnectionData.Schema, postTo);
                                }
                                break;
                            case "C1A_C1B":
                                {
                                    int benGiaoTraBenGui = 0;
                                    // Cấp 1 gửi hàng về Cấp 1 khác phát.
                                    // Thực hiện +- tiền như hiện tại. Update công nợ của 2 bên.
                                    // 1. Tính toán cước giao hàng
                                    int DeliveryFee = CalculatorFeeWithWeight((int)bill.BillWeight, provider.DeliveryInitPrice, provider.DeliveryInitWeight, provider.DeliveryStepWeight, provider.DeliveryStepPrice);
                                    if (DeliveryFee > 0)
                                    {
                                        benGiaoTraBenGui = benGiaoTraBenGui - DeliveryFee;
                                        // A. Gửi trả giao
                                        GExpBalanceDetail syscash = new GExpBalanceDetail();
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postFrom.Id;
                                        syscash.CurrentExtPostFrom = postFrom.ValueBlance;
                                        syscash.AfterPostFrom = postFrom.ValueBlance - DeliveryFee;
                                        syscash.FK_ExtPostTo = postTo.Id;
                                        syscash.CurrentExtPostTo = postTo.ValueBlance;
                                        syscash.AfterPostTo = postTo.ValueBlance + DeliveryFee;
                                        syscash.Value = DeliveryFee;
                                        syscash.CreateDate = currentDate.AddSeconds(1);
                                        syscash.CreateBy = UserId;
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "DELIVERY";
                                        syscash.Note = "Phí giao hàng [" + postFrom.TenDaiLy + "] trả cho [" + postTo.TenDaiLy + "]. Cân nặng: " + bill.BillWeight.ToString("N0") + " Gr";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        // Cập nhật số tiền hiện tại
                                        postTo.ValueBlance += syscash.Value;
                                        postFrom.ValueBlance -= syscash.Value;
                                    }
                                    // 2. Tính toán cước trung chuyển
                                    int TransFee = CalculatorFeeWithWeight((int)bill.BillWeight, provider.TranInitPrice, provider.TranInitWeight, provider.TranStepWeight, provider.TranStepPrice);
                                    if (TransFee > 0)
                                    {
                                        // B. Gửi trả system
                                        GExpBalanceDetail syscash = new GExpBalanceDetail();
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postFrom.Id;
                                        syscash.CurrentExtPostFrom = postFrom.ValueBlance;
                                        syscash.AfterPostFrom = postFrom.ValueBlance - TransFee;
                                        syscash.FK_ExtPostTo = postSys.Id;
                                        syscash.CurrentExtPostTo = postSys.ValueBlance;
                                        syscash.AfterPostTo = postSys.ValueBlance + TransFee;
                                        syscash.Value = TransFee;
                                        syscash.CreateDate = currentDate.AddSeconds(2);
                                        syscash.CreateBy = "SYS";
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "TRANSIT";
                                        syscash.Note = "Phí trung chuyển [" + postFrom.TenDaiLy + "] trả cho [" + postSys.TenDaiLy + "]";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        // Cập nhật số tiền hiện tại
                                        postSys.ValueBlance += syscash.Value;
                                        postFrom.ValueBlance -= syscash.Value;
                                    }

                                    // 3. Tính cước hệ thống
                                    int SysFee = CalculatorFeeWithWeight((int)bill.BillWeight, provider.SysInitPrice, provider.SysInitWeight, provider.SysStepWeight, provider.SysStepPrice);
                                    if (SysFee > 0)
                                    {
                                        // C. Gửi trả system
                                        GExpBalanceDetail syscash = new GExpBalanceDetail();
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postFrom.Id;
                                        syscash.CurrentExtPostFrom = postFrom.ValueBlance;
                                        syscash.AfterPostFrom = postFrom.ValueBlance - SysFee;
                                        syscash.FK_ExtPostTo = postSys.Id;
                                        syscash.CurrentExtPostTo = postSys.ValueBlance;
                                        syscash.AfterPostTo = postSys.ValueBlance + SysFee;
                                        syscash.Value = SysFee;
                                        syscash.CreateDate = currentDate.AddSeconds(3);
                                        syscash.CreateBy = "SYS";
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "OPER";
                                        syscash.Note = "Phí hệ thống [" + postFrom.TenDaiLy + "] trả cho [" + postSys.TenDaiLy + "]";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        // Cập nhật số tiền hiện tại
                                        postSys.ValueBlance += syscash.Value;
                                        postFrom.ValueBlance -= syscash.Value;
                                    }
                                    // Thu hộ giao trả cho gửi
                                    decimal ThuHo = bill.COD;
                                    string temp = "Tiền thu hộ khách hàng ";
                                    if (bill.FK_PaymentType == "NTT")
                                    {
                                        ThuHo = bill.COD + bill.Freight;
                                        temp += "+ Phí nhận trả ";
                                    }
                                    temp = temp.Trim() + ". ";
                                    if (ThuHo > 0)
                                    {
                                        benGiaoTraBenGui = benGiaoTraBenGui + (int)ThuHo;
                                        // D. Giao trả cho gửi
                                        GExpBalanceDetail syscash = new GExpBalanceDetail();
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postTo.Id;
                                        syscash.CurrentExtPostFrom = postTo.ValueBlance;
                                        syscash.AfterPostFrom = postTo.ValueBlance - (int)ThuHo;
                                        syscash.FK_ExtPostTo = postFrom.Id;
                                        syscash.CurrentExtPostTo = postFrom.ValueBlance;
                                        syscash.AfterPostTo = postFrom.ValueBlance + (int)ThuHo;
                                        syscash.Value = (int)ThuHo;
                                        syscash.CreateDate = currentDate.AddSeconds(4);
                                        syscash.CreateBy = UserId;
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "COD";
                                        syscash.Note = temp + "Đại lý [" + postTo.TenDaiLy + "] trả cho [" + postFrom.TenDaiLy + "]";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        // Cập nhật số tiền hiện tại
                                        postFrom.ValueBlance += syscash.Value;
                                        postTo.ValueBlance -= syscash.Value;
                                    }
                                    dc.EXppost.Update(ConnectionData.Schema, postTo);
                                    dc.EXppost.Update(ConnectionData.Schema, postFrom);
                                    dc.EXppost.Update(ConnectionData.Schema, postSys);
                                    // Ghi nhận công nợ
                                    if (benGiaoTraBenGui != 0)
                                    {
                                        GExpBalanceDetailPost CongNoCheck = dc.GExpbalancedetailpost.GetObjectCon(base.ConnectionData.Schema,
                                            "WHERE (FK_ExtPostFrom='" + postFrom.Id + "' AND FK_ExtPostTo='" + postTo.Id + "') OR (FK_ExtPostFrom='" + postTo.Id + "' AND FK_ExtPostTo='" + postFrom.Id + "') ORDER BY EpochTime DESC");
                                        if (CongNoCheck == null)
                                        {
                                            CongNoCheck = new GExpBalanceDetailPost();
                                            CongNoCheck.FK_ExtPostFrom = postFrom.Id;
                                            CongNoCheck.AfterPostFrom = 0;
                                            CongNoCheck.FK_ExtPostTo = postTo.Id;
                                            CongNoCheck.AfterPostTo = 0;
                                        }


                                        GExpBalanceDetailPost CongNo = new GExpBalanceDetailPost();
                                        CongNo.Id = Guid.NewGuid().ToString();
                                        CongNo.CreateDate = currentDate;
                                        CongNo.BillCode = bill.BillCode;
                                        CongNo.CreateBy = UserId;
                                        CongNo.EpochTime = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;

                                        if (benGiaoTraBenGui > 0)
                                        {
                                            // Cấp 1 giao, trả tiền lại cho cấp 1 gửi
                                            CongNo.FK_ExtPostFrom = postTo.Id;
                                            CongNo.FK_ExtPostTo = postFrom.Id;

                                            // Check Current Value From
                                            if (CongNoCheck.FK_ExtPostFrom == CongNo.FK_ExtPostFrom)
                                            {
                                                CongNo.CurrentExtPostFrom = CongNoCheck.AfterPostFrom;
                                            }
                                            else
                                            {
                                                CongNo.CurrentExtPostFrom = CongNoCheck.AfterPostTo;
                                            }
                                            // Check Current Value To
                                            if (CongNoCheck.FK_ExtPostFrom == CongNo.FK_ExtPostTo)
                                            {
                                                CongNo.CurrentExtPostTo = CongNoCheck.AfterPostFrom;
                                            }
                                            else
                                            {
                                                CongNo.CurrentExtPostTo = CongNoCheck.AfterPostTo;
                                            }

                                            CongNo.Value = Math.Abs(benGiaoTraBenGui);

                                            CongNo.AfterPostFrom = CongNo.CurrentExtPostFrom - CongNo.Value;
                                            CongNo.AfterPostTo = CongNo.CurrentExtPostTo + CongNo.Value;
                                            CongNo.Type = "TO => FROM";
                                            CongNo.Note = postTo.TenDaiLy + " TRẢ " + postFrom.TenDaiLy;

                                        }
                                        else
                                        {
                                            // Cấp 1 gửi trả tiền cho cấp 1 giao
                                            CongNo.FK_ExtPostFrom = postFrom.Id;
                                            CongNo.FK_ExtPostTo = postTo.Id;

                                            // Check Current Value From
                                            if (CongNoCheck.FK_ExtPostFrom == CongNo.FK_ExtPostFrom)
                                            {
                                                CongNo.CurrentExtPostFrom = CongNoCheck.AfterPostFrom;
                                            }
                                            else
                                            {
                                                CongNo.CurrentExtPostFrom = CongNoCheck.AfterPostTo;
                                            }
                                            // Check Current Value To
                                            if (CongNoCheck.FK_ExtPostFrom == CongNo.FK_ExtPostTo)
                                            {
                                                CongNo.CurrentExtPostTo = CongNoCheck.AfterPostFrom;
                                            }
                                            else
                                            {
                                                CongNo.CurrentExtPostTo = CongNoCheck.AfterPostTo;
                                            }

                                            CongNo.Value = Math.Abs(benGiaoTraBenGui);

                                            CongNo.AfterPostFrom = CongNo.CurrentExtPostFrom - CongNo.Value;
                                            CongNo.AfterPostTo = CongNo.CurrentExtPostTo + CongNo.Value;

                                            CongNo.Type = "FROM => TO";
                                            CongNo.Note = postFrom.TenDaiLy + " TRẢ " + postTo.TenDaiLy;
                                        }
                                        dc.GExpbalancedetailpost.InsertOnSubmit(base.ConnectionData.Schema, CongNo);
                                    }

                                }
                                break;
                            case "C1A_C2B":
                                {
                                    int benGiaoTraBenGui = 0;
                                    ExpPost postC1B = dc.EXppost.GetObject(ConnectionData.Schema, postTo.ParrentPost);
                                    // Cấp 1 gửi hàng về Cấp 2 khác phát.
                                    // T/hiện +- tiền ở 2 cấp 1. Update công nợ 2 bên
                                    // +- tiền ở cấp 2 bên gửi.
                                    // 1. Tính toán cước giao hàng
                                    int DeliveryFee = CalculatorFeeWithWeight((int)bill.BillWeight, provider.DeliveryInitPrice, provider.DeliveryInitWeight, provider.DeliveryStepWeight, provider.DeliveryStepPrice);
                                    if (DeliveryFee > 0)
                                    {
                                        // A. Gửi trả giao
                                        benGiaoTraBenGui = benGiaoTraBenGui - DeliveryFee;
                                        // Cấp 1 Gửi trả cấp 1 phát.
                                        GExpBalanceDetail syscash = new GExpBalanceDetail();
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postFrom.Id;
                                        syscash.CurrentExtPostFrom = postFrom.ValueBlance;
                                        syscash.AfterPostFrom = postFrom.ValueBlance - DeliveryFee;
                                        syscash.FK_ExtPostTo = postC1B.Id;
                                        syscash.CurrentExtPostTo = postC1B.ValueBlance;
                                        syscash.AfterPostTo = postC1B.ValueBlance + DeliveryFee;
                                        syscash.Value = DeliveryFee;
                                        syscash.CreateDate = currentDate.AddSeconds(1);
                                        syscash.CreateBy = UserId;
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "DELIVERY";
                                        syscash.Note = "Phí giao hàng [" + postFrom.TenDaiLy + "] trả cho [" + postC1B.TenDaiLy + "]. Cân nặng: " + bill.BillWeight.ToString("N0") + " Gr";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        postC1B.ValueBlance += syscash.Value;
                                        postFrom.ValueBlance -= syscash.Value;

                                        // Cấp 1 phát + hộ tiền cấp 2 phát (không thay đổi tiền cấp 1)
                                        syscash = new GExpBalanceDetail();
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postC1B.Id;
                                        syscash.CurrentExtPostFrom = postC1B.ValueBlance;
                                        syscash.AfterPostFrom = postC1B.ValueBlance;
                                        syscash.FK_ExtPostTo = postTo.Id;
                                        syscash.CurrentExtPostTo = postTo.ValueBlance;
                                        syscash.AfterPostTo = postTo.ValueBlance + DeliveryFee;
                                        syscash.Value = DeliveryFee;
                                        syscash.CreateDate = currentDate.AddSeconds(1);
                                        syscash.CreateBy = UserId;
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "DELIVERY";
                                        syscash.Note = "Phí giao hàng [" + postC1B.TenDaiLy + "] trả cho [" + postTo.TenDaiLy + "]. Cân nặng: " + bill.BillWeight.ToString("N0") + " Gr";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        // Cập nhật số tiền hiện tại
                                        postTo.ValueBlance += syscash.Value;

                                    }
                                    // 2. Tính toán cước trung chuyển
                                    int TransFee = CalculatorFeeWithWeight((int)bill.BillWeight, provider.TranInitPrice, provider.TranInitWeight, provider.TranStepWeight, provider.TranStepPrice);
                                    if (TransFee > 0)
                                    {
                                        // B. Gửi trả system
                                        GExpBalanceDetail syscash = new GExpBalanceDetail();
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postFrom.Id;
                                        syscash.CurrentExtPostFrom = postFrom.ValueBlance;
                                        syscash.AfterPostFrom = postFrom.ValueBlance - TransFee;
                                        syscash.FK_ExtPostTo = postSys.Id;
                                        syscash.CurrentExtPostTo = postSys.ValueBlance;
                                        syscash.AfterPostTo = postSys.ValueBlance + TransFee;
                                        syscash.Value = TransFee;
                                        syscash.CreateDate = currentDate.AddSeconds(2);
                                        syscash.CreateBy = "SYS";
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "TRANSIT";
                                        syscash.Note = "Phí trung chuyển [" + postFrom.TenDaiLy + "] trả cho [" + postSys.TenDaiLy + "]";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        // Cập nhật số tiền hiện tại
                                        postSys.ValueBlance += syscash.Value;
                                        postFrom.ValueBlance -= syscash.Value;
                                    }

                                    // 3. Tính cước hệ thống
                                    int SysFee = CalculatorFeeWithWeight((int)bill.BillWeight, provider.SysInitPrice, provider.SysInitWeight, provider.SysStepWeight, provider.SysStepPrice);
                                    if (SysFee > 0)
                                    {
                                        // C. Gửi trả system
                                        GExpBalanceDetail syscash = new GExpBalanceDetail();
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postFrom.Id;
                                        syscash.CurrentExtPostFrom = postFrom.ValueBlance;
                                        syscash.AfterPostFrom = postFrom.ValueBlance - SysFee;
                                        syscash.FK_ExtPostTo = postSys.Id;
                                        syscash.CurrentExtPostTo = postSys.ValueBlance;
                                        syscash.AfterPostTo = postSys.ValueBlance + SysFee;
                                        syscash.Value = SysFee;
                                        syscash.CreateDate = currentDate.AddSeconds(3);
                                        syscash.CreateBy = "SYS";
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "OPER";
                                        syscash.Note = "Phí hệ thống [" + postFrom.TenDaiLy + "] trả cho [" + postSys.TenDaiLy + "]";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        // Cập nhật số tiền hiện tại
                                        postSys.ValueBlance += syscash.Value;
                                        postFrom.ValueBlance -= syscash.Value;
                                    }
                                    // Thu hộ giao trả cho gửi
                                    decimal ThuHo = bill.COD;
                                    string temp = "Tiền thu hộ khách hàng ";
                                    if (bill.FK_PaymentType == "NTT")
                                    {
                                        ThuHo = bill.COD + bill.Freight;
                                        temp += "+ Phí nhận trả ";
                                    }
                                    temp = temp.Trim() + ". ";
                                    if (ThuHo > 0)
                                    {
                                        benGiaoTraBenGui = benGiaoTraBenGui + (int)ThuHo;

                                        // D. Giao trả cho gửi
                                        GExpBalanceDetail syscash = new GExpBalanceDetail();
                                        // Tiền COD Cấp 1 phát trả cho cấp 1 Gửi
                                        syscash = new GExpBalanceDetail();
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postC1B.Id;
                                        syscash.CurrentExtPostFrom = postC1B.ValueBlance;
                                        syscash.AfterPostFrom = postC1B.ValueBlance - (int)ThuHo;
                                        syscash.FK_ExtPostTo = postFrom.Id;
                                        syscash.CurrentExtPostTo = postFrom.ValueBlance;
                                        syscash.AfterPostTo = postFrom.ValueBlance + (int)ThuHo;
                                        syscash.Value = (int)ThuHo;
                                        syscash.CreateDate = currentDate.AddSeconds(4);
                                        syscash.CreateBy = UserId;
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "COD";
                                        syscash.Note = temp + "Đại lý [" + postC1B.TenDaiLy + "] trả cho [" + postFrom.TenDaiLy + "]";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        postFrom.ValueBlance += syscash.Value;
                                        postC1B.ValueBlance -= syscash.Value;

                                        // COD Cấp 2 phát trả cho Cấp 1 Phát
                                        syscash = new GExpBalanceDetail();
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postTo.Id;
                                        syscash.CurrentExtPostFrom = postTo.ValueBlance;
                                        syscash.AfterPostFrom = postTo.ValueBlance - (int)ThuHo;
                                        syscash.FK_ExtPostTo = postC1B.Id;
                                        syscash.CurrentExtPostTo = postC1B.ValueBlance;
                                        syscash.AfterPostTo = postC1B.ValueBlance;
                                        syscash.Value = (int)ThuHo;
                                        syscash.CreateDate = currentDate.AddSeconds(4);
                                        syscash.CreateBy = UserId;
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "COD";
                                        syscash.Note = temp + "Đại lý [" + postTo.TenDaiLy + "] trả cho [" + postC1B.TenDaiLy + "]";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        // Cập nhật số tiền hiện tại
                                        postTo.ValueBlance -= syscash.Value;

                                    }
                                    dc.EXppost.Update(ConnectionData.Schema, postTo);
                                    dc.EXppost.Update(ConnectionData.Schema, postC1B);
                                    dc.EXppost.Update(ConnectionData.Schema, postFrom);
                                    dc.EXppost.Update(ConnectionData.Schema, postSys);
                                    // Ghi nhận công nợ C1A_C2B
                                    if (benGiaoTraBenGui != 0)
                                    {
                                        GExpBalanceDetailPost CongNoCheck = dc.GExpbalancedetailpost.GetObjectCon(base.ConnectionData.Schema,
                                            "WHERE (FK_ExtPostFrom='" + postFrom.Id + "' AND FK_ExtPostTo='" + postC1B.Id + "') OR (FK_ExtPostFrom='" + postC1B.Id + "' AND FK_ExtPostTo='" + postFrom.Id + "') ORDER BY EpochTime DESC");
                                        if (CongNoCheck == null)
                                        {
                                            CongNoCheck = new GExpBalanceDetailPost();
                                            CongNoCheck.FK_ExtPostFrom = postFrom.Id;
                                            CongNoCheck.AfterPostFrom = 0;
                                            CongNoCheck.FK_ExtPostTo = postC1B.Id;
                                            CongNoCheck.AfterPostTo = 0;
                                        }

                                        GExpBalanceDetailPost CongNo = new GExpBalanceDetailPost();
                                        CongNo.Id = Guid.NewGuid().ToString();
                                        CongNo.CreateDate = currentDate;
                                        CongNo.BillCode = bill.BillCode;
                                        CongNo.CreateBy = UserId;
                                        CongNo.EpochTime = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;

                                        if (benGiaoTraBenGui > 0)
                                        {
                                            // Cấp 1 giao, trả tiền lại cho cấp 1 gửi
                                            CongNo.FK_ExtPostFrom = postC1B.Id;
                                            CongNo.FK_ExtPostTo = postFrom.Id;

                                            // Check Current Value From
                                            if (CongNoCheck.FK_ExtPostFrom == CongNo.FK_ExtPostFrom)
                                            {
                                                CongNo.CurrentExtPostFrom = CongNoCheck.AfterPostFrom;
                                            }
                                            else
                                            {
                                                CongNo.CurrentExtPostFrom = CongNoCheck.AfterPostTo;
                                            }
                                            // Check Current Value To
                                            if (CongNoCheck.FK_ExtPostFrom == CongNo.FK_ExtPostTo)
                                            {
                                                CongNo.CurrentExtPostTo = CongNoCheck.AfterPostFrom;
                                            }
                                            else
                                            {
                                                CongNo.CurrentExtPostTo = CongNoCheck.AfterPostTo;
                                            }

                                            CongNo.Value = Math.Abs(benGiaoTraBenGui);

                                            CongNo.AfterPostFrom = CongNo.CurrentExtPostFrom - CongNo.Value;
                                            CongNo.AfterPostTo = CongNo.CurrentExtPostTo + CongNo.Value;
                                            CongNo.Type = "TO => FROM";
                                            CongNo.Note = postTo.TenDaiLy + " TRẢ " + postFrom.TenDaiLy;

                                        }
                                        else
                                        {
                                            // Cấp 1 gửi trả tiền cho cấp 1 giao
                                            CongNo.FK_ExtPostFrom = postFrom.Id;
                                            CongNo.FK_ExtPostTo = postC1B.Id;

                                            // Check Current Value From
                                            if (CongNoCheck.FK_ExtPostFrom == CongNo.FK_ExtPostFrom)
                                            {
                                                CongNo.CurrentExtPostFrom = CongNoCheck.AfterPostFrom;
                                            }
                                            else
                                            {
                                                CongNo.CurrentExtPostFrom = CongNoCheck.AfterPostTo;
                                            }
                                            // Check Current Value To
                                            if (CongNoCheck.FK_ExtPostFrom == CongNo.FK_ExtPostTo)
                                            {
                                                CongNo.CurrentExtPostTo = CongNoCheck.AfterPostFrom;
                                            }
                                            else
                                            {
                                                CongNo.CurrentExtPostTo = CongNoCheck.AfterPostTo;
                                            }

                                            CongNo.Value = Math.Abs(benGiaoTraBenGui);

                                            CongNo.AfterPostFrom = CongNo.CurrentExtPostFrom - CongNo.Value;
                                            CongNo.AfterPostTo = CongNo.CurrentExtPostTo + CongNo.Value;

                                            CongNo.Type = "FROM => TO";
                                            CongNo.Note = postFrom.TenDaiLy + " TRẢ " + postTo.TenDaiLy;
                                        }
                                        dc.GExpbalancedetailpost.InsertOnSubmit(base.ConnectionData.Schema, CongNo);
                                    }
                                }
                                break;
                            case "C2A_C1B":
                                {
                                    // Cấp 2 gửi hàng về Cấp 1 khác phát.
                                    // T/hiện +- tiền ở 2 cấp 1. Update công nợ 2 bên
                                    // +- tiền ở cấp 2 bên gửi.
                                    // 1. Tính toán cước giao hàng
                                    int benGiaoTraBenGui = 0;
                                    ExpPost postC1A = dc.EXppost.GetObject(ConnectionData.Schema, postFrom.ParrentPost);
                                    int DeliveryFee = CalculatorFeeWithWeight((int)bill.BillWeight, provider.DeliveryInitPrice, provider.DeliveryInitWeight, provider.DeliveryStepWeight, provider.DeliveryStepPrice);
                                    if (DeliveryFee > 0)
                                    {
                                        // A. Gửi trả giao
                                        benGiaoTraBenGui = benGiaoTraBenGui - DeliveryFee;
                                        GExpBalanceDetail syscash = new GExpBalanceDetail();
                                        // Cấp 1 gửi trả tiền gửi hàng cho cấp 1 phát
                                        syscash = new GExpBalanceDetail();
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postC1A.Id;
                                        syscash.CurrentExtPostFrom = postC1A.ValueBlance;
                                        syscash.AfterPostFrom = postC1A.ValueBlance - DeliveryFee;
                                        syscash.FK_ExtPostTo = postTo.Id;
                                        syscash.CurrentExtPostTo = postTo.ValueBlance;
                                        syscash.AfterPostTo = postTo.ValueBlance + DeliveryFee;
                                        syscash.Value = DeliveryFee;
                                        syscash.CreateDate = currentDate.AddSeconds(1);
                                        syscash.CreateBy = UserId;
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "DELIVERY";
                                        syscash.Note = "Phí giao hàng [" + postC1A.TenDaiLy + "] trả cho [" + postTo.TenDaiLy + "]. Cân nặng: " + bill.BillWeight.ToString("N0") + " Gr";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        // Cập nhật số tiền hiện tại
                                        postTo.ValueBlance += syscash.Value;
                                        postC1A.ValueBlance -= syscash.Value;

                                        // Cấp 2 gửi trả tiền gửi hàng cho cấp 1 gửi
                                        syscash = new GExpBalanceDetail();
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postFrom.Id;
                                        syscash.CurrentExtPostFrom = postFrom.ValueBlance;
                                        syscash.AfterPostFrom = postFrom.ValueBlance - DeliveryFee;
                                        syscash.FK_ExtPostTo = postC1A.Id;
                                        syscash.CurrentExtPostTo = postC1A.ValueBlance;
                                        syscash.AfterPostTo = postC1A.ValueBlance;
                                        syscash.Value = DeliveryFee;
                                        syscash.CreateDate = currentDate.AddSeconds(1);
                                        syscash.CreateBy = UserId;
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "DELIVERY";
                                        syscash.Note = "Phí giao hàng [" + postFrom.TenDaiLy + "] trả cho [" + postC1A.TenDaiLy + "]. Cân nặng: " + bill.BillWeight.ToString("N0") + " Gr";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        // Cập nhật số tiền hiện tại
                                        postFrom.ValueBlance -= syscash.Value;

                                    }
                                    // 2. Tính toán cước trung chuyển
                                    int TransFee = CalculatorFeeWithWeight((int)bill.BillWeight, provider.TranInitPrice, provider.TranInitWeight, provider.TranStepWeight, provider.TranStepPrice);
                                    if (TransFee > 0)
                                    {
                                        // B. Gửi trả system
                                        GExpBalanceDetail syscash = new GExpBalanceDetail();
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postC1A.Id;
                                        syscash.CurrentExtPostFrom = postC1A.ValueBlance;
                                        syscash.AfterPostFrom = postC1A.ValueBlance - TransFee;
                                        syscash.FK_ExtPostTo = postSys.Id;
                                        syscash.CurrentExtPostTo = postSys.ValueBlance;
                                        syscash.AfterPostTo = postSys.ValueBlance + TransFee;
                                        syscash.Value = TransFee;
                                        syscash.CreateDate = currentDate.AddSeconds(2);
                                        syscash.CreateBy = "SYS";
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "TRANSIT";
                                        syscash.Note = "Phí trung chuyển [" + postC1A.TenDaiLy + "] trả cho [" + postSys.TenDaiLy + "]";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        postSys.ValueBlance += syscash.Value;
                                        postC1A.ValueBlance -= syscash.Value;

                                        // Thêm dòng detail cho C1A
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postFrom.Id;
                                        syscash.CurrentExtPostFrom = postFrom.ValueBlance;
                                        syscash.AfterPostFrom = postFrom.ValueBlance - TransFee;
                                        syscash.FK_ExtPostTo = postC1A.Id;
                                        syscash.CurrentExtPostTo = postC1A.ValueBlance;
                                        syscash.AfterPostTo = postC1A.ValueBlance;
                                        syscash.Value = TransFee;
                                        syscash.CreateDate = currentDate.AddSeconds(2);
                                        syscash.CreateBy = "SYS";
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "TRANSIT";
                                        syscash.Note = "Phí trung chuyển [" + postFrom.TenDaiLy + "] trả cho [" + postC1A.TenDaiLy + "]";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        // Cập nhật số tiền hiện tại
                                        postFrom.ValueBlance -= syscash.Value;

                                    }

                                    // 3. Tính cước hệ thống
                                    int SysFee = CalculatorFeeWithWeight((int)bill.BillWeight, provider.SysInitPrice, provider.SysInitWeight, provider.SysStepWeight, provider.SysStepPrice);
                                    if (SysFee > 0)
                                    {
                                        // C. Gửi trả system
                                        GExpBalanceDetail syscash = new GExpBalanceDetail();
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postC1A.Id;
                                        syscash.CurrentExtPostFrom = postC1A.ValueBlance;
                                        syscash.AfterPostFrom = postC1A.ValueBlance - SysFee;
                                        syscash.FK_ExtPostTo = postSys.Id;
                                        syscash.CurrentExtPostTo = postSys.ValueBlance;
                                        syscash.AfterPostTo = postSys.ValueBlance + SysFee;
                                        syscash.Value = SysFee;
                                        syscash.CreateDate = currentDate.AddSeconds(2);
                                        syscash.CreateBy = "SYS";
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "TRANSIT";
                                        syscash.Note = "Phí trung chuyển [" + postC1A.TenDaiLy + "] trả cho [" + postSys.TenDaiLy + "]";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        postSys.ValueBlance += syscash.Value;
                                        postC1A.ValueBlance -= syscash.Value;

                                        // Thêm dòng detail cho C1A
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postFrom.Id;
                                        syscash.CurrentExtPostFrom = postFrom.ValueBlance;
                                        syscash.AfterPostFrom = postFrom.ValueBlance - SysFee;
                                        syscash.FK_ExtPostTo = postC1A.Id;
                                        syscash.CurrentExtPostTo = postC1A.ValueBlance;
                                        syscash.AfterPostTo = postC1A.ValueBlance;
                                        syscash.Value = SysFee;
                                        syscash.CreateDate = currentDate.AddSeconds(2);
                                        syscash.CreateBy = "SYS";
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "TRANSIT";
                                        syscash.Note = "Phí trung chuyển [" + postFrom.TenDaiLy + "] trả cho [" + postC1A.TenDaiLy + "]";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        // Cập nhật số tiền hiện tại
                                        postFrom.ValueBlance -= syscash.Value;
                                    }
                                    // Thu hộ giao trả cho gửi
                                    decimal ThuHo = bill.COD;
                                    string temp = "Tiền thu hộ khách hàng ";
                                    if (bill.FK_PaymentType == "NTT")
                                    {
                                        ThuHo = bill.COD + bill.Freight;
                                        temp += "+ Phí nhận trả ";
                                    }
                                    temp = temp.Trim() + ". ";
                                    if (ThuHo > 0)
                                    {
                                        benGiaoTraBenGui = benGiaoTraBenGui + (int)ThuHo;
                                        // Cấp 1 phát trả tiền thu hộ cho cấp 1 gửi
                                        GExpBalanceDetail syscash = new GExpBalanceDetail();
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postTo.Id;
                                        syscash.CurrentExtPostFrom = postTo.ValueBlance;
                                        syscash.AfterPostFrom = postTo.ValueBlance - (int)ThuHo;
                                        syscash.FK_ExtPostTo = postC1A.Id;
                                        syscash.CurrentExtPostTo = postC1A.ValueBlance;
                                        syscash.AfterPostTo = postC1A.ValueBlance + (int)ThuHo;
                                        syscash.Value = (int)ThuHo;
                                        syscash.CreateDate = currentDate.AddSeconds(4);
                                        syscash.CreateBy = UserId;
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "COD";
                                        syscash.Note = temp + "Đại lý [" + postTo.TenDaiLy + "] trả cho [" + postC1A.TenDaiLy + "]";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        postTo.ValueBlance -= syscash.Value;
                                        postC1A.ValueBlance += syscash.Value;
                                        // Cấp 1 gửi hoàn trả tiền thu hộ lại cho cấp 2 gửi
                                        syscash = new GExpBalanceDetail();
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postC1A.Id;
                                        syscash.CurrentExtPostFrom = postC1A.ValueBlance;
                                        syscash.AfterPostFrom = postC1A.ValueBlance;
                                        syscash.FK_ExtPostTo = postFrom.Id;
                                        syscash.CurrentExtPostTo = postFrom.ValueBlance;
                                        syscash.AfterPostTo = postFrom.ValueBlance + (int)ThuHo;
                                        syscash.Value = (int)ThuHo;
                                        syscash.CreateDate = currentDate.AddSeconds(4);
                                        syscash.CreateBy = UserId;
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "COD";
                                        syscash.Note = temp + "Đại lý [" + postC1A.TenDaiLy + "] trả cho [" + postFrom.TenDaiLy + "]";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        // Cập nhật số tiền hiện tại
                                        postFrom.ValueBlance += syscash.Value;

                                    }
                                    dc.EXppost.Update(ConnectionData.Schema, postTo);
                                    dc.EXppost.Update(ConnectionData.Schema, postC1A);
                                    dc.EXppost.Update(ConnectionData.Schema, postFrom);
                                    dc.EXppost.Update(ConnectionData.Schema, postSys);
                                    // Ghi nhận công nợ
                                    //C2A_C1B
                                    if (benGiaoTraBenGui != 0)
                                    {
                                        GExpBalanceDetailPost CongNoCheck = dc.GExpbalancedetailpost.GetObjectCon(base.ConnectionData.Schema,
                                            "WHERE (FK_ExtPostFrom='" + postC1A.Id + "' AND FK_ExtPostTo='" + postTo.Id + "') OR (FK_ExtPostFrom='" + postTo.Id + "' AND FK_ExtPostTo='" + postC1A.Id + "') ORDER BY EpochTime DESC");
                                        if (CongNoCheck == null)
                                        {
                                            CongNoCheck = new GExpBalanceDetailPost();
                                            CongNoCheck.FK_ExtPostFrom = postC1A.Id;
                                            CongNoCheck.AfterPostFrom = 0;
                                            CongNoCheck.FK_ExtPostTo = postTo.Id;
                                            CongNoCheck.AfterPostTo = 0;
                                        }

                                        GExpBalanceDetailPost CongNo = new GExpBalanceDetailPost();
                                        CongNo.Id = Guid.NewGuid().ToString();
                                        CongNo.CreateDate = currentDate;
                                        CongNo.BillCode = bill.BillCode;
                                        CongNo.CreateBy = UserId;
                                        CongNo.EpochTime = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;

                                        if (benGiaoTraBenGui > 0)
                                        {
                                            // Cấp 1 giao, trả tiền lại cho cấp 1 gửi
                                            CongNo.FK_ExtPostFrom = postTo.Id;
                                            CongNo.FK_ExtPostTo = postC1A.Id;

                                            // Check Current Value From
                                            if (CongNoCheck.FK_ExtPostFrom == CongNo.FK_ExtPostFrom)
                                            {
                                                CongNo.CurrentExtPostFrom = CongNoCheck.AfterPostFrom;
                                            }
                                            else
                                            {
                                                CongNo.CurrentExtPostFrom = CongNoCheck.AfterPostTo;
                                            }
                                            // Check Current Value To
                                            if (CongNoCheck.FK_ExtPostFrom == CongNo.FK_ExtPostTo)
                                            {
                                                CongNo.CurrentExtPostTo = CongNoCheck.AfterPostFrom;
                                            }
                                            else
                                            {
                                                CongNo.CurrentExtPostTo = CongNoCheck.AfterPostTo;
                                            }

                                            CongNo.Value = Math.Abs(benGiaoTraBenGui);

                                            CongNo.AfterPostFrom = CongNo.CurrentExtPostFrom - CongNo.Value;
                                            CongNo.AfterPostTo = CongNo.CurrentExtPostTo + CongNo.Value;
                                            CongNo.Type = "TO => FROM";
                                            CongNo.Note = postTo.TenDaiLy + " TRẢ " + postFrom.TenDaiLy;

                                        }
                                        else
                                        {
                                            // Cấp 1 gửi trả tiền cho cấp 1 giao
                                            CongNo.FK_ExtPostFrom = postC1A.Id;
                                            CongNo.FK_ExtPostTo = postTo.Id;

                                            // Check Current Value From
                                            if (CongNoCheck.FK_ExtPostFrom == CongNo.FK_ExtPostFrom)
                                            {
                                                CongNo.CurrentExtPostFrom = CongNoCheck.AfterPostFrom;
                                            }
                                            else
                                            {
                                                CongNo.CurrentExtPostFrom = CongNoCheck.AfterPostTo;
                                            }
                                            // Check Current Value To
                                            if (CongNoCheck.FK_ExtPostFrom == CongNo.FK_ExtPostTo)
                                            {
                                                CongNo.CurrentExtPostTo = CongNoCheck.AfterPostFrom;
                                            }
                                            else
                                            {
                                                CongNo.CurrentExtPostTo = CongNoCheck.AfterPostTo;
                                            }

                                            CongNo.Value = Math.Abs(benGiaoTraBenGui);

                                            CongNo.AfterPostFrom = CongNo.CurrentExtPostFrom - CongNo.Value;
                                            CongNo.AfterPostTo = CongNo.CurrentExtPostTo + CongNo.Value;

                                            CongNo.Type = "FROM => TO";
                                            CongNo.Note = postFrom.TenDaiLy + " TRẢ " + postTo.TenDaiLy;
                                        }
                                        dc.GExpbalancedetailpost.InsertOnSubmit(base.ConnectionData.Schema, CongNo);
                                    }
                                }
                                break;
                            case "C2A_C2B":
                                {
                                    // Cấp 2 gửi hàng về cấp 2 khác phát
                                    // T/hiện +- tiền ở 2 cấp 1. Update công nợ 2 bên
                                    // +- tiền ở cấp 2 bên gửi và bên phát.
                                    // 1. Tính toán cước giao hàng
                                    int benGiaoTraBenGui = 0;
                                    ExpPost postC1A = dc.EXppost.GetObject(ConnectionData.Schema, postFrom.ParrentPost); // Gửi
                                    ExpPost postC1B = dc.EXppost.GetObject(ConnectionData.Schema, postTo.ParrentPost);// Phát
                                    int DeliveryFee = CalculatorFeeWithWeight((int)bill.BillWeight, provider.DeliveryInitPrice, provider.DeliveryInitWeight, provider.DeliveryStepWeight, provider.DeliveryStepPrice);
                                    if (DeliveryFee > 0)
                                    {
                                        // A. Gửi trả giao
                                        benGiaoTraBenGui = benGiaoTraBenGui - DeliveryFee;
                                        //Cấp 1 gửi trả tiền cho cấp 1 phát
                                        GExpBalanceDetail syscash = new GExpBalanceDetail();
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postC1A.Id;
                                        syscash.CurrentExtPostFrom = postC1A.ValueBlance;
                                        syscash.AfterPostFrom = postC1A.ValueBlance - DeliveryFee;
                                        syscash.FK_ExtPostTo = postC1B.Id;
                                        syscash.CurrentExtPostTo = postC1B.ValueBlance;
                                        syscash.AfterPostTo = postC1B.ValueBlance + DeliveryFee;
                                        syscash.Value = DeliveryFee;
                                        syscash.CreateDate = currentDate.AddSeconds(1);
                                        syscash.CreateBy = UserId;
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "DELIVERY";
                                        syscash.Note = "Phí giao hàng [" + postC1A.TenDaiLy + "] trả cho [" + postC1B.TenDaiLy + "]. Cân nặng: " + bill.BillWeight.ToString("N0") + " Gr";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        postC1B.ValueBlance += syscash.Value;
                                        postC1A.ValueBlance -= syscash.Value;
                                        // Cấp 2 gửi trả tiền phát hàng lại cho cấp 1 gửi
                                        syscash = new GExpBalanceDetail();
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postFrom.Id;
                                        syscash.CurrentExtPostFrom = postFrom.ValueBlance;
                                        syscash.AfterPostFrom = postFrom.ValueBlance - DeliveryFee;
                                        syscash.FK_ExtPostTo = postC1A.Id;
                                        syscash.CurrentExtPostTo = postC1A.ValueBlance;
                                        syscash.AfterPostTo = postC1A.ValueBlance;
                                        syscash.Value = DeliveryFee;
                                        syscash.CreateDate = currentDate.AddSeconds(2);
                                        syscash.CreateBy = UserId;
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "DELIVERY";
                                        syscash.Note = "Phí giao hàng [" + postFrom.TenDaiLy + "] trả cho [" + postC1A.TenDaiLy + "]. Cân nặng: " + bill.BillWeight.ToString("N0") + " Gr";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        postFrom.ValueBlance -= syscash.Value;
                                        // Cấp 1 phát trả tiền phát hàng lại cho cấp 2 phát
                                        syscash = new GExpBalanceDetail();
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postC1B.Id;
                                        syscash.CurrentExtPostFrom = postC1B.ValueBlance;
                                        syscash.AfterPostFrom = postC1B.ValueBlance;
                                        syscash.FK_ExtPostTo = postTo.Id;
                                        syscash.CurrentExtPostTo = postTo.ValueBlance;
                                        syscash.AfterPostTo = postTo.ValueBlance + DeliveryFee;
                                        syscash.Value = DeliveryFee;
                                        syscash.CreateDate = currentDate.AddSeconds(3);
                                        syscash.CreateBy = UserId;
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "DELIVERY";
                                        syscash.Note = "Phí giao hàng [" + postC1B.TenDaiLy + "] trả cho [" + postTo.TenDaiLy + "]. Cân nặng: " + bill.BillWeight.ToString("N0") + " Gr";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        // Cập nhật số tiền hiện tại
                                        postTo.ValueBlance += syscash.Value;
                                    }
                                    // 2. Tính toán cước trung chuyển
                                    int TransFee = CalculatorFeeWithWeight((int)bill.BillWeight, provider.TranInitPrice, provider.TranInitWeight, provider.TranStepWeight, provider.TranStepPrice);
                                    if (TransFee > 0)
                                    {
                                        // B. Gửi trả system
                                        GExpBalanceDetail syscash = new GExpBalanceDetail();
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postC1A.Id;
                                        syscash.CurrentExtPostFrom = postC1A.ValueBlance;
                                        syscash.AfterPostFrom = postC1A.ValueBlance - TransFee;
                                        syscash.FK_ExtPostTo = postSys.Id;
                                        syscash.CurrentExtPostTo = postSys.ValueBlance;
                                        syscash.AfterPostTo = postSys.ValueBlance + TransFee;
                                        syscash.Value = TransFee;
                                        syscash.CreateDate = currentDate.AddSeconds(2);
                                        syscash.CreateBy = "SYS";
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "TRANSIT";
                                        syscash.Note = "Phí trung chuyển [" + postC1A.TenDaiLy + "] trả cho [" + postSys.TenDaiLy + "]";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        // Cập nhật số tiền hiện tại
                                        postC1A.ValueBlance -= syscash.Value;
                                        postSys.ValueBlance += syscash.Value;
                                        // Thêm dòng detail cho C1A
                                        syscash = new GExpBalanceDetail();
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postFrom.Id;
                                        syscash.CurrentExtPostFrom = postFrom.ValueBlance;
                                        syscash.AfterPostFrom = postFrom.ValueBlance - TransFee;
                                        syscash.FK_ExtPostTo = postC1A.Id;
                                        syscash.CurrentExtPostTo = postC1A.ValueBlance;
                                        syscash.AfterPostTo = postC1A.ValueBlance;
                                        syscash.Value = TransFee;
                                        syscash.CreateDate = currentDate.AddSeconds(2);
                                        syscash.CreateBy = "SYS";
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "TRANSIT";
                                        syscash.Note = "Phí trung chuyển [" + postFrom.TenDaiLy + "] trả cho [" + postC1A.TenDaiLy + "]";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        // Cập nhật số tiền hiện tại
                                        postFrom.ValueBlance -= syscash.Value;

                                    }
                                    // 3. Tính cước hệ thống
                                    int SysFee = CalculatorFeeWithWeight((int)bill.BillWeight, provider.SysInitPrice, provider.SysInitWeight, provider.SysStepWeight, provider.SysStepPrice);
                                    if (SysFee > 0)
                                    {
                                        // C. Gửi trả system
                                        GExpBalanceDetail syscash = new GExpBalanceDetail();
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postC1A.Id;
                                        syscash.CurrentExtPostFrom = postC1A.ValueBlance;
                                        syscash.AfterPostFrom = postC1A.ValueBlance - SysFee;
                                        syscash.FK_ExtPostTo = postSys.Id;
                                        syscash.CurrentExtPostTo = postSys.ValueBlance;
                                        syscash.AfterPostTo = postSys.ValueBlance + SysFee;
                                        syscash.Value = SysFee;
                                        syscash.CreateDate = currentDate.AddSeconds(2);
                                        syscash.CreateBy = "SYS";
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "TRANSIT";
                                        syscash.Note = "Phí trung chuyển [" + postC1A.TenDaiLy + "] trả cho [" + postSys.TenDaiLy + "]";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        // Cập nhật số tiền hiện tại
                                        postC1A.ValueBlance -= syscash.Value;
                                        postSys.ValueBlance += syscash.Value;
                                        // Thêm dòng detail cho C1A
                                        syscash = new GExpBalanceDetail();
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postFrom.Id;
                                        syscash.CurrentExtPostFrom = postFrom.ValueBlance;
                                        syscash.AfterPostFrom = postFrom.ValueBlance - SysFee;
                                        syscash.FK_ExtPostTo = postC1A.Id;
                                        syscash.CurrentExtPostTo = postC1A.ValueBlance;
                                        syscash.AfterPostTo = postC1A.ValueBlance;
                                        syscash.Value = SysFee;
                                        syscash.CreateDate = currentDate.AddSeconds(2);
                                        syscash.CreateBy = "SYS";
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "TRANSIT";
                                        syscash.Note = "Phí trung chuyển [" + postFrom.TenDaiLy + "] trả cho [" + postC1A.TenDaiLy + "]";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        // Cập nhật số tiền hiện tại
                                        postFrom.ValueBlance -= syscash.Value;
                                    }
                                    // Thu hộ giao trả cho gửi
                                    decimal ThuHo = bill.COD;
                                    string temp = "Tiền thu hộ khách hàng ";
                                    if (bill.FK_PaymentType == "NTT")
                                    {
                                        ThuHo = bill.COD + bill.Freight;
                                        temp += "+ Phí nhận trả ";
                                    }
                                    temp = temp.Trim() + ". ";
                                    if (ThuHo > 0)
                                    {
                                        benGiaoTraBenGui = benGiaoTraBenGui + (int)ThuHo;
                                        // Cấp 1 giao trả lại cho cấp 1 gửi
                                        GExpBalanceDetail syscash = new GExpBalanceDetail();
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postC1B.Id;
                                        syscash.CurrentExtPostFrom = postC1B.ValueBlance;
                                        syscash.AfterPostFrom = postC1B.ValueBlance - (int)ThuHo;
                                        syscash.FK_ExtPostTo = postC1A.Id;
                                        syscash.CurrentExtPostTo = postC1A.ValueBlance;
                                        syscash.AfterPostTo = postC1A.ValueBlance + (int)ThuHo;
                                        syscash.Value = (int)ThuHo;
                                        syscash.CreateDate = currentDate.AddSeconds(4);
                                        syscash.CreateBy = UserId;
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "COD";
                                        syscash.Note = temp + "Đại lý [" + postC1B.TenDaiLy + "] trả cho [" + postC1A.TenDaiLy + "]";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        // Cập nhật số tiền hiện tại
                                        postC1A.ValueBlance += syscash.Value;
                                        postC1B.ValueBlance -= syscash.Value;
                                        // Cấp 2 giao trả lại cấp 1 giao
                                        syscash = new GExpBalanceDetail();
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postTo.Id;
                                        syscash.CurrentExtPostFrom = postTo.ValueBlance;
                                        syscash.AfterPostFrom = postTo.ValueBlance - (int)ThuHo;
                                        syscash.FK_ExtPostTo = postC1B.Id;
                                        syscash.CurrentExtPostTo = postC1B.ValueBlance;
                                        syscash.AfterPostTo = postC1B.ValueBlance;
                                        syscash.Value = (int)ThuHo;
                                        syscash.CreateDate = currentDate.AddSeconds(4);
                                        syscash.CreateBy = UserId;
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "COD";
                                        syscash.Note = temp + "Đại lý [" + postTo.TenDaiLy + "] trả cho [" + postC1B.TenDaiLy + "]";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        // Cập nhật số tiền hiện tại
                                        postTo.ValueBlance -= syscash.Value;
                                        // Cấp 1 gửi, trả tiền thu hộ lại cho cấp 2
                                        syscash = new GExpBalanceDetail();
                                        syscash.Id = Guid.NewGuid().ToString();
                                        syscash.FK_ExtPostFrom = postC1A.Id;
                                        syscash.CurrentExtPostFrom = postC1A.ValueBlance;
                                        syscash.AfterPostFrom = postC1A.ValueBlance;
                                        syscash.FK_ExtPostTo = postFrom.Id;
                                        syscash.CurrentExtPostTo = postFrom.ValueBlance;
                                        syscash.AfterPostTo = postFrom.ValueBlance + (int)ThuHo;
                                        syscash.Value = (int)ThuHo;
                                        syscash.CreateDate = currentDate.AddSeconds(4);
                                        syscash.CreateBy = UserId;
                                        syscash.BillCode = bill.BillCode;
                                        syscash.Type = "COD";
                                        syscash.Note = temp + "Đại lý [" + postC1A.TenDaiLy + "] trả cho [" + postFrom.TenDaiLy + "]";
                                        syscash.IsDelete = false;
                                        dc.GExpbalancedetail.InsertOnSubmit(base.ConnectionData.Schema, syscash);
                                        // Cập nhật số tiền hiện tại
                                        postFrom.ValueBlance += syscash.Value;
                                    }
                                    dc.EXppost.Update(ConnectionData.Schema, postTo);
                                    dc.EXppost.Update(ConnectionData.Schema, postC1A);
                                    dc.EXppost.Update(ConnectionData.Schema, postC1B);
                                    dc.EXppost.Update(ConnectionData.Schema, postFrom);
                                    dc.EXppost.Update(ConnectionData.Schema, postSys);
                                    // Ghi nhận công nợ C2A_C2B
                                    if (benGiaoTraBenGui != 0)
                                    {
                                        GExpBalanceDetailPost CongNoCheck = dc.GExpbalancedetailpost.GetObjectCon(base.ConnectionData.Schema,
                                            "WHERE (FK_ExtPostFrom='" + postC1A.Id + "' AND FK_ExtPostTo='" + postC1B.Id + "') OR (FK_ExtPostFrom='" + postC1B.Id + "' AND FK_ExtPostTo='" + postC1A.Id + "') ORDER BY EpochTime DESC");
                                        if (CongNoCheck == null)
                                        {
                                            CongNoCheck = new GExpBalanceDetailPost();
                                            CongNoCheck.FK_ExtPostFrom = postC1A.Id;
                                            CongNoCheck.AfterPostFrom = 0;
                                            CongNoCheck.FK_ExtPostTo = postC1B.Id;
                                            CongNoCheck.AfterPostTo = 0;
                                        }

                                        GExpBalanceDetailPost CongNo = new GExpBalanceDetailPost();
                                        CongNo.Id = Guid.NewGuid().ToString();
                                        CongNo.CreateDate = currentDate;
                                        CongNo.BillCode = bill.BillCode;
                                        CongNo.CreateBy = UserId;
                                        CongNo.EpochTime = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;

                                        if (benGiaoTraBenGui > 0)
                                        {
                                            // Cấp 1 giao, trả tiền lại cho cấp 1 gửi
                                            CongNo.FK_ExtPostFrom = postC1B.Id;
                                            CongNo.FK_ExtPostTo = postC1A.Id;

                                            // Check Current Value From
                                            if (CongNoCheck.FK_ExtPostFrom == CongNo.FK_ExtPostFrom)
                                            {
                                                CongNo.CurrentExtPostFrom = CongNoCheck.AfterPostFrom;
                                            }
                                            else
                                            {
                                                CongNo.CurrentExtPostFrom = CongNoCheck.AfterPostTo;
                                            }
                                            // Check Current Value To
                                            if (CongNoCheck.FK_ExtPostFrom == CongNo.FK_ExtPostTo)
                                            {
                                                CongNo.CurrentExtPostTo = CongNoCheck.AfterPostFrom;
                                            }
                                            else
                                            {
                                                CongNo.CurrentExtPostTo = CongNoCheck.AfterPostTo;
                                            }

                                            CongNo.Value = Math.Abs(benGiaoTraBenGui);

                                            CongNo.AfterPostFrom = CongNo.CurrentExtPostFrom - CongNo.Value;
                                            CongNo.AfterPostTo = CongNo.CurrentExtPostTo + CongNo.Value;
                                            CongNo.Type = "TO => FROM";
                                            CongNo.Note = postTo.TenDaiLy + " TRẢ " + postFrom.TenDaiLy;

                                        }
                                        else
                                        {
                                            // Cấp 1 gửi trả tiền cho cấp 1 giao
                                            CongNo.FK_ExtPostFrom = postC1A.Id;
                                            CongNo.FK_ExtPostTo = postC1B.Id;

                                            // Check Current Value From
                                            if (CongNoCheck.FK_ExtPostFrom == CongNo.FK_ExtPostFrom)
                                            {
                                                CongNo.CurrentExtPostFrom = CongNoCheck.AfterPostFrom;
                                            }
                                            else
                                            {
                                                CongNo.CurrentExtPostFrom = CongNoCheck.AfterPostTo;
                                            }
                                            // Check Current Value To
                                            if (CongNoCheck.FK_ExtPostFrom == CongNo.FK_ExtPostTo)
                                            {
                                                CongNo.CurrentExtPostTo = CongNoCheck.AfterPostFrom;
                                            }
                                            else
                                            {
                                                CongNo.CurrentExtPostTo = CongNoCheck.AfterPostTo;
                                            }

                                            CongNo.Value = Math.Abs(benGiaoTraBenGui);

                                            CongNo.AfterPostFrom = CongNo.CurrentExtPostFrom - CongNo.Value;
                                            CongNo.AfterPostTo = CongNo.CurrentExtPostTo + CongNo.Value;

                                            CongNo.Type = "FROM => TO";
                                            CongNo.Note = postFrom.TenDaiLy + " TRẢ " + postTo.TenDaiLy;
                                        }
                                        dc.GExpbalancedetailpost.InsertOnSubmit(base.ConnectionData.Schema, CongNo);
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    // Lưu toàn bộ dữ liệu thay đổi vào database
                    dc.SubmitChanges();
                    return string.Empty;
                }
                else
                {
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public string DelSigned(string Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                DateTime currentDate = dc.CurrentTime();
                GExpScanSign scan = dc.GExpscansign.GetObject(base.ConnectionData.Schema, Id);
                if (scan != null)
                {

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
            return string.Empty;
        }
        /// <summary>
        /// Quét hàng đến
        /// </summary>
        /// <param name="BillCode">Mã đơn hàng</param>
        /// <param name="UserId">Mã người quét</param>
        /// <param name="FullName">Tên người quét</param>
        /// <param name="phone">Số điện thoại người quét</param>
        /// <param name="scanPost">Bưu cục quét</param>
        /// <param name="address">Địa chỉ bưu cục quét</param>
        /// <returns></returns>
        public string AddCome(string BillCode, string UserId, string FullName, string phone, string scanPost, string address)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                DateTime currentDate = dc.CurrentTime();
                GExpBill bill = dc.GExpbill.GetObject(base.ConnectionData.Schema, BillCode);
                if (bill != null)
                {
                    if (bill.BillStatus == 6 || bill.BillStatus == 8)
                    {
                        return "Đơn hàng đã được ký nhận hoặc hoàn trả.";
                    }
                    GExpProvider provider = dc.GExpprovider.GetObject(base.ConnectionData.Schema, bill.FK_ProviderAccount);
                    if (provider.RunMode == 1)
                    {
                        return "Loại kiện không phải là kiện vận tải / kiện nội mạng / kiện không kết nối api nên không thể quét hàng đến!";
                    }
                    // Check đã scan chưa
                    GExpScanCome lastCome = dc.GExpscancome.GetObjectCon(base.ConnectionData.Schema, "WHERE FK_Post=@FK_Post AND BillCode=@BillCode AND CreateDate >='" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", currentDate.AddMinutes(-15)) + "'"
                        , "@FK_Post", scanPost
                        , "@BillCode", BillCode);
                    if (lastCome != null)
                    {
                        return "Dữ liệu quét đến đã tồn tại, vui lòng kiểm tra lại!";
                    }
                    // Thêm vào hành trình
                    GExpScanCome scan = new GExpScanCome();
                    scan.Id = Guid.NewGuid().ToString();
                    scan.FK_Post = scanPost;
                    scan.FK_Account = UserId;
                    scan.BillCode = BillCode;
                    scan.CreateDate = currentDate;
                    scan.Note = "[" + FullName + " SĐT: " + phone + "] - Quét nhận hàng đến [" + scanPost + " - " + address + "]";
                    // Kiểm tra last nếu không có thì báo lỗi
                    string frompost = string.Empty;
                    GExpScanSend lastSend = dc.GExpscansend.GetObjectCon(base.ConnectionData.Schema, "WHERE BillCode=@BillCode AND FK_SendToPost=@FK_SendToPost ORDER BY CreateDate DESC"
                        , "@BillCode", BillCode
                        , "@FK_SendToPost", scanPost);
                    if (lastSend == null)
                    {
                        GExpScanReturn lastReturn = dc.GExpscanreturn.GetObjectCon(base.ConnectionData.Schema, "WHERE BillCode=@BillCode AND FK_ReturnToPost=@FK_ReturnToPost ORDER BY CreateDate DESC"
                            , "@BillCode", BillCode
                            , "@FK_ReturnToPost", scanPost);
                        if (lastReturn == null)
                        {
                            return "Không có dữ liệu quét gửi, vui lòng liên hệ bên gửi";
                        }
                        else
                        {
                            // Tiếp nhận hàng hoàn
                            frompost = lastReturn.FK_Post;

                        }
                    }
                    else
                    {
                        // Tiếp nhận hàng gửi
                        frompost = lastSend.FK_Post;
                        if (bill.BillStatus < (int)enumGExpBillStatus.DEN_TRUNG_TAM_3)
                        {
                            bill.BillStatus = (int)enumGExpBillStatus.DEN_TRUNG_TAM_3;
                        }
                        else if (bill.BillStatus < (int)enumGExpBillStatus.DANG_TRUNG_CHUYEN_4)
                        {
                            bill.BillStatus = (int)enumGExpBillStatus.DANG_TRUNG_CHUYEN_4;
                        }
                        else if (bill.BillStatus < (int)enumGExpBillStatus.DUYET_HOAN_7)
                        {
                            bill.BillStatus = (int)enumGExpBillStatus.DUYET_HOAN_7;
                        }
                    }

                    scan.FK_ComeFromPost = frompost;
                    dc.GExpscancome.InsertOnSubmit(base.ConnectionData.Schema, scan);
                    dc.GExpbill.Update(base.ConnectionData.Schema, bill);
                    dc.SubmitChanges();
                    return string.Empty;
                }
                else
                {
                    return "Không tìm thấy đơn hàng mã [" + BillCode + "].";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public string DelCome(string Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                DateTime currentDate = dc.CurrentTime();
                GExpScanCome scan = dc.GExpscancome.GetObject(base.ConnectionData.Schema, Id);
                if (scan != null)
                {
                    dc.GExpscancome.DeleteOnSubmit(base.ConnectionData.Schema, scan);
                    dc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
            return string.Empty;
        }
        /// <summary>
        /// Quét giao hàng
        /// </summary>
        /// <param name="BillCode">Mã đơn hàng</param>
        /// <param name="UserId">Mã người quét</param>
        /// <param name="FullName">Tên người quét</param>
        /// <param name="phone">Điện thoại người quét</param>
        /// <param name="shipperID">Mã shipper</param>
        /// <param name="shipperName">Tên shipper</param>
        /// <param name="shipperPhone">Số điện thoại shipper</param>
        /// <param name="scanPost">Bưu cục quét</param>
        /// <returns></returns>
        public string AddDelivery(string BillCode, string UserId, string FullName, string phone, string shipperID, string shipperName, string shipperPhone, string scanPost)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                DateTime currentDate = dc.CurrentTime();
                GExpBill bill = dc.GExpbill.GetObject(base.ConnectionData.Schema, BillCode);
                if (bill != null)
                {
                    if (bill.BillStatus == 6 || bill.BillStatus == 8)
                    {
                        return "Đơn hàng đã được ký nhận hoặc hoàn trả.";
                    }
                    GExpProvider provider = dc.GExpprovider.GetObject(base.ConnectionData.Schema, bill.FK_ProviderAccount);
                    if (provider.RunMode == 1)
                    {
                        return "Loại kiện không phải là kiện vận tải / kiện nội mạng / kiện không kết nối api nên không thể quét hàng giao!";
                    }
                    GExpScanDelivery lastDelivery = dc.GExpscandelivery.GetObjectCon(base.ConnectionData.Schema, "WHERE FK_Post=@FK_Post AND BillCode=@BillCode AND FK_ShipperId=@FK_ShipperId AND CreateDate >='" + string.Format("{0:yyyy-MM-dd}", currentDate) + " 00:00:00' AND CreateDate <='" + string.Format("{0:yyyy-MM-dd}", currentDate) + " 23:59:59'"
                        , "@FK_Post", scanPost
                        , "@BillCode", BillCode
                        , "@FK_ShipperId", shipperID);
                    if (lastDelivery != null)
                    {
                        return "Dữ liệu quét giao đã tồn tại, vui lòng kiểm tra lại!";
                    }
                    // Thêm vào hành trình
                    GExpScanDelivery scan = new GExpScanDelivery();
                    scan.Id = Guid.NewGuid().ToString();
                    scan.FK_Post = scanPost;
                    scan.FK_Account = UserId;
                    scan.BillCode = BillCode;
                    scan.CreateDate = currentDate;
                    scan.Note = "[" + FullName + " - " + phone + "] - Quét hàng giao cho người giao là [" + shipperName + " SĐT: " + shipperPhone + "]";
                    scan.FK_ShipperId = shipperID;
                    dc.GExpscandelivery.InsertOnSubmit(base.ConnectionData.Schema, scan);
                    // Update status
                    bill.BillStatus = (int)enumGExpBillStatus.DANG_PHAT_5;
                    dc.GExpbill.Update(base.ConnectionData.Schema, bill);
                    dc.SubmitChanges();
                    return string.Empty;
                }
                else
                {
                    return "Không tìm thấy đơn hàng mã [" + BillCode + "].";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }

        public string DelDelivery(string Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                DateTime currentDate = dc.CurrentTime();
                GExpScanDelivery scan = dc.GExpscandelivery.GetObject(base.ConnectionData.Schema, Id);
                if (scan != null)
                {
                    dc.GExpscandelivery.DeleteOnSubmit(base.ConnectionData.Schema, scan);
                    dc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
            return string.Empty;
        }

        /// <summary>
        /// Quét hàng gửi
        /// </summary>
        /// <param name="BillCode">Mã đơn hàng</param>
        /// <param name="UserId">Mã người quét</param>
        /// <param name="FullName">Tên người quét</param>
        /// <param name="phone">Số điện thoại</param>
        /// <param name="sendPost">Mã bưu cục gửi</param>
        /// <param name="scanPost">Mã bưu cục quét</param>
        /// <returns></returns>
        public string AddSend(string BillCode, string UserId, string FullName, string phone, string sendPost, string scanPost)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                DateTime currentDate = dc.CurrentTime();
                GExpBill bill = dc.GExpbill.GetObject(base.ConnectionData.Schema, BillCode);
                if (bill != null)
                {
                    if (bill.BillStatus == 6 || bill.BillStatus == 8)
                    {
                        return "Đơn hàng đã được ký nhận hoặc hoàn trả.";
                    }
                    GExpProvider provider = dc.GExpprovider.GetObject(base.ConnectionData.Schema, bill.FK_ProviderAccount);
                    if (provider.RunMode == 1)
                    {
                        return "Loại kiện không phải là kiện vận tải / kiện nội mạng / kiện không kết nối api nên không thể quét hàng gửi!";
                    }
                    // Check đã scan chưa
                    GExpScanSend lastSend = dc.GExpscansend.GetObjectCon(base.ConnectionData.Schema, "WHERE FK_Post=@FK_Post AND BillCode=@BillCode AND FK_SendToPost=@FK_SendToPost AND CreateDate >='" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", currentDate.AddMinutes(-15)) + "'"
                        , "@FK_Post", scanPost
                        , "@BillCode", BillCode
                        , "@FK_SendToPost", sendPost);
                    if (lastSend != null)
                    {
                        return "Dữ liệu quét đã tồn tại, vui lòng kiểm tra lại!";
                    }
                    // Thêm vào hành trình
                    GExpScanSend scan = new GExpScanSend();
                    scan.Id = Guid.NewGuid().ToString();
                    scan.FK_Post = scanPost;
                    scan.FK_Account = UserId;
                    scan.BillCode = BillCode;
                    scan.CreateDate = currentDate;
                    scan.FK_SendToPost = sendPost;
                    scan.Note = "[" + FullName + " - " + phone + "] - Quét hàng gửi đến [" + sendPost + "]";
                    dc.GExpscansend.InsertOnSubmit(base.ConnectionData.Schema, scan);
                    // Xử lý Bill Status
                    if (bill.BillStatus < (int)enumGExpBillStatus.TIEP_NHAN_1)
                    {
                        bill.BillStatus = (int)enumGExpBillStatus.TIEP_NHAN_1;
                        dc.GExpbill.Update(base.ConnectionData.Schema, bill);
                    }

                    dc.SubmitChanges();
                    return string.Empty;
                }
                else
                {
                    return "Không tìm thấy đơn hàng mã [" + BillCode + "].";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public string DelSend(string Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                DateTime currentDate = dc.CurrentTime();
                GExpScanSend scan = dc.GExpscansend.GetObject(base.ConnectionData.Schema, Id);
                if (scan != null)
                {
                    dc.GExpscansend.DeleteOnSubmit(base.ConnectionData.Schema, scan);
                    dc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
            return string.Empty;
        }
        /// <summary>
        /// Quét hàng hoàn
        /// </summary>
        /// <param name="BillCode">Mã đơn hàng</param>
        /// <param name="UserId">Người quét</param>
        /// <param name="FullName">Tên người quét</param>
        /// <param name="phone">Số điện thoại người quét</param>
        /// <param name="returnPost">Bưu cục trả hàng hoàn</param>
        /// <param name="scanPost">Bưu cục quét</param>
        /// <returns></returns>
        public string AddReturn(string BillCode, string UserId, string FullName, string phone, string returnPost, string scanPost)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                DateTime currentDate = dc.CurrentTime();
                GExpBill bill = dc.GExpbill.GetObject(base.ConnectionData.Schema, BillCode);
                if (bill != null)
                {
                    if (bill.BillStatus == 6 || bill.BillStatus == 8)
                    {
                        return "Đơn hàng đã được ký nhận hoặc hoàn trả.";
                    }
                    GExpProvider provider = dc.GExpprovider.GetObject(base.ConnectionData.Schema, bill.FK_ProviderAccount);
                    if (provider.RunMode == 1)
                    {
                        return "Loại kiện không phải là kiện vận tải / kiện nội mạng / kiện không kết nối api nên không thể quét hàng hoàn!";
                    }
                    GExpScanReturn lastReturn = dc.GExpscanreturn.GetObjectCon(base.ConnectionData.Schema, "WHERE FK_Post=@FK_Post AND BillCode=@BillCode AND FK_ReturnToPost=@FK_ReturnToPost AND CreateDate >='" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", currentDate.AddMinutes(-15)) + "'"
                        , "@FK_Post", scanPost
                        , "@BillCode", BillCode
                        , "@FK_ReturnToPost", returnPost);
                    if (lastReturn != null)
                    {
                        return "Dữ liệu quét đã tồn tại, vui lòng kiểm tra lại!";
                    }
                    // Thêm vào hành trình
                    GExpScanReturn scan = new GExpScanReturn();
                    scan.Id = Guid.NewGuid().ToString();
                    scan.FK_Post = scanPost;
                    scan.FK_Account = UserId;
                    scan.BillCode = BillCode;
                    scan.CreateDate = currentDate;
                    scan.Note = "[" + FullName + " - " + phone + "] - Quét hoàn trả hàng hoàn về bưu cục [" + returnPost + "]";
                    scan.FK_ReturnToPost = returnPost;
                    dc.GExpscanreturn.InsertOnSubmit(base.ConnectionData.Schema, scan);
                    // Xử lý Bill Status
                    bill.BillStatus = (int)enumGExpBillStatus.DUYET_HOAN_7;
                    dc.GExpbill.Update(base.ConnectionData.Schema, bill);
                    dc.SubmitChanges();
                    return string.Empty;
                }
                else
                {
                    return "Không tìm thấy đơn hàng mã [" + BillCode + "].";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public string DelReturn(string Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                DateTime currentDate = dc.CurrentTime();
                GExpScanReturn scan = dc.GExpscanreturn.GetObject(base.ConnectionData.Schema, Id);
                if (scan != null)
                {
                    dc.GExpscanreturn.DeleteOnSubmit(base.ConnectionData.Schema, scan);
                    dc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
            return string.Empty;
        }
        /// <summary>
        /// Tính toán phí với cân nặng
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="InitPrice"></param>
        /// <param name="InitWeight"></param>
        /// <param name="StepWeight"></param>
        /// <param name="StepPrice"></param>
        /// <returns></returns>
        private int CalculatorFeeWithWeight(int weight, int InitPrice, int InitWeight, int StepWeight, int StepPrice)
        {
            int fee = 0;
            if (weight <= InitWeight)
            {
                fee = InitPrice;
            }
            else
            {
                if (StepWeight == 0)
                {
                    fee = 0;
                }
                else
                {
                    decimal temp = InitPrice + (((weight - InitWeight) * StepPrice) / StepWeight);
                    fee = (int)temp;
                }
            }
            return fee;
        }
        /// <summary>
        /// Lấy danh sách shipper có tất cả
        /// </summary>
        /// <param name="postID"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public List<GExpShipper> GetShipperListAllFilter(string postID, string keyword = "")
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<GExpShipper> list = new List<GExpShipper>();
                if (string.IsNullOrEmpty(keyword))
                {
                    GExpShipper cus = new GExpShipper();
                    cus.Id = "9999";
                    cus.ShipperName = "Tất cả";
                    list.Add(cus);
                }
                string searchKey = UnSigns(keyword);
                List<GExpShipper> temp = dc.GExpshipper.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_Post=@FK_Post AND (ShipperPhone LIKE '%" + searchKey + "%' OR ShipperName LIKE '%" + searchKey + "%' OR UserName LIKE N'%" + keyword + "%') ORDER BY ShipperName", "@FK_Post", postID);
                list.AddRange(temp);
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        /// <summary>
        /// Lấy danh sách shipper
        /// </summary>
        /// <param name="postID"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public List<GExpShipper> GetShipperListFilter(string postID, string keyword = "")
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string searchKey = UnSigns(keyword);
                return dc.GExpshipper.GetListObjectCon(base.ConnectionData.Schema, "WHERE FK_Post=@FK_Post AND (ShipperPhone LIKE '%" + searchKey + "%' OR ShipperName LIKE '%" + searchKey + "%' OR UserName LIKE N'%" + keyword + "%') ORDER BY ShipperName", "@FK_Post", postID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        public GExpShipper GetShipperDetail(string shipperId)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.GExpshipper.GetObject(base.ConnectionData.Schema, shipperId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        /// <summary>
        /// Lấy danh sách bưu cục master có select all
        /// </summary>
        /// <param name="postID"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public List<ExpPost> GetPostListAllFilter(string postID, string keyword = "")
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                List<ExpPost> list = new List<ExpPost>();
                if (string.IsNullOrEmpty(keyword))
                {
                    ExpPost cus = new ExpPost();
                    cus.Id = "9999";
                    cus.TenDaiLy = "Tất cả";
                    list.Add(cus);
                }
                string searchKey = keyword;
                list.AddRange(dc.EXppost.GetListObjectCon(base.ConnectionData.Schema, "WHERE Id<>@Id AND MaBuuCuc='M' AND (Code LIKE '%" + searchKey + "%' OR TenDaiLy LIKE '%" + searchKey + "%' OR Phone LIKE N'%" + keyword + "%') ORDER BY Id", "@Id", postID));
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        /// <summary>
        /// Lấy danh sách bưu cục master với Ma='M'
        /// </summary>
        /// <param name="postID"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public List<ExpPost> GetPostListFilter(string postID, string keyword = "")
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string searchKey = UnSigns(keyword);
                return dc.EXppost.GetListObjectCon(base.ConnectionData.Schema, "WHERE Id<>@Id AND MaBuuCuc='M' AND (Code LIKE '%" + searchKey + "%' OR TenDaiLy LIKE '%" + searchKey + "%' OR Phone LIKE N'%" + keyword + "%') ORDER BY Id", "@Id", postID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        /// <summary>
        /// Lấy danh sách đơn hàng đến
        /// </summary>
        /// <param name="postID">Bưu cục quét</param>
        /// <param name="postFrom">Đến từ bưu cục</param>
        /// <param name="from">Từ ngày</param>
        /// <param name="to">Đến ngày</param>
        /// <param name="keyword">Mã vận đơn</param>
        /// <returns></returns>
        public List<view_GExpScanCome> GetScanComeListFilter(string postID, string postFrom, DateTime from, DateTime to, string keyword = "")
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string condition = "WHERE FK_Post='" + postID + "' AND CreateDate>='" + string.Format("{0:yyyy-MM-dd}", from) + " 00:00:00' AND CreateDate<='" + string.Format("{0:yyyy-MM-dd}", to) + " 23:59:59' &";
                if (postFrom != "9999")
                {
                    condition += " FK_ComeFromPost='" + postFrom + "' &";
                }
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " BillCode='" + keyword + "' &";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('&');
                condition = condition.Replace("&", "AND");
                condition = condition + " ORDER BY CreateDate desc";
                return dc.VIewgexpscancome.GetListObjectCon(base.ConnectionData.Schema, condition);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        /// <summary>
        /// Lấy danh sách quét hàng gửi
        /// </summary>
        /// <param name="postID">Bưu cục quét</param>
        /// <param name="postTo">Gửi hàng đến bưu cục</param>
        /// <param name="from">Từ ngày</param>
        /// <param name="to">Đến ngày</param>
        /// <param name="keyword">Mã vận đơn</param>
        /// <returns></returns>
        public List<view_GExpScanSend> GetScanSendListFilter(string postID, string postTo, DateTime from, DateTime to, string keyword = "")
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string condition = "WHERE FK_Post='" + postID + "' AND CreateDate>='" + string.Format("{0:yyyy-MM-dd}", from) + " 00:00:00' AND CreateDate<='" + string.Format("{0:yyyy-MM-dd}", to) + " 23:59:59' &";
                if (postTo != "9999")
                {
                    condition += " FK_SendToPost='" + postTo + "' &";
                }
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " BillCode='" + keyword + "' &";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('&');
                condition = condition.Replace("&", "AND");
                condition = condition + " ORDER BY CreateDate desc";
                return dc.VIewgexpscansend.GetListObjectCon(base.ConnectionData.Schema, condition);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        /// <summary>
        /// Lấy danh sách đơn hàng hoàn trả
        /// </summary>
        /// <param name="postID">Bưu cục quét</param>
        /// <param name="postReturn">Trả hàng về cho bưu cục</param>
        /// <param name="from">Từ ngày</param>
        /// <param name="to">Đến ngày</param>
        /// <param name="keyword">Mã vận đơn</param>
        /// <returns></returns>
        public List<view_GExpScanReturn> GetScanReturnListFilter(string postID, string postReturn, DateTime from, DateTime to, string keyword = "")
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string condition = "WHERE FK_Post='" + postID + "' AND CreateDate>='" + string.Format("{0:yyyy-MM-dd}", from) + " 00:00:00' AND CreateDate<='" + string.Format("{0:yyyy-MM-dd}", to) + " 23:59:59' &";
                if (postReturn != "9999")
                {
                    condition += " FK_SendToPost='" + postReturn + "' &";
                }
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " BillCode='" + keyword + "' &";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('&');
                condition = condition.Replace("&", "AND");
                condition = condition + " ORDER BY CreateDate desc";
                return dc.VIewgexpscanreturn.GetListObjectCon(base.ConnectionData.Schema, condition);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        /// <summary>
        /// Lấy danh sách quét giao
        /// </summary>
        /// <param name="postID">Bưu cục quét</param>
        /// <param name="shipperID">Shipper Id Lọc</param>
        /// <param name="from">Từ ngày</param>
        /// <param name="to">Đến ngày</param>
        /// <param name="keyword">Mã vận đơn</param>
        /// <returns></returns>
        public List<view_GExpScanDelivery> GetScanDeliveryListFilter(string postID, string shipperID, DateTime from, DateTime to, string keyword = "")
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string condition = "WHERE FK_Post='" + postID + "' AND CreateDate>='" + string.Format("{0:yyyy-MM-dd}", from) + " 00:00:00' AND CreateDate<='" + string.Format("{0:yyyy-MM-dd}", to) + " 23:59:59' &";
                if (shipperID != "9999")
                {
                    condition += " FK_ShipperId='" + shipperID + "' &";
                }
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " BillCode='" + keyword + "' &";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('&');
                condition = condition.Replace("&", "AND");
                condition = condition + " ORDER BY CreateDate desc";
                return dc.VIewgexpscandelivery.GetListObjectCon(base.ConnectionData.Schema, condition);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
        /// <summary>
        /// Lấy danh sách ký nhận nội mạng
        /// </summary>
        /// <param name="postID">Bưu cục ký nhận</param>
        /// <param name="shipperID">Shipper ký nhận</param>
        /// <param name="from">Từ ngày</param>
        /// <param name="to">Đến ngày</param>
        /// <param name="keyword">Mã vận đơn lọc</param>
        /// <returns></returns>
        public List<view_GExpScanSign> GetScanSignListFilter(string postID, string shipperID, DateTime from, DateTime to, string keyword = "")
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string condition = "WHERE FK_Post='" + postID + "' AND CreateDate>='" + string.Format("{0:yyyy-MM-dd}", from) + " 00:00:00' AND CreateDate<='" + string.Format("{0:yyyy-MM-dd}", to) + " 23:59:59' &";
                if (shipperID != "9999")
                {
                    condition += " FK_Account='" + shipperID + "' &";
                }
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += " BillCode='" + keyword + "' &";
                }
                condition = condition.Trim();
                condition = condition.TrimEnd('&');
                condition = condition.Replace("&", "AND");
                condition = condition + " ORDER BY CreateDate desc";
                return dc.VIewgexpscansign.GetListObjectCon(base.ConnectionData.Schema, condition);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }
    }
}
