using System.Linq;
using simple_mvc.Models;
using System.Collections.Generic;
using simple_mvc.Data;

namespace simple_mvc.Methods
{
    public class ListarDadosCliente
    {
        public List<Cliente> Listar()
        {
            using (var db = new MvcContext())
            {
                var model = from clientes in db.Clientes
                    select new Cliente {
                        ID = clientes.ID,
                        Nome = clientes.Nome,
                        Cpf = clientes.Cpf,
                        DataNascimento = clientes.DataNascimento,
                        Sexo = clientes.Sexo,
                        Cep = clientes.Cep,
                        Endereco = clientes.Endereco,
                        Numero = clientes.Numero,
                        Complemento = clientes.Complemento,
                        Bairro = clientes.Bairro,
                        Estado = clientes.Estado,
                        Cidade = clientes.Cidade
                    };
                    return model.ToList();
            }
        }
    }
}