namespace Auditorium
{
    public class Auditorium
    {
        private string name;
        private string responsibleEmployee;
        private int seatingCapacity;
        private int windowCount;
        private List<string> equipmentList;

        public Auditorium(string name, string responsibleEmployee, int seatingCapacity, int windowCount, List<string> equipmentList)
        {
            this.name = name;
            this.responsibleEmployee = responsibleEmployee;
            this.seatingCapacity = seatingCapacity;
            this.windowCount = windowCount;
            this.equipmentList = equipmentList;
        }
    }
}
