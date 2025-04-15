using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ЛР2;

namespace lab1
{
    internal class ProductDescription
    {
        public string Name { get; set; }
        public double Price { get; set; }
       

        public ProductDescription(string Название, double Цена)
        {
            Name = Название;
            Price = Цена;
            
        }
        public override string ToString() 
        {
            return $"Название: {Name}, Цена: {Price:F2}";
        }

        public string ПолучитьНазвание() => Name;
        public double ПолучитьЦену() => Price;

    }
}
