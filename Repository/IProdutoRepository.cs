using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiFluentNhibernate.Models;

namespace WebApiFluentNhibernate.Repository
{
    interface IProdutoRepository
    {
        IList<Produto> Lista();
        Produto ProdutoId(int id);
        void GravarProduto(Produto produto);
        Produto EliminarProduto(int id);

    }
}