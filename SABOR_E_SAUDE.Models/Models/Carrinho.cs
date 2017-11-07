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
    public class Carrinho
    {
        public Carrinho()
        {
            CarrinhoID = Guid.NewGuid();
        }

        [Key]
        public Guid CarrinhoID { get; set; }

        public Decimal ValorTotal { get; set; }

        //Registro Horario Da Venda
        public DateTime DataVenda { get; set; }


        // FK PARA ITEM CARRINHO
        public virtual List<ItemCarrinho> ItemCarrinhoID { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual ItemCarrinho ItemCarrinhoId { get; set; }
        public Guid ClienteId { get; set; }
        





    }
}
