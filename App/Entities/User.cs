using App.Enums;
using App.Interfaces;

namespace App.Entities
{
    public class User : IUser
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Sex Sex { get; set; }
        public int Salary { get; set; }
        public bool IsAdult => Age >= 18;
        
        public User(){}

        public User(string name, int age, Sex sex, int salary)
        {
            Name = name;
            Age = age;
            Sex = sex;
            Salary = salary;
        }

        public virtual bool IsEqualRole(IUser other)
        {
            return other is User;
        }
    }
}