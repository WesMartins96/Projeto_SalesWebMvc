using Projeto_SalesWebMvc.Data;
using Projeto_SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_SalesWebMvc.Services
{
    public class SellerService
    {


        private readonly Projeto_SalesWebMvcContext _context;

        public SellerService(Projeto_SalesWebMvcContext context)
        {
            _context = context;
        }


        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
