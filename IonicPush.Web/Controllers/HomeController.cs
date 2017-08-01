using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IonicPush.CSharp;
using System.Threading.Tasks;

namespace IonicPush.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly string _apiKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJqdGkiOiJmMDQ5NTM1Zi0zMGUyLTQ5MWYtODhiOS03OTc2YTdhYzI3NWIifQ.EnVbwN9ZtD0ccc6-y-O3NG6zKLTVB0fc2HhwMMAOBUQ";
        public async Task<ActionResult> Index()
        {
            //Token token = new Token(new Push(_apiKey));
            //var res = await token.GetTokens(null, null, null);


            var notification = new Notification(new Push(_apiKey));
            //var res = await notification.SendNotificationsToAll("This is the title", "This is the message");

            var res = await notification.GetNotifications(null, null);
            return Json(res,JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}