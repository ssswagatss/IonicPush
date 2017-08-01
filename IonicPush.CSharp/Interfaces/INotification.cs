using IonicPush.CSharp.Models;
using IonicPush.CSharp.Models.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IonicPush.CSharp.Interfaces
{
    public interface INotification
    {
        Task<Result<List<CreatedNotificationVM>>> GetNotifications(int? pageSize, int? page);
        Task<Result<CreatedNotificationVM>> SendNotificationsToDevices(List<string> tokens, string heading, string message);
        Task<Result<CreatedNotificationVM>> SendNotificationsToAll(string heading, string message);
    }
}
