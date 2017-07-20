using IonicPush.CSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IonicPush.CSharp
{
    public class Notification :INotification
    {

        private readonly Push _ionicPush;

        /// <summary>
        /// Constructor to create a Notification Object
        /// </summary>
        /// <param name="ionicPush">Ionic Push Object</param>
        public Notification(Push ionicPush)
        {
            _ionicPush = ionicPush;
        }
    }
}
