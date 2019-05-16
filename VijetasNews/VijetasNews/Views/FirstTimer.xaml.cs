using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VijetasNews.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstTimer : ContentPage
    {
        public FirstTimer()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (Name.Text == null && Surname.Text == null)
                {
                Name.Text = String.Empty;
                Surname.Text = String.Empty;
                }
            else{
                var UserInfo = new Model.UserCreate()
                {
                    param_name = Name.Text,
                    param_surname = Surname.Text
                };
                var UserInfoJson =  JsonConvert.SerializeObject(UserInfo);

                var Session = new Functions.PersonalHTTPs();

                var httpResponseFromRegister = Session.ResponseFromRequest(UserInfoJson,
                    "http://192.168.0.111:8080/api/registerUser");

               JObject results = JObject.Parse(httpResponseFromRegister);
                
               bool resflag = (bool) results["resflag"];
               if (resflag == true)
                    {
                        var userobject =  (string)results["userobject"];
                        
                        var userobjectObject =   JObject.Parse(userobject);
                        
                        var UserId = (string)userobjectObject["param_id"];

                        Preferences.Set("UserId",UserId);
                        
                         App.Current.MainPage = new NavigationPage(new MainPage());
                        
                    }

                
            }
        }
    }
}