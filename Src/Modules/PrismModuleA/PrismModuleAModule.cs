using Prism.Modularity;
using Prism.Regions;
using System;
using Microsoft.Practices.Unity;
using PrismDemo.Infrastructure;
using PrismModuleA.ViewModels;
using PrismModuleA.Views;

namespace PrismModuleA
{
    public class PrismModuleAModule : IModule
    {
        readonly IRegionManager _regionManager;
        private IUnityContainer _container;

        public PrismModuleAModule(RegionManager regionManager, IUnityContainer container)
        {
            _regionManager = regionManager;
            _container = container;
        }

        public void Initialize()
        {
            
            //_regionManager.RegisterViewWithRegion(RegionNames.ToolbarRegion, typeof (ToolbarView));

            IRegion region = _regionManager.Regions[RegionNames.ToolbarRegion];
            region.Add(_container.Resolve<ToolbarView>());
            region.Add(_container.Resolve<ToolbarView>());
            region.Add(_container.Resolve<ToolbarView>());
            region.Add(_container.Resolve<ToolbarView>());
            region.Add(_container.Resolve<ToolbarView>());
            region.Add(_container.Resolve<ToolbarView>());
            region.Add(_container.Resolve<ToolbarView>());

            _regionManager.RegisterViewWithRegion(RegionNames.ContentRegion, typeof (ContentView));
        }
    }
}