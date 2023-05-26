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
using XF.Material.Forms.UI.Dialogs.Configurations;

namespace LeMaiMobile.ViewModels;

public partial class PageVanDonChiTietViewModel : GhViewModelBase<PageVanDonChiTiet>
{
    public PageVanDonChiTietViewModel(INavigationService navigationService, IDialogService dialogService, Models.IStatusBar myStatuBar)
        : base(navigationService, dialogService, myStatuBar)
    {
    }

    private string _billCode = "";

    public override async void OnNavigatedTo(INavigationParameters parameters)
    {
        base.OnNavigatedTo(parameters);

        switch (parameters.GetNavigationMode())
        {
            case Prism.Navigation.NavigationMode.Back:
                break;
            case Prism.Navigation.NavigationMode.New:
                if (parameters.TryGetValue("modeView", out string modeView))
                {
                    ModeViewIndex = modeView == "HanhTrinh" ? 1 : 0;
                }
                if (parameters.TryGetValue("billCode", out string billCode))
                {
                    _billCode = billCode;
                }
                LoadChiTietCommand.Execute(null);
                break;
            default:
                break;
        }
    }


    [ObservableProperty]
    private int _modeViewIndex = 0; // 0: Thong tin, 1: hanh trinh

    [ObservableProperty]
    private VanDonChiTietOutput _vanDon = null;

    [ObservableProperty]
    private decimal _ToTalCOD = 0;

    [RelayCommand]
    private async Task LoadChiTietAsync()
    {
        if (LoadChiTietCommand.IsRunning || !CanCommandRun || string.IsNullOrWhiteSpace(_billCode))
        {
            return;
        }

        try
        {
            CanCommandRun = false;
            await ShowLoading();

            // Call api lay thong tin can ho
            var request = new RestRequest("/Shipper/ChiTietVanDon", Method.Get);
            request.AddParameter("billCode", _billCode);

            var response = await ExecuteApiAsync<VanDonChiTietOutput>(request);
            if (!response.isOk || response.data == null)
            {
                return;
            }
            ToTalCOD = response.data.ChiTiet.Cod;
            if (response.data.ChiTiet.PayType != "Gửi thanh toán")
            {
                ToTalCOD = ToTalCOD + response.data.ChiTiet.Freight;
            }
            if (response.data.ListHanhTrinh != null && response.data.ListHanhTrinh.Count > 0)
            {
                response.data.ListHanhTrinh[0].IsFirst = true;
            }

            VanDon = response.data;
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
        if (MakePhoneCallCommand.IsRunning || !CanCommandRun || string.IsNullOrWhiteSpace(phone))
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
    [RelayCommand]
    private async Task KienVanDeAsync(string billcode)
    {
        var showLoading = false;
        if (KienVanDeCommand.IsRunning || !CanCommandRun || string.IsNullOrWhiteSpace(billcode))
        {
            return;
        }

        try
        {
            CanCommandRun = false;
            // Kiện vấn đề
            var matKhauMoi = await MaterialDialog.Instance.InputAsync(
                title: "Thêm kiện vấn đề",
                message: "Nhập nội dung kiện vấn đề",
                confirmingText: "Đồng ý",
                dismissiveText: "Hủy bỏ",
                inputPlaceholder: "",
                configuration: new MaterialInputDialogConfiguration()
                {
                    InputMaxLength = 250,
                    InputType = XF.Material.Forms.UI.MaterialTextFieldInputType.Text,
                }
            );

            showLoading = true;
            await ShowLoading();

            // Call api đăng ký kiện vấn đề
            var request = new RestRequest("/Shipper/AddKienVanDe", Method.Post);
            request.AddJsonBody(new TaiKhoanDoiMatKhauInput
            {
                MatKhauMoi = matKhauMoi
            });

            var response = await ExecuteApiAsync<bool>(request);
            if (!response.isOk || !response.data)
            {
                return;
            }

            await AlertAsync("Lập kiện vấn đề thành công");

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
    private async Task KyNhanAsync(string billcode)
    {
        var showLoading = false;
        if (KyNhanCommand.IsRunning || !CanCommandRun)
        {
            return;
        }
        try
        {
            CanCommandRun = false;

            var result = await MaterialDialog.Instance.ConfirmAsync(
                message: "Bạn có chắc muốn ký nhận đơn hàng này?",
                title: "Ký nhận",
                confirmingText: "Đồng ý",
                dismissiveText: GetTextForIos("Hủy bỏ")
            );

            if (!(result.HasValue && result.Value))
            {
                return;
            }
            result = await MaterialDialog.Instance.ConfirmAsync(
                message: "Đơn hàng ký nhận khi giao thành công, thu tiền COD đầy đủ",
                title: "Ký nhận",
                confirmingText: "Đồng ý",
                dismissiveText: GetTextForIos("Hủy bỏ")
            );

            if (!(result.HasValue && result.Value))
            {
                return;
            }

            showLoading = true;
            await ShowLoading();
            // Call api ký nhận
            var request = new RestRequest("/Shipper/KyNhan", Method.Post);
            request.AddJsonBody(new TaiKhoanDoiMatKhauInput
            {
                MatKhauMoi = billcode
            });

            var response = await ExecuteApiAsync<bool>(request);
            if (!response.isOk || !response.data)
            {
                return;
            }
            await AlertAsync("Ký nhận đơn hàng thành công");
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