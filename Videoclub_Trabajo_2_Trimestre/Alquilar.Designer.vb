<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alquilar
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
        Me.dg_Peliculas = New System.Windows.Forms.DataGridView()
        Me.lbl_Peliculas = New System.Windows.Forms.Label()
        Me.lbl_Alquileres = New System.Windows.Forms.Label()
        Me.lbl_Buscar = New System.Windows.Forms.Label()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.lbl_Cabecero = New System.Windows.Forms.Label()
        Me.dg_Alquileres = New System.Windows.Forms.DataGridView()
        Me.cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.director = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.protagonistas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.genero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_CodCliente = New System.Windows.Forms.Label()
        Me.gb_Genero = New System.Windows.Forms.GroupBox()
        Me.rb_Todos = New System.Windows.Forms.RadioButton()
        Me.rb_Documental = New System.Windows.Forms.RadioButton()
        Me.rb_Terror = New System.Windows.Forms.RadioButton()
        Me.rb_Ciencia = New System.Windows.Forms.RadioButton()
        Me.rb_Animacion = New System.Windows.Forms.RadioButton()
        Me.rb_Accion = New System.Windows.Forms.RadioButton()
        Me.txt_Duracion = New System.Windows.Forms.TextBox()
        Me.lbl_Numero = New System.Windows.Forms.Label()
        Me.btn_Menos = New System.Windows.Forms.Button()
        Me.btn_Mas = New System.Windows.Forms.Button()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Aceptar = New System.Windows.Forms.Button()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Agregar = New System.Windows.Forms.Button()
        CType(Me.dg_Peliculas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_Alquileres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_Genero.SuspendLayout()
        Me.SuspendLayout()
        '
        'dg_Peliculas
        '
        Me.dg_Peliculas.AllowUserToAddRows = False
        Me.dg_Peliculas.AllowUserToDeleteRows = False
        Me.dg_Peliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_Peliculas.Location = New System.Drawing.Point(12, 59)
        Me.dg_Peliculas.MultiSelect = False
        Me.dg_Peliculas.Name = "dg_Peliculas"
        Me.dg_Peliculas.ReadOnly = True
        Me.dg_Peliculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_Peliculas.Size = New System.Drawing.Size(544, 235)
        Me.dg_Peliculas.TabIndex = 11
        '
        'lbl_Peliculas
        '
        Me.lbl_Peliculas.AutoSize = True
        Me.lbl_Peliculas.Location = New System.Drawing.Point(9, 43)
        Me.lbl_Peliculas.Name = "lbl_Peliculas"
        Me.lbl_Peliculas.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Peliculas.TabIndex = 13
        Me.lbl_Peliculas.Text = "Peliculas"
        '
        'lbl_Alquileres
        '
        Me.lbl_Alquileres.AutoSize = True
        Me.lbl_Alquileres.Location = New System.Drawing.Point(12, 300)
        Me.lbl_Alquileres.Name = "lbl_Alquileres"
        Me.lbl_Alquileres.Size = New System.Drawing.Size(52, 13)
        Me.lbl_Alquileres.TabIndex = 14
        Me.lbl_Alquileres.Text = "Alquileres"
        '
        'lbl_Buscar
        '
        Me.lbl_Buscar.AutoSize = True
        Me.lbl_Buscar.Location = New System.Drawing.Point(339, 9)
        Me.lbl_Buscar.Name = "lbl_Buscar"
        Me.lbl_Buscar.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Buscar.TabIndex = 17
        Me.lbl_Buscar.Text = "Buscar"
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(387, 6)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(169, 20)
        Me.txt_buscar.TabIndex = 16
        '
        'lbl_Cabecero
        '
        Me.lbl_Cabecero.AutoSize = True
        Me.lbl_Cabecero.Location = New System.Drawing.Point(9, 9)
        Me.lbl_Cabecero.Name = "lbl_Cabecero"
        Me.lbl_Cabecero.Size = New System.Drawing.Size(170, 13)
        Me.lbl_Cabecero.TabIndex = 19
        Me.lbl_Cabecero.Text = "Alquiler de pelicula para el cliente: "
        '
        'dg_Alquileres
        '
        Me.dg_Alquileres.AllowUserToAddRows = False
        Me.dg_Alquileres.AllowUserToDeleteRows = False
        Me.dg_Alquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_Alquileres.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod, Me.nombre, Me.director, Me.protagonistas, Me.genero})
        Me.dg_Alquileres.Location = New System.Drawing.Point(12, 323)
        Me.dg_Alquileres.MultiSelect = False
        Me.dg_Alquileres.Name = "dg_Alquileres"
        Me.dg_Alquileres.ReadOnly = True
        Me.dg_Alquileres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_Alquileres.Size = New System.Drawing.Size(544, 237)
        Me.dg_Alquileres.TabIndex = 20
        '
        'cod
        '
        Me.cod.HeaderText = "cod"
        Me.cod.Name = "cod"
        Me.cod.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.HeaderText = "nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'director
        '
        Me.director.HeaderText = "director"
        Me.director.Name = "director"
        Me.director.ReadOnly = True
        '
        'protagonistas
        '
        Me.protagonistas.HeaderText = "protagonistas"
        Me.protagonistas.Name = "protagonistas"
        Me.protagonistas.ReadOnly = True
        '
        'genero
        '
        Me.genero.HeaderText = "genero"
        Me.genero.Name = "genero"
        Me.genero.ReadOnly = True
        '
        'lbl_CodCliente
        '
        Me.lbl_CodCliente.AutoSize = True
        Me.lbl_CodCliente.Location = New System.Drawing.Point(185, 9)
        Me.lbl_CodCliente.Name = "lbl_CodCliente"
        Me.lbl_CodCliente.Size = New System.Drawing.Size(0, 13)
        Me.lbl_CodCliente.TabIndex = 22
        '
        'gb_Genero
        '
        Me.gb_Genero.Controls.Add(Me.rb_Todos)
        Me.gb_Genero.Controls.Add(Me.rb_Documental)
        Me.gb_Genero.Controls.Add(Me.rb_Terror)
        Me.gb_Genero.Controls.Add(Me.rb_Ciencia)
        Me.gb_Genero.Controls.Add(Me.rb_Animacion)
        Me.gb_Genero.Controls.Add(Me.rb_Accion)
        Me.gb_Genero.Location = New System.Drawing.Point(652, 54)
        Me.gb_Genero.Name = "gb_Genero"
        Me.gb_Genero.Size = New System.Drawing.Size(116, 165)
        Me.gb_Genero.TabIndex = 24
        Me.gb_Genero.TabStop = False
        Me.gb_Genero.Text = "Generos"
        '
        'rb_Todos
        '
        Me.rb_Todos.AutoSize = True
        Me.rb_Todos.Checked = True
        Me.rb_Todos.Location = New System.Drawing.Point(6, 19)
        Me.rb_Todos.Name = "rb_Todos"
        Me.rb_Todos.Size = New System.Drawing.Size(55, 17)
        Me.rb_Todos.TabIndex = 5
        Me.rb_Todos.TabStop = True
        Me.rb_Todos.Text = "Todos"
        Me.rb_Todos.UseVisualStyleBackColor = True
        '
        'rb_Documental
        '
        Me.rb_Documental.AutoSize = True
        Me.rb_Documental.Location = New System.Drawing.Point(6, 136)
        Me.rb_Documental.Name = "rb_Documental"
        Me.rb_Documental.Size = New System.Drawing.Size(82, 17)
        Me.rb_Documental.TabIndex = 4
        Me.rb_Documental.Text = "Documental"
        Me.rb_Documental.UseVisualStyleBackColor = True
        '
        'rb_Terror
        '
        Me.rb_Terror.AutoSize = True
        Me.rb_Terror.Location = New System.Drawing.Point(6, 113)
        Me.rb_Terror.Name = "rb_Terror"
        Me.rb_Terror.Size = New System.Drawing.Size(53, 17)
        Me.rb_Terror.TabIndex = 3
        Me.rb_Terror.Text = "Terror"
        Me.rb_Terror.UseVisualStyleBackColor = True
        '
        'rb_Ciencia
        '
        Me.rb_Ciencia.AutoSize = True
        Me.rb_Ciencia.Location = New System.Drawing.Point(6, 88)
        Me.rb_Ciencia.Name = "rb_Ciencia"
        Me.rb_Ciencia.Size = New System.Drawing.Size(97, 17)
        Me.rb_Ciencia.TabIndex = 2
        Me.rb_Ciencia.Text = "Ciencia Ficción"
        Me.rb_Ciencia.UseVisualStyleBackColor = True
        '
        'rb_Animacion
        '
        Me.rb_Animacion.AutoSize = True
        Me.rb_Animacion.Location = New System.Drawing.Point(6, 65)
        Me.rb_Animacion.Name = "rb_Animacion"
        Me.rb_Animacion.Size = New System.Drawing.Size(74, 17)
        Me.rb_Animacion.TabIndex = 1
        Me.rb_Animacion.Text = "Animación"
        Me.rb_Animacion.UseVisualStyleBackColor = True
        '
        'rb_Accion
        '
        Me.rb_Accion.AutoSize = True
        Me.rb_Accion.Location = New System.Drawing.Point(6, 42)
        Me.rb_Accion.Name = "rb_Accion"
        Me.rb_Accion.Size = New System.Drawing.Size(58, 17)
        Me.rb_Accion.TabIndex = 0
        Me.rb_Accion.Text = "Acción"
        Me.rb_Accion.UseVisualStyleBackColor = True
        '
        'txt_Duracion
        '
        Me.txt_Duracion.Enabled = False
        Me.txt_Duracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Duracion.Location = New System.Drawing.Point(694, 339)
        Me.txt_Duracion.Name = "txt_Duracion"
        Me.txt_Duracion.Size = New System.Drawing.Size(29, 20)
        Me.txt_Duracion.TabIndex = 25
        Me.txt_Duracion.Text = "2"
        '
        'lbl_Numero
        '
        Me.lbl_Numero.AutoSize = True
        Me.lbl_Numero.Location = New System.Drawing.Point(670, 323)
        Me.lbl_Numero.Name = "lbl_Numero"
        Me.lbl_Numero.Size = New System.Drawing.Size(83, 13)
        Me.lbl_Numero.TabIndex = 28
        Me.lbl_Numero.Text = "Número de días"
        '
        'btn_Menos
        '
        Me.btn_Menos.Image = Global.Videoclub_Trabajo_2_Trimestre.My.Resources.Resources.menos
        Me.btn_Menos.Location = New System.Drawing.Point(673, 365)
        Me.btn_Menos.Name = "btn_Menos"
        Me.btn_Menos.Size = New System.Drawing.Size(34, 34)
        Me.btn_Menos.TabIndex = 27
        Me.btn_Menos.UseVisualStyleBackColor = True
        '
        'btn_Mas
        '
        Me.btn_Mas.Image = Global.Videoclub_Trabajo_2_Trimestre.My.Resources.Resources.mas
        Me.btn_Mas.Location = New System.Drawing.Point(706, 365)
        Me.btn_Mas.Name = "btn_Mas"
        Me.btn_Mas.Size = New System.Drawing.Size(34, 34)
        Me.btn_Mas.TabIndex = 26
        Me.btn_Mas.UseVisualStyleBackColor = True
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_Eliminar.Enabled = False
        Me.btn_Eliminar.Image = Global.Videoclub_Trabajo_2_Trimestre.My.Resources.Resources.carrito_menos
        Me.btn_Eliminar.Location = New System.Drawing.Point(562, 323)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(70, 70)
        Me.btn_Eliminar.TabIndex = 23
        Me.btn_Eliminar.UseVisualStyleBackColor = False
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_Aceptar.Image = Global.Videoclub_Trabajo_2_Trimestre.My.Resources.Resources.ok
        Me.btn_Aceptar.Location = New System.Drawing.Point(562, 460)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(100, 100)
        Me.btn_Aceptar.TabIndex = 21
        Me.btn_Aceptar.UseVisualStyleBackColor = False
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_Cancelar.Image = Global.Videoclub_Trabajo_2_Trimestre.My.Resources.Resources.cancel96
        Me.btn_Cancelar.Location = New System.Drawing.Point(668, 460)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(100, 100)
        Me.btn_Cancelar.TabIndex = 18
        Me.btn_Cancelar.UseVisualStyleBackColor = False
        '
        'btn_Agregar
        '
        Me.btn_Agregar.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_Agregar.Image = Global.Videoclub_Trabajo_2_Trimestre.My.Resources.Resources.carrito
        Me.btn_Agregar.Location = New System.Drawing.Point(562, 59)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(70, 70)
        Me.btn_Agregar.TabIndex = 15
        Me.btn_Agregar.UseVisualStyleBackColor = False
        '
        'Alquilar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(778, 572)
        Me.Controls.Add(Me.lbl_Numero)
        Me.Controls.Add(Me.btn_Menos)
        Me.Controls.Add(Me.btn_Mas)
        Me.Controls.Add(Me.txt_Duracion)
        Me.Controls.Add(Me.gb_Genero)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.lbl_CodCliente)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.dg_Alquileres)
        Me.Controls.Add(Me.lbl_Cabecero)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.lbl_Buscar)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.btn_Agregar)
        Me.Controls.Add(Me.lbl_Alquileres)
        Me.Controls.Add(Me.lbl_Peliculas)
        Me.Controls.Add(Me.dg_Peliculas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Alquilar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alquilar"
        CType(Me.dg_Peliculas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_Alquileres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_Genero.ResumeLayout(False)
        Me.gb_Genero.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dg_Peliculas As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_Peliculas As System.Windows.Forms.Label
    Friend WithEvents lbl_Alquileres As System.Windows.Forms.Label
    Friend WithEvents btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents lbl_Cabecero As System.Windows.Forms.Label
    Friend WithEvents dg_Alquileres As System.Windows.Forms.DataGridView
    Friend WithEvents cod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents lbl_CodCliente As System.Windows.Forms.Label
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents director As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents protagonistas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents genero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gb_Genero As System.Windows.Forms.GroupBox
    Friend WithEvents rb_Todos As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Documental As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Terror As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Ciencia As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Animacion As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Accion As System.Windows.Forms.RadioButton
    Friend WithEvents txt_Duracion As System.Windows.Forms.TextBox
    Friend WithEvents btn_Mas As System.Windows.Forms.Button
    Friend WithEvents btn_Menos As System.Windows.Forms.Button
    Friend WithEvents lbl_Numero As System.Windows.Forms.Label
End Class
