using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiFluentNhibernate.Models
{
    
    public class Venda
    {
        public virtual int VendaId { get; set; }
        public virtual DateTime DataCadastro { get; set; }
        public virtual decimal Preco { get; set; }
        public virtual int FlgAtivo { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}