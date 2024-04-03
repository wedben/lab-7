using ClassLibrary1;
using GFD;
using Auditorium;
using Vid_Zanyatia;

namespace ClassLibrary3
{
    public class Var1Zanyatie
    {
        public DateTime dateTime2 { get; }
        public V3discipline discipline2 { get; }
        public Employees employees2 { get; }
        public Auditorium2 auditorium2 { get; }
        public Var4 gruppa2 { get; }
        //public Var7 { get; }
        public Vid vidZ2 { get; }

        public Var1Zanyatie(DateTime dateTime, V3discipline discipline, Employees sotrudnik, Auditorium2 auditorium, Var4 gruppa, Vid vidZ)
        {
            dateTime2 = dateTime;
            discipline2 = discipline;
            employees2 = sotrudnik;
            auditorium2 = auditorium;
            gruppa2 = gruppa;
            vidZ2 = vidZ;
        }
    }
}
