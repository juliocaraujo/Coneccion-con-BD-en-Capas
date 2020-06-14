Imports CapaLogica

Public Class Form1

    Private Sub btnContar_Click(sender As Object, e As EventArgs) Handles btnContar.Click
        MsgBox("Cantidad de Registros= " + ControladorPersona.ObtenerCantidad())

    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Try
            ControladorPersona.DardeAlta(txtId.Text, txtNombre.Text, txtApellido.Text, txtMail.Text)
            MsgBox("Ingreso Correctamente")
        Catch ex As Exception
            MsgBox("Se a producido un error")

        End Try


    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Dim tabla As New DataTable
        tabla.Load(ControladorPersona.ListarTodo())
        ListaDePersonas.DataSource() = tabla

    End Sub
End Class
