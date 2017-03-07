<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PostulantesAlta
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
        Me.lbl_error = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbTipoDoc = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txt_pos_dni = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.titulo = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_grupo_fliar = New System.Windows.Forms.Button()
        Me.dgv_familiares = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_agregar_fliar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.dgv_familiares, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_error
        '
        Me.lbl_error.AutoSize = True
        Me.lbl_error.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_error.ForeColor = System.Drawing.Color.Red
        Me.lbl_error.Location = New System.Drawing.Point(12, 199)
        Me.lbl_error.Name = "lbl_error"
        Me.lbl_error.Size = New System.Drawing.Size(87, 13)
        Me.lbl_error.TabIndex = 90
        Me.lbl_error.Text = "XX-XXX-XXXX"
        Me.lbl_error.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(292, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "Estado Civil"
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(360, 142)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(169, 21)
        Me.cmbEstado.TabIndex = 83
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Apellidos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(466, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "Documento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(429, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Número"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(292, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Tipo"
        '
        'cmbTipoDoc
        '
        Me.cmbTipoDoc.FormattingEnabled = True
        Me.cmbTipoDoc.Location = New System.Drawing.Point(295, 99)
        Me.cmbTipoDoc.Name = "cmbTipoDoc"
        Me.cmbTipoDoc.Size = New System.Drawing.Size(106, 21)
        Me.cmbTipoDoc.TabIndex = 79
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Nombres"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(15, 99)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(236, 20)
        Me.txtApellido.TabIndex = 82
        '
        'txt_pos_dni
        '
        Me.txt_pos_dni.Location = New System.Drawing.Point(432, 100)
        Me.txt_pos_dni.Name = "txt_pos_dni"
        Me.txt_pos_dni.Size = New System.Drawing.Size(97, 20)
        Me.txt_pos_dni.TabIndex = 80
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(15, 142)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(236, 20)
        Me.txtNombre.TabIndex = 81
        '
        'titulo
        '
        Me.titulo.AutoSize = True
        Me.titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titulo.Location = New System.Drawing.Point(271, 9)
        Me.titulo.Name = "titulo"
        Me.titulo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.titulo.Size = New System.Drawing.Size(265, 37)
        Me.titulo.TabIndex = 91
        Me.titulo.Text = "Alta Postulantes"
        Me.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(453, 226)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar.TabIndex = 92
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(372, 226)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 93
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btn_grupo_fliar
        '
        Me.btn_grupo_fliar.Location = New System.Drawing.Point(15, 226)
        Me.btn_grupo_fliar.Name = "btn_grupo_fliar"
        Me.btn_grupo_fliar.Size = New System.Drawing.Size(84, 23)
        Me.btn_grupo_fliar.TabIndex = 94
        Me.btn_grupo_fliar.Text = "Grupo Familiar"
        Me.btn_grupo_fliar.UseVisualStyleBackColor = True
        '
        'dgv_familiares
        '
        Me.dgv_familiares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_familiares.Location = New System.Drawing.Point(554, 99)
        Me.dgv_familiares.Name = "dgv_familiares"
        Me.dgv_familiares.RowHeadersVisible = False
        Me.dgv_familiares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_familiares.Size = New System.Drawing.Size(297, 150)
        Me.dgv_familiares.TabIndex = 95
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(777, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "Grupo Familiar"
        '
        'btn_agregar_fliar
        '
        Me.btn_agregar_fliar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar_fliar.Location = New System.Drawing.Point(827, 73)
        Me.btn_agregar_fliar.Name = "btn_agregar_fliar"
        Me.btn_agregar_fliar.Size = New System.Drawing.Size(24, 23)
        Me.btn_agregar_fliar.TabIndex = 97
        Me.btn_agregar_fliar.Text = "+"
        Me.btn_agregar_fliar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(551, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(170, 13)
        Me.Label8.TabIndex = 98
        Me.Label8.Text = "Recuerde agregar los parentezcos"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(554, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(187, 13)
        Me.Label9.TabIndex = 99
        Me.Label9.Text = "para una mejor comprension del grupo"
        '
        'PostulantesAlta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 261)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_agregar_fliar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_familiares)
        Me.Controls.Add(Me.btn_grupo_fliar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.titulo)
        Me.Controls.Add(Me.lbl_error)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbEstado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbTipoDoc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txt_pos_dni)
        Me.Controls.Add(Me.txtNombre)
        Me.Name = "PostulantesAlta"
        Me.Text = "PostulantesAlta"
        CType(Me.dgv_familiares, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_error As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbTipoDoc As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txt_pos_dni As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents titulo As Label
    Friend WithEvents btn_guardar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_grupo_fliar As Button
    Friend WithEvents dgv_familiares As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_agregar_fliar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
