namespace Oppgave_uke_2
{
    internal class Program
    {
        private static void Main()
        {
            Student.StudentList.Add(new Student("Heibert", 42, "Radiobilkjøring"));
            Student.StudentList.Add(new Student("Susanne", 23, "Radioamatør"));
            Student.StudentList.Add(new Student("Hilde", 45, "Dronepilot"));
            Student.StudentList.Add(new Student("Petter", 19, "Dronepilot"));
            MainMenu.Menu();
        }
    }
}