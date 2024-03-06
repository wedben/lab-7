using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var12
{
    // вариант 12
    internal class Организация
    {
        private string Название;
        private string Юридический_адрес;
        private string Фактический_адрес;
        private string Руководитель;

        public Организация(string Название, string Юридический_адрес, string Фактический_адрес, string Руководитель)
        {
            this.Название = Название;
            this.Юридический_адрес = Юридический_адрес;
            this.Фактический_адрес = Фактический_адрес;
            this.Руководитель = Руководитель;
        }
    }
}
