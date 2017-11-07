using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SABOR_E_SAUDE.DOMAIN.Models
{

    [Table("Administrador")]
    public class Administrador
    {
        public Administrador()
        {
            AdmId = Guid.NewGuid();
        }

        [Key]
        public Guid AdmId { get; set; }
    }
}
