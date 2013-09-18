<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Informes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.crv_Informes = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.m_Informes = New System.Windows.Forms.MenuStrip()
        Me.InformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mi_General = New System.Windows.Forms.ToolStripMenuItem()
        Me.mi_Cliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.mi_Pelicula = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_Informes.SuspendLayout()
        Me.SuspendLayout()
        '
        'crv_Informes
        '
        Me.crv_Informes.ActiveViewIndex = -1
        Me.crv_Informes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_Informes.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv_Informes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv_Informes.Location = New System.Drawing.Point(0, 24)
        Me.crv_Informes.Name = "crv_Informes"
        Me.crv_Informes.Size = New System.Drawing.Size(794, 547)
        Me.crv_Informes.TabIndex = 0
        Me.crv_Informes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.ParameterPanel
        '
        'm_Informes
        '
        Me.m_Informes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformesToolStripMenuItem})
        Me.m_Informes.Location = New System.Drawing.Point(0, 0)
        Me.m_Informes.Name = "m_Informes"
        Me.m_Informes.Size = New System.Drawing.Size(794, 24)
        Me.m_Informes.TabIndex = 1
        Me.m_Informes.Text = "MenuStrip1"
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mi_General, Me.mi_Cliente, Me.mi_Pelicula, Me.SalirToolStripMenuItem})
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.InformesToolStripMenuItem.Text = "Informes"
        '
        'mi_General
        '
        Me.mi_General.Name = "mi_General"
        Me.mi_General.Size = New System.Drawing.Size(115, 22)
        Me.mi_General.Text = "General"
        '
        'mi_Cliente
        '
        Me.mi_Cliente.Name = "mi_Cliente"
        Me.mi_Cliente.Size = New System.Drawing.Size(115, 22)
        Me.mi_Cliente.Text = "Cliente"
        '
        'mi_Pelicula
        '
        Me.mi_Pelicula.Name = "mi_Pelicula"
        Me.mi_Pelicula.Size = New System.Drawing.Size(115, 22)
        Me.mi_Pelicula.Text = "Pelicula"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Informes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(794, 571)
        Me.Controls.Add(Me.crv_Informes)
        Me.Controls.Add(Me.m_Informes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.m_Informes
        Me.MaximizeBox = False
        Me.Name = "Informes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informes"
        Me.m_Informes.ResumeLayout(False)
        Me.m_Informes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents crv_Informes As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents m_Informes As System.Windows.Forms.MenuStrip
    Friend WithEvents InformesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mi_General As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mi_Cliente As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mi_Pelicula As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
