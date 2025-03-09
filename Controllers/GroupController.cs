using Practical2_INF272.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical2_INF272.Controllers
{
    public class GroupController : Controller
    {
        // GET: Group
        public ActionResult GroupPeople()
        {
            List<Models.GroupModel> group = new List<Models.GroupModel>();
            group.Add(new Models.GroupModel { studentNumber = "u24805522", FirstName = "Aluwani", LastName = "Ndlovu", EmailAddress = "u24805522@tuks.co.za",Link="~/HTML/Aluwani.html" });
            group.Add(new Models.GroupModel { studentNumber = "u24980879", FirstName = "Junior", LastName = "Maluleke", EmailAddress = "u24980879@tuks.co.za",Link = "~/HTML/Junior.html" });
            group.Add(new Models.GroupModel { studentNumber = "u23588548", FirstName = "Sizwe", LastName = "Mjiyakho", EmailAddress = "u23588548@tuks.co.za",Link="~/HTML/Sizwe.html" });
            group.Add(new Models.GroupModel { studentNumber = "u22569848", FirstName = "Pfarelo", LastName = "Muofhe", EmailAddress = "u23569848@tuks.co.za",Link = "~/HTML/Pfarelo.html" });
            group.Add(new Models.GroupModel { studentNumber = "u235698545", FirstName = "Khuliso", LastName = "Madzuvhane", EmailAddress = "u235698545@tuks.co.za",Link = "~/HTML/Khuliso.html" });
            return View(group);
        }
    }
}