using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkAcademy_DesafioFinal.nsDomain
{
    public class Store
    {
        public string Name { get; private set; }
        public string Address { get; private set; }

        public Dictionary<string, Wear> Inventory = new Dictionary<string, Wear>();

        public Store(string Name, string Address)
        {
            this.Name = Name;
            this.Address = Address;
        }

        public void GenerateInventory()
        {
            Inventory.Add("shirt_False_False_False", new Shirt(false, false, false, 175));
            Inventory.Add("shirt_False_False_True", new Shirt(false, false, true, 175));
            Inventory.Add("shirt_False_True_False", new Shirt(false, true, false, 75));
            Inventory.Add("shirt_False_True_True", new Shirt(false, true, true, 75));
            Inventory.Add("shirt_True_False_False", new Shirt(true, false, false, 150));
            Inventory.Add("shirt_True_False_True", new Shirt(true, false, true, 150));
            Inventory.Add("shirt_True_True_False", new Shirt(true, true, false, 100));
            Inventory.Add("shirt_True_True_True", new Shirt(true, true, true, 100));

            Inventory.Add("trouser_False_False", new Trouser(false, false, 250));
            Inventory.Add("trouser_False_True", new Trouser(false, true, 250));
            Inventory.Add("trouser_True_False", new Trouser(true, false, 750));
            Inventory.Add("trouser_True_True", new Trouser(true, true, 750));
        }

        public int GetQuantity(string wear_type)
        {
            return Inventory[wear_type].Quantity;
        }
    }
}
