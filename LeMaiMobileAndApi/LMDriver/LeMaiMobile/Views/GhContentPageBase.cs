using LeMaiMobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace LeMaiMobile.Views;

public class GhContentPageBase : ContentPage
{
    public GhContentPageBase()
    {
        Xamarin.Forms.NavigationPage.SetBackButtonTitle(this, "");

        PropertyChanged -= GhContentPageBase_PropertyChanged;
        PropertyChanged += GhContentPageBase_PropertyChanged;

        On<iOS>().SetUseSafeArea(true);

        if (Xamarin.Essentials.DeviceInfo.Platform == Xamarin.Essentials.DevicePlatform.iOS)
        {
            var safeInsets = On<iOS>().SafeAreaInsets();
            safeInsets.Bottom = 20;
            Padding = safeInsets;

            SetStatusBarBg();
        }
    }

    private void GhContentPageBase_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == BindingContextProperty.PropertyName)
        {
            if (BindingContext is IGhViewModelWithView vmView)
            {
                vmView.SetView(this);
                PropertyChanged -= GhContentPageBase_PropertyChanged;
            }
        }
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        if (Xamarin.Essentials.DeviceInfo.Platform == Xamarin.Essentials.DevicePlatform.iOS)
        {
            var safeInsets = On<iOS>().SafeAreaInsets();
            safeInsets.Bottom = 20;
            Padding = safeInsets;

            SetStatusBarBg();
        }
    }

    private void SetStatusBarBg()
    {
        if (Xamarin.Essentials.DeviceInfo.Platform == Xamarin.Essentials.DevicePlatform.iOS)
        {
            XF.Material.Forms.Material.PlatformConfiguration.ChangeStatusBarColor(Xamarin.Forms.Color.Blue);

            Xamarin.Forms.Color primaryColor = XF.Material.Forms.Material.Color.Primary;
            XF.Material.Forms.Material.PlatformConfiguration.ChangeStatusBarColor(primaryColor);
        }
    }
}


public class ContentControl : ContentView
{
    public DataTemplate ItemTemplate
    {
        get => (DataTemplate)GetValue(ItemTemplateProperty);
        set => SetValue(ItemTemplateProperty, value);
    }
    public static readonly BindableProperty ItemTemplateProperty = BindableProperty.Create(nameof(ItemTemplate), typeof(DataTemplate), typeof(ContentControl), propertyChanged: ItemTemplateChanged);

    public object Item
    {
        get => (object)GetValue(ItemProperty);
        set => SetValue(ItemProperty, value);
    }
    public static readonly BindableProperty ItemProperty = BindableProperty.Create(nameof(Item), typeof(object), typeof(ContentControl), null, propertyChanged: SourceChanged);

    private static void ItemTemplateChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = bindable as ContentControl;
        control.BuildItem();
    }

    private static void SourceChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = bindable as ContentControl;
        control.BuildItem();
    }

    public bool HideOnNullContent { get; set; } = false;

    protected void BuildItem()
    {
        if (Item == null)
        {
            Content = null;
            return;
        }

        //Create the content
        try
        {
            Content = CreateTemplateForItem(Item, ItemTemplate, false);
        }
        catch
        {
            Content = null;
        }
        finally
        {
            if (HideOnNullContent)
                IsVisible = Content != null;
        }
    }

    public static View CreateTemplateForItem(object item, DataTemplate itemTemplate, bool createDefaultIfNoTemplate = true)
    {
        //Check to see if we have a template selector or just a template
        var templateToUse = itemTemplate is DataTemplateSelector templateSelector ? templateSelector.SelectTemplate(item, null) : itemTemplate;

        //If we still don't have a template, create a label
        if (templateToUse == null)
            return createDefaultIfNoTemplate ? new Label() { Text = item.ToString() } : null;

        //Create the content
        //If a view wasn't created, we can't use it, exit
        if (!(templateToUse.CreateContent() is View view)) return new Label() { Text = item.ToString() }; ;

        //Set the binding
        view.BindingContext = item;

        return view;
    }
}