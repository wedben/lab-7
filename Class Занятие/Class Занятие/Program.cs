using System;

public class Занятие
{
    private DateTime Дата;

    private string Дисциплина;
    private string Сотрудник;
    private string Auditorium;
    private string Группа;
    private string Пара;
    private string ВидЗанятия;
    
    public Занятие(string Дисциплина, string Сотрудник, string Auditorium, string Группа, string Пара, string ВидЗанятия, DateTime Дата)
    {
        this.Дата = Дата;
        this.Дисциплина = Дисциплина;
        this.Сотрудник = Сотрудник;
        this.Auditorium = Auditorium;
        this.Группа = Группа;
        this.Пара = Пара;
        this.ВидЗанятия = ВидЗанятия;

        if (Дата == DateTime.MinValue)
        {
            this.Дата = DateTime.Now;
        }
    }
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
            
        }
    }
}
