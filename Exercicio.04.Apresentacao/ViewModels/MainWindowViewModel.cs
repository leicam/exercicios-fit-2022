using Exercicio._04.Apresentacao.UserControls;
using Exercicio.Quatro.Apresentacao.Classes;
using Exercicio.Quatro.Apresentacao.Commands;
using Exercicio.Quatro.Apresentacao.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Exercicio.Quatro.Apresentacao.ViewModels
{
    public class MainWindowViewModel : AbstractViewModel
    {
        #region variaveis privadas

        private Page _currentUserControl;
        private ObservableCollection<ProdutoModel> _produtos = new ObservableCollection<ProdutoModel>();

        #endregion variaveis privadas

        #region propriedades

        public Page CurrentUserControl 
        { 
            get => _currentUserControl;
            set => SetField(ref _currentUserControl, value);
        }

        public ObservableCollection<ProdutoModel> Produtos 
        { 
            get => _produtos; 
            set => SetField(ref _produtos, value);
        }

        #endregion propriedades

        #region construtores

        public MainWindowViewModel()
        {
            CurrentUserControl = new ucLista();
        }

        #endregion construtores
    }
}