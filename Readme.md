# Keeping a checked filter item displayed when records are removed from the data source


<p>The following example demonstrates how to keep a checked filter item displayed when all records with the corresponding field value are removed from the data source.<br />
In this example, the CustomFilterPopupItems event is handled to ensure whether all filter values are represented in the filter items list.<br />
Initially, the filter of the Product Name field is set to include only the Alice Mutton and Aniseed Syrup products into the report. An end-user can emulate removing all records Alice Mutton from the data source. In this instance, the 'Alice Mutton' filter item would normally be hidden from the filter drop-down. Handling the CustomFilterPopupItems event allows adding the 'Alice Mutton' filter item into the drop-down explicitly.</p><br />


<br/>


