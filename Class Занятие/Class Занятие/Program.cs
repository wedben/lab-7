using System;
using ClassLibrary1;
using ConsoleApp1;
using Sotrudnik;


public class Занятие
{
    private DateTime Дата;

    private string Дисциплина;
    private string Sotrudnik;
    private string ConsoleApp1;
    private string ClassLibrary1;
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
