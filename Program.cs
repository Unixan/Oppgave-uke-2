namespace Oppgave_uke_2
{
    internal class Program
    {
            static List<Student> studentList = new Student(new List<Student>()).StudentList;
        static void Main()
        {
            studentList.Add(new Student("Heibert", 42, "Radiobilkjøring"));
            studentList.Add(new Student("Susanne", 23, "Radioamatør"));
            studentList.Add(new Student("Hilde", 45, "Dronepilot"));
            studentList.Add(new Student("Petter", 19, "Dronepilot"));
            Menu();
        }
        private static void Menu()
        {
            Console.Clear();
            Console.WriteLine("************ Meny ************\n\n1: Se alle elever\n2: Filtrere elever etter kurs\n3: Avslutt");
            var choice = Console.ReadLine();
            MenuSelect(choice);
        }

        private static void MenuSelect(string choice)
        {
            switch (choice)
            {


                case "1":
                {
                    listStudents();
                        break;
                    }
                case "2":
                    {
                        break;
                    }
                case "3":
                    {
                        break;
                    }
                default:
                    {
                        NotAllowed("Invalid choice");
                        Menu();
                        break;
                    }
            }
        }

        private static void listStudents()
        {
            foreach (var student in studentList)
            {
                Console.WriteLine(student.Name);
            }
            NotAllowed("");
            Menu();
        }

        private static void NotAllowed(string msg)
        {
            Console.WriteLine(msg + "\nTrykk en tast for å fortsette . . .");
            Console.ReadKey();
        }
    }
}