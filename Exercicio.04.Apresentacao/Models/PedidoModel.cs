using Exercicio.Quatro.Apresentacao.Classes;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Exercicio.Quatro.Apresentacao.Models
{
    public class PedidoModel : AbstractModel
    {
        #region variaveis privadas

        private decimal _total = 0.00m;
        private ObservableCollection<ProdutoModel> _produtos = new ObservableCollection<ProdutoModel>();

        #endregion variaveis privadas

        #region propriedades

        public decimal Total
        {
            get => _total;
            set => SetField(ref _total, value);
        }

        public ObservableCollection<ProdutoModel> Produtos
        {
            get => _produtos;
            set => SetField(ref _produtos, value);
        }

        #endregion propriedades

        #region metodos

        public void AdicionarProduto(ProdutoModel produto)
        {
            if (produto.Estoque <= 0)
                throw new Exception("Produto sem estoque. Tente novamente mais tarde.");

            if (Produtos.Contains(produto))
                throw new Exception("Produto já adicionado ao carrinho!");

            produto.Estoque -= 1;
            produto.Quantidade += 1;

            Produtos.Add(produto);
            Totalizar();
        }

        public void AdicionarQuantidade(ProdutoModel produto)
        {
            if (produto.Estoque <= 0)
                throw new Exception("Produto sem estoque. Tente novamente mais tarde.");

            if (!Produtos.Contains(produto))
                throw new Exception("Produto não pertence ao carrinho!");

            var item = Produtos.FirstOrDefault(x => x.Referencia == produto.Referencia);

            item.Estoque -= 1;
            item.Quantidade += 1;

            Totalizar();
        }

        public void RemoverProduto(ProdutoModel produto)
        {
            if (!Produtos.Contains(produto))
                throw new Exception("Produto não pertence ao carrinho!");

            produto.Estoque += produto.Quantidade;
            produto.Quantidade = 0;

            Produtos.Remove(produto);
            Totalizar();
        }

        public void RemoverQuantidade(ProdutoModel produto)
        {
            if (!Produtos.Contains(produto))
                throw new Exception("Produto não pertence ao carrinho!");

            var item = Produtos.FirstOrDefault(x => x.Referencia == produto.Referencia);

            if (item.Quantidade <= 0)
                throw new Exception("Produto sem quantidade.");

            item.Estoque += 1;
            item.Quantidade -= 1;

            Totalizar();
        }

        private void Totalizar()
        {
            Total = 0.0m;

            foreach (var produto in Produtos.Where(x => x.Quantidade > 0))
                Total += produto.Preco * produto.Quantidade;
        }

        #endregion metodos
    }
}