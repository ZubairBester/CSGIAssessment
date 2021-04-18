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
        public async Task<ActionResult<IEnumerable<StudentEndOfDay>>> GetStudents()
        {
            return await _context.Students.ToListAsync();
            
        }
        
        //api/students/3
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentEndOfDay>> GetStudent(int id)
        {
            return await _context.Students.FindAsync(id);
         
        }
    }
}