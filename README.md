# Samples.Bootstrapping

This sample demonstrates how start to use LogoFX framework and setup application bootstrapper.

---

## WPF & ExtendedSimpleContainerAdapter

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
6. In `App` constructor create new instance of `AppBootstrapper` and invoke `Initialize()` method..
 
```
        public App()
        {
            var appBootstrapper = new AppBootstrapper();
            appBootstrapper.Initialize();
        }
```
### Creation Options

The `BootstrapperContainerBase` constructor accepts Creation Options.

The `BootstrapperCreationOptions` class represents various settings for bootstrapper creation.

* `UseApplication` - a value indicating whether the real application is used. Default value is `true`. Use `false` for tests.
* `ReuseCompositionInformation` - a value indicating whether the composition information is re-used. Use `true` when running lots of integration client-side tests. The default value is `true`.
* `DiscoverCompositionModules` - a value indicating whether the bootstrapper should look for instances of `Solid.Practices.Modularity.ICompositionModule`. The default value is `true`.
* `InspectAssemblies` - a value indicating whether the bootstrapper should look for potential application-component assemblies. The default value is `true`.
* `UseDefaultMiddlewares` - a value indicating whether the default middlewares are used. The default value is `true`.
* `DisplayRootView` - a value indicating whether the root view is displayed upon successful initialization.

Usage:

```
        public AppBootstrapper()
            : base(new ExtendedSimpleContainerAdapter(),
                  new BootstrapperCreationOptions
                  {
                      DiscoverCompositionModules = true,
                      InspectAssemblies = true,
                      ReuseCompositionInformation = true,
                      UseApplication = true,
                      UseDefaultMiddlewares = true,
                      DisplayRootView = true
                  })
        {
        }
```
