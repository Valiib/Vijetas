
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
	public partial class Categories : ContentPage
	{
		public Categories ()
		{
			InitializeComponent ();
              BindingContext = new ViewModel.CategoryViewModel();

		}

        private void Category_itemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null) return;
            var NewsData = e.Item as Model.CategoryModel;
          



            Navigation.PushAsync(new CategorySelected(NewsData.NewsOnThis));
        }
    }
}