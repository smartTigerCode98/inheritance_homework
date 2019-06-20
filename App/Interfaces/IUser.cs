using App.Enums;

namespace App.Interfaces
{
    public interface IUser
    {
        string Name { get; set; }
        int Age { get; set; }
        Sex Sex { get; set; }
        int Salary { get; set; }
        bool IsAdult { get; }
    }
}