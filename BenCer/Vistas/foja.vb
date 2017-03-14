Public Class foja
    Public Sub imprimir()
        Try
            ImprimirDatos.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(50, 50, 50, 50)
            ImprimirDatos.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.Scrollable)
        Catch ex As Exception
            MsgBox("Tiene alguna impresora isntalada?, Instale una y vuelva a intentarlo")
        End Try

    End Sub

    Public Sub cerrar()
        Me.Close()
    End Sub
End Class