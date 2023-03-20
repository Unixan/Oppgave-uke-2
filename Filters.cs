

namespace Oppgave_uke_2
{
    internal class Filters
    {
        public static void FilterStudents()
        {
            Console.Clear();
            Console.WriteLine("Velg ønsket filter:");
            Console.WriteLine();
            var filterChoices = GetFilterChoices(Student.StudentList);
            for (var index = 0; index < filterChoices.Length; index++)
            {
                var selection = index + 1;
                var choice = filterChoices[index];
                Console.WriteLine(selection + ": " + choice);
            }
            Console.WriteLine("0: Tilbake til hovedmeny");
            Console.WriteLine();
            Console.WriteLine("Filter> ");
            var userChoice = Console.ReadLine();
            PerformFilterChoice(userChoice, filterChoices);
        }

        private static void PerformFilterChoice(string userChoice, string[] filterChoices)
        {
            for (int i = 0; i < filterChoices.Length; i++)
            {
                int indexInt = i + 1;
                string index = indexInt.ToString();
                if (userChoice == index)
                {
                    FilterBy(filterChoices[i]);
                    break;
                }
                if (userChoice == "0")
                {
                    MainMenu.Menu();
                    break;
                }else if (i == filterChoices.Length - 1)
                {
                    Common.NotAllowed("Ugyldig valg!");
                    FilterStudents();
                    break;
                }
                
            }

        }


        private static void FilterBy(string filterChoice)
        {
            Console.Clear();
            foreach (var student in Student.StudentList)
            {
                if (student.Course == filterChoice)
                {
                    Console.WriteLine($"Navn: {student.Name} Alder: {student.Age} Kurs: {student.Course}");
                }
            }

            Console.WriteLine();
            Common.NotAllowed("");
            FilterStudents();
        }


        private static string[] GetFilterChoices(List<Student> students)
        {
            var courses = new List<string>();
            foreach (var student in students)
            {
                if (!courses.Contains(student.Course))
                {
                    courses.Add(student.Course);
                }
            }
            return courses.ToArray();
        }

        
    }
}
