Public Class ModeloPersona
    Inherits Modelo
    'hereda todo de Modelo
    Public Id As String
    Public Nombre As String
    Public Apellido As String
    Public Mail As String

    Public Function Contar()
        Me.Comando.CommandText = "SELECT COUNT(*) FROM persona"
        Return Me.Comando.ExecuteScalar().ToString()
    End Function

    Public Sub Guardar()
        Comando.CommandText = "INSERT INTO persona 
                            VALUES (" + Me.Id + ",'" + Me.Nombre + "','" + Me.Apellido + "','" + Me.Mail + "')"
        Comando.ExecuteNonQuery()
    End Sub

End Class
