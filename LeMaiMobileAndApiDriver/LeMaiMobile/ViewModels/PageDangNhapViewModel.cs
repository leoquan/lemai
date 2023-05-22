using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LeMaiDto;
using LeMaiMobile.Models;
using Prism.Navigation;
using Prism.Services.Dialogs;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Globalization;
using System.Text.Json;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Helpers;
using Xamarin.Essentials;

namespace LeMaiMobile.ViewModels;

public partial class PageDangNhapViewModel : GhViewModelBase<Views.PageDangNhap>
{
    public PageDangNhapViewModel(INavigationService navigationService, IDialogService dialogService, Models.IStatusBar myStatuBar)
        : base(navigationService, dialogService, myStatuBar)
    {
        //// For test
        //TenDangNhap = "VN808260027";
        //MatKhau = "zto123456";
    }

    string ListIdChungCu;

    public override async void OnNavigatedTo(INavigationParameters parameters)
    {
        base.OnNavigatedTo(parameters);

        NhoDangNhap = Preferences.Get("PageDangNhap_NhoMatKhau", false);

        switch (parameters.GetNavigationMode())
        {
            case Prism.Navigation.NavigationMode.Back:
                if (parameters.TryGetValue<string>("DangKy_TenDangNhap", out string dangKyTenDangNhap))
                {
                    TenDangNhap = dangKyTenDangNhap;
                }
                if (parameters.TryGetValue<string>("DangKy_MatKhau", out string dangkyMatKhau))
                {
                    MatKhau = dangkyMatKhau;
                }

                break;
            case Prism.Navigation.NavigationMode.New:

                await CheckIsTestingAsync();

                if (NhoDangNhap)
                {
                    TenDangNhap = Preferences.Get("PageDangNhap_TenDangNhap", "");
                    MatKhau = Preferences.Get("PageDangNhap_MatKhau", "");
                    if (parameters.TryGetValue<string>("MatKhau", out string matKhau))
                    {
                        MatKhau = matKhau;
                    }
                }
                else
                {
                    TenDangNhap = "";
                    MatKhau = "";
                }
                break;
            default:
                break;
        }
    }


    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(DangNhapCommand))]
    private string _tenDangNhap;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(DangNhapCommand))]
    private string _matKhau;

    [ObservableProperty]
    private bool _nhoDangNhap;

    private bool _canDangNhapAsync => 
        !string.IsNullOrWhiteSpace(_tenDangNhap) 
        && !string.IsNullOrWhiteSpace(_matKhau);
    [RelayCommand(CanExecute = nameof(_canDangNhapAsync))]
    private async Task DangNhapAsync()
    {
        if (DangNhapCommand.IsRunning || !CanCommandRun)
        {
            return;
        }

        try
        {
            CanCommandRun = false;
            await ShowLoading();

            var request = new RestRequest("/TaiKhoan/DangNhap", Method.Post);
            request.AddJsonBody(new
            {
                TenDangNhap = TenDangNhap,
                MatKhau = MatKhau
            });

            var response = await ExecuteApiAsync<TaiKhoanDangNhapOutput>(request, isAuth: false
                , errorTitle: "Đăng nhập thất bại");
            if (!response.isOk)
            {
                //await AlertAsync(
                //  message: string.Join("\n", response.Data.Errors),
                //  title: string.IsNullOrWhiteSpace(title) ? "Lỗi dữ liệu máy chủ" : title,
                //  acknowledgementText: "Đóng"
                //);
                return;
            }

            var userInfo = new LoginUserInfo()
            {
                IsDangNhap = true,

                Id = response.data.Id,
                TaiKhoan = response.data.Code,
                HoTen = response.data.HoTen,
                SoDienThoai = response.data.SoDienThoai,
                AccessToken = response.data.AccessToken,
                AccessTimeoutUtc = DateTime.ParseExact(
                    response.data.AccessTimeoutUtc,
                    "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
            };

            Preferences.Set("App_LoginUserInfo", JsonSerializer.Serialize(userInfo));
            App.UserInfo = userInfo;

            Preferences.Set("PageDangNhap_NhoMatKhau", NhoDangNhap);
            if (NhoDangNhap)
            {
                Preferences.Set("PageDangNhap_TenDangNhap", TenDangNhap);
                Preferences.Set("PageDangNhap_MatKhau", MatKhau);
            }
            else
            {
                Preferences.Set("PageDangNhap_TenDangNhap", "");
                Preferences.Set("PageDangNhap_MatKhau", "");
            }

            App.AppSettings.ApiToken = response.data.AccessToken;
            App.ApiAuth = new JwtAuthenticator(response.data.AccessToken);

            await NavigationService.NavigateAsync($"/NavigationPage/{nameof(Views.PageTrangChu)}");
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