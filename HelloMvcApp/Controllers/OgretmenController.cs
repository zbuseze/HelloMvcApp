using HelloMvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace HelloMvcApp.Controllers
{
    public class OgretmenController : Controller
    {
        // LIST
        public IActionResult Index()
        {
            List<Ogretmen> lst;
            using(var ctx = new OkulDbContext())
            {
                lst = ctx.Ogretmenler.ToList();
            }

            return View(lst);
        }
        // INSERT
        [HttpGet]
        public ViewResult AddOgretmen()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddOgretmen(Ogretmen ogrt)
        {
            using(var ctx= new OkulDbContext())
            {
                ctx.Ogretmenler.Add(ogrt);
                var result = ctx.SaveChanges();
                if (result>0)
                {
                    TempData["result"]= true;
                }
                else
                {
                    TempData["result"] = null;
                }
            }

            return RedirectToAction("Index");
        }
        // UPDATE 
        [HttpGet]
        
        public IActionResult UpdateOgretmen(int id)
        {
            Ogretmen ogrt;
            using (var ctx = new OkulDbContext())
            {
                ogrt = ctx.Ogretmenler.Find(id);
            }
            return View(ogrt);
            
        }
        [HttpPost]
        public IActionResult UpdateOgretmen(Ogretmen ogrt) // this object is sent to database
        {
            using(var ctx=new OkulDbContext())
            {
                ctx.Entry(ogrt).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                ctx.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // DELETE
        public IActionResult DeleteOgretmen(int id)
        {
            Ogretmen ogrt;
            using(var ctx = new OkulDbContext())
            {
                ogrt= ctx.Ogretmenler.Find(id);
                ctx.Ogretmenler.Remove(ogrt);
                ctx.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
