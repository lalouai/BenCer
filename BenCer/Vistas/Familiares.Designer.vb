<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Familiares
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_fam_cerrar = New System.Windows.Forms.Button()
        Me.txt_fam_cod_persona = New System.Windows.Forms.TextBox()
        Me.lbl_fam_persona_nombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_fam_error = New System.Windows.Forms.Label()
        Me.btn_fam_agregar = New System.Windows.Forms.Button()
        Me.btn_fam_eliminar = New System.Windows.Forms.Button()
        Me.btn_fam_editar = New System.Windows.Forms.Button()
        Me.dgv_familiares = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado_civil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.parentezco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_fam_estado_civil = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_fam_tipo_doc = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_fam_apellido = New System.Windows.Forms.TextBox()
        Me.txt_fam_dni = New System.Windows.Forms.TextBox()
        Me.txt_fam_nombre = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmb_fam_parentezco = New System.Windows.Forms.ComboBox()
        CType(Me.dgv_familiares, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_fam_cerrar
        '
        Me.btn_fam_cerrar.Location = New System.Drawing.Point(823, 498)
        Me.btn_fam_cerrar.Name = "btn_fam_cerrar"
        Me.btn_fam_cerrar.Size = New System.Drawing.Size(142, 23)
        Me.btn_fam_cerrar.TabIndex = 16
        Me.btn_fam_cerrar.Text = "Cerrar"
        Me.btn_fam_cerrar.UseVisualStyleBackColor = True
        '
        'txt_fam_cod_persona
        '
        Me.txt_fam_cod_persona.Location = New System.Drawing.Point(28, 62)
        Me.txt_fam_cod_persona.Name = "txt_fam_cod_persona"
        Me.txt_fam_cod_persona.Size = New System.Drawing.Size(42, 20)
        Me.txt_fam_cod_persona.TabIndex = 20
        Me.txt_fam_cod_persona.Visible = False
        '
        'lbl_fam_persona_nombre
        '
        Me.lbl_fam_persona_nombre.AutoSize = True
        Me.lbl_fam_persona_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fam_persona_nombre.Location = New System.Drawing.Point(123, 43)
        Me.lbl_fam_persona_nombre.Name = "lbl_fam_persona_nombre"
        Me.lbl_fam_persona_nombre.Size = New System.Drawing.Size(66, 16)
        Me.lbl_fam_persona_nombre.TabIndex = 19
        Me.lbl_fam_persona_nombre.Text = "Persona"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Apellido y Nombre"
        '
        'lbl_fam_error
        '
        Me.lbl_fam_error.AutoSize = True
        Me.lbl_fam_error.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fam_error.ForeColor = System.Drawing.Color.Red
        Me.lbl_fam_error.Location = New System.Drawing.Point(12, 553)
        Me.lbl_fam_error.Name = "lbl_fam_error"
        Me.lbl_fam_error.Size = New System.Drawing.Size(51, 15)
        Me.lbl_fam_error.TabIndex = 17
        Me.lbl_fam_error.Text = "Label1"
        Me.lbl_fam_error.Visible = False
        '
        'btn_fam_agregar
        '
        Me.btn_fam_agregar.Location = New System.Drawing.Point(823, 548)
        Me.btn_fam_agregar.Name = "btn_fam_agregar"
        Me.btn_fam_agregar.Size = New System.Drawing.Size(142, 23)
        Me.btn_fam_agregar.TabIndex = 12
        Me.btn_fam_agregar.Text = "Agregar"
        Me.btn_fam_agregar.UseVisualStyleBackColor = True
        '
        'btn_fam_eliminar
        '
        Me.btn_fam_eliminar.Location = New System.Drawing.Point(823, 124)
        Me.btn_fam_eliminar.Name = "btn_fam_eliminar"
        Me.btn_fam_eliminar.Size = New System.Drawing.Size(142, 23)
        Me.btn_fam_eliminar.TabIndex = 15
        Me.btn_fam_eliminar.Text = "Eliminar"
        Me.btn_fam_eliminar.UseVisualStyleBackColor = True
        '
        'btn_fam_editar
        '
        Me.btn_fam_editar.Location = New System.Drawing.Point(823, 95)
        Me.btn_fam_editar.Name = "btn_fam_editar"
        Me.btn_fam_editar.Size = New System.Drawing.Size(142, 23)
        Me.btn_fam_editar.TabIndex = 14
        Me.btn_fam_editar.Text = "Editar"
        Me.btn_fam_editar.UseVisualStyleBackColor = True
        '
        'dgv_familiares
        '
        Me.dgv_familiares.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_familiares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_familiares.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dni, Me.apellido, Me.nombre, Me.estado_civil, Me.parentezco})
        Me.dgv_familiares.Location = New System.Drawing.Point(12, 95)
        Me.dgv_familiares.Name = "dgv_familiares"
        Me.dgv_familiares.RowHeadersVisible = False
        Me.dgv_familiares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_familiares.Size = New System.Drawing.Size(805, 426)
        Me.dgv_familiares.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(789, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 37)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Familiares"
        '
        'dni
        '
        Me.dni.DataPropertyName = "nro_doc"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.dni.DefaultCellStyle = DataGridViewCellStyle6
        Me.dni.HeaderText = "DNI"
        Me.dni.Name = "dni"
        Me.dni.ReadOnly = True
        '
        'apellido
        '
        Me.apellido.DataPropertyName = "apellido"
        Me.apellido.HeaderText = "Apellido"
        Me.apellido.Name = "apellido"
        Me.apellido.ReadOnly = True
        Me.apellido.Width = 200
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 200
        '
        'estado_civil
        '
        Me.estado_civil.HeaderText = "Estado Civil"
        Me.estado_civil.Name = "estado_civil"
        Me.estado_civil.ReadOnly = True
        Me.estado_civil.Width = 150
        '
        'parentezco
        '
        Me.parentezco.HeaderText = "Parentezco"
        Me.parentezco.Name = "parentezco"
        Me.parentezco.ReadOnly = True
        Me.parentezco.Width = 150
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(327, 641)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "Estado Civil"
        '
        'cmb_fam_estado_civil
        '
        Me.cmb_fam_estado_civil.FormattingEnabled = True
        Me.cmb_fam_estado_civil.Location = New System.Drawing.Point(395, 638)
        Me.cmb_fam_estado_civil.Name = "cmb_fam_estado_civil"
        Me.cmb_fam_estado_civil.Size = New System.Drawing.Size(169, 21)
        Me.cmb_fam_estado_civil.TabIndex = 83
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(578, 575)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Apellidos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(587, 553)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "Documento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(717, 534)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Número"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(652, 534)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Tipo"
        '
        'cmb_fam_tipo_doc
        '
        Me.cmb_fam_tipo_doc.FormattingEnabled = True
        Me.cmb_fam_tipo_doc.Location = New System.Drawing.Point(655, 550)
        Me.cmb_fam_tipo_doc.Name = "cmb_fam_tipo_doc"
        Me.cmb_fam_tipo_doc.Size = New System.Drawing.Size(59, 21)
        Me.cmb_fam_tipo_doc.TabIndex = 79
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(325, 575)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 84
        Me.Label8.Text = "Nombres"
        '
        'txt_fam_apellido
        '
        Me.txt_fam_apellido.Location = New System.Drawing.Point(581, 591)
        Me.txt_fam_apellido.Name = "txt_fam_apellido"
        Me.txt_fam_apellido.Size = New System.Drawing.Size(236, 20)
        Me.txt_fam_apellido.TabIndex = 82
        '
        'txt_fam_dni
        '
        Me.txt_fam_dni.Location = New System.Drawing.Point(720, 550)
        Me.txt_fam_dni.Name = "txt_fam_dni"
        Me.txt_fam_dni.Size = New System.Drawing.Size(97, 20)
        Me.txt_fam_dni.TabIndex = 80
        '
        'txt_fam_nombre
        '
        Me.txt_fam_nombre.Location = New System.Drawing.Point(328, 591)
        Me.txt_fam_nombre.Name = "txt_fam_nombre"
        Me.txt_fam_nombre.Size = New System.Drawing.Size(236, 20)
        Me.txt_fam_nombre.TabIndex = 81
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(580, 641)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 91
        Me.Label9.Text = "Parentezco"
        '
        'cmb_fam_parentezco
        '
        Me.cmb_fam_parentezco.FormattingEnabled = True
        Me.cmb_fam_parentezco.Location = New System.Drawing.Point(648, 638)
        Me.cmb_fam_parentezco.Name = "cmb_fam_parentezco"
        Me.cmb_fam_parentezco.Size = New System.Drawing.Size(169, 21)
        Me.cmb_fam_parentezco.TabIndex = 90
        '
        'Familiares
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 672)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmb_fam_parentezco)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmb_fam_estado_civil)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_fam_tipo_doc)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_fam_apellido)
        Me.Controls.Add(Me.txt_fam_dni)
        Me.Controls.Add(Me.txt_fam_nombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_fam_cerrar)
        Me.Controls.Add(Me.txt_fam_cod_persona)
        Me.Controls.Add(Me.lbl_fam_persona_nombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_fam_error)
        Me.Controls.Add(Me.btn_fam_agregar)
        Me.Controls.Add(Me.btn_fam_eliminar)
        Me.Controls.Add(Me.btn_fam_editar)
        Me.Controls.Add(Me.dgv_familiares)
        Me.Name = "Familiares"
        Me.Text = "Familiares"
        CType(Me.dgv_familiares, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_fam_cerrar As Button
    Friend WithEvents txt_fam_cod_persona As TextBox
    Friend WithEvents lbl_fam_persona_nombre As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_fam_error As Label
    Friend WithEvents btn_fam_agregar As Button
    Friend WithEvents btn_fam_eliminar As Button
    Friend WithEvents btn_fam_editar As Button
    Friend WithEvents dgv_familiares As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents dni As DataGridViewTextBoxColumn
    Friend WithEvents apellido As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents estado_civil As DataGridViewTextBoxColumn
    Friend WithEvents parentezco As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents cmb_fam_estado_civil As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_fam_tipo_doc As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_fam_apellido As TextBox
    Friend WithEvents txt_fam_dni As TextBox
    Friend WithEvents txt_fam_nombre As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmb_fam_parentezco As ComboBox
End Class
