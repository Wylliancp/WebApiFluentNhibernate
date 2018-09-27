using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiFluentNhibernate.DTO
{
    public class ClienteDTO
    {

        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }

        //[JsonIgnore]
        //public ICollection<VendaDTO> VendaDTO { get; set; }
    }
}