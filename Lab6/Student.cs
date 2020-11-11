using System;
namespace Lab6
{
    public class Student
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string dept;
        public string Dept
        {
            get { return dept; }
            set { dept = value; }
        }
        private float cgpa;
        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        public Student()
        {
            Console.WriteLine("Student Default");
        }
        public Student(string name, string id, string dept, float cgpa)
        {
            this.name = name;
            this.id = id;
            this.dept = dept;
            this.cgpa = cgpa;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Dept:" + dept);
            Console.WriteLine("Cgpa: " + cgpa);
            
        }

    }

}
