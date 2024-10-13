using DependcyInjection.Models;
using Microsoft.AspNetCore.Mvc;

namespace DependcyInjection.Entities
{
    public class ClassRoom: ITeacher // Inherited from the ITeacher
    {

        private readonly ITeacher _teachers; // depency Injecttion from the ITeacher

        public ClassRoom(ITeacher teacher) // defined the cnstructor for the using get info method include ITeacher
        {
            _teachers = teacher;
        }

        public string GetInfo()// call the in teachers class GetInfo Method
        {
            return _teachers.GetInfo();
        }

     
    }
}
