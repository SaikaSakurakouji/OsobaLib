using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osoba.Builder.Idols
{
    public class Idols
    {
        /// <summary>
        /// 名前
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// カテゴリ
        /// </summary>
        public IdolCategory Category { get; private set; } = IdolCategory.None;
        /// <summary>
        /// レベル
        /// </summary>
        public int Level { get; private set; }
        /// <summary>
        /// 体力
        /// </summary>
        public int HP { get; private set; }
        /// <summary>
        /// 魔力
        /// </summary>
        public int MP { get; private set; }
        /// <summary>
        /// 精神力
        /// </summary>
        public int SP { get; private set; }
        /// <summary>
        /// STR(力)(ストレングス)
        /// </summary>
        public int Strength { get; private set; }
        /// <summary>
        /// INT(知性)(インテリジェンス)
        /// </summary>
        public int Intelligence { get; private set; }
        /// <summary>
        /// WIS(知恵)(ウィズダム)
        /// </summary>
        public int Wisdom { get; private set; }
        /// <summary>
        /// DEX(器用さ)(デクスタリティ)
        /// </summary>
        public int Dexterity { get; private set; }
        /// <summary>
        /// CHA(魅力)(カリスマ)
        /// </summary>
        public int Charisma { get; private set; }
        /// <summary>
        /// AC(回避力)(アーマークラス)
        /// </summary>
        public int ArmorClass { get; private set; }

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

        public void SetLevel(int Level) { this.Level = Level; }
        public void SetStrength(int Strength) { this.Strength = Strength; }
        public void SetIntelligence(int Intelligence) { this.Intelligence = Intelligence; }
        public void SetWisdom(int Wisdom) { this.Wisdom = Wisdom; }
        public void SetDexterity(int Dexterity) { this.Dexterity = Dexterity; }
        public void SetCharisma(int Charisma) { this.Charisma = Charisma; }
        public void SetArmorClass(int ArmorClass) { this.ArmorClass = ArmorClass; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            string format = @"{0}:{1}";
            sb.AppendFormat(format, nameof(Name), Name).AppendLine();
            sb.AppendFormat(format, nameof(Category), Category).AppendLine();
            sb.AppendFormat(format, nameof(Level), Level).AppendLine();
            sb.AppendFormat(format, nameof(HP), HP).AppendLine();
            sb.AppendFormat(format, nameof(MP), MP).AppendLine();
            sb.AppendFormat(format, nameof(SP), SP).AppendLine();
            sb.AppendFormat(format, nameof(Strength), Strength).AppendLine();
            sb.AppendFormat(format, nameof(Intelligence), Intelligence).AppendLine();
            sb.AppendFormat(format, nameof(Wisdom), Wisdom).AppendLine();
            sb.AppendFormat(format, nameof(Dexterity), Dexterity).AppendLine();
            sb.AppendFormat(format, nameof(Charisma), Charisma).AppendLine();
            sb.AppendFormat(format, nameof(ArmorClass), ArmorClass).AppendLine();

            return sb.ToString();
        }
    }
}
