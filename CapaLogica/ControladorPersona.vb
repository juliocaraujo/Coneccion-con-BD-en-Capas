Imports CapaDeDatos

Public Module ControladorPersona

    Public Function ObtenerCantidad()
        Dim p As New ModeloPersona
        Return p.Contar()

    End Function

End Module
