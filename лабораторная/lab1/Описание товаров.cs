using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Описание_Товара
    {
        public string Name { get; set; }
        public double Price { get; set; }

        //конструктор
        public Описание_Товара(string Название,double Цена)
        {
            Название = Name;
            Цена = Price;
        }
        public override string ToString() // Переопределяем метод ToString() для более удобного вывода информации об объекте
        {
            return $"Название: {Name}, Цена: {Price:F2}"; // :F2 - форматирование, чтобы показать 2 знака после запятой
        }



    }
}
