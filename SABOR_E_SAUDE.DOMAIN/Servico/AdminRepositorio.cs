using SABOR_E_SAUDE.DOMAIN.Models;
using SABOR_E_SAUDE.Util.Seguranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SABOR_E_SAUDE.DOMAIN.Servico
{
    public class AdminRepositorio
    {

        public Administrador EfetuarLogin(string email, string senha)
        {
            AdminRepositorio adminRepositorio = new AdminRepositorio();
            Administrador administrador = adminRepositorio.EfetuarLogin(email, Criptografia.GetMD5Hash(senha));

            return administrador;
        }
    }
}
