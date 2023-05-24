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

public partial class PageDonDatViewModel : GhViewModelBase<PageDonDat>
{
    public PageDonDatViewModel(INavigationService navigationService, IDialogService dialogService, Models.IStatusBar myStatuBar)
        : base(navigationService, dialogService, myStatuBar)
    {
    }

    public override async void OnNavigatedTo(INavigationParameters parameters)
    {
        base.OnNavigatedTo(parameters);

        switch (parameters.GetNavigationMode())
        {
            case Prism.Navigation.NavigationMode.Back:
                if (_tranferModel != null 
                    && !string.IsNullOrWhiteSpace(_tranferModel.Id)
                    && _tranferModel.IsSave)
                {
                    LoadChiTietCommand.Execute(null);
                }
                break;
            case Prism.Navigation.NavigationMode.New:
                LoadDanhSachCommand.Execute(null);
                break;
            default:
                break;
        }
    }





    [ObservableProperty]
    private ObservableCollection<DonDatDanhSachOutput> _listDanhSach = new ObservableCollection<DonDatDanhSachOutput>();
    private List<DonDatDanhSachOutput> _listDanhSachAll = new List<DonDatDanhSachOutput>();

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
                var request = new RestRequest("/DonDat/ListMaster", Method.Get);

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
                var request = new RestRequest("/DonDat/DanhSach", Method.Get);

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

                var response = await ExecuteApiAsync<List<DonDatDanhSachOutput>>(request);
                if (!response.isOk || response.data == null)
                {
                    return;
                }


                _listDanhSachAll = response.data;
                foreach (var item in _listDanhSachAll)
                {
                    item.OrderCode = item.OrderCode.NormlizeWhitespace().ToUpper();
                    item.AcceptPhone = item.AcceptPhone.NormlizeWhitespace().ToUpper();
                    item.AcceptName = item.AcceptName.NormlizeWhitespace();
                    //item.AcceptManUpper = item.AcceptMan.ToUpper();
                    item.AcceptManNonUnicodeUpper = item.AcceptName.NonUnicodeUpper();
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
    private async Task LoadChiTietAsync()
    {
        if (LoadChiTietCommand.IsRunning || !CanCommandRun)
        {
            return;
        }

        try
        {
            CanCommandRun = false;
            await ShowLoading();


            // Call api lay thong tin can ho
            var request = new RestRequest("/DonDat/DanhSach", Method.Get);
            request.AddQueryParameter("id", _tranferModel.Id);

            var response = await ExecuteApiAsync<List<DonDatDanhSachOutput>>(request);
            if (!response.isOk || response.data == null || response.data.Count == 0)
            {
                return;
            }

            foreach (var item in response.data)
            {
                item.OrderCode = item.OrderCode.NormlizeWhitespace().ToUpper();
                item.AcceptPhone = item.AcceptPhone.NormlizeWhitespace().ToUpper();
                item.AcceptName = item.AcceptName.NormlizeWhitespace();
                //item.AcceptManUpper = item.AcceptMan.ToUpper();
                item.AcceptManNonUnicodeUpper = item.AcceptName.NonUnicodeUpper();
            }

            {
                var modelItemIndex = _listDanhSachAll.FindIndex(h => h.Id == _tranferModel.Id);
                if (modelItemIndex == -1)
                {
                    _listDanhSachAll.Insert(0, response.data[0]);
                }
                else
                {
                    _listDanhSachAll.RemoveAt(modelItemIndex);
                    _listDanhSachAll.Insert(modelItemIndex, response.data[0]);
                }
            }

            {
                var modelItem = ListDanhSach.FirstOrDefault(h => h.Id == _tranferModel.Id);
                if (modelItem != null)
                {
                    var modelItemIndex = ListDanhSach.IndexOf(modelItem);
                    if (modelItemIndex == -1)
                    {
                        ListDanhSach.Insert(0, response.data[0]);
                    }
                    else
                    {
                        ListDanhSach.RemoveAt(modelItemIndex);
                        ListDanhSach.Insert(modelItemIndex, response.data[0]);
                    }
                }
                else
                {
                    ListDanhSach.Insert(0, response.data[0]);
                }
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
                ListDanhSach = new ObservableCollection<DonDatDanhSachOutput>(_listDanhSachAll);
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
                    h.OrderCode.Contains(filterTextNonUnicodeUpper)
                    || h.AcceptPhone.Contains(filterTextNonUnicodeUpper)
                    || h.AcceptManNonUnicodeUpper.Contains(filterTextNonUnicodeUpper)
                );
            }

            ListDanhSach = new ObservableCollection<DonDatDanhSachOutput>(query.ToList());
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



    ViewDonDatFilterDate _groupDates = null;

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

            _groupDates = new ViewDonDatFilterDate();
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


    private DonDatDanhSachOutput _tranferModel = null;

    [RelayCommand]
    private async Task TaoMoiDonDatAsync()
    {
        if (TaoMoiDonDatCommand.IsRunning || !CanCommandRun)
        {
            return;
        }

        try
        {
            CanCommandRun = false;
            await ShowLoading();

            _tranferModel = new DonDatDanhSachOutput();

            var navParam = new NavigationParameters();
            navParam.Add("model", _tranferModel);
            await NavigationService.NavigateAsync($"{nameof(Views.PageDonDatChiTiet)}", navParam);
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
    private async Task CapNhatDonDatAsync(string id)
    {
        if (CapNhatDonDatCommand.IsRunning || !CanCommandRun)
        {
            return;
        }

        try
        {
            CanCommandRun = false;
            await ShowLoading();


            _tranferModel = new DonDatDanhSachOutput();
            _tranferModel.Id = id;
            _tranferModel.IsEdit = true;

            var navParam = new NavigationParameters();
            navParam.Add("model", _tranferModel);
            await NavigationService.NavigateAsync($"{nameof(Views.PageDonDatChiTiet)}", navParam);
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
    private async Task XoaDonDatAsync(string id)
    {
        if (XoaDonDatCommand.IsRunning || !CanCommandRun)
        {
            return;
        }

        var showLoading = false;
        try
        {
            CanCommandRun = false;

            var result = await MaterialDialog.Instance.ConfirmAsync(
               message: "Bạn có chắc muốn xóa đơn đặt này?",
               title: "Xác nhận xóa",
               confirmingText: "Đồng ý",
               dismissiveText: GetTextForIos("Hủy bỏ")
           );

            if (!(result.HasValue && result.Value))
            {
                return;
            }

            
            await ShowLoading();
            showLoading = true;


            // Call api xóa đơn đặt
            var request = new RestRequest("/DonDat/Xoa", Method.Post);
            request.AddQueryParameter("id", id);

            var response = await ExecuteApiAsync<bool>(request);
            if (!response.isOk || !response.data)
            {
                return;
            }

            {
                var modelItemIndex = _listDanhSachAll.FindIndex(h => h.Id == id);
                if (modelItemIndex > -1)
                {
                    _listDanhSachAll.RemoveAt(modelItemIndex);
                }
            }

            {
                var modelItem = ListDanhSach.FirstOrDefault(h => h.Id == id);
                if (modelItem != null)
                {
                    ListDanhSach.Remove(modelItem);
                }
            }

            await AlertAsync(
               message: "Xóa thành công đơn đặt.",
               title: "Thông báo",
               acknowledgementText: "Đóng"
               );
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
    private async Task SaoChepDonDatAsync(string id)
    {
        if (CapNhatDonDatCommand.IsRunning || !CanCommandRun)
        {
            return;
        }

        try
        {
            CanCommandRun = false;

            var maDonDat = _listDanhSachAll.FirstOrDefault(h => h.Id == id).OrderCode;
            var result = await MaterialDialog.Instance.ConfirmAsync(
              message: $"Bạn có muốn tạo thêm một đơn đặt hàng giống đơn hàng mã [{maDonDat}] hay không?",
              title: "Xác nhận thêm",
              confirmingText: "Đồng ý",
              dismissiveText: GetTextForIos("Hủy bỏ")
          );

            if (!(result.HasValue && result.Value))
            {
                return;
            }

            await ShowLoading();

            // Call api lay thong tin can ho
            var request = new RestRequest("/DonDat/SaoChep", Method.Post);
            request.AddJsonBody(new { Id = id });

            var response = await ExecuteApiAsync<DonDatDanhSachOutput>(request);
            if (!response.isOk || response.data == null)
            {
                return;
            }

            var item = response.data;
            item.OrderCode = item.OrderCode.NormlizeWhitespace().ToUpper();
            item.AcceptPhone = item.AcceptPhone.NormlizeWhitespace().ToUpper();
            item.AcceptName = item.AcceptName.NormlizeWhitespace();
            //item.AcceptManUpper = item.AcceptMan.ToUpper();
            item.AcceptManNonUnicodeUpper = item.AcceptName.NonUnicodeUpper();

            {
                var modelItemIndex = _listDanhSachAll.FindIndex(h => h.Id == item.Id);
                if (modelItemIndex == -1)
                {
                    _listDanhSachAll.Insert(0, item);
                }
                else
                {
                    _listDanhSachAll.RemoveAt(modelItemIndex);
                    _listDanhSachAll.Insert(modelItemIndex, item);
                }
            }

            {
                var modelItem = ListDanhSach.FirstOrDefault(h => h.Id == item.Id);
                if (modelItem != null)
                {
                    var modelItemIndex = ListDanhSach.IndexOf(modelItem);
                    if (modelItemIndex == -1)
                    {
                        ListDanhSach.Insert(0, item);
                    }
                    else
                    {
                        ListDanhSach.RemoveAt(modelItemIndex);
                        ListDanhSach.Insert(modelItemIndex, item);
                    }
                }
                else
                {
                    ListDanhSach.Insert(0, item);
                }
            }

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