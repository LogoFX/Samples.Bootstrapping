using LogoFX.Client.Bootstrapping.Adapters.SimpleContainer;
using LogoFX.Client.Bootstrapping.Middleware.ViewModels;

namespace LogoFX.Client.Bootstrapping.Middleware
{
    public class AppBootstrapper : BootstrapperContainerBase<ShellViewModel, ExtendedSimpleContainerAdapter>
    {
        public AppBootstrapper()
            : base(new ExtendedSimpleContainerAdapter(),
                  new BootstrapperCreationOptions
                  {
                      DiscoverCompositionModules = true,
                      InspectAssemblies = true,
                      ReuseCompositionInformation = true,
                      UseApplication = true,
                      UseDefaultMiddlewares = true
                  })
        {
        }
    }
}