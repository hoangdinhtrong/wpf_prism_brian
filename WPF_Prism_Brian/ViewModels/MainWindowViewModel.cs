using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Windows.Input;

namespace WPF_Prism_Brian.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private bool _isEnabeld;
        public bool IsEnabled
        {
            get { return _isEnabeld; }
            set { 
                SetProperty(ref _isEnabeld, value);
                //MyAweSomeCommand.RaiseCanExecuteChanged();
            }
        }

        private string _updateText;
        public string UpdateText
        {
            get { return _updateText; }
            set { 
                SetProperty(ref _updateText, value); 
            }
        }

        public DelegateCommand MyAweSomeCommand { get; set; }

        public MainWindowViewModel()
        {
            //MyAweSomeCommand = new DelegateCommand(Execute, CanExecuted)
            //   .ObservesProperty(() => IsEnabled);
            MyAweSomeCommand = new DelegateCommand(Execute)
                .ObservesCanExecute(() => IsEnabled);
        }

        private void Execute()
        {
            UpdateText = $"Update {DateTime.Now}";
        }

        private bool CanExecuted()
        {
            return IsEnabled;
        }
    }
}
