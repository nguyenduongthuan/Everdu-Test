using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using FruitShopManagement.src.ui;
using FruitShopManagement.src.utils;
using FruitShopManagement.src.manager;
public class Program
{
    public static void Main()
    {
        FruitManagement fm = new FruitManagement();
        Menu menu = new Menu("FRUIT SHOP SYSTEM");
        menu.AddNewOption("Create Fruit");
        menu.AddNewOption("View orders");
        menu.AddNewOption("Shopping (for buyer)");
        menu.AddNewOption("Exit");
        int choice;
        fm.initData();
        while (true)
        {
            menu.Print();
            choice = menu.GetChoice();
            switch (choice)
            {
                case 1:
                    {
                        do
                        {
                            fm.AddNewFruits("Adding successfull");
                            String isContinue = Inputter.GetBooleanString("Do you want to continue (Y/N)?", "Please choose Y/N!", "Y", "N");
                            if (isContinue == "N") break;
                        } while (true);
                        break;
                    }
                case 2:
                    {
                        fm.ViewOrders();
                        break;
                    }
                case 3:
                    {
                        fm.Shopping();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("See you later");
                        return;
                    }

            }
        }
    }
}
