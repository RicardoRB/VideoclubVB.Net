<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Devolver
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
        Me.btn_Devolver = New System.Windows.Forms.Button()
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.dg_Alquileres = New System.Windows.Forms.DataGridView()
        CType(Me.dg_Alquileres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Devolver
        '
        Me.btn_Devolver.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_Devolver.Image = Global.Videoclub_Trabajo_2_Trimestre.My.Resources.Resources.give_back
        Me.btn_Devolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Devolver.Location = New System.Drawing.Point(526, 254)
        Me.btn_Devolver.Name = "btn_Devolver"
        Me.btn_Devolver.Size = New System.Drawing.Size(100, 30)
        Me.btn_Devolver.TabIndex = 1
        Me.btn_Devolver.Text = "Devolver"
        Me.btn_Devolver.UseVisualStyleBackColor = False
        '
        'btn_Salir
        '
        Me.btn_Salir.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_Salir.Image = Global.Videoclub_Trabajo_2_Trimestre.My.Resources.Resources._return
        Me.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Salir.Location = New System.Drawing.Point(632, 254)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(100, 30)
        Me.btn_Salir.TabIndex = 2
        Me.btn_Salir.Text = "Volver"
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'dg_Alquileres
        '
        Me.dg_Alquileres.AllowUserToAddRows = False
        Me.dg_Alquileres.AllowUserToDeleteRows = False
        Me.dg_Alquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_Alquileres.Location = New System.Drawing.Point(12, 12)
        Me.dg_Alquileres.MultiSelect = False
        Me.dg_Alquileres.Name = "dg_Alquileres"
        Me.dg_Alquileres.ReadOnly = True
        Me.dg_Alquileres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_Alquileres.Size = New System.Drawing.Size(447, 272)
        Me.dg_Alquileres.TabIndex = 22
        '
        'Devolver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(744, 296)
        Me.Controls.Add(Me.dg_Alquileres)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Devolver)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Devolver"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Devolver Alquiler"
        CType(Me.dg_Alquileres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Devolver As System.Windows.Forms.Button
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents dg_Alquileres As System.Windows.Forms.DataGridView
End Class
