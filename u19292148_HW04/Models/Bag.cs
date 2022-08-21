using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19292148_HW04.Models
{
    public class Bag: Product
    {

        public string bpattern;



        public string BPattern { get => bpattern; set => bpattern = value; }


        public Bag()
        {

        }

        public Bag(double price, string type, string name, string surname, string email, string phone, int qty, string addresss, string pattern) : base(price, type, name, surname, email, phone, qty, addresss)
        {
            BPattern = pattern;
        }

        public override double getPrice()
        {
            double newPrice = 0;
            newPrice = Qty * Price;
            return newPrice;
        }

        public override string getSelect()
        {
            return BPattern;
        }
    }
}