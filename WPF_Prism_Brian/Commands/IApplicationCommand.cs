using Prism.Commands;

namespace WPF_Prism_Brian.Commands
{
    public interface IApplicationCommand
    {
        CompositeCommand SaveAllCommand { get; }
    }
}
