using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiFluentNhibernate.Models;
using WebApiFluentNhibernate.Repository;

namespace WebApiFluentNhibernate.Controllers
{
    public class ProdutoController : ApiController
    {

        private ProdutoRepository repository = new ProdutoRepository();

        public Produto GetCliente(int id)
        {
            var retorno = repository.ProdutoId(id);
            return retorno;
        }

        public IList<Produto> GetClientes()
        {
            var retorno = repository.Lista();
            return retorno;
        }

        public IHttpActionResult Post(Produto produto)
        {
            repository.GravarProduto(produto);
            return Ok();
        }

        public IHttpActionResult Put(Produto produto)
        {
            repository.GravarProduto(produto);
            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            repository.EliminarProduto(id);
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
