using Exercicio.Quatro.Apresentacao.Classes;
using Exercicio.Quatro.Apresentacao.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Exercicio.Quatro.Apresentacao.ViewModels
{
    public class MainWindowViewModel : AbstractViewModel
    {
        private ObservableCollection<ProdutoModel> _produtos = new ObservableCollection<ProdutoModel>();

        public ObservableCollection<ProdutoModel> Produtos 
        { 
            get => _produtos;
            set => SetField(ref _produtos, value); 
        }

        public MainWindowViewModel()
        {
            Produtos.Add(new ProdutoModel()
            {
                Imagem = new BitmapImage(new Uri("../Resources/Images/p1.png")),
                Descriucao = "Cheter Gloves",
                Referencia = "Ref. 002322111",
                Cor = "Black",
                Quantidade = "1",
                Preco = "20,00 BRL",
            });
        }
    }
}