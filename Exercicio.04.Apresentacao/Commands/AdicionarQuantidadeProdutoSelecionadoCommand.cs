using Exercicio.Quatro.Apresentacao.Classes;
using Exercicio.Quatro.Apresentacao.ViewModels;
using System;
using System.Windows;

namespace Exercicio.Quatro.Apresentacao.Commands
{
    public class AdicionarQuantidadeProdutoSelecionadoCommand : AbstractCommand
    {
        public override void Execute(object parameter)
        {
            try
            {
                (parameter as CarrinhoViewModel)
                    .Pedido
                    .AdicionarQuantidade((parameter as CarrinhoViewModel).ProdutoSelecionado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Adicionar Produto", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}