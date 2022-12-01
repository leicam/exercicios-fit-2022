using Exercicio.Quatro.Apresentacao.Classes;
using Exercicio.Quatro.Apresentacao.ViewModels;
using System;
using System.Linq;
using System.Windows;

namespace Exercicio.Quatro.Apresentacao.Commands
{
    public class NavegarParaCarrinhoCommand : AbstractCommand
    {
        public override void Execute(object parameter)
        {
            try
            {
                var vm = parameter as ListaViewModel;

                if (!vm.Pedido.Produtos.Any())
                    throw new Exception("Não há produtos adicionados ao carrinho!");

                vm.Notify();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Remover Produto", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}