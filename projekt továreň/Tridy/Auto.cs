using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekttovarna.Tridy
{
    internal class Auto
    {
        public string Znacka = "Tesla";
        public int rokvyroby = DateTime.Now.Year;
        #region Vlastnosti
        public string model { get; set; }
        public int pocetsedadel { get; set; }
        public string druhpohonu { get; set; }
        public string Cena { get; set; }
        public string obrazek { get; set; }
        public znacka()
        {
            Console.WriteLine("Objekt Vytvořen");
        }
        
        
    }
}