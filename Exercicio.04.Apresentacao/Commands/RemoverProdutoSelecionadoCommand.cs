using Exercicio.Quatro.Apresentacao.Classes;
using Exercicio.Quatro.Apresentacao.ViewModels;

namespace Exercicio.Quatro.Apresentacao.Commands
{
    public class RemoverProdutoSelecionadoCommand : AbstractCommand
    {
        public override void Execute(object parameter)
        {
            var vm = parameter as CarrinhoViewModel;

            vm.Produtos.Remove(vm.ProdutoSelecionado);
            vm.Totalizar();
        }
    }
}