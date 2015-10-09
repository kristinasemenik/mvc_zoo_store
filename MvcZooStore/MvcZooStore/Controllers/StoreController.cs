using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcZooStore.Models;

namespace MvcZooStore.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/
        ZooStoreEntities storeDB = new ZooStoreEntities();
        public ActionResult Index()
        {
            var kinds = storeDB.Kinds.ToList();
            return View(kinds);
        }
        public ActionResult Details(int id)
        {
            var pet = storeDB.Pets.Find(id);
            return View(pet);
        }
        public ActionResult Browse(string kind)
        {
            var kindModel = storeDB.Kinds.Include("Pets").Single(g => g.Name == kind);
            return View(kindModel);
        }

        //
        // GET: /Store/KindMenu
        [ChildActionOnly]
        public ActionResult KindMenu()
        {
            var kinds = storeDB.Kinds.ToList();
            return PartialView(kinds);
        }

       /* public ActionResult UserCart(string nameparam)
        {
            ViewBag.param = nameparam;
            return View(storeDB.OrderDetails.ToList());
        }

        public ActionResult UserCartDetails(int idparam)
        {
            ViewBag.param = idparam;
            return View(storeDB.OrderDetails.ToList());
        }*/
    }
}
