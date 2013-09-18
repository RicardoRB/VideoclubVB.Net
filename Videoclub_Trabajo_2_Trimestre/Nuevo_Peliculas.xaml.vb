Public Class Nuevo_Peliculas
    Public modificar As Boolean = False
    Private Function comprobarCampos()

        If txt_Nombre.Text.Length = 0 Then
            MsgBox("El campo Nombre esta vacio", MsgBoxStyle.Exclamation)
            Return False
        Else
            If txt_Director.Text.Length = 0 Then
                MsgBox("El campo Director esta vacio", MsgBoxStyle.Exclamation)
                Return False
            Else
                If txt_Protagonistas.Text.Length = 0 Then
                    MsgBox("El campo Protagonistas esta vacio", MsgBoxStyle.Exclamation)
                    Return False
                End If
            End If
        End If
        Return True

    End Function

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btn_Agregar.Click

        Dim adm As New Administrador
        If comprobarCampos() Then
            If modificar Then
                Dim respuesta As Integer
                respuesta = MsgBox("¿Esta seguro de que desea modificar a " & lbl_numCodigo.Content & "?", MsgBoxStyle.OkCancel)
                If respuesta = 1 Then
                    adm.modificarPelicula(Integer.Parse(lbl_numCodigo.Content.ToString), txt_Nombre.Text, txt_Director.Text, txt_Protagonistas.Text, cb_Genero.SelectionBoxItem.ToString)
                    Me.Hide()
                End If
            Else
                adm.agregarPelicula(lbl_numCodigo.Content, txt_Nombre.Text, txt_Director.Text, txt_Protagonistas.Text, cb_Genero.SelectionBoxItem.ToString)
                Me.Hide()
            End If
        End If

    End Sub

    Private Sub Nuevo_Peliculas_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        Dim respuesta As Integer
        respuesta = MsgBox("¿Esta seguro de que desea salir?", MsgBoxStyle.OkCancel)
        If respuesta = 1 Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Nuevo_Peliculas_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles Me.Loaded
        If modificar Then
            Me.Title = "Modificar Pelicula"
            'Me.btn_Agregar.Content = "Modificar"
        Else
            Dim adm As New Administrador
            Me.lbl_numCodigo.Content = adm.obtenerNumPeliculas
            Me.Title = "Nueva Pelicula"
            'Me.btn_Agregar.Content = "Agregar"
        End If
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btn_Cancelar.Click
        Dim respuesta As Integer
        If txt_Nombre.Text.Length > 0 Or txt_Director.Text.Length > 0 Or txt_Protagonistas.Text.Length > 0 Then
            respuesta = MsgBox("¿Esta seguro de que desea cancelar la operacion?", MsgBoxStyle.OkCancel)
            If respuesta = 1 Then
                Dim cli As New Clientes
                Me.Hide()
            End If
        Else
            Dim cli As New Clientes
            Me.Hide()
        End If
    End Sub

End Class
