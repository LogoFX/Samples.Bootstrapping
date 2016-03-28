using Caliburn.Micro;
using JetBrains.Annotations;

namespace Samples.Bootstrapping.BootstrapperAsApp.ViewModels
{
    [UsedImplicitly]
    public sealed class ShellViewModel : Screen
    {
        public override string DisplayName
        {
            get { return "Bootstrapper As App Shell"; }
            set { }
        }
    }
}