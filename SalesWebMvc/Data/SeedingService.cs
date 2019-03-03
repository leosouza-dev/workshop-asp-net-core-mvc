using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        //**injeção de dependencia
        private readonly SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        //essa operação vai popular a base de dado
        public void Seed()
        {
            //vamos testar se existe algum dado na minha base de dados
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                //CASO EXISTA, FIM
                return; //DB já foi populado
            }


       
            //Department d1 = new Department(1, "Computers");
            //Department d2 = new Department(2, "Electronics");

            //Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            //Seller s2 = new Seller(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);

            //SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);
            //SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 09, 4), 7000.0, SaleStatus.Billed, s2);


            //_context.Department.AddRange(d1, d2);
            //_context.Seller.AddRange(s1, s2);
            //_context.SalesRecord.AddRange(r1, r2);

            //_context.SaveChanges();

        }
    }
}
