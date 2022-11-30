using Exercicio.Quatro.Apresentacao.Classes;
using Exercicio.Quatro.Apresentacao.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace Exercicio.Quatro.Apresentacao.ViewModels
{
    public class ListaViewModel : AbstractViewModel
    {
        private ObservableCollection<ProdutoModel> _produtos = new ObservableCollection<ProdutoModel>();

        public ObservableCollection<ProdutoModel> Produtos
        {
            get => _produtos;
            set => SetField(ref _produtos, value);
        }

        public ListaViewModel()
        {
            Produtos.Add(new ProdutoModel()
            {
                Imagem = new BitmapImage(new Uri(@"../net5.0-windows/Resources/Images/p1.png", UriKind.Relative)),
                Descricao = "Cheter Gloves",
                Referencia = "Ref. 002322111",
                Cor = "Black",
                Quantidade = 0,
                Preco = 20.00m,
            });
        }
    }
}