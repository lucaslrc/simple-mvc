using System;
using System.Linq;
using simple_mvc.Data;
using simple_mvc.Models;

namespace simple_mvc.Methods
{
    public class EditarDadosCliente
    {
        public string Editar(long ID, string Nome, string Cpf, DateTime DataNascimento, string Sexo, 
                                string Cep, string Endereco, string Numero, string Complemento, 
                                    string Bairro, string Estado, string Cidade)
        {
            if (string.IsNullOrEmpty(Nome) || Nome.Length < 3 || Cpf.Length != 11 || DataNascimento.ToString().Length < 7
                || string.IsNullOrEmpty(Sexo) || Cep.Length < 8 || string.IsNullOrEmpty(Endereco) || string.IsNullOrEmpty(Numero)
                || string.IsNullOrEmpty(Bairro) || string.IsNullOrEmpty(Estado) || string.IsNullOrEmpty(Cidade))
            {
                return "Todos os campos além do 'Complemento' precisam ser preenchidos corretamente.";
            }

            using (var db = new MvcContext())
            {
                var clienteExistente = db.Clientes.Where(x => x.ID == ID).FirstOrDefault();
                
                if (clienteExistente != null)
                {
                    if (db.Clientes.Where(x => x.Cep == Cep).FirstOrDefault() != null)
                    {
                        clienteExistente.Nome = Nome;
                        clienteExistente.DataNascimento = DataNascimento;
                        clienteExistente.Sexo = Sexo;

                        db.SaveChanges();

                        return "Dados atualizados com sucesso!";
                    }
                    else
                    {
                        clienteExistente.Nome = Nome;
                        clienteExistente.DataNascimento = DataNascimento;
                        clienteExistente.Sexo = Sexo;
                        clienteExistente.Cep = Cep;
                        clienteExistente.Endereco = Endereco;
                        clienteExistente.Numero = Numero;
                        clienteExistente.Bairro = Bairro;
                        clienteExistente.Estado = Estado;
                        clienteExistente.Cidade = Cidade;

                        db.SaveChanges();

                        return "Dados atualizados com sucesso!";
                    }
                }

                return "Não foi possível encontrar o cliente.";
            }
        }
    }
}