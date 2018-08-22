using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osoba.Builder.Venues
{
    public class Venues
    {
        /// <summary>
        /// 名前
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// カテゴリ
        /// </summary>
        public VenuesCategory Category { get; private set; } = VenuesCategory.VacantLand;

        public void SetName(string Name) { this.Name = Name; }
        public void SetCategory(VenuesCategory Category) { this.Category = Category; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            string format = @"{0}:{1}";
            sb.AppendFormat(format, nameof(Name), Name).AppendLine();
            sb.AppendFormat(format, nameof(Category), Category).AppendLine();
            return sb.ToString();
        }
    }
}
