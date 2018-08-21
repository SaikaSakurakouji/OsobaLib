using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osoba.Builder.Idols
{
    public class Idols
    {
        public string Name { get; private set; }
        public IdolCategory Category { get; private set; }
        public int HP { get; private set; }
        public int MP { get; private set; }
        public int SP { get; private set; }

        public void SetName(string name) { this.Name = name; }
        public void SetCategory(IdolCategory Category) { this.Category = Category; }
        public void SetHead(int code) { }
        public void SetTops(int cpde) { }
        public void SetBottoms(int code) { }
        public void SetShoes(int code) { }
        public void SetAccessory(int code) { }
        public void SetHp(int HP) { this.HP = HP; }
        public void SetMp(int MP) { this.MP = MP; }
        public void SetSp(int SP) { this.SP = SP; }
    }
}
