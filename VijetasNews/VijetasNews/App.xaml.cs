using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using VijetasNews.Functions;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace VijetasNews
{
    public partial class App : Application
    {
        public readonly IThemeChanger ThemeChanger;
        public App(IThemeChanger themeChanger)
        {
            InitializeComponent();

            this.ThemeChanger = themeChanger;

            var userid = Preferences.Get("UserId","");


            if (userid != "")
                {
                var userIdToTest = new Model.UserRead(){ param_userId = userid  };
                
                var UserInfoJson =  JsonConvert.SerializeObject(userIdToTest);

                var Session = new Functions.PersonalHTTPs();

                var httpResponseFromRegister = Session.ResponseFromRequest(UserInfoJson,
                    "http://192.168.0.111:8080/api/GetUserInfoById");
                
                
                JObject results = JObject.Parse(httpResponseFromRegister);
                
                bool resflag = (bool) results["resflag"];
                
                
                if(resflag)
                    {
                    MainPage = new NavigationPage(new Views.MainPage());
                    }else{
                    MainPage = new NavigationPage(new Views.FirstTimer());
                    }
                }else{
                MainPage = new NavigationPage(new Views.FirstTimer()); }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
