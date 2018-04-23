Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.IO
Imports System.Collections
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraPivotGrid.Data

Namespace XtraPivotGrid_ExampleTemplate
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			pivotGridControl1.DataSource = PivotHelper.GetFullDataTable()
			pivotGridControl1.BestFit()
			fieldProductName.Options.AllowSort = DefaultBoolean.False

			pivotGridControl1.BeginUpdate()
			fieldProductName.FilterValues.ValuesIncluded = New Object() { "Alice Mutton", "Aniseed Syrup" }
			pivotGridControl1.EndUpdate()
		End Sub
		Private Sub pivotGridControl1_CustomFilterPopupItems(ByVal sender As Object, ByVal e As PivotCustomFilterPopupItemsEventArgs) Handles pivotGridControl1.CustomFilterPopupItems
			If (Not cheKeepFilterItems.Checked) Then
				Return
			End If
			For Each value As Object In fieldProductName.FilterValues.ValuesIncluded
				Dim match As Boolean = False
				For Each item As PivotGridFilterItem In e.Items
					If item.Value.ToString() = value.ToString() Then
						match = True
					End If
				Next item
				If (Not match) Then
					e.Items.Add(New PivotGridFilterItem(value, value.ToString(), True))
				End If
			Next value
			ArrayList.Adapter(CType(e.Items, IList)).Sort(New FilterItemsComparer())
		End Sub
		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDeleteDSRecords.Click
			pivotGridControl1.DataSource = PivotHelper.GetIncompleteDataTable()
		End Sub
		Private Sub btnRestoreDSRecords_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRestoreDSRecords.Click
			pivotGridControl1.DataSource = PivotHelper.GetFullDataTable()
		End Sub
		Public Class FilterItemsComparer
			Implements IComparer
			Private Function IComparer_Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
				If Not(TypeOf x Is PivotGridFilterItem) OrElse Not(TypeOf y Is PivotGridFilterItem) Then
					Return 0
				End If
				Dim item1 As PivotGridFilterItem = CType(x, PivotGridFilterItem)
				Dim item2 As PivotGridFilterItem = CType(y, PivotGridFilterItem)
				Return String.Compare(item1.ToString(), item2.ToString())
			End Function
		End Class
		Public NotInheritable Class PivotHelper
			Private Sub New()
			End Sub
			Public Shared Function GetFullDataTable() As DataTable
				Dim table As New DataTable()
				table.Columns.Add("ProductName", GetType(String))
				table.Columns.Add("ShippedYear", GetType(DateTime))
				table.Columns.Add("Quantity", GetType(Integer))
				table.Rows.Add("Alice Mutton", New DateTime(2010, 1, 1), 36)
				table.Rows.Add("Alice Mutton", New DateTime(2009, 4, 12), 124)
				table.Rows.Add("Alice Mutton", New DateTime(2007, 6, 3), 355)
				table.Rows.Add("Aniseed Syrup", New DateTime(2010, 2, 19), 4)
				table.Rows.Add("Aniseed Syrup", New DateTime(2010, 8, 23), 234)
				table.Rows.Add("Aniseed Syrup", New DateTime(2009, 12, 4), 12)
				table.Rows.Add("Aniseed Syrup", New DateTime(2008, 10, 15), 56)
				table.Rows.Add("Boston Crab Meat", New DateTime(2007, 9, 13), 14)
				table.Rows.Add("Boston Crab Meat", New DateTime(2010, 12, 17), 129)
				Return table
			End Function
			Public Shared Function GetIncompleteDataTable() As DataTable
				Dim table As New DataTable()
				table.Columns.Add("ProductName", GetType(String))
				table.Columns.Add("ShippedYear", GetType(DateTime))
				table.Columns.Add("Quantity", GetType(Integer))
				table.Rows.Add("Aniseed Syrup", New DateTime(2010, 2, 19), 4)
				table.Rows.Add("Aniseed Syrup", New DateTime(2010, 8, 23), 234)
				table.Rows.Add("Aniseed Syrup", New DateTime(2009, 12, 4), 12)
				table.Rows.Add("Aniseed Syrup", New DateTime(2008, 10, 15), 56)
				table.Rows.Add("Boston Crab Meat", New DateTime(2007, 9, 13), 14)
				table.Rows.Add("Boston Crab Meat", New DateTime(2010, 12, 17), 129)
				Return table
			End Function
		End Class
	End Class
End Namespace