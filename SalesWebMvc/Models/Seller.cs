using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime BirthDate { get; set; }

        public double BaseSalary { get; set; }

        //associação - um vendedor possui um departamento
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        //associação - um vendedor possui muitas salesRecord
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        //CONSTRUTORES
        public Seller()
        {

        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        //METODOS CUSTOMIZADOS

        //vamos adicionar uma venda em nossa lista de vendas
        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        //remove a venda
        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        //total de vendas em um determinado periodo
        public double TotalSales(DateTime initial, DateTime final)
        {
            //usar o Linq para filtrar num determinado periodo
            //Sales é a lista de vendas
            //após isso é filtrado
            //e por fim, fazemos a soma do amount
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
