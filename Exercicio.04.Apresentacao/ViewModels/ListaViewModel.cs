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
        public NavegarParaCarrinhoCommand NavegarParaCarrinho { get; private set; } = new NavegarParaCarrinhoCommand();

        #endregion comandos

        #region construtores

        public ListaViewModel(ObservableCollection<ProdutoModel> produtos)
        {
            Produtos = produtos;
        }

        #endregion construtores
    }
}