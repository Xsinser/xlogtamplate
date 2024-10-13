
namespace xlogtamplate.ViewModels
{
    public partial class MainMenuViewModel : ViewModelBase
    {
        public void OpenBattlePage()
        {
             ViewController.ShowNewView<AboutViewModel>();
        }

    }
}
