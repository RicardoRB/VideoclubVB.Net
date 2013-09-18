Class MainWindow 

    Private Sub btn_Cliente_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btn_Cliente.Click
        Dim cli As New Clientes
        cli.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Peliculas_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btn_Peliculas.Click
        Dim pel As New Peliculas_A
        Me.Hide()
        pel.Show()
    End Sub

    Private Sub btn_Alquileres_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btn_Alquileres.Click
        Dim al As New Alquileres
        Me.Hide()
        al.Show()
    End Sub

    Private Sub btn_Informes_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btn_Informes.Click
        Dim inf As New Informes
        Me.Hide()
        inf.Show()
    End Sub

    Private Sub MainWindow_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        Dim respuesta As Integer
        respuesta = MsgBox("¿Esta seguro de que desea salir?", MsgBoxStyle.OkCancel)
        If respuesta = 1 Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btn_Salir.Click
        Dim respuesta As Integer
        respuesta = MsgBox("¿Esta seguro de que desea salir?", MsgBoxStyle.OkCancel)
        If respuesta = 1 Then
            End
        End If
    End Sub

End Class
