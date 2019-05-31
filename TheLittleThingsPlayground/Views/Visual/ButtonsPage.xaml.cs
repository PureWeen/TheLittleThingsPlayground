using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace VisualTesting.Pages
{
    [QueryProperty("UseMaterial", "material")]
    public partial class ButtonsPage : ContentPage
    {
        string useMaterial;

        public ButtonsPage()
        {
            InitializeComponent();
        }

        public string UseMaterial
        {
            get => useMaterial;
            set
            {
                useMaterial = value;
                bool _result;

                if (Boolean.TryParse( value, out _result) && _result)
                    Visual = VisualMarker.Material;
                else
                    Visual = VisualMarker.Default;
            }
        }
    }
}
