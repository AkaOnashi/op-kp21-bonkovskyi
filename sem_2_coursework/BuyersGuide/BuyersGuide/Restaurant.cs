using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyersGuide
{
    public class Restaurant : Cafe
    {
        public Restaurant()
        {
            this.typeShop = TypeShop.Restaurant;
        }
        public void Menu()
        {
            //Логіка рекомандацій страв з меню
        }
    }
}
