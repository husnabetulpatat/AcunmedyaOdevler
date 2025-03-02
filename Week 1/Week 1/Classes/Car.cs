using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Week_1.CLasses
{
    public class Car
    {
        public string brand;
        public string color;
        public string model;
        public string vites;
        public int year;
        public double km;
        public bool turbo;


        public void git(string color, string brand)
        {
            Console.WriteLine(color +" "+ brand + " " + "gidiyor!");
        }

        public void info(string brand, string model)
        {
            Console.WriteLine("Arabanın markası: " + brand + " " + "Arabanın modeli: " + model);
        }

        public void vitesTürü(string brand, string vites)
        {
            Console.WriteLine(brand + " " + vites + " " + "viteslidir.");
        }

    }
}
