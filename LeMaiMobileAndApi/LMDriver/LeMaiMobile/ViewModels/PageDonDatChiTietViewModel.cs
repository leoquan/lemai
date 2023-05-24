using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LeMaiDto;
using LeMaiMobile.Views;
using Newtonsoft.Json;
using Prism.Navigation;
using Prism.Services.Dialogs;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Essentials;
using XF.Material.Forms.UI.Dialogs;

namespace LeMaiMobile.ViewModels;

public partial class PageDonDatChiTietViewModel : GhViewModelBase<PageDonDatChiTiet>
{
    public PageDonDatChiTietViewModel(INavigationService navigationService, IDialogService dialogService, Models.IStatusBar myStatuBar)
        : base(navigationService, dialogService, myStatuBar)
    {
        Title = "Chi tiết vận đơn";
    }

    private bool _originIsEdit = false;
    private DonDatDanhSachOutput _originModel = null;
    public override async void OnNavigatedTo(INavigationParameters parameters)
    {
        base.OnNavigatedTo(parameters);

        switch (parameters.GetNavigationMode())
        {
            case Prism.Navigation.NavigationMode.Back:
                break;
            case Prism.Navigation.NavigationMode.New:
                if (parameters.TryGetValue("model", out DonDatDanhSachOutput editModel))
                {
                    _originModel = editModel;

                    if (string.IsNullOrWhiteSpace(editModel.Id))
                    {
                        Title = "Tạo mới đơn đặt";
                        _originIsEdit = false;
                        WorkingModel = new DonDatEditInputModel();
                        // Init giá trị mặc định
                        WorkingModel.Id = "0000";
                        LoadChiTietCommand.Execute(null);

                    }
                    else
                    {
                        Title = "Cập nhật đơn đặt";
                        _originIsEdit = true;
                        WorkingModel = new DonDatEditInputModel();
                        WorkingModel.Id = editModel.Id;
                        LoadChiTietCommand.Execute(null);
                    }
                }

                break;
            default:
                break;
        }
    }

    [ObservableProperty]
    public List<string> _listIsShopPayType = new List<string>
    {
        "Gửi trả (Bao ship)",
        "Nhận trả (Không bao ship)"
    };

    [ObservableProperty]
    private DonDatEditInputModel _workingModel = new DonDatEditInputModel();

    [RelayCommand]
    private async Task LoadChiTietAsync()
    {
        if (LoadChiTietCommand.IsRunning || !CanCommandRun || string.IsNullOrWhiteSpace(WorkingModel?.Id))
        {
            return;
        }

        try
        {
            CanCommandRun = false;
            await ShowLoading();

            // Call api lay thong tin can ho
            var request = new RestRequest("/DonDat/ChiTiet", Method.Get);
            request.AddParameter("id", WorkingModel.Id);

            var response = await ExecuteApiAsync<GexpOrderDto>(request);
            if (!response.isOk || response.data == null)
            {
                return;
            }
            var workingModel = new DonDatEditInputModel();
            var editModel = response.data;
            workingModel.Id = editModel.Id;
            workingModel.OrderCode = editModel.OrderCode;
            workingModel.AcceptName = editModel.AcceptName;
            workingModel.AcceptPhone = editModel.AcceptPhone;
            workingModel.AcceptAddress = editModel.AcceptAddress;
            workingModel.GoodsName = editModel.GoodsName;
            workingModel.CodStr = editModel.Cod.ToString();
            workingModel.Cod = editModel.Cod;
            workingModel.IsShopPay = editModel.IsShopPay;
            workingModel.Note = editModel.Note;
            workingModel.WeightStr = editModel.Weight.ToString();
            workingModel.Weight = editModel.Weight;
            workingModel.ProvinceCode = editModel.ProvinceCode;
            workingModel.DistrictCode = editModel.DistrictCode;
            workingModel.DistrictWard = editModel.DistrictWard;
            workingModel.Freight = editModel.Freight;
            workingModel.FreightStr = string.Format("{0:N0} VNĐ", editModel.Freight);
            workingModel.FK_ShipperNot = editModel.FkShipperNot;

            WorkingModel = workingModel;


            ListTinh = new ObservableCollection<ProvineDanhSachOutput>(response.data.DanhSachProvine.OrderBy(o => o.Name));
            SelectedTinh = ListTinh.FirstOrDefault(h => h.Id == workingModel.ProvinceCode);

            ListHuyen = new ObservableCollection<DistrictDanhSachOutput>(response.data.DanhSachDistrict.OrderBy(o => o.Name));
            SelectedHuyen = response.data.DanhSachDistrict.FirstOrDefault(h => h.Id == workingModel.DistrictCode);

            ListXa = new ObservableCollection<WardDanhSachOutput>(response.data.DanhSachWard.OrderBy(o => o.Name));
            SelectedXa = ListXa.FirstOrDefault(h => h.Id == workingModel.DistrictWard);

            // Loại kiện
            ListLoaiKien = new ObservableCollection<LoaiKienDanhSachOutput>(new List<LoaiKienDanhSachOutput>
            {
                new LoaiKienDanhSachOutput{Id="CXH", Name="Cho xem hàng"},
                new LoaiKienDanhSachOutput{Id="KXH", Name="Không cho xem hàng"},
            });
            SelectedLoaiKien = ListLoaiKien.FirstOrDefault(u => u.Id == workingModel.FK_ShipperNot);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(ex);
        }
        finally
        {
            CanCommandRun = true;
            await HideLoading();
        }
    }


    [RelayCommand]
    private async Task LuuAsync()
    {
        if (LuuCommand.IsRunning || !CanCommandRun)
        {
            return;
        }

        try
        {
            CanCommandRun = false;
            await ShowLoading();

            var submitModel = new DonDatEditInput();
            submitModel.Id = _workingModel.Id;
            submitModel.OrderCode = _workingModel.OrderCode;
            submitModel.AcceptName = _workingModel.AcceptName;
            submitModel.AcceptPhone = _workingModel.AcceptPhone;
            submitModel.AcceptAddress = _workingModel.AcceptAddress;
            submitModel.GoodsName = _workingModel.GoodsName;
            submitModel.Cod = _workingModel.Cod;
            submitModel.IsShopPay = _workingModel.IsShopPay;
            submitModel.Note = _workingModel.Note;
            submitModel.Weight = _workingModel.Weight;

            submitModel.ProvinceCode = SelectedTinh.Id;
            submitModel.DistrictCode = SelectedHuyen.Id;
            submitModel.DistrictWard = SelectedXa.Id;
            submitModel.Freight = _workingModel.Freight;
            submitModel.FK_ShipperNot = _workingModel.FK_ShipperNot;

            var validateError = DonDatValidate.ValidateAndNormalize(submitModel, !string.IsNullOrWhiteSpace(_workingModel.Id));
            if (validateError.Length > 0)
            {
                await AlertAsync(
                  message: validateError,
                  title: "Lỗi nhập liệu",
                  acknowledgementText: "Đóng"
                  );

                return;
            }

            // Call api lay thong tin can ho
            var request = new RestRequest("/DonDat/"
                + (string.IsNullOrWhiteSpace(_workingModel.Id) ? "TaoMoi" : "CapNhat")
                , Method.Post);
            request.AddJsonBody(submitModel);

            var response = await ExecuteApiAsync<GexpOrderDto>(request);
            if (!response.isOk || response.data == null)
            {
                return;
            }

            var workingModel = new DonDatEditInputModel();
            var editModel = response.data;
            workingModel.Id = editModel.Id;
            workingModel.OrderCode = editModel.OrderCode;
            workingModel.AcceptName = editModel.AcceptName;
            workingModel.AcceptPhone = editModel.AcceptPhone;
            workingModel.AcceptAddress = editModel.AcceptAddress;
            workingModel.GoodsName = editModel.GoodsName;
            workingModel.CodStr = editModel.Cod.ToString();
            workingModel.Cod = editModel.Cod;
            workingModel.IsShopPay = editModel.IsShopPay;
            workingModel.Note = editModel.Note;
            workingModel.WeightStr = editModel.Weight.ToString();
            workingModel.Weight = editModel.Weight;
            workingModel.ProvinceCode = editModel.ProvinceCode;
            workingModel.DistrictCode = editModel.DistrictCode;
            workingModel.DistrictWard = editModel.DistrictWard;
            workingModel.FK_ShipperNot = editModel.FkShipperNot;
            workingModel.FreightStr = string.Format("{0:N0} VNĐ", editModel.Freight);
            workingModel.Freight = editModel.Freight;

            WorkingModel = workingModel;
            Title = "Cập nhật đơn đặt";

            if (string.IsNullOrWhiteSpace(submitModel.Id))
            {
                await AlertAsync(
                    message: "Tạo mới thành công đơn đặt.",
                    title: "Thông báo",
                    acknowledgementText: "Đóng"
                    );
                _originModel.Id = _workingModel.Id;
            }
            else
            {
                await AlertAsync(
                    message: "Cập nhật thành công đơn đặt.",
                    title: "Thông báo",
                    acknowledgementText: "Đóng"
                    );
            }
            _originModel.IsSave = true;
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(ex);
        }
        finally
        {
            CanCommandRun = true;
            await HideLoading();
        }
    }


    [ObservableProperty]
    private ObservableCollection<ProvineDanhSachOutput> _listTinh = new ObservableCollection<ProvineDanhSachOutput>();
    [ObservableProperty]
    private ProvineDanhSachOutput _selectedTinh = null;

    [RelayCommand]
    private async Task SelectTinhAsync(ProvineDanhSachOutput selectValue)
    {
        // Select change
        if (SelectTinhCommand.IsRunning || !CanCommandRun)
        {
            return;
        }
        try
        {
            CanCommandRun = false;
            await ShowLoading();
            // Call api lay thong tin can ho
            var request = new RestRequest("/DonDat/GetDistrict", Method.Get);
            request.AddHeader("weight", _workingModel.Weight);
            request.AddHeader("provine", SelectedTinh.Id);
            var response = await ExecuteApiAsync<DistrictDanhSachFeeOutput>(request);
            if (!response.isOk)
            {
                return;
            }

            WorkingModel.Freight = response.data.Fee;
            WorkingModel.FreightStr = string.Format("{0:N0} VNĐ", response.data.Fee);

            ListHuyen = new ObservableCollection<DistrictDanhSachOutput>(response.data.DanhSachHuyen.OrderBy(o => o.Name));
            SelectedHuyen = ListHuyen.FirstOrDefault();

            ListXa = new ObservableCollection<WardDanhSachOutput>(response.data.DanhSachXa.OrderBy(o => o.Name));
            SelectedXa = ListXa.FirstOrDefault();
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(ex);
        }
        finally
        {
            CanCommandRun = true;
            await HideLoading();
        }

    }

    [ObservableProperty]
    private ObservableCollection<DistrictDanhSachOutput> _listHuyen = new ObservableCollection<DistrictDanhSachOutput>();
    [ObservableProperty]
    private DistrictDanhSachOutput _selectedHuyen = null;
    [RelayCommand]
    private async Task SelectHuyenAsync(DistrictDanhSachOutput selectValue)
    {
        // Select change
        if (SelectHuyenCommand.IsRunning || !CanCommandRun)
        {
            return;
        }
        try
        {
            CanCommandRun = false;
            await ShowLoading();

            var request = new RestRequest("/DonDat/GetWard", Method.Get);
            request.AddHeader("weight", _workingModel.Weight);
            request.AddHeader("provine", SelectedTinh.Id);
            request.AddHeader("districtId", SelectedHuyen.Id);
            var response = await ExecuteApiAsync<WardDanhSachFeeOutput>(request);
            if (!response.isOk)
            {
                return;
            }
            WorkingModel.Freight = response.data.Fee;
            WorkingModel.FreightStr = string.Format("{0:N0} VNĐ", response.data.Fee);

            ListXa = new ObservableCollection<WardDanhSachOutput>(response.data.DanhSachXa.OrderBy(o => o.Name));
            SelectedXa = ListXa.FirstOrDefault();

        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(ex);
        }
        finally
        {
            CanCommandRun = true;
            await HideLoading();
        }
    }
    [ObservableProperty]
    private ObservableCollection<WardDanhSachOutput> _listXa = new ObservableCollection<WardDanhSachOutput>();
    [ObservableProperty]
    private WardDanhSachOutput _selectedXa = null;

    [ObservableProperty]
    private ObservableCollection<LoaiKienDanhSachOutput> _listLoaiKien = new ObservableCollection<LoaiKienDanhSachOutput>();
    [ObservableProperty]
    private LoaiKienDanhSachOutput _selectedLoaiKien = null;


    [RelayCommand]
    private async Task CopyBillCodeAsync(string billCode)
    {
        if (CopyBillCodeCommand.IsRunning || !CanCommandRun || string.IsNullOrWhiteSpace(billCode))
        {
            return;
        }

        try
        {
            CanCommandRun = false;

            await Clipboard.SetTextAsync(billCode);

            _ = MaterialDialog.Instance.SnackbarAsync(
               "Đã sao chép mã đặt hàng vào bộ nhớ tạm",
               msDuration: 2000);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(ex);
        }
        finally
        {
            CanCommandRun = true;
        }
    }
    [RelayCommand]
    private async Task FreightAsync()
    {

        if (FreightCommand.IsRunning || !CanCommandRun)
        {
            return;
        }

        try
        {
            CanCommandRun = false;
            await ShowLoading();

            int Weight = _workingModel.Weight;

            // Call api lay thong tin can ho
            var request = new RestRequest("/DonDat/GetFee"
                , Method.Get);
            request.AddHeader("weight", Weight);
            request.AddHeader("provine", SelectedTinh.Id);
            request.AddHeader("district", SelectedHuyen.Id);

            var response = await ExecuteApiAsync<int>(request);
            if (!response.isOk)
            {
                return;
            }
            WorkingModel.Freight = response.data;
            WorkingModel.FreightStr = string.Format("{0:N0} VNĐ", WorkingModel.Freight);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(ex);
        }
        finally
        {
            CanCommandRun = true;
            await HideLoading();
        }
    }

    [RelayCommand]
    private async Task AcceptPhoneAsync()
    {
        if (AcceptPhoneCommand.IsRunning || !CanCommandRun)
        {
            return;
        }
        try
        {
            CanCommandRun = false;
            await ShowLoading();

            // Call api lay thong tin can ho
            var request = new RestRequest("/DonDat/GetAccepntMan"
                , Method.Get);
            request.AddHeader("phone", WorkingModel.AcceptPhone);

            var response = await ExecuteApiAsync<AcceptOutput>(request);
            if (!response.isOk)
            {
                return;
            }
            if (response.data.IsFound == true)
            {
                WorkingModel.AcceptName = response.data.AcceptName;
                WorkingModel.AcceptAddress = response.data.AcceptAddress;

                SelectedTinh = ListTinh.FirstOrDefault(u => u.Id == response.data.ProvineCode);

                ListHuyen = new ObservableCollection<DistrictDanhSachOutput>(response.data.DanhSachHuyen.OrderBy(o => o.Name));
                SelectedHuyen = ListHuyen.FirstOrDefault(u => u.Id == response.data.DistrictCode);

                ListXa = new ObservableCollection<WardDanhSachOutput>(response.data.DanhSachXa.OrderBy(o => o.Name));
                SelectedXa = ListXa.FirstOrDefault(u => u.Id == response.data.WardCode);
            }
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(ex);
        }
        finally
        {
            CanCommandRun = true;
            await HideLoading();
        }
    }
}

[ObservableObject]
public partial class DonDatEditInputModel
{
    [ObservableProperty]
    private string _Id;
    [ObservableProperty]
    private string _OrderCode;
    [ObservableProperty]
    private string _AcceptName;
    [ObservableProperty]
    private string _AcceptPhone;
    [ObservableProperty]
    private string _AcceptAddress;
    [ObservableProperty]
    private string _GoodsName;
    [ObservableProperty]
    private decimal _Cod;
    [ObservableProperty]
    private int _Weight;
    [ObservableProperty]
    private bool _IsShopPay;
    [ObservableProperty]
    private string _Note;
    //private DateTime _CreateDate { get; set; }
    [ObservableProperty]
    private string _FkCustomerId;
    [ObservableProperty]
    private int _StatusOrder;
    [ObservableProperty]
    private int _ProvinceCode;
    [ObservableProperty]
    private int _DistrictCode;
    [ObservableProperty]
    private string _DistrictWard;
    [ObservableProperty]
    private int _Freight;
    [ObservableProperty]
    private string _FK_ShipperNot;

    [ObservableProperty]
    private string _FreightStr;

    private string _codStr;
    public string CodStr
    {
        get { return _codStr; }
        set
        {
            SetProperty(ref _codStr, value);
            if (string.IsNullOrWhiteSpace(value))
            {
                Cod = 0;
            }
            else
            {
                try
                {
                    Cod = decimal.Parse(value);
                }
                catch
                {
                    Cod = 0;
                }
            }
        }
    }

    private string _weightStr;
    public string WeightStr
    {
        get { return _weightStr; }
        set
        {
            SetProperty(ref _weightStr, value);
            if (string.IsNullOrWhiteSpace(value))
            {
                Weight = 0;
            }
            else
            {
                try
                {
                    Weight = int.Parse(value);
                }
                catch
                {
                    Weight = 0;
                }
            }
        }
    }

    [ObservableProperty]
    private string _copyId;
}

