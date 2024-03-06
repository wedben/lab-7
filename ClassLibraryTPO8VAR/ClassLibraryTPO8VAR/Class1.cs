using System;



namespace ClassLibaryTPO8VAR
{
    public class Смена
    {
        private string _название;

        public Смена(string название, DateTime? дата = null)
        {
            _название = название;
            if (дата == null)
            {
                дата = DateTime.Now;
            }
            // ваша логика по работе с датой
        }
    }
}

