<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProgramasDetalle
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
        Me.dvg_prg_det = New System.Windows.Forms.DataGridView()
        Me.cmb_prg_det_prog = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_prg_det_eje = New System.Windows.Forms.Label()
        Me.lbl_prg_det_ter = New System.Windows.Forms.Label()
        Me.btn_prg_det = New System.Windows.Forms.Button()
        Me.beneficiario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prototipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.constructor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_inicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dvg_prg_det, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dvg_prg_det
        '
        Me.dvg_prg_det.AllowUserToResizeRows = False
        Me.dvg_prg_det.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvg_prg_det.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.beneficiario, Me.prototipo, Me.constructor, Me.fecha_inicio})
        Me.dvg_prg_det.Location = New System.Drawing.Point(12, 70)
        Me.dvg_prg_det.Name = "dvg_prg_det"
        Me.dvg_prg_det.RowHeadersVisible = False
        Me.dvg_prg_det.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvg_prg_det.Size = New System.Drawing.Size(754, 535)
        Me.dvg_prg_det.TabIndex = 0
        '
        'cmb_prg_det_prog
        '
        Me.cmb_prg_det_prog.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_prg_det_prog.FormattingEnabled = True
        Me.cmb_prg_det_prog.Location = New System.Drawing.Point(70, 21)
        Me.cmb_prg_det_prog.Name = "cmb_prg_det_prog"
        Me.cmb_prg_det_prog.Size = New System.Drawing.Size(284, 21)
        Me.cmb_prg_det_prog.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Programa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(369, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cantidad de obras en ejecución"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(369, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cantidad de obras terminadas"
        '
        'lbl_prg_det_eje
        '
        Me.lbl_prg_det_eje.AutoSize = True
        Me.lbl_prg_det_eje.Location = New System.Drawing.Point(532, 24)
        Me.lbl_prg_det_eje.Name = "lbl_prg_det_eje"
        Me.lbl_prg_det_eje.Size = New System.Drawing.Size(53, 13)
        Me.lbl_prg_det_eje.TabIndex = 5
        Me.lbl_prg_det_eje.Text = "ejecución"
        '
        'lbl_prg_det_ter
        '
        Me.lbl_prg_det_ter.AutoSize = True
        Me.lbl_prg_det_ter.Location = New System.Drawing.Point(532, 46)
        Me.lbl_prg_det_ter.Name = "lbl_prg_det_ter"
        Me.lbl_prg_det_ter.Size = New System.Drawing.Size(59, 13)
        Me.lbl_prg_det_ter.TabIndex = 6
        Me.lbl_prg_det_ter.Text = "ejecutadas"
        '
        'btn_prg_det
        '
        Me.btn_prg_det.Location = New System.Drawing.Point(772, 70)
        Me.btn_prg_det.Name = "btn_prg_det"
        Me.btn_prg_det.Size = New System.Drawing.Size(121, 23)
        Me.btn_prg_det.TabIndex = 7
        Me.btn_prg_det.Text = "Cerrar"
        Me.btn_prg_det.UseVisualStyleBackColor = True
        '
        'beneficiario
        '
        Me.beneficiario.DataPropertyName = "beneficiario"
        Me.beneficiario.HeaderText = "Beneficiario"
        Me.beneficiario.Name = "beneficiario"
        Me.beneficiario.ReadOnly = True
        Me.beneficiario.Width = 250
        '
        'prototipo
        '
        Me.prototipo.DataPropertyName = "tipo_obra"
        Me.prototipo.HeaderText = "Prototipo"
        Me.prototipo.Name = "prototipo"
        Me.prototipo.ReadOnly = True
        Me.prototipo.Width = 200
        '
        'constructor
        '
        Me.constructor.DataPropertyName = "constructor"
        Me.constructor.HeaderText = "Constructor"
        Me.constructor.Name = "constructor"
        Me.constructor.ReadOnly = True
        Me.constructor.Width = 200
        '
        'fecha_inicio
        '
        Me.fecha_inicio.DataPropertyName = "fecha_inicio"
        Me.fecha_inicio.HeaderText = "Fecha Inicio"
        Me.fecha_inicio.Name = "fecha_inicio"
        Me.fecha_inicio.ReadOnly = True
        '
        'ProgramasDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 631)
        Me.Controls.Add(Me.btn_prg_det)
        Me.Controls.Add(Me.lbl_prg_det_ter)
        Me.Controls.Add(Me.lbl_prg_det_eje)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_prg_det_prog)
        Me.Controls.Add(Me.dvg_prg_det)
        Me.Name = "ProgramasDetalle"
        Me.Text = "ProgramasDetalle"
        CType(Me.dvg_prg_det, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dvg_prg_det As DataGridView
    Friend WithEvents cmb_prg_det_prog As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_prg_det_eje As Label
    Friend WithEvents lbl_prg_det_ter As Label
    Friend WithEvents btn_prg_det As Button
    Friend WithEvents beneficiario As DataGridViewTextBoxColumn
    Friend WithEvents prototipo As DataGridViewTextBoxColumn
    Friend WithEvents constructor As DataGridViewTextBoxColumn
    Friend WithEvents fecha_inicio As DataGridViewTextBoxColumn
End Class
