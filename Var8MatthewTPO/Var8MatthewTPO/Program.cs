using System;

namespace Var8MatthewTPO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
        }

        public class Смена
        {
            private string Название;
            private DateTime Дата;

            public Смена(string название, DateTime? дата = null)
            {
                Название = название;
                if (дата == null)
                {
                    Дата = DateTime.Now;
                }
                else
                {
                    Дата = (DateTime)дата;
                }
            }
        }


    }

}


