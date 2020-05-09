﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinGraphsEx.ViewModels;

namespace XamarinGraphsEx
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PieChart : ContentPage
	{
        PieChartViewModel vm;
        public PieChart()
        {
            vm = new PieChartViewModel();
            InitializeComponent();
            this.BindingContext = vm;
        }
    }
}