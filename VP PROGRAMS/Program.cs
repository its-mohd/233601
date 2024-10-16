using System;

namespace PersonStudentDemo
{
    // Enum for Department
    public enum Department
    {
        ComputerScience,
        ElectricalEngineering,
        MechanicalEngineering,
        CivilEngineering,
        BusinessAdministration
    }
    public class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Person()
        {
            name = null;
        }
        public Person(string name)
        {
            this.name = name;
        }
    }
    public class Student : Person
    {
        
        private string regNo;
        private int age;
        private Department program;

        
        public string RegNo
        {
            get { return regNo; }
            set { regNo = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Department Program
        {
            get { return program; }
            set { program = value; }
        }

        public Student() : base()
        {
            regNo = null; 
            age = 0;      
            program = default(Department); 
        }

        public Student(string name, string regNo, int age, Department program)
            : base(name)
        {
            this.regNo = regNo;
            this.age = age;
            this.program = program;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Using no-argument constructor
            Student student1 = new Student();
            Console.WriteLine("Student1:");
            Console.WriteLine("Name: " + student1.Name);
            Console.WriteLine("Reg No: " + student1.RegNo);
            Console.WriteLine("Age: " + student1.Age);
            Console.WriteLine("Program: " + student1.Program);
            Console.WriteLine();

            // Using multi-argument constructor
            Student student2 = new Student("Mohammad", "CSF24", 20, Department.ComputerScience);
            Console.WriteLine("Student2:");
            Console.WriteLine("Name: " + student2.Name);
            Console.WriteLine("Reg No: " + student2.RegNo);
            Console.WriteLine("Age: " + student2.Age);
            Console.WriteLine("Program: " + student2.Program);
        }
    }
}
