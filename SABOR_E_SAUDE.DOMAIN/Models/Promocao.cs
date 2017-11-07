using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SABOR_E_SAUDE.DOMAIN.Models
{
    public class Promocao
    {
        public Guid IdPromocao { get; set; }

        public virtual Guid ProdutoId { get; set; }

        public DateTime Data { get; set; }


    }
}
