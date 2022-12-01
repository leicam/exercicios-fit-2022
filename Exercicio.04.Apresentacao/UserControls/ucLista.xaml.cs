using Exercicio.Quatro.Apresentacao.Models;
using Exercicio.Quatro.Apresentacao.ViewModels;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Exercicio._04.Apresentacao.UserControls
{
    /// <summary>
    /// User Control Baseado no projeto 
    /// https://github.com/Abel13/HorizontalList/blob/master/HorizontalList/MainWindow.xaml
    /// </summary>
    public partial class ucLista : Page
    {
        public ucLista(ObservableCollection<ProdutoModel> produtos)
        {
            InitializeComponent();
            DataContext = new ListaViewModel(produtos);
        }
    }
}