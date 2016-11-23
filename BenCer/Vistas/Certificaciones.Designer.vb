<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Certificaciones
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_cert_beneficiario = New System.Windows.Forms.DataGridView()
        Me.btn_cert_ver = New System.Windows.Forms.Button()
        Me.btn_cert_cerrar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgv_cert_certificados = New System.Windows.Forms.DataGridView()
        Me.txt_cert_filtrar_ben = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_cert = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.imprimir = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgv_cert_beneficiario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_cert_certificados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(601, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Certificados"
        '
        'dgv_cert_beneficiario
        '
        Me.dgv_cert_beneficiario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cert_beneficiario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dni, Me.apellido, Me.nombre})
        Me.dgv_cert_beneficiario.Location = New System.Drawing.Point(13, 74)
        Me.dgv_cert_beneficiario.Name = "dgv_cert_beneficiario"
        Me.dgv_cert_beneficiario.RowHeadersVisible = False
        Me.dgv_cert_beneficiario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_cert_beneficiario.Size = New System.Drawing.Size(305, 276)
        Me.dgv_cert_beneficiario.TabIndex = 2
        '
        'btn_cert_ver
        '
        Me.btn_cert_ver.Location = New System.Drawing.Point(676, 74)
        Me.btn_cert_ver.Name = "btn_cert_ver"
        Me.btn_cert_ver.Size = New System.Drawing.Size(123, 23)
        Me.btn_cert_ver.TabIndex = 4
        Me.btn_cert_ver.Text = "Ver"
        Me.btn_cert_ver.UseVisualStyleBackColor = True
        '
        'btn_cert_cerrar
        '
        Me.btn_cert_cerrar.Location = New System.Drawing.Point(677, 327)
        Me.btn_cert_cerrar.Name = "btn_cert_cerrar"
        Me.btn_cert_cerrar.Size = New System.Drawing.Size(122, 23)
        Me.btn_cert_cerrar.TabIndex = 5
        Me.btn_cert_cerrar.Text = "Cerrar"
        Me.btn_cert_cerrar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 392)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(486, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Para crear un nuevo certificado de avance, vaya a Obra, seleccionela y luego haga" &
    " click en certificar"
        '
        'dgv_cert_certificados
        '
        Me.dgv_cert_certificados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cert_certificados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.num_cert, Me.estado, Me.imprimir})
        Me.dgv_cert_certificados.Location = New System.Drawing.Point(324, 74)
        Me.dgv_cert_certificados.Name = "dgv_cert_certificados"
        Me.dgv_cert_certificados.RowHeadersVisible = False
        Me.dgv_cert_certificados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_cert_certificados.Size = New System.Drawing.Size(346, 276)
        Me.dgv_cert_certificados.TabIndex = 7
        '
        'txt_cert_filtrar_ben
        '
        Me.txt_cert_filtrar_ben.Location = New System.Drawing.Point(218, 356)
        Me.txt_cert_filtrar_ben.Name = "txt_cert_filtrar_ben"
        Me.txt_cert_filtrar_ben.Size = New System.Drawing.Size(100, 20)
        Me.txt_cert_filtrar_ben.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(180, 359)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Filtrar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Filtrar"
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
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'num_cert
        '
        Me.num_cert.DataPropertyName = "numero"
        Me.num_cert.HeaderText = "Certificado Nº"
        Me.num_cert.Name = "num_cert"
        Me.num_cert.ReadOnly = True
        '
        'estado
        '
        Me.estado.DataPropertyName = "estado"
        Me.estado.HeaderText = "Estado"
        Me.estado.Name = "estado"
        Me.estado.ReadOnly = True
        Me.estado.Width = 140
        '
        'imprimir
        '
        Me.imprimir.HeaderText = "Imprimir"
        Me.imprimir.Name = "imprimir"
        Me.imprimir.Text = "Imprimir"
        '
        'Certificaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 436)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_cert_filtrar_ben)
        Me.Controls.Add(Me.dgv_cert_certificados)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_cert_cerrar)
        Me.Controls.Add(Me.btn_cert_ver)
        Me.Controls.Add(Me.dgv_cert_beneficiario)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Certificaciones"
        Me.Text = "Certificaciones"
        CType(Me.dgv_cert_beneficiario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_cert_certificados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_cert_beneficiario As DataGridView
    Friend WithEvents btn_cert_ver As Button
    Friend WithEvents btn_cert_cerrar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents dgv_cert_certificados As DataGridView
    Friend WithEvents txt_cert_filtrar_ben As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dni As DataGridViewTextBoxColumn
    Friend WithEvents apellido As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents num_cert As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
    Friend WithEvents imprimir As DataGridViewButtonColumn
End Class
