using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SABOR_E_SAUDE.DOMAIN.Models
{
    public class Comentario
    {

        [Key]
        public Guid ComentarioID { get; set; }

        [Required(ErrorMessage ="Por favor, digite um comentario.")]
        [StringLength(180)]
        [Column("Comentario", TypeName = "varchar")]
        public string Comentariotxt{ get; set; }


        public Guid ClienteID { get; set; }
    }
}
