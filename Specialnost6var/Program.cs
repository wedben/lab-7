using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Специальность
    {
        private string название;
        private string сокращение;

        public Специальность(string название, string сокращение)
        {
            this.название = название;
            this.сокращение = сокращение;
        }

        public string Название
        {
            get { return название; }
            set { название = value; }
        }

        public string Сокращение
        {
            get { return сокращение; }
            set { сокращение = value; }
        }
    }
}
