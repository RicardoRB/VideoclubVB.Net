<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alquileres
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
        Me.btn_Atras = New System.Windows.Forms.Button()
        Me.dg_Alquileres = New System.Windows.Forms.DataGridView()
        CType(Me.dg_Alquileres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Atras
        '
        Me.btn_Atras.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_Atras.Image = Global.Videoclub_Trabajo_2_Trimestre.My.Resources.Resources._return
        Me.btn_Atras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Atras.Location = New System.Drawing.Point(632, 254)
        Me.btn_Atras.Name = "btn_Atras"
        Me.btn_Atras.Size = New System.Drawing.Size(100, 30)
        Me.btn_Atras.TabIndex = 1
        Me.btn_Atras.Text = "Volver"
        Me.btn_Atras.UseVisualStyleBackColor = False
        '
        'dg_Alquileres
        '
        Me.dg_Alquileres.AllowUserToAddRows = False
        Me.dg_Alquileres.AllowUserToDeleteRows = False
        Me.dg_Alquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_Alquileres.Location = New System.Drawing.Point(12, 10)
        Me.dg_Alquileres.MultiSelect = False
        Me.dg_Alquileres.Name = "dg_Alquileres"
        Me.dg_Alquileres.ReadOnly = True
        Me.dg_Alquileres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_Alquileres.Size = New System.Drawing.Size(456, 274)
        Me.dg_Alquileres.TabIndex = 21
        '
        'Alquileres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(744, 296)
        Me.Controls.Add(Me.dg_Alquileres)
        Me.Controls.Add(Me.btn_Atras)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Alquileres"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alquileres"
        CType(Me.dg_Alquileres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Atras As System.Windows.Forms.Button
    Friend WithEvents dg_Alquileres As System.Windows.Forms.DataGridView
End Class
