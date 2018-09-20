
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bll;
using Models;

namespace OnlineExamSystem.Controllers
{
    public class OrganizationController : Controller
    {
        OrganizationBll _organizationBll=new OrganizationBll();



        public ActionResult Entry()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Entry(Organization organization)
        {
            if (ModelState.IsValid)
            {
                bool isSaved = _organizationBll.Add(organization);
            }
          

            return View();
        }


        

        
	}
}