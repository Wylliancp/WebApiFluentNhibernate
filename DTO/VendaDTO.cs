using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiFluentNhibernate.Models;

namespace WebApiFluentNhibernate.DTO
{
    public class VendaDTO
    {
        public int VendaId { get; set; }
        public DateTime DataCadastro { get; set; }
        public decimal Preco { get; set; }
        public int FlgAtivo { get; set; }
        public ProdutoDTO ProdutoDTO { get; set; }
        public ClienteDTO ClienteDTO { get; set; }
    }
}