<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Obras
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_obras = New System.Windows.Forms.DataGridView()
        Me.btn_obra_editar = New System.Windows.Forms.Button()
        Me.btn_obra_certificar = New System.Windows.Forms.Button()
        Me.btn_obra_ver = New System.Windows.Forms.Button()
        Me.btn_obra_cerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.beneficiario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prototipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.programa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.constructor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_obras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_obras
        '
        Me.dgv_obras.AllowUserToResizeRows = False
        Me.dgv_obras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_obras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.beneficiario, Me.prototipo, Me.programa, Me.constructor, Me.estado})
        Me.dgv_obras.Location = New System.Drawing.Point(12, 63)
        Me.dgv_obras.Name = "dgv_obras"
        Me.dgv_obras.RowHeadersVisible = False
        Me.dgv_obras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_obras.Size = New System.Drawing.Size(798, 557)
        Me.dgv_obras.TabIndex = 0
        '
        'btn_obra_editar
        '
        Me.btn_obra_editar.Location = New System.Drawing.Point(816, 63)
        Me.btn_obra_editar.Name = "btn_obra_editar"
        Me.btn_obra_editar.Size = New System.Drawing.Size(110, 23)
        Me.btn_obra_editar.TabIndex = 1
        Me.btn_obra_editar.Text = "Editar"
        Me.btn_obra_editar.UseVisualStyleBackColor = True
        '
        'btn_obra_certificar
        '
        Me.btn_obra_certificar.Location = New System.Drawing.Point(816, 121)
        Me.btn_obra_certificar.Name = "btn_obra_certificar"
        Me.btn_obra_certificar.Size = New System.Drawing.Size(110, 23)
        Me.btn_obra_certificar.TabIndex = 2
        Me.btn_obra_certificar.Text = "Certificar"
        Me.btn_obra_certificar.UseVisualStyleBackColor = True
        '
        'btn_obra_ver
        '
        Me.btn_obra_ver.Location = New System.Drawing.Point(816, 92)
        Me.btn_obra_ver.Name = "btn_obra_ver"
        Me.btn_obra_ver.Size = New System.Drawing.Size(110, 23)
        Me.btn_obra_ver.TabIndex = 4
        Me.btn_obra_ver.Text = "Ver Detalle"
        Me.btn_obra_ver.UseVisualStyleBackColor = True
        '
        'btn_obra_cerrar
        '
        Me.btn_obra_cerrar.Location = New System.Drawing.Point(817, 597)
        Me.btn_obra_cerrar.Name = "btn_obra_cerrar"
        Me.btn_obra_cerrar.Size = New System.Drawing.Size(110, 23)
        Me.btn_obra_cerrar.TabIndex = 5
        Me.btn_obra_cerrar.Text = "Cerrar"
        Me.btn_obra_cerrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(817, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 37)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Obras"
        '
        'id
        '
        Me.id.DataPropertyName = "cod_obra"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.id.DefaultCellStyle = DataGridViewCellStyle2
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.id.Width = 50
        '
        'beneficiario
        '
        Me.beneficiario.DataPropertyName = "beneficiario"
        Me.beneficiario.HeaderText = "Beneficiario"
        Me.beneficiario.Name = "beneficiario"
        Me.beneficiario.ReadOnly = True
        Me.beneficiario.Width = 200
        '
        'prototipo
        '
        Me.prototipo.DataPropertyName = "tipo_obra"
        Me.prototipo.HeaderText = "Prototipo"
        Me.prototipo.Name = "prototipo"
        Me.prototipo.ReadOnly = True
        Me.prototipo.Width = 150
        '
        'programa
        '
        Me.programa.DataPropertyName = "programa"
        Me.programa.HeaderText = "Programa"
        Me.programa.Name = "programa"
        Me.programa.ReadOnly = True
        Me.programa.Width = 180
        '
        'constructor
        '
        Me.constructor.DataPropertyName = "constructor"
        Me.constructor.HeaderText = "Constructor"
        Me.constructor.Name = "constructor"
        Me.constructor.ReadOnly = True
        Me.constructor.Width = 130
        '
        'estado
        '
        Me.estado.DataPropertyName = "estado"
        Me.estado.HeaderText = "Estado"
        Me.estado.Name = "estado"
        Me.estado.ReadOnly = True
        Me.estado.Width = 80
        '
        'Obras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 675)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_obra_cerrar)
        Me.Controls.Add(Me.btn_obra_ver)
        Me.Controls.Add(Me.btn_obra_certificar)
        Me.Controls.Add(Me.btn_obra_editar)
        Me.Controls.Add(Me.dgv_obras)
        Me.Name = "Obras"
        Me.Text = "Obras"
        CType(Me.dgv_obras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_obras As DataGridView
    Friend WithEvents btn_obra_editar As Button
    Friend WithEvents btn_obra_certificar As Button
    Friend WithEvents btn_obra_ver As Button
    Friend WithEvents btn_obra_cerrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents beneficiario As DataGridViewTextBoxColumn
    Friend WithEvents prototipo As DataGridViewTextBoxColumn
    Friend WithEvents programa As DataGridViewTextBoxColumn
    Friend WithEvents constructor As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
End Class
