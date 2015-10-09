using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcZooStore.Models;
using System.Data.Entity;

//using MvcZooStore.ViewModels;

namespace MvcZooStore.Controllers
{
    public class HomeController : Controller
    {
        ZooStoreEntities storeDB = new ZooStoreEntities();
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to the Zoo Shop!";
            // Get most popular pets
            var pets = GetTopSellingPets(5);

            return View(pets);
           
        }
   
        //test
       /* public ActionResult Test()
        {
        return RedirectToAction("Index", "Home");
        }*/
                        
            //return View();
        

        public ActionResult About()
        {
            return View();
        }
        private List<Pet> GetTopSellingPets(int count)
        {
            // Group the order details by pet and return
            // the pets with the highest count
            return storeDB.Pets
            .OrderByDescending(a => (from od in a.OrderDetails
                                     select od.Quantity).Sum())
            .Take(count)
            .ToList();
        }
    }
}
