using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Person student = new Person("Anar", "Qandayev", 45);
            Person employee = new Person("Ilham", "Veliyev", 15);
         
            Employee e = new Employee();
            e.person = employee;

            Console.WriteLine("Ishci: "+e.person.name+" "+ e.person.surname);
            Console.WriteLine(e.CalculateSalary(9, 300,e.person.age));

            Student st = new Student();
            st.person = student;
            Console.WriteLine("Student: " + st.person.name + " " + st.person.surname);

            Console.WriteLine( "Neticeniz: " + st.ExamResult(50, 60 , st.person.age));



        }
    }
}
