using System;
using System.Data;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraPivotGrid.Data;

namespace XtraPivotGrid_ExampleTemplate {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            pivotGridControl1.DataSource = PivotHelper.GetFullDataTable();
            pivotGridControl1.BestFit();
            fieldProductName.Options.AllowSort = DefaultBoolean.False;
            
            pivotGridControl1.BeginUpdate();
            fieldProductName.FilterValues.ValuesIncluded = new object[] { "Alice Mutton", "Aniseed Syrup" };
            pivotGridControl1.EndUpdate();
        }
        private void pivotGridControl1_CustomFilterPopupItems(object sender, PivotCustomFilterPopupItemsEventArgs e) {
            if (!cheKeepFilterItems.Checked) return;
            foreach (object value in fieldProductName.FilterValues.ValuesIncluded) {
                bool match = false;
                foreach (PivotGridFilterItem item in e.Items)
                    if (item.Value.ToString() == value.ToString())
                        match = true;
                if (!match)
                    e.Items.Add(new PivotGridFilterItem(value, value.ToString(), true));
            }
            ArrayList.Adapter((IList)e.Items).Sort(new FilterItemsComparer());
        }
        private void simpleButton1_Click(object sender, EventArgs e) {
            pivotGridControl1.DataSource = PivotHelper.GetIncompleteDataTable();
        }
        private void btnRestoreDSRecords_Click(object sender, EventArgs e) {
            pivotGridControl1.DataSource = PivotHelper.GetFullDataTable();
        }
        public class FilterItemsComparer : IComparer {
            int IComparer.Compare(object x, object y) {
                if (!(x is PivotGridFilterItem) || !(y is PivotGridFilterItem)) return 0;
                PivotGridFilterItem item1 = (PivotGridFilterItem)x;
                PivotGridFilterItem item2 = (PivotGridFilterItem)y;
                return string.Compare(item1.ToString(), item2.ToString());
            }
        }
        public static class PivotHelper {
            public static DataTable GetFullDataTable() {
                DataTable table = new DataTable();
                table.Columns.Add("ProductName", typeof(string));
                table.Columns.Add("ShippedYear", typeof(DateTime));
                table.Columns.Add("Quantity", typeof(int));
                table.Rows.Add("Alice Mutton", new DateTime(2010, 1, 1), 36);
                table.Rows.Add("Alice Mutton", new DateTime(2009, 4, 12), 124);
                table.Rows.Add("Alice Mutton", new DateTime(2007, 6, 3), 355);
                table.Rows.Add("Aniseed Syrup", new DateTime(2010, 2, 19), 4);
                table.Rows.Add("Aniseed Syrup", new DateTime(2010, 8, 23), 234);
                table.Rows.Add("Aniseed Syrup", new DateTime(2009, 12, 4), 12);
                table.Rows.Add("Aniseed Syrup", new DateTime(2008, 10, 15), 56);
                table.Rows.Add("Boston Crab Meat", new DateTime(2007, 9, 13), 14);
                table.Rows.Add("Boston Crab Meat", new DateTime(2010, 12, 17), 129);
                return table;
            }
            public static DataTable GetIncompleteDataTable() {
                DataTable table = new DataTable();
                table.Columns.Add("ProductName", typeof(string));
                table.Columns.Add("ShippedYear", typeof(DateTime));
                table.Columns.Add("Quantity", typeof(int));
                table.Rows.Add("Aniseed Syrup", new DateTime(2010, 2, 19), 4);
                table.Rows.Add("Aniseed Syrup", new DateTime(2010, 8, 23), 234);
                table.Rows.Add("Aniseed Syrup", new DateTime(2009, 12, 4), 12);
                table.Rows.Add("Aniseed Syrup", new DateTime(2008, 10, 15), 56);
                table.Rows.Add("Boston Crab Meat", new DateTime(2007, 9, 13), 14);
                table.Rows.Add("Boston Crab Meat", new DateTime(2010, 12, 17), 129);
                return table;
            }
        }
    }
}