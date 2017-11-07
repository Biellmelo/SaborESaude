using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SABOR_E_SAUDE.Models.Models
{
    [Table("Promocoes")]
    public class Promocao
    {
        public Guid IdPromocao { get; set; }

        public virtual Guid ProdutoId { get; set; }

        public DateTime Data { get; set; }
    }
}
