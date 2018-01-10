using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstLook.Models;

namespace FirstLook.Controllers
{
    public class MailingController : Controller
    {
        // GET: Mailing
        public ActionResult Index()
        {
            //first instance of the Mailing() class
            Mailing m1 = new Mailing();
            m1.FirstName = "James";
            m1.LastName = "Shively";
            m1.Email = "james.shively-iii@seattlecentral.edu";

            //second instance of the Mailing() class
            Mailing m2 = new Mailing();
            m2.FirstName = "Cory";
            m2.LastName = "Trevor";
            m2.Email = "smokes_now@sunnyvale.com";

            //third instance of the Mailing() class
            Mailing m3 = new Mailing();
            m3.FirstName = "Sara";
            m3.LastName = "Reed";
            m3.Email = "saraspringreed@gmail.com";

            //adds the instances to the mailing list
            List<Mailing> mailings = new List<Mailing>();
            mailings.Add(m1);
            mailings.Add(m2);
            mailings.Add(m3);

            //returns the view of the instances
            return View(mailings);
        }
    }
}