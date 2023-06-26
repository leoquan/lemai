using Common;
using DevComponents.WinForms.Drawing;
using LeMaiDomain;
using LeMaiDomain.Models;
using LeMaiLogic.Logic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Google.Apis.Requests.BatchRequest;

namespace LeMaiDesktop
{
    public partial class frmAutoUpdateTrack : frmBase
    {
        private GExpBillLogic _logic = new GExpBillLogic(PBean.ConnectionBase);
        private GExpScanLogic _logicScan = new GExpScanLogic(PBean.ConnectionBase);
        List<GExpBillStatusName> lsStatus = new List<GExpBillStatusName>();

        view_GExpBillGHNApi bill;
        public bool isBusy = false;
        public bool isBusyWebhook = false;
        public bool isBusySign = false;
        public frmAutoUpdateTrack() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {

            if (timer.Enabled == false)
            {
                log.Info("Chạy tự động tracking");
                timer.Enabled = true;
                timerwebhook.Enabled = true;
                progressBar.Visible = true;
                btnRun.Text = "Đang chạy";
                btnRun.Image = global::LeMaiDesktop.Properties.Resources.iStop;
            }
            else
            {
                log.Info("Tạm dựng chạy tự động tracking");
                timer.Enabled = false;
                timerwebhook.Enabled = false;
                progressBar.Visible = false;
                btnRun.Text = "Đang dừng";
                btnRun.Image = global::LeMaiDesktop.Properties.Resources.iPlay;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            timerwebhook.Enabled = false;
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Autocheck
            if (isBusy == false)
            {
                try
                {
                    isBusy = true;
                    bill = _logic.GetDetailTrackingGHNApi();
                    if (bill != null)
                    {
                        txtMaDonHang.Text = bill.BillCode;
                        txtNguoiGui.Text = bill.SendMan;
                        txtNguoiNhan.Text = bill.AcceptMan;
                        txtSoDienThoaiNguoiGui.Text = bill.SendManPhone;
                        txtSoDienThoaiNguoiNhan.Text = bill.AcceptManPhone;
                        txtBT3Code.Text = bill.BT3Code;
                        txtSystemDate.Text = string.Format("{0:dd/MM/yy HH:mm:ss}", bill.SystemDate);
                        txtNgayGui.Text = string.Format("{0:dd/MM/yy HH:mm:ss}", bill.RegisterDate);
                        backgroundWorker.RunWorkerAsync();
                    }
                }
                catch
                {
                    isBusy = false;
                    Thread.Sleep(5000);
                }
            }
        }

        private void frmAutoUpdateTrack_Load(object sender, EventArgs e)
        {
            lsStatus = ApiConnectUlti.GetTrackingNameList();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _logic.UpdateSystemDateTracking(bill.BillCode, "BEGIN TRACKING");
                IConnectApi api = ApiConnectUlti.GetApiByName(bill.ProviderTypeCode, bill);
                string mess = string.Empty;

                var result = api.Tracking(bill);
                if (result.IsSuccess == true)
                {
                    mess = "Track Update " + string.Format("{0:dd/MM/yyyy HH:mm}", DateTime.Now);
                    _logic.UpdateTracking(bill.BillCode, result, lsStatus);
                    if (result.UpdateFee == true)
                    {
                        _logic.UpdateBT3Freight(bill.BillCode, result.BT3Freight);
                    }
                }
                else
                {
                    mess = result.Message;
                }
                _logic.UpdateSystemDateTracking(bill.BillCode, mess);
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }

        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            isBusy = false;
        }

        private void timerwebhook_Tick(object sender, EventArgs e)
        {
            if (isBusyWebhook == false)
            {
                try
                {
                    isBusyWebhook = true;
                    backgroundWorkerWH.RunWorkerAsync();
                }
                catch
                {
                    isBusyWebhook = false;
                    Thread.Sleep(2000);
                }
            }
        }

        private void backgroundWorkerWH_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                // Lấy danh sách webhook
                List<GExpWebhook> list = _logic.GetListWebhook();
                foreach (var item in list)
                {
                    // Xử lý webhook
                    if (item.Provider == "NINJA")
                    {
                        WHNinjaInput objectJson = JsonConvert.DeserializeObject<WHNinjaInput>(item.JsonContent);
                        if (objectJson != null)
                        {
                            OutTrackingResultGHN trackingResultGHN = new OutTrackingResultGHN();
                            trackingResultGHN.outTrackingLogs = new List<OutTrackingLogGHN>();
                            OutTrackingLogGHN log = new OutTrackingLogGHN();
                            DateTime tempDate = objectJson.timestamp;
                            log.ActionDateTime = new DateTime(tempDate.Year, tempDate.Month, tempDate.Day, tempDate.Hour, tempDate.Minute, 0, 0);
                            log.ActionDate = log.ActionDateTime.ToString();
                            log.StatusCode = "N." + objectJson.status;
                            string com = GetNinjaStatusDesc(objectJson.status);
                            log.ProviderName = "NINJA";
                            log.Note = com + " " + objectJson.comments;
                            trackingResultGHN.outTrackingLogs.Add(log);
                            _logic.UpdateTracking(objectJson.tracking_id, trackingResultGHN, lsStatus);
                        }
                    }
                    else if (item.Provider == "JNT")
                    {
                        WHJNTInput hJNTInput = JsonConvert.DeserializeObject<WHJNTInput>(item.JsonContent);
                        if (hJNTInput != null)
                        {
                            foreach (var wh in hJNTInput.responseitems)
                            {
                                switch (wh.status_code)
                                {
                                    case "103"://Xác nhận đơn hàng
                                        {
                                        }
                                        break;
                                    case "104"://Lấy hàng ko thành công
                                        { }
                                        break;
                                    case "105"://Hủy đơn
                                        { }
                                        break;
                                    case "106"://Nhận hàng thành công
                                        { }
                                        break;
                                    case "107"://Nhập kho
                                        { }
                                        break;
                                    case "108"://Đóng bao
                                        { }
                                        break;
                                    case "109"://Gửi kiện
                                        { }
                                        break;
                                    case "110"://Kiện đến
                                        { }
                                        break;
                                    case "111"://Tháo bao
                                        { }
                                        break;
                                    case "112"://Giao kiện
                                        { }
                                        break;
                                    case "113"://Giao kiện thành công | Ký nhận
                                        {
                                            // Ký nhận đơn hàng

                                        }
                                        break;
                                    case "116"://Chuyển hoàn
                                        { }
                                        break;
                                    case "117"://Chuyển hoàn thành công | Ký nhận
                                        { }
                                        break;
                                    case "118"://Giao không thành công
                                        { }
                                        break;
                                    case "120"://Chuyển hoàn không thành công
                                        { }
                                        break;

                                    default:
                                        break;
                                }
                            }
                        }
                    }
                    // Delete những webhook đã xử lý
                    _logic.DeleteWebhook(item.Id);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }
        }

        private void backgroundWorkerWH_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            isBusyWebhook = false;
        }
        private string GetNinjaStatusDesc(string code)
        {
            string result = code;

            string path = AppDomain.CurrentDomain.BaseDirectory + "apidata/ninjaStatus.json";
            if (File.Exists(path))
            {
                using (StreamReader st = new StreamReader(path))
                {
                    string json = st.ReadToEnd();
                    NinjaStatusDiction lsError = JsonConvert.DeserializeObject<NinjaStatusDiction>(json);
                    NinjaStatus err = lsError.NinjaEvent.FirstOrDefault(u => u.id == code);
                    if (err != null)
                    {
                        return err.description;
                    }

                }
            }
            return result;
        }

        private void timerSign_Tick(object sender, EventArgs e)
        {
            if (isBusySign == false)
            {
                try
                {
                    isBusySign = true;
                    backgroundWorkerSign.RunWorkerAsync();
                }
                catch
                {
                    isBusySign = false;
                    Thread.Sleep(1000);
                }
            }
        }

        private void backgroundWorkerSign_DoWork(object sender, DoWorkEventArgs e)
        {
            // Lấy dữ liệu
            try
            {
                view_AutoSignDelivery delivery = _logic.GetDetailAutoSignDelivery();
                if (delivery != null)
                {
                    // Ký thực tế
                    _logicScan.AddSigned(delivery.BillCode, delivery.ShipperId, delivery.ShipperName, delivery.ShipperPhone, delivery.FK_Post, delivery.Id);
                }
            }
            catch
            {
            }
        }

        private void backgroundWorkerSign_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            isBusySign = false;
        }
    }
}
