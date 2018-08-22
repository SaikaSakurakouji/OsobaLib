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
            IdolsDirector Director;
            Director = new IdolsDirector(new CoolIdolBuilder());
            Idols idol1 = Director.Construct();

            Director = new IdolsDirector(new CuteIdolBuilder());
            Idols idol2 = Director.Construct();

            Director = new IdolsDirector(new CoolIdolBuilder());
            Idols idol3 = Director.Construct();


            Console.WriteLine(idol1.ToString());
            Console.WriteLine(idol2.ToString());
            Console.WriteLine(idol3.ToString());

            Console.Read();
        }
    }
}
