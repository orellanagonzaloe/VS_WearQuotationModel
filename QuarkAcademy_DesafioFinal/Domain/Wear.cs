using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkAcademy_DesafioFinal.nsDomain
{
    public abstract class Wear
    {
        public bool Quality { get; set; } // false: Standard, true: Premium
        public double Price { get; set; }
        public int Quantity { get; set; }

        internal abstract double GetPrice();
        internal abstract string GetStringCode();
    }
}
