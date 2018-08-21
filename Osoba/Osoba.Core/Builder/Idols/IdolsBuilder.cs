using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osoba.Core.Builder.Idols
{
    public interface IdolsBuilder
    {
        void SetName();
        void SetIdolCategoly();
        void SetHead();
        void SetTops();
        void SetBottoms();
        void SetShoes();
        void SetAccessory();
        void SetHp();
        void SetMp();
        void SetSp();
        Idols GetIdol();
    }
}
