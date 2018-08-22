using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Osoba.Builder.Idols;
using Osoba.Builder.Venues;
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

            VenuesDirector vDirector;

            vDirector = new VenuesDirector(new VacantLandBuilder());
            Venues venue1 = vDirector.Construct();

            vDirector = new VenuesDirector(new StreetBuilder());
            Venues venue2 = vDirector.Construct();

            vDirector = new VenuesDirector(new LiveHouseBuilder());
            Venues venue3 = vDirector.Construct();

            vDirector = new VenuesDirector(new ConcertHallBuilder());
            Venues venue4 = vDirector.Construct();

            Console.WriteLine(venue1.ToString());
            Console.WriteLine(venue2.ToString());
            Console.WriteLine(venue3.ToString());
            Console.WriteLine(venue4.ToString());

            Console.Read();
        }
    }
}
