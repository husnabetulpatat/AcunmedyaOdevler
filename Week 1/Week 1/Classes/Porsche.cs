using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_1.CLasses;
using Week_1.Interfaces;

namespace Week_1.Classes
{
    public class Porsche : Car, IAracHareketleri
    {
        public void DenizdeYuz(string brand)
        {
            
        }

        public void HavadaUc(string brand)
        {
            Console.WriteLine(brand + " havada uçar.");
        }

        public void HizliGit(string brand)
        {
         
        }
    }
}
