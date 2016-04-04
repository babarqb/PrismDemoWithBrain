using Prism.Modularity;
using Prism.Regions;
using System;

namespace PrismModuleB
{
    //[Module(ModuleName = "PrismModuleBModule",OnDemand = true)]
    public class PrismModuleBModule : IModule
    {
        IRegionManager _regionManager;

        public PrismModuleBModule(RegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }
    }
}