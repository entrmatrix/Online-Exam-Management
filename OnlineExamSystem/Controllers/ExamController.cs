using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineExamSystem.Controllers
{
    public class ExamController : Controller
    {
        //
        // GET: /Exam/
        public ActionResult CreateExam()
        {
            return View();
        }
	}
}