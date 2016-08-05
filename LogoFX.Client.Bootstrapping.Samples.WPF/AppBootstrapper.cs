using LogoFX.Client.Bootstrapping.Adapters.SimpleContainer;
using LogoFX.Client.Bootstrapping.Samples.WPF.ViewModels;

namespace LogoFX.Client.Bootstrapping.Samples.WPF
{
    public class AppBootstrapper : BootstrapperContainerBase<ExtendedSimpleContainerAdapter>.WithRootObject<ShellViewModel>
    {
        public AppBootstrapper()
		:base (new ExtendedSimpleContainerAdapter())
		{
			
		}
    }
}