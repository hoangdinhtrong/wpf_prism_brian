using Prism.Commands;

namespace WPF_Prism_Brian.Commands
{
    public class ApplicationCommand : IApplicationCommand
    {
        private CompositeCommand _saveAllCommand = new CompositeCommand();
        public CompositeCommand SaveAllCommand
        {
            get { return _saveAllCommand; }
        }
    }
}
