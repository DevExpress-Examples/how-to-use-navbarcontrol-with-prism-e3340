﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using NavBarAndPrism.Views;
using System.ComponentModel.Composition;
using Prism.Mef.Modularity;
using Prism.Modularity;
using Prism.Regions;

namespace NavBarAndPrism.Modules {
    [ModuleExport(typeof(ModuleB))]
    public class ModuleB : IModule {
        [Import]
        public IRegionManager RegionManager;
        public void Initialize() {
            RegionManager.RegisterViewWithRegion("NavBarControlRegion", typeof(ModuleBView));
        }
    }
}
