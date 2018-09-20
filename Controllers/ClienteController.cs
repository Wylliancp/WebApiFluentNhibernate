﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiFluentNhibernate.Models;
using WebApiFluentNhibernate.Repository;

namespace WebApiFluentNhibernate.Controllers
{
    public class ClienteController : ApiController
    {
        private readonly ClienteRepository clienteRepository = new ClienteRepository();


        public Cliente GetCliente(int id)
        {
            var cliente = clienteRepository.ClienteId(id);
            return cliente;
        }

        public IList<Cliente> GetClientes()
        {
            var clientes = clienteRepository.Lista();
            return clientes;
        }
    }
}