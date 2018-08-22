using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osoba.Builder.Venues
{
    public class VenuesDirector
    {
        private VenuesBuilder builder;
        public VenuesDirector(VenuesBuilder builder)
        {
            this.builder = builder;
        }
        public Venues Construct()
        {
            this.builder.SetName();
            this.builder.SetCategoly();

            return this.builder.GetIdol();
        }
    }
}
