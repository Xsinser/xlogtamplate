using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using xlogtamplate.ViewModels;

namespace xlogtamplate.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase _CurrentPage;
        public ViewModelBase CurrentPage
        {
            get { return _CurrentPage; }
            set
            {
                this.RaiseAndSetIfChanged(ref _CurrentPage, value);
                OnPropertyChanged();
            }
        }

        public MainWindowViewModel()
        {
            ViewController.Initialize(this);
            ViewController.ShowNewView<MainMenuViewModel>();
            //CurrentPage = new MainMenuViewModel();
        }
    }
}
