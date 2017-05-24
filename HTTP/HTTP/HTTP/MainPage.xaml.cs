﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HTTP
{
    public partial class MainPage : ContentPage
    {
        RateViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();

            viewModel = new RateViewModel();
            // установка контекста данных
            this.BindingContext = viewModel;
        }
    }
}
