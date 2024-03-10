using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Var11Подразделение
    {
        public string Название { get; }
        public Var9Сотрудник Руководитель { get; }
        public Var12Организация Организация { get; }
        public Var11Подразделение(string названиеПодразделения, Var9Сотрудник руководитель, Var12Организация организация)
        {
            Название = названиеПодразделения;
            Организация = организация;
            Руководитель = руководитель;
        }
    }
}