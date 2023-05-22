using LeMaiMobile.Models;
using LeMaiMobile.Views;
using Prism;
using Prism.Ioc;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Globalization;
using System.Text.Json;
using Xamarin.Essentials;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace LeMaiMobile;

public partial class App
{
    public static bool IsIos
    {
        get
        {
            return Xamarin.Essentials.DeviceInfo.Platform == Xamarin.Essentials.DevicePlatform.iOS;
        }
    }
    public static bool IsModeTesting { get; set; }
    public static bool IsModeReal { get; set; }


    public static string ActiveMenuTab { get; set; } = "ActiveMain";

    public static GhAppSettings AppSettings { get; set; }
    public static RestClient ApiClient { get; set; }
    public static JwtAuthenticator ApiAuth { get; set; }


    public static LoginUserInfo UserInfo { get; set; } = new LoginUserInfo();


    public App(IPlatformInitializer initializer)
        : base(initializer)
    {
        VersionTracking.Track();
    }


    public static int BadgeNumber { get; private set; }
    public static void SaveBadgeNumber(int number)
    {
        BadgeNumber = number;
        Preferences.Set(nameof(BadgeNumber), number);
    }

    protected override async void OnInitialized()
    {
        #region Init app setting
        var appSetting = new GhAppSettings();
        appSetting.ApiUrl = "https://donhang.lemai.vn:7641";
        //#if DEBUG
        //        appSetting.ApiUrl = "https://donhang.lemai.vn:7641";
        //#endif


        AppSettings = appSetting;
        #endregion

        #region Config ngon ngu
        var ngonNgu = Preferences.Get("_NgonNgu_", "");
        if (string.IsNullOrWhiteSpace(ngonNgu))
        {
            ngonNgu = "vi-VN";
            Preferences.Set("_NgonNgu_", ngonNgu);
        }

        if (CultureInfo.DefaultThreadCurrentCulture == null
                || !string.Equals(CultureInfo.DefaultThreadCurrentCulture.Name, ngonNgu, StringComparison.OrdinalIgnoreCase))
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo(ngonNgu);
        }
        if (CultureInfo.DefaultThreadCurrentUICulture == null
            || !string.Equals(CultureInfo.DefaultThreadCurrentUICulture.Name, ngonNgu, StringComparison.OrdinalIgnoreCase))
        {
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo(ngonNgu);
        }
        #endregion

        #region Init
        // Init meterial truoc init xamarin form de fix bug loi dialog width khi show Alert
        XF.Material.Forms.Material.Init(this);
        InitializeComponent();

        var deviceHelper = Container.Resolve<LeMaiMobile.Models.IDevice>();
        var deviceId = deviceHelper.GetIdentifier();
        Xamarin.Essentials.Preferences.Set("_DeviceId_", deviceId);


        // Init meterial sau init xamarin form thi gap loi dialog width khi show Alert
        //XF.Material.Forms.Material.Init(this);
        //XF.Material.Forms.Material.Init(this,
        //    Resources["Material.Configuration"] as XF.Material.Forms.Resources.MaterialConfiguration);
        XF.Material.Forms.Material.Use("Material.Configuration");

        try
        {
            Xamarin.Essentials.VersionTracking.Track();
        }
        catch (Exception ex)
        {
            //BaseViewModel.LogErrorStatic(ex);
        }
        #endregion

        // Lay thong tin dang nhap
        try
        {
            var userInfo = JsonSerializer.Deserialize<LoginUserInfo>(
                Preferences.Get("App_LoginUserInfo", ""));
            UserInfo = userInfo;
        }
        catch (Exception ex) { }

        #region Config RestClient
        var restOptions = new RestClientOptions(AppSettings.ApiUrl)
        {
            //ThrowOnAnyError = true,
            //Timeout = 3000,
            MaxTimeout = 30_000
        };
        ApiClient = new RestClient(restOptions);

        if (UserInfo.IsDangNhap)
        {
            AppSettings.ApiToken = UserInfo.AccessToken;
            ApiAuth = new JwtAuthenticator(AppSettings.ApiToken);
        }
        #endregion

        try
        {
            if (UserInfo.IsDangNhap)
            {
                await NavigationService.NavigateAsync($"NavigationPage/{nameof(PageTrangChu)}");
                return;
            }

            await NavigationService.NavigateAsync($"NavigationPage/{nameof(PageDangNhap)}");
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public static bool IsForeground { get; set; }
    public static string NotifyIdThongBao { get; set; }

    protected override void OnStart()
    {
        base.OnStart();
        IsForeground = true;
    }

    protected override void OnResume()
    {
        base.OnResume();
        IsForeground = true;

    }

    protected override void OnSleep()
    {
        base.OnSleep();
        IsForeground = false;
    }

    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();


        containerRegistry.RegisterForNavigation<NavigationPage>();
        //containerRegistry.RegisterForNavigation<MaterialNavigationPage>("NavigationPage");
        
        containerRegistry.RegisterForNavigation<PageDangNhap>();
        containerRegistry.RegisterForNavigation<PageTrangChu>();
        containerRegistry.RegisterForNavigation<PageVanDon>();
        containerRegistry.RegisterForNavigation<PageVanDonChiTiet>();
        containerRegistry.RegisterForNavigation<PageKienVanDe>();
        containerRegistry.RegisterForNavigation<PageDonDat>();
        containerRegistry.RegisterForNavigation<PageDonDatChiTiet>();
        containerRegistry.RegisterForNavigation<PageCOD>();
        containerRegistry.RegisterForNavigation<PageDangKy>();
    }
}

public class LoginUserInfo
{
    public bool IsDangNhap { get; set; }
    public string Id { get; set; }
    public string TaiKhoan { get; set; }

    public string HoTen { get; set; }
    public string SoDienThoai { get; set; }

    

    public string AccessToken { get; set; }
    public DateTime AccessTimeoutUtc { get; set; }

    public string RefreshToken { get; set; }
    public DateTime RefreshTimeoutUtc { get; set; }
}
