using System.Security.Cryptography;
using System;
using System.Text;
using System.Threading.Tasks;
using API.Data;
using API;
using API.Entities;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class AccountController: BaseApiController
    {
        private readonly DataContext _context;
        public AccountController (DataContext context)
        {
            _context = context;
        }
        
        
        
    }
}