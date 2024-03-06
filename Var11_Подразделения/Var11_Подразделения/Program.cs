using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    public class Var11Подразделение
    {
        public string Название { get; } // ссылка на вариант с заданиями
        public Var9Сотрудник Руководитель { get; } // ссылка на вариант с Руководителем
        public Var12Организация Организация { get; } // ссылка на вариант с Организацией
        public Var11Подразделение(string названиеПодразделения, Var9Сотрудник руководитель, Var12Организация организация)
        {
            Название = названиеПодразделения;
            Организация = организация;
            Руководитель = руководитель;
        }
    }
}
