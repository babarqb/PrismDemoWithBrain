using System;
using Microsoft.Practices.Unity;
using Prism.Unity;
using PrismDemo.Views;
using System.Windows;
using System.Windows.Controls;
using Prism.Modularity;
using Prism.Regions;
using PrismDemo.Infrastructure;
using PrismModuleA;
using PrismModuleB;

namespace PrismDemo
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {

            Application.Current.MainWindow.Show();
        }

        protected override RegionAdapterMappings ConfigureRegionAdapterMappings()
        {
            RegionAdapterMappings mappings =  base.ConfigureRegionAdapterMappings();
            mappings.RegisterMapping(typeof(StackPanel),Container.Resolve<StackPanelRegionAdapter>());
            return mappings;
        }

        // Module with Code::: This way Module is referenced in shell
        //protected override void ConfigureModuleCatalog()
        //{
        //    //Type moduleType = typeof(PrismModuleAModule);
        //    //ModuleCatalog.AddModule(new ModuleInfo()
        //    //{
        //    //    ModuleName = moduleType.Name,
        //    //    ModuleType = moduleType.AssemblyQualifiedName,
        //    //    InitializationMode = InitializationMode.WhenAvailable
        //    //});

        //    Type moduleType = typeof(PrismModuleBModule);
        //    ModuleCatalog.AddModule(new ModuleInfo()
        //    {
        //        ModuleName = moduleType.Name,
        //        ModuleType = moduleType.AssemblyQualifiedName,
        //        InitializationMode = InitializationMode.WhenAvailable
        //    });
        //}

        // Module from directory
        //protected override IModuleCatalog CreateModuleCatalog()
        //{
        //    return new DirectoryModuleCatalog()
        //    {
        //        ModulePath = @".\Modules"
        //    };
        //}

        //Module from xaml file 
        protected override IModuleCatalog CreateModuleCatalog()
        {
            return Prism.Modularity.ModuleCatalog.CreateFromXaml(
                new Uri("/PrismDemo;component/XamlCatalog.xaml", UriKind.Relative));
        }
    }
}
