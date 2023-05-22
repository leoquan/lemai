using Xamarin.Forms;
using System;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Helpers;
using Prism.Navigation.Xaml;
using System.Collections;
using LeMaiMobile.ViewModels;

namespace LeMaiMobile.Views
{
    public partial class PageTrangChu : GhContentPageBase
    {
        public PageTrangChu()
        {
            InitializeComponent();
        }

        private void MaterialMenuButton_MenuSelected(object sender, XF.Material.Forms.UI.MenuSelectedEventArgs e)
        {
            if (e.Result != null)
            {
                if (BindingContext is PageTrangChuViewModel vm)
                {
                    if (e.Result.Index == 0)
                    {
                        vm.DoiMatKhauCommand.Execute(null);
                    }
                    else if (e.Result.Index == 1)
                    {
                        vm.DangXuatCommand.Execute(null);
                    }
                    else if (e.Result.Index == 3)
                    {
                        vm.XoaTaiKhoanCommand.Execute(null);
                    }
                }
            }
        }
    }
}
