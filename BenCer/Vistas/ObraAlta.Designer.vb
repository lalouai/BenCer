<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ObraAlta
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbl_obra_alta_titulo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_obra_alta_cod_persona = New System.Windows.Forms.TextBox()
        Me.lbl_obra_alta_ayuda = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_obra_alta_apellido = New System.Windows.Forms.TextBox()
        Me.txt_obra_alta_nombre = New System.Windows.Forms.TextBox()
        Me.txt_obra_alta_dni = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_obra_alta_constructor = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtp_obra_alta_fecha_inicio = New System.Windows.Forms.DateTimePicker()
        Me.cmb_obra_alta_programa = New System.Windows.Forms.ComboBox()
        Me.cmb_obra_alta_prototipo = New System.Windows.Forms.ComboBox()
        Me.btn_obra_alta_crear = New System.Windows.Forms.Button()
        Me.btn_obra_alta_cancelar = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.dgv_obra_alta_resultados = New System.Windows.Forms.DataGridView()
        Me.DNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_obra_alta_reiniciar = New System.Windows.Forms.Button()
        Me.grp_postulantes = New System.Windows.Forms.GroupBox()
        Me.obra_avance = New System.Windows.Forms.GroupBox()
        Me.dgv_obra_alta_pagos = New System.Windows.Forms.DataGridView()
        Me.obra_alta_avance_porcentual = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.obra_alta_avance_financiero = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.obra_alta_grafico = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.obra_alta_costo_total = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cod_pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cod_certificado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_obra_alta_resultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_postulantes.SuspendLayout()
        Me.obra_avance.SuspendLayout()
        CType(Me.dgv_obra_alta_pagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obra_alta_grafico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_obra_alta_titulo
        '
        Me.lbl_obra_alta_titulo.AutoSize = True
        Me.lbl_obra_alta_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_obra_alta_titulo.Location = New System.Drawing.Point(482, 27)
        Me.lbl_obra_alta_titulo.Name = "lbl_obra_alta_titulo"
        Me.lbl_obra_alta_titulo.Size = New System.Drawing.Size(127, 24)
        Me.lbl_obra_alta_titulo.TabIndex = 10
        Me.lbl_obra_alta_titulo.Text = "Alta de Obra"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_obra_alta_cod_persona)
        Me.GroupBox1.Controls.Add(Me.lbl_obra_alta_ayuda)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_obra_alta_apellido)
        Me.GroupBox1.Controls.Add(Me.txt_obra_alta_nombre)
        Me.GroupBox1.Controls.Add(Me.txt_obra_alta_dni)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(38, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(571, 174)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Beneficiario"
        '
        'txt_obra_alta_cod_persona
        '
        Me.txt_obra_alta_cod_persona.Location = New System.Drawing.Point(217, 53)
        Me.txt_obra_alta_cod_persona.Name = "txt_obra_alta_cod_persona"
        Me.txt_obra_alta_cod_persona.Size = New System.Drawing.Size(100, 22)
        Me.txt_obra_alta_cod_persona.TabIndex = 16
        Me.txt_obra_alta_cod_persona.Visible = False
        '
        'lbl_obra_alta_ayuda
        '
        Me.lbl_obra_alta_ayuda.AutoSize = True
        Me.lbl_obra_alta_ayuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_obra_alta_ayuda.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_obra_alta_ayuda.Location = New System.Drawing.Point(303, 73)
        Me.lbl_obra_alta_ayuda.Name = "lbl_obra_alta_ayuda"
        Me.lbl_obra_alta_ayuda.Size = New System.Drawing.Size(230, 13)
        Me.lbl_obra_alta_ayuda.TabIndex = 15
        Me.lbl_obra_alta_ayuda.Text = "Ingrese el DNI de un postulante para comenzar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(66, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(66, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(376, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "DNI"
        '
        'txt_obra_alta_apellido
        '
        Me.txt_obra_alta_apellido.Enabled = False
        Me.txt_obra_alta_apellido.Location = New System.Drawing.Point(217, 136)
        Me.txt_obra_alta_apellido.Name = "txt_obra_alta_apellido"
        Me.txt_obra_alta_apellido.Size = New System.Drawing.Size(316, 22)
        Me.txt_obra_alta_apellido.TabIndex = 11
        '
        'txt_obra_alta_nombre
        '
        Me.txt_obra_alta_nombre.Enabled = False
        Me.txt_obra_alta_nombre.Location = New System.Drawing.Point(217, 93)
        Me.txt_obra_alta_nombre.Name = "txt_obra_alta_nombre"
        Me.txt_obra_alta_nombre.Size = New System.Drawing.Size(316, 22)
        Me.txt_obra_alta_nombre.TabIndex = 10
        '
        'txt_obra_alta_dni
        '
        Me.txt_obra_alta_dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_obra_alta_dni.Location = New System.Drawing.Point(433, 50)
        Me.txt_obra_alta_dni.Name = "txt_obra_alta_dni"
        Me.txt_obra_alta_dni.Size = New System.Drawing.Size(100, 20)
        Me.txt_obra_alta_dni.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cmb_obra_alta_constructor)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.dtp_obra_alta_fecha_inicio)
        Me.GroupBox2.Controls.Add(Me.cmb_obra_alta_programa)
        Me.GroupBox2.Controls.Add(Me.cmb_obra_alta_prototipo)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(38, 249)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(571, 229)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de la Obra"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(52, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Constructor"
        '
        'cmb_obra_alta_constructor
        '
        Me.cmb_obra_alta_constructor.Enabled = False
        Me.cmb_obra_alta_constructor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_obra_alta_constructor.FormattingEnabled = True
        Me.cmb_obra_alta_constructor.Location = New System.Drawing.Point(203, 141)
        Me.cmb_obra_alta_constructor.Name = "cmb_obra_alta_constructor"
        Me.cmb_obra_alta_constructor.Size = New System.Drawing.Size(316, 21)
        Me.cmb_obra_alta_constructor.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(52, 204)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Fecha de Inicio"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(52, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Programa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(52, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Prototipo"
        '
        'dtp_obra_alta_fecha_inicio
        '
        Me.dtp_obra_alta_fecha_inicio.Enabled = False
        Me.dtp_obra_alta_fecha_inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_obra_alta_fecha_inicio.Location = New System.Drawing.Point(203, 198)
        Me.dtp_obra_alta_fecha_inicio.Name = "dtp_obra_alta_fecha_inicio"
        Me.dtp_obra_alta_fecha_inicio.Size = New System.Drawing.Size(216, 20)
        Me.dtp_obra_alta_fecha_inicio.TabIndex = 17
        '
        'cmb_obra_alta_programa
        '
        Me.cmb_obra_alta_programa.Enabled = False
        Me.cmb_obra_alta_programa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_obra_alta_programa.FormattingEnabled = True
        Me.cmb_obra_alta_programa.Location = New System.Drawing.Point(203, 39)
        Me.cmb_obra_alta_programa.Name = "cmb_obra_alta_programa"
        Me.cmb_obra_alta_programa.Size = New System.Drawing.Size(316, 21)
        Me.cmb_obra_alta_programa.TabIndex = 16
        '
        'cmb_obra_alta_prototipo
        '
        Me.cmb_obra_alta_prototipo.Enabled = False
        Me.cmb_obra_alta_prototipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_obra_alta_prototipo.FormattingEnabled = True
        Me.cmb_obra_alta_prototipo.Location = New System.Drawing.Point(203, 89)
        Me.cmb_obra_alta_prototipo.Name = "cmb_obra_alta_prototipo"
        Me.cmb_obra_alta_prototipo.Size = New System.Drawing.Size(316, 21)
        Me.cmb_obra_alta_prototipo.TabIndex = 15
        '
        'btn_obra_alta_crear
        '
        Me.btn_obra_alta_crear.Location = New System.Drawing.Point(533, 498)
        Me.btn_obra_alta_crear.Name = "btn_obra_alta_crear"
        Me.btn_obra_alta_crear.Size = New System.Drawing.Size(75, 23)
        Me.btn_obra_alta_crear.TabIndex = 17
        Me.btn_obra_alta_crear.Text = "Crear"
        Me.btn_obra_alta_crear.UseVisualStyleBackColor = True
        '
        'btn_obra_alta_cancelar
        '
        Me.btn_obra_alta_cancelar.Location = New System.Drawing.Point(452, 498)
        Me.btn_obra_alta_cancelar.Name = "btn_obra_alta_cancelar"
        Me.btn_obra_alta_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_obra_alta_cancelar.TabIndex = 18
        Me.btn_obra_alta_cancelar.Text = "Cancelar"
        Me.btn_obra_alta_cancelar.UseVisualStyleBackColor = True
        '
        'dgv_obra_alta_resultados
        '
        Me.dgv_obra_alta_resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_obra_alta_resultados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DNI, Me.apellido, Me.nombre})
        Me.dgv_obra_alta_resultados.Location = New System.Drawing.Point(6, 19)
        Me.dgv_obra_alta_resultados.Name = "dgv_obra_alta_resultados"
        Me.dgv_obra_alta_resultados.RowHeadersVisible = False
        Me.dgv_obra_alta_resultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_obra_alta_resultados.Size = New System.Drawing.Size(388, 191)
        Me.dgv_obra_alta_resultados.TabIndex = 19
        '
        'DNI
        '
        Me.DNI.DataPropertyName = "nro_doc"
        Me.DNI.HeaderText = "DNI"
        Me.DNI.Name = "DNI"
        Me.DNI.ReadOnly = True
        Me.DNI.Width = 80
        '
        'apellido
        '
        Me.apellido.DataPropertyName = "apellido"
        Me.apellido.HeaderText = "Apellido"
        Me.apellido.Name = "apellido"
        Me.apellido.ReadOnly = True
        Me.apellido.Width = 150
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 150
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(230, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Selecccione el postulante haciendo doble click"
        '
        'btn_obra_alta_reiniciar
        '
        Me.btn_obra_alta_reiniciar.Location = New System.Drawing.Point(371, 498)
        Me.btn_obra_alta_reiniciar.Name = "btn_obra_alta_reiniciar"
        Me.btn_obra_alta_reiniciar.Size = New System.Drawing.Size(75, 23)
        Me.btn_obra_alta_reiniciar.TabIndex = 20
        Me.btn_obra_alta_reiniciar.Text = "Reiniciar"
        Me.btn_obra_alta_reiniciar.UseVisualStyleBackColor = True
        Me.btn_obra_alta_reiniciar.Visible = False
        '
        'grp_postulantes
        '
        Me.grp_postulantes.Controls.Add(Me.dgv_obra_alta_resultados)
        Me.grp_postulantes.Controls.Add(Me.Label4)
        Me.grp_postulantes.Location = New System.Drawing.Point(626, 54)
        Me.grp_postulantes.Name = "grp_postulantes"
        Me.grp_postulantes.Size = New System.Drawing.Size(414, 277)
        Me.grp_postulantes.TabIndex = 21
        Me.grp_postulantes.TabStop = False
        '
        'obra_avance
        '
        Me.obra_avance.Controls.Add(Me.dgv_obra_alta_pagos)
        Me.obra_avance.Controls.Add(Me.obra_alta_avance_porcentual)
        Me.obra_avance.Controls.Add(Me.Label14)
        Me.obra_avance.Controls.Add(Me.obra_alta_avance_financiero)
        Me.obra_avance.Controls.Add(Me.Label12)
        Me.obra_avance.Controls.Add(Me.obra_alta_grafico)
        Me.obra_avance.Controls.Add(Me.obra_alta_costo_total)
        Me.obra_avance.Controls.Add(Me.Label5)
        Me.obra_avance.Location = New System.Drawing.Point(626, 63)
        Me.obra_avance.Name = "obra_avance"
        Me.obra_avance.Size = New System.Drawing.Size(464, 415)
        Me.obra_avance.TabIndex = 22
        Me.obra_avance.TabStop = False
        Me.obra_avance.Text = "Avance"
        Me.obra_avance.Visible = False
        '
        'dgv_obra_alta_pagos
        '
        Me.dgv_obra_alta_pagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_obra_alta_pagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fecha, Me.cod_pago, Me.cod_certificado, Me.monto})
        Me.dgv_obra_alta_pagos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_obra_alta_pagos.Location = New System.Drawing.Point(3, 262)
        Me.dgv_obra_alta_pagos.Name = "dgv_obra_alta_pagos"
        Me.dgv_obra_alta_pagos.RowHeadersVisible = False
        Me.dgv_obra_alta_pagos.Size = New System.Drawing.Size(458, 150)
        Me.dgv_obra_alta_pagos.TabIndex = 24
        '
        'obra_alta_avance_porcentual
        '
        Me.obra_alta_avance_porcentual.AutoSize = True
        Me.obra_alta_avance_porcentual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.obra_alta_avance_porcentual.Location = New System.Drawing.Point(355, 231)
        Me.obra_alta_avance_porcentual.Name = "obra_alta_avance_porcentual"
        Me.obra_alta_avance_porcentual.Size = New System.Drawing.Size(59, 16)
        Me.obra_alta_avance_porcentual.TabIndex = 23
        Me.obra_alta_avance_porcentual.Text = "avance"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(231, 233)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Avance porcentual"
        '
        'obra_alta_avance_financiero
        '
        Me.obra_alta_avance_financiero.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.obra_alta_avance_financiero.AutoSize = True
        Me.obra_alta_avance_financiero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.obra_alta_avance_financiero.Location = New System.Drawing.Point(126, 230)
        Me.obra_alta_avance_financiero.Name = "obra_alta_avance_financiero"
        Me.obra_alta_avance_financiero.Size = New System.Drawing.Size(76, 16)
        Me.obra_alta_avance_financiero.TabIndex = 21
        Me.obra_alta_avance_financiero.Text = "financiero"
        Me.obra_alta_avance_financiero.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 233)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Avance financiero"
        '
        'obra_alta_grafico
        '
        ChartArea1.Name = "ChartArea1"
        Me.obra_alta_grafico.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.obra_alta_grafico.Legends.Add(Legend1)
        Me.obra_alta_grafico.Location = New System.Drawing.Point(9, 19)
        Me.obra_alta_grafico.Name = "obra_alta_grafico"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.obra_alta_grafico.Series.Add(Series1)
        Me.obra_alta_grafico.Size = New System.Drawing.Size(449, 182)
        Me.obra_alta_grafico.TabIndex = 19
        Me.obra_alta_grafico.Text = "Chart1"
        '
        'obra_alta_costo_total
        '
        Me.obra_alta_costo_total.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.obra_alta_costo_total.AutoSize = True
        Me.obra_alta_costo_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.obra_alta_costo_total.Location = New System.Drawing.Point(156, 210)
        Me.obra_alta_costo_total.Name = "obra_alta_costo_total"
        Me.obra_alta_costo_total.Size = New System.Drawing.Size(46, 16)
        Me.obra_alta_costo_total.TabIndex = 18
        Me.obra_alta_costo_total.Text = "costo"
        Me.obra_alta_costo_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Costo total"
        '
        'fecha
        '
        Me.fecha.DataPropertyName = "fecha_pago"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.fecha.DefaultCellStyle = DataGridViewCellStyle1
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'cod_pago
        '
        Me.cod_pago.DataPropertyName = "cod_pago"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cod_pago.DefaultCellStyle = DataGridViewCellStyle2
        Me.cod_pago.HeaderText = "Orden Pago"
        Me.cod_pago.Name = "cod_pago"
        Me.cod_pago.ReadOnly = True
        '
        'cod_certificado
        '
        Me.cod_certificado.DataPropertyName = "cod_certificado"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cod_certificado.DefaultCellStyle = DataGridViewCellStyle3
        Me.cod_certificado.HeaderText = "Certificado"
        Me.cod_certificado.Name = "cod_certificado"
        Me.cod_certificado.ReadOnly = True
        '
        'monto
        '
        Me.monto.DataPropertyName = "monto"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.monto.DefaultCellStyle = DataGridViewCellStyle4
        Me.monto.HeaderText = "Monto"
        Me.monto.Name = "monto"
        Me.monto.ReadOnly = True
        Me.monto.Width = 150
        '
        'ObraAlta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1102, 546)
        Me.Controls.Add(Me.obra_avance)
        Me.Controls.Add(Me.grp_postulantes)
        Me.Controls.Add(Me.btn_obra_alta_reiniciar)
        Me.Controls.Add(Me.btn_obra_alta_cancelar)
        Me.Controls.Add(Me.btn_obra_alta_crear)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_obra_alta_titulo)
        Me.Name = "ObraAlta"
        Me.Text = "ObraAlta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_obra_alta_resultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_postulantes.ResumeLayout(False)
        Me.grp_postulantes.PerformLayout()
        Me.obra_avance.ResumeLayout(False)
        Me.obra_avance.PerformLayout()
        CType(Me.dgv_obra_alta_pagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obra_alta_grafico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_obra_alta_titulo As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_obra_alta_apellido As TextBox
    Friend WithEvents txt_obra_alta_nombre As TextBox
    Friend WithEvents txt_obra_alta_dni As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtp_obra_alta_fecha_inicio As DateTimePicker
    Friend WithEvents cmb_obra_alta_programa As ComboBox
    Friend WithEvents cmb_obra_alta_prototipo As ComboBox
    Friend WithEvents btn_obra_alta_crear As Button
    Friend WithEvents btn_obra_alta_cancelar As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents dgv_obra_alta_resultados As DataGridView
    Friend WithEvents DNI As DataGridViewTextBoxColumn
    Friend WithEvents apellido As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_obra_alta_ayuda As Label
    Friend WithEvents btn_obra_alta_reiniciar As Button
    Friend WithEvents txt_obra_alta_cod_persona As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmb_obra_alta_constructor As ComboBox
    Friend WithEvents grp_postulantes As GroupBox
    Friend WithEvents obra_avance As GroupBox
    Friend WithEvents dgv_obra_alta_pagos As DataGridView
    Friend WithEvents obra_alta_avance_porcentual As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents obra_alta_avance_financiero As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents obra_alta_grafico As DataVisualization.Charting.Chart
    Friend WithEvents obra_alta_costo_total As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents cod_pago As DataGridViewTextBoxColumn
    Friend WithEvents cod_certificado As DataGridViewTextBoxColumn
    Friend WithEvents monto As DataGridViewTextBoxColumn
End Class
