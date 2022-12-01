using Exercicio.Quatro.Apresentacao.Commands;
using Exercicio.Quatro.Apresentacao.Interfaces;
using System.Collections.Generic;

namespace Exercicio.Quatro.Apresentacao.Classes
{
    public abstract class AbstractViewModel : AbstractNotifyPropertyChanged, ISubject
    {
        #region variaveis privadas

        private readonly List<IObserver> _observers = new List<IObserver>();

        #endregion variaveis privadas

        #region comandos

        public FecharJanelaCommand FecharJanela { get; private set; } = new FecharJanelaCommand();
        public MinimizarJanelaCommand MinimizarJanela { get; private set; } = new MinimizarJanelaCommand();

        #endregion comandos

        #region metodos

        public void Add(IObserver observer) => _observers.Add(observer);
        public void Remove(IObserver observer) => _observers.Remove(observer);
        public virtual void Notify() => _observers.ForEach(x => x.Update(this));

        #endregion metodos
    }
}