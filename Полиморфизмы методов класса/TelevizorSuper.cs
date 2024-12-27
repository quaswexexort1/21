using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Полиморфизмы_методов_класса
{
    internal class TelevizorSuper:televizor
    {
        public class ЯпонскийТелевизор : televizor
        {
            public override double РассчитатьQp()
            {
                return 2 * РассчитатьQp(); // Qp равен 2 * Q для японских телевизоров
            }
        }

        public class АзиатскийТелевизор:televizor
        {
            public override double РассчитатьQp()
            {
                return 1.5 * РассчитатьQp(); // Qp равен 1.5 * Q для азиатских телевизоров
            }
        }

        public class ОбычныйТелевизор:televizor
        {
            // Ничего не переопределяет
        }


        public static class FactoryTV
        {
            public static televizor CreateTV(string фирма, double диагональ, double мощность, string страна)
            {
                switch (страна.ToLower())
                {
                    case "Япония": return new ЯпонскийТелевизор { Фирма = фирма, Диагональ = диагональ, МощностьЗвука = мощность, СтранаПроизводитель = страна };
                    case "Сингапур":
                    case "Корея":
                        return new АзиатскийТелевизор { Фирма = фирма, Диагональ = диагональ, МощностьЗвука = мощность, СтранаПроизводитель = страна };
                    default:
                        return new ОбычныйТелевизор { Фирма = фирма, Диагональ = диагональ, МощностьЗвука = мощность, СтранаПроизводитель = страна };
                }
            }
        }
    }

    
}
