using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary3;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
                        while (true)
            {
                Console.Write("Введите имя создаваемого класса: ");
                switch (Console.ReadLine())
                {
                    case "Аудитория": UI.Print(ClassCreator.Аудитория()); break;
                    case "Дисциплина": UI.Print(ClassCreator.Дисциплина()); break;
                    case "Группа": UI.Print(ClassCreator.Группа()); break;
                    case "Пара": UI.Print(ClassCreator.Пара()); break;
                    case "Должность": UI.Print(ClassCreator.Должность()); break;
                    case "Студент": UI.Print(ClassCreator.Студент()); break;
                    case "Организация": UI.Print(ClassCreator.Организация()); break;
                    case "Смена": UI.Print(ClassCreator.Смена()); break;
                    case "Подразделение": UI.Print(ClassCreator.Подразделение()); break;
                    case "Сотрудник": UI.Print(ClassCreator.Сотрудник()); break;
                    default: Console.WriteLine("Этот класс не реализован"); break;
                }
            }

        }
    }
}
