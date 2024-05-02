using System;

namespace ClassLibaryTPO8VAR
{
    public class Smena
    {
        private string _nazvanie;
        public Smena(string nazvanie, DateTime? date = null)
        {
            _nazvanie = nazvanie;
            if (date == null)
            {
                date = DateTime.Now;
            }
        }
    }
}

