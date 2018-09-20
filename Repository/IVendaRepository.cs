using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiFluentNhibernate.Models;

namespace WebApiFluentNhibernate.Repository
{
    interface IVendaRepository
    {
        IList<Venda> Lista();
        Venda VendaId(int id);
        void GravarVenda(Venda venda);
        Venda EliminarVenda(int id);

    }
}