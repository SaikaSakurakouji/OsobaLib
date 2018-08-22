using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osoba.Builder.Idols
{
    public class CuteIdolBuilder : IdolsBuilder
    {
        public override void SetAccessory()
        {
        }

        public override void SetArmorClass()
        {
        }

        public override void SetBottoms()
        {
        }

        public override void SetCharisma()
        {
        }

        public override void SetDexterity()
        {
        }

        public override void SetHead()
        {
        }

        public override void SetHp()
        {
            this.Idol.SetMp(20);
        }

        public override void SetCategoly()
        {
            this.Idol.SetCategory(IdolCategory.Cute);
        }

        public override void SetIntelligence()
        {
        }

        public override void SetLevel()
        {
        }

        public override void SetMp()
        {
            this.Idol.SetMp(10);
        }

        public override void SetName()
        {
            this.Idol.SetName("Cute");
        }

        public override void SetShoes()
        {
        }

        public override void SetSp()
        {
            this.Idol.SetMp(30);
        }

        public override void SetStrength()
        {
        }

        public override void SetTops()
        {
        }

        public override void SetWisdom()
        {
        }
    }
}
