using System;
using System.Collections.Generic;

namespace GarageExams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Exam> exams = new List<Exam>();
            Console.WriteLine("Please enter count of the exams: ");
            int examCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < examCount; i++)
            {
                Console.WriteLine($"Exam #{i+1}");

                Console.WriteLine("Please enter FullName: ");
                string studentName = Console.ReadLine();

                Console.WriteLine("Please Enter a Subject: ");
                string subjectName = Console.ReadLine();

                Console.WriteLine("Enter Point: ");
                int point = int.Parse(Console.ReadLine());       

                Console.WriteLine("Start time (HH:mm): ");
                DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "HH:mm", null);

                Console.WriteLine("End time (HH:mm): ");
                DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "HH:mm", null);


                Student student = new Student { NameSurname = studentName};
                Subject subject = new Subject { SubjectName = subjectName };
                Exam exam = new Exam
                {
                    Student = student,
                    Subject = subject,
                    Point = point,
                    StartDate = startDate,
                    EndDate = endDate
                };

                exams.Add(exam);
            }

            Console.WriteLine("Exams with more than 50 points: ");
            foreach (var exam in exams)
            {
                if (exam.Point>50)
                {
                    Console.WriteLine($"{exam.Student.NameSurname} {exam.Point}");
                }
            }

            Console.WriteLine("Exams lasting longer than 1 hour: ");
            foreach (var exam in exams)
            {
                TimeSpan duration = exam.EndDate - exam.StartDate;
                if (duration.TotalHours>1)
                {
                    Console.WriteLine($"{exam.Student.NameSurname} {duration.TotalHours} saat");
                }
            }
        }
    }
}
