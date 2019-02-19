using System;
using System.Collections.Generic;

namespace SchoolApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var students = new List<Student>();
            Console.WriteLine("Student Grading System - V1");
            Console.WriteLine("MetalPhoenix Systems");
            Console.WriteLine("Please enter the number of Students:");

         
            var adding = true;
            while (adding)
            {
                var newStudent = new Student();
                
                Console.Write("Student Name: ");
                newStudent.Name = Console.ReadLine();
               
                Console.Write("Student Birthday: ");
                newStudent.Birthday = Console.ReadLine();

                Console.Write("Student Address: ");
                newStudent.Address = Console.ReadLine();

                Console.Write("Student Phone: ");
                newStudent.Phone = int.Parse(Console.ReadLine());


                students.Add(newStudent);

                Console.WriteLine("Add Another? Yes/No?");
                if (Console.ReadLine() != "Yes")
                    adding = false;
            }

            foreach (var student in students)
            {

                    
                Console.WriteLine("Student Name: {0}, Grade {1}", student.Name, student.Grade);
            }
        }
    }
}

class Student
{
    public string Name;
    public int Grade;
    public string Birthday;
    public string Address;
    public int Phone;
}

