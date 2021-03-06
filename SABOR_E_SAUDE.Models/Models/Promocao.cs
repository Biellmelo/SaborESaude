﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SABOR_E_SAUDE.DOMAIN.Models
{

    [Table("Promocoes")]
    public class Promocao
    {

        public Promocao()
        {
            IdPromocao = Guid.NewGuid();
        }

        [Key]
        public Guid IdPromocao { get; set; }

        [Required]
        public Guid ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }

        public DateTime DataExpira { get; set; }


    }
}