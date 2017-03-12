<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Beneficiarios
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_ben_filtrar = New System.Windows.Forms.TextBox()
        Me.dvg_ben = New System.Windows.Forms.DataGridView()
        Me.DNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_ben_cerrar = New System.Windows.Forms.Button()
        Me.dismisser = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_error_ben = New System.Windows.Forms.Label()
        CType(Me.dvg_ben, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(797, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Filtrar"
        '
        'txt_ben_filtrar
        '
        Me.txt_ben_filtrar.Location = New System.Drawing.Point(842, 53)
        Me.txt_ben_filtrar.Name = "txt_ben_filtrar"
        Me.txt_ben_filtrar.Size = New System.Drawing.Size(156, 20)
        Me.txt_ben_filtrar.TabIndex = 51
        '
        'dvg_ben
        '
        Me.dvg_ben.AllowUserToOrderColumns = True
        Me.dvg_ben.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dvg_ben.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvg_ben.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DNI, Me.Apellido, Me.Nombre})
        Me.dvg_ben.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dvg_ben.Location = New System.Drawing.Point(12, 96)
        Me.dvg_ben.MultiSelect = False
        Me.dvg_ben.Name = "dvg_ben"
        Me.dvg_ben.RowHeadersVisible = False
        Me.dvg_ben.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvg_ben.Size = New System.Drawing.Size(987, 518)
        Me.dvg_ben.TabIndex = 50
        '
        'DNI
        '
        Me.DNI.DataPropertyName = "nro_doc"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DNI.DefaultCellStyle = DataGridViewCellStyle1
        Me.DNI.HeaderText = "DNI"
        Me.DNI.Name = "DNI"
        Me.DNI.ReadOnly = True
        Me.DNI.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Apellido
        '
        Me.Apellido.DataPropertyName = "apellido"
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        Me.Apellido.Width = 335
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 335
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(786, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 37)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Beneficiarios"
        '
        'btn_ben_cerrar
        '
        Me.btn_ben_cerrar.Location = New System.Drawing.Point(922, 621)
        Me.btn_ben_cerrar.Name = "btn_ben_cerrar"
        Me.btn_ben_cerrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_ben_cerrar.TabIndex = 54
        Me.btn_ben_cerrar.Text = "Cerrar"
        Me.btn_ben_cerrar.UseVisualStyleBackColor = True
        '
        'dismisser
        '
        Me.dismisser.Interval = 3000
        '
        'lbl_error_ben
        '
        Me.lbl_error_ben.AutoSize = True
        Me.lbl_error_ben.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_error_ben.ForeColor = System.Drawing.Color.Red
        Me.lbl_error_ben.Location = New System.Drawing.Point(9, 626)
        Me.lbl_error_ben.Name = "lbl_error_ben"
        Me.lbl_error_ben.Size = New System.Drawing.Size(38, 15)
        Me.lbl_error_ben.TabIndex = 55
        Me.lbl_error_ben.Text = "error"
        Me.lbl_error_ben.Visible = False
        '
        'Beneficiarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 688)
        Me.Controls.Add(Me.lbl_error_ben)
        Me.Controls.Add(Me.btn_ben_cerrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_ben_filtrar)
        Me.Controls.Add(Me.dvg_ben)
        Me.Name = "Beneficiarios"
        Me.Text = "Beneficiarios"
        CType(Me.dvg_ben, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_ben_filtrar As TextBox
    Friend WithEvents dvg_ben As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_ben_cerrar As Button
    Friend WithEvents DNI As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents dismisser As Timer
    Friend WithEvents lbl_error_ben As Label
End Class
