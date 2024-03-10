using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace ClassLibrary1
{
    public class Var01_Class
    {
        internal static Var02 ToString(string value)
        {
            throw new NotImplementedException();
        }

        private DateTime dateTime;
        private Var11 discipline;
        private Var09 employees;
        private Var02 theAudience;
        private Var04 group;
        private Var07 couple;
        private Var14 classes;

        public string datetime
        {
            get { return dateTime.ToString(); }
            set { dateTime = DateTime.Parse(value); }
        }
        public string Discipline
        {
            get { return discipline.ToString(); }
            set { discipline = Var11.ToString(value); }
        }
        public string Employees
        {
            get { return employees.ToString(); }
            set { employees = Var09.ToString(value); }
        }
        public string TheAudience
        {
            get { return theAudience.ToString(); }
            set { theAudience = Var02.ToString(value); }
        }
        public string Group
        {
            get { return group.ToString(); }
            set { group = Var04.ToString(value); }
        }
        public string Couple
        {
            get { return couple.ToString(); }
            set { couple = Var07.ToString(value); }
        }
        public string Classes
        {
            get { return classes.ToString(); }
            set { classes = Var14.ToString(value); }
        }

        public Var01_Class(string dateTime, string discipline, string employees, string theAudience, string group, string couple, string classes)
        {
            datetime = dateTime;
            Discipline = discipline;
            Employees = employees;
            TheAudience = theAudience;
            Group = group;
            Couple = couple;
            Classes = classes;
        }


    }
}