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
        
        public void AddShop(string name, string address, Ownership ownership, string workingHours)
        {
            this.name = name;
            this.address = address;
            this.ownership = ownership;
            this.workingHours = workingHours;
        }

        public void PrintInfo()
        {
            Console.WriteLine(this.Name + this.Address + this.Ownership + this.typeShop + this.WorkingHours);
        }
    }
}
