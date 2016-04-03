namespace LogoFX.Client.Bootstrapping.Samples.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        public App()
        {
            var appBootstrapper = new AppBootstrapper();
            appBootstrapper.Initialize();
        }
    }
}
