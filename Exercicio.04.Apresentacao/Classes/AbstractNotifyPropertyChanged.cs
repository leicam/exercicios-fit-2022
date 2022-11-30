using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Exercicio.Quatro.Apresentacao.Classes
{
    public abstract class AbstractNotifyPropertyChanged : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void FecharJanela() => ObterJanelaAtiva().Close();
        public void MinimizarJanela() => ObterJanelaAtiva().WindowState = WindowState.Minimized;

        public void SetField<T>(ref T field, T value, [CallerMemberName] string nameProperty = null)
        {
            if (!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                RaizePropertyChange(nameProperty);
            }
        }

        private void RaizePropertyChange(string nameProperty)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameProperty));

        private Window ObterJanelaAtiva()
            => Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
    }
}