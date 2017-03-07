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
        Me.btn_crear = New System.Windows.Forms.Button()
        Me.dgv_postulantes = New System.Windows.Forms.DataGridView()
        Me.btn_pos_editar = New System.Windows.Forms.Button()
        Me.btn_pos_eliminar = New System.Windows.Forms.Button()
        Me.btn_pos_cerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado_civil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_postulantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_crear
        '
        Me.btn_crear.Location = New System.Drawing.Point(724, 76)
        Me.btn_crear.Name = "btn_crear"
        Me.btn_crear.Size = New System.Drawing.Size(124, 23)
        Me.btn_crear.TabIndex = 71
        Me.btn_crear.Text = "Crear"
        Me.btn_crear.UseVisualStyleBackColor = True
        '
        'dgv_postulantes
        '
        Me.dgv_postulantes.AllowUserToResizeRows = False
        Me.dgv_postulantes.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_postulantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_postulantes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dni, Me.apellido, Me.nombre, Me.estado_civil})
        Me.dgv_postulantes.Location = New System.Drawing.Point(13, 76)
        Me.dgv_postulantes.Name = "dgv_postulantes"
        Me.dgv_postulantes.RowHeadersVisible = False
        Me.dgv_postulantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_postulantes.Size = New System.Drawing.Size(705, 471)
        Me.dgv_postulantes.TabIndex = 65
        '
        'btn_pos_editar
        '
        Me.btn_pos_editar.Location = New System.Drawing.Point(724, 105)
        Me.btn_pos_editar.Name = "btn_pos_editar"
        Me.btn_pos_editar.Size = New System.Drawing.Size(124, 23)
        Me.btn_pos_editar.TabIndex = 80
        Me.btn_pos_editar.Text = "Editar"
        Me.btn_pos_editar.UseVisualStyleBackColor = True
        '
        'btn_pos_eliminar
        '
        Me.btn_pos_eliminar.Location = New System.Drawing.Point(724, 134)
        Me.btn_pos_eliminar.Name = "btn_pos_eliminar"
        Me.btn_pos_eliminar.Size = New System.Drawing.Size(124, 23)
        Me.btn_pos_eliminar.TabIndex = 81
        Me.btn_pos_eliminar.Text = "Eliminar"
        Me.btn_pos_eliminar.UseVisualStyleBackColor = True
        '
        'btn_pos_cerrar
        '
        Me.btn_pos_cerrar.Location = New System.Drawing.Point(724, 163)
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
        'dni
        '
        Me.dni.DataPropertyName = "nro_doc"
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
        Me.estado_civil.DataPropertyName = "estado_civil"
        Me.estado_civil.HeaderText = "Estado Civil"
        Me.estado_civil.Name = "estado_civil"
        Me.estado_civil.ReadOnly = True
        '
        'Postulantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 640)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_pos_cerrar)
        Me.Controls.Add(Me.btn_pos_eliminar)
        Me.Controls.Add(Me.btn_pos_editar)
        Me.Controls.Add(Me.btn_crear)
        Me.Controls.Add(Me.dgv_postulantes)
        Me.Name = "Postulantes"
        Me.Text = "Postulantes"
        CType(Me.dgv_postulantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_crear As Button
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
