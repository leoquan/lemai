using Android.App;
using LeMaiMobile.Models;

namespace LeMaiMobile.Droid.Models
{
    public class UniqueId : IDevice
    {
        public string GetIdentifier()
        {
            return Android.Provider.Settings.Secure.GetString(Application.Context.ContentResolver, Android.Provider.Settings.Secure.AndroidId);
        }
    }
}