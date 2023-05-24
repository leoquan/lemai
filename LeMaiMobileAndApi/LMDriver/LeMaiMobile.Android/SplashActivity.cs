using Android.App;
using Android.Content;
using Android.OS;
using AndroidX.AppCompat.App;
using Plugin.FirebasePushNotification;

namespace GlobalHomeMobile.Droid
{
    [Activity(Theme = "@style/MainTheme.Splash",
              MainLauncher = true, 
              NoHistory = true,
              Icon = "@mipmap/ic_launcher",
              RoundIcon = "@mipmap/ic_launcher")]
    public class SplashActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            //Plugin.LocalNotification.LocalNotificationCenter.CreateNotificationChannel();
            
            base.OnCreate(savedInstanceState);

            //Plugin.LocalNotification.LocalNotificationCenter.NotifyNotificationTapped(Intent);
            FirebasePushNotificationManager.ProcessIntent(this, Intent);

            //// Create your application here
            //var mainIntent = new Intent(Application.Context, typeof(MainActivity));

            //if (Intent.Extras != null)
            //{
            //    mainIntent.PutExtras(Intent.Extras);
            //}
            //mainIntent.SetFlags(ActivityFlags.SingleTop);

            //StartActivity(mainIntent);
        }

        protected override void OnNewIntent(Intent intent)
        {
            //Plugin.LocalNotification.LocalNotificationCenter.NotifyNotificationTapped(intent);
            //
            base.OnNewIntent(intent);
            FirebasePushNotificationManager.ProcessIntent(this, intent);
        }

        // Launches the startup task
        protected override void OnResume()
        {
            base.OnResume();

            var mainIntent = new Intent(Application.Context, typeof(MainActivity));

            ////mainIntent.SetFlags(ActivityFlags.SingleTop);
            //var data = Intent.GetStringExtra(Plugin.LocalNotification.LocalNotificationCenter.ReturnRequest);
            //if (!string.IsNullOrWhiteSpace(data))
            //{
            //    mainIntent.PutExtra(Plugin.LocalNotification.LocalNotificationCenter.ReturnRequest, data);
            //}

            StartActivity(mainIntent);
        }
    }
}
