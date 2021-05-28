using System;
using System.Collections.Generic;
using System.Text;

namespace Testy
{
    public class Dziennik
    {
        private string uczen;
        private int ocena;
        public Dziennik(string uczen, int ocena)
        {
            uczen = this.uczen;
            ocena = this.ocena;
        }

        public string Uczen
        {
            get { return uczen; }
        }
        public int Ocena
        {
            get { return ocena; }
        }
        public static string Sprawdzian(int punkty)
        {
            if (punkty < 50)
                return "nie zdales";
            if (punkty == 50)
                return "ekstra zadanie";
            if (punkty > 50)
                return "zdales";

            return punkty.ToString();
                
            
        }
        public static string OcenaWDzienniku(int punkty)
        {
         
            if (punkty < 50)
                return "niedostateczne";
            if (punkty >= 51 && punkty <= 65)
                return "dostateczny";
            if (punkty >= 66 && punkty <= 75)
                return "dobry";
            if (punkty >= 76 && punkty <= 85)
                return "bardzo dobry";
            if (punkty > 86)
                return "celujacy";
            return punkty.ToString();

        }

        public static int EkstraOcena(int x, int y)
        {
            Console.WriteLine("oblicz NWD");
            while (x != y)
            {
                if (x > y)
                    x = x - y;
                else
                    y = y - x;

            }

            return x;

        }
    }
}
