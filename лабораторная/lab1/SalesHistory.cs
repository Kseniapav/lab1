using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ЛР2;


namespace lab1
{
    internal class SalesHistory
    {
        Dictionary<Cosmetics, List<RecordOfSale>> SalesDictionary = new Dictionary<Cosmetics, List<RecordOfSale>>();

        public void ДобавитьПродажу(Cosmetics категория, RecordOfSale запись)
        {
            if (!SalesDictionary.ContainsKey(категория))
                SalesDictionary[категория] = new List<RecordOfSale>();

            SalesDictionary[категория].Add(запись);
        }

        public List<RecordOfSale> ПолучитьПродажи(Cosmetics категория) =>
            SalesDictionary.ContainsKey(категория) ? SalesDictionary[категория] : new List<RecordOfSale>();

        public double ПолучитьСуммуПоКатегории(Cosmetics тип) =>
            ПолучитьПродажи(тип).Sum(продажа => продажа.ПолучитьСумму());
    }
}
