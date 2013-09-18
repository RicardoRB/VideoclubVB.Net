Public Class Alquileres

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Atras.Click
        Dim main As New MainWindow
        main.Show()
        Me.Hide()
    End Sub

    Private Sub Alquileres_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim respuesta As Integer
        respuesta = MsgBox("¿Esta seguro de que desea salir?", MsgBoxStyle.OkCancel)
        If respuesta = 1 Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Alquileres_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim adm As New Administrador
        dg_Alquileres.DataSource = adm.obtenerAlquileres()
        dg_Alquileres.DataMember = "Alquiler"
    End Sub
End Class