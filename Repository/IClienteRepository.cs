using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiFluentNhibernate.Models;

namespace WebApiFluentNhibernate.Repository
{
    interface IClienteRepository 
    {

        IList<Cliente> Lista();
        Cliente ClienteId(int id);
        void GravarCliente(Cliente cliente);
        Cliente EliminarCliente(int id);

    }
}