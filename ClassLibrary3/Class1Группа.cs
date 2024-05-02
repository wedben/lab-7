using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GFD;
using Specialization;

namespace ClassLibrary1
{
    public class Var4
    {
       public string Nazvanie2 { get; }
        public string Sokr2 { get; }
        public int Chisl2 { get; }
        public int GosPost2 { get; }
        public Employees  employees2 { get; }
        public Var6Specialization Specialization2 { get; }
        public Var4(string Nazvanie, string Sokr, int Chisl, int GosPost, Employees employees, Var6Specialization Specialization)
        {
            Nazvanie2 = Nazvanie;
            Sokr2 = Sokr;
            Chisl2 = Chisl;
            GosPost2 = GosPost;
            employees2 = employees;
            Specialization2 = Specialization;
        }
    }
}
