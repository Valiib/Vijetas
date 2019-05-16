using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace VijetasNews.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewsTemplate : ContentPage
	{
      

		public NewsTemplate (Model.NewsModel newsData)
		{
			InitializeComponent ();
            BindingContext = newsData;
            Mainimage.Source = newsData.ImageLink;
            LoadData();
		}

        private void LoadData()
            {
            Loading.IsRunning =false;
            Loading.IsVisible =false;
            }
	}
}