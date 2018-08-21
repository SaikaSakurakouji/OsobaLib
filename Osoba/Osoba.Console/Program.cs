using Osoba.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Osoba.Core.Builder.Idols;
namespace Osoba.Console
{
    class Program
    {
        // Client
        // ・Builderを利用する
        static void Main(string[] args)
        {
            IdolsDirector Director1 = new IdolsDirector(new CoolIdolBuilder());
            IdolsDirector Director2 = new IdolsDirector(new CuteIdolBuilder());

            Idols idol1 = Director1.Construct();
            Idols idol2 = Director2.Construct();

            System.Console.WriteLine(idol1.Name);
            System.Console.WriteLine(idol2.Name);

            System.Console.ReadLine();
        }
    }
}
