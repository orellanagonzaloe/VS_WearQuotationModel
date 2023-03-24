using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QuarkAcademy_DesafioFinal.nsDomain
{
    internal class Trouser : Wear
    {
        public bool Type { get; private set; } // false: Normal, true: Slim

        public Trouser(bool Type, bool _Quality, int _Quantity)
        {
            Quality = _Quality;
            Quantity = _Quantity;
            this.Type = Type;
        }

        internal override double GetPrice()
        {
            if (this.Type)
                this.Price *= 0.88;

            if (this.Quality)
                this.Price *= 1.3;

            return this.Price * this.Quantity;
        }

        internal override string GetStringCode()
        {
            return String.Format("trouser_{0}_{1}", Type, Quality);
        }
    }
}
