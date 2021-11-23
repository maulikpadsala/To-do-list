using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentRecordManagementSystem.Models;

namespace StudentRecordManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        StudentDataAccessLayer studentDataAccessLayer = null;
        public StudentController()
        {
            studentDataAccessLayer = new StudentDataAccessLayer();
        }

        // GET: Student
        public ActionResult Index()
        {
            IEnumerable<ToDo> students = studentDataAccessLayer.GetAll();
            return View(students);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            ToDo student = studentDataAccessLayer.Get(id);
            return View(student);
           
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ToDo ToDo)
        {
            try
            {
                // TODO: Add insert logic here
                studentDataAccessLayer.Add(ToDo);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            ToDo ToDo = studentDataAccessLayer.Get(id);
            return View(ToDo);
        }

        // POST: Student/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ToDo ToDo)
        {
            try
            {
                // TODO: Add update logic here
                studentDataAccessLayer.Update(ToDo);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            ToDo ObjToDo = studentDataAccessLayer.Get(id);
            return View(ObjToDo);
        }

        // POST: Student/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ToDo todo)
        {
            try
            {
                // TODO: Add delete logic here
                studentDataAccessLayer.Delete(todo.Id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}