using Prism.Mvvm;

namespace WPF_Prism_Brian.PageModels
{
    public class MainPageViewModel : BindableBase
    {
        private string _title = "Prism Unity Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainPageViewModel()
        {

        }
    }
}
