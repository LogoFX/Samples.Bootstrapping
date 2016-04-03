using LogoFX.Client.Bootstrapping.Adapters.SimpleContainer;
using LogoFX.Client.Bootstrapping.Samples.WPF.ViewModels;

namespace LogoFX.Client.Bootstrapping.Samples.WPF
{
    public class AppBootstrapper : BootstrapperContainerBase<ShellViewModel, ExtendedSimpleContainerAdapter>
    {
        public AppBootstrapper()
            : base(new ExtendedSimpleContainerAdapter())
        {
        }
    }
}