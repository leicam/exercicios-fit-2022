using Exercicio.Quatro.Apresentacao.Classes;

namespace Exercicio.Quatro.Apresentacao.Commands
{
    public class MinimizarJanelaCommand : AbstractCommand
    {
        public override void Execute(object parameter) => (parameter as AbstractViewModel).MinimizarJanela();
    }
}