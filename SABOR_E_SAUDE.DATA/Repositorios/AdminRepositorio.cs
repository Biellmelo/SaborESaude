using SABOR_E_SAUDE.DATA.Context;
using SABOR_E_SAUDE.DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SABOR_E_SAUDE.DATA.Repositorios
{
    public class AdminRepositorio
    {

        private SABOR_E_SAUDEContext db = new SABOR_E_SAUDEContext();

        public AdminRepositorio()
        {

        }

        public Administrador EfetuarLogin(string email, string senha)
        {
            return db.Administrador.Where(c => c.Email.Equals(email) && c.Senha.Equals(senha)).FirstOrDefault();
        }

    }
}
