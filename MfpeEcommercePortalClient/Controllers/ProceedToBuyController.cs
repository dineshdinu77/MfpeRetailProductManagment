using EcommercePortalClient.Models;
using EcommercePortalClient.Models.ViewModels;
using EcommercePortalClient.Provider;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommercePortalClient.Controllers
{
    public class ProceedToBuyController : Controller
    {

        private readonly IProceedToBuyProvider _provider;
        private log4net.ILog _logger = log4net.LogManager.GetLogger(typeof(ProceedToBuyController));
        public ProceedToBuyController(IProceedToBuyProvider provider)
        {
            this._provider = provider;
        }

        [HttpGet]
        public  IActionResult AddToCart(int id)
        {

            if (HttpContext.Session.GetString("token") == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            string today = DateTime.Today.Year.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Day;
            ViewBag.Min = today;
           
            CartViewModel cart = new CartViewModel();
            cart.Product_Id = id;
            cart.Customer_Id = Convert.ToInt32(HttpContext.Session.GetInt32("custId"));
            return View(cart);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddToCart(CartViewModel cart)
        {
            if (HttpContext.Session.GetString("token") == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            else
            {
                if (!ModelState.IsValid)
                {
                    return View(cart);
                }
                Cart cartobj = new Cart();

                try
                {
                    _logger.Info("Adding Products to cart");
                    string token = HttpContext.Session.GetString("token");
                    var response = await _provider.AddToCart(cart,token);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var jsoncontent = await response.Content.ReadAsStringAsync();
                        cartobj = JsonConvert.DeserializeObject<Cart>(jsoncontent);
                        if(cartobj.CartId!=0)
                        {
                            _logger.Info("Cart Added");
                            return View("CartAdded", cartobj);
                        }
                        else
                        {
                            _logger.Error("Error in Adding Cart ");
                            return View("CartNotAdded",cartobj);

                        }
                        
                       
                        
                    }
                    else if(response.StatusCode ==System.Net.HttpStatusCode.NoContent)
                    {
                        ModelState.AddModelError("", "Error while  adding to cart");
                        return View();
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.InternalServerError)
                    {
                        ModelState.AddModelError("", "Having server issue while adding to cart");
                        return View();
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                    {
                        ModelState.AddModelError("", "Invalid model states");
                        return View();
                    }
                }
                catch (Exception e)
                {
                    _logger.Error("Exception Occured as : " + e.Message);
                }
                return View();
            }
        }
        [HttpGet]
        public IActionResult CartAdded()
        {
            _logger.Info("Products added to cart");
            if (HttpContext.Session.GetString("token") == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            Cart cartobj = new Cart();
            return View(cartobj);
        }
        [HttpGet]
        public IActionResult CartNotAdded()
        {
            if (HttpContext.Session.GetString("token") == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            Cart cartobj = new Cart();
            return View(cartobj);
        }

        [HttpGet]
        public IActionResult AddToWishlist(int id)
        {
            _logger.Info("Adding Products to WishList");
            if (HttpContext.Session.GetString("token") == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            WishlistViewModel wish = new WishlistViewModel();
            wish.CustomerId= Convert.ToInt32(HttpContext.Session.GetInt32("custId"));
            wish.ProductId = id;
            return View(wish);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddToWishlist(WishlistViewModel wish)
        {
            if (HttpContext.Session.GetString("token") == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            else
            {
                if (!ModelState.IsValid)
                {
                    return View(wish);
                }
                WishlistStatusViewModel status = new WishlistStatusViewModel();
                try
                {
                    string token = HttpContext.Session.GetString("token");
                    var response = await _provider.AddToWishlist(wish,token);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var jsoncontent = await response.Content.ReadAsStringAsync();
                        status = JsonConvert.DeserializeObject<WishlistStatusViewModel>(jsoncontent);
                        return View("WishlistStatus", status);
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.InternalServerError)
                    {
                        ModelState.AddModelError("", "Having server issue while adding to wishlist");
                        return View();
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                    {
                        ModelState.AddModelError("", "Invalid model states");
                        return View();
                    }
                }
                catch (Exception e)
                {
                    _logger.Error("Exception Occured as : " + e.Message);
                }
                return View();
            }
        }
        [HttpGet]
        public IActionResult WishlistStatus()
        {
            _logger.Info("Sucessfull status for adding products");
            if (HttpContext.Session.GetString("token") == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            WishlistStatusViewModel status = new WishlistStatusViewModel();
            return View(status);
        }
    }
}
