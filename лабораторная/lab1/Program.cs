
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


            var q = new ProductDescription("Тональный крем L'Oreal True Match", 400);
            var w = new ProductDescription("Тональный крем Maybelline Fit Me", 300);
            var e = new ProductDescription("Помада Maybelline SuperStay", 540);
            var r = new ProductDescription("Помада NYX Soft Matte", 1200); 
            var t = new ProductDescription("Румяна MAC Powder Blush", 230) ;
            var y = new ProductDescription("Румяна Bourjois Little Round Pot", 670);
            var u = new ProductDescription("Хайлайтер Fenty Beauty Killawatt", 1099);
            var i = new ProductDescription("Хайлайтер Revolution Reloaded", 890);
            var o = new ProductDescription("Скульптор для лица NYX Highlight & Contour", 700);
            var p = new ProductDescription("Скульптор KVD Beauty Shade + Light", 500);
            var a = new ProductDescription("Тушь для ресниц Rimmel Extra Super Lash", 670);
            var s = new ProductDescription("Тушь Maybelline Lash Sensational", 999);





            var record = new SalesHistory();

            // Добавляем продажи
            record.ДобавитьПродажу(Cosmetics.Тональные_крема, new RecordOfSale(4, 12, q));
            record.ДобавитьПродажу(Cosmetics.Помады, new RecordOfSale(1, 16, r));
            record.ДобавитьПродажу(Cosmetics.Тушь, new RecordOfSale(5, 17, a));
            record.ДобавитьПродажу(Cosmetics.Хайлайтеры, new RecordOfSale(1, 18, i));
            record.ДобавитьПродажу(Cosmetics.Помады, new RecordOfSale(1, 18, e));

            Console.WriteLine("____ОТЧЕТ О ПРОДАЖАХ____");
            foreach (Cosmetics категория in Enum.GetValues(typeof(Cosmetics)))
            {
                var продажи = record.ПолучитьПродажи(категория);
                if (продажи.Count > 0)
                {
                    Console.WriteLine($"\nКатегория: {категория}");
                    foreach (var продажа in продажи)
                    {
                        Console.WriteLine($"- {продажа.ПолучитьТовар().ПолучитьНазвание()}, " +
                                        $"{продажа.ПолучитьКоличество()} шт., " +
                                        $"день {продажа.ПолучитьДень()}, " +
                                        $"сумма: {продажа.ПолучитьСумму():N2} руб.");
                    }
                    Console.WriteLine($"Итого по категории: {record.ПолучитьСуммуПоКатегории(категория):N2} руб.");
                }
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

          

    }
}
