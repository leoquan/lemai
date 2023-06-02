using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LeMaiDto;
using LeMaiMobile.Views;
using Prism.Navigation;
using Prism.Services.Dialogs;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Helpers;
using Xamarin.Essentials;
using System.Collections.ObjectModel;
using XF.Material.Forms.UI.Dialogs;
using Xamarin.Forms;
using Microcharts;
using SkiaSharp;
using XF.Material.Forms.Models;
using XF.Material.Forms.UI.Dialogs.Configurations;

namespace LeMaiMobile.ViewModels;

public partial class PageTrangChuViewModel : GhViewModelBase<PageTrangChu>
{
    public PageTrangChuViewModel(INavigationService navigationService, IDialogService dialogService, Models.IStatusBar myStatuBar)
        : base(navigationService, dialogService,myStatuBar)
    {

        ListMenu.Add(Version);
        
    }

    public override async void OnNavigatedTo(INavigationParameters parameters)
    {
        base.OnNavigatedTo(parameters);

        HoTen = App.UserInfo.HoTen;
        SoDienThoai = App.UserInfo.SoDienThoai;
        TaiKhoan = App.UserInfo.TaiKhoan;
        DisplayDateType();
        switch (parameters.GetNavigationMode())
        {
            case Prism.Navigation.NavigationMode.Back:
                break;
            case Prism.Navigation.NavigationMode.New:

                await CheckIsTestingAsync();
                if (IsModeTesting)
                {
                    ListMenu.Add("Xóa tài khoản");
                }
                ListMenu = ListMenu.ToList();

                LoadThongKeCommand.Execute(null);
                break;
            default:
                break;
        }
    }


    [ObservableProperty]
    private string _hoTen;
    [ObservableProperty]
    private string _soDienThoai;
    [ObservableProperty]
    private string _taiKhoan;



    [RelayCommand]
    private async Task DangXuatAsync()
    {
        var showLoading = false;
        if (DangXuatCommand.IsRunning || !CanCommandRun)
        {
            return;
        }

        try
        {
            CanCommandRun = false;
           

            var result = await MaterialDialog.Instance.ConfirmAsync(
                message: "Bạn có chắc muốn đăng xuất tài khoản?",
                title: "Đăng xuất",
                confirmingText: "Đồng ý",
                dismissiveText: GetTextForIos("Hủy bỏ")
            );

            if (!(result.HasValue && result.Value))
            {
                return;
            }

            showLoading = true;
            await ShowLoading();

            Preferences.Set("App_LoginUserInfo", "");
            App.UserInfo = new LoginUserInfo();

            await NavigationService.NavigateAsync($"/NavigationPage/{nameof(Views.PageDangNhap)}");
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(ex);
        }
        finally
        {
            CanCommandRun = true;
            if (showLoading)
            {
                await HideLoading();
            }
        }
    }





    ViewTrangChuFilterDate _groupDates = null;

    [ObservableProperty]
    private List<string> _listDateType = new List<string> {
            "Trước 7 ngày",
            "Trước 30 ngày",
            "Tuần này",
            "Tháng này",
            "Tháng trước",
            "Tùy chọn"
        };
    [ObservableProperty]
    private int _SelectedDateTypeIndex = 0;
    [ObservableProperty]
    private DateTime? _selectedDateTo = DateTime.Now;
    [ObservableProperty]
    private DateTime? _selectedDateFrom = DateTime.Now;

    [ObservableProperty]
    private string _selectDateTypeDisplay = "";

    private int _selectedFilterDateTypeIndex = 0;
    private DateTime? _selectedFilterDateTo = DateTime.Now;
    private DateTime? _selectedFilterDateFrom = DateTime.Now;

    [RelayCommand]
    private async Task ShowFilterDateAsync()
    {
        if (ShowFilterDateCommand.IsRunning || !CanCommandRun)
        {
            return;
        }

        var needFilter = false;
        try
        {
            CanCommandRun = false;
            //await ShowLoading();

            SelectedDateTypeIndex = _selectedFilterDateTypeIndex;
            SelectedDateTo = _selectedFilterDateTo;
            SelectedDateFrom = _selectedFilterDateFrom;

            _groupDates = new ViewTrangChuFilterDate();
            _groupDates.BindingContext = this;

            //Show confirmation dialog for choosing one or more, with pre-selected choices.
            var result = await MaterialDialog.Instance.ShowCustomContentAsync(
               view: _groupDates,
               message: "",
               title: "Thời gian vận đơn",
               confirmingText: "Xác nhận",
               dismissiveText: "Hủy bỏ");

            if (result.HasValue && result.Value)
            {
                // do nothing
            }
            else
            {
                return;
            }

            _selectedFilterDateTypeIndex = SelectedDateTypeIndex;
            _selectedFilterDateTo = SelectedDateTo;
            _selectedFilterDateFrom = SelectedDateFrom;

            if (!_selectedFilterDateTo.HasValue)
            {
                _selectedFilterDateTo = DateTime.Now;
            }
            if (!_selectedFilterDateFrom.HasValue)
            {
                _selectedFilterDateFrom = DateTime.Now;
            }

            DisplayDateType();

             needFilter = true;
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(ex);
        }
        finally
        {
            if (_groupDates != null)
            {
                _groupDates.BindingContext = null;
                _groupDates = null;
            }
            await HideLoading();
            CanCommandRun = true;
        }

        if (needFilter)
        {
            LoadThongKeCommand.Execute(null);
        }
    }

    private void DisplayDateType ()
    {
        var registerDateType = _listDateType[_selectedFilterDateTypeIndex];
        if (registerDateType == "Trước 7 ngày")
        {
            SelectDateTypeDisplay = registerDateType;
        }
        else if (registerDateType == "Trước 30 ngày")
        {
            SelectDateTypeDisplay = registerDateType;
        }
        else if (registerDateType == "Tuần này")
        {
            SelectDateTypeDisplay = registerDateType;
        }
        else if (registerDateType == "Tháng này")
        {
            SelectDateTypeDisplay = registerDateType;
        }
        else if (registerDateType == "Tháng trước")
        {
            SelectDateTypeDisplay = registerDateType;
        }
        else
        {
            SelectDateTypeDisplay = $"Tùy chọn {_selectedFilterDateTo:yyyy-MM-dd} -> {_selectedFilterDateFrom:yyyy-MM-dd}";
        }
    }

    [ObservableProperty]
    private VanDonThongKeOutput _thongKe = new VanDonThongKeOutput();

    [ObservableProperty]
    private Chart _chartVanDon = new DonutChart();

    [ObservableProperty]
    private ObservableCollection<ChartStatusModel> _listChartStatusModel = new ObservableCollection<ChartStatusModel>();

    //private List<string> _listStatusName = new List<string>();
    //private List<string> _listStatusBgColor = new List<string>();
    private bool _isLoadListStatus = false;
    [RelayCommand]
    private async Task LoadThongKeAsync()
    {
        if (LoadThongKeCommand.IsRunning || !CanCommandRun)
        {
            return;
        }

        try
        {
            CanCommandRun = false;
            await ShowLoading();

            if (!_isLoadListStatus)
            {
                // Call api lay thong tin can ho
                var request = new RestRequest("/Shipper/ListMasterVanDon", Method.Get);

                var response = await ExecuteApiAsync<VanDonListMasterOutput>(request);
                if (!response.isOk || response.data == null)
                {
                    return;
                }

                var listChartStatusModel = new List<ChartStatusModel>(response.data.ListStatusName.Count);
                for (int i = 0; i < response.data.ListStatusName.Count; i++)
                {
                    listChartStatusModel.Add(new ChartStatusModel
                    {
                        Ten = response.data.ListStatusName[i],
                        Mau = response.data.ListStatusBgColor[i],
                    });
                }
                ListChartStatusModel = new ObservableCollection<ChartStatusModel>(listChartStatusModel);
                _isLoadListStatus = true;
            }

            {
                // Call api lay thong tin can ho
                var request = new RestRequest("/Shipper/ThongKeVanDon", Method.Get);

                var dateType = _listDateType[_selectedFilterDateTypeIndex];
                request.AddQueryParameter("registerDateType", dateType);
                if (dateType == "Tùy chọn")
                {
                    if (!_selectedFilterDateFrom.HasValue)
                    {
                        _selectedFilterDateFrom = DateTime.Now;
                    }
                    if (!_selectedFilterDateTo.HasValue)
                    {
                        _selectedFilterDateTo = DateTime.Now;
                    }

                    request.AddQueryParameter("registerDateFrom", _selectedFilterDateFrom.Value.ToString("yyyy-MM-dd"));
                    request.AddQueryParameter("registerDateTo", _selectedFilterDateTo.Value.ToString("yyyy-MM-dd"));
                }

                var response = await ExecuteApiAsync<VanDonThongKeOutput>(request);
                if (!response.isOk || response.data == null)
                {
                    return;
                }

                ThongKe = response.data;

                var listChartEntry = new List<ChartEntry>(_listChartStatusModel.Count);
                for (int i = 0; i < _listChartStatusModel.Count; i++)
                {
                    var statusName = _listChartStatusModel[i].Ten;
                    var statusBgColor = _listChartStatusModel[i].Mau;

                    var count = 0;
                    var indexCountStatusName = response.data.ListStatusName.IndexOf(statusName);
                    if (indexCountStatusName > -1)
                    {
                        count = response.data.ListCountStatusName[indexCountStatusName];
                    }
                    _listChartStatusModel[i].SoLuong = count;
                    listChartEntry.Add(new ChartEntry(count)
                    {
                        Label = statusName,
                        ValueLabel = count.ToString("N0"),
                        Color = SKColor.Parse(statusBgColor)
                    });
                }

                var charVanDon = new DonutChart();
                charVanDon.Entries = listChartEntry;
                charVanDon.LabelMode = LabelMode.None;
                charVanDon.LabelTextSize = 30;
                ChartVanDon = charVanDon;
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



    [ObservableProperty]
    private List<string> _listMenu = new List<string>()
    {
        "Đổi mật khẩu",
        "Đăng xuất"
    };

    [RelayCommand]
    private async Task DoiMatKhauAsync()
    {
        var showLoading = false;
        if (DangXuatCommand.IsRunning || !CanCommandRun)
        {
            return;
        }

        try
        {
            CanCommandRun = false;


            var matKhauMoi = await MaterialDialog.Instance.InputAsync(
                title: "Đổi mật khẩu",
                message: "Nhập mật khẩu mới",
                confirmingText: "Đồng ý",
                dismissiveText: "Hủy bỏ",
                inputPlaceholder: "",
                configuration: new MaterialInputDialogConfiguration()
                {
                    InputMaxLength = 50,
                    InputType = XF.Material.Forms.UI.MaterialTextFieldInputType.Text
                }
            );

            if (string.IsNullOrWhiteSpace(matKhauMoi))
            {
                return;
            }

            showLoading = true;
            await ShowLoading();

            // Call api lay thong tin can ho
            var request = new RestRequest("/TaiKhoan/DoiMatKhau", Method.Post);
            request.AddJsonBody(new TaiKhoanDoiMatKhauInput
            {
                MatKhauMoi = matKhauMoi
            });

            var response = await ExecuteApiAsync<bool>(request);
            if (!response.isOk || !response.data)
            {
                return;
            }

            var nhoDangNhap = Preferences.Get("PageDangNhap_NhoMatKhau", false);
            if (nhoDangNhap)
            {
                Preferences.Set("PageDangNhap_MatKhau", matKhauMoi);
            }

            await AlertAsync("Đổi mật khẩu thành công");
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(ex);
        }
        finally
        {
            CanCommandRun = true;
            if (showLoading)
            {
                await HideLoading();
            }
        }
    }



    [RelayCommand]
    private async Task XoaTaiKhoanAsync()
    {
        var showLoading = false;
        if (XoaTaiKhoanCommand.IsRunning || !CanCommandRun)
        {
            return;
        }

        try
        {
            CanCommandRun = false;


            var result = await MaterialDialog.Instance.ConfirmAsync(
                message: "Bạn có chắc muốn xóa tài khoản ngày?",
                title: "Xác nhận",
                confirmingText: "Đồng ý",
                dismissiveText: GetTextForIos("Hủy bỏ")
            );

            if (!(result.HasValue && result.Value))
            {
                return;
            }

            showLoading = true;
            await ShowLoading();

            var request = new RestRequest("/TaiKhoan/XoaTaiKhoan", Method.Post);

            var response = await ExecuteApiAsync<bool>(request, isAuth: true);
            if (!response.isOk)
            {
                return;
            }

            Preferences.Set("App_LoginUserInfo", "");
            App.UserInfo = new LoginUserInfo();

            await AlertAsync("Xóa tài khoản thành công");

            await NavigationService.NavigateAsync($"/NavigationPage/{nameof(Views.PageDangNhap)}");
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(ex);
        }
        finally
        {
            CanCommandRun = true;
            if (showLoading)
            {
                await HideLoading();
            }
        }
    }

}

[ObservableObject]
public partial class ChartStatusModel
{
    [ObservableProperty]
    private string _ten;
    [ObservableProperty]
    private string _mau;
    [ObservableProperty]
    private int _soLuong;
}