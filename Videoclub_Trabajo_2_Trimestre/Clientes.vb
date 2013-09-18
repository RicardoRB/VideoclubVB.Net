Public Class Clientes

    Private Sub Clientes_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim respuesta As Integer
        respuesta = MsgBox("¿Esta seguro de que desea salir?", MsgBoxStyle.OkCancel)
        If respuesta = 1 Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub mostrarClientes()
        Dim adm As New Administrador
        dg_Clientes.DataSource = adm.obtenerClientes
        dg_Clientes.DataMember = "Cliente"
    End Sub
    Private Sub Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrarClientes()
        If dg_Clientes.RowCount <= 0 Then
            btn_Devolver.Enabled = False
            btn_Alquilar.Enabled = False
            btn_Eliminar.Enabled = False
            btn_Modificar.Enabled = False
        End If
    End Sub

    Private Sub btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Nuevo.Click
        Dim nuev As New Nuevo_Clientes
        nuev.modificar = False
        nuev.ShowDialog()
        resetear()
        If dg_Clientes.RowCount > 0 Then
            btn_Devolver.Enabled = True
            btn_Alquilar.Enabled = True
            btn_Eliminar.Enabled = True
            btn_Modificar.Enabled = True
        End If
    End Sub
    Private Sub resetear()
        dg_Clientes.DataSource = Nothing
        mostrarClientes()
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        Dim respuesta As Integer
        respuesta = MsgBox("¿Esta seguro de que desea eliminar el cliente con el DNI " & dg_Clientes.SelectedCells(0).Value.ToString & "?", MsgBoxStyle.OkCancel)
        If respuesta = 1 Then
            Dim adm As New Administrador
            adm.eliminarCliente(dg_Clientes.SelectedCells(0).Value.ToString)
            resetear()
        End If
        If dg_Clientes.RowCount <= 0 Then
            btn_Devolver.Enabled = False
            btn_Alquilar.Enabled = False
            btn_Eliminar.Enabled = False
            btn_Modificar.Enabled = False
        End If
    End Sub

    Private Sub btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Modificar.Click
        Dim nuev As New Nuevo_Clientes
        nuev.modificar = True
        nuev.txt_DNI.Text = dg_Clientes.SelectedCells(0).Value.ToString
        nuev.txt_Nombre.Text = dg_Clientes.SelectedCells(1).Value.ToString
        nuev.txt_Direccion.Text = dg_Clientes.SelectedCells(2).Value.ToString
        nuev.txt_Telefono.Text = dg_Clientes.SelectedCells(3).Value.ToString
        nuev.ShowDialog()
        resetear()
    End Sub

    Private Sub btn_Atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Atras.Click
        Dim main As New MainWindow
        Me.Hide()
        main.Show()
    End Sub

    Private Sub txt_buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_buscar.TextChanged
        Dim adm As New Administrador
        dg_Clientes.DataSource = Nothing
        dg_Clientes.DataSource = adm.buscarClientes(txt_buscar.Text)
        dg_Clientes.DataMember = "Cliente"
    End Sub

    Private Sub btn_Alquilar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Alquilar.Click
        Dim alq As New Alquilar
        alq.lbl_CodCliente.Text = dg_Clientes.SelectedCells(0).Value.ToString
        Me.Hide()
        alq.Show()
    End Sub

    Private Sub btn_Devolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Devolver.Click
        Dim dev As New Devolver
        dev.cli = dg_Clientes.SelectedRows.Item(0).Cells.Item(0).Value
        dev.Show()
        Me.Hide()
    End Sub
End Class