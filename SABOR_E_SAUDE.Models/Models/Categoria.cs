using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SABOR_E_SAUDE.Models.Models
{
    [Table("Categorias")]
    public class Categoria
    {

        public Categoria()
        {
            CategoriaId = Guid.NewGuid();
        }

        [Key]
        public Guid CategoriaId { get; set; }

        [Required(ErrorMessage = "Por Favor, digite o nome para esta nova Categoria.")]
        [StringLength(20)]
        public string NomeCategoria { get; set; }

        public virtual List<Produto> Produtos { get; set; }
    }
}
