using Exercicio.Quatro.Apresentacao.ViewModels;
using System.Windows;

namespace Exercicio._04.Apresentacao
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}