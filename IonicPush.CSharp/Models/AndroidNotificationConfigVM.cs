using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IonicPush.CSharp.Models
{
    public class AndroidNotificationConfigVM
    {
        /// <summary>
        /// Identifies a group of messages that can be collapsed, so that only the last message gets sent when delivery can be resumed.
        /// </summary>
        [JsonProperty("collapse_key")]
        public string CollapseKey { get; set; }

        /// <summary>
        /// Determines if the message should be delivered as a silent notification. A value of 1 will cause the message to be delivered as a background notification, which will not display a notification to the user, but the application can still process the notification.
        /// </summary>

        [JsonProperty("content_available")]
        public int ContentAvailable { get; set; }

        /// <summary>
        ///Raw data sent to GCM
        /// </summary>
        [JsonProperty("data")]
        public object Data { get; set; }

        /// <summary>
        ///When this parameter is set to true, it indicates that the message should not be sent until the device becomes active.
        /// </summary>
        [JsonProperty("delay_while_idle")]
        public bool DelayWhileIdle{ get; set; }


        /// <summary>
        ///Filename of the Icon to display with the notification
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }

        /// <summary>
        ///Filename or URI of an image file to display with the notification
        /// </summary>
        [JsonProperty("image")]
        public string    Image { get; set; }


        /// <summary>
        ///Message Text
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// Custom data
        /// </summary>
        [JsonProperty("payload")]
        public object Payload { get; set; }

        /// <summary>
        /// Filename of audio file to play when a notification is received. Setting this to default will use the default Android device notification sound
        /// </summary>
        [JsonProperty("sound")]
        public string Sound { get; set; }

        /// <summary>
        ///Indicates whether each notification message results in a new entry on the notification center on Android.If not set, each request creates a new notification.If set, and a notification with the same tag is already being shown, the new notification replaces the existing one in notification center.
        /// </summary>
        [JsonProperty("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// Default values to for template variables when a corresponding user does not have a value
        /// </summary>
        [JsonProperty("template_defaults")]
        public object TemplateDefaults { get; set; }

        /// <summary>
        /// This parameter specifies how long (in seconds) the message should be kept in GCM storage if the device is offline
        /// </summary>
        [JsonProperty("time_to_live")]
        public int TimeToLive { get; set; }

        /// <summary>
        /// Notification Title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

    }
}
