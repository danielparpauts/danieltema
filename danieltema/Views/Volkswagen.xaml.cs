﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace danieltema.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Volkswagen : ContentPage
    {
        public Volkswagen()
        {
            InitializeComponent();
        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            header.Text = "Модель:" + picker.Items[picker.SelectedIndex];
        }
    }
}