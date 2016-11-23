<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CertificadoAlta
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_cert_alta_numero = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbl_cert_alta_programa = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btn_cert_alta_cancelar = New System.Windows.Forms.Button()
        Me.btn_cert_alta_guardar = New System.Windows.Forms.Button()
        Me.btn_cert_alta_consolidar = New System.Windows.Forms.Button()
        Me.lbl_cert_alta_porc_cert = New System.Windows.Forms.Label()
        Me.lbl_cert_alta_monto = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_cert_alta_monto_total = New System.Windows.Forms.Label()
        Me.lbl_cert_alta_tipo_obra = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_cert_alta_beneficiario = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_cert_alta_renglones = New System.Windows.Forms.DataGridView()
        Me.item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.avance_anterior = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.avance_actual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.avance_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_cert_alta_item = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_cert_alta_del_item = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbl_cert_alta_error = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_cert_alta_add_item = New System.Windows.Forms.Button()
        Me.txt_cert_alta_subtotal = New System.Windows.Forms.TextBox()
        Me.txt_cert_alta_avance_ant = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cert_alta_avance = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_cert_alta_renglones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_cert_alta_numero)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.lbl_cert_alta_programa)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.btn_cert_alta_cancelar)
        Me.GroupBox1.Controls.Add(Me.btn_cert_alta_guardar)
        Me.GroupBox1.Controls.Add(Me.btn_cert_alta_consolidar)
        Me.GroupBox1.Controls.Add(Me.lbl_cert_alta_porc_cert)
        Me.GroupBox1.Controls.Add(Me.lbl_cert_alta_monto)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lbl_cert_alta_monto_total)
        Me.GroupBox1.Controls.Add(Me.lbl_cert_alta_tipo_obra)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lbl_cert_alta_beneficiario)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(909, 189)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la Obra"
        '
        'lbl_cert_alta_numero
        '
        Me.lbl_cert_alta_numero.AutoSize = True
        Me.lbl_cert_alta_numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cert_alta_numero.Location = New System.Drawing.Point(801, 82)
        Me.lbl_cert_alta_numero.Name = "lbl_cert_alta_numero"
        Me.lbl_cert_alta_numero.Size = New System.Drawing.Size(84, 15)
        Me.lbl_cert_alta_numero.TabIndex = 18
        Me.lbl_cert_alta_numero.Text = "Beneficiario"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(543, 84)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 13)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Certificado nº"
        '
        'lbl_cert_alta_programa
        '
        Me.lbl_cert_alta_programa.AutoSize = True
        Me.lbl_cert_alta_programa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cert_alta_programa.Location = New System.Drawing.Point(227, 95)
        Me.lbl_cert_alta_programa.Name = "lbl_cert_alta_programa"
        Me.lbl_cert_alta_programa.Size = New System.Drawing.Size(84, 15)
        Me.lbl_cert_alta_programa.TabIndex = 16
        Me.lbl_cert_alta_programa.Text = "Beneficiario"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 97)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Programa"
        '
        'btn_cert_alta_cancelar
        '
        Me.btn_cert_alta_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cert_alta_cancelar.Location = New System.Drawing.Point(666, 26)
        Me.btn_cert_alta_cancelar.Name = "btn_cert_alta_cancelar"
        Me.btn_cert_alta_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cert_alta_cancelar.TabIndex = 14
        Me.btn_cert_alta_cancelar.Text = "Cancelar"
        Me.btn_cert_alta_cancelar.UseVisualStyleBackColor = True
        '
        'btn_cert_alta_guardar
        '
        Me.btn_cert_alta_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cert_alta_guardar.Location = New System.Drawing.Point(747, 26)
        Me.btn_cert_alta_guardar.Name = "btn_cert_alta_guardar"
        Me.btn_cert_alta_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cert_alta_guardar.TabIndex = 13
        Me.btn_cert_alta_guardar.Text = "Guardar"
        Me.btn_cert_alta_guardar.UseVisualStyleBackColor = True
        '
        'btn_cert_alta_consolidar
        '
        Me.btn_cert_alta_consolidar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cert_alta_consolidar.Location = New System.Drawing.Point(828, 26)
        Me.btn_cert_alta_consolidar.Name = "btn_cert_alta_consolidar"
        Me.btn_cert_alta_consolidar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cert_alta_consolidar.TabIndex = 12
        Me.btn_cert_alta_consolidar.Text = "Consolidar"
        Me.btn_cert_alta_consolidar.UseVisualStyleBackColor = True
        '
        'lbl_cert_alta_porc_cert
        '
        Me.lbl_cert_alta_porc_cert.AutoSize = True
        Me.lbl_cert_alta_porc_cert.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cert_alta_porc_cert.Location = New System.Drawing.Point(801, 149)
        Me.lbl_cert_alta_porc_cert.Name = "lbl_cert_alta_porc_cert"
        Me.lbl_cert_alta_porc_cert.Size = New System.Drawing.Size(84, 15)
        Me.lbl_cert_alta_porc_cert.TabIndex = 11
        Me.lbl_cert_alta_porc_cert.Text = "Beneficiario"
        '
        'lbl_cert_alta_monto
        '
        Me.lbl_cert_alta_monto.AutoSize = True
        Me.lbl_cert_alta_monto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cert_alta_monto.Location = New System.Drawing.Point(227, 149)
        Me.lbl_cert_alta_monto.Name = "lbl_cert_alta_monto"
        Me.lbl_cert_alta_monto.Size = New System.Drawing.Size(84, 15)
        Me.lbl_cert_alta_monto.TabIndex = 10
        Me.lbl_cert_alta_monto.Text = "Beneficiario"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(543, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(181, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Porcentaje de avance del certificado"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 151)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Monto del certificado"
        '
        'lbl_cert_alta_monto_total
        '
        Me.lbl_cert_alta_monto_total.AutoSize = True
        Me.lbl_cert_alta_monto_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cert_alta_monto_total.Location = New System.Drawing.Point(227, 122)
        Me.lbl_cert_alta_monto_total.Name = "lbl_cert_alta_monto_total"
        Me.lbl_cert_alta_monto_total.Size = New System.Drawing.Size(84, 15)
        Me.lbl_cert_alta_monto_total.TabIndex = 6
        Me.lbl_cert_alta_monto_total.Text = "Beneficiario"
        '
        'lbl_cert_alta_tipo_obra
        '
        Me.lbl_cert_alta_tipo_obra.AutoSize = True
        Me.lbl_cert_alta_tipo_obra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cert_alta_tipo_obra.Location = New System.Drawing.Point(227, 68)
        Me.lbl_cert_alta_tipo_obra.Name = "lbl_cert_alta_tipo_obra"
        Me.lbl_cert_alta_tipo_obra.Size = New System.Drawing.Size(84, 15)
        Me.lbl_cert_alta_tipo_obra.TabIndex = 5
        Me.lbl_cert_alta_tipo_obra.Text = "Beneficiario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Monto total de mano de obra"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Prototipo"
        '
        'lbl_cert_alta_beneficiario
        '
        Me.lbl_cert_alta_beneficiario.AutoSize = True
        Me.lbl_cert_alta_beneficiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cert_alta_beneficiario.Location = New System.Drawing.Point(227, 41)
        Me.lbl_cert_alta_beneficiario.Name = "lbl_cert_alta_beneficiario"
        Me.lbl_cert_alta_beneficiario.Size = New System.Drawing.Size(84, 15)
        Me.lbl_cert_alta_beneficiario.TabIndex = 1
        Me.lbl_cert_alta_beneficiario.Text = "Beneficiario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Beneficiario"
        '
        'dgv_cert_alta_renglones
        '
        Me.dgv_cert_alta_renglones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cert_alta_renglones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item, Me.descripcion, Me.avance_anterior, Me.avance_actual, Me.avance_total, Me.importe})
        Me.dgv_cert_alta_renglones.Location = New System.Drawing.Point(13, 209)
        Me.dgv_cert_alta_renglones.Name = "dgv_cert_alta_renglones"
        Me.dgv_cert_alta_renglones.RowHeadersVisible = False
        Me.dgv_cert_alta_renglones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_cert_alta_renglones.Size = New System.Drawing.Size(909, 296)
        Me.dgv_cert_alta_renglones.TabIndex = 1
        '
        'item
        '
        Me.item.DataPropertyName = "item"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.item.DefaultCellStyle = DataGridViewCellStyle6
        Me.item.HeaderText = "ITEM"
        Me.item.Name = "item"
        Me.item.ReadOnly = True
        Me.item.Width = 50
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "denominacion"
        Me.descripcion.HeaderText = "Descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 400
        '
        'avance_anterior
        '
        Me.avance_anterior.DataPropertyName = "avance_anterior"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "P"
        Me.avance_anterior.DefaultCellStyle = DataGridViewCellStyle7
        Me.avance_anterior.HeaderText = "Avance Anterior"
        Me.avance_anterior.Name = "avance_anterior"
        Me.avance_anterior.ReadOnly = True
        Me.avance_anterior.Width = 120
        '
        'avance_actual
        '
        Me.avance_actual.DataPropertyName = "avance"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "P"
        Me.avance_actual.DefaultCellStyle = DataGridViewCellStyle8
        Me.avance_actual.HeaderText = "Avance Actual"
        Me.avance_actual.Name = "avance_actual"
        Me.avance_actual.ReadOnly = True
        Me.avance_actual.Width = 120
        '
        'avance_total
        '
        Me.avance_total.DataPropertyName = "avance_total"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "P"
        Me.avance_total.DefaultCellStyle = DataGridViewCellStyle9
        Me.avance_total.HeaderText = "Avance Total"
        Me.avance_total.Name = "avance_total"
        Me.avance_total.ReadOnly = True
        Me.avance_total.Width = 120
        '
        'importe
        '
        Me.importe.DataPropertyName = "subtotal"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "C2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.importe.DefaultCellStyle = DataGridViewCellStyle10
        Me.importe.HeaderText = "Importe"
        Me.importe.Name = "importe"
        Me.importe.ReadOnly = True
        Me.importe.Width = 95
        '
        'txt_cert_alta_item
        '
        Me.txt_cert_alta_item.Location = New System.Drawing.Point(6, 34)
        Me.txt_cert_alta_item.Name = "txt_cert_alta_item"
        Me.txt_cert_alta_item.Size = New System.Drawing.Size(449, 20)
        Me.txt_cert_alta_item.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_cert_alta_del_item)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.lbl_cert_alta_error)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.btn_cert_alta_add_item)
        Me.GroupBox2.Controls.Add(Me.txt_cert_alta_subtotal)
        Me.GroupBox2.Controls.Add(Me.txt_cert_alta_avance_ant)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_cert_alta_avance)
        Me.GroupBox2.Controls.Add(Me.txt_cert_alta_item)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 511)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(909, 82)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Agregar item"
        '
        'btn_cert_alta_del_item
        '
        Me.btn_cert_alta_del_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cert_alta_del_item.Location = New System.Drawing.Point(828, 59)
        Me.btn_cert_alta_del_item.Name = "btn_cert_alta_del_item"
        Me.btn_cert_alta_del_item.Size = New System.Drawing.Size(75, 23)
        Me.btn_cert_alta_del_item.TabIndex = 25
        Me.btn_cert_alta_del_item.Text = "Eliminar"
        Me.btn_cert_alta_del_item.UseVisualStyleBackColor = True
        Me.btn_cert_alta_del_item.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(579, 37)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(15, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "%"
        '
        'lbl_cert_alta_error
        '
        Me.lbl_cert_alta_error.AutoSize = True
        Me.lbl_cert_alta_error.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cert_alta_error.ForeColor = System.Drawing.Color.DarkRed
        Me.lbl_cert_alta_error.Location = New System.Drawing.Point(461, 57)
        Me.lbl_cert_alta_error.Name = "lbl_cert_alta_error"
        Me.lbl_cert_alta_error.Size = New System.Drawing.Size(34, 13)
        Me.lbl_cert_alta_error.TabIndex = 23
        Me.lbl_cert_alta_error.Text = "Error"
        Me.lbl_cert_alta_error.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(695, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(15, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "%"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(6, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(258, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Comience a escribir la descripción del item a certificar"
        '
        'btn_cert_alta_add_item
        '
        Me.btn_cert_alta_add_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cert_alta_add_item.Location = New System.Drawing.Point(828, 32)
        Me.btn_cert_alta_add_item.Name = "btn_cert_alta_add_item"
        Me.btn_cert_alta_add_item.Size = New System.Drawing.Size(75, 23)
        Me.btn_cert_alta_add_item.TabIndex = 15
        Me.btn_cert_alta_add_item.Text = "Agregar"
        Me.btn_cert_alta_add_item.UseVisualStyleBackColor = True
        '
        'txt_cert_alta_subtotal
        '
        Me.txt_cert_alta_subtotal.Enabled = False
        Me.txt_cert_alta_subtotal.Location = New System.Drawing.Point(729, 34)
        Me.txt_cert_alta_subtotal.Name = "txt_cert_alta_subtotal"
        Me.txt_cert_alta_subtotal.Size = New System.Drawing.Size(81, 20)
        Me.txt_cert_alta_subtotal.TabIndex = 20
        '
        'txt_cert_alta_avance_ant
        '
        Me.txt_cert_alta_avance_ant.Enabled = False
        Me.txt_cert_alta_avance_ant.Location = New System.Drawing.Point(492, 34)
        Me.txt_cert_alta_avance_ant.Name = "txt_cert_alta_avance_ant"
        Me.txt_cert_alta_avance_ant.Size = New System.Drawing.Size(81, 20)
        Me.txt_cert_alta_avance_ant.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(489, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Avance anterior"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(726, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Total Item"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(609, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Avance"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Descripcion"
        '
        'txt_cert_alta_avance
        '
        Me.txt_cert_alta_avance.Location = New System.Drawing.Point(612, 34)
        Me.txt_cert_alta_avance.Name = "txt_cert_alta_avance"
        Me.txt_cert_alta_avance.Size = New System.Drawing.Size(81, 20)
        Me.txt_cert_alta_avance.TabIndex = 3
        '
        'CertificadoAlta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 605)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgv_cert_alta_renglones)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CertificadoAlta"
        Me.Text = "CertificadoAlta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_cert_alta_renglones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_cert_alta_cancelar As Button
    Friend WithEvents btn_cert_alta_guardar As Button
    Friend WithEvents lbl_cert_alta_porc_cert As Label
    Friend WithEvents lbl_cert_alta_monto As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_cert_alta_monto_total As Label
    Friend WithEvents lbl_cert_alta_tipo_obra As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_cert_alta_beneficiario As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_cert_alta_renglones As DataGridView
    Friend WithEvents btn_cert_alta_consolidar As Button
    Friend WithEvents txt_cert_alta_item As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btn_cert_alta_add_item As Button
    Friend WithEvents txt_cert_alta_subtotal As TextBox
    Friend WithEvents txt_cert_alta_avance_ant As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_cert_alta_avance As TextBox
    Friend WithEvents lbl_cert_alta_programa As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lbl_cert_alta_numero As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_cert_alta_error As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btn_cert_alta_del_item As Button
    Friend WithEvents item As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents avance_anterior As DataGridViewTextBoxColumn
    Friend WithEvents avance_actual As DataGridViewTextBoxColumn
    Friend WithEvents avance_total As DataGridViewTextBoxColumn
    Friend WithEvents importe As DataGridViewTextBoxColumn
End Class
