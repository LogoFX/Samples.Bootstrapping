using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml.Controls;
using Caliburn.Micro;
using LogoFX.Client.Bootstrapping;
using LogoFX.Client.Bootstrapping.Adapters.WinRTContainer;
using Samples.Bootstrapping.BootstrapperAsApp.ViewModels;

namespace Samples.Bootstrapping.BootstrapperAsApp
{
    public class AppBootstrapper : BootstrapperContainerBase<ShellViewModel, WinRTContainerAdapter, WinRTContainer>
    {
        private static readonly WinRTContainer IocContainer = new WinRTContainer();

        protected AppBootstrapper() : base(IocContainer, c => new WinRTContainerAdapter(c))
        {
        }

        protected override void BeforeOnLaunched(LaunchActivatedEventArgs e)
        {
            System.Windows.Threading.Dispatch.Current.InitializeDispatch();
#if DEBUG
            //if (Debugger.IsAttached)
            //{
            //    DebugSettings.EnableFrameRateCounter = true;
            //}
#endif  
        }

        protected override void PrepareViewFirst(Frame rootFrame)
        {
            IocContainer.RegisterNavigationService(rootFrame);
        }
    }
}