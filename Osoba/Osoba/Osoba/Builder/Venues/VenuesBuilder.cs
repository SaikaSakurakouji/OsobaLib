using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osoba.Builder.Venues
{
    public abstract class VenuesBuilder
    {
        protected Venues Venue { get; private set; } = new Venues();
        abstract public void SetName();
        abstract public void SetCategoly();

        public Venues GetIdol() { return Venue; }
    }
}
