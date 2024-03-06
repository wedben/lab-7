using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ТРПО;

namespace ТРПО
{
    public class Var5Студент
    {
        public string Фамилия { get; }
        public string Имя { get; }
        public string Отчество { get; }
        public DateTime ДатаРождения { get; }
        public Var4Группа Группа { get; }
        public Var5Студент(string фамилия, string имя, string отчество, Var4Группа группа, DateTime датаРождения)
        {
            Фамилия = фамилия;
            Имя = имя;
            Отчество = отчество;
            ДатаРождения = датаРождения;
            Группа = группа;
        }
    }
}

