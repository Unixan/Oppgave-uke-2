namespace Oppgave_uke_2
{
    internal class Student
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Course { get; private set; }
        public static List<Student> StudentList = new List<Student>();


        public Student(string name, int age, string course)
        {
            Name = name;
            Age = age;
            Course = course;
        }
    }
}