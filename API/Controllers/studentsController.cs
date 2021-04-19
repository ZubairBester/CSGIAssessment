using API.Data;
using System.Collections.Generic;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class studentsController : ControllerBase
    {
        private readonly DataContext _context;
        public studentsController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public ActionResult<IEnumerable<GradeClass>>GetGrades()
        {
            var grades = _context.GradeStudent.ToList();
            return grades;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentEndOfDay>>> GetStudents()
        {
            return await _context.Students.ToListAsync();
            
        }
        //get all student records
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentEndOfTerm>>> GetStudentRecords()
        {
            return await _context.StudentRecords.ToListAsync();
        }

        //api/grades/3
        [HttpGet("{id}")]
        public ActionResult<GradeClass> GetGrade(int id)
        {
            var vrGradeClass = _context.GradeStudent.FindAsync(id);
            return vrGradeClass;
        }
        
        //api/students/3
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentEndOfDay>> GetStudent(int id)
        {
            return await _context.Students.FindAsync(id);
         
        }
         //api/students Record/3
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentEndOfTerm>> GetStudentRecord(int id)
        {
            return await _context.StudentRecords.FindAsync(id);
         
        }
    }
}