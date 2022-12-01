using Exercicio.Quatro.Apresentacao.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercicio._04.Testes
{
    [TestClass]
    public class PedidoModelTestes
    {
        private const string _criador = "Juliano Maciel";
        private const string _categoria = "Pedido";

        [TestMethod]
        [Owner(_criador)]
        [TestCategory(_categoria)]
        public void AdicionarProduto_Estoque_EsperadoException()
        {
            var produto = new ProdutoModel()
            {
                Descricao = "Luvas Cheter",
                Referencia = "Ref. 002322111",
                Cor = "Preto",
                Estoque = 0,
                Preco = 159.90m,
            };
            var pedido = new PedidoModel();

            Assert.ThrowsException<Exception>(() => pedido.AdicionarProduto(produto));
        }

        [TestMethod]
        [Owner(_criador)]
        [TestCategory(_categoria)]
        public void AdicionarProduto_Produto_EsperadoJaAdicionadoException()
        {
            var produto = new ProdutoModel()
            {
                Descricao = "Luvas Cheter",
                Referencia = "Ref. 002322111",
                Cor = "Preto",
                Estoque = 2,
                Preco = 159.90m,
            };
            var pedido = new PedidoModel();

            pedido.AdicionarProduto(produto);

            Assert.ThrowsException<Exception>(() => pedido.AdicionarProduto(produto));
        }

        [TestMethod]
        [Owner(_criador)]
        [TestCategory(_categoria)]
        public void AdicionarProduto_EsperadoSucesso()
        {
            try
            {
                var produto = new ProdutoModel()
                {
                    Descricao = "Luvas Cheter",
                    Referencia = "Ref. 002322111",
                    Cor = "Preto",
                    Estoque = 1,
                    Preco = 159.90m,
                };
                var pedido = new PedidoModel();

                pedido.AdicionarProduto(produto);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        [Owner(_criador)]
        [TestCategory(_categoria)]
        public void AdicionarQuantidade_Estoque_EsperadoException()
        {
            var produto = new ProdutoModel()
            {
                Descricao = "Luvas Cheter",
                Referencia = "Ref. 002322111",
                Cor = "Preto",
                Estoque = 1,
                Preco = 159.90m,
            };
            var pedido = new PedidoModel();

            pedido.AdicionarProduto(produto);

            Assert.ThrowsException<Exception>(() => pedido.AdicionarQuantidade(produto));
        }

        [TestMethod]
        [Owner(_criador)]
        [TestCategory(_categoria)]
        public void AdicionarQuantidade_Produto_EsperadoNaoEncontradoException()
        {
            var produto = new ProdutoModel()
            {
                Descricao = "Luvas Cheter",
                Referencia = "Ref. 002322111",
                Cor = "Preto",
                Estoque = 1,
                Preco = 159.90m,
            };
            var pedido = new PedidoModel();

            Assert.ThrowsException<Exception>(() => pedido.AdicionarQuantidade(produto));
        }

        [TestMethod]
        [Owner(_criador)]
        [TestCategory(_categoria)]
        public void RemoverProduto_Produto_EsperadoNaoEncontradoException()
        {
            var produto = new ProdutoModel()
            {
                Descricao = "Luvas Cheter",
                Referencia = "Ref. 002322111",
                Cor = "Preto",
                Estoque = 1,
                Preco = 159.90m,
            };
            var pedido = new PedidoModel();

            Assert.ThrowsException<Exception>(() => pedido.RemoverProduto(produto));
        }

        [TestMethod]
        [Owner(_criador)]
        [TestCategory(_categoria)]
        public void RemoverProduto_EsperadoSucesso()
        {
            try
            {
                var produto = new ProdutoModel()
                {
                    Descricao = "Luvas Cheter",
                    Referencia = "Ref. 002322111",
                    Cor = "Preto",
                    Estoque = 1,
                    Preco = 159.90m,
                };
                var pedido = new PedidoModel();

                pedido.AdicionarProduto(produto);
                pedido.RemoverProduto(produto);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        [Owner(_criador)]
        [TestCategory(_categoria)]
        public void RemoverQuantidade_Produto_EsperadoNaoEncontradoException()
        {
            var produto = new ProdutoModel()
            {
                Descricao = "Luvas Cheter",
                Referencia = "Ref. 002322111",
                Cor = "Preto",
                Estoque = 1,
                Preco = 159.90m,
            };
            var pedido = new PedidoModel();

            Assert.ThrowsException<Exception>(() => pedido.RemoverQuantidade(produto));
        }

        [TestMethod]
        [Owner(_criador)]
        [TestCategory(_categoria)]
        public void RemoverQuantidade_Produto_EsperadoSemQuantidadeException()
        {
            var produto = new ProdutoModel()
            {
                Descricao = "Luvas Cheter",
                Referencia = "Ref. 002322111",
                Cor = "Preto",
                Estoque = 1,
                Preco = 159.90m,
            };
            var pedido = new PedidoModel();

            pedido.AdicionarProduto(produto);
            pedido.RemoverQuantidade(produto);

            Assert.ThrowsException<Exception>(() => pedido.RemoverQuantidade(produto));
        }

        [TestMethod]
        [Owner(_criador)]
        [TestCategory(_categoria)]
        public void RemoverQuantidade_Produto_EsperadoSucesso()
        {
            try
            {
                var produto = new ProdutoModel()
                {
                    Descricao = "Luvas Cheter",
                    Referencia = "Ref. 002322111",
                    Cor = "Preto",
                    Estoque = 1,
                    Preco = 159.90m,
                };
                var pedido = new PedidoModel();

                pedido.AdicionarProduto(produto);
                pedido.RemoverQuantidade(produto);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}