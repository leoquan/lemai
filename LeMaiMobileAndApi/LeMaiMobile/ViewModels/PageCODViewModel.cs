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

public partial class PageCODViewModel : GhViewModelBase<PageCOD>
{
    public PageCODViewModel(INavigationService navigationService, IDialogService dialogService, Models.IStatusBar myStatuBar)
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
                LoadDanhSachAsync().ConfigureAwait(false);
                break;
            default:
                break;
        }
    }

    private async Task LoadDanhSachAsync()
    {
        await LoadDanhSachDaThanhToanAsync();
        await LoadDanhSachChuaThanhToanAsync();
    }

    #region DaThanhToan
    [ObservableProperty]
    private ObservableCollection<VanDonDanhSachOutput> _listDanhSachDaThanhToan = new ObservableCollection<VanDonDanhSachOutput>();
    private List<VanDonDanhSachOutput> _listDanhSachDaThanhToanAll = new List<VanDonDanhSachOutput>();

    private bool _isLoadListStatusDaThanhToan = false;
    [RelayCommand]
    private async Task LoadDanhSachDaThanhToanAsync()
    {
        if (LoadDanhSachDaThanhToanCommand.IsRunning || !CanCommandRun)
        {
            return;
        }

        var needFilter = false;
        try
        {
            CanCommandRun = false;
            await ShowLoading();

            if (!_isLoadListStatusDaThanhToan)
            {
                // Call api lay thong tin can ho
                var request = new RestRequest("/VanDon/ListMaster", Method.Get);

                var response = await ExecuteApiAsync<VanDonListMasterOutput>(request);
                if (!response.isOk || response.data == null)
                {
                    return;
                }

                _listStatusNameDaThanhToan = response.data.ListStatusName;
                _listStatusDaThanhToan = response.data.ListStatusName.Select(h => new StatusNameModel
                {
                    Name = h,
                    IsChecked = true,
                    SaveChecked = true
                }).ToList();

                _isLoadListStatusDaThanhToan = true;
            }

            {
                // Call api lay thong tin can ho
                var request = new RestRequest("/VanDon/DanhSach", Method.Get);
                request.AddQueryParameter("isSigned", true);
                request.AddQueryParameter("isPayCustomer", true);

                var dateType = _listDateTypeDaThanhToan[_selectedFilterDateTypeIndexDaThanhToan];
                request.AddQueryParameter("registerDateType", dateType);
                if (dateType == "Tùy chọn")
                {
                    if (!_selectedFilterDateFromDaThanhToan.HasValue)
                    {
                        _selectedFilterDateFromDaThanhToan = DateTime.Now;
                    }
                    if (!_selectedFilterDateToDaThanhToan.HasValue)
                    {
                        _selectedFilterDateToDaThanhToan = DateTime.Now;
                    }

                    request.AddQueryParameter("registerDateFrom", _selectedFilterDateFromDaThanhToan.Value.ToString("yyyy-MM-dd"));
                    request.AddQueryParameter("registerDateTo", _selectedFilterDateToDaThanhToan.Value.ToString("yyyy-MM-dd"));
                }

                var response = await ExecuteApiAsync<List<VanDonDanhSachOutput>>(request);
                if (!response.isOk || response.data == null)
                {
                    return;
                }


                _listDanhSachDaThanhToanAll = response.data;
                foreach (var item in _listDanhSachDaThanhToanAll)
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
            FilterVanDonDaThanhToanCommand.Execute(null);
        }
    }




    [RelayCommand]
    private async Task FilterVanDonDaThanhToanAsync()
    {
        if (FilterVanDonDaThanhToanCommand.IsRunning || !CanCommandRun)
        {
            return;
        }

        try
        {
            CanCommandRun = false;
            //await ShowLoading();

            if ((_listStatusNameDaThanhToan.Count == 0
                || _listStatusNameDaThanhToan.Count == _listStatusDaThanhToan.Count)
                && string.IsNullOrWhiteSpace(_filterTextVanDonDaThanhToan)
                )
            {
                ListDanhSachDaThanhToan = new ObservableCollection<VanDonDanhSachOutput>(_listDanhSachDaThanhToanAll);
                return;
            }

            var query = _listDanhSachDaThanhToanAll.AsQueryable();

            if (_listStatusNameDaThanhToan.Count > 0
                && _listStatusNameDaThanhToan.Count < _listStatusDaThanhToan.Count)
            {
                query = query.Where(h => _listStatusNameDaThanhToan.Contains(h.StatusName));
            }

            if (!string.IsNullOrWhiteSpace(_filterTextVanDonDaThanhToan))
            {
                var filterText = _filterTextVanDonDaThanhToan.NormlizeWhitespace();
                //var filterTextUpper = filterText.ToUpper();
                var filterTextNonUnicodeUpper = filterText.NonUnicodeUpper();

                query = query.Where(h =>
                    h.BillCode.Contains(filterTextNonUnicodeUpper)
                    || h.AcceptManPhone.Contains(filterTextNonUnicodeUpper)
                    || h.AcceptManNonUnicodeUpper.Contains(filterTextNonUnicodeUpper)
                );
            }

            ListDanhSachDaThanhToan = new ObservableCollection<VanDonDanhSachOutput>(query.ToList());
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(ex);
        }
        finally
        {
            IsRefeshListVanDonDaThanhToan = false;
            //await HideLoading();
            CanCommandRun = true;
        }
    }




    private List<StatusNameModel> _listStatusDaThanhToan = new List<StatusNameModel>();
    private List<string> _listStatusNameDaThanhToan = new List<string>();
    ViewVanDonFilterStatus _groupStatusDaThanhToan = null;

    [ObservableProperty]
    private bool _isFilterStatusActiveDaThanhToan = false;
    [RelayCommand]
    private async Task ShowFilterStatusDaThanhToanAsync()
    {
        if (ShowFilterStatusDaThanhToanCommand.IsRunning || !CanCommandRun)
        {
            return;
        }

        var needFilter = false;
        try
        {
            CanCommandRun = false;
            await ShowLoading();

            foreach (var item in _listStatusDaThanhToan)
            {
                item.IsChecked = item.SaveChecked;
            }

            _groupStatusDaThanhToan = new ViewVanDonFilterStatus();
            _groupStatusDaThanhToan.ListStatus = _listStatusDaThanhToan;

            //Show confirmation dialog for choosing one or more, with pre-selected choices.
            var result = await MaterialDialog.Instance.ShowCustomContentAsync(
               view: _groupStatusDaThanhToan,
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

            foreach (var item in _listStatusDaThanhToan)
            {
                item.SaveChecked = item.IsChecked;
            }
            _listStatusNameDaThanhToan = _listStatusDaThanhToan.Where(h => h.SaveChecked).Select(h => h.Name).ToList();
            if (_listStatusNameDaThanhToan.Count == 0 || _listStatusNameDaThanhToan.Count == _listStatusDaThanhToan.Count)
            {
                IsFilterStatusActiveDaThanhToan = false;
            }
            else
            {
                IsFilterStatusActiveDaThanhToan = true;
            }
            needFilter = true;
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(ex);
        }
        finally
        {
            if (_groupStatusDaThanhToan != null)
            {
                _groupStatusDaThanhToan.BindingContext = null;
                _groupStatusDaThanhToan = null;
            }
            await HideLoading();
            CanCommandRun = true;
        }

        if (needFilter)
        {
            FilterVanDonDaThanhToanCommand.Execute(null);
        }
    }



    ViewCODDaThanhToanFilterDate _groupDatesDaThanhToan = null;

    [ObservableProperty]
    private List<string> _listDateTypeDaThanhToan = new List<string> {
            "Trước 7 ngày",
            "Trước 30 ngày",
            "Tuần này",
            "Tháng này",
            "Tháng trước",
            "Tùy chọn"
        };
    [ObservableProperty]
    private int _SelectedDateTypeIndexDaThanhToan = 0;
    [ObservableProperty]
    private DateTime? _selectedDateToDaThanhToan = DateTime.Now;
    [ObservableProperty]
    private DateTime? _selectedDateFromDaThanhToan = DateTime.Now;

    private int _selectedFilterDateTypeIndexDaThanhToan = 0;
    private DateTime? _selectedFilterDateToDaThanhToan = DateTime.Now;
    private DateTime? _selectedFilterDateFromDaThanhToan = DateTime.Now;

    [RelayCommand]
    private async Task ShowFilterDateDaThanhToanAsync()
    {
        if (ShowFilterDateDaThanhToanCommand.IsRunning || !CanCommandRun)
        {
            return;
        }

        var needFilter = false;
        try
        {
            CanCommandRun = false;
            //await ShowLoading();

            SelectedDateTypeIndexDaThanhToan = _selectedFilterDateTypeIndexDaThanhToan;
            SelectedDateToDaThanhToan = _selectedFilterDateToDaThanhToan;
            SelectedDateFromDaThanhToan = _selectedFilterDateFromDaThanhToan;

            _groupDatesDaThanhToan = new ViewCODDaThanhToanFilterDate();
            _groupDatesDaThanhToan.BindingContext = this;

            //Show confirmation dialog for choosing one or more, with pre-selected choices.
            var result = await MaterialDialog.Instance.ShowCustomContentAsync(
               view: _groupDatesDaThanhToan,
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

            _selectedFilterDateTypeIndexDaThanhToan = SelectedDateTypeIndexDaThanhToan;
            _selectedFilterDateToDaThanhToan = SelectedDateToDaThanhToan;
            _selectedFilterDateFromDaThanhToan = SelectedDateFromDaThanhToan;

            if (!_selectedFilterDateToDaThanhToan.HasValue)
            {
                _selectedFilterDateToDaThanhToan = DateTime.Now;
            }
            if (!_selectedFilterDateFromDaThanhToan.HasValue)
            {
                _selectedFilterDateFromDaThanhToan = DateTime.Now;
            }

            needFilter = true;
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(ex);
        }
        finally
        {
            if (_groupDatesDaThanhToan != null)
            {
                _groupDatesDaThanhToan.BindingContext = null;
                _groupDatesDaThanhToan = null;
            }
            await HideLoading();
            CanCommandRun = true;
        }

        if (needFilter)
        {
            LoadDanhSachDaThanhToanCommand.Execute(null);
        }
    }




    [ObservableProperty]
    private string _filterTextVanDonDaThanhToan = "";
    [ObservableProperty]
    private bool _isRefeshListVanDonDaThanhToan = false;
    #endregion

    #region ChuaThanhToan
    [ObservableProperty]
    private ObservableCollection<VanDonDanhSachOutput> _listDanhSachChuaThanhToan = new ObservableCollection<VanDonDanhSachOutput>();
    private List<VanDonDanhSachOutput> _listDanhSachChuaThanhToanAll = new List<VanDonDanhSachOutput>();

    private bool _isLoadListStatusChuaThanhToan = false;
    [RelayCommand]
    private async Task LoadDanhSachChuaThanhToanAsync()
    {
        if (LoadDanhSachChuaThanhToanCommand.IsRunning || !CanCommandRun)
        {
            return;
        }

        var needFilter = false;
        try
        {
            CanCommandRun = false;
            await ShowLoading();

            if (!_isLoadListStatusChuaThanhToan)
            {
                // Call api lay thong tin can ho
                var request = new RestRequest("/VanDon/ListMaster", Method.Get);

                var response = await ExecuteApiAsync<VanDonListMasterOutput>(request);
                if (!response.isOk || response.data == null)
                {
                    return;
                }

                _listStatusNameChuaThanhToan = response.data.ListStatusName;
                _listStatusChuaThanhToan = response.data.ListStatusName.Select(h => new StatusNameModel
                {
                    Name = h,
                    IsChecked = true,
                    SaveChecked = true
                }).ToList();

                _isLoadListStatusChuaThanhToan = true;
            }

            {
                // Call api lay thong tin can ho
                var request = new RestRequest("/VanDon/DanhSach", Method.Get);
                request.AddQueryParameter("isSigned", true);
                request.AddQueryParameter("isPayCustomer", false);

                var dateType = _listDateTypeChuaThanhToan[_selectedFilterDateTypeIndexChuaThanhToan];
                request.AddQueryParameter("registerDateType", dateType);
                if (dateType == "Tùy chọn")
                {
                    if (!_selectedFilterDateFromChuaThanhToan.HasValue)
                    {
                        _selectedFilterDateFromChuaThanhToan = DateTime.Now;
                    }
                    if (!_selectedFilterDateToChuaThanhToan.HasValue)
                    {
                        _selectedFilterDateToChuaThanhToan = DateTime.Now;
                    }

                    request.AddQueryParameter("registerDateFrom", _selectedFilterDateFromChuaThanhToan.Value.ToString("yyyy-MM-dd"));
                    request.AddQueryParameter("registerDateTo", _selectedFilterDateToChuaThanhToan.Value.ToString("yyyy-MM-dd"));
                }

                var response = await ExecuteApiAsync<List<VanDonDanhSachOutput>>(request);
                if (!response.isOk || response.data == null)
                {
                    return;
                }


                _listDanhSachChuaThanhToanAll = response.data;
                foreach (var item in _listDanhSachChuaThanhToanAll)
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
            FilterVanDonChuaThanhToanCommand.Execute(null);
        }
    }




    [RelayCommand]
    private async Task FilterVanDonChuaThanhToanAsync()
    {
        if (FilterVanDonChuaThanhToanCommand.IsRunning || !CanCommandRun)
        {
            return;
        }

        try
        {
            CanCommandRun = false;
            //await ShowLoading();

            if ((_listStatusNameChuaThanhToan.Count == 0
                || _listStatusNameChuaThanhToan.Count == _listStatusChuaThanhToan.Count)
                && string.IsNullOrWhiteSpace(_filterTextVanDonChuaThanhToan)
                )
            {
                ListDanhSachChuaThanhToan = new ObservableCollection<VanDonDanhSachOutput>(_listDanhSachChuaThanhToanAll);
                return;
            }

            var query = _listDanhSachChuaThanhToanAll.AsQueryable();

            if (_listStatusNameChuaThanhToan.Count > 0
                && _listStatusNameChuaThanhToan.Count < _listStatusChuaThanhToan.Count)
            {
                query = query.Where(h => _listStatusNameChuaThanhToan.Contains(h.StatusName));
            }

            if (!string.IsNullOrWhiteSpace(_filterTextVanDonChuaThanhToan))
            {
                var filterText = _filterTextVanDonChuaThanhToan.NormlizeWhitespace();
                //var filterTextUpper = filterText.ToUpper();
                var filterTextNonUnicodeUpper = filterText.NonUnicodeUpper();

                query = query.Where(h =>
                    h.BillCode.Contains(filterTextNonUnicodeUpper)
                    || h.AcceptManPhone.Contains(filterTextNonUnicodeUpper)
                    || h.AcceptManNonUnicodeUpper.Contains(filterTextNonUnicodeUpper)
                );
            }

            ListDanhSachChuaThanhToan = new ObservableCollection<VanDonDanhSachOutput>(query.ToList());
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(ex);
        }
        finally
        {
            IsRefeshListVanDonChuaThanhToan = false;
            //await HideLoading();
            CanCommandRun = true;
        }
    }




    private List<StatusNameModel> _listStatusChuaThanhToan = new List<StatusNameModel>();
    private List<string> _listStatusNameChuaThanhToan = new List<string>();
    ViewVanDonFilterStatus _groupStatusChuaThanhToan = null;

    [ObservableProperty]
    private bool _isFilterStatusActiveChuaThanhToan = false;
    [RelayCommand]
    private async Task ShowFilterStatusChuaThanhToanAsync()
    {
        if (ShowFilterStatusChuaThanhToanCommand.IsRunning || !CanCommandRun)
        {
            return;
        }

        var needFilter = false;
        try
        {
            CanCommandRun = false;
            await ShowLoading();

            foreach (var item in _listStatusChuaThanhToan)
            {
                item.IsChecked = item.SaveChecked;
            }

            _groupStatusChuaThanhToan = new ViewVanDonFilterStatus();
            _groupStatusChuaThanhToan.ListStatus = _listStatusChuaThanhToan;

            //Show confirmation dialog for choosing one or more, with pre-selected choices.
            var result = await MaterialDialog.Instance.ShowCustomContentAsync(
               view: _groupStatusChuaThanhToan,
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

            foreach (var item in _listStatusChuaThanhToan)
            {
                item.SaveChecked = item.IsChecked;
            }
            _listStatusNameChuaThanhToan = _listStatusChuaThanhToan.Where(h => h.SaveChecked).Select(h => h.Name).ToList();
            if (_listStatusNameChuaThanhToan.Count == 0 || _listStatusNameChuaThanhToan.Count == _listStatusChuaThanhToan.Count)
            {
                IsFilterStatusActiveChuaThanhToan = false;
            }
            else
            {
                IsFilterStatusActiveChuaThanhToan = true;
            }
            needFilter = true;
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(ex);
        }
        finally
        {
            if (_groupStatusChuaThanhToan != null)
            {
                _groupStatusChuaThanhToan.BindingContext = null;
                _groupStatusChuaThanhToan = null;
            }
            await HideLoading();
            CanCommandRun = true;
        }

        if (needFilter)
        {
            FilterVanDonChuaThanhToanCommand.Execute(null);
        }
    }



    ViewCODChuaThanhToanFilterDate _groupDatesChuaThanhToan = null;

    [ObservableProperty]
    private List<string> _listDateTypeChuaThanhToan = new List<string> {
            "Trước 7 ngày",
            "Trước 30 ngày",
            "Tuần này",
            "Tháng này",
            "Tháng trước",
            "Tùy chọn"
        };
    [ObservableProperty]
    private int _SelectedDateTypeIndexChuaThanhToan = 0;
    [ObservableProperty]
    private DateTime? _selectedDateToChuaThanhToan = DateTime.Now;
    [ObservableProperty]
    private DateTime? _selectedDateFromChuaThanhToan = DateTime.Now;

    private int _selectedFilterDateTypeIndexChuaThanhToan = 0;
    private DateTime? _selectedFilterDateToChuaThanhToan = DateTime.Now;
    private DateTime? _selectedFilterDateFromChuaThanhToan = DateTime.Now;

    [RelayCommand]
    private async Task ShowFilterDateChuaThanhToanAsync()
    {
        if (ShowFilterDateChuaThanhToanCommand.IsRunning || !CanCommandRun)
        {
            return;
        }

        var needFilter = false;
        try
        {
            CanCommandRun = false;
            //await ShowLoading();

            SelectedDateTypeIndexChuaThanhToan = _selectedFilterDateTypeIndexChuaThanhToan;
            SelectedDateToChuaThanhToan = _selectedFilterDateToChuaThanhToan;
            SelectedDateFromChuaThanhToan = _selectedFilterDateFromChuaThanhToan;

            _groupDatesChuaThanhToan = new ViewCODChuaThanhToanFilterDate();
            _groupDatesChuaThanhToan.BindingContext = this;

            //Show confirmation dialog for choosing one or more, with pre-selected choices.
            var result = await MaterialDialog.Instance.ShowCustomContentAsync(
               view: _groupDatesChuaThanhToan,
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

            _selectedFilterDateTypeIndexChuaThanhToan = SelectedDateTypeIndexChuaThanhToan;
            _selectedFilterDateToChuaThanhToan = SelectedDateToChuaThanhToan;
            _selectedFilterDateFromChuaThanhToan = SelectedDateFromChuaThanhToan;

            if (!_selectedFilterDateToChuaThanhToan.HasValue)
            {
                _selectedFilterDateToChuaThanhToan = DateTime.Now;
            }
            if (!_selectedFilterDateFromChuaThanhToan.HasValue)
            {
                _selectedFilterDateFromChuaThanhToan = DateTime.Now;
            }

            needFilter = true;
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(ex);
        }
        finally
        {
            if (_groupDatesChuaThanhToan != null)
            {
                _groupDatesChuaThanhToan.BindingContext = null;
                _groupDatesChuaThanhToan = null;
            }
            await HideLoading();
            CanCommandRun = true;
        }

        if (needFilter)
        {
            LoadDanhSachChuaThanhToanCommand.Execute(null);
        }
    }




    [ObservableProperty]
    private string _filterTextVanDonChuaThanhToan = "";
    [ObservableProperty]
    private bool _isRefeshListVanDonChuaThanhToan = false;
    #endregion















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

}