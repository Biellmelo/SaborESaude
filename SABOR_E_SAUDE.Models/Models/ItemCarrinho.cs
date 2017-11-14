using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SABOR_E_SAUDE.DOMAIN.Models
{
    [Table("ItensCarrinho")]
    public class ItemCarrinho
    {
        public ItemCarrinho()
        {
            ItemCarrinhoID = Guid.NewGuid();
        }
    
        [Key]
        public Guid ItemCarrinhoID { get; set; }

        public int Quantidade { get; set; }

        [Required]
        public Guid CarrinhoID { get; set; }
        public virtual Carrinho Carrinho { get; set; }

        [Required]
        public Guid ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }


    }
}
