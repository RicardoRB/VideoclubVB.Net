Public Class Nuevo_Clientes

    Public modificar As Boolean = False

    Private Function comprobarCampos()
        If txt_DNI.Text.Length = 0 Then
            MsgBox("El campo DNI esta vacio", MsgBoxStyle.Exclamation)
            Return False
        Else
            If Not IsNumeric(txt_DNI.Text.Substring(0, txt_DNI.Text.Length - 1)) Or IsNumeric(txt_DNI.Text.Substring(8)) Then
                MsgBox("El campo DNI es incorrecto", MsgBoxStyle.Exclamation)
                Return False
            Else
                If txt_Nombre.Text.Length = 0 Then
                    MsgBox("El campo Nombre esta vacio", MsgBoxStyle.Exclamation)
                    Return False
                Else
                    If txt_Direccion.Text.Length = 0 Then
                        MsgBox("El campo Direccion esta vacio", MsgBoxStyle.Exclamation)
                        Return False
                    Else
                        If txt_Telefono.Text.Length = 0 Then
                            MsgBox("El campo Telefono esta vacio", MsgBoxStyle.Exclamation)
                            Return False
                        Else
                            If txt_Telefono.Text.Length < 9 Then
                                MsgBox("El campo telefono no tiene 9 digitos")
                                Return False
                            Else
                                If Not IsNumeric(txt_Telefono.Text) Then
                                    MsgBox("El campo Telefono no es un numero", MsgBoxStyle.Exclamation)
                                    Return False
                                End If
                            End If
                        End If
                    End If
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
                respuesta = MsgBox("¿Esta seguro de que desea modificar a " & txt_DNI.Text & "?", MsgBoxStyle.OkCancel)
                If respuesta = 1 Then
                    adm.modificarCliente(txt_DNI.Text, txt_Nombre.Text, txt_Direccion.Text, txt_Telefono.Text)
                    Me.Hide()
                End If
            Else
                adm.agregarCliente(txt_DNI.Text, txt_Nombre.Text, txt_Direccion.Text, txt_Telefono.Text)
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub Nuevo_Clientes_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        Dim respuesta As Integer
        respuesta = MsgBox("¿Esta seguro de que desea salir?", MsgBoxStyle.OkCancel)
        If respuesta = 1 Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btn_Cancelar.Click
        Dim respuesta As Integer
        If txt_DNI.Text.Length > 0 Or txt_Nombre.Text.Length > 0 Or txt_Direccion.Text.Length > 0 Or txt_Telefono.Text.Length > 0 Then
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

    Private Sub Nuevo_Clientes_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles Me.Loaded
        If modificar Then
            txt_DNI.IsReadOnly = True
            Me.Title = "Modificar Cliente"
            'Me.btn_Agregar.Content = "Modificar"
        Else
            txt_DNI.IsReadOnly = False
            Me.Title = "Nuevo Cliente"
            'Me.btn_Agregar.Content = "Agregar"
        End If
    End Sub

    Private Sub Image1_ImageFailed(ByVal sender As System.Object, ByVal e As System.Windows.ExceptionRoutedEventArgs) Handles Image1.ImageFailed

    End Sub
End Class
