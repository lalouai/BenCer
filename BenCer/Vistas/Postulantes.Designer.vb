<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Postulantes
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
        Me.btn_crear = New System.Windows.Forms.Button()
        Me.txt_pos_dni = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.dgv_postulantes = New System.Windows.Forms.DataGridView()
        Me.dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado_civil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_pos_editar = New System.Windows.Forms.Button()
        Me.btn_pos_eliminar = New System.Windows.Forms.Button()
        Me.btn_pos_cerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgv_postulantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_error
        '
        Me.lbl_error.AutoSize = True
        Me.lbl_error.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_error.ForeColor = System.Drawing.Color.Red
        Me.lbl_error.Location = New System.Drawing.Point(13, 597)
        Me.lbl_error.Name = "lbl_error"
        Me.lbl_error.Size = New System.Drawing.Size(87, 13)
        Me.lbl_error.TabIndex = 78
        Me.lbl_error.Text = "XX-XXX-XXXX"
        Me.lbl_error.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(225, 707)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "Estado Civil"
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(293, 704)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(169, 21)
        Me.cmbEstado.TabIndex = 70
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(476, 641)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "Apellidos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(485, 619)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Documento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(615, 600)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Número"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(550, 600)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Tipo"
        '
        'cmbTipoDoc
        '
        Me.cmbTipoDoc.FormattingEnabled = True
        Me.cmbTipoDoc.Location = New System.Drawing.Point(553, 616)
        Me.cmbTipoDoc.Name = "cmbTipoDoc"
        Me.cmbTipoDoc.Size = New System.Drawing.Size(59, 21)
        Me.cmbTipoDoc.TabIndex = 66
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(223, 641)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Nombres"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(479, 657)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(236, 20)
        Me.txtApellido.TabIndex = 69
        '
        'btn_crear
        '
        Me.btn_crear.Location = New System.Drawing.Point(737, 614)
        Me.btn_crear.Name = "btn_crear"
        Me.btn_crear.Size = New System.Drawing.Size(124, 23)
        Me.btn_crear.TabIndex = 71
        Me.btn_crear.Text = "Crear"
        Me.btn_crear.UseVisualStyleBackColor = True
        '
        'txt_pos_dni
        '
        Me.txt_pos_dni.Location = New System.Drawing.Point(618, 616)
        Me.txt_pos_dni.Name = "txt_pos_dni"
        Me.txt_pos_dni.Size = New System.Drawing.Size(97, 20)
        Me.txt_pos_dni.TabIndex = 67
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(226, 657)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(236, 20)
        Me.txtNombre.TabIndex = 68
        '
        'dgv_postulantes
        '
        Me.dgv_postulantes.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_postulantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_postulantes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dni, Me.apellido, Me.nombre, Me.estado_civil})
        Me.dgv_postulantes.Location = New System.Drawing.Point(13, 76)
        Me.dgv_postulantes.Name = "dgv_postulantes"
        Me.dgv_postulantes.RowHeadersVisible = False
        Me.dgv_postulantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_postulantes.Size = New System.Drawing.Size(705, 518)
        Me.dgv_postulantes.TabIndex = 65
        '
        'dni
        '
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
        Me.nombre.Width = 200
        '
        'estado_civil
        '
        Me.estado_civil.DataPropertyName = "estado_civil"
        Me.estado_civil.HeaderText = "Estado Civil"
        Me.estado_civil.Name = "estado_civil"
        Me.estado_civil.ReadOnly = True
        '
        'btn_pos_editar
        '
        Me.btn_pos_editar.Location = New System.Drawing.Point(737, 76)
        Me.btn_pos_editar.Name = "btn_pos_editar"
        Me.btn_pos_editar.Size = New System.Drawing.Size(124, 23)
        Me.btn_pos_editar.TabIndex = 80
        Me.btn_pos_editar.Text = "Editar"
        Me.btn_pos_editar.UseVisualStyleBackColor = True
        '
        'btn_pos_eliminar
        '
        Me.btn_pos_eliminar.Location = New System.Drawing.Point(737, 122)
        Me.btn_pos_eliminar.Name = "btn_pos_eliminar"
        Me.btn_pos_eliminar.Size = New System.Drawing.Size(124, 23)
        Me.btn_pos_eliminar.TabIndex = 81
        Me.btn_pos_eliminar.Text = "Eliminar"
        Me.btn_pos_eliminar.UseVisualStyleBackColor = True
        '
        'btn_pos_cerrar
        '
        Me.btn_pos_cerrar.Location = New System.Drawing.Point(737, 571)
        Me.btn_pos_cerrar.Name = "btn_pos_cerrar"
        Me.btn_pos_cerrar.Size = New System.Drawing.Size(124, 23)
        Me.btn_pos_cerrar.TabIndex = 82
        Me.btn_pos_cerrar.Text = "Cerrar"
        Me.btn_pos_cerrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(649, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 37)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Postulantes"
        '
        'Postulantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 762)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_pos_cerrar)
        Me.Controls.Add(Me.btn_pos_eliminar)
        Me.Controls.Add(Me.btn_pos_editar)
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
        Me.Controls.Add(Me.btn_crear)
        Me.Controls.Add(Me.txt_pos_dni)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.dgv_postulantes)
        Me.Name = "Postulantes"
        Me.Text = "Postulantes"
        CType(Me.dgv_postulantes, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btn_crear As Button
    Friend WithEvents txt_pos_dni As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents dgv_postulantes As DataGridView
    Friend WithEvents btn_pos_editar As Button
    Friend WithEvents btn_pos_eliminar As Button
    Friend WithEvents btn_pos_cerrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dni As DataGridViewTextBoxColumn
    Friend WithEvents apellido As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents estado_civil As DataGridViewTextBoxColumn
End Class
