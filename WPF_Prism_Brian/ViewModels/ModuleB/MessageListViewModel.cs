using Prism.Events;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using WPF_Prism_Brian.Cores;

namespace WPF_Prism_Brian.ViewModels
{
    public class MessageListViewModel : BindableBase
    {
        private ObservableCollection<string> _messages;
        public ObservableCollection<string> Messages
        {
            get { return _messages; }
            set { SetProperty(ref _messages, value); }
        }

        public IEventAggregator _eventAggregator { get; }

        public MessageListViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            Messages = new ObservableCollection<string>();
            _eventAggregator.GetEvent<MessageSentEvent>().Subscribe(MessageReceived);
        }

        private void MessageReceived(string message)
        {
            Messages.Add(message);
        }
    }
}
