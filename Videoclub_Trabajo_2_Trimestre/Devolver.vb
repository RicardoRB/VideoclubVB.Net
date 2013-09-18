Public Class Devolver
    Public cli As String

    Private Sub btn_Devolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Devolver.Click

        Dim dias As Integer = DateDiff("d", Date.Today, Date.Parse(dg_Alquileres.SelectedRows.Item(0).Cells.Item(2).Value))
        If dias > 0 Then
            MsgBox("El cliente ha tardado en devolver la pelicula " & dias & " dias, tiene una multa de: " & dias * 3 & "€", MsgBoxStyle.Information)
        End If
        Dim adm As New Administrador
        adm.devolverPelicula(Integer.Parse(dg_Alquileres.SelectedRows.Item(0).Cells.Item(0).Value))
        resetear()
        If dg_Alquileres.RowCount <= 0 Then
            btn_Devolver.Enabled = False
        End If
        MsgBox("Pelicula devuelta con exito")
    End Sub

    Private Sub Devolver_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim respuesta As Integer
        respuesta = MsgBox("¿Esta seguro de que desea salir?", MsgBoxStyle.OkCancel)
        If respuesta = 1 Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Devolver_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        resetear()
        If dg_Alquileres.RowCount <= 0 Then
            btn_Devolver.Enabled = False
        End If
    End Sub

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Dim cli As New Clientes
        cli.Show()
        Me.Hide()
    End Sub

    Private Sub resetear()
        Dim adm As New Administrador
        dg_Alquileres.DataSource = adm.obtenerAlquileres(cli)
        dg_Alquileres.DataMember = "Alquiler"
    End Sub
End Class