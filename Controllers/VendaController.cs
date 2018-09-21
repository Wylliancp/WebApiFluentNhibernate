using Newtonsoft.Json;
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
    public class VendaController : ApiController
    {
        private VendaRepository vendaRepository = new VendaRepository();

        public Venda GetVenda(int id)
        {
            var retorno = JsonConvert.SerializeObject(vendaRepository.VendaId(id));
            Venda des = JsonConvert.DeserializeObject<Venda>(retorno);
            return des;
        }

        public IList<Venda> GetVendas()
        {
            var retorno = vendaRepository.Lista();
            return retorno;
        }

        public IHttpActionResult Post(Venda venda)
        {
            vendaRepository.GravarVenda(venda);
            return Ok();
        }

        public IHttpActionResult Put(Venda venda)
        {
            vendaRepository.GravarVenda(venda);
            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            vendaRepository.EliminarVenda(id);
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
