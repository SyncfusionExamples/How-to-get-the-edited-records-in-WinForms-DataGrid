using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Events;

namespace WinformsDataGrid
{
    public partial class Form1 : Form
    {
        OrderInfoCollection orderInfoCollection;
        ObservableCollection<OrderInfo> editedRows;
        ObservableCollection<object> editedRecords;

        public Form1()
        {
            InitializeComponent();

            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "OrderID", HeaderText = "Order ID" });
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "CustomerID", HeaderText = "Customer ID" });
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "CustomerName", Width = 150, HeaderText = "Customer Name" });
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "Country", HeaderText = "Country" });
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "ShipCity", HeaderText = "Ship City" });
            orderInfoCollection = new OrderInfoCollection();
            editedRows = new ObservableCollection<OrderInfo>();
            editedRecords = new ObservableCollection<object>();
            sfDataGrid1.DataSource = orderInfoCollection.Orders;
            //Event subscription
            sfDataGrid1.CurrentCellValidated += OnCurrentCellValidated; 
        }

        //Event customization
        private void OnCurrentCellValidated(object sender, CurrentCellValidatedEventArgs e)
        {
            if (e.NewValue != null)
            {
                editedRecords.Add(e.NewValue);
            }

            if (e.RowData != null)
            {
                editedRows.Add(e.RowData as OrderInfo);
            }
        }
    }
}
