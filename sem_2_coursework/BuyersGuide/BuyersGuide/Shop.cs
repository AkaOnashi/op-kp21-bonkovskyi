using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyersGuide
{
    public enum Ownership 
    {
        Solo,
        Partenrship,
        Corporation,
        State
    }

    public enum TypeShop
    {
        Grocery,
        Industrial,
        Pet,
        Book,
        Jewellery,
        Clothes,
        Toy,
        Cafe,
        Market,
        ShoppingCenter
    }
    public abstract class Shop
    {

        private string name;
        private string address;
        public TypeShop typeShop;
        public string ukrTypeShop;
        private string workingHours;
        private Ownership ownership;
 
        public string Name { get { return name; } set { name = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string WorkingHours { get { return workingHours; } set { workingHours = value; } }
        public Ownership Ownership { get { return ownership; } set { ownership = value; } }

        
        public Shop(TypeShop typeShop)
        {
            this.typeShop = typeShop;
        }
        public void AddShop(string name, string address, string workingHours)
        {
            Console.OutputEncoding = Encoding.Unicode;
            this.name = name;
            this.address = address;
            this.workingHours = workingHours;
        }
        public void AddShop(string name, string address, Ownership ownership, string workingHours)
        {
            Console.OutputEncoding = Encoding.Unicode;
            this.name = name;
            this.address = address;
            this.ownership = ownership;
            this.workingHours = workingHours;
        }

        public void PrintInfo()
        {
            Console.OutputEncoding = Encoding.Unicode;
            switch (typeShop)
            {
                case TypeShop.Grocery:
                    ukrTypeShop = "Продуктовий магазин";
                    break;
                case TypeShop.Industrial:
                    ukrTypeShop = "Промисловий магазин";
                    break;
                case TypeShop.Pet:
                    ukrTypeShop = "Зоо-магазин";
                    break;
                case TypeShop.Book:
                    ukrTypeShop = "Книгарня";
                    break;
                case TypeShop.Jewellery:
                    ukrTypeShop = "Біжутерія";
                    break;
                case TypeShop.Clothes:
                    ukrTypeShop = "Магазин одягу";
                    break;
                case TypeShop.Toy:
                    ukrTypeShop = "Іграшковий магазин";
                    break;
                case TypeShop.Cafe:
                    ukrTypeShop = "Кафе";
                    break;
                case TypeShop.Market:
                    ukrTypeShop = "Універсам";
                    break;
                case TypeShop.ShoppingCenter:
                    ukrTypeShop = "Торговий центр";
                    break;
            }
          
            
            Console.WriteLine("\"{0}\" -- {1} -- {2} -- {3}", this.Name, this.Address, this.ukrTypeShop, this.WorkingHours);
            //this.Ownership + 
        }
    }
}
