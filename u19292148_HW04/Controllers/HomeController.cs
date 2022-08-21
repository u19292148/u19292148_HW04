using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u19292148_HW04.Models;

namespace u19292148_HW04.Controllers
{
    public class HomeController : Controller
    {
        public static List<Product> products = new List<Product>();
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult NPO()
        {
            return View();
        }
        
        public ActionResult Shop()
        {
            return View();
        }

        public ActionResult Card()
        {
            return View(products);
        }

        public ActionResult Invoice()
        {
            return View(products);
        }

        [HttpGet]
        public ActionResult Display()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Display(string type,string name, string surname, string email, string phone, string colour, int qty, string pattern,string address, string qoute)
        { 
            if(type == "Straw")
            {
                Straw newS = new Straw()
                {
                    Price = 100,
                    Type = type,
                    Name = name,
                    Surname = surname,
                    Email = email,
                    Phone = phone,
                    SColour = colour,
                    Qty = qty,
                    Address = address

                };
                products.Add(newS);
            }
            else if(type == "Bag")
            {
                Bag newB = new Bag()
                {
                    Price = 350,
                    Type = type,
                    Name = name,
                    Surname = surname,
                    Email = email,
                    Phone = phone,
                    BPattern = pattern,
                    Qty = qty,
                    Address = address,

                };
                products.Add(newB);
            }
            else if(type == "Cup")
            {
                Cup newC = new Cup()
                {
                    Price = 250,
                    Type = type,
                    Name = name,
                    Surname = surname,
                    Email = email,
                    Phone = phone,
                    CQoute = qoute,
                    Qty = qty,
                    Address = address,

                };
                products.Add(newC);
            }

           
            return RedirectToAction("Card");
        }







    }
}