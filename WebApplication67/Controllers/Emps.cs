using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication67.Models
{
    public class Emps : Controller
    { List<Emp> l1 = new List<Emp>
    {new Emp{Eid=1,Ename="Gaurav",EDesig="Devloper",EDoj=DateTime.Now },
    new Emp{Eid=2,Ename="Ram",EDesig="Devloper",EDoj=DateTime.Now },
    new Emp{Eid=3,Ename="Karan",EDesig="tester",EDoj=DateTime.Now },
    new Emp{Eid=4,Ename="Jason",EDesig="Hr",EDoj=DateTime.Now },
    };
        // GET: Emps
        public ActionResult Index()
        {
            return View(l1);
        }

        // GET: Emps/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Emps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Emps/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Emps/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Emps/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Emps/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Emps/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
