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
    public class GradeController : BaseApiController
    {
        private readonly DataContext _context;
        public GradeController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GradeClass>>> GetGrades()
        {
            return await _context.GradeStudent.ToListAsync();
          
        }

        //api/grades/3s
        [HttpGet("{id}")]
        public async Task<ActionResult<GradeClass>>GetGrade(int id)
        {
           return await _context.GradeStudent.FindAsync(id);
        
        }

        
    }
}