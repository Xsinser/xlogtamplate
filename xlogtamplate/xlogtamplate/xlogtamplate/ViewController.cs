using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xlogtamplate.ViewModels;

namespace xlogtamplate
{
    public static class ViewController
    {
        private static MainWindowViewModel _viewModelBase;

        private static List<(string, ViewModelBase)> _views = new();

        public static void Initialize(MainWindowViewModel viewModelBase)
        {
            _viewModelBase = viewModelBase;
        }

        public static void ShowNewView<T>() where T : ViewModelBase, new()
        {
            _viewModelBase.CurrentPage = new T();
        }

        public static void ShowView<T>() where T : ViewModelBase, new()
        {
            var view = _views.FirstOrDefault(x => x.Item1 == typeof(T).Name).Item2;
            if (view == null)
            {
                view = new T();
                _views.Add((typeof(T).Name, view));
            }

            _viewModelBase.CurrentPage = view;
        }
    }
}
