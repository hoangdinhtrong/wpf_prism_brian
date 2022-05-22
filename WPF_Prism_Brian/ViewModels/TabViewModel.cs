using Prism.Commands;
using Prism.Mvvm;
using System;
using WPF_Prism_Brian.Commands;

namespace WPF_Prism_Brian.ViewModels
{
    public class TabViewModel : BindableBase
    {
        IApplicationCommand _applicationCommands;

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private bool _canUpdate = true;
        public bool CanUpdate
        {
            get { return _canUpdate; }
            set { SetProperty(ref _canUpdate, value); }
        }

        private string _updatedText;
        public string UpdateText
        {
            get { return _updatedText; }
            set { SetProperty(ref _updatedText, value); }
        }

        public DelegateCommand UpdateCommand { get; private set; }

        public TabViewModel(IApplicationCommand applicationCommands)
        {
            _applicationCommands = applicationCommands;

            UpdateCommand = new DelegateCommand(Update).ObservesCanExecute(() => CanUpdate);

            _applicationCommands.SaveAllCommand.RegisterCommand(UpdateCommand);
        }

        private void Update()
        {
            UpdateText = $"Updated: {DateTime.Now}";
        }
    }
}
