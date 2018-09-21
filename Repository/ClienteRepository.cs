using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiFluentNhibernate.Infra;
using WebApiFluentNhibernate.Models;

namespace WebApiFluentNhibernate.Repository
{
    public class ClienteRepository : IClienteRepository
    {

        public Cliente ClienteId(int id)
        {
            try
            {
                using (var context = new DBContext())
                {
                    var cliente = context.session.Get<Cliente>(id);
                    return cliente;
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Cliente EliminarCliente(int id)
        {
            try
            {
                using (var context = new DBContext())
                {
                    var cliente = context.session.Get<Cliente>(id);
                    context.session.Delete(cliente);
                    context.transaction.Commit();
                    return cliente;
                }
            }
            catch (Exception e)
            {
                throw e;
                
            }
        }

        public void GravarCliente(Cliente cliente)
        {
            try
            {
                using (var context = new DBContext())
               {
                    if (cliente.ClienteId == 0)
                    {
                        context.session.Save(cliente);
                        context.transaction.Commit();
                    }
                    else
                    {
                        context.session.Update(cliente);
                        context.transaction.Commit();
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IList<Cliente> Lista()
        {
            try
            {
                using (var context = new DBContext())
                {
                    var clientes = context.session.Query<Cliente>().ToList();
                    return clientes;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}