using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SABOR_E_SAUDE.Models.Models
{
    public class Cliente
    {
        public Cliente()
        {
            ClienteId = Guid.NewGuid();
        }
        [Key]
        public Guid ClienteId { get; set; }


        //Nome
        [Required(ErrorMessage = "Favor, precisamos saber qual é o seu nome!.")]
        [StringLength(50, MinimumLength = 5)]
        [Display(Name = "* Nome")]
        public string Nome { get; set; }


        //CPF
        [Required(ErrorMessage = "CPF na nota é dinheiro de volta, preencha este campo.")]
        [StringLength(11, MinimumLength = 11)]
        [Display(Name = "* CPF:")]
        [DisplayFormat(DataFormatString = "999.999.999.99")]
        public string CPF { get; set; }


        //E-mail
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Qual é o seu E-mail??")]
        [StringLength(50, MinimumLength = 10)]
        [Display(Name = "* E-mail:")]
        public string Email { get; set; }


        //Senha
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Recomendamos hahaha (minimo 8, maximo 10)")]
        [StringLength(20, MinimumLength = 8)]
        [Display(Name = "* Senha:")]
        public string Senha { get; set; }

        // Confirmação de Senha
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Precisos ter certeza de que você realmente sabe sua senha!")]
        [StringLength(20, MinimumLength = 8)]
        [Display(Name = "* Confirmar Senha:")]
        public string ConfirmaSenha { get; set; }


        //Data De Cadastro
        [DataType(DataType.Date)]
        public DateTime DataCadastro { get; set; }


        //Permissões de Usuario
        public string Permissao { get; set; }



        // REFERENCIAS DE TABELAS
        public virtual List<Endereco> Enderecos { get; set; }
        public virtual List<Carrinho> CarrinhoID { get; set; }
        public virtual List<Comentario> Comentario { get; set; }
    }
}
