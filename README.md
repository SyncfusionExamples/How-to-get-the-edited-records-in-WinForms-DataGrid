# How to get the edited records in WinForms DataGrid (SfDataGrid)

In [WinForms DataGrid](https://www.syncfusion.com/winforms-ui-controls/datagrid) (SfDataGrid), you can retrieve the edited records in the [CurrentCellValidated](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.DataGrid.SfDataGrid.html#Syncfusion_WinForms_DataGrid_SfDataGrid_CurrentCellValidated) event. This event is triggered once the cell validation is complete with valid data, and you can access both the edited cell value and the corresponding row values in this event.

 ```C#
sfDataGrid1.CurrentCellValidated += SfDataGrid1_CurrentCellValidated;

private void SfDataGrid1_CurrentCellValidated(object sender, CurrentCellValidatedEventArgs e)
{
     if(e.NewValue != null)
     {
         editedRecords.Add(e.NewValue);
     }
     if(e.RowData != null)
     {
         editedRows.Add(e.RowData as OrderInfo);
     }
} 
 ```

Take a moment to peruse the [WinForms DataGrid - CurrentCellValidated](https://help.syncfusion.com/windowsforms/datagrid/datavalidation#cell-validation-2) event documentation, where you can find about the cell validation with code examples.