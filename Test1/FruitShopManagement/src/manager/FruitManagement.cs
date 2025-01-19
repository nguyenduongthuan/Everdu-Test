using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FruitShopManagement.src.data;
using FruitShopManagement.src.enums;
using FruitShopManagement.src.ui;
using FruitShopManagement.src.utils;

namespace FruitShopManagement.src.manager
{
    public class FruitManagement
    {
        List<Fruit> fruitList = new List<Fruit>();
        List<Order> orderList = new List<Order>();
        public void initData()
        {
            fruitList.Add(new Fruit("Apple", 2, 10, Country.UK));
            fruitList.Add(new Fruit("Mango", 3, 20, Country.Vietnam));
            fruitList.Add(new Fruit("Orange", 4, 10, Country.Thailand));
            fruitList.Add(new Fruit("Grape", 5, 10, Country.France));
        }

        public void AddNewFruits(string msg)
        {
            string name = Inputter.GetString("Please input your fruit name: ", "That filed is required!");
            double price = Inputter.GetAnDouble("Please input your price: ", "Please input an double number!");
            int quantity = Inputter.GetAnInteger("Please input your quantity: ", "Please input an integer number!");
            Country country = ChooseCountry.GetCountry();
            Fruit nFruit = new Fruit(name, price, quantity, country);
            fruitList.Add(nFruit);
            Console.WriteLine(msg);
        }

        public void DisplayAllFruits()
        {
            if (fruitList.Count == 0)
            {
                Console.WriteLine("Don't have fruit to show!");
            }
            else
            {
                Console.WriteLine(string.Format("{0, -5}|{1, -20}|{2, -8}|{3, -8}", "Item", "Fruit Name", "Origin ", "Price "));
                Console.WriteLine("-----|--------------------|--------|--------");
                fruitList.Sort(new IdComparer());
                foreach (Fruit fruit in fruitList)
                {
                    fruit.ShowInforWithId();
                }
            }
        }


        //method giúp user shopping

        public Order Shopping()
        {
            Order order = new Order();
            string isContinue = "";
            while (true)
            {
                DisplayAllFruits();
                int choice = Inputter.GetAnInteger("Please input number of item you want to buy: ", "Your choice must been 1 and " + fruitList.Count, 1, fruitList.Count);
                Fruit selectedFruit = fruitList[choice - 1];
                Console.WriteLine("You selected: " + selectedFruit.Name);
                if (selectedFruit.Quantity == 0)
                {
                    Console.WriteLine("Out of stock!");
                    return null;
                }
                int quantity = Inputter.GetAnInteger("Please input quantity: ",
                    "Please input quantity beetween 1 and " + selectedFruit.Quantity + " because we only have " + selectedFruit.Quantity + " fruits of this type left.",
                    1, selectedFruit.Quantity);
                Fruit nFruit = new Fruit(selectedFruit.Id, selectedFruit.Name, selectedFruit.Price, quantity, selectedFruit.Origin);
                //cập nhật số lượng trái cây
                fruitList[choice - 1].UpdateQuantity(quantity);
                order.AddFruit(nFruit);
                isContinue = Inputter.GetBooleanString("Do you want to order now (Y/N)?", "Please choose Y/N!", "Y", "N");
                if(isContinue == "Y")
                {
                    order.DisplayOrder(order.fruits);
                    Console.WriteLine("Total: " + order.GetTotal() + "$");
                    string name = Inputter.GetString("Input your name: ", "Please input a string!");
                    order.CustomerName = name;
                    orderList.Add(order);
                    return order;
                }

            }

        }

        //method view order

        public void ViewOrders()
        {
            if (orderList.Count == 0)
            {
                Console.WriteLine("Don't have order to show!");
            }
            foreach (Order order in orderList)
            {
                Console.WriteLine("Customer: " + order.CustomerName);
                order.DisplayOrder(order.fruits);
                Console.WriteLine("Total: " + order.GetTotal() + "$");
                Console.WriteLine();
            }
        }
    }
}
