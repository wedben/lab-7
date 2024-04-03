using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace Dolgnost
{
    class Position
    {
        private string nazvanie;
        private double oklad;
        private Var11PodraZdelenie Var11PodraZdelenie;

        public Position(string nazvanie, double oklad, Var11PodraZdelenie Var11PodraZdelenie)
        {
            this.nazvanie = nazvanie;
            this.oklad = oklad;
            this.Var11PodraZdelenie = Var11PodraZdelenie;
        }

        public string Nazvanie
        {
            get { return nazvanie; }
            set { nazvanie = value; }
        }

        public double Oklad
        {
            get { return oklad; }
            set { oklad = value; }
        }

        public string var11PodraZdelenie
        {
            get { return Var11PodraZdelenie; }
            set { Var11PodraZdelenie = value; }
        }
    }
}
