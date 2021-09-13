using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Cortado : Coffee, IMilk
    {
        public int mlMilk()
        {
            return 40;
        }

        public Cortado(int discount) : base( discount )
        {
            
        }


        public override int price()
        {
            return 25;
        }

        public override string strength()
        {
            return "Medium";
        }

        
    }
}
