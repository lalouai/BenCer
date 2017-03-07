<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Imp_cert
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Imp_cert))
        Me.lbl_imp_numero = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbl_imp_programa = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_imp_porc_cert = New System.Windows.Forms.Label()
        Me.lbl_imp_monto = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_imp_total = New System.Windows.Forms.Label()
        Me.lbl_imp_tipo_obra = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_imp_beneficiario = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_imp_renglones = New System.Windows.Forms.DataGridView()
        Me.item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.avance_anterior = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.avance_actual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.avance_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ImprimirDatos = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        CType(Me.dgv_imp_renglones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_imp_numero
        '
        Me.lbl_imp_numero.AutoSize = True
        Me.lbl_imp_numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_imp_numero.Location = New System.Drawing.Point(514, 13)
        Me.lbl_imp_numero.Name = "lbl_imp_numero"
        Me.lbl_imp_numero.Size = New System.Drawing.Size(84, 15)
        Me.lbl_imp_numero.TabIndex = 33
        Me.lbl_imp_numero.Text = "Beneficiario"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(414, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 13)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Certificado nº"
        '
        'lbl_imp_programa
        '
        Me.lbl_imp_programa.AutoSize = True
        Me.lbl_imp_programa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_imp_programa.Location = New System.Drawing.Point(226, 181)
        Me.lbl_imp_programa.Name = "lbl_imp_programa"
        Me.lbl_imp_programa.Size = New System.Drawing.Size(84, 15)
        Me.lbl_imp_programa.TabIndex = 31
        Me.lbl_imp_programa.Text = "Beneficiario"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(5, 183)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Programa"
        '
        'lbl_imp_porc_cert
        '
        Me.lbl_imp_porc_cert.AutoSize = True
        Me.lbl_imp_porc_cert.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_imp_porc_cert.Location = New System.Drawing.Point(226, 261)
        Me.lbl_imp_porc_cert.Name = "lbl_imp_porc_cert"
        Me.lbl_imp_porc_cert.Size = New System.Drawing.Size(84, 15)
        Me.lbl_imp_porc_cert.TabIndex = 29
        Me.lbl_imp_porc_cert.Text = "Beneficiario"
        '
        'lbl_imp_monto
        '
        Me.lbl_imp_monto.AutoSize = True
        Me.lbl_imp_monto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_imp_monto.Location = New System.Drawing.Point(226, 235)
        Me.lbl_imp_monto.Name = "lbl_imp_monto"
        Me.lbl_imp_monto.Size = New System.Drawing.Size(84, 15)
        Me.lbl_imp_monto.TabIndex = 28
        Me.lbl_imp_monto.Text = "Beneficiario"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 263)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(181, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Porcentaje de avance del certificado"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(5, 237)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Monto del certificado"
        '
        'lbl_imp_total
        '
        Me.lbl_imp_total.AutoSize = True
        Me.lbl_imp_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_imp_total.Location = New System.Drawing.Point(226, 208)
        Me.lbl_imp_total.Name = "lbl_imp_total"
        Me.lbl_imp_total.Size = New System.Drawing.Size(84, 15)
        Me.lbl_imp_total.TabIndex = 25
        Me.lbl_imp_total.Text = "Beneficiario"
        '
        'lbl_imp_tipo_obra
        '
        Me.lbl_imp_tipo_obra.AutoSize = True
        Me.lbl_imp_tipo_obra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_imp_tipo_obra.Location = New System.Drawing.Point(226, 154)
        Me.lbl_imp_tipo_obra.Name = "lbl_imp_tipo_obra"
        Me.lbl_imp_tipo_obra.Size = New System.Drawing.Size(84, 15)
        Me.lbl_imp_tipo_obra.TabIndex = 24
        Me.lbl_imp_tipo_obra.Text = "Beneficiario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Monto total de mano de obra"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Prototipo"
        '
        'lbl_imp_beneficiario
        '
        Me.lbl_imp_beneficiario.AutoSize = True
        Me.lbl_imp_beneficiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_imp_beneficiario.Location = New System.Drawing.Point(226, 127)
        Me.lbl_imp_beneficiario.Name = "lbl_imp_beneficiario"
        Me.lbl_imp_beneficiario.Size = New System.Drawing.Size(84, 15)
        Me.lbl_imp_beneficiario.TabIndex = 20
        Me.lbl_imp_beneficiario.Text = "Beneficiario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Beneficiario"
        '
        'dgv_imp_renglones
        '
        Me.dgv_imp_renglones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_imp_renglones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item, Me.descripcion, Me.avance_anterior, Me.avance_actual, Me.avance_total, Me.importe})
        Me.dgv_imp_renglones.Location = New System.Drawing.Point(12, 295)
        Me.dgv_imp_renglones.Name = "dgv_imp_renglones"
        Me.dgv_imp_renglones.RowHeadersVisible = False
        Me.dgv_imp_renglones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_imp_renglones.Size = New System.Drawing.Size(589, 296)
        Me.dgv_imp_renglones.TabIndex = 21
        '
        'item
        '
        Me.item.DataPropertyName = "item"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.item.DefaultCellStyle = DataGridViewCellStyle1
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
        Me.descripcion.Width = 200
        '
        'avance_anterior
        '
        Me.avance_anterior.DataPropertyName = "avance_anterior"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "P"
        Me.avance_anterior.DefaultCellStyle = DataGridViewCellStyle2
        Me.avance_anterior.HeaderText = "Avance Anterior"
        Me.avance_anterior.Name = "avance_anterior"
        Me.avance_anterior.ReadOnly = True
        Me.avance_anterior.Width = 80
        '
        'avance_actual
        '
        Me.avance_actual.DataPropertyName = "avance"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "P"
        Me.avance_actual.DefaultCellStyle = DataGridViewCellStyle3
        Me.avance_actual.HeaderText = "Avance Actual"
        Me.avance_actual.Name = "avance_actual"
        Me.avance_actual.ReadOnly = True
        Me.avance_actual.Width = 80
        '
        'avance_total
        '
        Me.avance_total.DataPropertyName = "avance_total"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "P"
        Me.avance_total.DefaultCellStyle = DataGridViewCellStyle4
        Me.avance_total.HeaderText = "Avance Total"
        Me.avance_total.Name = "avance_total"
        Me.avance_total.ReadOnly = True
        Me.avance_total.Width = 80
        '
        'importe
        '
        Me.importe.DataPropertyName = "subtotal"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.importe.DefaultCellStyle = DataGridViewCellStyle5
        Me.importe.HeaderText = "Importe"
        Me.importe.Name = "importe"
        Me.importe.ReadOnly = True
        Me.importe.Width = 95
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox2.Image = Global.BenCer.My.Resources.Resources.pie
        Me.PictureBox2.Location = New System.Drawing.Point(0, 649)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(610, 61)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 35
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.BenCer.My.Resources.Resources.uep
        Me.PictureBox1.Location = New System.Drawing.Point(8, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'ImprimirDatos
        '
        Me.ImprimirDatos.DocumentName = "document"
        Me.ImprimirDatos.Form = Me
        Me.ImprimirDatos.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.ImprimirDatos.PrinterSettings = CType(resources.GetObject("ImprimirDatos.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.ImprimirDatos.PrintFileName = Nothing
        '
        'Imp_cert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 710)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_imp_numero)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lbl_imp_programa)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lbl_imp_porc_cert)
        Me.Controls.Add(Me.lbl_imp_monto)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbl_imp_total)
        Me.Controls.Add(Me.lbl_imp_tipo_obra)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_imp_beneficiario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_imp_renglones)
        Me.Name = "Imp_cert"
        Me.Text = "Imp_cert"
        CType(Me.dgv_imp_renglones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_imp_numero As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lbl_imp_programa As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lbl_imp_porc_cert As Label
    Friend WithEvents lbl_imp_monto As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_imp_total As Label
    Friend WithEvents lbl_imp_tipo_obra As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_imp_beneficiario As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_imp_renglones As DataGridView
    Friend WithEvents item As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents avance_anterior As DataGridViewTextBoxColumn
    Friend WithEvents avance_actual As DataGridViewTextBoxColumn
    Friend WithEvents avance_total As DataGridViewTextBoxColumn
    Friend WithEvents importe As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ImprimirDatos As PowerPacks.Printing.PrintForm
End Class
