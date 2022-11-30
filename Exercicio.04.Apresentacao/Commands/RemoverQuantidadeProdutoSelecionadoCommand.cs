using Exercicio.Quatro.Apresentacao.Classes;
using Exercicio.Quatro.Apresentacao.ViewModels;

namespace Exercicio.Quatro.Apresentacao.Commands
{
    public class RemoverQuantidadeProdutoSelecionadoCommand : AbstractCommand
    {
        public override void Execute(object parameter)
        {
            var vm = parameter as CarrinhoViewModel;

            if (vm.ProdutoSelecionado.Quantidade == 0)
                return;

            vm.ProdutoSelecionado.Quantidade -= 1;
            vm.Totalizar();
        }
    }
}