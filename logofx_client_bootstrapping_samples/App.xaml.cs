using Solid.Core;

namespace LogoFX.Client.Bootstrapping.Samples
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
