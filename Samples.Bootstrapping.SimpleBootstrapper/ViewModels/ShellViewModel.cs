using Caliburn.Micro;
using JetBrains.Annotations;

namespace Samples.Bootstrapping.SimpleBootstrapper.ViewModels
{
    [UsedImplicitly]
    public sealed class ShellViewModel : Screen
    {
        public override string DisplayName
        {
            get { return "Simple Bootstrapper Shell"; }
            set { }
        }
    }
}