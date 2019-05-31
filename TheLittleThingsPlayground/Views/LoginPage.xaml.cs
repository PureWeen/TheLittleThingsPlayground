using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TheLittleThingsPlayground.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            Shell.SetBackButtonBehavior(this,
                new BackButtonBehavior()
                {
                    IconOverride = "coffee.png",
                    Command = new Command(async () =>
                    {
                        OnLoginClicked(this, EventArgs.Empty);
                    })
                });
        }

        async void OnLoginClicked(object sender, EventArgs e)
        {
            if (Navigation.NavigationStack.Count > 1)
                await Navigation.PopAsync();
            else
                await Shell.Current.GoToAsync("///Bottom Tabs");
        }

    }
}