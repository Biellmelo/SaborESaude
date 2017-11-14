using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SABOR_E_SAUDE.DOMAIN.Models
{

    [Table("Admins")]
    public class Administrador
    {
        public Administrador()
        {
            AdminId = Guid.NewGuid();
            Permissao = "ADMIN";
        }

        [Key]
        public Guid AdminId { get; set; }

        [StringLength(60, MinimumLength = 5)]
        [Column(TypeName = "varchar")]
        [Required]
        public string Email { get; set; }

        [StringLength(200, MinimumLength = 5)]
        [Column(TypeName = "varchar")]
        [Required]
        public string Senha { get; set; }

        public string Permissao { get; set; }
    }
}
