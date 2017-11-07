using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SABOR_E_SAUDE.DOMAIN.Models
{
    [Table("Produtos")]
    public class Produto
    {
        public Produto()
        {
            ProdutoId = Guid.NewGuid();
        }

        // PK DE PRODUTO
        [Key]
        public Guid ProdutoId { get; set; }


        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Nome { get; set; }

        [Required]
        public decimal Preco { get; set; }

        [Required]
        public int Quantidade { get; set; }

        
        // FKS PARA OUTRAS CLASSES
        [Required]
        public Guid CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }

        //
        public virtual List<ItemCarrinho> ItemCarrinho { get; set; }

    }
}
