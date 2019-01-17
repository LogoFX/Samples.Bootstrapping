using Solid.Core;

namespace LogoFX.Client.Bootstrapping.Samples.WPF
{    
    public partial class App
    {
        public App()
        {
            var appBootstrapper = new AppBootstrapper();
            (appBootstrapper as IInitializable).Initialize();
        }
    }
}
