using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osoba.Builder.Idols
{
    public abstract class IdolsBuilder
    {
#if WLIB
        //aaaaaa
#endif
        protected Idols Idol { get; private set; } = new Idols();
        abstract public void SetName();
        abstract public void SetCategoly();
        abstract public void SetHead();
        abstract public void SetTops();
        abstract public void SetBottoms();
        abstract public void SetShoes();
        abstract public void SetAccessory();
        abstract public void SetHp();
        abstract public void SetMp();
        abstract public void SetSp();

        abstract public void SetLevel();
        abstract public void SetStrength();
        abstract public void SetIntelligence();
        abstract public void SetWisdom();
        abstract public void SetDexterity();
        abstract public void SetCharisma();
        abstract public void SetArmorClass();

        public Idols GetIdol() { return Idol; }
    }
}
