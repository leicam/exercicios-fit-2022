using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Exercicio.Quatro.Apresentacao.Classes
{
    public abstract class AbstractNotifyPropertyChanged : INotifyPropertyChanged
    {
        private Window _currentWindow = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
        
        public event PropertyChangedEventHandler PropertyChanged;

        public void CloseWindow() => _currentWindow.Close();

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
    }
}