using Exercicio.Quatro.Apresentacao.Models;
using Exercicio.Quatro.Apresentacao.ViewModels;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Exercicio._04.Apresentacao.UserControls
{
    /// <summary>
    /// User Control baseado no projeto
    /// https://github.com/sajjad-z/WPF-Shoppinh-Cart
    /// </summary>
    public partial class ucCarrinho : Page
    {
        private ucCarrinho(ObservableCollection<ProdutoModel> produtos)
        {
            InitializeComponent();
            DataContext = new CarrinhoViewModel(produtos);
        }

        public static ucCarrinho Obter(ObservableCollection<ProdutoModel> produtos)
        {
            return new ucCarrinho(produtos);
        }
    }
}