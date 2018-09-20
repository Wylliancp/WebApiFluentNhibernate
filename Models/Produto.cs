using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiFluentNhibernate.Models
{
    public class Produto
    {
        public virtual int ProdutoId { get; set; }
        public virtual string Nome { get; set; }
        public virtual int Quantidade { get; set; }
        public virtual DateTime DataCadastro { get; set; }

        [JsonIgnore]
        public virtual ICollection<Venda> Venda { get; set; }

    }
}