Imports CrystalDecisions.CrystalReports.Engine

Public Class Informes

    Private Sub mi_Cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mi_Cliente.Click
        Dim crysrpt As New ReportDocument
        crysrpt.Load("..\..\Cliente.rpt")
        crv_Informes.ReportSource = crysrpt
        crv_Informes.Refresh()

    End Sub

    Private Sub Informes_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim respuesta As Integer
        respuesta = MsgBox("¿Esta seguro de que desea salir?", MsgBoxStyle.OkCancel)
        If respuesta = 1 Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Dim main As New MainWindow
        Me.Hide()
        main.Show()
    End Sub

    Private Sub mi_Pelicula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mi_Pelicula.Click
        Dim crysrpt As New ReportDocument
        crysrpt.Load("..\..\Pelicula.rpt")
        crv_Informes.ReportSource = crysrpt
        crv_Informes.Refresh()
    End Sub

    Private Sub mi_General_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mi_General.Click
        Dim crysrpt As New ReportDocument
        crysrpt.Load("..\..\General.rpt")
        crv_Informes.ReportSource = crysrpt
        crv_Informes.Refresh()
    End Sub
End Class