using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    /// <summary>
    /// A class that is used for coffe orders
    /// </summary>
    abstract class Coffee
    {
        /// <summary>
        /// returns the price of the coffee
        /// It's possible to override this method, beacuse it is virtual 
        /// </summary>
        /// <returns>20 dkr</returns>

        private int _discount;
        private int _price;

        public Coffee(int discount)
        {
            _discount = discount;

            if (discount > 5)
            {
                throw new Exception("Discount cannot be above 5 DKK");
            }

            if (discount < 0)
            {
                throw new Exception("Discount cannot be below 0 DKK");
            }
        }

        public int Discount
        {
            get { return _discount; }
            set
            {
                if (_discount > 5 || _discount < 0)
                {
                    throw new Exception("Discount cannot be greater than 5 or smaller than 0 DKK");
                }

                else
                {
                    _discount = value;
                }
            }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        
        public virtual int price()
        {
            Price = 20;
            return Price - Discount;
        }

        public abstract string strength();
        

    }
}
