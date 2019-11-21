using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JustEat.Controllers
{
    public class RestaurantController : Controller
    {
       

        // GET: Restaurant/login
        public ActionResult Login()
        {
            return View();
        }



        // GET: Restaurant/Home/id
        public ActionResult Home()
        {
            return View();
        }

        // GET: Restaurant/SignUp
        public ActionResult SignUp()
        {
            return View();
        }

        // GET: Restaurant/AddFood
        
        public ActionResult AddFood()
        {
            return View();
        }

        // GET: Restaurant/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Restaurant/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Restaurant/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Restaurant/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
