using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.ComponentModel.Composition.Hosting;
using NavBarAndPrism.Modules;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.NavBar;
using Prism.Mef;
using Prism.Modularity;
using Prism.Regions;
using DevExpress.Xpf.Prism;

namespace NavBarAndPrism {
    public class Bootstrapper : MefBootstrapper {
        protected override void ConfigureAggregateCatalog() {
            base.ConfigureAggregateCatalog();
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(Bootstrapper).Assembly));
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(ModuleA).Assembly));
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(ModuleB).Assembly));
        }
        protected override void ConfigureModuleCatalog() {
            base.ConfigureModuleCatalog();
            ModuleCatalog moduleCatalog = (ModuleCatalog)this.ModuleCatalog;
            moduleCatalog.AddModule(typeof(ModuleA));
            moduleCatalog.AddModule(typeof(ModuleB));
        }
        protected override DependencyObject CreateShell() {
            return Container.GetExportedValue<Shell>();
        }
        protected override void InitializeShell() {
            base.InitializeShell();
            Application.Current.MainWindow = new DXWindow();
            Application.Current.MainWindow.Content = (Shell)this.Shell;
            Application.Current.MainWindow.Show();
        }
        protected override RegionAdapterMappings ConfigureRegionAdapterMappings() {
            RegionAdapterMappings mappings = base.ConfigureRegionAdapterMappings();
            var factory = Container.GetExportedValue<IRegionBehaviorFactory>();
            mappings.RegisterMapping(typeof(NavBarControl), AdapterFactory.Make<RegionAdapterBase<NavBarControl>>(factory));
            return mappings;
        }
    }
}
