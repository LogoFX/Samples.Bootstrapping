# Samples.Bootstrapping

This sample demonstrates how start to use LogoFX framework and setup application bootstrapper.

---

## WPF

### Steps to create

1. Create new WPF project
2. Remove MainWindow.xaml/MainWindow.xaml.cs
3. In App.xaml remove `StartupUri` element.

```
<Application x:Class="LogoFX.Client.Bootstrapping.Samples.WPF.App"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">

    <Application.Resources>
         
    </Application.Resources>
</Application>
```
4. Add folders Views and ViewModels. Add new class `ShellViewModel` to ViewModels folder and new WPF Window `ShellView` to Views.
5. Add new class `AppBootstrapper` to root of project.

```
    public class AppBootstrapper : BootstrapperContainerBase<ShellViewModel, ExtendedSimpleContainerAdapter>
    {
        public AppBootstrapper()
            : base(new ExtendedSimpleContainerAdapter())
        {
        }
    }
```
