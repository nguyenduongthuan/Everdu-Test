using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FruitShopManagement.src.utils;

namespace FruitShopManagement.src.ui
{
    public class Menu
    {
        //mảng lưu các lựa chọn
        public ArrayList optionList = new ArrayList();

        public string title { get; set; }

        public Menu(string title)
        {
            this.title = title;
        }

        //hàm thêm 1 option cho danh sách
        public void AddNewOption(string newOption)
        {
            optionList.Add(newOption);
        }


        //hiển thị menu
        public void Print()
        {
            int count = 1;
            Console.WriteLine("\n" + title);
            foreach (var op in optionList)
            {
                Console.WriteLine("       " + count++ + ". " + op);
            }
        }

        //hàm thu thập lựa chọn của người dùng
        public int GetChoice()
        {
            int choice = Inputter.GetAnInteger("Please choose 1 to create product, 2 to view order, 3 for shopping, 4 to Exit program: ",
                "Your choice must been 1 and " + optionList.Count, 1, optionList.Count);
            return choice;
        }
    }
}
