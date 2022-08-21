using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19292148_HW04.Models
{
    public class Straw: Product
    {

        public string scolour;
      

        public string SColour { get => scolour; set => scolour = value; }


        public Straw()
        {

        }

        public Straw(double price, string type, string name, string surname, string email, string phone, int qty, string addresss, string colour ): base(price,type, name, surname, email, phone, qty, addresss)
        {
            SColour = colour;

        }

        public override double getPrice()
        {
            double newPrice = 0;
            newPrice = Qty * Price;
            return newPrice;
        }

        public override string getSelect()
        {
            return SColour;
        }
    }
}