using LogoFX.Client.Bootstrapping;
using LogoFX.Client.Bootstrapping.Adapters.SimpleContainer;
using logofx_client_bootstrapping_samples.ViewModels;
using Solid.Practices.Composition;

namespace logofx_client_bootstrapping_samples
{
    public class AppBootstrapper : BootstrapperContainerBase<ExtendedSimpleContainerAdapter>.WithRootObject<ShellViewModel>
    {
        public AppBootstrapper()
		:base (new ExtendedSimpleContainerAdapter())
		{
			
		}

        public override CompositionOptions CompositionOptions => new CompositionOptions
        {
            Prefixes = new[] { "logofx_client_bootstrapping_samples" }
        };
    }
}