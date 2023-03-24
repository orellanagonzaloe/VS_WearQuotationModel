using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkAcademy_DesafioFinal.nsDomain
{
    public class Seller
    {

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Code { get; private set; }

        public Seller(string Name, string Surname, string Code)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Code = Code;
        }
    }
}

