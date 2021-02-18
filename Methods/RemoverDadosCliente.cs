using System;
using System.Linq;
using CadastroCliente.Data;

namespace simple_mvc.Methods
{
    public class RemoverDadosCliente
    {
        public string Remover(long ID)
        {
            using (var db = new MvcContext())
            {
                try
                {
                    var existingId = db.Clientes.Where(x => x.ID == ID);

                    if (existingId != null)
                    {
                        db.Clientes.Remove(existingId.FirstOrDefault());
                        db.SaveChanges();
                    }

                    return "Cliente removido com sucesso!";
                }
                catch
                {
                    return "Error ao remover cliente, tente novamente.";
                }
            }
        }
    }
}