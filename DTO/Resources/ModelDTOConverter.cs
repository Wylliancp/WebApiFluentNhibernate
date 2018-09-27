using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiFluentNhibernate.Models;

namespace WebApiFluentNhibernate.DTO.Resources
{
    public static class ModelDTOConverter
    {

        public static Cliente GetModel(this ClienteDTO clienteDTO)
        {
            Cliente cliente = new Cliente()
            {
                ClienteId = clienteDTO.ClienteId,
                Cpf = clienteDTO.Cpf,
                Nome = clienteDTO.Nome,
                DataNascimento = clienteDTO.DataNascimento,
            };
            return cliente;
        }

        public static ClienteDTO GetDTO(this Cliente cliente)
        {
            ClienteDTO clienteDTO = new ClienteDTO()
            {
                ClienteId = cliente.ClienteId,
                Cpf = cliente.Cpf,
                Nome = cliente.Nome,
                DataNascimento = cliente.DataNascimento,
            };
            return clienteDTO;
        }

        public static Produto GetModel(this ProdutoDTO produtoDTO)
        {
            Produto produto = new Produto()
            {
                ProdutoId = produtoDTO.ProdutoId,
                DataCadastro = produtoDTO.DataCadastro,
                Nome = produtoDTO.Nome,
                Quantidade = produtoDTO.Quantidade
            };
            return produto;
        }

        public static ProdutoDTO GetDTO(this Produto produto)
        {
            ProdutoDTO produtoDTO = new ProdutoDTO()
            {
                ProdutoId = produto.ProdutoId,
                Nome = produto.Nome,
                Quantidade = produto.Quantidade,
                DataCadastro = produto.DataCadastro,
            };
            return produtoDTO;
        }

        public static VendaDTO GetDTO(this Venda obj)
        {
            VendaDTO dto = new VendaDTO()
            {
                VendaId = obj.VendaId,
                Preco = obj.Preco,
                DataCadastro = obj.DataCadastro,
                FlgAtivo = obj.FlgAtivo,
                ClienteDTO = obj.Cliente.GetDTO(),
                ProdutoDTO = obj.Produto.GetDTO()
            };
            return dto;
        }

        public static Venda GetModel(this VendaDTO vendaDTO)
        {
            Venda venda = new Venda()
            {
                VendaId = vendaDTO.VendaId,
                Preco = vendaDTO.Preco,
                DataCadastro = vendaDTO.DataCadastro,
                FlgAtivo = vendaDTO.FlgAtivo,
                Cliente = vendaDTO.ClienteDTO.GetModel(),
                Produto = vendaDTO.ProdutoDTO.GetModel()
            };
            return venda;
        }
    }
}