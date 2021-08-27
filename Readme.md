<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128654993/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3340)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [ModuleA.cs](./CS/NavBarAndPrism.ModuleA/ModuleA.cs) (VB: [ModuleAView.xaml.vb](./VB/NavBarAndPrism.ModuleA/ModuleAView.xaml.vb))
* [ModuleAView.xaml](./CS/NavBarAndPrism.ModuleA/ModuleAView.xaml) (VB: [ModuleAView.xaml](./VB/NavBarAndPrism.ModuleA/ModuleAView.xaml))
* [ModuleAView.xaml.cs](./CS/NavBarAndPrism.ModuleA/ModuleAView.xaml.cs) (VB: [ModuleAView.xaml.vb](./VB/NavBarAndPrism.ModuleA/ModuleAView.xaml.vb))
* [ModuleB.cs](./CS/NavBarAndPrism.ModuleB/ModuleB.cs) (VB: [ModuleBView.xaml.vb](./VB/NavBarAndPrism.ModuleB/ModuleBView.xaml.vb))
* [ModuleBView.xaml](./CS/NavBarAndPrism.ModuleB/ModuleBView.xaml) (VB: [ModuleBView.xaml](./VB/NavBarAndPrism.ModuleB/ModuleBView.xaml))
* [ModuleBView.xaml.cs](./CS/NavBarAndPrism.ModuleB/ModuleBView.xaml.cs) (VB: [ModuleBView.xaml.vb](./VB/NavBarAndPrism.ModuleB/ModuleBView.xaml.vb))
* [Bootstrapper.WPF.cs](./CS/NavBarAndPrism/Bootstrapper.WPF.cs) (VB: [Bootstrapper.WPF.vb](./VB/NavBarAndPrism/Bootstrapper.WPF.vb))
* [NavBarControlAdapter.cs](./CS/NavBarAndPrism/NavBarControlAdapter.cs) (VB: [NavBarControlAdapter.vb](./VB/NavBarAndPrism/NavBarControlAdapter.vb))
* [Shell.xaml](./CS/NavBarAndPrism/Shell.xaml) (VB: [Shell.xaml](./VB/NavBarAndPrism/Shell.xaml))
* [Shell.xaml.cs](./CS/NavBarAndPrism/Shell.xaml.cs) (VB: [Shell.xaml.vb](./VB/NavBarAndPrism/Shell.xaml.vb))
<!-- default file list end -->
# How to use NavBarControl with Prism


<p>This example demonstrates how to add groups to <strong>NavBarControl</strong> using PRISM. See the <strong>Implementation Details</strong> section to learn more on how to enable PRISM support in the selected DevExpress version.</p>


<h3>Description</h3>

<p>In versions where PRISM is not supported out of the box, it is necessary to create and register a <a href="https://msdn.microsoft.com/en-us/library/ff921129.aspx">custom Region Adapter</a> for the <strong>NavBarControl</strong> type.<br>In the context of this example, we implemented the NavBarControlAdapter class, which is registered in the following manner:</p>
<code lang="cs">protected override RegionAdapterMappings ConfigureRegionAdapterMappings() {
    RegionAdapterMappings mappings = base.ConfigureRegionAdapterMappings();
    mappings.RegisterMapping(typeof(NavBarControl), Container.GetExportedValue&lt;NavBarControlAdapter&gt;());
    return mappings;
}</code>
<code lang="vb">Protected Overrides Function ConfigureRegionAdapterMappings() As RegionAdapterMappings
	Dim mappings As RegionAdapterMappings = MyBase.ConfigureRegionAdapterMappings()
	mappings.RegisterMapping(GetType(NavBarControl), Container.GetExportedValue(Of NavBarControlAdapter)())
	Return mappings
End Function</code>

<br/>


