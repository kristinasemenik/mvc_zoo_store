using System;
using System.Linq;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Data;
using MvcZooStore.Models;
using System.Data.Entity;

namespace MvcZooStore.Controllers
{
    [Authorize]
    public class CheckoutController : Controller
    {
        ZooStoreEntities storeDB = new ZooStoreEntities();
        const string PromoCode = "FREE";

        public ActionResult UserCart(string nameparam)
        {
            ViewBag.param = nameparam;
            return View(storeDB.OrderDetails.ToList());
        }

        public ActionResult UserCartDetails(int idparam)
        {
            ViewBag.param = idparam;
            return View(storeDB.OrderDetails.ToList());
        }
        
        //
        // GET: /Checkout/AddressAndPayment

        public ActionResult AddressAndPayment()
        {
            return View();
        }

        //
        // POST: /Checkout/AddressAndPayment

        [HttpPost]
        public ActionResult AddressAndPayment(FormCollection values)
        {
            var order = new Order();
            TryUpdateModel(order);

            try
            {
                if (string.Equals(values["PromoCode"], PromoCode,
                   StringComparison.OrdinalIgnoreCase) == true)
                {
                    order.Username = User.Identity.Name;
                    order.OrderDate = DateTime.Now;
                    order.Total = 0;
                    //return View(order);

                 storeDB.Orders.Add(order);                   
                   storeDB.SaveChanges();
                    


                    var cart = ShoppingCart.GetCart(this.HttpContext);
                    cart.CreateOrder(order);

                    return RedirectToAction("Complete",
                        new { id = order.OrderID });
                }
                else
                {
                    order.Username = User.Identity.Name;
                    order.OrderDate = DateTime.Now;

                    //Save Order
                //  storeDB.Orders.Add(order);
                 // storeDB.SaveChanges();

                    //Process the order
                    var cart = ShoppingCart.GetCart(this.HttpContext);
                    cart.CreateOrder(order);

                    return RedirectToAction("Complete",
                        new { id = order.OrderID });
                }

            }
            catch
            {
                //Invalid - redisplay with errors
                return View(order);
            }
        }

        //
        // GET: /Checkout/Complete

        public ActionResult Complete(int id)
        {
            // Validate customer owns this order
            bool isValid = storeDB.Orders.Any(
                o => o.OrderID == id &&
                o.Username == User.Identity.Name);

            if (isValid)
            {
                return View(id);
            }
            else
            {
                return View("Error");
            }
        }
    }
}
