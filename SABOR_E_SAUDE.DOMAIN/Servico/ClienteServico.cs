using SABOR_E_SAUDE.DATA.Repositorios;
using SABOR_E_SAUDE.DOMAIN.Models;
using SABOR_E_SAUDE.Util.Seguranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SABOR_E_SAUDE.DOMAIN.Servico
{
    public class ClienteServico
    {
        public ClienteServico()
        {

        }

        public Cliente EfetuarLogin(string email, string senha)
        {
            ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
            Cliente cliente = clienteRepositorio.EfetuarLogin(email, Criptografia.GetMD5Hash(senha));

            return cliente;
        }

        public void InserirCliente(Cliente cliente)
        {
            ClienteRepositorio cr = new ClienteRepositorio();
            cliente.Senha = Criptografia.GetMD5Hash(cliente.Senha);
            cr.InserirCliente(cliente);
        }
    }
}
