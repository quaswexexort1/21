using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Полиморфизмы_методов_класса
{
    internal class televizor
    {
        public string Фирма {  get; set; }
        public double Диагональ { get; set; }
        public double МощностьЗвука { get; set; }
        public string СтранаПроизводитель { get; set; }


        public virtual double РассчитатьQ()
        {
            return Диагональ + (0.05 * МощностьЗвука);
        }

        public virtual double РассчитатьQp()
        {
            return РассчитатьQ(); // По умолчанию Qp равен Q
        }

        public override string? ToString()
        {
            return $"Фирма:{Фирма}, Диагональ:{Диагональ}, Мощность: {МощностьЗвука}, Страна: {СтранаПроизводитель}, Q: {РассчитатьQ()}, Qp: {РассчитатьQp()}";
            
        }
    }
}
