using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Описание_Товара
    {
        private string Name;
        private double Prise;

        //конструктор
        public Описание_Товара(string Название,double Цена)
        {
            Название = Name;
            Цена = Prise;
        }
        public string Скажи_Название()
        {
            return Name;
        }
        public double Скажи_стоимость()
        {
            return Prise;
        }



    }
}
