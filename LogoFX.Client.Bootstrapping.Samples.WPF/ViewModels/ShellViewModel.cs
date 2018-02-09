using Caliburn.Micro;

namespace LogoFX.Client.Bootstrapping.Samples.WPF.ViewModels
{
    public class ShellViewModel : Screen
    {
        protected override void OnInitialize()
        {
            base.OnInitialize();
            DisplayName = "Samples.Bootstrapping";
        }
    }
}