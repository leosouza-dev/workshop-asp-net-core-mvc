using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;

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

        //metodo para inserir um novo vendedor
        public void Insert(Seller seller)
        {
            var result = from obj in _context.Seller select obj;
            //result = result.Where(x => x.Name == seller.Name);

            if(result.Any(x => x.Name == seller.Name))
            {
                return;
            }

            seller.Department = _context.Department.First();
            _context.Add(seller);
            _context.SaveChanges();
            
        }
    }
}
