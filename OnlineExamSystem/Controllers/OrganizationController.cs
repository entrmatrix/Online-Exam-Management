using DatabaseContext;
using OnlineExamSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineExamSystem.Controllers
{
    public class OrganizationController : Controller
    {
        
        public ActionResult Entry(Organization organization)
        {
            if(!string.IsNullOrEmpty(organization.Name))
            {
                
                bool x = Add(organization);
            }
            return View();
        }
        private bool Add(Organization organization)
        {
            OrganizationDbContext db = new OrganizationDbContext();
            db.Organizations.Add(organization);
            return db.SaveChanges() > 0;
        }
	}
}