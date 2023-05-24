using LeMaiMobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LeMaiMobile.Views;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class ViewVanDonFilterStatus : ContentView
{
    public ViewVanDonFilterStatus()
    {
        InitializeComponent();
        BindingContext = this;
    }


    public static readonly BindableProperty ListStatusProperty =
        BindableProperty.Create(nameof(ListStatus), typeof(List<StatusNameModel>), typeof(ViewVanDonFilterStatus), null);

    public List<StatusNameModel> ListStatus
    {
        get { return (List<StatusNameModel>)GetValue(ListStatusProperty); }
        set { SetValue(ListStatusProperty, value); }
    }

    private void cardChonHet_Clicked(object sender, EventArgs e)
    {
        if (ListStatus == null)
        {
            return;
        }

        foreach (var item in ListStatus)
        {
            item.IsChecked = true;
        }
    }

    private void cardBoHet_Clicked(object sender, EventArgs e)
    {
        if (ListStatus == null)
        {
            return;
        }

        foreach (var item in ListStatus)
        {
            item.IsChecked = false;
        }
    }
}