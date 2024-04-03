using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dolgnost;

namespace GFD
{

    public class Employees
    {
        public string Familia { get; }
        public string Imia { get; }
        public string Otchestvo { get; }
        public Position position { get; }

        public Employees(string Familia, string Imia, string Otchestvo, Position post)
        {
            this.Familia = Familia;
            this.Imia = Imia;
            this.Otchestvo = Otchestvo;
            this.position = post;
        }

    }
}
