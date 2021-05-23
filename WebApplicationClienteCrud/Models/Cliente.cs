using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationClienteCrud.Models
{
    public class Cliente
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public DateTime Data_de_Nascimento { get; set; }
        [Required]
        public String Ativo { get; set; }

        public Cliente()
        {
            Id = Guid.NewGuid();
        }

    }
}
