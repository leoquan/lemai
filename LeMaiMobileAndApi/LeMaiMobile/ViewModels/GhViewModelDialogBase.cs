using CommunityToolkit.Mvvm.ComponentModel;
using LeMaiDto;
using Prism.Navigation;
using Prism.Services.Dialogs;
using RestSharp;
using System;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Helpers;
using Xamarin.Essentials;
using Xamarin.Forms;
using XF.Material.Forms.UI.Dialogs;
using XF.Material.Forms.UI.Dialogs.Configurations;

namespace LeMaiMobile.ViewModels;

[INotifyPropertyChanged]
public partial class GhViewModelDialogBase<T> : IDialogAware
    where T : ContentView
{
    public INavigationService NavigationService { get; }

    public GhViewModelDialogBase(INavigationService navigationService)
    {
        NavigationService = navigationService;
    }

    #region IDialogAware
    public event Action<IDialogParameters> RequestClose;
    protected void RequestCloseImplement(IDialogParameters param)
    {
        RequestClose?.Invoke(param);
    }

    private bool _canCloseDialog;
    public bool CanCloseDialog()
    {
        return _canCloseDialog && CanCloseDialogImplement();
    }

    /// <summary>
    /// Note: Không cần call base.CanCloseDialogImplement
    /// </summary>
    /// <returns></returns>
    public virtual bool CanCloseDialogImplement()
    {
        return true;
    }

    public void OnDialogClosed()
    {
        // Fix loi double tap background crash app
        _canCloseDialog = false;
        OnDialogClosedImplement();
    }
    /// <summary>
    /// Note: Không cần call base.OnDialogClosedImplement
    /// </summary>
    protected virtual void OnDialogClosedImplement()
    {

    }

    public void OnDialogOpened(IDialogParameters parameters)
    {
        // Fix loi double tap background crash app
        _canCloseDialog = true;
        OnDialogOpenedImplement(parameters);
    }
    /// <summary>
    /// Note: Không cần call base.OnDialogOpenedImplement
    /// </summary>
    /// <param name="parameters"></param>
    protected virtual void OnDialogOpenedImplement(in IDialogParameters parameters)
    {

    }
    #endregion

    protected async Task HandleExceptionAsync(Exception ex)
    {
        await AlertAsync(
             message: ex.ToString(),
             title: ex.Message,
             acknowledgementText: "Đóng"
           );
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
            message = LocalizationResourceManager.Current["PageLoading_DangXuLy"];
        }
        if (_loadingIndicator != null)
        {
            await _loadingIndicator.DismissAsync();
        }

        _loadingIndicator = await MaterialDialog.Instance.LoadingDialogAsync(message);
    }

    protected async Task HideLoading()
    {
        if (_loadingIndicator != null)
        {
            await _loadingIndicator.DismissAsync();
            _loadingIndicator = null;
        }
    }
    #endregion

    #region Api caller
    protected async Task<(bool isOk, T data)> ExecuteApiAsync<T>(RestRequest request,
        bool isAuth = true,
        int timeoutMili = 10_000,
        string errorTitle = null)
    {
        if (isAuth)
        {
            App.ApiClient.Authenticator = App.ApiAuth;
        }
        else
        {
            App.ApiClient.Authenticator = null;
        }
        request.Resource = $"/api/{Preferences.Get("_NgonNgu_", "vi-VN")}{request.Resource}";


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
            if (check)
            {
                return (true, apiTask.Result.Data.Data);
            }
        }

        return (false, default);
    }

    protected async Task<bool> CheckApiResultAsync<T>(RestResponse<ApiResult<T>> response, string errorTitle = null)
    {
        // Lỗi tầng đường truyền mạng
        if (!response.IsSuccessful || response.Data == null)
        {
            string title = "Lỗi máy chủ";
            string message = "Lỗi xử lý hệ thống máy chủ.";
#if DEBUG
            title = $"Status code: {response.ResponseStatus} | {response.StatusCode}";
            message = $"{response.ErrorException}";
#endif
            await AlertAsync(
                message: message,
                title: title,
                acknowledgementText: "Đóng"
            );

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

}
