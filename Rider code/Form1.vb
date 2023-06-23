Imports Microsoft.Office.Interop

Public Class FormDropIt

    Private Sub btnExitClick(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnDeleteCustoClick(sender As Object, e As EventArgs) Handles btnDeleteCusto.Click
        lbViewCustomer.Items.Clear()
    End Sub

    Private Sub btnChooseCustomerClick(sender As Object, e As EventArgs) Handles btnChooseCustomer.Click

        Dim xlApp As New Excel.Application
        Dim xlWorkbook As Excel.Workbook = xlApp.Workbooks.Open("C:\Users\User\Documents\Customer Details.xlsm")
        Dim xlWorksheet As Excel.Worksheet = CType(xlWorkbook.Sheets(1), Excel.Worksheet)
        Dim dataRange As Excel.Range = xlWorksheet.UsedRange

        lbChooseCustomer.Items.Clear()
        ' Loop through each row in the data range

        For rowIndex As Integer = 2 To dataRange.Rows.Count

            ' Get the value from the first column (assuming data starts from column A)
            Dim cellValue As String = CType(dataRange.Cells(rowIndex, 1), Excel.Range).Value2

            ' Add the value to the ListBox
            lbChooseCustomer.Items.Add(cellValue)

        Next rowIndex

        ' Close the workbook
        xlWorkbook.Close()

        ' Quit Excel
        xlApp.Quit()

        ' Release the Excel objects
        ReleaseComObject(xlWorksheet)
        ReleaseComObject(xlWorkbook)
        ReleaseComObject(xlApp)

    End Sub

    Private Sub ReleaseComObject(ByVal obj As Object)
        ' Release COM object references
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        lbChooseCustomer.Items.Clear()
    End Sub
End Class
