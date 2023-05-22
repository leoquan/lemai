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
using System.Text.RegularExpressions;

namespace LeMaiMobile.ViewModels;

public partial class PageDangKyViewModel : GhViewModelBase<PageDangKy>
{
    public PageDangKyViewModel(INavigationService navigationService, IDialogService dialogService, Models.IStatusBar myStatuBar)
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
                break;
            default:
                break;
        }
    }

    [ObservableProperty]
    private string _soDienThoai = "";
    [ObservableProperty]
    private string _hoTen = "";
    [ObservableProperty]
    private string _matKhau = "";
    [ObservableProperty]
    private string _nhapLaiMatKhau = "";








    [RelayCommand]
    private async Task DangKyAsync()
    {
        var showLoading = false;
        if (DangKyCommand.IsRunning || !CanCommandRun)
        {
            return;
        }

        try
        {
            CanCommandRun = false;

            var error = new StringBuilder();
            if (string.IsNullOrWhiteSpace(SoDienThoai))
            {
                error.AppendLine("- Số điện thoại chưa được nhập");
            }
            else if (SoDienThoai.Length < 10)
            {
                error.AppendLine("- Số điện thoại phải đủ 10 chữ số");
            }

            if (string.IsNullOrWhiteSpace(HoTen))
            {
                error.AppendLine("- Họ tên chưa được nhập");
            }

            if (string.IsNullOrWhiteSpace(MatKhau))
            {
                error.AppendLine("- Mật khẩu chưa được nhập");
            }
            else if (MatKhau != NhapLaiMatKhau)
            {
                error.AppendLine("- Nhập lại mật khẩu không chính xác");
            }

            if (error.Length > 0)
            {
                await AlertAsync(error.ToString(), "Lỗi nhập liệu");
                return;
            }

            await ShowLoading();

            var request = new RestRequest("/TaiKhoan/DangKy", Method.Post);
            request.AddJsonBody(new
            {
                SoDienThoai,
                HoTen,
                MatKhau
            });

            var response = await ExecuteApiAsync<bool>(request, isAuth: false
                , errorTitle: "Đăng ký thất bại");
            if (!response.isOk)
            {
                return;
            }

            await AlertAsync("Đăng ký thành công tài khoản:\n" + SoDienThoai);

            var navParam = new NavigationParameters();
            navParam.Add("DangKy_TenDangNhap", SoDienThoai);
            navParam.Add("DangKy_MatKhau", MatKhau);

            await NavigationService.GoBackAsync(navParam);
            //await NavigationService.NavigateAsync($"/NavigationPage/{nameof(Views.PageDangNhap)}", navParam);
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


[INotifyPropertyChanged]
public partial class PageDangKyViewModel_ThongTinDangKyModel
{
    [ObservableProperty]
    private string _soDienThoai;
    [ObservableProperty]
    private string _hoTen;
    [ObservableProperty]
    private string _matKhau;
    [ObservableProperty]
    private string _nhapLaiMatKhau;
}