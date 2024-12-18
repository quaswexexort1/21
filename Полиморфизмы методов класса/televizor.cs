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
        public string Firma {  get; set; }
        private int diagonal;
        public int Diagonal
        {
            get => diagonal;
            set
            {
                if (value >= 0) diagonal = value;
            }
        }
        private int zvukpower;
        public int Zvukpower
        {
            get => zvukpower;
            set { if (value >= 0) zvukpower = value; }
        }

        public televizor(string firma, int diagonal, int zvukpower)
        {
            Firma = firma;
            Diagonal = diagonal;
            Zvukpower = zvukpower;
        }

        public televizor()
        {

        }


        public virtual double GetQuality()
        {
            return (double)(Diagonal + (0, 05 * Zvukpower));
        }

        public override string? ToString()
        {
            return $"Фирма:{Firma}, Диагональ:{Diagonal}, Звуковая мощность: {Zvukpower}";
        }
    }
}
