<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Peliculas_A
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
        Me.btn_Nuevo = New System.Windows.Forms.Button()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Atras = New System.Windows.Forms.Button()
        Me.lbl_Buscar = New System.Windows.Forms.Label()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.dg_Peliculas = New System.Windows.Forms.DataGridView()
        CType(Me.dg_Peliculas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_Nuevo.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_Nuevo.Image = Global.Videoclub_Trabajo_2_Trimestre.My.Resources.Resources.add
        Me.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Nuevo.Location = New System.Drawing.Point(567, 218)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(100, 30)
        Me.btn_Nuevo.TabIndex = 0
        Me.btn_Nuevo.Text = "Añadir"
        Me.btn_Nuevo.UseVisualStyleBackColor = False
        '
        'btn_Modificar
        '
        Me.btn_Modificar.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_Modificar.Image = Global.Videoclub_Trabajo_2_Trimestre.My.Resources.Resources.tools
        Me.btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Modificar.Location = New System.Drawing.Point(567, 254)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(100, 30)
        Me.btn_Modificar.TabIndex = 1
        Me.btn_Modificar.Text = "Modificar"
        Me.btn_Modificar.UseVisualStyleBackColor = False
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_Eliminar.Image = Global.Videoclub_Trabajo_2_Trimestre.My.Resources.Resources.delete
        Me.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Eliminar.Location = New System.Drawing.Point(673, 218)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(100, 30)
        Me.btn_Eliminar.TabIndex = 2
        Me.btn_Eliminar.Text = "Borrar"
        Me.btn_Eliminar.UseVisualStyleBackColor = False
        '
        'btn_Atras
        '
        Me.btn_Atras.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_Atras.Image = Global.Videoclub_Trabajo_2_Trimestre.My.Resources.Resources._return
        Me.btn_Atras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Atras.Location = New System.Drawing.Point(673, 254)
        Me.btn_Atras.Name = "btn_Atras"
        Me.btn_Atras.Size = New System.Drawing.Size(100, 30)
        Me.btn_Atras.TabIndex = 3
        Me.btn_Atras.Text = "Volver"
        Me.btn_Atras.UseVisualStyleBackColor = False
        '
        'lbl_Buscar
        '
        Me.lbl_Buscar.AutoSize = True
        Me.lbl_Buscar.Location = New System.Drawing.Point(564, 15)
        Me.lbl_Buscar.Name = "lbl_Buscar"
        Me.lbl_Buscar.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Buscar.TabIndex = 9
        Me.lbl_Buscar.Text = "Buscar"
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(610, 12)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(219, 20)
        Me.txt_buscar.TabIndex = 8
        '
        'dg_Peliculas
        '
        Me.dg_Peliculas.AllowUserToAddRows = False
        Me.dg_Peliculas.AllowUserToDeleteRows = False
        Me.dg_Peliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_Peliculas.Location = New System.Drawing.Point(12, 12)
        Me.dg_Peliculas.MultiSelect = False
        Me.dg_Peliculas.Name = "dg_Peliculas"
        Me.dg_Peliculas.ReadOnly = True
        Me.dg_Peliculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_Peliculas.Size = New System.Drawing.Size(543, 272)
        Me.dg_Peliculas.TabIndex = 10
        '
        'Peliculas_A
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(785, 296)
        Me.Controls.Add(Me.dg_Peliculas)
        Me.Controls.Add(Me.lbl_Buscar)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.btn_Atras)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Modificar)
        Me.Controls.Add(Me.btn_Nuevo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Peliculas_A"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Peliculas"
        CType(Me.dg_Peliculas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Atras As System.Windows.Forms.Button
    Friend WithEvents lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents dg_Peliculas As System.Windows.Forms.DataGridView
End Class
