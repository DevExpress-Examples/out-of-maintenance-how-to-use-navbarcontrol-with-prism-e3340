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


