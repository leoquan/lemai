using System;
using Android.App;
using Android.Runtime;

namespace LeMaiMobile.Droid
{
    [Application(
        Theme = "@style/MainTheme",
        Icon = "@mipmap/ic_launcher",
        RoundIcon = "@mipmap/ic_launcher"
        )]
    public class MainApplication : Application
    {
        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();
            Xamarin.Essentials.Platform.Init(this);
        }
    }
}
