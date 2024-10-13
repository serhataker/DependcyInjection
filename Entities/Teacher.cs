using DependcyInjection.Models;

namespace DependcyInjection.Entities
{
    public class Teacher:ITeacher// Implemneted from yhe Iteacher
    {
        // Tecaher class Properites
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Teacher(string firstName, string lastName) // asign the properies for thw teacer object constructor
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetInfo() // return the teacher first and last name
        {
            return $"{FirstName} {LastName}";

        }
    }
}
