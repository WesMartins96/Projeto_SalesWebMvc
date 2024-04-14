using Microsoft.EntityFrameworkCore;
using Projeto_SalesWebMvc.Data;
using Projeto_SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly Projeto_SalesWebMvcContext _context;

        public DepartmentService(Projeto_SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }




    }
}
