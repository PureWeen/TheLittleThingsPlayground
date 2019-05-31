using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisualTesting.Pages
{
    [QueryProperty("UseMaterial", "material")]
    public partial class CheckBoxPage : ContentPage
    {
        public CheckBoxPage()
        {
            InitializeComponent();
        }

        public string UseMaterial
        {
            set
            {
                bool _result;

                if (Boolean.TryParse(value, out _result) && _result)
                    Visual = VisualMarker.Material;
                else
                    Visual = VisualMarker.Default;
            }
        }
    }
}