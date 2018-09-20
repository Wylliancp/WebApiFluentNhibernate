using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiFluentNhibernate.Models;

namespace WebApiFluentNhibernate.Map
{
    public class ClienteMap : ClassMap<Cliente>
    {
        public ClienteMap()
        {
            Id(x => x.ClienteId).GeneratedBy.Identity();
            Map(x => x.Nome).Column("Nome");
            Map(x => x.Cpf);
            Map(x => x.DataNascimento).Column("DataNasc");
            HasMany(x => x.Venda);
            Table("Clientes");
        }
    }
}