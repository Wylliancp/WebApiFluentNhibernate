using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiFluentNhibernate.Models;

namespace WebApiFluentNhibernate.Map
{
    public class VendaMap : ClassMap<Venda>
    {

        public VendaMap()
        {
            Id(x => x.VendaId).GeneratedBy.Identity();
            Map(x => x.Preco);
            Map(x => x.DataCadastro).Column("DataRegistro");
            Map(x => x.FlgAtivo);
            References(x => x.Cliente).Column("ClienteId");
            References(x => x.Produto).Column("ProdutoId");
            Table("Venda");
        }
    }
}