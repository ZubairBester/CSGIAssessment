using API.Data;
using System;
using System.Collections.Generic;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
   
    public class StudentController : BaseApiController
    {
        private readonly DataContext _context;
        public StudentController(DataContext context)
        {
            _context = context;

        }

        

        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentEndOfDay>>> GetStudents()
        {
            return await _context.Students.ToListAsync();
            
        }
        //get all student records
        // [HttpGet]
        // public async Task<ActionResult<IEnumerable<StudentEndOfTerm>>> GetStudentRecords()
        // {
        //     return await _context.StudentRecords.ToListAsync();
        // }

        
        
        //api/students/3
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentEndOfDay>> GetStudent(int id)
        {
            return await _context.Students.FindAsync(id);
         
        }
         //api/students Record/3
        // [HttpGet("{id}")]
        // public async Task<ActionResult<StudentEndOfTerm>> GetStudentRecord(int id)
        // {
        //     return await _context.StudentRecords.FindAsync(id);
         
        // }

        [HttpPost("register")]
        public async Task<ActionResult<StudentEndOfDay>> RegisterStudent(StudentEndOfDay studentRecord)
        {
            //var studentRecord = new StudentEndOfDay
            //{
            //    ClassName = stu,
            //    Grade = Grade,
            //    Date = Date,
            //    Time = Time,
            //    StudentsName = studentsName,
            //    Attendency = Attendency
            //};

            _context.Students.Add(studentRecord);
            await _context.SaveChangesAsync();
            return studentRecord;
        }
    }
}