using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Windows.Input;
using WPF_Prism_Brian.Commands;

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

        private IApplicationCommand _applicationCommands;
        public IApplicationCommand ApplicationCommands
        {
            get { return _applicationCommands; }
            set { SetProperty(ref _applicationCommands, value); }
        }

        public MainWindowViewModel(IApplicationCommand applicationCommands)
        {
            ApplicationCommands = applicationCommands;
        }
    }
}
