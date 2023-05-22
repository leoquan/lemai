using Foundation;
using LeMaiMobile.Models;
using UIKit;
using Xamarin.Forms;

namespace LeMaiMobile.iOS.Models
{
    public class MyStatusBar : IStatusBar
    {
        public void SetBgColor(Color color)
        {
            UIColor uiColor = UIColor.FromRGB((float)color.R, (float)color.G, (float)color.B);

            UIView statusBar = new UIView(UIApplication.SharedApplication.StatusBarFrame);
            statusBar.BackgroundColor = uiColor;
            //statusBar.TintColor = UIColor.Orange;
            foreach (UIScene scene in UIApplication.SharedApplication.ConnectedScenes)
            {
                if (scene.ActivationState == UISceneActivationState.ForegroundActive)
                {
                    UIWindowScene myScene = (UIWindowScene)scene;
                    foreach (UIWindow win in myScene.Windows)
                    {
                        if (win.IsKeyWindow)
                        {
                            win.AddSubview(statusBar);
                        }
                    }

                }
            }

        }
    }
}