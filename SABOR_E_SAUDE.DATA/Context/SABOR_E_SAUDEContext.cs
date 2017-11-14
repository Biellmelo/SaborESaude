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
       // public DbSet<Carrinho> Carrinho { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
       // public DbSet<ItemCarrinho> ItensCarrinhoss { get; set; }
        public DbSet<Promocao> Promocoes { get; set; }


        public override int SaveChanges()
        {
            //Faz um foreach na classe e verifica qual classe possui uma propriedade.
            //chamada DataCadastro.
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataDeCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {//Se estou adicionando no banco, a DataCadastro recebe DateTime.Now
                    entry.Property("DataDeCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataDeCadastro").IsModified = false;
                }
            }

            return base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Toda string no meu sistema vai ser varchar no banco
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            //quando uma string não tiver maxlength, ela terá um maxlength no banco de 100
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

            base.OnModelCreating(modelBuilder);
        }
    }
}
