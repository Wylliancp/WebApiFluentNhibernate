using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiFluentNhibernate.Models;

namespace WebApiFluentNhibernate.Map
{
    public class ProdutoMap : ClassMap<Produto>
    {

        public ProdutoMap()
        {
            Id(x => x.ProdutoId).GeneratedBy.Identity();
            Map(x => x.Nome);
            Map(x => x.Quantidade);
            Map(x => x.DataCadastro).Column("DataRegistro");
            HasMany(x => x.Venda);
            Table("Produtos");
        }
    }
}