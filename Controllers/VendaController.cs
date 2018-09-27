using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiFluentNhibernate.DTO;
using WebApiFluentNhibernate.DTO.Resources;
using WebApiFluentNhibernate.Models;
using WebApiFluentNhibernate.Repository;

namespace WebApiFluentNhibernate.Controllers
{
    public class VendaController : ApiController
    {
        private VendaRepository vendaRepository = new VendaRepository();
       public IHttpActionResult GetVenda(int id)
        {
            var venda = vendaRepository.VendaId(id);

            VendaDTO n = venda.GetDTO();

            var retorno = JsonConvert.SerializeObject(n);
            VendaDTO vendar = JsonConvert.DeserializeObject<VendaDTO>(retorno);

            return Json(vendar);
        }

        public IList<VendaDTO> GetVendas()
        {


            var vendas = vendaRepository.Lista();
            IList<VendaDTO> ns = vendas.GetDTOs();
            
            var retorno = JsonConvert.SerializeObject(ns);
            IList<VendaDTO> vendass = JsonConvert.DeserializeObject<List<VendaDTO>>(retorno);
            return vendass;
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
