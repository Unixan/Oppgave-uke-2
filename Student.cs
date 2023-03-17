namespace Oppgave_uke_2
{
    internal class Student
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Course { get; private set; }
        public int Id { get; private set; }
        public List<Student> StudentList { get; set; }


        public Student(string name, int age, string course)
        {
            Name = name;
            Age = age;
            Course = course;
        }

        public Student(List<Student> studentList)
        {
            StudentList = studentList;
        }
    }
}