using Exercicio.Quatro.Apresentacao.Classes;
using Exercicio.Quatro.Apresentacao.ViewModels;
using System;
using System.Windows;

namespace Exercicio.Quatro.Apresentacao.Commands
{
    public class FinalizarPedidoCommand : AbstractCommand
    {
        public override void Execute(object parameter)
        {
            try
            {
                var vm = parameter as CarrinhoViewModel;

                if (string.IsNullOrEmpty(vm.Cartao.Numero))
                    throw new ArgumentException("Informe o número do cartão");

                if (string.IsNullOrEmpty(vm.Cartao.Validade))
                    throw new ArgumentException("Informe a validade do cartão");

                if (string.IsNullOrEmpty(vm.Cartao.CVV))
                    throw new ArgumentException("Informe o CVV do cartão");

                MessageBox.Show("Pedido finalizado com sucesso!", "Pedido Compra", MessageBoxButton.OK, MessageBoxImage.Information);
                vm.Notify();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pedido Compra", MessageBoxButton.OK, MessageBoxImage.Warning);
            }            
        }
    }
}