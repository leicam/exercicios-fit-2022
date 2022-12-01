using Exercicio._04.Apresentacao.UserControls;
using Exercicio.Quatro.Apresentacao.Classes;
using Exercicio.Quatro.Apresentacao.Interfaces;
using Exercicio.Quatro.Apresentacao.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Exercicio.Quatro.Apresentacao.ViewModels
{
    public class MainWindowViewModel : AbstractViewModel, IObserver
    {
        #region variaveis privadas

        private const string _loremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit," +
            " sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. A iaculis at erat pellentesque" +
            " adipiscing commodo. Libero nunc consequat interdum varius sit amet mattis vulputate enim." +
            " Gravida arcu ac tortor dignissim convallis. Nunc vel risus commodo viverra maecenas." +
            " Malesuada pellentesque elit eget gravida cum sociis natoque. Egestas sed sed risus pretium" +
            " quam vulputate dignissim suspendisse in. Elementum pulvinar etiam non quam lacus suspendisse" +
            " faucibus interdum. Adipiscing vitae proin sagittis nisl rhoncus mattis rhoncus. Sit amet " +
            "nulla facilisi morbi tempus. Augue ut lectus arcu bibendum at. Leo vel fringilla est ullamcorper." +
            " Ut placerat orci nulla pellentesque dignissim enim. Id aliquet lectus proin nibh nisl condimentum id." +
            " In est ante in nibh mauris. Vulputate ut pharetra sit amet aliquam id. Nisi scelerisque eu ultrices" +
            " vitae auctor eu augue ut. Mi in nulla posuere sollicitudin aliquam ultrices sagittis orci a. " +
            "Proin libero nunc consequat interdum varius. Senectus et netus et malesuada fames.";

        private Page _currentUserControl;
        private ucLista _lista;
        private ucCarrinho _carrinho;
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
            CarregarProdutos();

            _lista = new ucLista(Produtos);
            (_lista.DataContext as ListaViewModel).Add(this);
            CurrentUserControl = _lista;
        }

        #endregion construtores

        #region metodos

        #region metodos

        private void CarregarProdutos()
        {
            Produtos.Clear();

            Produtos.Add(new ProdutoModel()
            {
                Imagem = new BitmapImage(new Uri(@"../net5.0-windows/Images/p1.png", UriKind.Relative)),
                Descricao = "Luvas Cheter",
                Referencia = "Ref. 002322111",
                Cor = "Preto",
                Sobre = _loremIpsum,
                Estoque = 10,
                Preco = 159.90m,
            });

            Produtos.Add(new ProdutoModel()
            {
                Imagem = new BitmapImage(new Uri(@"../net5.0-windows/Images/p2.png", UriKind.Relative)),
                Descricao = "Sapato Matric",
                Referencia = "Ref. 006542123",
                Cor = "Verde",
                Sobre = _loremIpsum,
                Estoque = 10,
                Preco = 399.90m,
            });

            Produtos.Add(new ProdutoModel()
            {
                Imagem = new BitmapImage(new Uri(@"../net5.0-windows/Images/p3.png", UriKind.Relative)),
                Descricao = "Meias Patizen",
                Referencia = "Ref. 001289258",
                Cor = "Creme",
                Sobre = _loremIpsum,
                Estoque = 0,
                Preco = 29.90m,
            });

            Produtos.Add(new ProdutoModel()
            {
                Imagem = new BitmapImage(new Uri(@"../net5.0-windows/Images/p4.png", UriKind.Relative)),
                Descricao = "Camiseta Beni",
                Referencia = "Ref. 007197660",
                Cor = "Preto",
                Sobre = _loremIpsum,
                Estoque = 10,
                Preco = 89.90m,
            });

            Produtos.Add(new ProdutoModel()
            {
                Imagem = new BitmapImage(new Uri(@"../net5.0-windows/Images/p5.png", UriKind.Relative)),
                Descricao = "Cinto Couro T-Bone",
                Referencia = "Ref. 008967133",
                Cor = "Marrom",
                Sobre = _loremIpsum,
                Estoque = 6,
                Preco = 99.90m,
            });

            Produtos.Add(new ProdutoModel()
            {
                Imagem = new BitmapImage(new Uri(@"../net5.0-windows/Images/p6.png", UriKind.Relative)),
                Descricao = "Vestido Maria Bonita",
                Referencia = "Ref. 0079121897",
                Cor = "Vermelho",
                Sobre = _loremIpsum,
                Estoque = 10,
                Preco = 89.90m,
            });
        }

        #endregion metodos


        public void Update(ISubject subject)
        {
            if (subject is CarrinhoViewModel)
            {
                CarregarProdutos();
                _lista = new ucLista(Produtos);
                (_lista.DataContext as ListaViewModel).Add(this);
                CurrentUserControl = _lista;

                return;
            }

            if (subject is ListaViewModel)
            {
                _carrinho = new ucCarrinho((subject as ListaViewModel).Pedido);
                (_carrinho.DataContext as CarrinhoViewModel).Add(this);
                CurrentUserControl = _carrinho;

                return;
            }
        }

        #endregion metodos
    }
}