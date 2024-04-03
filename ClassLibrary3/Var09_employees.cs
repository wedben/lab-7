using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFD
{

    internal class employees
    {   
        private string Familia { get; };
        private string Imia { get; };
        private string Otchestvo { get; };
        private string position { get; };

        public employees(string Familia, string Imia, string Otchestvo, Position post)
        {
            this.Familia = Familia;
            this.Imia = Imia;
            this.Otchestvo = Otchestvo;
            this.Position = post;
        }

    }
}
