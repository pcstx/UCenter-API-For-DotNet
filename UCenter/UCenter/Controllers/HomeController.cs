using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DS.Web.UCenter.Client;
using DS.Web.UCenter;

namespace UCenter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           

            return View();
        }

        [HttpPost]
        public ActionResult Register(string userName,string password,string email)
        {
            UcClient client = new UcClient();
            UcUserRegister result= client.UserRegister(userName, password, email);

            return Content(result.Uid.ToString());
        }

        [HttpPost]
        public ActionResult GetMessage(int uid)
        {
            UcClient client = new UcClient();

           var userInfo= client.UserInfo(uid);

            UcPmCheckNew news= client.PmCheckNew(uid);
            int announcePm = news.AnnouncePm;

            return Content(announcePm.ToString());
        }

        [HttpPost]
        public ActionResult Login(string userName, string passWord)
        {
            UcClient client = new UcClient();
            UcUserLogin login= client.UserLogin(userName, passWord);
            if (login.Success)
            {
                string result= client.UserSynlogin(login.Uid);
            }

            return Content(login.UserName);
        }

        [HttpPost]
        public ActionResult Logout()
        {
            UcClient client = new UcClient();
            string result= client.UserSynLogout();
            return Content(result);
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