using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bll;
using Models;

namespace OnlineExamSystem.Controllers
{
    public class CourseController : Controller
    {
        CourseBll _courseBll=new CourseBll();
        //
        // GET: /Course/
        [HttpGet]
        public ActionResult Entry()
        {
            var model =new Course()
            {
                organizationSlItems = GetAllOrganizatonSlItems()
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult Entry(Course course)
        {
            bool isSaved=_courseBll.Add(course);
            course.organizationSlItems = GetAllOrganizatonSlItems();
            return View(course);
        }

        public List<SelectListItem> GetAllOrganizatonSlItems()
        {
            var organizations = _courseBll.GetAllOrganizations();
            var selectItems = new List<SelectListItem>();
            foreach (var organization in organizations)
            {
                var sli = new SelectListItem();
                sli.Text = organization.Name;
                sli.Value = organization.Id.ToString();
                selectItems.Add(sli);
            }
            return selectItems;
        } 
	}
}