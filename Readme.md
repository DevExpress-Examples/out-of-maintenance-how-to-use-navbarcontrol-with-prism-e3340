# How to use NavBarControl with Prism


<p>This example demonstrates how to add groups to <strong>NavBarControl</strong> using PRISM. See the <strong>Implementation Details</strong> section to learn more on how to enable PRISM support in the selected DevExpress version.</p>


<h3>Description</h3>

<p>In version 17.1, we have implemented ready-to-use PRISM adapters for DXNavBar. You can&nbsp;<a href="https://msdn.microsoft.com/en-us/library/ff921129.aspx">register</a> them in the following manner:</p>
<code lang="cs">protected override RegionAdapterMappings ConfigureRegionAdapterMappings() {
    RegionAdapterMappings mappings = base.ConfigureRegionAdapterMappings();
    var factory = Container.GetExportedValue&lt;IRegionBehaviorFactory&gt;();
    mappings.RegisterMapping(typeof(NavBarControl), AdapterFactory.Make&lt;RegionAdapterBase&lt;NavBarControl&gt;&gt;(factory));
    mappings.RegisterMapping(typeof(NavBarGroup), AdapterFactory.Make&lt;RegionAdapterBase&lt;NavBarGroup&gt;&gt;(factory));
    return mappings;
}</code>
<code lang="vb">Protected Overrides Function ConfigureRegionAdapterMappings() As RegionAdapterMappings
	Dim mappings As RegionAdapterMappings = MyBase.ConfigureRegionAdapterMappings()
	Dim factory = Container.GetExportedValue(Of IRegionBehaviorFactory)()
    mappings.RegisterMapping(GetType(NavBarControl), AdapterFactory.Make(Of RegionAdapterBase(Of NavBarControl))(factory))
    mappings.RegisterMapping(GetType(NavBarGroup), AdapterFactory.Make(Of RegionAdapterBase(Of NavBarGroup))(factory))
    Return mappings
End Function</code>

<br/>


