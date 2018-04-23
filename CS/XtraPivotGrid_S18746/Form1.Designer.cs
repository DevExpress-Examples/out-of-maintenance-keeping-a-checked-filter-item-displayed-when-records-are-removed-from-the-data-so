namespace XtraPivotGrid_ExampleTemplate {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuantity = new DevExpress.XtraPivotGrid.PivotGridField();
            this.btnDeleteDSRecords = new DevExpress.XtraEditors.SimpleButton();
            this.cheKeepFilterItems = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnRestoreDSRecords = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheKeepFilterItems.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldYear,
            this.fieldProductName,
            this.fieldQuantity});
            this.pivotGridControl1.Location = new System.Drawing.Point(12, 12);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(490, 187);
            this.pivotGridControl1.TabIndex = 0;
            this.pivotGridControl1.CustomFilterPopupItems += new DevExpress.XtraPivotGrid.PivotCustomFilterPopupItemsEventHandler(this.pivotGridControl1_CustomFilterPopupItems);
            // 
            // fieldYear
            // 
            this.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldYear.AreaIndex = 0;
            this.fieldYear.Caption = "Year";
            this.fieldYear.FieldName = "ShippedYear";
            this.fieldYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldYear.Name = "fieldYear";
            this.fieldYear.UnboundFieldName = "fieldYear";
            // 
            // fieldProductName
            // 
            this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName.AreaIndex = 0;
            this.fieldProductName.Caption = "Product Name";
            this.fieldProductName.FieldName = "ProductName";
            this.fieldProductName.Name = "fieldProductName";
            // 
            // fieldQuantity
            // 
            this.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQuantity.AreaIndex = 0;
            this.fieldQuantity.Caption = "Quantity";
            this.fieldQuantity.FieldName = "Quantity";
            this.fieldQuantity.Name = "fieldQuantity";
            // 
            // btnDeleteDSRecords
            // 
            this.btnDeleteDSRecords.Location = new System.Drawing.Point(12, 237);
            this.btnDeleteDSRecords.Name = "btnDeleteDSRecords";
            this.btnDeleteDSRecords.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteDSRecords.TabIndex = 1;
            this.btnDeleteDSRecords.Text = "Remove";
            this.btnDeleteDSRecords.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cheKeepFilterItems
            // 
            this.cheKeepFilterItems.EditValue = true;
            this.cheKeepFilterItems.Location = new System.Drawing.Point(174, 239);
            this.cheKeepFilterItems.Name = "cheKeepFilterItems";
            this.cheKeepFilterItems.Properties.Caption = "Keep Filter Items For Field Values Removed From Data Source";
            this.cheKeepFilterItems.Size = new System.Drawing.Size(328, 19);
            this.cheKeepFilterItems.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl1.Location = new System.Drawing.Point(12, 205);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(490, 26);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Click the \'Remove\' button to remove all records, containing \'Alice Mutton\' in the" +
                " \'Product Name\' field from the data source. Click the \'Restore\' button to restor" +
                "e those records.";
            // 
            // btnRestoreDSRecords
            // 
            this.btnRestoreDSRecords.Location = new System.Drawing.Point(93, 237);
            this.btnRestoreDSRecords.Name = "btnRestoreDSRecords";
            this.btnRestoreDSRecords.Size = new System.Drawing.Size(75, 23);
            this.btnRestoreDSRecords.TabIndex = 4;
            this.btnRestoreDSRecords.Text = "Restore";
            this.btnRestoreDSRecords.Click += new System.EventHandler(this.btnRestoreDSRecords_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 272);
            this.Controls.Add(this.btnRestoreDSRecords);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cheKeepFilterItems);
            this.Controls.Add(this.btnDeleteDSRecords);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheKeepFilterItems.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldYear;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQuantity;
        private DevExpress.XtraEditors.SimpleButton btnDeleteDSRecords;
        private DevExpress.XtraEditors.CheckEdit cheKeepFilterItems;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnRestoreDSRecords;
    }
}

