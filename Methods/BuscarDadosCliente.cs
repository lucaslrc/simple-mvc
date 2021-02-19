using System;
using System.Linq;
using simple_mvc.Data;
using simple_mvc.Models;

namespace simple_mvc.Methods
{
    public class BuscarDadosCliente
    {
        public Cliente Buscar(long ID)
        {
            using (var db = new MvcContext())
            {
                return db.Clientes.Where(x => x.ID == ID).FirstOrDefault();
            }
        }
    }
}