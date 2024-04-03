using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GFD;
using Lab_4;

namespace ClassLibrary2
{
    public class Var11PodraZdelenie
    {
        public string Nazvanie2 { get; }
        public Employees Rukovoditel2 { get; }
        public Organizaca Organizaca2 { get; }
        public Var11PodraZdelenie(string Nazvanie, Employees Rukovoditel, Organizaca Organizaca)
        {
            Nazvanie2 = Nazvanie;
            Rukovoditel2 = Rukovoditel;
            Organizaca2 = Organizaca;
        }
    }
}
