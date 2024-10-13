// Controllers/ClassRoomController.cs
using DependcyInjection.Entities;
using DependcyInjection.Models;
using Microsoft.AspNetCore.Mvc;
using DependcyInjection.Models;

namespace MyApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClassRoomController : ControllerBase
    {
        private readonly ITeacher _teacher;

        public ClassRoomController(ITeacher teacher)
        {
            _teacher = teacher;
        }

        [HttpGet("teacher-info")]
        public ActionResult<string> GetTeacherInfo()
        {
            var classRoom = new ClassRoom(_teacher);
            return classRoom.GetInfo();
        }
    }
}
