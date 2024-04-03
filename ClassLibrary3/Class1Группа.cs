using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    public class Var4
    {
        public string Название { get; }
        public string Сокращение { get; }
        public int Численность { get; }
        public int ГодПоступления { get; }
        public Var9Сотрудник КлассныйРуководитель { get; }
        public Var6Специальность Специальность { get; }
        public Var4Группа(string названиеГруппы, string сокращение, int численность, int годПоступления, Var9Сотрудник классныйРуководитель, Var6Специальность специальность)
        {
            Название = названиеГруппы;
            Сокращение = сокращение;
            Численность = численность;
            ГодПоступления = годПоступления;
            КлассныйРуководитель = классныйРуководитель;
            Специальность = специальность;
        }
    }

}
