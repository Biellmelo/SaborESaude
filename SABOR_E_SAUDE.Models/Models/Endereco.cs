using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SABOR_E_SAUDE.Models.Models
{
    [Table("Enderecos")]
    public class Endereco
    {
        public Endereco()
        {
            EnderecoId = Guid.NewGuid();
        }

        [Required(ErrorMessage = "Recomendamos hahaha (minimo 8, maximo 10)")]
        [Display(Name = "CEP")]
        public string Cep { get; set; }

        // [Key]
        public Guid EnderecoId { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string Bairro { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public Guid ClienteId { get; set; }
    }
}
