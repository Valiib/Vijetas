
using Android.App;
using Android.Content;

using Android.Util;
using Firebase.Messaging;


using Android.Support.V4.App;

using VijetasNews.Droid;

[Service]
[IntentFilter(new[] { "com.google.firebase.MESSAGING_EVENT" })]
public class MyFirebaseMessagingService : FirebaseMessagingService
{
    private readonly string Tag = "MyFirebaseMsgService";
   
    void SendNotification(string title,string bodytext)
    {
        var intent = new Intent(this, typeof(VijetasNews.Droid.MainActivity));
        
        

        var pendingIntent = PendingIntent.GetActivity(this,
                                                      VijetasNews.Droid.MainActivity.NOTIFICATION_ID,
                                                      intent,
                                                      PendingIntentFlags.OneShot);

        var notificationBuilder = new NotificationCompat.Builder(this, VijetasNews.Droid.MainActivity.CHANNEL_ID)
                                  .SetSmallIcon(Resource.Drawable.ic_stat_ic_notification)
                                  .SetContentTitle(title)
                                  .SetContentText(bodytext)
                                  .SetAutoCancel(true)
                                  .SetContentIntent(pendingIntent);

        var notificationManager = NotificationManagerCompat.From(this);
        notificationManager.Notify(VijetasNews.Droid.MainActivity.NOTIFICATION_ID, notificationBuilder.Build());
    }
    public override void OnMessageReceived(RemoteMessage message)
    {
        Log.Debug(Tag, "From: " + message.From);
        

        
       var nameT = message.Data["key1"];
       var bodyT = message.Data["key2"];
        

        SendNotification(nameT,bodyT);
    }
}