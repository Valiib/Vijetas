using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VijetasNews.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CategorySelected : ContentPage
	{

        

		public CategorySelected (ObservableCollection<Model.NewsModel> BindingObjects)
		{
			InitializeComponent ();
             NewsView.ItemsSource = BindingObjects;
            
		}
          private  void OpenDesiredProfile(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null) return;
            var NewsData = e.Item as Model.NewsModel;
          
            Navigation.PushAsync(new NewsTemplate(NewsData));
           

        }
	}
}