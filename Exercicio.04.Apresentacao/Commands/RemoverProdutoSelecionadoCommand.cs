﻿using Exercicio.Quatro.Apresentacao.Classes;
using Exercicio.Quatro.Apresentacao.ViewModels;
using System;
using System.Windows;

namespace Exercicio.Quatro.Apresentacao.Commands
{
    public class RemoverProdutoSelecionadoCommand : AbstractCommand
    {
        public override void Execute(object parameter)
        {
            try
            {
                (parameter as CarrinhoViewModel)
                    .Pedido
                    .RemoverProduto((parameter as CarrinhoViewModel).ProdutoSelecionado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Remover Produto", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}