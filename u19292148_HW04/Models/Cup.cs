using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19292148_HW04.Models
{
    public class Cup: Product
    {

        public string cqoute;

        public string CQoute { get => cqoute; set => cqoute = value; }


        public Cup()
        {

        }

        public Cup(double price, string type, string name, string surname, string email, string phone, int qty, string addresss, string qoute) : base(price, type, name, surname, email, phone, qty, addresss)
        {
            CQoute = qoute;
        }

        public override double getPrice()
        {
            double newPrice = 0;
            newPrice = Qty * Price;
            return newPrice;
        }

        public override string getSelect()
        {
            return CQoute;
        }
    }
}