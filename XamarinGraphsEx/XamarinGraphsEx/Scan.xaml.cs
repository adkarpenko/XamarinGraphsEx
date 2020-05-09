using System;
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
    public partial class Scan : ContentPage
    {
        MainPageViewModel vm;
        public Scan()
        {
            vm = new MainPageViewModel();
            InitializeComponent();
            this.BindingContext = vm;
        }
        private async void btnPieCharts_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PieChart());
        }
    }
}