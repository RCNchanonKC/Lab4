using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class VendingMachine
    {
        public int coffee = 0;
        public int water = 0;
        public int chocolate = 0;
        public int milk = 0;

        public VendingMachine()
        {
            this.coffee = 500;
            this.water = 500;
            this.chocolate = 500;
            this.milk = 500;
        }

        public bool make_blackCoffee()
        {
            if (coffee >= 20 && water >= 300)
            {
                coffee -= 20;
                water -= 300;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool make_moccca()
        {
            if (coffee >= 20 && water >= 300 && chocolate >= 10)
            {
                coffee -= 20;
                water -= 300;
                chocolate -= 10;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool make_latte()
        {
            if (coffee >= 20 && water >= 300 && milk >= 10)
            {
                coffee -= 20;
                water -= 300;
                milk -= 10;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool make_chocolate()
        {
            if (water >= 300 && chocolate >= 20)
            {
                water -= 300;
                chocolate -= 20;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void increaseMaterial(int water , int coffee , int milk , int chocolate)
        {
            this.water += water;
            this.coffee += coffee;
            this.milk += milk;
            this.chocolate += chocolate;
        }

    }
}
