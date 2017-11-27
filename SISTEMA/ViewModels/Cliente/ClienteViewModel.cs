using SABOR_E_SAUDE.DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SISTEMA.ViewModels.Cliente
{
    public class ClienteViewModel
    {
        public ClienteViewModel()
        {
            ClienteId = Guid.NewGuid();
        }

        [Key]
        public Guid ClienteId { get; set; }


        //Nome
        [Required(ErrorMessage = "Favor, precisamos saber qual é o seu nome!.")]
        [StringLength(50, MinimumLength = 5)]
        [Display(Name = "* Nome")]
        [Column(TypeName = "varchar")]
        public string Nome { get; set; }

        //E-mail
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Qual é o seu E-mail??")]
        [StringLength(50, MinimumLength = 10)]
        [Display(Name = "* E-mail:")]
        [Column(TypeName = "varchar")]
        public string Email { get; set; }

        //DATA DE NASCIMENTO
        [DataType(DataType.Date)]
        [Required]
        public DateTime DataNascimento { get; set; }

        //Permissões de Usuario
        public string Permissao { get; set; }

        [Required]
        public bool Ativo { get; set; }

        [Required]
        public bool Excluido { get; set; }

        //Senha
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Recomendamos hahaha (minimo 8, maximo 10)")]
        [StringLength(20, MinimumLength = 8)]
        [Display(Name = "* Senha:")]
        [Column(TypeName = "varchar")]
        public string Senha { get; set; }

        //Senha
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "senhas não coincidem")]
        [StringLength(20, MinimumLength = 8)]
        [Display(Name = "* Confirmação de Senha:")]
        [Compare("Senha", ErrorMessage = "As senhas não conferes")]
        public string ConfirmaSenha { get; set; }

        //CPF
        [Required(ErrorMessage = "CPF na nota é dinheiro de volta, preencha este campo.")]
        [StringLength(11, MinimumLength = 11)]
        [Display(Name = "* CPF:")]
        public string CPF { get; set; }

        //Data De Cadastro
        [DataType(DataType.Date)]
        [Required]
        public DateTime DataCadastro { get; set; }

    }
}