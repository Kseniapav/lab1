using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab1.История_Продаж;

namespace lab1
{
    internal class Список_записей_продаж
    {
        Dictionary<Косметика, List<Запись_о_продаже>> Список_Продаж = new Dictionary<Косметика, List<Запись_о_продаже>>();
    }
}
