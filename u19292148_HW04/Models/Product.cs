using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19292148_HW04.Models
{
    public abstract class Product
    {
        public double Price { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Qty { get; set; }
        public string Address { get; set; }


        public Product()
        {

        }

        public Product(double price, string type, string name, string surname, string email, string phone, int qty, string address)
        {
            Price = price;
            Type = type;
            Name = name;
            Surname = surname;
            Email = email;
            Phone = phone;
            Qty = qty;
            Address = address;
        }

        public abstract double getPrice();
        public abstract string getSelect();

    }


}