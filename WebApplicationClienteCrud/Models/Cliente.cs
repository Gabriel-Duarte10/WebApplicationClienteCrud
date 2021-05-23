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
        public Guid CLI_ID { get; set; }
        [Required]
        public string CLI_NOME { get; set; }
        [Required]
        public DateTime CLI_DATANASCIMENTO { get; set; }
        [Required]
        public String CLI_ATIVO { get; set; }

        public Cliente()
        {
            CLI_ID = Guid.NewGuid();
        }

    }
}
