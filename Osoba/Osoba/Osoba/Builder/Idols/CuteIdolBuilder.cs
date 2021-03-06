﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osoba.Core.Builder.Idols
{
    public class CuteIdolBuilder : IdolsBuilder
    {
        public Idols Idol { get; private set; } = new Idols();
        public Idols GetIdol()
        {
            return Idol;
        }

        public void SetAccessory()
        {
        }

        public void SetBottoms()
        {
        }

        public void SetHead()
        {
        }

        public void SetHp()
        {
            this.Idol.SetMp(20);
        }

        public void SetIdolCategoly()
        {
            this.Idol.SetCategory(IdolCategory.Cute);
        }

        public void SetMp()
        {
            this.Idol.SetMp(10);
        }

        public void SetName()
        {
            this.Idol.SetName("Cute");
        }

        public void SetShoes()
        {
        }

        public void SetSp()
        {
            this.Idol.SetMp(30);
        }

        public void SetTops()
        {
        }
    }
}
