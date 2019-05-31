using System;
using System.Collections.Generic;
using TheLittleThingsPlayground.Views;
using VisualTesting.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace TheLittleThingsPlayground
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("source", typeof(ViewSourcePage));
            Routing.RegisterRoute("buttons", typeof(ButtonsPage));



            Routing.RegisterRoute("activityindicators", typeof(ActivityIndicatorsPage));
            Routing.RegisterRoute("cards", typeof(CardsPage));
            Routing.RegisterRoute("editors", typeof(Editors));
            Routing.RegisterRoute("entries", typeof(EntriesPage));
            Routing.RegisterRoute("pickers", typeof(Pickers));
            Routing.RegisterRoute("progress", typeof(ProgressPage));
            Routing.RegisterRoute("sliders", typeof(SlidersPage));
            Routing.RegisterRoute("steppers", typeof(SteppersPage));
            Routing.RegisterRoute("sidebyside", typeof(SideBySide));
            Routing.RegisterRoute("checkbox", typeof(CheckBoxPage));


        }
        async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await GoToAsync("///loginpage");
        }

        async void OnMenuItemPushClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

        async void OnPerformanceClicked(object sender, EventArgs e)
        {
            var page = new ContentPage().LoadProfile();
            await Navigation.PushModalAsync(page);
        }
    }
}
