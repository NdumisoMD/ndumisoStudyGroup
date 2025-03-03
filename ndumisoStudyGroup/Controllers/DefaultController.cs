using ndumisoStudyGroup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace ndumisoStudyGroup.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult View()
        {

            List<Models.StudentDetails> members = new List<Models.StudentDetails>();

            members.Add(new Models.StudentDetails { StudentNumber = "23558530", Name = "Ndumiso", Surname = "Manyike", Email = "u23558530@tuks.co.za" });
            members.Add(new Models.StudentDetails { StudentNumber = "24951405", Name = "Lathitha", Surname = "Mqoboli", Email = "u249551405tuks.co.za" });
            members.Add(new Models.StudentDetails { StudentNumber = "23578140", Name = "Kopano", Surname = "Moloi", Email = "23578140@tuks.co.za" });
            members.Add(new Models.StudentDetails { StudentNumber = "246866752", Name = "Thato", Surname = "Mokgothu", Email = "246866752.co.za" });
            members.Add(new Models.StudentDetails { StudentNumber = "23643570", Name = "Mary", Surname = "Modiba", Email = "23643570@tuks.co.za" });
            return View(members);
        }
    }
}