using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekttovarna
{
    internal class Auto
    {
        public string Znacka = "Tesla";
        public int rokvyroby = DateTime.Now.Year;
        #region Vlastnosti
        public string model { get; set; }
        public int pocetsedadel { get; set; }
        public string druhpohonu { get; set; }
        public int Cena { get; set; }
        public string obrazek { get; set; }
        #endregion Vlastnosti

        public void tesla()
        {
            Console.WriteLine("Objekt Vytvořen");
        }
        
        
    }
}