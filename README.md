# Samples.Bootstrapping

<img src=https://ci.appveyor.com/api/projects/status/github/logofx/Samples.Bootstrapping>

This sample demonstrates how to start using LogoFX framework and setup application bootstrapper.

---

## WPF & ExtendedSimpleContainerAdapter

### Steps to create

- Create new WPF project
- Remove MainWindow.xaml/MainWindow.xaml.cs
- In App.xaml remove `StartupUri` element.

```
<Application x:Class="LogoFX.Client.Bootstrapping.Samples.WPF.App"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">

    <Application.Resources>
         
    </Application.Resources>
</Application>
```
- Add folders Views and ViewModels. Add new class `ShellViewModel` to ViewModels folder and new WPF Window `ShellView` to Views.
- Add new class `AppBootstrapper` to root of project.

```
    public class AppBootstrapper : BootstrapperContainerBase<ShellViewModel, ExtendedSimpleContainerAdapter>
    {
        public AppBootstrapper()
            : base(new ExtendedSimpleContainerAdapter())
        {
        }
    }
```

- In `App` constructor create new instance of `AppBootstrapper` and invoke `Initialize()` method..
 
```
        public App()
        {
            var appBootstrapper = new AppBootstrapper();
            appBootstrapper.Initialize();
        }
```
### Creation Options

The `BootstrapperContainerBase` constructor accepts Creation Options.

The `BootstrapperCreationOptions` class represents various settings for bootstrapper creation. Description of the properties of this class follows bellow.

- `UseApplication` - a value indicating whether the real application is used. Default value is `true`. Use `false` for tests.
- `ReuseCompositionInformation` - a value indicating whether the composition information is re-used. Use `true` when running lots of integration client-side tests. The default value is `true`.
- `DiscoverCompositionModules` - a value indicating whether the bootstrapper should look for instances of `Solid.Practices.Modularity.ICompositionModule`. The default value is `true`.
- `InspectAssemblies` - a value indicating whether the bootstrapper should look for potential application-component assemblies. The default value is `true`.
- `UseDefaultMiddlewares` - a value indicating whether the default middlewares are used. The default value is `true`.
- `DisplayRootView` - a value indicating whether the root view is displayed upon successful initialization. The default value is `true`.

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

# Templating

## Create template

```
dotnet new -i <path-to-project>
```

This command will create new template with name `logofx-client-bootstrapping` (in `template.json`) from the project where `<path-to-project>` is full or relative path to project folder.
  
## Create project from this template

```
dotnet new logofx-client-bootstrapping
```

The project will create in current folder with name of this folder. For set custom project name use `-n` switch.

```
dotnet new logofx-client-bootstrapping -n <new-project-name>
```
