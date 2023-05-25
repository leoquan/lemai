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
using LeMaiMobile.Models;
using XF.Material.Forms.UI;

namespace LeMaiMobile.ViewModels;

public partial class PageVanDonViewModel : GhViewModelBase<PageVanDon>
{
    public PageVanDonViewModel(INavigationService navigationService, IDialogService dialogService, Models.IStatusBar myStatuBar)
        : base(navigationService, dialogService, myStatuBar)
    {
    }

    public override async void OnNavigatedTo(INavigationParameters parameters)
    {
        base.OnNavigatedTo(parameters);

        switch (parameters.GetNavigationMode())
        {
            case Prism.Navigation.NavigationMode.Back:
                break;
            case Prism.Navigation.NavigationMode.New:
                LoadDanhSachCommand.Execute(null);
                break;
            default:
                break;
        }
    }



    [ObservableProperty]
    private ObservableCollection<VanDonDanhSachOutput> _listDanhSach = new ObservableCollection<VanDonDanhSachOutput>();
    private List<VanDonDanhSachOutput> _listDanhSachAll = new List<VanDonDanhSachOutput>();

    private bool _isLoadListStatus = false;
    [RelayCommand]
    private async Task LoadDanhSachAsync()
    {
        if (LoadDanhSachCommand.IsRunning || !CanCommandRun)
        {
            return;
        }

        var needFilter = false;
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

                _listStatusName = response.data.ListStatusName;
                _listStatus = response.data.ListStatusName.Select(h => new StatusNameModel
                {
                    Name = h,
                    IsChecked = true,
                    SaveChecked = true
                }).ToList();

                _isLoadListStatus = true;
            }

            {
                // Call api lay thong tin can ho
                var request = new RestRequest("/Shipper/DanhSachVanDon", Method.Get);

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

                var response = await ExecuteApiAsync<List<VanDonDanhSachOutput>>(request);
                if (!response.isOk || response.data == null)
                {
                    return;
                }
                _listDanhSachAll = response.data;
                foreach (var item in _listDanhSachAll)
                {
                    item.BillCode = item.BillCode.NormlizeWhitespace().ToUpper();
                    item.AcceptManPhone = item.AcceptManPhone.NormlizeWhitespace().ToUpper();
                    item.AcceptMan = item.AcceptMan.NormlizeWhitespace();
                    //item.AcceptManUpper = item.AcceptMan.ToUpper();
                    item.AcceptManNonUnicodeUpper = item.AcceptMan.NonUnicodeUpper();
                }

                needFilter = true;
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

        if (needFilter)
        {
            FilterVanDonCommand.Execute(null);
        }
    }


    [RelayCommand]
    private async Task ChiTietVanDonAsync(string billCode)
    {
        if (ChiTietVanDonCommand.IsRunning || !CanCommandRun || string.IsNullOrWhiteSpace(billCode))
        {
            return;
        }

        try
        {
            CanCommandRun = false;
            await ShowLoading();

            var navParam = new NavigationParameters();
            navParam.Add("billCode", billCode);
            navParam.Add("modeView", "ThongTin");

            await NavigationService.NavigateAsync($"{nameof(Views.PageVanDonChiTiet)}", navParam);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(ex);
        }
        finally
        {
            await HideLoading();
            CanCommandRun = true;
        }
    }

    [RelayCommand]
    private async Task ChiTietHanhTrinhAsync(string billCode)
    {
        if (ChiTietHanhTrinhCommand.IsRunning || !CanCommandRun || string.IsNullOrWhiteSpace(billCode))
        {
            return;
        }

        try
        {
            CanCommandRun = false;
            await ShowLoading();

            var navParam = new NavigationParameters();
            navParam.Add("billCode", billCode);
            navParam.Add("modeView", "HanhTrinh");

            await NavigationService.NavigateAsync($"{nameof(Views.PageVanDonChiTiet)}", navParam);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(ex);
        }
        finally
        {
            await HideLoading();
            CanCommandRun = true;
        }
    }


    [RelayCommand]
    private async Task FilterVanDonAsync()
    {
        if (FilterVanDonCommand.IsRunning || !CanCommandRun)
        {
            return;
        }

        try
        {
            CanCommandRun = false;
            //await ShowLoading();

            if ((_listStatusName.Count == 0
                || _listStatusName.Count == _listStatus.Count)
                && string.IsNullOrWhiteSpace(_filterTextVanDon)
                )
            {
                ListDanhSach = new ObservableCollection<VanDonDanhSachOutput>(_listDanhSachAll);
                return;
            }

            var query = _listDanhSachAll.AsQueryable();

            if (_listStatusName.Count > 0
                && _listStatusName.Count < _listStatus.Count)
            {
                query = query.Where(h => _listStatusName.Contains(h.StatusName));
            }

            if (!string.IsNullOrWhiteSpace(_filterTextVanDon))
            {
                var filterText = _filterTextVanDon.NormlizeWhitespace();
                //var filterTextUpper = filterText.ToUpper();
                var filterTextNonUnicodeUpper = filterText.NonUnicodeUpper();

                query = query.Where(h =>
                    h.BillCode.Contains(filterTextNonUnicodeUpper)
                    || h.AcceptManPhone.Contains(filterTextNonUnicodeUpper)
                    || h.AcceptManNonUnicodeUpper.Contains(filterTextNonUnicodeUpper)
                );
            }

            ListDanhSach = new ObservableCollection<VanDonDanhSachOutput>(query.ToList());
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(ex);
        }
        finally
        {
            IsRefeshListVanDon = false;
            //await HideLoading();
            CanCommandRun = true;
        }
    }




    private List<StatusNameModel> _listStatus = new List<StatusNameModel>();
    private List<string> _listStatusName = new List<string>();
    ViewVanDonFilterStatus _groupStatus = null;

    [ObservableProperty]
    private bool _isFilterStatusActive = false;
    [RelayCommand]
    private async Task ShowFilterStatusAsync()
    {
        if (ShowFilterStatusCommand.IsRunning || !CanCommandRun)
        {
            return;
        }

        var needFilter = false;
        try
        {
            CanCommandRun = false;
            await ShowLoading();

            foreach (var item in _listStatus)
            {
                item.IsChecked = item.SaveChecked;
            }

            _groupStatus = new ViewVanDonFilterStatus();
            _groupStatus.ListStatus = _listStatus;

            //Show confirmation dialog for choosing one or more, with pre-selected choices.
            var result = await MaterialDialog.Instance.ShowCustomContentAsync(
               view: _groupStatus,
               message: "",
               title: "Trạng thái vận đơn",
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

            foreach (var item in _listStatus)
            {
                item.SaveChecked = item.IsChecked;
            }
            _listStatusName = _listStatus.Where(h => h.SaveChecked).Select(h => h.Name).ToList();
            if (_listStatusName.Count == 0 || _listStatusName.Count == _listStatus.Count)
            {
                IsFilterStatusActive = false;
            }
            else
            {
                IsFilterStatusActive = true;
            }
            needFilter = true;
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(ex);
        }
        finally
        {
            if (_groupStatus != null)
            {
                _groupStatus.BindingContext = null;
                _groupStatus = null;
            }
            await HideLoading();
            CanCommandRun = true;
        }

        if (needFilter)
        {
            FilterVanDonCommand.Execute(null);
        }
    }



    ViewVanDonFilterDate _groupDates = null;

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

            _groupDates = new ViewVanDonFilterDate();
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
            LoadDanhSachCommand.Execute(null);
        }
    }






    [ObservableProperty]
    private string _filterTextVanDon = "";
    [ObservableProperty]
    private bool _isRefeshListVanDon = false;


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
               "Đã sao chép mã vận đơn vào bộ nhớ tạm",
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
    private async Task MakePhoneCallAsync(string phone)
    {
        if (CopyBillCodeCommand.IsRunning || !CanCommandRun || string.IsNullOrWhiteSpace(phone))
        {
            return;
        }

        try
        {
            CanCommandRun = false;
            try
            {
                PhoneDialer.Open(phone);
            }
            catch (Exception err)
            {
                await Clipboard.SetTextAsync(phone);
                _ = MaterialDialog.Instance.SnackbarAsync("Đã sao chép số điện thoại vào bộ nhớ tạm", msDuration: 2000);
            }
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

}

[ObservableObject]
public partial class StatusNameModel
{
    [ObservableProperty]
    private bool _isChecked;

    [ObservableProperty]
    private string _name;

    public bool SaveChecked { get; set; }
}