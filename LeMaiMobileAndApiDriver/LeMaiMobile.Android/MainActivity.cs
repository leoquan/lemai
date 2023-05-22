using Android.App;
using Android.Content.PM;
using Android.OS;
using LeMaiMobile.Droid.Models;
using LeMaiMobile.Models;
using Prism;
using Prism.Ioc;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace LeMaiMobile.Droid
{
    [Activity(Theme = "@style/MainThemeA",
              ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize
        , ScreenOrientation = ScreenOrientation.Portrait
        , LaunchMode = LaunchMode.SingleTask
        , Icon = "@mipmap/ic_launcher", RoundIcon = "@mipmap/ic_launcher"
        , MainLauncher = true
        )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        //static bool _isProcessFirebase = false;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            SetTheme(LeMaiMobile.Droid.Resource.Style.MainThemeA);

            base.OnCreate(savedInstanceState);

            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;
            TaskScheduler.UnobservedTaskException += TaskSchedulerOnUnobservedTaskException;

            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            XF.Material.Droid.Material.Init(this, savedInstanceState);

            DisplayCrashReport();

            LoadApplication(new App(new AndroidInitializer()));
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public override void OnBackPressed()
        {
            XF.Material.Droid.Material.HandleBackButton(base.OnBackPressed);
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
                var libraryPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // iOS: Environment.SpecialFolder.Resources
                var errorFilePath = Path.Combine(libraryPath, errorFileName);
                var errorMessage = String.Format("Time: {0}\r\nError: Unhandled Exception\r\n{1}",
                DateTime.Now, exception.ToString());
                File.WriteAllText(errorFilePath, errorMessage);

                // Log to Android Device Logging.
                Android.Util.Log.Error("Crash Report", errorMessage);
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
            const string errorFilename = "Fatal.log";
            var libraryPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var errorFilePath = Path.Combine(libraryPath, errorFilename);

            if (!File.Exists(errorFilePath))
            {
                return;
            }

            var errorText = File.ReadAllText(errorFilePath);
            new AlertDialog.Builder(this)
                .SetPositiveButton("Clear", (sender, args) =>
                {
                    File.Delete(errorFilePath);
                })
                .SetNegativeButton("Close", (sender, args) =>
                {
                    // User pressed Close.
                })
                .SetMessage(errorText)
                .SetTitle("Crash Report")
                .Show();
        }

        #endregion
    }

    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Register any platform specific implementations
            containerRegistry.RegisterSingleton<IDevice, UniqueId>();
            containerRegistry.RegisterSingleton<IStatusBar, MyStatuBar>();
            
        }
    }
}

