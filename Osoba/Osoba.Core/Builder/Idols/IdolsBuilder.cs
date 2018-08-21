using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osoba.Core.Builder.Idols
{
    //public abstract class IdolsBuilder
    //{
    //    public abstract void SetName();
    //    public abstract void SetHead();
    //    public abstract void SetTops();
    //    public abstract void SetBottoms();
    //    public abstract void SetShoes();
    //    public abstract void SetAccessory();
    //    public abstract void SetHp();
    //    public abstract void SetMp();
    //    public abstract void SetSp();
    //    public abstract Idols GetIdol();
    //}
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
