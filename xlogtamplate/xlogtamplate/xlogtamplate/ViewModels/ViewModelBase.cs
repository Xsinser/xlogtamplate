using System.ComponentModel;
using System.Runtime.CompilerServices;
using ReactiveUI;

namespace xlogtamplate.ViewModels
{
    public abstract class ViewModelBase : ReactiveObject, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
