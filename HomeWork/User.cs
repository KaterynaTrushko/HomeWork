using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{

 
    public class User
    {
        public enum UserGender
        {
            Male,
            Female
        }

        private string _firstName;
        private string _lastName;
        private string _age;
        private UserGender _gender;

        //Enum.IsDefined(typeof(UserGender), value)
        public string FirstName 
        {
            get; set;
/*          get => _firstName;
            set => _lastName = value;*/
        }

        public string LastName
        { get;  set; }

        public string Age => _age;

        public UserGender Gender
        { get; set; }

        
        public User() { }

        public User( string name, string lastName, string gender, string age )
        {
            
            FirstName = name;
            LastName = lastName;
            _age = age;
         
                      
              if ( gender.Trim().ToLower() == "male")
               {
                   Gender = UserGender.Male;
               } else if ( gender.Trim().ToLower() == "female")
               { 
                   Gender = UserGender.Female; 
               } else
               {
                 throw new ArgumentOutOfRangeException(nameof(gender), "Gender must be male or female");
               }
        }

        public override string ToString()
        {
            return $"Hi, my name is {FirstName} and last name {LastName}. I am {20} years old. I am {Gender}.";
        }

    }
}
