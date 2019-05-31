﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace VisualTesting.Pages
{
    [QueryProperty("UseMaterial", "material")]
    public partial class ActivityIndicatorsPage : ContentPage
    {
        public ActivityIndicatorsPage()
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
