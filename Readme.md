<!-- default file list -->
*Files to look at*:

* [ModuleA.cs](./CS/NavBarAndPrism.ModuleA/ModuleA.cs) (VB: [ModuleAView.xaml.vb](./VB/NavBarAndPrism.ModuleA/ModuleAView.xaml.vb))
* [ModuleAView.xaml](./CS/NavBarAndPrism.ModuleA/ModuleAView.xaml) (VB: [ModuleAView.xaml](./VB/NavBarAndPrism.ModuleA/ModuleAView.xaml))
* [ModuleAView.xaml.cs](./CS/NavBarAndPrism.ModuleA/ModuleAView.xaml.cs) (VB: [ModuleAView.xaml.vb](./VB/NavBarAndPrism.ModuleA/ModuleAView.xaml.vb))
* [ModuleB.cs](./CS/NavBarAndPrism.ModuleB/ModuleB.cs) (VB: [ModuleB.vb](./VB/NavBarAndPrism.ModuleB/ModuleB.vb))
* [ModuleBView.xaml](./CS/NavBarAndPrism.ModuleB/ModuleBView.xaml) (VB: [ModuleBView.xaml](./VB/NavBarAndPrism.ModuleB/ModuleBView.xaml))
* [ModuleBView.xaml.cs](./CS/NavBarAndPrism.ModuleB/ModuleBView.xaml.cs) (VB: [ModuleBView.xaml.vb](./VB/NavBarAndPrism.ModuleB/ModuleBView.xaml.vb))
* [Bootstrapper.cs](./CS/NavBarAndPrism/Bootstrapper.cs) (VB: [Bootstrapper.vb](./VB/NavBarAndPrism/Bootstrapper.vb))
* [Shell.xaml](./CS/NavBarAndPrism/Shell.xaml) (VB: [Shell.xaml](./VB/NavBarAndPrism/Shell.xaml))
* [Shell.xaml.cs](./CS/NavBarAndPrism/Shell.xaml.cs) (VB: [Shell.xaml.vb](./VB/NavBarAndPrism/Shell.xaml.vb))
<!-- default file list end -->
# How to use NavBarControl with Prism


This example demonstrates how to add groups to `NavBarControl` using PRISM. See the **Implementation Details** section to learn more on how to enable PRISM support in the selected DevExpress version.


## Description

In **v17.1**, we have implemented ready-to-use PRISM adapters for DXNavBar. You can **[register](https://msdn.microsoft.com/en-us/library/ff921129.aspx)** them in the following manner:</p>

```cs
protected override RegionAdapterMappings ConfigureRegionAdapterMappings() {
    RegionAdapterMappings mappings = base.ConfigureRegionAdapterMappings();
    var factory = Container.GetExportedValue&lt;IRegionBehaviorFactory&gt;();
    mappings.RegisterMapping(typeof(NavBarControl), AdapterFactory.Make&lt;RegionAdapterBase&lt;NavBarControl&gt;&gt;(factory));
    mappings.RegisterMapping(typeof(NavBarGroup), AdapterFactory.Make&lt;RegionAdapterBase&lt;NavBarGroup&gt;&gt;(factory));
    return mappings;
}
```
```vb
Protected Overrides Function ConfigureRegionAdapterMappings() As RegionAdapterMappings
    Dim mappings As RegionAdapterMappings = MyBase.ConfigureRegionAdapterMappings()
    Dim factory = Container.GetExportedValue(Of IRegionBehaviorFactory)()
    mappings.RegisterMapping(GetType(NavBarControl), AdapterFactory.Make(Of RegionAdapterBase(Of NavBarControl))(factory))
    mappings.RegisterMapping(GetType(NavBarGroup), AdapterFactory.Make(Of RegionAdapterBase(Of NavBarGroup))(factory))
    Return mappings
End Function
```
