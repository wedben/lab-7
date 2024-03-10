using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sotrudnik
{

    internal class Sotrudnik
    {   
        private string Familia { get; };
        private string Imia { get; };
        private string Otchestvo { get; };
        private string DoljnostName { get; };

        public Sotrudnik(string Familia, string Imia, string Otchestvo, string DoljnostName)
        {
            this.Familia = Familia;
            this.Imia = Imia;
            this.Otchestvo = Otchestvo;
            this.DoljnostName = DoljnostName;
        }

    }
}
