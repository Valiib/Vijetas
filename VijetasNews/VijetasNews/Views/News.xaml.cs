using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VijetasNews.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class News : ContentPage
	{
		public News ()
		{
			InitializeComponent ();
            BindingContext = new ViewModel.NewsViewModel();
		}

        private  void OpenDesiredProfile(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null) return;
            var NewsData = e.Item as Model.NewsModel;
          
            Navigation.PushAsync(new NewsTemplate(NewsData));
           

        }
	}
}