using System;
using System.Linq;
using simple_mvc.Data;
using simple_mvc.Models;

namespace simple_mvc.Methods
{
    public class InserirDadosCliente
    {
        public string Inserir(string Nome, string Cpf, DateTime DataNascimento, string Sexo, 
                                string Cep, string Endereco, string Numero, string Complemento, 
                                    string Bairro, string Estado, string Cidade)
        {
            if (string.IsNullOrEmpty(Nome) || Nome.Length < 3 || Cpf.Length != 11 || DataNascimento.ToString().Length < 7
                || string.IsNullOrEmpty(Sexo) || Cep.Length < 8 || string.IsNullOrEmpty(Endereco) || string.IsNullOrEmpty(Numero)
                || string.IsNullOrEmpty(Bairro) || string.IsNullOrEmpty(Estado) || string.IsNullOrEmpty(Cidade))
            {
                return "Todos os campos além do 'Complemento' precisam ser preenchidos corretamente.";
            }

            using (var db = new MvcContext()) {

                try 
                {
                    var existingUser = db.Clientes.Any(x => x.Cpf == Cpf);
                    
                    if (existingUser)
                    {
                        return "CPF já está em uso, por favor tente utilizando outro.";    
                    }

                    db.Clientes.Add(new Cliente {
                        Nome = Nome,
                        Cpf = Cpf,
                        DataNascimento = DataNascimento,
                        Sexo = Sexo,
                        Cep = Cep,
                        Endereco = Endereco,
                        Numero = Numero,
                        Complemento = Complemento,
                        Bairro = Bairro,
                        Estado = Estado,
                        Cidade = Cidade
                    });

                    db.SaveChanges();
                }
                catch
                {
                    return "Erro ao inserir dados!";
                }
            }

            return "Dados inseridos com sucesso!";
        }
    }
}