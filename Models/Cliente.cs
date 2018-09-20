using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiFluentNhibernate.Models
{
    public class Cliente
    {
        public virtual int ClienteId { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Cpf { get; set; }
        public virtual DateTime DataNascimento { get; set; }

        public virtual ICollection<Venda> Venda { get; set; }

    }
}