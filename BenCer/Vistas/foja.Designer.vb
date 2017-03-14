<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class foja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(foja))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ImprimirDatos = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgv_imp_foja = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_imp_foja_tipo_obra = New System.Windows.Forms.Label()
        Me.item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.avance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_imp_foja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImprimirDatos
        '
        Me.ImprimirDatos.DocumentName = "document"
        Me.ImprimirDatos.Form = Me
        Me.ImprimirDatos.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.ImprimirDatos.PrinterSettings = CType(resources.GetObject("ImprimirDatos.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.ImprimirDatos.PrintFileName = Nothing
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox2.Image = Global.BenCer.My.Resources.Resources.pie
        Me.PictureBox2.Location = New System.Drawing.Point(0, 730)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(600, 61)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 52
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.BenCer.My.Resources.Resources.uep
        Me.PictureBox1.Location = New System.Drawing.Point(475, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'dgv_imp_foja
        '
        Me.dgv_imp_foja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_imp_foja.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item, Me.descripcion, Me.avance})
        Me.dgv_imp_foja.Location = New System.Drawing.Point(12, 119)
        Me.dgv_imp_foja.Name = "dgv_imp_foja"
        Me.dgv_imp_foja.RowHeadersVisible = False
        Me.dgv_imp_foja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_imp_foja.Size = New System.Drawing.Size(575, 605)
        Me.dgv_imp_foja.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Prototipo"
        '
        'lbl_imp_foja_tipo_obra
        '
        Me.lbl_imp_foja_tipo_obra.AutoSize = True
        Me.lbl_imp_foja_tipo_obra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_imp_foja_tipo_obra.Location = New System.Drawing.Point(81, 53)
        Me.lbl_imp_foja_tipo_obra.Name = "lbl_imp_foja_tipo_obra"
        Me.lbl_imp_foja_tipo_obra.Size = New System.Drawing.Size(104, 20)
        Me.lbl_imp_foja_tipo_obra.TabIndex = 41
        Me.lbl_imp_foja_tipo_obra.Text = "Beneficiario"
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
        Me.descripcion.Width = 400
        '
        'avance
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "P"
        Me.avance.DefaultCellStyle = DataGridViewCellStyle2
        Me.avance.HeaderText = "Avance"
        Me.avance.Name = "avance"
        Me.avance.ReadOnly = True
        Me.avance.Width = 120
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Foja de medición para ser presentada an certificaciones"
        '
        'foja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 791)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_imp_foja_tipo_obra)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgv_imp_foja)
        Me.Name = "foja"
        Me.Text = "foja"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_imp_foja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImprimirDatos As PowerPacks.Printing.PrintForm
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgv_imp_foja As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_imp_foja_tipo_obra As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents item As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents avance As DataGridViewTextBoxColumn
End Class
