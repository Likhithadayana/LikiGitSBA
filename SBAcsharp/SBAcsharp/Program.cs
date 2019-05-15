using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBAcsharp
{
    class Program
    {
        static void Main(string[] args)
        {


            Accenture a = new Accenture(101, "liki", "HR", "devloper", 22000);
            Console.WriteLine("Company:Accenture");
            Console.WriteLine("PF = {0}", a.PF(a.basicsal));
            Console.WriteLine("Leaves= {0}", a.Leave());
      
           Console.WriteLine("-------------------------------------------------------------------------------------------");

            Tcs t = new Tcs(201, "Anpu", "Finance", "Tester", 15000);
            Console.WriteLine("Company:TCS");
            Console.WriteLine("PF = {0}", t.PF(t.basicsal));
            Console.WriteLine(" Leaves = {0}", t.Leave());
            Console.WriteLine("Gratuity Amount {0}", t.gratuityAmt(15, t.basicsal));

            Console.ReadKey();
        }
    }
}
