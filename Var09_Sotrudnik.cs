using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sotrudnik
{

    internal class Sotrudnik
    {   
        private string Familia;
        private string Imia;
        private string Otchestvo;
        private string DoljnostName;

        public Sotrudnik(string Familia, string Imia, string Otchestvo, string DoljnostName)
        {
            this.Familia = Familia;
            this.Imia = Imia;
            this.Otchestvo = Otchestvo;
            this.DoljnostName = DoljnostName;
        }

    }
}
