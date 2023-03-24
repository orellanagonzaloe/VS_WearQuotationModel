using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkAcademy_DesafioFinal.nsDomain
{
    public class Quote
    {
        public int Number { get; set; }
        public string DateTime { get; set; }
        public string Code { get; set; }
        public Wear wear { get; set; }
        public int Quantity { get; set; }
        public double Result;


        public void Quotate()
        {
            Result = wear.GetPrice();
        }
    }
}
