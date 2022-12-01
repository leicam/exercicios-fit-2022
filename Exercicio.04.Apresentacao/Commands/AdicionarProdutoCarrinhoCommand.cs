using Exercicio.Quatro.Apresentacao.Classes;
using Exercicio.Quatro.Apresentacao.ViewModels;
using System;
using System.Windows;

namespace Exercicio.Quatro.Apresentacao.Commands
{
    public class AdicionarProdutoCarrinhoCommand : AbstractCommand
    {
        public override void Execute(object parameter)
        {
            try
            {
                var vm = parameter as ListaViewModel;
                vm.Pedido.AdicionarProduto(vm.ProdutoSelecionado);
                MessageBox.Show("Produto adicionado ao carrinho com sucesso!", "Adicionar Produto", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Adicionar Produto", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}