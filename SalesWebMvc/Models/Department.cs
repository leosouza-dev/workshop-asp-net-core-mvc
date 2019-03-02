
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Department
    {
        //propriedades da clase
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigátório")]
        public string Name { get; set; }

        //associações - departamento possui varios vendedores
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();


        //CONSTRUTORES
        public Department()
        {
                
        }

        //obs: não incluir argumentos que são coleções
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        //METODOS

        //Add vendedor
        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        //reultado de total de vendas do departamento em periodo
        //vamos pegar a lista de vendedores e somar o total de venda de cada vendedor nesse periodo
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
