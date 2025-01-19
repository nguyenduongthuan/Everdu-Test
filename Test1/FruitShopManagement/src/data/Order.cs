using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using FruitShopManagement.src.enums;

namespace FruitShopManagement.src.data
{
    public class Order
    {
        public List<Fruit> fruits = new List<Fruit>();
        public string CustomerName { get; set; }

        public Order(string CustomerName)
        {
            this.CustomerName = CustomerName;
        }
        public Order() { }

        public void ShowItemOfOrder(Fruit fruit)
        {
            Console.WriteLine(string.Format("{0, -20}|{1, -8}|{2, -8}|{3, -8}", fruit.Name, fruit.Quantity, fruit.Price, (fruit.Price * fruit.Quantity)));
        }

        public void AddFruit(int id, string name, double price, int quantity, Country origin)
        {
            fruits.Add(new Fruit(id, name, price, quantity, origin));
        }

        public void AddFruit(Fruit fruit)
        {
            fruits.Add(fruit);
        }

        public double GetTotal()
        {
            double total = 0;
            foreach (Fruit fruit in fruits)
            {
                total += fruit.Price * fruit.Quantity;
            }
            return total;
        }

        public void DisplayOrder(List<Fruit> fruits)
        {
            Console.WriteLine(string.Format("{0, -20}|{1, -8}|{2, -8}|{3, -8}", "Product", "Quantity", "Price ", "Amount"));
            Console.WriteLine("--------------------|--------|--------|--------");
            foreach (Fruit fruit in fruits)
            {
                ShowItemOfOrder(fruit);
            }
        }
    }
}
