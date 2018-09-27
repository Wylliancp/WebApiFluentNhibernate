using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiFluentNhibernate.DTO
{
    public class ProdutoDTO
    {

        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataCadastro { get; set; }

        //[JsonIgnore]
        //public ICollection<VendaDTO> VendaDTO { get; set; }
    }
}