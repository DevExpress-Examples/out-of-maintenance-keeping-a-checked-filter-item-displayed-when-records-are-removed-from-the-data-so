Imports Microsoft.VisualBasic
Imports System
Namespace XtraPivotGrid_ExampleTemplate
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.btnDeleteDSRecords = New DevExpress.XtraEditors.SimpleButton()
			Me.cheKeepFilterItems = New DevExpress.XtraEditors.CheckEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.btnRestoreDSRecords = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cheKeepFilterItems.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldYear, Me.fieldProductName, Me.fieldQuantity})
			Me.pivotGridControl1.Location = New System.Drawing.Point(12, 12)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.Size = New System.Drawing.Size(490, 187)
			Me.pivotGridControl1.TabIndex = 0
'			Me.pivotGridControl1.CustomFilterPopupItems += New DevExpress.XtraPivotGrid.PivotCustomFilterPopupItemsEventHandler(Me.pivotGridControl1_CustomFilterPopupItems);
			' 
			' fieldYear
			' 
			Me.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldYear.AreaIndex = 0
			Me.fieldYear.Caption = "Year"
			Me.fieldYear.FieldName = "ShippedYear"
			Me.fieldYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.fieldYear.Name = "fieldYear"
			Me.fieldYear.UnboundFieldName = "fieldYear"
			' 
			' fieldProductName
			' 
			Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldProductName.AreaIndex = 0
			Me.fieldProductName.Caption = "Product Name"
			Me.fieldProductName.FieldName = "ProductName"
			Me.fieldProductName.Name = "fieldProductName"
			' 
			' fieldQuantity
			' 
			Me.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldQuantity.AreaIndex = 0
			Me.fieldQuantity.Caption = "Quantity"
			Me.fieldQuantity.FieldName = "Quantity"
			Me.fieldQuantity.Name = "fieldQuantity"
			' 
			' btnDeleteDSRecords
			' 
			Me.btnDeleteDSRecords.Location = New System.Drawing.Point(12, 237)
			Me.btnDeleteDSRecords.Name = "btnDeleteDSRecords"
			Me.btnDeleteDSRecords.Size = New System.Drawing.Size(75, 23)
			Me.btnDeleteDSRecords.TabIndex = 1
			Me.btnDeleteDSRecords.Text = "Remove"
'			Me.btnDeleteDSRecords.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' cheKeepFilterItems
			' 
			Me.cheKeepFilterItems.EditValue = True
			Me.cheKeepFilterItems.Location = New System.Drawing.Point(174, 239)
			Me.cheKeepFilterItems.Name = "cheKeepFilterItems"
			Me.cheKeepFilterItems.Properties.Caption = "Keep Filter Items For Field Values Removed From Data Source"
			Me.cheKeepFilterItems.Size = New System.Drawing.Size(328, 19)
			Me.cheKeepFilterItems.TabIndex = 2
			' 
			' labelControl1
			' 
			Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
			Me.labelControl1.Location = New System.Drawing.Point(12, 205)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(490, 26)
			Me.labelControl1.TabIndex = 3
			Me.labelControl1.Text = "Click the 'Remove' button to remove all records, containing 'Alice Mutton' in the" & " 'Product Name' field from the data source. Click the 'Restore' button to restor" & "e those records."
			' 
			' btnRestoreDSRecords
			' 
			Me.btnRestoreDSRecords.Location = New System.Drawing.Point(93, 237)
			Me.btnRestoreDSRecords.Name = "btnRestoreDSRecords"
			Me.btnRestoreDSRecords.Size = New System.Drawing.Size(75, 23)
			Me.btnRestoreDSRecords.TabIndex = 4
			Me.btnRestoreDSRecords.Text = "Restore"
'			Me.btnRestoreDSRecords.Click += New System.EventHandler(Me.btnRestoreDSRecords_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(514, 272)
			Me.Controls.Add(Me.btnRestoreDSRecords)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.cheKeepFilterItems)
			Me.Controls.Add(Me.btnDeleteDSRecords)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cheKeepFilterItems.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private fieldYear As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldQuantity As DevExpress.XtraPivotGrid.PivotGridField
		Private WithEvents btnDeleteDSRecords As DevExpress.XtraEditors.SimpleButton
		Private cheKeepFilterItems As DevExpress.XtraEditors.CheckEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents btnRestoreDSRecords As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace

