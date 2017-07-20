using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IonicPush.CSharp.Models
{
    public class IOSNotificationConfigVM
    {
        /// <summary>
        /// The number to display as the badge of the app icon
        /// </summary>
        [JsonProperty("badge")]
        public int Badge { get; set; }

        /// <summary>
        /// Determines if the message should be delivered as a silent notification. A value of 1 will cause the message to be delivered as a background notification, which will not display a notification to the user, but the application can still process the notification.
        /// </summary>
        [JsonProperty("content_available")]
        public int ContentAvailable { get; set; }


        /// <summary>
        /// Time at which APNS will stop trying to deliver the notification
        /// </summary>
        [JsonProperty("expire")]
        public string Expire{ get; set; }


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
        /// Default values to for template variables when a corresponding user does not have a value
        /// </summary>
        [JsonProperty("template_defaults")]
        public object TemplateDefaults { get; set; }

        /// <summary>
        /// Notification Title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }


        /// <summary>
        /// Message Priority. A value of 10 will cause APNS to attempt immediate delivery. A value of 5 will attempt a delivery which is convenient for battery life.
        /// </summary>
        [JsonProperty("priority")]
        public int Priority { get; set; }
    }
}
