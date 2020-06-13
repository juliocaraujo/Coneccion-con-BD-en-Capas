Imports CapaLogica

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Cantidad de Registros= " + ControladorPersona.ObtenerCantidad())

    End Sub
End Class
