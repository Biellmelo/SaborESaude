using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SABOR_E_SAUDE.DOMAIN.Models
{
    public class ItemCarrinho
    {
        public ItemCarrinho()
        {
            ItemCarrinhoID = Guid.NewGuid();
        }

        // PK DE ITENS CARRINHO.
        [Key]
        public Guid ItemCarrinhoID { get; set; }

        // FK DE CARRINHO
        public virtual Guid CarrinhoID { get; set; }

        // FK DE PRODUTOS
        public virtual Guid ProdutoId { get; set; }

        //QUANTIDADE DE PRODUTO
        public int Quantidade { get; set; }



    }
}
