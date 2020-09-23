using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapar instans av Bil mha konstruktorn
           // Bil bil = new Bil();

            //Bil enAnnanBil = new Bil("Rosa", "AAA 111");

           Bil bil = new Bil("Svart", "AAA 111", 180);

            string färg = bil.GetFärg();
            Console.WriteLine(färg);

            bil.SetFärg("Röd");
            bil.Färg = "Röd";
            

            Console.WriteLine(bil.GetFärg());
            int hastighet = 200;

            if (hastighet > bil.GetMaxHastighet())
            {
                Console.WriteLine($"Högsta tillåtna hastighet är {bil.GetMaxHastighet()}!");
            }
            else
            {
                Console.WriteLine($"Jag jör just nu i {bil.Gasa(hastighet)}");
            }
            Console.ReadLine();
        }
    }

}
