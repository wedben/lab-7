using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТРПО_Лаба_2_вариант_10__должность_
{
    class Position
    {
        private string title;
        private double salary;
        private string departmentLink;

        public Position(string title, double salary, string departmentLink)
        {
            this.title = title;
            this.salary = salary;
            this.departmentLink = departmentLink;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string DepartmentLink
        {
            get { return departmentLink; }
            set { departmentLink = value; }
        }
    }
}
