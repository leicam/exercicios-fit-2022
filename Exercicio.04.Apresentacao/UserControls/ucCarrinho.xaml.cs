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
        public ucCarrinho(PedidoModel pedido)
        {
            InitializeComponent();
            DataContext = new CarrinhoViewModel(pedido);
        }
    }
}