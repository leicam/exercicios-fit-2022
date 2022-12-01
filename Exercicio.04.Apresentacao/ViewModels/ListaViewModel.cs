using Exercicio.Quatro.Apresentacao.Classes;
using Exercicio.Quatro.Apresentacao.Commands;
using Exercicio.Quatro.Apresentacao.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace Exercicio.Quatro.Apresentacao.ViewModels
{
    public class ListaViewModel : AbstractViewModel
    {
        #region variaveis privadas

        private PedidoModel _pedido = new PedidoModel();
        private ProdutoModel _produtoSelecionado = new ProdutoModel();
        private ObservableCollection<ProdutoModel> _produtos = new ObservableCollection<ProdutoModel>();

        #endregion variaveis privadas

        #region propriedades

        public PedidoModel Pedido
        {
            get => _pedido;
            set => SetField(ref _pedido, value);
        }

        public ProdutoModel ProdutoSelecionado
        {
            get => _produtoSelecionado;
            set => SetField(ref _produtoSelecionado, value);
        }

        public ObservableCollection<ProdutoModel> Produtos
        {
            get => _produtos;
            set => SetField(ref _produtos, value);
        }

        #endregion propriedades

        #region comandos

        public AdicionarProdutoCarrinhoCommand AdicionarProdutoCarrinho { get; private set; } = new AdicionarProdutoCarrinhoCommand();

        #endregion comandos

        #region construtores

        public ListaViewModel()
        {
            CarregarProdutos();
        }

        #endregion construtores

        #region metodos

        private void CarregarProdutos()
        {
            Produtos.Add(new ProdutoModel()
            {
                Imagem = new BitmapImage(new Uri(@"../net5.0-windows/Resources/Images/p1.png", UriKind.Relative)),
                Descricao = "Luvas Cheter",
                Referencia = "Ref. 002322111",
                Cor = "Preto",
                Estoque = 10,
                Preco = 159.90m,
            });

            Produtos.Add(new ProdutoModel()
            {
                Imagem = new BitmapImage(new Uri(@"../net5.0-windows/Resources/Images/p2.png", UriKind.Relative)),
                Descricao = "Sapato Matric",
                Referencia = "Ref. 006542123",
                Cor = "Verde",
                Estoque = 10,
                Preco = 399.90m,
            });

            Produtos.Add(new ProdutoModel()
            {
                Imagem = new BitmapImage(new Uri(@"../net5.0-windows/Resources/Images/p3.png", UriKind.Relative)),
                Descricao = "Meias Patizen",
                Referencia = "Ref. 001289258",
                Cor = "Creme",
                Estoque = 0,
                Preco = 29.90m,
            });

            Produtos.Add(new ProdutoModel()
            {
                Imagem = new BitmapImage(new Uri(@"../net5.0-windows/Resources/Images/p4.png", UriKind.Relative)),
                Descricao = "Camiseta Beni",
                Referencia = "Ref. 007197660",
                Cor = "Preto",
                Estoque = 10,
                Preco = 89.90m,
            });
        }

        #endregion metodos
    }
}