using System;
using System.Collections.Generic;
using System.Text;

namespace LeMaiMobile.Models
{
    public class GhAppSettings
    {
        public string ApiUrl { get; set; } = "";
        public string ApiToken { get; set; } = "FakeToken";


    }

    public interface IStatusBar
    {
        void SetBgColor(Xamarin.Forms.Color color);
    }

    public interface IDevice
    {
        string GetIdentifier();
    }
}
