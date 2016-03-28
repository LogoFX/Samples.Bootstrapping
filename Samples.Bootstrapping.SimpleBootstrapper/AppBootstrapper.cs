using LogoFX.Client.Bootstrapping;
using LogoFX.Client.Bootstrapping.Adapters.SimpleContainer;
using Samples.Bootstrapping.SimpleBootstrapper.ViewModels;

namespace Samples.Bootstrapping.SimpleBootstrapper
{
    public sealed class AppBootstrapper : LogoFX.Client.Bootstrapping.SimpleContainer.SimpleBootstrapper<ShellViewModel>
    {
        public AppBootstrapper()
            : base(
                new ExtendedSimpleContainerAdapter(),
                new BootstrapperCreationOptions
                {
                    DiscoverCompositionModules = true,
                    InspectAssemblies = true,
                    UseApplication = true,
                    ReuseCompositionInformation = true
                })

        {
        }
    }
}