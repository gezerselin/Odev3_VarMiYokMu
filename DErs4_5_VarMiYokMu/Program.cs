using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DErs4_5_VarMiYokMu
{
    class Program
    {
        static void Main(string[] args)
        {
            int indis = 0;
            string[] sehirler = { "Eskisehir", "Istanbul", "Ankara", "Izmir", "Diyarbakir", "Sinop" };
            Console.WriteLine("sehir girin");
            string girilenSehir = Console.ReadLine();
            bool varMi = false;
            foreach (string item in sehirler)
            {
   
                if (girilenSehir == item)
                {
                    
                    varMi = true;
                    break;
                }
                indis++;
            }
            
            if (varMi)
            {
                Console.WriteLine($"aradiginiz sehiri bulduk :)  indisi: {indis}");

            }
            else
            {
                Console.WriteLine("aradığınız şehri bulamadık:(");
            }
            Console.ReadLine();

        }
    }
}
