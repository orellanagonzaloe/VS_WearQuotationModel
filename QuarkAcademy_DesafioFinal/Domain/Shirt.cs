using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkAcademy_DesafioFinal.nsDomain
{
    internal class Shirt : Wear
    {
        public bool Sleeve { get; private set; } // false: Long, true: Short
        public bool Collar { get; private set; } // false: Normal, true: Mao

        public Shirt(bool Sleeve, bool Collar, bool _Quality, int _Quantity)
        {
            Quality = _Quality;
            Quantity = _Quantity;
            this.Sleeve = Sleeve;
            this.Collar = Collar;
        }

        internal override double GetPrice()
        {
            if (this.Sleeve)
                this.Price *= 0.9;

            if (this.Collar)
                this.Price *= 1.03;

            if (this.Quality)
                this.Price *= 1.3;

            return this.Price * this.Quantity;
        }

        internal override string GetStringCode()
        {
            return String.Format("shirt_{0}_{1}_{2}", Sleeve, Collar, Quality);
        }
    }
}
