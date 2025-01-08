namespace CSH_P35
{
    class Student
    {
        string? name;
        List<double> grades;
        double avgGrade;

        public string? Name { get { return name; } set { this.name = value; } }
        public List<double> Grades { get { return grades; } }

        public Student() : this("Vasya", new double[] { }) { }
        public Student(string? name, double[] grades)
        {
            this.name = name;
            this.grades = new List<double>(grades);
            this.CountAvgGrade();
        }

        public double CountAvgGrade() { 
            if (this.grades == null || this.grades.Count == 0)
            {
                this.avgGrade = 0;
                return 0;
            }

            this.avgGrade = grades.Sum() / grades.Count;
            return this.avgGrade; 
        }

        public override string ToString()
        {
            return $"{this.name} ({this.avgGrade}) — {String.Join(", ", this.grades)}";
        }
    }
    

    class Group
    {
        string? name;
        List<Student> students;

        public string? Name { get { return name; } set { this.name = value; } }
        public List<Student> Students { get { return students; } }

        public Group() : this("Group") { }
        public Group(string? name) {
            this.name = name;
            this.students = new List<Student>();
        }
        public double CountTotalAvgGrade()
        {
            double sum = 0;
            foreach(Student student in this.students) { sum += student.CountAvgGrade(); }
            return sum / this.students.Count;
        }

        public override string ToString()
        {
            return $"{this.name} ({this.CountTotalAvgGrade()}):\n  {String.Join("\n  ", this.students)}";
        }
    }

    
    internal class Lesson_7
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Jonny", new double[] { 6, 3, 8, 9 });
            Student student2 = new Student("Alex", new double[] { 10, 9, 11, 10 });

            Group gr1 = new Group("Group 1");
            gr1.Students.Add(student1);
            gr1.Students.Add(student2);
            Console.WriteLine(gr1);
        }
    }
}
