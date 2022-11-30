using Exercicio.Quatro.Apresentacao.Classes;
using Exercicio.Quatro.Apresentacao.ViewModels;

namespace Exercicio.Quatro.Apresentacao.Commands
{
    public class AdicionarQuantidadeProdutoSelecionadoCommand : AbstractCommand
    {
        public override void Execute(object parameter)
        {
            var vm = parameter as CarrinhoViewModel;

            vm.ProdutoSelecionado.Quantidade += 1;
            vm.Totalizar();
        }
    }
}