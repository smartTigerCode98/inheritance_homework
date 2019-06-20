using App.Enums;
using App.Interfaces;

namespace App.Entities
{
    public class Student : User
    {
        public int Course { get; set; }
        public Group Group { get; set; }
        
        public Student(){}

        public Student(string name, int age, Sex sex, int salary, int course, Group group) : base(name, age, sex, salary)
        {
            Course = course;
            Group = group;
        }

        public override bool IsEqualRole(IUser other)
        {
            return other is Student;
        }
    }
}