using System;
using System.Collections.Generic;
using App.Entities;
using App.Enums;
using App.Interfaces;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<IUser>
            {
                new User("Vasil", 30, Sex.Male, 3000),
                new User("Anatoliy", 54, Sex.Male, 3000),
                new Student("Yuriy", 21, Sex.Male, 1300, 3, Group.Tv61),
                new Student("Maria", 19, Sex.Female, 1300, 3, Group.Tv61),
                new Teacher("John", 42, Sex.Male, 5000, Discipline.Programming, Review.Good),
                new Teacher("Valentina", 28, Sex.Female, 4500, Discipline.Math, Review.Perfect)
            };
            
            double totalUserSalary = 0, totalStudentSalary = 0, totalTeacherSalary = 0;
            int countUsers = 0, countStudents = 0, countTeachers = 0;

            foreach (var person in people)
            {
                if (person is User)
                {
                    totalUserSalary += person.Salary;
                    countUsers += 1;
                }

                switch (person)
                {
                    case Student _:
                        totalStudentSalary += person.Salary;
                        countStudents += 1;
                        break;
                    case Teacher _:
                        totalTeacherSalary += person.Salary;
                        countTeachers += 1;
                        break;
                }
            }
            
            Console.WriteLine($"Average salary among all users is {totalUserSalary/countUsers}");
            Console.WriteLine($"Average salary among all teachers is {totalTeacherSalary/countTeachers}");
            Console.WriteLine($"Average salary among all students is {totalStudentSalary/countStudents}");
            
        }
    }
}
