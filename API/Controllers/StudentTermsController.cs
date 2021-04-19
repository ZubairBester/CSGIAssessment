using System.Collections.Generic;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class StudentTermsController : BaseApiController
    {
        private readonly DataContext _context;
        public StudentTermsController(DataContext context)
        {
            _context = context;


        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentEndOfTerm>>> GetStudentRecords()
        {
            return await _context.StudentRecords.ToListAsync();
        }
         
         [HttpGet("{id}")]
        public async Task<ActionResult<StudentEndOfTerm>> GetStudentRecord(int id)
        {
            return await _context.StudentRecords.FindAsync(id);
         
        }
         

         [HttpPost("register")]
        public async Task<ActionResult<StudentEndOfTerm>> RegisterStudentTerm(StudentEndOfTerm studentRecordTerm)
        {
            
            _context.StudentRecords.Add(studentRecordTerm);
            await _context.SaveChangesAsync();
            return studentRecordTerm;
        }
    }
}