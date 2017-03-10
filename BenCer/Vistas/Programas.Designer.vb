<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Programas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_prg = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ape_Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_prg_cod_programa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_prg_error = New System.Windows.Forms.Label()
        Me.txt_prg_nombre = New System.Windows.Forms.TextBox()
        Me.txt_prg_expediente = New System.Windows.Forms.TextBox()
        Me.btn_prg_agregar = New System.Windows.Forms.Button()
        Me.btn_prg_eliminar = New System.Windows.Forms.Button()
        Me.btn_prg_editar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_prg_anio = New System.Windows.Forms.Label()
        Me.txt_prg_anio = New System.Windows.Forms.TextBox()
        Me.btn_prg_cerrar = New System.Windows.Forms.Button()
        CType(Me.dgv_prg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_prg
        '
        Me.dgv_prg.AllowUserToResizeRows = False
        Me.dgv_prg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_prg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_prg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Ape_Nom, Me.cuit})
        Me.dgv_prg.Location = New System.Drawing.Point(12, 124)
        Me.dgv_prg.Name = "dgv_prg"
        Me.dgv_prg.RowHeadersVisible = False
        Me.dgv_prg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_prg.Size = New System.Drawing.Size(755, 352)
        Me.dgv_prg.TabIndex = 4
        '
        'ID
        '
        Me.ID.DataPropertyName = "cod_programa"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ID.DefaultCellStyle = DataGridViewCellStyle1
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'Ape_Nom
        '
        Me.Ape_Nom.DataPropertyName = "nombre"
        Me.Ape_Nom.HeaderText = "Nombre"
        Me.Ape_Nom.Name = "Ape_Nom"
        Me.Ape_Nom.ReadOnly = True
        Me.Ape_Nom.Width = 500
        '
        'cuit
        '
        Me.cuit.DataPropertyName = "expediente"
        Me.cuit.HeaderText = "Expediente"
        Me.cuit.Name = "cuit"
        Me.cuit.ReadOnly = True
        Me.cuit.Width = 150
        '
        'txt_prg_cod_programa
        '
        Me.txt_prg_cod_programa.Location = New System.Drawing.Point(37, 95)
        Me.txt_prg_cod_programa.Name = "txt_prg_cod_programa"
        Me.txt_prg_cod_programa.Size = New System.Drawing.Size(42, 20)
        Me.txt_prg_cod_programa.TabIndex = 19
        Me.txt_prg_cod_programa.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(544, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Expediente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Nombre"
        '
        'lbl_prg_error
        '
        Me.lbl_prg_error.AutoSize = True
        Me.lbl_prg_error.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prg_error.ForeColor = System.Drawing.Color.Red
        Me.lbl_prg_error.Location = New System.Drawing.Point(12, 41)
        Me.lbl_prg_error.Name = "lbl_prg_error"
        Me.lbl_prg_error.Size = New System.Drawing.Size(51, 15)
        Me.lbl_prg_error.TabIndex = 16
        Me.lbl_prg_error.Text = "Label1"
        Me.lbl_prg_error.Visible = False
        '
        'txt_prg_nombre
        '
        Me.txt_prg_nombre.Location = New System.Drawing.Point(119, 95)
        Me.txt_prg_nombre.Name = "txt_prg_nombre"
        Me.txt_prg_nombre.Size = New System.Drawing.Size(419, 20)
        Me.txt_prg_nombre.TabIndex = 0
        '
        'txt_prg_expediente
        '
        Me.txt_prg_expediente.Location = New System.Drawing.Point(544, 95)
        Me.txt_prg_expediente.Name = "txt_prg_expediente"
        Me.txt_prg_expediente.Size = New System.Drawing.Size(137, 20)
        Me.txt_prg_expediente.TabIndex = 1
        '
        'btn_prg_agregar
        '
        Me.btn_prg_agregar.Location = New System.Drawing.Point(771, 95)
        Me.btn_prg_agregar.Name = "btn_prg_agregar"
        Me.btn_prg_agregar.Size = New System.Drawing.Size(142, 23)
        Me.btn_prg_agregar.TabIndex = 3
        Me.btn_prg_agregar.Text = "Agregar"
        Me.btn_prg_agregar.UseVisualStyleBackColor = True
        '
        'btn_prg_eliminar
        '
        Me.btn_prg_eliminar.Location = New System.Drawing.Point(771, 153)
        Me.btn_prg_eliminar.Name = "btn_prg_eliminar"
        Me.btn_prg_eliminar.Size = New System.Drawing.Size(142, 23)
        Me.btn_prg_eliminar.TabIndex = 6
        Me.btn_prg_eliminar.Text = "Eliminar"
        Me.btn_prg_eliminar.UseVisualStyleBackColor = True
        '
        'btn_prg_editar
        '
        Me.btn_prg_editar.Location = New System.Drawing.Point(771, 124)
        Me.btn_prg_editar.Name = "btn_prg_editar"
        Me.btn_prg_editar.Size = New System.Drawing.Size(142, 23)
        Me.btn_prg_editar.TabIndex = 5
        Me.btn_prg_editar.Text = "Editar"
        Me.btn_prg_editar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(820, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Programas"
        '
        'lbl_prg_anio
        '
        Me.lbl_prg_anio.AutoSize = True
        Me.lbl_prg_anio.Location = New System.Drawing.Point(687, 98)
        Me.lbl_prg_anio.Name = "lbl_prg_anio"
        Me.lbl_prg_anio.Size = New System.Drawing.Size(10, 13)
        Me.lbl_prg_anio.TabIndex = 21
        Me.lbl_prg_anio.Text = "-"
        '
        'txt_prg_anio
        '
        Me.txt_prg_anio.Location = New System.Drawing.Point(703, 95)
        Me.txt_prg_anio.Name = "txt_prg_anio"
        Me.txt_prg_anio.Size = New System.Drawing.Size(64, 20)
        Me.txt_prg_anio.TabIndex = 2
        '
        'btn_prg_cerrar
        '
        Me.btn_prg_cerrar.Location = New System.Drawing.Point(771, 182)
        Me.btn_prg_cerrar.Name = "btn_prg_cerrar"
        Me.btn_prg_cerrar.Size = New System.Drawing.Size(142, 23)
        Me.btn_prg_cerrar.TabIndex = 7
        Me.btn_prg_cerrar.Text = "Cerrar"
        Me.btn_prg_cerrar.UseVisualStyleBackColor = True
        '
        'Programas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 486)
        Me.Controls.Add(Me.btn_prg_cerrar)
        Me.Controls.Add(Me.txt_prg_anio)
        Me.Controls.Add(Me.lbl_prg_anio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgv_prg)
        Me.Controls.Add(Me.txt_prg_cod_programa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_prg_error)
        Me.Controls.Add(Me.txt_prg_nombre)
        Me.Controls.Add(Me.txt_prg_expediente)
        Me.Controls.Add(Me.btn_prg_agregar)
        Me.Controls.Add(Me.btn_prg_eliminar)
        Me.Controls.Add(Me.btn_prg_editar)
        Me.Name = "Programas"
        Me.Text = "Programas"
        CType(Me.dgv_prg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_prg As DataGridView
    Friend WithEvents txt_prg_cod_programa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_prg_error As Label
    Friend WithEvents txt_prg_nombre As TextBox
    Friend WithEvents txt_prg_expediente As TextBox
    Friend WithEvents btn_prg_agregar As Button
    Friend WithEvents btn_prg_eliminar As Button
    Friend WithEvents btn_prg_editar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Ape_Nom As DataGridViewTextBoxColumn
    Friend WithEvents cuit As DataGridViewTextBoxColumn
    Friend WithEvents lbl_prg_anio As Label
    Friend WithEvents txt_prg_anio As TextBox
    Friend WithEvents btn_prg_cerrar As Button
End Class
