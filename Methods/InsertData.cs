using System;
using CadastroCliente.Data;
using CadastroCliente.Models;

namespace simple_mvc.Methods
{
    public class InsertData
    {
        public string Insert(String name)
        {
            using (var db = new MvcContext()) {
                db.Clientes.Add(new Cliente {
                    Nome = name
                });

                db.SaveChanges();
            }

            return "Operation insert success!";
        }
    }
}