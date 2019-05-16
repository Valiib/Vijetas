using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Gms.Common;
using Android.Util;
using Firebase.Iid;
using Firebase.Messaging;
using VijetasNews.Functions;

namespace VijetasNews.Droid
{
    [Activity(Label = "VijetasNews", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity , IThemeChanger
    {
       
       static readonly string TAG = "MainActivity";

            internal static readonly string CHANNEL_ID = "my_notification_channel";
            internal static readonly int NOTIFICATION_ID = 100;

            TextView msgText;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            
    
         

              base.OnCreate (savedInstanceState);
             

              msgText = FindViewById<TextView> (Resource.Id.msgText);
          

            if (Intent.Extras != null)
            {
                foreach (var key in Intent.Extras.KeySet())
                {
                    var value = Intent.Extras.GetString(key);
                    Log.Debug(TAG, "Key: {0} Value: {1}", key, value);
                }
            }
        
            IsPlayServicesAvailable ();
            CreateNotificationChannel();
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            FFImageLoading.Forms.Platform.CachedImageRenderer.Init(enableFastRenderer: true);
            
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
           
                  
                     
        
        var logTokenButton = FindViewById<Button>(Resource.Id.logTokenButton);
       
        LoadApplication(new App(this));
        }
  
        
    public bool IsPlayServicesAvailable ()
    {
        int resultCode = GoogleApiAvailability.Instance.IsGooglePlayServicesAvailable (this);
        if (resultCode != ConnectionResult.Success)
        {
            if (GoogleApiAvailability.Instance.IsUserResolvableError (resultCode))
                msgText.Text = GoogleApiAvailability.Instance.GetErrorString (resultCode);
            else
            {
                msgText.Text = "This device is not supported";
                Finish ();
            }
            return false;
        }
        else
        {
           
            return true;
        }
    }
        
        
         public void ApplyTheme(string newTheme)
        {
            if (newTheme?.ToLower() == "dark")
            {
                SetTheme(Resource.Style.Base_Theme_AppCompat);
            }
            else
            {
                SetTheme(Resource.Style.Base_Theme_AppCompat_Light);
            }
        }
        
    void CreateNotificationChannel()
    {
        if (Build.VERSION.SdkInt < BuildVersionCodes.O)
        {
            // Notification channels are new in API 26 (and not a part of the
            // support library). There is no need to create a notification
            // channel on older versions of Android.
            return;
        }

        var channel = new NotificationChannel(CHANNEL_ID,
                                                "FCM Notifications",
                                                NotificationImportance.Default)
                        {

                            Description = "Firebase Cloud Messages appear in this channel"
                        };

        var notificationManager = (NotificationManager)GetSystemService(Android.Content.Context.NotificationService);
        notificationManager.CreateNotificationChannel(channel);
    }


    } 
}