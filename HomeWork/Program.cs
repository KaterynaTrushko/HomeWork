using HomeWork;
using System;


internal class Program
{
    private static void Main(string[] args)
    {
        User user1 = new User();
        user1.Gender = User.UserGender.Female;

        Console.WriteLine("Input username");
        string userName = Console.ReadLine();
        user1.FirstName = userName;

        Console.WriteLine("Input lastname");
        string lastName = Console.ReadLine();
        user1.LastName = lastName;
       
        Console.WriteLine($"This is {user1.FirstName} {user1.LastName}, a gender is {user1.Gender.ToString().ToLower()} ");
        Console.WriteLine(user1.ToString());

    }
}