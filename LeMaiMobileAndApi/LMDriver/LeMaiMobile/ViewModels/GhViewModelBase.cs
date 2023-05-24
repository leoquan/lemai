using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LeMaiDto;
using LeMaiMobile.Models;
using LeMaiMobile.Views;
using Prism.Navigation;
using Prism.Services.Dialogs;
using RestSharp;
using System;
using System.IO;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Helpers;
using Xamarin.Essentials;
using XF.Material.Forms.UI.Dialogs;
using XF.Material.Forms.UI.Dialogs.Configurations;

namespace LeMaiMobile.ViewModels;

[INotifyPropertyChanged]
public partial class GhViewModelBase : IInitialize, INavigationAware, IDestructible
{
    public INavigationService NavigationService { get; private set; }
    public IDialogService DialogService { get; private set; }
    public IStatusBar MyStatuBar { get; private set; }


    public GhViewModelBase(INavigationService navigationService, IDialogService dialogService, IStatusBar myStatuBar)
    {
        NavigationService = navigationService;
        DialogService = dialogService;
        MyStatuBar = myStatuBar;
        Version = $"V: {VersionTracking.CurrentVersion} | B: {VersionTracking.CurrentBuild}";

        IsIos = Xamarin.Essentials.DeviceInfo.Platform == Xamarin.Essentials.DevicePlatform.iOS;
    }

    [ObservableProperty]
    private string _title;

   

    [ObservableProperty]
    private string _version;

    #region Navigation helpers
    [RelayCommand]
    private async Task GoToPageAsync(string pageName)
    {
        if (GoToPageCommand.IsRunning)
        {
            return;
        }

        try
        {
            await NavigationService.NavigateAsync(pageName);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(ex);
        }
    }

    [RelayCommand]
    private async Task GoToPageModalAsync(string pageName)
    {
        if (GoToPageModalCommand.IsRunning)
        {
            return;
        }

        try
        {
            await NavigationService.NavigateAsync(pageName, useModalNavigation: true);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(ex);
        }
    }

    [RelayCommand]
    private async Task GoToPageRootAsync(string pageName)
    {
        if (GoToPageCommand.IsRunning)
        {
            return;
        }

        try
        {
            await NavigationService.NavigateAsync($"/NavigationPage/{pageName}");
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(ex);
        }
    }

    [RelayCommand]
    private async Task GoBackAsync()
    {
        if (GoToPageCommand.IsRunning)
        {
            return;
        }

        try
        {
            await NavigationService.GoBackAsync();
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(ex);
        }
    }

    [RelayCommand]
    private async Task GoBackToRootAsync()
    {
        if (GoToPageCommand.IsRunning)
        {
            return;
        }

        try
        {
            await NavigationService.GoBackToRootAsync();
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(ex);
        }
    }

    #endregion


    [RelayCommand]
    private async Task ChucNangDangPhatTrien()
    {
        if (ChucNangDangPhatTrienCommand.IsRunning || !CanCommandRun)
        {
            return;
        }

        try
        {
            await AlertAsync(
              message: "Chức năng đang được phát triển.",
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
        }
    }

    #region IInitialize, INavigationAware
    public virtual async void Initialize(INavigationParameters parameters)
    {

    }

    public virtual void OnNavigatedFrom(INavigationParameters parameters)
    {

    }

    public virtual void OnNavigatedTo(INavigationParameters parameters)
    {

    }

    public virtual void Destroy()
    {

    }
    #endregion


    #region Api caller
    protected async Task<(bool isOk, T data)> ExecuteApiAsync<T>(RestRequest request,
        bool isAuth = true,
        int timeoutMili = 30_000,
        string errorTitle = null,
        bool showNoInternet = false)
    {
        if (Connectivity.NetworkAccess == NetworkAccess.Internet)
        {

        }
        else
        {
            if (showNoInternet)
            {
                await AlertAsync(
                    message: "Chương trình cần có mạng để thực hiện chức năng.",
                    title: "Không có mạng",
                    acknowledgementText: "Đóng"
                );
            }
            
            return (false, default);
        }


        if (isAuth)
        {
            App.ApiClient.Authenticator = App.ApiAuth;
        }
        else
        {
            App.ApiClient.Authenticator = null;
        }
        request.Resource = $"/api{request.Resource}";


        request.Timeout = timeoutMili;
        var apiTask = App.ApiClient.ExecuteAsync<ApiResult<T>>(request);
        var timeOutTask = Task.Run(async () =>
        {
            await Task.Delay(timeoutMili);
        });

        await Task.WhenAny(apiTask, timeOutTask);

        if (apiTask.IsCompleted)
        {
            var check = await CheckApiResultAsync(apiTask.Result, errorTitle);
            if (!check.HasValue)
            {
                await NavigationService.NavigateAsync($"/NavigationPage/{nameof(PageDangNhap)}");
            }
            else if (check.Value)
            {
                return (true, apiTask.Result.Data.Data);
            }
        }

        return (false, default);
    }

    protected async Task<bool?> CheckApiResultAsync<T>(RestResponse<ApiResult<T>> response, string errorTitle = null)
    {
        // Lỗi tầng đường truyền mạng
        if (!response.IsSuccessful || response.Data == null)
        {
            string title = "Lỗi máy chủ";
            string message = "Lỗi xử lý hệ thống máy chủ.";
//#if DEBUG
//            title = $"Status code: {response.ResponseStatus} | {response.StatusCode}";
//            message = $"{response.ErrorException}";
//#endif

            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                await AlertAsync(
                   message: "Bạn không có quyền truy cập.",
                   title: "Lỗi đăng nhập",
                   acknowledgementText: "Đóng"
               );

                return null;
            }
            else
            {
                await AlertAsync(
                   message: message,
                   title: title,
                   acknowledgementText: "Đóng"
                );
            }
           

            return false;
        }
        // Lỗi logic gửi từ server
        else if (response.Data.Errors != null && response.Data.Errors.Count > 0)
        {
            string title = null;
            if (response.Data.Status == ApiStatus.LogicError)
            {
                title = errorTitle;
            }

            await AlertAsync(
               message: string.Join("\n", response.Data.Errors),
               title: string.IsNullOrWhiteSpace(title) ? "Lỗi dữ liệu máy chủ" : title,
               acknowledgementText: "Đóng"
               );
            return false;
        }
        // Không có lỗi, dự đoán là call API thành công
        else
        {
            return true;
        }
    }
    #endregion


    protected async Task HandleExceptionAsync(Exception ex)
    {
        if (App.IsModeReal == false && App.IsModeTesting == false)
        {

        }
        else
        {
//#if DEBUG
//            await AlertAsync(
//                               message: ex.ToString(),
//                               title: ex.Message,
//                               acknowledgementText: UiRes.DisplayAlert_Close
//                             );


//#else
//            if (App.IsModeReal)
//            {
//                await AlertAsync(
//                   message: UiRes.DisplayAlert_CommonError,
//                   title: UiRes.DisplayAlert_Title,
//                   acknowledgementText: UiRes.DisplayAlert_Close
//                 );
//            }
//#endif


            if (App.IsModeReal)
            {
                await AlertAsync(
                   message: "Đã có lỗi trong quá trình xử lý. Vui lòng thử lại hoặc liên hệ nhà quản trị.",
                   title: "Lỗi xử lý",
                   acknowledgementText: "Đóng"
                 );
            }
        }
    }



    #region Fix Meterial show alert not awaiting
    protected async Task AlertAsync(string message, MaterialAlertDialogConfiguration configuration = null)
    {
        await MaterialDialog.Instance.ConfirmAsync(message
            , configuration: configuration
            , dismissiveText: null
            );
    }
    //
    // Summary:
    //     Shows an alert dialog for acknowledgement. It only has a single, dismissive action
    //     used for acknowledgement.
    //
    // Parameters:
    //   message:
    //     The message of the alert dialog.
    //
    //   title:
    //     The title of the alert dialog.
    //
    //   configuration:
    //     The style of the alert dialog.
    protected async Task AlertAsync(string message, string title, MaterialAlertDialogConfiguration configuration = null)
    {
        await MaterialDialog.Instance.ConfirmAsync(message
            , title: title
            , configuration: configuration
            , dismissiveText: null
            );
    }
    //
    // Summary:
    //     Shows an alert dialog for acknowledgement. It only has a single, dismissive action
    //     used for acknowledgement.
    //
    // Parameters:
    //   message:
    //     The message of the alert dialog.
    //
    //   title:
    //     The title of the alert dialog.
    //
    //   acknowledgementText:
    //     The text of the acknowledgement button.
    //
    //   configuration:
    //     The style of the alert dialog.
    protected async Task AlertAsync(string message, string title, string acknowledgementText, MaterialAlertDialogConfiguration configuration = null)
    {
        await MaterialDialog.Instance.ConfirmAsync(message
            , title: title
            , confirmingText: acknowledgementText
            , configuration: configuration
            , dismissiveText: null
            );
    }
    #endregion

    #region Show hide loading
    private static IMaterialModalPage _loadingIndicator = null;
    protected async Task ShowLoading(string message = null)
    {
        if (message == null)
        {
            message = "Đang xử lý...";
        }
        if (_loadingIndicator != null)
        {
            await _loadingIndicator.DismissAsync();
        }

        _loadingIndicator = await MaterialDialog.Instance.LoadingDialogAsync(message);
        SetStatusBarBg();
    }

    protected async Task HideLoading()
    {
        if (_loadingIndicator != null)
        {
            await _loadingIndicator.DismissAsync();
            _loadingIndicator = null;
            SetStatusBarBg();
        }
    }
    #endregion


    [ObservableProperty]
    public bool _canCommandRun = true;

    private void SetStatusBarBg()
    {
        if (Xamarin.Essentials.DeviceInfo.Platform == Xamarin.Essentials.DevicePlatform.iOS)
        {
            ////Xamarin.Forms.Color primaryColor = XF.Material.Forms.Material.Color.Primary;
            Xamarin.Forms.Color primaryColor = Xamarin.Forms.Color.FromHex("#EF3300");
            //XF.Material.Forms.Material.PlatformConfiguration.ChangeStatusBarColor(primaryColor);
            ////XF.Material.Forms.Material.PlatformConfiguration.ChangeStatusBarColor(primaryColor);

            MyStatuBar.SetBgColor(primaryColor);
        }
    }


    protected string GetTextForIos(string text)
    {
        if (Xamarin.Essentials.DeviceInfo.Platform == Xamarin.Essentials.DevicePlatform.iOS)
        {
            return $"     {text}  ";
        }

        return text;
    }

    [ObservableProperty]
    private bool _isModeTesting;
    [ObservableProperty]
    private bool _isModeReal;

    #region Check is testing
    protected async Task<bool?> CheckIsTestingAsync()
    {
        try
        {
            var request = new RestRequest("/AppInfo/CheckIsTesting", Method.Get);
           
            var response = await ExecuteApiAsync<bool>(request, isAuth:false);
            if (!response.isOk)
            {
                IsModeTesting = false;
                IsModeReal = false;
                
                App.IsModeTesting = false;
                App.IsModeReal = false;
                return null;
            }

            IsModeTesting = response.data;
            IsModeReal = !IsModeTesting;

            App.IsModeTesting = response.data;
            App.IsModeReal = !IsModeTesting;

            return response.data;
        }
        catch (Exception ex)
        {
            IsModeTesting = false;
            IsModeReal = false;
            App.IsModeTesting = false;
            App.IsModeReal = false;
            return null;
        }
    }

    #endregion


    [RelayCommand]
    private async Task OpenExternalLinkAsync(string url)
    {
        if (OpenExternalLinkCommand.IsRunning || !CanCommandRun)
        {
            return;
        }

        try
        {
            CanCommandRun = false;
            await ShowLoading();

            if (!string.IsNullOrEmpty(url))
            {
                await Browser.OpenAsync(url, BrowserLaunchMode.External);
            }
        }
        catch
        {
            await AlertAsync($"{LocalizationResourceManager.Current["PageTO110MainTop_ThongBaoLink"]}", $"{LocalizationResourceManager.Current["DisplayAlert_Title"]}");
        }
        finally
        {
            await HideLoading();
            CanCommandRun = true;
        }
    }

    [ObservableProperty]
    private bool _isIos;
}


public partial class GhViewModelBase<TView> : GhViewModelBase, IGhViewModelWithView
    where TView : GhContentPageBase
{

    public void SetView<T>(T view) where T : GhContentPageBase
    {
        ViewObj = view as TView;
    }

    public TView ViewObj { get; set; }

    public GhViewModelBase(INavigationService navigationService, IDialogService dialogService, IStatusBar myStatuBar)
        : base(navigationService, dialogService, myStatuBar)
    {

    }



    [RelayCommand]
    private async Task ClickHomeAsync()
    {
        if (ClickHomeCommand.IsRunning || !CanCommandRun)
        {
            return;
        }

        try
        {
            CanCommandRun = false;
            await ShowLoading();

            await NavigationService.NavigateAsync($"../{nameof(Views.PageTrangChu)}");
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
    private async Task ClickVanDonAsync()
    {
        if (ClickVanDonCommand.IsRunning || !CanCommandRun)
        {
            return;
        }

        try
        {
            CanCommandRun = false;
            await ShowLoading();

            await NavigationService.NavigateAsync($"../{nameof(Views.PageVanDon)}");
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
    private async Task ClickDonDatAsync()
    {
        if (ClickDonDatCommand.IsRunning || !CanCommandRun)
        {
            return;
        }

        try
        {
            CanCommandRun = false;
            await ShowLoading();

            await NavigationService.NavigateAsync($"../{nameof(Views.PageDonDat)}");
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
    private async Task ClickCODAsync()
    {
        if (ClickDonDatCommand.IsRunning || !CanCommandRun)
        {
            return;
        }

        try
        {
            CanCommandRun = false;
            await ShowLoading();

            await NavigationService.NavigateAsync($"../{nameof(Views.PageCOD)}");
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
    private async Task ClickKienVanDeAsync()
    {
        if (ClickKienVanDeCommand.IsRunning || !CanCommandRun)
        {
            return;
        }

        try
        {
            CanCommandRun = false;
            await ShowLoading();

            await NavigationService.NavigateAsync($"../{nameof(Views.PageKienVanDe)}");
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

public interface IGhViewModelWithView
{
    void SetView<T>(T view) where T : GhContentPageBase;
}
