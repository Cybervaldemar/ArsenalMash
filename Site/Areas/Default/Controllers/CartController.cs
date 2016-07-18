using Site.Model;
using Site.Models;
using Site.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Areas.Default.Controllers
{
    public class CartController : Controller
    {
        private IRepository repository;
        public CartController(IRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index(Cart cart, string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = cart,
                ReturnUrl = returnUrl
            });
        }

        [HttpGet]
        public ActionResult Checkout()
        {
            return View(new ShippingView());
        }

        [HttpPost]
        public ActionResult Checkout(Cart cart, ShippingView shippingDetails)
        {
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Извините, ваша корзина пуста!");
            }
            

            if (ModelState.IsValid)
            {
                foreach (var line in cart.Lines)
                {
                    ShippingDetails sd = new ShippingDetails();

                    var subtotal = line.Order.Price * line.Quantity;

                    sd.OrderID = line.Order.ID;
                    sd.Line1 = shippingDetails.Line1;
                    sd.Line2 = shippingDetails.Line2;
                    sd.Name = shippingDetails.Name;
                    sd.City = shippingDetails.City;
                    sd.Country = shippingDetails.Country;
                    sd.Count = line.Quantity;

                    repository.CreateDetails(sd);
                    
                }

                cart.Clear();

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(shippingDetails);
            }
        }

        public PartialViewResult Summary(Cart cart)
        {
            return PartialView(cart);
        }
        
        public RedirectToRouteResult AddToCart(Cart cart, int ID, string returnUrl)
        {
            TypeServices game = repository.Services
                .FirstOrDefault(g => g.ID == ID);

            if (game != null)
            {
                cart.AddItem(game, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToRouteResult RemoveFromCart(Cart cart, int ID, string returnUrl)
        {
            TypeServices game = repository.Services
                .FirstOrDefault(g => g.ID == ID);

            if (game != null)
            {
                cart.RemoveLine(game);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        
	}
}