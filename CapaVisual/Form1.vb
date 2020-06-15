Imports CapaLogica

Public Class Form1

    Private Sub btnContar_Click(sender As Object, e As EventArgs) Handles btnContar.Click
        Try
            MsgBox("Cantidad de Registros= " + ControladorPersona.ObtenerCantidad())
        Catch ex As Exception
            MsgBox("Se produjo un error")
        End Try

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
        Try
            Dim tabla As New DataTable
            tabla.Load(ControladorPersona.ListarTodo())
            ListaDePersonas.DataSource() = tabla
        Catch ex As Exception
            MsgBox("Se produjo un error")
        End Try
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Try
            ControladorPersona.borrar(txtId.Text)
            MsgBox("Persona Borrada Correctamente")

        Catch ex As Exception
            MsgBox("Se produjo un Error ")
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            ControladorPersona.ModificarPer(txtId.Text, txtNombre.Text, txtApellido.Text, txtMail.Text)
            MsgBox("Persona modificada correctamente")
        Catch ex As Exception
            MsgBox("Se produjo un error")
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
