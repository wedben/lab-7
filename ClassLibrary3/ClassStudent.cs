using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Student5var
{
    public class Var5
    {
        public string Familia2 { get; }
        public string Imya2 { get; }
        public string Otchestvo2 { get; }
        public DateTime Datarozdeniya2 { get; }

        public Var4Группа gruppa2 { get; }
        public Var5(string Familia, string Imya, string Otchestvo, Var4Группа gruppa, DateTime Datarozdeniya)
        {
            Familia2 = Familia;
            Imya2 = Imya;
            Otchestvo2 = Otchestvo;
            Datarozdeniya2 = Datarozdeniya;
            gruppa2 = gruppa;
        }
    }
}
