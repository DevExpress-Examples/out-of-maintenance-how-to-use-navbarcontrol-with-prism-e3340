Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.ComponentModel.Composition.Hosting
Imports NavBarAndPrism.Modules
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.NavBar
Imports Prism.Mef
Imports Prism.Modularity
Imports Prism.Regions
Imports DevExpress.Xpf.Prism

Namespace NavBarAndPrism
	Public Class Bootstrapper
		Inherits MefBootstrapper

		Protected Overrides Sub ConfigureAggregateCatalog()
			MyBase.ConfigureAggregateCatalog()
			AggregateCatalog.Catalogs.Add(New AssemblyCatalog(GetType(Bootstrapper).Assembly))
			AggregateCatalog.Catalogs.Add(New AssemblyCatalog(GetType(ModuleA).Assembly))
			AggregateCatalog.Catalogs.Add(New AssemblyCatalog(GetType(ModuleB).Assembly))
		End Sub
		Protected Overrides Sub ConfigureModuleCatalog()
			MyBase.ConfigureModuleCatalog()
			Dim moduleCatalog As ModuleCatalog = CType(Me.ModuleCatalog, ModuleCatalog)
			moduleCatalog.AddModule(GetType(ModuleA))
			moduleCatalog.AddModule(GetType(ModuleB))
		End Sub
		Protected Overrides Function CreateShell() As DependencyObject
			Return Container.GetExportedValue(Of Shell)()
		End Function
		Protected Overrides Sub InitializeShell()
			MyBase.InitializeShell()
			Application.Current.MainWindow = New DXWindow()
			Application.Current.MainWindow.Content = CType(Me.Shell, Shell)
			Application.Current.MainWindow.Show()
		End Sub
		Protected Overrides Function ConfigureRegionAdapterMappings() As RegionAdapterMappings
			Dim mappings As RegionAdapterMappings = MyBase.ConfigureRegionAdapterMappings()
			Dim factory = Container.GetExportedValue(Of IRegionBehaviorFactory)()
            mappings.RegisterMapping(GetType(NavBarControl), AdapterFactory.Make(Of RegionAdapterBase(Of NavBarControl))(factory))
            mappings.RegisterMapping(GetType(NavBarGroup), AdapterFactory.Make(Of RegionAdapterBase(Of NavBarGroup))(factory))
            Return mappings
		End Function
	End Class
End Namespace
