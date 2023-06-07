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
        public void RestockInventory()
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
        public bool grooming = false;
        public PetShop() : base(TypeShop.Pet)
        {

        }

        public string PetGroomingServices()
        {
            if (grooming)
            {
                return "Наявні послуги догляду за тваринами";
            }
            else
            {
                return "Не наявні послуги догляду за тваринами";
            }
        }
    }
    public class BookShop : Shop
    {
        public BookShop() : base(TypeShop.Book)
        {

        }
        public void RecommendBooks()
        {
            // Логіка рекомендацій покупцям книжкового магазину
        }
    }
    public class JewelleryShop : Shop
    {
        public JewelleryShop() : base(TypeShop.Jewellery)
        {

        }
        public decimal CalculateDiscount(decimal price)
        {
            // Логіка розрахунку знижки на прикраси
            decimal discount = 0.1m * price; // Наприклад, 10% знижка
            return price - discount;
        }
    }
    public class ClothesShop : Shop
    {
        public ClothesShop() : base(TypeShop.Clothes)
        {

        }
        public string GetLatestCollection()
        {
            // Логіка отримання інформації про останню колекцію одягу
            return "Осінь-зима 2023";
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
        public string[] prodList;
        public Market() : base(TypeShop.Market)
        {

        }
        public void ProdList()
        {
            Console.WriteLine("{0} - цей універсам має такі типи товарів:");
            foreach(string prod in prodList)
            {
                Console.WriteLine(prod);
            }
        }
        public void AddShop(string name, string address, Ownership ownership, string workingHours, string[] prodList)
        {
            Console.OutputEncoding = Encoding.Unicode;
            this.prodList = prodList;
            this.name = name;
            this.address = address;
            this.ownership = ownership;
            this.workingHours = workingHours;
        }
    }
    public class ShoppingCenter : Shop
    {
        public List<Shop> Shops { get; set; }

        public ShoppingCenter() : base(TypeShop.ShoppingCenter)
        {
            Shops = new List<Shop>();
        }

        public void AddShop(Shop shop)
        {
            Shops.Add(shop);
        }

        public void RemoveShop(Shop shop)
        {
            Shops.Remove(shop);
        }
    }
}
