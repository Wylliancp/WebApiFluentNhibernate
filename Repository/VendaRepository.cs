using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiFluentNhibernate.Infra;
using WebApiFluentNhibernate.Models;

namespace WebApiFluentNhibernate.Repository
{
    public class VendaRepository : IVendaRepository
    {
        private DBContext context = new DBContext();
        public Venda EliminarVenda(int id)
        {
            try
            {
                var venda = VendaId(id);
                context.session.Delete(venda);
                context.transaction.Commit();
                return venda;
            }
            catch (Exception e)
            {
                context.transaction.Rollback();
                throw e;
            }
        }

        public void GravarVenda(Venda venda)
        {
            try
            {
                if (venda.VendaId == 0)
                {
                    context.session.Save(venda);
                    context.transaction.Commit();
                }
                else
                {
                    context.session.Update(venda);
                    context.transaction.Commit();
                }
            }
            catch (Exception e)
            {
                context.transaction.Rollback();
                throw e;
            }
        }

        public IList<Venda> Lista()
        {
            try
            {
                var vendas = context.session.Query<Venda>().ToList();
                return vendas;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Venda VendaId(int id)
        {
            try
            {
                var venda = context.session.Get<Venda>(id);
                return venda;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}