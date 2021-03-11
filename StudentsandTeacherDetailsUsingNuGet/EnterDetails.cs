using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsandTeacherDetailsUsingNuGet
{
    class EnterDetails
    {
        public struct Students
        {
            public string Name;
            public string ClassAndSession;
        }
        struct Teacher
        {
            public string Name;
            public string ClassAndSession;
        }
        struct Subject
        {
            public string Name;
            public string SubjectCode;
        }
        public static void Do()
        {
            Console.Write("Enter Details of Student1: ");
            Students student = new Students();
            student.Name = Console.ReadLine();
            student.ClassAndSession = Console.ReadLine();
            Console.Write("Enter Details of Student2: ");
            Students student1 = new Students();
            student1.Name = Console.ReadLine();
            student1.ClassAndSession = Console.ReadLine();
            Console.Write("Enter Details of Student3: ");
            Students student2 = new Students();
            student2.Name = Console.ReadLine();
            student2.ClassAndSession = Console.ReadLine();
            Console.Write("Enter Details of Teacher1: ");
            Teacher teacher = new Teacher();
            teacher.Name = Console.ReadLine();

            teacher.ClassAndSession = Console.ReadLine();
            Console.Write("Enter Details of Teacher2: ");
            Teacher teacher1 = new Teacher();
            teacher1.Name = Console.ReadLine();
            teacher1.ClassAndSession = Console.ReadLine();

            Console.Write("Enter Details of Teacher3: ");
            Teacher teacher2 = new Teacher();
            teacher2.Name = Console.ReadLine();
            teacher2.ClassAndSession = Console.ReadLine();

            Console.WriteLine("enter Details of Subject1: ");
            Subject subject = new Subject();
            subject.Name = Console.ReadLine();
            subject.SubjectCode = Console.ReadLine();
            Console.WriteLine("enter Details of Subject2: ");
            Subject subject1 = new Subject();
            subject1.Name = Console.ReadLine();
            subject1.SubjectCode = Console.ReadLine();
            Console.WriteLine("enter Details of Subject3: ");
            Subject subject2 = new Subject();
            subject2.Name = Console.ReadLine();
            subject2.SubjectCode = Console.ReadLine();

            Console.WriteLine("-----------------------------Student Details-----------------------------");
            Console.WriteLine("Name: " + student.Name + "\tClass And Session: " + student.ClassAndSession);
            Console.WriteLine("Name: " + student1.Name + "\tClass And Session: " + student1.ClassAndSession);
            Console.WriteLine("Name: " + student2.Name + "\tClass And Session: " + student2.ClassAndSession);
            Console.WriteLine("-----------------------------Teacher Details-----------------------------");
            Console.WriteLine("Name: " + teacher.Name + "\tClass And Session: " + teacher.ClassAndSession);
            Console.WriteLine("Name: " + teacher1.Name + "\tClass And Session: " + teacher1.ClassAndSession);
            Console.WriteLine("Name: " + teacher2.Name + "\tClass And Session: " + teacher2.ClassAndSession);
            Console.WriteLine("-----------------------------Subject Details-----------------------------");
            Console.WriteLine("Name: " + subject.Name + "\tSubject Code: " + subject.SubjectCode);
            Console.WriteLine("Name: " + subject1.Name + "\tSubject Code: " + subject1.SubjectCode);
            Console.WriteLine("Name: " + subject2.Name + "\tSubject Code: " + subject2.SubjectCode);
        } 
    }
}
