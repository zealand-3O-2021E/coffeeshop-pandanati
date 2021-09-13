using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class FlatWhite : Coffee, IMilk
    {
        public int mlMilk()
        {
            return 160;
        }
        public FlatWhite(int discount) : base(discount)
        {

        }

        public override int price()
        {
            return 30;
        }

        public override string strength()
        {
            return "Mild";
        }
    }
}
