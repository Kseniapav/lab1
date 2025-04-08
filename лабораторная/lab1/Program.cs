
using System;
using System.Collections.Generic;
using ЛР2;


namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Инициализация истории продаж
            var историяПродаж = new SalesHistory();

            // Создание описаний товаров
            var товары = new Dictionary<Cosmetics, ProductDescription>
            {
               { Cosmetics.Тональные_крема, new ProductDescription("Тональный крем L'Oreal True Match", 25.99) },
               { Cosmetics.Тональные_крема, new ProductDescription("Тональный крем Maybelline Fit Me", 18.50) },
               { Cosmetics.Помады, new ProductDescription("Помада Maybelline SuperStay", 15.50) },
               { Cosmetics.Помады, new ProductDescription("Помада NYX Soft Matte", 9.99) },
               { Cosmetics.Румяна, new ProductDescription("Румяна MAC Powder Blush", 22.00) },
               { Cosmetics.Румяна, new ProductDescription("Румяна Bourjois Little Round Pot", 12.50) },
               { Cosmetics.Хайлайтеры, new ProductDescription("Хайлайтер Fenty Beauty Killawatt", 32.00) },
               { Cosmetics.Хайлайтеры, new ProductDescription("Хайлайтер Revolution Reloaded", 8.99) },
               { Cosmetics.Скульпторы, new ProductDescription("Скульптор для лица NYX Highlight & Contour", 16.75) },
               { Cosmetics.Скульпторы, new ProductDescription("Скульптор KVD Beauty Shade + Light", 28.00) },
               { Cosmetics.Тушь, new ProductDescription("Тушь для ресниц Rimmel Extra Super Lash", 12.75) },
               { Cosmetics.Тушь, new ProductDescription("Тушь Maybelline Lash Sensational", 10.99) }


            };
        }

          

    }
}
