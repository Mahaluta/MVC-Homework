using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeworkMVC.Models;

namespace HomeworkMVC.Controllers
{
    public class StudentController : Controller
    {
       
        public StudentController()
        {

        }

        [HttpPost]
        public ActionResult PostAction()
        {
            return View("Index");
        }


        [HttpPut]
        public ActionResult PutAction()
        {
            return View("Index");
        }

        [HttpDelete]
        public ActionResult DeleteAction()
        {
            return View("Index");
        }

        [HttpHead]
        public ActionResult HeadAction()
        {
            return View("Index");
        }

        [HttpOptions]
        public ActionResult OptionsAction()
        {
            return View("Index");
        }

        [HttpPatch]
        public ActionResult PatchAction()
        {
            return View("Index");
        }

        [AcceptVerbs(HttpVerbs.Post | HttpVerbs.Get)]
        public ActionResult GetAndPostAction()
        {
            return RedirectToAction("Index");
        }

        [ActionName("find")]
        public ActionResult GetById (int id)
        {
            // get student from the database 
            return View();
        }

        [NonAction]
        public Student GetStudent(int id)
        {
            return GetList().Where(s => s.StudentId == id).FirstOrDefault();
        }

        // GET: Student
        public ActionResult Index()
        {
            var std = GetList();
            return View(std);
        }

        // [HttpGet] by default
        public ActionResult Edit(int id)
        {
            var std = GetList().Where(s => s.StudentId == id).FirstOrDefault();

            return View(std);
        }

        [HttpPost]
        public ActionResult Edit(Student std)
        {
            {
                var id = std.StudentId;
                var name = std.StudentName;
                var age = std.StudentAge;
                var standardName = std.standard.StandardName;

                //update database here..

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

       [HttpDelete]
       public ActionResult Delete(int id)
        {
            // delete student from the database whose id matches with specified id

            return RedirectToAction("Index");
        }

        private List<Student> GetList()
        {
            var s1 = new Student { StudentName = "s1", StudentId = 1, StudentAge = 20 };
            var s2 = new Student { StudentName = "s2", StudentId = 2, StudentAge = 21 };
            var s3 = new Student { StudentName = "s3", StudentId = 3, StudentAge = 22 };

            return new List<Student> { s1, s2, s3 };
        }
    }
}