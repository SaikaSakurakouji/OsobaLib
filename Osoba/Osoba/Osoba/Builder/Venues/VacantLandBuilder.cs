using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osoba.Builder.Venues
{
    public class VacantLandBuilder : VenuesBuilder
    {
        public override void SetCategoly()
        {
            this.Venue.SetCategory(VenuesCategory.VacantLand);
        }

        public override void SetName()
        {

        }
    }
}
