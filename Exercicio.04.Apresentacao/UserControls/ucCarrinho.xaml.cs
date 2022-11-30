using Exercicio.Quatro.Apresentacao.Models;
using Exercicio.Quatro.Apresentacao.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exercicio._04.Apresentacao.UserControls
{
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