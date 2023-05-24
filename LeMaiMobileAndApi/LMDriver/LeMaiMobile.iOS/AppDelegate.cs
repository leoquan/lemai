using Foundation;
using LeMaiMobile.iOS.Models;
using LeMaiMobile.Models;
using Prism;
using Prism.Ioc;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using UIKit;

namespace LeMaiMobile.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;
            TaskScheduler.UnobservedTaskException += TaskSchedulerOnUnobservedTaskException;

            global::Xamarin.Forms.Forms.Init();
            XF.Material.iOS.Material.Init();

            DisplayCrashReport();

            LoadApplication(new App(new iOSInitializer()));

            UIUserNotificationSettings settings = UIUserNotificationSettings.GetSettingsForTypes(UIUserNotificationType.Badge, null);
            UIApplication.SharedApplication.RegisterUserNotificationSettings(settings);


            return base.FinishedLaunching(app, options);
        }


        #region Error handling
        private static void TaskSchedulerOnUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs unobservedTaskExceptionEventArgs)
        {
            var newExc = new Exception("TaskSchedulerOnUnobservedTaskException", unobservedTaskExceptionEventArgs.Exception);
            LogUnhandledException(newExc);
        }

        private static void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs unhandledExceptionEventArgs)
        {
            var newExc = new Exception("CurrentDomainOnUnhandledException", unhandledExceptionEventArgs.ExceptionObject as Exception);
            LogUnhandledException(newExc);
        }

        internal static void LogUnhandledException(Exception exception)
        {
            try
            {
                const string errorFileName = "Fatal.log";
                var libraryPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Resources); // iOS: Environment.SpecialFolder.Resources
                var errorFilePath = Path.Combine(libraryPath, errorFileName);
                var errorMessage = String.Format("Time: {0}\r\nError: Unhandled Exception\r\n{1}",
                DateTime.Now, exception.ToString());
                File.WriteAllText(errorFilePath, errorMessage);

                // Log to Android Device Logging.
                //Android.Util.Log.Error("Crash Report", errorMessage);
            }
            catch
            {
                // just suppress any error logging exceptions
            }
        }

        /// <summary>
        // If there is an unhandled exception, the exception information is diplayed 
        // on screen the next time the app is started (only in debug configuration)
        /// </summary>
        [Conditional("DEBUG")]
        private void DisplayCrashReport()
        {
            return;
            const string errorFilename = "Fatal.log";
            var libraryPath = Environment.GetFolderPath(Environment.SpecialFolder.Resources);
            var errorFilePath = Path.Combine(libraryPath, errorFilename);

            if (!File.Exists(errorFilePath))
            {
                return;
            }

            var errorText = File.ReadAllText(errorFilePath);


            var uiAlert = UIAlertController.Create("Crash Report", errorText, UIAlertControllerStyle.ActionSheet);
            //Add Actions
            uiAlert.AddAction(UIAlertAction.Create("Clear", UIAlertActionStyle.Default, alert => File.Delete(errorFilePath)));
            uiAlert.AddAction(UIAlertAction.Create("Close", UIAlertActionStyle.Cancel, null));

            //uiAlert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, (alertAction) => {
            //    alertAction.Dispose();
            //    uiAlert.Dispose();
            //}));
            UIApplication.SharedApplication.KeyWindow.RootViewController.PresentViewController(uiAlert, true, null);
            //PresentViewControllerAsync(uiAlert, true);


            //var alertView = new UIAlertView("Crash Report", errorText, null, "Close", "Clear") { UserInteractionEnabled = true };
            //alertView.Clicked += (sender, args) =>
            //{
            //    if (args.ButtonIndex != 0)
            //    {
            //        File.Delete(errorFilePath);
            //    }
            //};
            //alertView.Show();
        }

        #endregion
    }

    public class iOSInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Register any platform specific implementations
            containerRegistry.RegisterSingleton<IDevice, UniqueId>();
            containerRegistry.RegisterSingleton<IStatusBar, MyStatusBar>();
        }
    }
}
