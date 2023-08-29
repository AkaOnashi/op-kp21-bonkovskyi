using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyersGuide
{
    public class Supermarket : Market
    {
        public Supermarket()
        {
            this.typeShop = TypeShop.Supermarket;
        }

        public void Inventarisation()
        {
            //Логіка інвентаризації супермаркета
        }
    }
}
