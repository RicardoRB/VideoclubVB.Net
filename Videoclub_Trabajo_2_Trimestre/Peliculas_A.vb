Public Class Peliculas_A

    Private Sub btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Nuevo.Click
        Dim nue As New Nuevo_Peliculas
        nue.modificar = False
        nue.ShowDialog()
        resetear()
        If dg_Peliculas.RowCount > 0 Then
            btn_Eliminar.Enabled = True
            btn_Modificar.Enabled = True
        End If
    End Sub

    Private Sub btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Modificar.Click
        Dim nue As New Nuevo_Peliculas
        nue.modificar = True
        nue.lbl_numCodigo.Content = dg_Peliculas.SelectedCells(0).Value.ToString
        nue.txt_Nombre.Text = dg_Peliculas.SelectedCells(1).Value.ToString
        nue.txt_Director.Text = dg_Peliculas.SelectedCells(2).Value.ToString
        nue.txt_Protagonistas.Text = dg_Peliculas.SelectedCells(3).Value.ToString
        nue.ShowDialog()
        resetear()
    End Sub

    Private Sub btn_Atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Atras.Click
        Dim main As New MainWindow
        main.Show()
        Me.Hide()
    End Sub

    Private Sub Peliculas_A_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim respuesta As Integer
        respuesta = MsgBox("¿Esta seguro de que desea salir?", MsgBoxStyle.OkCancel)
        If respuesta = 1 Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub txt_buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_buscar.TextChanged
        Dim adm As New Administrador
        dg_Peliculas.DataSource = Nothing
        dg_Peliculas.DataSource = adm.buscarPeliculas(txt_buscar.Text)
        dg_Peliculas.DataMember = "Pelicula"
    End Sub

    Private Sub mostrarPeliculas()
        Dim adm As New Administrador
        dg_Peliculas.DataSource = adm.obtenerPeliculas
        dg_Peliculas.DataMember = "Pelicula"
    End Sub

    Private Sub Peliculas_A_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        mostrarPeliculas()
        If dg_Peliculas.RowCount <= 0 Then
            btn_Eliminar.Enabled = False
            btn_Modificar.Enabled = False
        End If
    End Sub

    Private Sub resetear()
        dg_Peliculas.DataSource = Nothing
        mostrarPeliculas()
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        Dim respuesta As Integer
        respuesta = MsgBox("¿Esta seguro de que desea eliminar la pelicula con el codigo " & dg_Peliculas.SelectedCells(0).Value.ToString & "?", MsgBoxStyle.OkCancel)
        If respuesta = 1 Then
            Dim adm As New Administrador
            adm.eliminarPelicula(dg_Peliculas.SelectedCells(0).Value.ToString)
            resetear()
        End If
        If dg_Peliculas.RowCount <= 0 Then
            btn_Eliminar.Enabled = False
            btn_Modificar.Enabled = False
        End If
    End Sub

End Class