Imports System.Data.Odbc
Imports System.Data

Public Class Administrador
    Dim MyConString As String = "DRIVER={MySQL ODBC 3.51 Driver};" & _
              "SERVER=62.117.186.99;" & _
              "DATABASE=videoclub;" & _
              "UID=quepaza;" & _
              "PASSWORD=quepaza;" & _
              "OPTION=3;"
    Dim MyConnection As New OdbcConnection(MyConString)
    Public Sub agregarCliente(ByVal DNI As String, ByVal nom As String, ByVal dire As String, ByVal tele As String)
        Try
            MyConnection.Open()
            Dim adaptadordatos As New OdbcDataAdapter("INSERT INTO Cliente VALUES ('" & DNI & "','" & nom & "','" & dire & "','" & tele & "')", MyConnection)
            Dim conjuntoDatos As New DataSet
            adaptadordatos.Fill(conjuntoDatos, "Cliente")
            MyConnection.Close()
            MsgBox("Cliente agregado con exito")
        Catch ex As Exception
            MsgBox(ex.Message)
            If (MyConnection.State = ConnectionState.Open) Then
                MyConnection.Close()
            End If
        End Try
    End Sub

    Public Sub eliminarCliente(ByVal DNI As String)
        Try
            MyConnection.Open()
            Dim adaptadordatos As New OdbcDataAdapter("DELETE FROM Cliente WHERE DNI = '" & DNI & "'", MyConnection)
            Dim conjuntoDatos As New DataSet
            adaptadordatos.Fill(conjuntoDatos, "Cliente")
            MyConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            If (MyConnection.State = ConnectionState.Open) Then
                MyConnection.Close()
            End If
        End Try
    End Sub

    Public Sub modificarCliente(ByVal DNI As String, ByVal nom As String, ByVal dire As String, ByVal tele As String)
        Try
            MyConnection.Open()
            Dim adaptadordatos As New OdbcDataAdapter("UPDATE Cliente SET nombre = '" & nom & "', direccion = '" & dire & "', telefono = '" & tele & "' WHERE DNI = '" & DNI & "'", MyConnection)
            Dim conjuntoDatos As New DataSet
            adaptadordatos.Fill(conjuntoDatos, "Cliente")
            MyConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            If (MyConnection.State = ConnectionState.Open) Then
                MyConnection.Close()
            End If
        End Try
    End Sub

    Public Function buscarClientes(ByVal busc As String)
        Try
            Dim adaptadordatos As New OdbcDataAdapter("SELECT * FROM Cliente WHERE DNI LIKE '" & busc & "%' OR nombre LIKE '" & busc & "%'", MyConnection)
            Dim ds As New DataSet("Cliente")
            MyConnection.Open()
            adaptadordatos.Fill(ds, "Cliente")
            MyConnection.Close()
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message)
            If (MyConnection.State = ConnectionState.Open) Then
                MyConnection.Close()
            End If
            Return Nothing
        End Try
    End Function

    Public Function obtenerClientes()
        Try
            Dim adaptadordatos As New OdbcDataAdapter("SELECT * FROM Cliente", MyConnection)
            Dim ds As New DataSet("Cliente")
            MyConnection.Open()
            adaptadordatos.Fill(ds, "Cliente")
            MyConnection.Close()
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message)
            If (MyConnection.State = ConnectionState.Open) Then
                MyConnection.Close()
            End If
            Return Nothing
        End Try
    End Function

    Public Function obtenerPeliculas()
        Try
            Dim adaptadordatos As New OdbcDataAdapter("SELECT * FROM Pelicula", MyConnection)
            Dim ds As New DataSet("Pelicula")
            MyConnection.Open()
            adaptadordatos.Fill(ds, "Pelicula")
            MyConnection.Close()
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message)
            If (MyConnection.State = ConnectionState.Open) Then
                MyConnection.Close()
            End If
            Return Nothing
        End Try
    End Function

    Public Function obtenerPeliculasLimitada(ByVal com As Integer)
        Try
            Dim adaptadordatos As New OdbcDataAdapter("SELECT * FROM Pelicula LIMIT " & com & ", 12", MyConnection)
            Dim ds As New DataSet("Pelicula")
            MyConnection.Open()
            adaptadordatos.Fill(ds, "Pelicula")
            MyConnection.Close()
            Return ds.Tables(0).Rows
        Catch ex As Exception
            MsgBox(ex.Message)
            If (MyConnection.State = ConnectionState.Open) Then
                MyConnection.Close()
            End If
            Return Nothing
        End Try
    End Function

    Public Sub modificarPelicula(ByVal codigo As Integer, ByVal nombre As String, ByVal director As String, ByVal protagonistas As String, ByVal genero As String)
        Try
            MyConnection.Open()
            Dim adaptadordatos As New OdbcDataAdapter("UPDATE Pelicula SET nombre = '" & nombre & "', director = '" & director & "', protagonistas = '" & protagonistas & "', genero = '" & genero & "' WHERE cod = '" & codigo & "'", MyConnection)
            Dim conjuntoDatos As New DataSet
            adaptadordatos.Fill(conjuntoDatos, "Pelicula")
            MyConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            If (MyConnection.State = ConnectionState.Open) Then
                MyConnection.Close()
            End If
        End Try
    End Sub

    Public Sub agregarPelicula(ByVal codigo As Integer, ByVal nombre As String, ByVal director As String, ByVal protagonistas As String, ByVal genero As String)
        Try
            MyConnection.Open()
            Dim adaptadordatos As New OdbcDataAdapter("INSERT INTO Pelicula VALUES ('" & codigo & "','" & nombre & "','" & director & "','" & protagonistas & "','" & genero & "')", MyConnection)
            Dim conjuntoDatos As New DataSet
            adaptadordatos.Fill(conjuntoDatos, "Pelicula")
            MyConnection.Close()
            MsgBox("Pelicula agregado con exito")
        Catch ex As Exception
            MsgBox(ex.Message)
            If (MyConnection.State = ConnectionState.Open) Then
                MyConnection.Close()
            End If
        End Try
    End Sub

    Public Function obtenerNumPeliculas()
        Try
            MyConnection.Open()
            Dim adaptadordatos As New OdbcDataAdapter("SELECT max(cod) FROM Pelicula", MyConnection)
            Dim conjuntoDatos As New DataSet
            adaptadordatos.Fill(conjuntoDatos, "Pelicula")
            Return conjuntoDatos.Tables(0).Rows(0).Item(0) + 1
            MyConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            If (MyConnection.State = ConnectionState.Open) Then
                MyConnection.Close()
            End If
            Return -1
        End Try

    End Function

    Public Sub eliminarPelicula(ByVal cod As Integer)
        Try
            MyConnection.Open()
            Dim adaptadordatos As New OdbcDataAdapter("DELETE FROM Pelicula WHERE cod = '" & cod & "'", MyConnection)
            Dim conjuntoDatos As New DataSet
            adaptadordatos.Fill(conjuntoDatos, "Pelicula")
            MyConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            If (MyConnection.State = ConnectionState.Open) Then
                MyConnection.Close()
            End If
        End Try
    End Sub

    Public Function buscarPeliculas(ByVal busc As String) As Object
        Try
            Dim adaptadordatos As New OdbcDataAdapter("SELECT * FROM Pelicula WHERE cod LIKE '" & busc & "%' OR nombre LIKE '" & busc & "%'", MyConnection)
            Dim ds As New DataSet("Pelicula")
            MyConnection.Open()
            adaptadordatos.Fill(ds, "Pelicula")
            MyConnection.Close()
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message)
            If (MyConnection.State = ConnectionState.Open) Then
                MyConnection.Close()
            End If
            Return Nothing
        End Try
    End Function

    Public Function agregarAlquiler(ByVal codpel As Integer, ByVal codcli As String, ByVal numdias As Integer)
        Try
            MyConnection.Open()
            Dim adaptadordatos As New OdbcDataAdapter("INSERT INTO Alquiler VALUES (" & codpel & ",'" & codcli & "','" & System.DateTime.Today & "'," & numdias & ")", MyConnection)
            Dim conjuntoDatos As New DataSet
            adaptadordatos.Fill(conjuntoDatos, "Alquiler")
            MyConnection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            If (MyConnection.State = ConnectionState.Open) Then
                MyConnection.Close()
            End If
            Return False
        End Try
    End Function

    Public Function obtenerPeliculasAlquiler()
        Try
            Dim adaptadordatos As New OdbcDataAdapter("SELECT p.cod, p.nombre, p.director, p.protagonistas, p.genero FROM pelicula p WHERE cod <>ALL (SELECT a.cod_pel FROM alquiler a WHERE a.durac_alq <> 0)", MyConnection)
            Dim ds As New DataSet("Pelicula")
            MyConnection.Open()
            adaptadordatos.Fill(ds, "Pelicula")
            MyConnection.Close()
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message)
            If (MyConnection.State = ConnectionState.Open) Then
                MyConnection.Close()
            End If
            Return Nothing
        End Try
    End Function

    Public Function buscarPeliculasAlquiler(ByVal busc As String) As Object
        Try
            Dim adaptadordatos As New OdbcDataAdapter("SELECT p.cod, p.nombre, p.director, p.protagonistas, p.genero FROM pelicula p WHERE cod <>ALL (SELECT a.cod_pel FROM alquiler a WHERE a.durac_alq <> 0) AND p.nombre LIKE '" & busc & "%'", MyConnection)
            Dim ds As New DataSet("Pelicula")
            MyConnection.Open()
            adaptadordatos.Fill(ds, "Pelicula")
            MyConnection.Close()
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message)
            If (MyConnection.State = ConnectionState.Open) Then
                MyConnection.Close()
            End If
            Return Nothing
        End Try
    End Function

    Public Function obtenerPeliculasAlquilerGenero(ByVal genero As String) As Object
        Try
            Dim adaptadordatos As New OdbcDataAdapter("SELECT p.cod, p.nombre, p.director, p.protagonistas, p.genero FROM pelicula p WHERE cod <>ALL (SELECT a.cod_pel FROM alquiler a WHERE a.durac_alq <> 0) AND p.genero = '" & genero & "'", MyConnection)
            Dim ds As New DataSet("Pelicula")
            MyConnection.Open()
            adaptadordatos.Fill(ds, "Pelicula")
            MyConnection.Close()
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message)
            If (MyConnection.State = ConnectionState.Open) Then
                MyConnection.Close()
            End If
            Return Nothing
        End Try
    End Function

    Public Function obtenerAlquileres()
        Try
            MyConnection.Open()
            Dim adaptadordatos As New OdbcDataAdapter("SELECT * FROM alquiler", MyConnection)
            Dim conjuntoDatos As New DataSet
            adaptadordatos.Fill(conjuntoDatos, "Alquiler")
            MyConnection.Close()
            Return conjuntoDatos
        Catch ex As Exception
            MsgBox(ex.Message)
            If (MyConnection.State = ConnectionState.Open) Then
                MyConnection.Close()
            End If
            Return Nothing
        End Try
    End Function

    Public Function obtenerAlquileres(ByVal dni As String)
        Try
            MyConnection.Open()
            Dim adaptadordatos As New OdbcDataAdapter("SELECT * FROM alquiler WHERE dni_cli = '" & dni & "' AND durac_alq <> 0", MyConnection)
            Dim conjuntoDatos As New DataSet
            adaptadordatos.Fill(conjuntoDatos, "Alquiler")
            MyConnection.Close()
            Return conjuntoDatos
        Catch ex As Exception
            MsgBox(ex.Message)
            If (MyConnection.State = ConnectionState.Open) Then
                MyConnection.Close()
            End If
            Return Nothing
        End Try
    End Function

    Public Sub devolverPelicula(ByVal cod As Integer)
        Try
            MyConnection.Open()
            Dim adaptadordatos As New OdbcDataAdapter("UPDATE Alquiler SET durac_alq = 0 WHERE cod_pel = '" & cod & "'", MyConnection)
            Dim conjuntoDatos As New DataSet
            adaptadordatos.Fill(conjuntoDatos, "Alquiler")
            MyConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            If (MyConnection.State = ConnectionState.Open) Then
                MyConnection.Close()
            End If
        End Try
    End Sub
End Class
