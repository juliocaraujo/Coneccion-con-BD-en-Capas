﻿Imports CapaDeDatos

Public Module ControladorPersona

    Public Function ObtenerCantidad()
        Dim p As New ModeloPersona
        Return p.Contar()

    End Function
    Public Sub DardeAlta(id As String, nombre As String, apellido As String, mail As String)
        Dim p As New ModeloPersona
        p.Id = id
        p.Nombre = nombre
        p.Apellido = apellido
        p.Mail = mail

        p.Guardar()

    End Sub
    Public Function ListarTodo()
        Dim p As New ModeloPersona
        Return p.Listar()

    End Function

    Public Sub borrar(id As String)
        Dim p As New ModeloPersona
        p.Id = id
        p.borrar()

    End Sub

    Public Sub ModificarPer(id As String, nombre As String, apellido As String, mail As String)
        Dim p As New ModeloPersona
        p.Id = id
        p.Nombre = nombre
        p.Apellido = apellido
        p.Mail = mail

        p.Modificar()

    End Sub

End Module
