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
        public string Familia { get; }
        public string Imya { get; }
        public string Otchestvo { get; }
        public DateTime Datarozdeniya { get; }

        public Var4Группа группа { get; }
        public Var5(string Familia, string Imya, string Otchestvo, Var4Группа группа, DateTime Datarozdeniya)
        {
            Familia = Familia;
            Imya = Imya;
            Otchestvo = Otchestvo;
            Datarozdeniya = Datarozdeniya;
            группа = группа;
        }
    }
}
