using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        //nossa clase possui uma dependencia de dbcontext
        private readonly SalesWebMvcContext _context;
        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        //metodo para retornar uma lista com todos os vendedores
        //nesse momento temos uma operação sincrona
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
