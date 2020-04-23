using Solid.Core;

namespace logofx_client_bootstrapping_samples
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
