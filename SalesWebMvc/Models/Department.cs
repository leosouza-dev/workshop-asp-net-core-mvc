
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class Department
    {
        //propriedades da clase
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigátório")]
        public string Name { get; set; }
    }
}
