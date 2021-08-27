<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128582740/10.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2684)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/XtraPivotGrid_S18746/Form1.cs) (VB: [Form1.vb](./VB/XtraPivotGrid_S18746/Form1.vb))
<!-- default file list end -->
# Keeping a checked filter item displayed when records are removed from the data source


<p>The following example demonstrates how to keep a checked filter item displayed when all records with the corresponding field value are removed from the data source.<br />
In this example, the CustomFilterPopupItems event is handled to ensure whether all filter values are represented in the filter items list.<br />
Initially, the filter of the Product Name field is set to include only the Alice Mutton and Aniseed Syrup products into the report. An end-user can emulate removing all records Alice Mutton from the data source. In this instance, the 'Alice Mutton' filter item would normally be hidden from the filter drop-down. Handling the CustomFilterPopupItems event allows adding the 'Alice Mutton' filter item into the drop-down explicitly.</p><br />


<br/>


