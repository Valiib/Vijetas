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
	public partial class Settings : ContentPage
	{
		public Settings ()
		{
			InitializeComponent ();
		}
        
        public bool ToggleCheck { get; set; }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
           if (ToggleCheck == true){
                ToggleCheck = false;
           ((App.Current) as App).ThemeChanger.ApplyTheme("Dark"); }
            else{
                ToggleCheck = true;
            ((App.Current) as App).ThemeChanger.ApplyTheme("Light");
                }
        }
    }
}