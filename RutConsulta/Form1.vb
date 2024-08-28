Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Office.Interop

Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtRut.TextChanged

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim rutToSearch As String = txtRut.Text
        Dim excelFilePath As String = "C:\Users\alumnos.republica\Desktop\Maestra.xlsx"
        Try
            Dim excelApp As New Excel.Application
            Dim workbook As Excel.Workbook = excelApp.Workbooks.Open(excelFilePath)
            Dim worksheet As Excel.Worksheet = workbook.Sheets(1) ' Asegúrate de que el índice de la hoja sea correcto

            Dim found As Boolean = False
            Dim usedRange As Excel.Range = worksheet.UsedRange
            For i As Integer = 1 To usedRange.Rows.Count
                Dim rutCell As Excel.Range = usedRange.Cells(i, 1) ' Suponiendo que los RUT están en la primera columna
                Dim nameCell As Excel.Range = usedRange.Cells(i, 2) ' Suponiendo que los nombres están en la segunda columna

                If rutCell.Value IsNot Nothing AndAlso rutCell.Value.ToString() = rutToSearch Then
                    txtResult.Text = nameCell.Value.ToString()
                    found = True
                    Exit For
                End If
            Next

            If Not found Then
                txtResult.Text = "RUT no encontrado"
            End If

            workbook.Close(False)
            excelApp.Quit()

            ' Liberar los recursos COM
            ReleaseObject(worksheet)
            ReleaseObject(workbook)
            ReleaseObject(excelApp)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Class