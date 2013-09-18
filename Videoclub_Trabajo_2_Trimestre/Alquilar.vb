Imports System.Windows.Forms

Public Class Alquilar
    Public realizarAlquiler As Boolean

    Private Sub txt_buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_buscar.TextChanged
        Dim adm As New Administrador
        dg_Peliculas.DataSource = Nothing
        dg_Peliculas.DataSource = adm.buscarPeliculasAlquiler(txt_buscar.Text)
        dg_Peliculas.DataMember = "Pelicula"
    End Sub

    Private Sub btn_Atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        Dim cli As New Clientes
        cli.Show()
        Me.Hide()
    End Sub

    Private Sub Alquilar_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim respuesta As Integer
        respuesta = MsgBox("¿Esta seguro de que desea salir?", MsgBoxStyle.OkCancel)
        If respuesta = 1 Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Alquilar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        mostrarPeliculas()
        If dg_Peliculas.RowCount <= 0 Then
            btn_Aceptar.Enabled = False
            btn_Agregar.Enabled = False
            btn_Mas.Enabled = False
            btn_Menos.Enabled = False
        End If
    End Sub

    Private Sub mostrarPeliculas()
        Dim adm As New Administrador
        dg_Peliculas.DataSource = adm.obtenerPeliculasAlquiler()
        dg_Peliculas.DataMember = "Pelicula"
    End Sub

    Private Sub resetear()
        dg_Peliculas.DataSource = Nothing
        mostrarPeliculas()
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        pasarAAlquileres()
    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        'InputBox("Se debe pagar como total: " & Integer.Parse(txt_Duracion.Text) * dg_Alquileres.Rows.Count, "Calcular pago")
        Dim cal As New Calcular_Alquiler
        If dg_Alquileres.Rows.Count > 0 Then
            cal.lbl_Precio.Content = (Integer.Parse(txt_Duracion.Text) * dg_Alquileres.Rows.Count) * 2
            cal.alq = Me
            cal.ShowDialog()
        End If
        If realizarAlquiler Then
            Dim adm As New Administrador
            Dim cli As New Clientes
            Dim comp As Boolean

            For i = 0 To dg_Alquileres.Rows.Count - 1
                comp = adm.agregarAlquiler(Integer.Parse(dg_Alquileres.Rows.Item(i).Cells.Item(0).Value.ToString), lbl_CodCliente.Text, Integer.Parse(txt_Duracion.Text))
            Next

            If comp Then
                MsgBox("Alquiler agregado con exito")
                cli.Show()
                Me.Hide()
            End If
        End If
    End Sub


    Private Sub pasarAAlquileres()
        Dim dgvRow As New DataGridViewRow
        Dim dgvCell = Nothing
        Dim res As Boolean = True

        For i = 0 To dg_Alquileres.Rows.Count - 1
            If dg_Peliculas.SelectedRows(0).Cells.Item(0).Value = dg_Alquileres.Rows(i).Cells.Item(0).Value Then
                MsgBox("La pelicula del codigo '" & dg_Peliculas.SelectedRows(0).Cells.Item(0).Value & "' ya ha sido añadida", MsgBoxStyle.Exclamation)
                res = False
                Exit For
            End If
        Next
        If res Then
            For i = 0 To dg_Peliculas.SelectedCells.Count - 1
                dgvCell = New DataGridViewTextBoxCell
                dgvCell.Value = dg_Peliculas.SelectedCells(i).Value
                dgvRow.Cells.Add(dgvCell)
            Next
            dg_Alquileres.Rows.Add(dgvRow)
            'Quitar del datagrid peliculas
            'dg_Peliculas.Rows.RemoveAt(dg_Peliculas.SelectedRows(0).Index)
            btn_Eliminar.Enabled = True
        End If
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        dg_Alquileres.Rows.RemoveAt(dg_Alquileres.SelectedRows(0).Index)
        If dg_Alquileres.Rows.Count <= 0 Then
            btn_Eliminar.Enabled = False
        End If
    End Sub

    Private Sub btn_Mas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mas.Click
        txt_Duracion.Text = Integer.Parse(txt_Duracion.Text) + 1
    End Sub

    Private Sub btn_Menos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Menos.Click

        If Integer.Parse(txt_Duracion.Text) > 2 Then
            txt_Duracion.Text = Integer.Parse(txt_Duracion.Text) - 1
        End If

    End Sub

    Private Sub rb_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Todos.CheckedChanged
        mostrarPeliculas()
    End Sub

    Private Sub rb_Accion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Accion.CheckedChanged
        Dim adm As New Administrador
        dg_Peliculas.DataSource = adm.obtenerPeliculasAlquilerGenero("Accion")
        dg_Peliculas.DataMember = "Pelicula"
    End Sub

    Private Sub rb_Animacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Animacion.CheckedChanged
        Dim adm As New Administrador
        dg_Peliculas.DataSource = adm.obtenerPeliculasAlquilerGenero("Animacion")
        dg_Peliculas.DataMember = "Pelicula"
    End Sub

    Private Sub rb_Ciencia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Ciencia.CheckedChanged
        Dim adm As New Administrador
        dg_Peliculas.DataSource = adm.obtenerPeliculasAlquilerGenero("Ciencia Ficcion")
        dg_Peliculas.DataMember = "Pelicula"
    End Sub

    Private Sub rb_Terror_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Terror.CheckedChanged
        Dim adm As New Administrador
        dg_Peliculas.DataSource = adm.obtenerPeliculasAlquilerGenero("Terror")
        dg_Peliculas.DataMember = "Pelicula"
    End Sub

    Private Sub rb_Documental_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Documental.CheckedChanged
        Dim adm As New Administrador
        dg_Peliculas.DataSource = adm.obtenerPeliculasAlquilerGenero("Documental")
        dg_Peliculas.DataMember = "Pelicula"
    End Sub

End Class