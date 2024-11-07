using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yp_3
{
    public class SpecialProduct : Product
    {
        // Дополнительное поле P
        private double popularity;

        // Три новых свойства
        public string Category { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool IsAvailable { get; set; }

        public SpecialProduct(string name, double price,int count, string art, string color, double popularity, string category)
            : base(name, price,count,art,color)
        {
            this.popularity = popularity;
            Category = category;
            ExpiryDate = DateTime.Now.AddMonths(6);
            IsAvailable = true;
        }

        // Переопределенная функция качества
        public override double CalculateQuality()
        {
            int curyear = DateTime.Now.Year;
            int razr = ExpiryDate.Year;
            return base.CalculateQuality() + 0.5*(curyear-razr);
        }

        // Собственная функция(скидка)
        public double CalculateDiscount()
        {
            return price * (popularity / 100);
        }

        // Переопределенный вывод информации
        public override string DisplayInfo()
        {
            base.DisplayInfo();
            return $"Popularity: {popularity} Category: {Category} Expiry Date: {ExpiryDate:d}  Available:{IsAvailable} Discount:{CalculateDiscount():C}";
        }
    }
}
