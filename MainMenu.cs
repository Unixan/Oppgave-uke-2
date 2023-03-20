namespace Oppgave_uke_2
{
    internal class MainMenu
    {
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("************ Meny ************\n\n1: Se alle elever\n2: Filtrere elever etter kurs\n3: Avslutt\n\nSkriv et tall fra menyen og trykk enter");
            string choice = Console.ReadLine();
            MenuSelect(choice);
        }

        private static void MenuSelect(string choice)
        {
            switch (choice)
            {


                case "1":
                {
                    ListStudents();
                    break;
                }
                case "2":
                {
                    Filters.FilterStudents();
                    break;
                }
                case "3":
                {
                    break;
                }
                default:
                {
                    Common.NotAllowed("Du må velge 1, 2 eller 3");
                    Menu();
                    break;
                }
            }
        }
        private static void ListStudents()
        {
            Console.Clear();
            Console.WriteLine("Navn på Elever:\n");
            foreach (var student in Student.StudentList)
            {
                Console.WriteLine(student.Name);
            }
            Common.NotAllowed("");
            MainMenu.Menu();
        }
    }
}
