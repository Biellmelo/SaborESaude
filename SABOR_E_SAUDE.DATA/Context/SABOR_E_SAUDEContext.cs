using SABOR_E_SAUDE.DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SABOR_E_SAUDE.DATA.Context
{
    public class SABOR_E_SAUDEContext : DbContext
    {
        public SABOR_E_SAUDEContext()
                :base("DefaultConnection")
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Administrador> Administrador { get; set; }
        public DbSet<Carrinho> Carrinho { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<ItemCarrinho> ItensCarrinhoss { get; set; }
        public DbSet<Promocao> Promocoes { get; set; }

    }
}
