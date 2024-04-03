using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТРПО_Лаба_2_вариант_10__должность_
{
    class Position
    {
        private string nazvanie;
        private double oklad;
        private string departmentLink;

        public Position(string nazvanie, double oklad, string departmentLink)
        {
            this.nazvanie = nazvanie;
            this.oklad = oklad;
            this.departmentLink = departmentLink;
        }

        public string Nazvanie
        {
            get { return nazvanie; }
            set { nazvanie = value; }
        }

        public double Oklad
        {
            get { return oklad; }
            set { oklad = value; }
        }

        public string DepartmentLink
        {
            get { return departmentLink; }
            set { departmentLink = value; }
        }
    }
}
