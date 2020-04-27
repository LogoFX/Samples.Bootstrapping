using LogoFX.Client.Bootstrapping;
using LogoFX.Client.Bootstrapping.Adapters.SimpleContainer;
using LogoFX.Samples.Client.Bootstrapping.ViewModels;
using Solid.Practices.Composition;

namespace LogoFX.Samples.Client.Bootstrapping
{
    public class AppBootstrapper : BootstrapperContainerBase<ExtendedSimpleContainerAdapter>.WithRootObject<ShellViewModel>
    {
        public AppBootstrapper()
            : base(new ExtendedSimpleContainerAdapter())
        {

        }

        public override CompositionOptions CompositionOptions => new CompositionOptions
        {
            Prefixes = new[] {"LogoFX.Samples.Client.Bootstrapping"}
        };
    }
}