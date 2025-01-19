using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShopManagement.src.utils
{
    public class Inputter
    {
        //mehthod giúp ng dùng nhập chuẩn số nguyên -> nhập sai chửi
        public static int GetAnInteger(string inpMsg, string errMsg)
        {
            //hiển thị câu mời nhập
            Console.WriteLine(inpMsg);
            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    return number;
                }
                catch (Exception)
                {
                    Console.WriteLine(errMsg);
                }
            }
        }

        //method giúp người dùng nhập chuỗi nhưng ko đc để trống
        public static string GetString(string inpMsg, string errMsg)
        {
            //hiển thị câu mời nhập
            Console.WriteLine(inpMsg);
            while (true)
            {
                try
                {
                    string str = Console.ReadLine();
                    if (str.Equals(""))
                    {
                        throw new Exception(errMsg);
                    }
                    return str;
                }
                catch (Exception)
                {
                    Console.WriteLine(errMsg);
                }
            }
        }

        //method ép bắt nhập số nguyên chuẩn nhưng phải ở trong khoảng
        public static int GetAnInteger(string inpMsg, string errMsg, int lowerBound, int upperBound)
        {
            if (lowerBound > upperBound)
            {//đổi chỗ nếu có người dùng khờ
                int tmp = lowerBound;
                lowerBound = upperBound;
                upperBound = tmp;
            }
            Console.WriteLine(inpMsg);//hiển thị câu mời nhập
            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    if (number < lowerBound || number > upperBound)
                    {
                        throw new Exception();
                    }
                    return number;
                }
                catch (Exception e)
                {
                    Console.WriteLine(errMsg);
                }
            }
        }
        //method ép người dùng nhập lựa chọn 
        public static string GetBooleanString(string inpMsg, string errMsg, string y, string n)
        {
            //hiển thị câu mời nhập
            Console.WriteLine(inpMsg);
            while (true)
            {
                try
                {
                    string str = Console.ReadLine();
                    if (!(str.ToUpper().Equals(y) || str.ToUpper().Equals(n)))
                    {
                        throw new Exception(errMsg);
                    }
                    return str.ToUpper();
                }
                catch (Exception)
                {
                    Console.WriteLine(errMsg);
                }
            }
        }


        //mehthod giúp ng dùng nhập chuẩn số thực double -> nhập sai chửi
        public static double GetAnDouble(string inpMsg, string errMsg)
        {
            //hiển thị câu mời nhập
            Console.WriteLine(inpMsg);
            while (true)
            {
                try
                {
                    double number = Convert.ToDouble(Console.ReadLine());
                    return number;
                }
                catch (Exception)
                {
                    Console.WriteLine(errMsg);
                }
            }
        }

    }

}