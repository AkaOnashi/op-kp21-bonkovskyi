using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyersGuide
{

    public class GroceryShop : Shop
    {
        public GroceryShop() : base(TypeShop.Grocery)
        {

        }
    }
    public class IndusrialShop : Shop
    {
        public IndusrialShop() : base(TypeShop.Industrial)
        {

        }
    }
    public class PetShop : Shop
    {
        public PetShop() : base(TypeShop.Pet)
        {

        }
    }
    public class BookShop : Shop
    {
        public BookShop() : base(TypeShop.Book)
        {

        }
    }
    public class JewelleryShop : Shop
    {
        public JewelleryShop() : base(TypeShop.Jewellery)
        {

        }
    }
    public class ClothesShop : Shop
    {
        public ClothesShop() : base(TypeShop.Clothes)
        {

        }
    }
    public class ToyShop : Shop
    {
        public ToyShop() : base(TypeShop.Toy)
        {

        }
    }
    public class Cafe : Shop
    {
        public Cafe() : base(TypeShop.Cafe)
        {

        }
    }
    public class Market : Shop
    {
        public Market() : base(TypeShop.Market)
        {

        }
    }
    public class ShoppingCenter : Shop
    {
        public ShoppingCenter() : base(TypeShop.ShoppingCenter)
        {

        }
    }
}
