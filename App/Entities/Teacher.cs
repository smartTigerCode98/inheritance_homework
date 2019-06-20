using App.Enums;
using App.Interfaces;

namespace App.Entities
{
    public class Teacher : User
    {
        public Discipline Discipline { get; set; }
        public Review Review { get; set; }

        public Teacher(string name, int age, Sex sex, int salary, Discipline discipline, Review review) : base(name,
            age, sex, salary)
        {
            Discipline = discipline;
            Review = review;
        }
        
        public override bool IsEqualRole(IUser other)
        {
            return other is Teacher;
        }
    }
}