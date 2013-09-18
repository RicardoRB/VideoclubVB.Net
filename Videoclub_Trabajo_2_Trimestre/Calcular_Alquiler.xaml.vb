Public Class Calcular_Alquiler
    Public alq As Alquilar

    Private Sub btn_Calcular_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btn_Calcular.Click

        If txt_Importe.Text = "" Or Not IsNumeric(txt_Importe.Text) Then
            lbl_Cambio.Content = "El importe introducido es incorrecto"
        Else
            lbl_Cambio.Content = "Se debe dar un cambio de: " & Double.Parse(txt_Importe.Text) - Integer.Parse(lbl_Precio.Content) & "€"
            alq.realizarAlquiler = True
        End If

    End Sub

    Private Sub Calcular_Alquiler_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        Hide()
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btn_Cancelar.Click
        alq.realizarAlquiler = False
        Hide()
    End Sub

    Private Sub btn_Continuar_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btn_Continuar.Click
        Hide()
    End Sub
End Class
