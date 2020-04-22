using LogoFX.Client.Bootstrapping.Adapters.SimpleContainer;
using LogoFX.Client.Bootstrapping.Samples.WPF.ViewModels;
using Solid.Practices.Composition;

namespace LogoFX.Client.Bootstrapping.Samples.WPF
{
    public class AppBootstrapper : BootstrapperContainerBase<ExtendedSimpleContainerAdapter>.WithRootObject<ShellViewModel>
    {
        public AppBootstrapper()
		:base (new ExtendedSimpleContainerAdapter())
		{
			
		}

        public override CompositionOptions CompositionOptions => new CompositionOptions
        {
            Prefixes = new[] {"LogoFX.Client.Bootstrapping.Samples"}
        };
    }
}