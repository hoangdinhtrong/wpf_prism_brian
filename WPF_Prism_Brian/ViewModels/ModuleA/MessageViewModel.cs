using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using WPF_Prism_Brian.Cores;

namespace WPF_Prism_Brian.ViewModels
{
    public class MessageViewModel : BindableBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public DelegateCommand SendMessageCommand { get; private set; }
        public IEventAggregator _eventAggregator { get; }

        public MessageViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            SendMessageCommand = new DelegateCommand(SendMessage);
        }

        private void SendMessage()
        {
            _eventAggregator.GetEvent<MessageSentEvent>().Publish(Message);
        }
    }
}
