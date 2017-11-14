using SABOR_E_SAUDE.DATA.Context;
using SABOR_E_SAUDE.DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SABOR_E_SAUDE.DATA.Repositorios
{
    public class ClienteRepositorio
    {
        private SABOR_E_SAUDEContext db = new SABOR_E_SAUDEContext();

        public ClienteRepositorio()
        {

        }

        public Cliente EfetuarLogin(string email, string senha)
        {
            return db.Clientes.Where(c => c.Email.Equals(email) && c.Senha.Equals(senha)).FirstOrDefault();
        }

        public Cliente EfetuarLogin(string email, object criptografia, string senha )
        {
            throw new NotImplementedException();
        }

        public void InserirCliente(Cliente cliente)
        {
            db.Clientes.Add(cliente);
            db.SaveChanges();
        }

    }

   
}
