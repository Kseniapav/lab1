using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal struct RecordOfSale
    {
        private int Количество;
        private int День;
        private ProductDescription Товар;

        internal RecordOfSale(int количество, int день, ProductDescription товар)
        {
            if (количество <= 0) throw new ArgumentException("Количество должно быть положительным");
            if (день < 1 || день > 31) throw new ArgumentException("День должен быть от 1 до 31");

            this.Количество = количество;
            this.День = день;
            this.Товар = товар ?? throw new ArgumentNullException(nameof(товар));
        }

        public int ПолучитьКоличество() => Количество;
        public int ПолучитьДень() => День;
        public ProductDescription ПолучитьТовар() => Товар;
        public double ПолучитьСумму() => Количество * Товар.ПолучитьЦену();
    }

    
        



}
