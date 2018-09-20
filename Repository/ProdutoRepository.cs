using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiFluentNhibernate.Infra;
using WebApiFluentNhibernate.Models;

namespace WebApiFluentNhibernate.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private DBContext context = new DBContext();

        public Produto EliminarProduto(int id)
        {
            try
            {
                var produto = ProdutoId(id);
                context.session.Delete(produto);
                context.transaction.Commit();
                return produto;
            }
            catch (Exception e)
            {
                context.transaction.Rollback();
                throw e;
            }
        }

        public void GravarProduto(Produto produto)
        {
            try
            {
                if (produto.ProdutoId == 0)
                {
                    context.session.Save(produto);
                    context.transaction.Commit();
                }
                else
                {
                    context.session.Update(produto);
                    context.transaction.Commit();
                }
            }
            catch (Exception e)
            {
                context.transaction.Rollback();
                throw e;
            }
        }

        public IList<Produto> Lista()
        {
            try
            {
                var clientes = context.session.Query<Produto>().ToList();
                return clientes;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Produto ProdutoId(int id)
        {
            try
            {
                var produto = context.session.Get<Produto>(id);
                return produto;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}