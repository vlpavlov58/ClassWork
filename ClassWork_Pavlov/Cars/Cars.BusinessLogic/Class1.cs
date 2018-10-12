using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.BusinessLogic
{
    public class Car
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        private double _price;
        public double Discount { get; set; }

        public double Price
        {
            get
            {
                return _price * Discount;
            }
            set
            {

                _price = value;

            }


        }
    }
}
