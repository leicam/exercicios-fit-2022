using Exercicio.Quatro.Apresentacao.Classes;
using Exercicio.Quatro.Apresentacao.Commands;
using Exercicio.Quatro.Apresentacao.Models;

namespace Exercicio.Quatro.Apresentacao.ViewModels
{
    public class CarrinhoViewModel : AbstractViewModel
    {
        #region variaveis privadas

        private CartaoModel _cartao = new CartaoModel();
        private PedidoModel _pedido = new PedidoModel();
        private ProdutoModel _produtoSelecionado = new ProdutoModel();

        #endregion variaveis privadas

        #region propriedades

        public CartaoModel Cartao 
        { 
            get => _cartao;
            set => SetField(ref _cartao, value);
        }

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

        #endregion propriedades

        #region comandos

        public AdicionarQuantidadeProdutoSelecionadoCommand AdicionarQuantidadeProdutoSelecionado { get; private set; } = new AdicionarQuantidadeProdutoSelecionadoCommand();
        public RemoverQuantidadeProdutoSelecionadoCommand RemoverQuantidadeProdutoSelecionado { get; private set; } = new RemoverQuantidadeProdutoSelecionadoCommand();
        public RemoverProdutoSelecionadoCommand RemoverProdutoSelecionado { get; private set; } = new RemoverProdutoSelecionadoCommand();
        public FinalizarPedidoCommand FinalizarPedido { get; private set; } = new FinalizarPedidoCommand();

        #endregion comandos

        #region construtores

        public CarrinhoViewModel(PedidoModel pedido)
        {
            if (pedido == null)
                return;

            Pedido = pedido;
        }

        #endregion construtores
    }
}