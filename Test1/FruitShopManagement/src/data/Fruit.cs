using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FruitShopManagement.src.enums;

namespace FruitShopManagement.src.data
{
    public class Fruit
    {
        // Fruit Id, Fruit Name, Price, Quantity and Origin
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public Country Origin { get; set; }

        private static int currentId = 0;

        public Fruit(string name, double price, int quantity, Country origin)
        {
            Id = ++currentId;
            Name = name;
            Price = price;
            Quantity = quantity;
            Origin = origin;
        }

        public Fruit(int id, string name, double price, int quantity, Country origin)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
            Origin = origin;
        }

        public void ShowInfor()
        {
            Console.WriteLine(string.Format("{0, -20}|{1, -8}|{2, -8}|{2, -8}", Name, Price, Quantity, Origin));
        }

        public void ShowInforWithId()
        {
            //Console.WriteLine(String.Format("{0, -5}|{1, -20}|{2, -10}|{3, -8}", "Item", "Fruit Name", "Origin ", "Price "));
            Console.WriteLine(string.Format("{0, -5}|{1, -20}|{2, -8}|{3, -8}", Id, Name, Origin, Price));
        }

        public void UpdateQuantity(int quantity)
        {
            this.Quantity -= quantity;
        }
    }
}
