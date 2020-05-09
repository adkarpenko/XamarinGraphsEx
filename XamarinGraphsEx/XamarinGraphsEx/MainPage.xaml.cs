using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinGraphsEx.ViewModels;

namespace XamarinGraphsEx
{
	public partial class MainPage : MasterDetailPage
	{
        //MainPageViewModel vm;
		public MainPage()
		{
            //vm = new MainPageViewModel();
			InitializeComponent();
            Detail = new NavigationPage(new History());
            //this.BindingContext = vm;
		}

        private void Button1_Click(object sender,EventArgs e)
        {
            Detail = new NavigationPage(new Scan());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new diagram());
        }
        //private async void btnPieCharts_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushModalAsync(new PieChart());
        //}
    }
}
