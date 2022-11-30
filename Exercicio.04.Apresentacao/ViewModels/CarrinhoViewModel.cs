using Exercicio.Quatro.Apresentacao.Classes;
using Exercicio.Quatro.Apresentacao.Commands;
using Exercicio.Quatro.Apresentacao.Models;
using System.Collections.ObjectModel;
using System.Linq;

namespace Exercicio.Quatro.Apresentacao.ViewModels
{
    public class CarrinhoViewModel : AbstractViewModel
    {
        #region variaveis privadas

        private decimal _total = 0.00m;
        private ProdutoModel _produtoSelecionado = new ProdutoModel();
        private ObservableCollection<ProdutoModel> _produtos = new ObservableCollection<ProdutoModel>();

        #endregion variaveis privadas

        #region propriedades

        public decimal Total
        {
            get => _total;
            set => SetField(ref _total, value);
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

        public AdicionarQuantidadeProdutoSelecionadoCommand AdicionarQuantidadeProdutoSelecionado { get; private set; } = new AdicionarQuantidadeProdutoSelecionadoCommand();
        public RemoverQuantidadeProdutoSelecionadoCommand RemoverQuantidadeProdutoSelecionado { get; private set; } = new RemoverQuantidadeProdutoSelecionadoCommand();
        public RemoverProdutoSelecionadoCommand RemoverProdutoSelecionado { get; private set; } = new RemoverProdutoSelecionadoCommand();

        #endregion comandos

        #region construtores

        public CarrinhoViewModel(ObservableCollection<ProdutoModel> produtos)
        {
            foreach (var produto in produtos)
                Produtos.Add(produto);

            Totalizar();
        }

        #endregion construtores

        #region metodos

        public void Totalizar()
        {
            Total = 0.0m;

            foreach (var produto in Produtos.Where(x => x.Quantidade > 0))
                Total += produto.Preco * produto.Quantidade;
        }

        #endregion metodos
    }
}