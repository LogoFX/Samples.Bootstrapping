using Solid.Core;

namespace LogoFX.Samples.Client.Bootstrapping
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        public App()
        {
            var appBootstrapper = new AppBootstrapper();
            ((IInitializable)appBootstrapper).Initialize();
        }
    }
}
