# How to get the edited records in WinForms DataGrid?

In [WinForms DataGrid](https://www.syncfusion.com/winforms-ui-controls/datagrid) (SfDataGrid), edited records can be retrieved in the [CurrentCellValidated](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.DataGrid.SfDataGrid.html#Syncfusion_WinForms_DataGrid_SfDataGrid_CurrentCellValidated) event. This event is triggered once cell validation is completed with valid data, allowing access to both the edited cell value and the corresponding row values.

 ```C#
//Event subscription
sfDataGrid1.CurrentCellValidated += OnCurrentCellValidated;

//Event customization
private void OnCurrentCellValidated(object sender, CurrentCellValidatedEventArgs e)
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