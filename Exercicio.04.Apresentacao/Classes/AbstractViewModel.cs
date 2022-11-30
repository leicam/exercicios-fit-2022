using Exercicio.Quatro.Apresentacao.Commands;

namespace Exercicio.Quatro.Apresentacao.Classes
{
    public abstract class AbstractViewModel : AbstractNotifyPropertyChanged 
    { 
        public FecharJanelaCommand FecharJanela { get; private set; } = new FecharJanelaCommand();
        public MinimizarJanelaCommand MinimizarJanela { get; private set; } = new MinimizarJanelaCommand();
    }
}