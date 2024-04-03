using ClassLibrary1;
using GFD;
using Auditorium;
using Vid_Zanyatia;

namespace ClassLibrary3
{
    public class Var1Zanyatie
    {
        public DateTime dateTime { get; }
        public V3discipline discipline { get; }
        public employees employees2 { get; }
        public Auditorium2 auditorium { get; }
        public Var4Группа gruppa { get; }
        //public Var7 { get; }
        public Vid vidZ { get; }

        public Var1Zanyatie(DateTime dateTime, V3discipline discipline, employees sotrudnik, Auditorium2 auditorium, Var4Группа gruppa, Vid vidZ)
        {
            dateTime = dateTime;
            discipline = discipline;
            sotrudnik = sotrudnik;
            auditorium = auditorium;
            gruppa = gruppa;
            vidZ = vidZ;
        }
    }
}
