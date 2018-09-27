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

        public static IList<ClienteDTO> GetDTOs(this IList<Cliente> obj)
        {
            List<ClienteDTO> resultado = new List<ClienteDTO>();

            foreach (var item in obj)
            {
                ClienteDTO cliente = new ClienteDTO();
                cliente.ClienteId = item.ClienteId;
                cliente.Cpf = item.Cpf;
                cliente.DataNascimento = item.DataNascimento;
                cliente.Nome = item.Nome;
                resultado.Add(cliente);
            }
            return resultado;
        }

        public static IList<Cliente> GetModels(this IList<ClienteDTO> obj)
        {
            List<Cliente> resultado = new List<Cliente>();
            foreach (var item in obj)
            {
                Cliente cliente = new Cliente()
                {
                    ClienteId = item.ClienteId,
                    Nome = item.Nome,
                    DataNascimento = item.DataNascimento,
                    Cpf = item.Cpf,
                };
                resultado.Add(cliente);
            }
            return resultado;
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

        public static IList<ProdutoDTO> GetDTOs(this IList<Produto> obj)
        {
            List<ProdutoDTO> resultado = new List<ProdutoDTO>();

            foreach (var item in obj)
            {
                ProdutoDTO produto = new ProdutoDTO();
                produto.ProdutoId = item.ProdutoId;
                produto.Nome = item.Nome;
                produto.DataCadastro = item.DataCadastro;
                produto.Quantidade = item.Quantidade;
                resultado.Add(produto);
            }
            return resultado;
        }

        public static IList<Produto> GetModels(this IList<ProdutoDTO> obj)
        {
            List<Produto> resultado = new List<Produto>();
            foreach (var item in obj)
            {
                Produto produto = new Produto()
                {
                    ProdutoId = item.ProdutoId,
                    Nome = item.Nome,
                    DataCadastro = item.DataCadastro,
                    Quantidade = item.Quantidade,
                };
                resultado.Add(produto);
            }
            return resultado;
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

        public static IList<VendaDTO> GetDTOs(this IList<Venda> obj)
        {
            List<VendaDTO> resultado = new List<VendaDTO>();

            foreach (var item in obj)
            {
                VendaDTO venda = new VendaDTO();
                venda.VendaId = item.VendaId;
                venda.Preco = item.Preco;
                venda.DataCadastro = item.DataCadastro;
                venda.FlgAtivo = item.FlgAtivo;
                venda.ClienteDTO = item.Cliente.GetDTO();
                venda.ProdutoDTO = item.Produto.GetDTO();
                resultado.Add(venda);
            }
            return resultado;
        }

        public static IList<Venda> GetModels(this IList<VendaDTO> obj)
        {
            List<Venda> resultado = new List<Venda>();
            foreach (var item in obj)
            {
                Venda venda = new Venda()
                {
                    VendaId = item.VendaId,
                    Preco = item.Preco,
                    DataCadastro = item.DataCadastro,
                    FlgAtivo = item.FlgAtivo,
                    Cliente = item.ClienteDTO.GetModel(),
                    Produto = item.ProdutoDTO.GetModel()
                };
                resultado.Add(venda);
            }
            return resultado;
        }
    }
}