<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pagos
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TC = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_pay_filtro_sin = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_pay_total = New System.Windows.Forms.Label()
        Me.btn_gen_o_pago = New System.Windows.Forms.Button()
        Me.dgv_s_orden = New System.Windows.Forms.DataGridView()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.certificado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.beneficiario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.constructor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_pay_orden = New System.Windows.Forms.DataGridView()
        Me.fecha_orden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_orden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.constructor_orden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuit_orden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto_orden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.accion = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgv_pay_pagados = New System.Windows.Forms.DataGridView()
        Me.fecha_pagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.forma_pagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.constructor_pagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuit_pagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto_pagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_pagados_total = New System.Windows.Forms.Label()
        Me.lbl_titulo_total = New System.Windows.Forms.Label()
        Me.filtrar_pagados = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TC.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_s_orden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_pay_orden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgv_pay_pagados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TC
        '
        Me.TC.Controls.Add(Me.TabPage1)
        Me.TC.Controls.Add(Me.TabPage2)
        Me.TC.Controls.Add(Me.TabPage3)
        Me.TC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TC.Location = New System.Drawing.Point(0, 0)
        Me.TC.Name = "TC"
        Me.TC.SelectedIndex = 0
        Me.TC.Size = New System.Drawing.Size(848, 539)
        Me.TC.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.tb_pay_filtro_sin)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.lbl_pay_total)
        Me.TabPage1.Controls.Add(Me.btn_gen_o_pago)
        Me.TabPage1.Controls.Add(Me.dgv_s_orden)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(840, 513)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Certificados s/orden de pago"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 469)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Filtrar"
        '
        'tb_pay_filtro_sin
        '
        Me.tb_pay_filtro_sin.Location = New System.Drawing.Point(9, 446)
        Me.tb_pay_filtro_sin.Name = "tb_pay_filtro_sin"
        Me.tb_pay_filtro_sin.Size = New System.Drawing.Size(471, 20)
        Me.tb_pay_filtro_sin.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(545, 454)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Total a pagar"
        '
        'lbl_pay_total
        '
        Me.lbl_pay_total.AutoSize = True
        Me.lbl_pay_total.Location = New System.Drawing.Point(649, 454)
        Me.lbl_pay_total.Name = "lbl_pay_total"
        Me.lbl_pay_total.Size = New System.Drawing.Size(39, 13)
        Me.lbl_pay_total.TabIndex = 2
        Me.lbl_pay_total.Text = "Label1"
        Me.lbl_pay_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_gen_o_pago
        '
        Me.btn_gen_o_pago.Location = New System.Drawing.Point(727, 6)
        Me.btn_gen_o_pago.Name = "btn_gen_o_pago"
        Me.btn_gen_o_pago.Size = New System.Drawing.Size(106, 23)
        Me.btn_gen_o_pago.TabIndex = 1
        Me.btn_gen_o_pago.Text = "Generar O. Pago"
        Me.btn_gen_o_pago.UseVisualStyleBackColor = True
        '
        'dgv_s_orden
        '
        Me.dgv_s_orden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_s_orden.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fecha, Me.certificado, Me.beneficiario, Me.constructor, Me.cuit, Me.monto})
        Me.dgv_s_orden.Location = New System.Drawing.Point(6, 6)
        Me.dgv_s_orden.Name = "dgv_s_orden"
        Me.dgv_s_orden.RowHeadersVisible = False
        Me.dgv_s_orden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_s_orden.Size = New System.Drawing.Size(715, 425)
        Me.dgv_s_orden.TabIndex = 0
        '
        'fecha
        '
        Me.fecha.DataPropertyName = "fecha"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Format = "d"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.fecha.DefaultCellStyle = DataGridViewCellStyle10
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Width = 70
        '
        'certificado
        '
        Me.certificado.DataPropertyName = "certificado"
        Me.certificado.HeaderText = "Certificado"
        Me.certificado.Name = "certificado"
        Me.certificado.ReadOnly = True
        Me.certificado.Width = 60
        '
        'beneficiario
        '
        Me.beneficiario.DataPropertyName = "beneficiario"
        Me.beneficiario.HeaderText = "Beneficiario"
        Me.beneficiario.Name = "beneficiario"
        Me.beneficiario.ReadOnly = True
        Me.beneficiario.Width = 200
        '
        'constructor
        '
        Me.constructor.DataPropertyName = "constructor"
        Me.constructor.HeaderText = "Constructor"
        Me.constructor.Name = "constructor"
        Me.constructor.ReadOnly = True
        Me.constructor.Width = 200
        '
        'cuit
        '
        Me.cuit.DataPropertyName = "cuit"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.cuit.DefaultCellStyle = DataGridViewCellStyle11
        Me.cuit.HeaderText = "CUIT"
        Me.cuit.Name = "cuit"
        Me.cuit.ReadOnly = True
        Me.cuit.Width = 80
        '
        'monto
        '
        Me.monto.DataPropertyName = "monto"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "C2"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.monto.DefaultCellStyle = DataGridViewCellStyle12
        Me.monto.HeaderText = "Monto"
        Me.monto.Name = "monto"
        Me.monto.ReadOnly = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgv_pay_orden)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(840, 513)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Certificados c/orden de pago"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgv_pay_orden
        '
        Me.dgv_pay_orden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pay_orden.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fecha_orden, Me.num_orden, Me.constructor_orden, Me.cuit_orden, Me.monto_orden, Me.accion})
        Me.dgv_pay_orden.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgv_pay_orden.Location = New System.Drawing.Point(3, 3)
        Me.dgv_pay_orden.Name = "dgv_pay_orden"
        Me.dgv_pay_orden.RowHeadersVisible = False
        Me.dgv_pay_orden.Size = New System.Drawing.Size(834, 421)
        Me.dgv_pay_orden.TabIndex = 0
        '
        'fecha_orden
        '
        Me.fecha_orden.DataPropertyName = "fecha_orden"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "d"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.fecha_orden.DefaultCellStyle = DataGridViewCellStyle13
        Me.fecha_orden.HeaderText = "Fecha"
        Me.fecha_orden.Name = "fecha_orden"
        Me.fecha_orden.ReadOnly = True
        '
        'num_orden
        '
        Me.num_orden.DataPropertyName = "cod_pago"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.num_orden.DefaultCellStyle = DataGridViewCellStyle14
        Me.num_orden.HeaderText = "Orden nº"
        Me.num_orden.Name = "num_orden"
        Me.num_orden.ReadOnly = True
        '
        'constructor_orden
        '
        Me.constructor_orden.DataPropertyName = "constructor"
        Me.constructor_orden.HeaderText = "Constructor"
        Me.constructor_orden.Name = "constructor_orden"
        Me.constructor_orden.ReadOnly = True
        Me.constructor_orden.Width = 300
        '
        'cuit_orden
        '
        Me.cuit_orden.DataPropertyName = "cuit"
        Me.cuit_orden.HeaderText = "CUIT"
        Me.cuit_orden.Name = "cuit_orden"
        Me.cuit_orden.ReadOnly = True
        '
        'monto_orden
        '
        Me.monto_orden.DataPropertyName = "monto"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "C2"
        DataGridViewCellStyle15.NullValue = Nothing
        Me.monto_orden.DefaultCellStyle = DataGridViewCellStyle15
        Me.monto_orden.HeaderText = "Monto"
        Me.monto_orden.Name = "monto_orden"
        Me.monto_orden.ReadOnly = True
        Me.monto_orden.Width = 130
        '
        'accion
        '
        Me.accion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.accion.HeaderText = "Acción"
        Me.accion.Name = "accion"
        Me.accion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.accion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.filtrar_pagados)
        Me.TabPage3.Controls.Add(Me.lbl_titulo_total)
        Me.TabPage3.Controls.Add(Me.lbl_pagados_total)
        Me.TabPage3.Controls.Add(Me.dgv_pay_pagados)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(840, 513)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Certificados Pagados"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgv_pay_pagados
        '
        Me.dgv_pay_pagados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pay_pagados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fecha_pagado, Me.forma_pagado, Me.constructor_pagado, Me.cuit_pagado, Me.monto_pagado})
        Me.dgv_pay_pagados.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgv_pay_pagados.Location = New System.Drawing.Point(3, 3)
        Me.dgv_pay_pagados.Name = "dgv_pay_pagados"
        Me.dgv_pay_pagados.RowHeadersVisible = False
        Me.dgv_pay_pagados.Size = New System.Drawing.Size(834, 446)
        Me.dgv_pay_pagados.TabIndex = 0
        '
        'fecha_pagado
        '
        Me.fecha_pagado.DataPropertyName = "fecha_pago"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.fecha_pagado.DefaultCellStyle = DataGridViewCellStyle16
        Me.fecha_pagado.HeaderText = "Fecha"
        Me.fecha_pagado.Name = "fecha_pagado"
        Me.fecha_pagado.ReadOnly = True
        '
        'forma_pagado
        '
        Me.forma_pagado.DataPropertyName = "ver_forma"
        Me.forma_pagado.HeaderText = "Forma de Pago"
        Me.forma_pagado.Name = "forma_pagado"
        Me.forma_pagado.ReadOnly = True
        Me.forma_pagado.Width = 200
        '
        'constructor_pagado
        '
        Me.constructor_pagado.DataPropertyName = "constructor"
        Me.constructor_pagado.HeaderText = "Constructor"
        Me.constructor_pagado.Name = "constructor_pagado"
        Me.constructor_pagado.ReadOnly = True
        Me.constructor_pagado.Width = 300
        '
        'cuit_pagado
        '
        Me.cuit_pagado.DataPropertyName = "cuit"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.cuit_pagado.DefaultCellStyle = DataGridViewCellStyle17
        Me.cuit_pagado.HeaderText = "CUIT"
        Me.cuit_pagado.Name = "cuit_pagado"
        Me.cuit_pagado.ReadOnly = True
        Me.cuit_pagado.Width = 130
        '
        'monto_pagado
        '
        Me.monto_pagado.DataPropertyName = "monto"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle18.Format = "C2"
        DataGridViewCellStyle18.NullValue = Nothing
        Me.monto_pagado.DefaultCellStyle = DataGridViewCellStyle18
        Me.monto_pagado.HeaderText = "Monto"
        Me.monto_pagado.Name = "monto_pagado"
        Me.monto_pagado.ReadOnly = True
        '
        'lbl_pagados_total
        '
        Me.lbl_pagados_total.AutoSize = True
        Me.lbl_pagados_total.Location = New System.Drawing.Point(793, 456)
        Me.lbl_pagados_total.Margin = New System.Windows.Forms.Padding(3, 0, 6, 0)
        Me.lbl_pagados_total.Name = "lbl_pagados_total"
        Me.lbl_pagados_total.Size = New System.Drawing.Size(39, 13)
        Me.lbl_pagados_total.TabIndex = 1
        Me.lbl_pagados_total.Text = "Label3"
        Me.lbl_pagados_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_titulo_total
        '
        Me.lbl_titulo_total.AutoSize = True
        Me.lbl_titulo_total.Location = New System.Drawing.Point(618, 456)
        Me.lbl_titulo_total.Name = "lbl_titulo_total"
        Me.lbl_titulo_total.Size = New System.Drawing.Size(31, 13)
        Me.lbl_titulo_total.TabIndex = 2
        Me.lbl_titulo_total.Text = "Total"
        '
        'filtrar_pagados
        '
        Me.filtrar_pagados.Location = New System.Drawing.Point(6, 456)
        Me.filtrar_pagados.Name = "filtrar_pagados"
        Me.filtrar_pagados.Size = New System.Drawing.Size(293, 20)
        Me.filtrar_pagados.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 479)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Buscar"
        '
        'Pagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 539)
        Me.Controls.Add(Me.TC)
        Me.Name = "Pagos"
        Me.Text = "Pagos"
        Me.TC.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgv_s_orden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_pay_orden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dgv_pay_pagados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TC As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btn_gen_o_pago As Button
    Friend WithEvents dgv_s_orden As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_pay_total As Label
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents certificado As DataGridViewTextBoxColumn
    Friend WithEvents beneficiario As DataGridViewTextBoxColumn
    Friend WithEvents constructor As DataGridViewTextBoxColumn
    Friend WithEvents cuit As DataGridViewTextBoxColumn
    Friend WithEvents monto As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_pay_filtro_sin As TextBox
    Friend WithEvents dgv_pay_orden As DataGridView
    Friend WithEvents fecha_orden As DataGridViewTextBoxColumn
    Friend WithEvents num_orden As DataGridViewTextBoxColumn
    Friend WithEvents constructor_orden As DataGridViewTextBoxColumn
    Friend WithEvents cuit_orden As DataGridViewTextBoxColumn
    Friend WithEvents monto_orden As DataGridViewTextBoxColumn
    Friend WithEvents accion As DataGridViewButtonColumn
    Friend WithEvents dgv_pay_pagados As DataGridView
    Friend WithEvents fecha_pagado As DataGridViewTextBoxColumn
    Friend WithEvents forma_pagado As DataGridViewTextBoxColumn
    Friend WithEvents constructor_pagado As DataGridViewTextBoxColumn
    Friend WithEvents cuit_pagado As DataGridViewTextBoxColumn
    Friend WithEvents monto_pagado As DataGridViewTextBoxColumn
    Friend WithEvents lbl_titulo_total As Label
    Friend WithEvents lbl_pagados_total As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents filtrar_pagados As TextBox
End Class
