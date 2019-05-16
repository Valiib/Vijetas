using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace VijetasNews.Model
{
    class UserRead
    {
        public string param_userId { get; set; }
    }
    class UserCreate
    {
        public string param_name { get; set; }
        public string param_surname { get; set; }
        public string param_token {get;set;} = Preferences.Get("Token","");
    }
}
