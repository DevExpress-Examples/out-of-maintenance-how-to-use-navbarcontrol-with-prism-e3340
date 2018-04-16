Imports System
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports NavBarAndPrism.Views
Imports System.ComponentModel.Composition
Imports Prism.Mef.Modularity
Imports Prism.Modularity
Imports Prism.Regions

Namespace NavBarAndPrism.Modules
	<ModuleExport(GetType(ModuleB))>
	Public Class ModuleB
		Implements IModule

		<Import>
		Public RegionManager As IRegionManager
        Public Sub Initialize() Implements IModule.Initialize
            RegionManager.RegisterViewWithRegion("NavBarControlRegion", GetType(ModuleBView))
        End Sub
    End Class
End Namespace
