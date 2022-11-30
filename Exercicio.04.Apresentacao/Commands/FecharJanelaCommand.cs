using Exercicio.Quatro.Apresentacao.Classes;

namespace Exercicio.Quatro.Apresentacao.Commands
{
    public class FecharJanelaCommand : AbstractCommand
    {
        public override void Execute(object parameter) 
            => (parameter as AbstractViewModel).FecharJanela();
    }
}