using Xamarin.Forms;
using System;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Helpers;
using Prism.Navigation.Xaml;
using System.Collections;
using XF.Material.Forms.UI;
using LeMaiMobile.ViewModels;

namespace LeMaiMobile.Views
{
    public partial class PageDonDatChiTiet : GhContentPageBase
    {
        public PageDonDatChiTiet()
        {
            InitializeComponent();
        }

        private void txtTrongLuong_Unfocused(object sender, FocusEventArgs e)
        {
            if (BindingContext is PageDonDatChiTietViewModel vm)
            {
                vm.FreightCommand.Execute(null);
            }
        }

        private void txtSoDienThoai_Unfocused(object sender, FocusEventArgs e)
        {
            if (BindingContext is PageDonDatChiTietViewModel vm)
            {
                vm.AcceptPhoneCommand.Execute(null);
            }
        }
    }
}
