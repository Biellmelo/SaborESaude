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

        [DataType(DataType.Date)]
        [Required]
        public DateTime DataCadastro { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime DataDaCompra { get; set; }

        [Required]
        public int StatusId { get; set; }

        [Required]
        public decimal ValorTotal { get; set; }

        [Required]
        public Guid ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }

        [Required]
        public Guid EnderecoId { get; set; }
        public virtual Endereco Endereco { get; set; }

        public virtual List<ItemCarrinho> ItemCarrinho { get; set; }
    }
}