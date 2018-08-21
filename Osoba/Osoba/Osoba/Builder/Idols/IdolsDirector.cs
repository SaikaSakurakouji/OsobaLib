using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osoba.Builder.Idols
{
    public class IdolsDirector
    {
        private IdolsBuilder builder;
        public IdolsDirector(IdolsBuilder builder)
        {
            this.builder = builder;
        }
        public Idols Construct()
        {
            this.builder.SetName();
            this.builder.SetIdolCategoly();
            this.builder.SetHead();
            this.builder.SetTops();
            this.builder.SetBottoms();
            this.builder.SetShoes();
            this.builder.SetAccessory();
            this.builder.SetHp();
            this.builder.SetMp();
            this.builder.SetSp();
            return this.builder.GetIdol();
        }
    }
}
