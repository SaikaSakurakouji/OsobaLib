using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Osoba.Builder.Idols;
namespace Osoba.Term
{
    class Program
    {
        static void Main(string[] args)
        {
            IdolsDirector d1 = new IdolsDirector(new CoolIdolBuilder());
            IdolsDirector d2 = new IdolsDirector(new CuteIdolBuilder());
            Idols idol1 = d1.Construct();
            Idols idol2 = d2.Construct();


            Console.WriteLine(idol1.Name);
            Console.WriteLine(idol2.Name);

            Console.Read();
        }
    }
}
