using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    // вариант 12
    internal class Организация
    {
        private string Nazvanie;
        private string Ur_adress;
        private string Fakt_adress;
        private string Rukovoditel;

        public Организация(string Nazvanie, string Ur_adress, string Fakt_adress, string Rukovoditel)
        {
            this.Nazvanie = Nazvanie;
            this.Ur_adress = Ur_adress;
            this.Fakt_adress = Fakt_adress;
            this.Rukovoditel = Rukovoditel;
        }
    }
}
