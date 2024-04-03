using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace Dolgnost
{
    public class Position
    {
        private string nazvanie;
        private double oklad;
        private Var11PodraZdelenie Var11PodraZdelenie2;

        public Position(string nazvanie, double oklad, Var11PodraZdelenie Var11PodraZdelenie2)
        {
            this.nazvanie = nazvanie;
            this.oklad = oklad;
            this.Var11PodraZdelenie2 = Var11PodraZdelenie2;
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

        public string Var11PodraZdelenie
        {
            get { return Var11PodraZdelenie; }
            set { Var11PodraZdelenie = value; }
        }
    }
}
