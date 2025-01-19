using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FruitShopManagement.src.enums;
using FruitShopManagement.src.utils;

namespace FruitShopManagement.src.ui
{
    public class ChooseCountry
    {
        //method giúp admin chọn country
        public static Country GetCountry()
        {
            var countries = Enum.GetValues(typeof(Country)).Cast<Country>().ToList();

            Console.WriteLine("List of countries: ");
            foreach (Country country in countries)
            {
                Console.WriteLine($"{(int)country}. {country}");
            }

            int number = Inputter.GetAnInteger("Please choose your country: ", "Please input an integer and in range 1 -> 5!", 1, countries.Count);
            return (Country)number;
        }
    }
}
