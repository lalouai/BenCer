<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Constructores
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
        Me.dvg_cons = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ape_Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_cons_editar = New System.Windows.Forms.Button()
        Me.btn_cons_eliminar = New System.Windows.Forms.Button()
        Me.btn_cons_agregar = New System.Windows.Forms.Button()
        Me.txt_cons_cuit = New System.Windows.Forms.TextBox()
        Me.txt_cons_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_cons_error = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cons_cod_constructor = New System.Windows.Forms.TextBox()
        Me.btn_cons_cerrar = New System.Windows.Forms.Button()
        CType(Me.dvg_cons, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dvg_cons
        '
        Me.dvg_cons.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dvg_cons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvg_cons.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Ape_Nom, Me.cuit})
        Me.dvg_cons.Location = New System.Drawing.Point(12, 12)
        Me.dvg_cons.Name = "dvg_cons"
        Me.dvg_cons.RowHeadersVisible = False
        Me.dvg_cons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvg_cons.Size = New System.Drawing.Size(755, 426)
        Me.dvg_cons.TabIndex = 3
        '
        'ID
        '
        Me.ID.DataPropertyName = "cod_constructor"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ID.DefaultCellStyle = DataGridViewCellStyle1
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'Ape_Nom
        '
        Me.Ape_Nom.DataPropertyName = "nombre"
        Me.Ape_Nom.HeaderText = "Apellido y Nombre"
        Me.Ape_Nom.Name = "Ape_Nom"
        Me.Ape_Nom.ReadOnly = True
        Me.Ape_Nom.Width = 500
        '
        'cuit
        '
        Me.cuit.DataPropertyName = "cuit"
        Me.cuit.HeaderText = "CUIT"
        Me.cuit.Name = "cuit"
        Me.cuit.ReadOnly = True
        Me.cuit.Width = 150
        '
        'btn_cons_editar
        '
        Me.btn_cons_editar.Location = New System.Drawing.Point(773, 12)
        Me.btn_cons_editar.Name = "btn_cons_editar"
        Me.btn_cons_editar.Size = New System.Drawing.Size(142, 23)
        Me.btn_cons_editar.TabIndex = 4
        Me.btn_cons_editar.Text = "Editar"
        Me.btn_cons_editar.UseVisualStyleBackColor = True
        '
        'btn_cons_eliminar
        '
        Me.btn_cons_eliminar.Location = New System.Drawing.Point(773, 41)
        Me.btn_cons_eliminar.Name = "btn_cons_eliminar"
        Me.btn_cons_eliminar.Size = New System.Drawing.Size(142, 23)
        Me.btn_cons_eliminar.TabIndex = 5
        Me.btn_cons_eliminar.Text = "Eliminar"
        Me.btn_cons_eliminar.UseVisualStyleBackColor = True
        '
        'btn_cons_agregar
        '
        Me.btn_cons_agregar.Location = New System.Drawing.Point(773, 465)
        Me.btn_cons_agregar.Name = "btn_cons_agregar"
        Me.btn_cons_agregar.Size = New System.Drawing.Size(142, 23)
        Me.btn_cons_agregar.TabIndex = 2
        Me.btn_cons_agregar.Text = "Agregar"
        Me.btn_cons_agregar.UseVisualStyleBackColor = True
        '
        'txt_cons_cuit
        '
        Me.txt_cons_cuit.Location = New System.Drawing.Point(628, 467)
        Me.txt_cons_cuit.Name = "txt_cons_cuit"
        Me.txt_cons_cuit.Size = New System.Drawing.Size(137, 20)
        Me.txt_cons_cuit.TabIndex = 1
        '
        'txt_cons_nombre
        '
        Me.txt_cons_nombre.Location = New System.Drawing.Point(374, 467)
        Me.txt_cons_nombre.Name = "txt_cons_nombre"
        Me.txt_cons_nombre.Size = New System.Drawing.Size(248, 20)
        Me.txt_cons_nombre.TabIndex = 0
        '
        'lbl_cons_error
        '
        Me.lbl_cons_error.AutoSize = True
        Me.lbl_cons_error.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cons_error.ForeColor = System.Drawing.Color.Red
        Me.lbl_cons_error.Location = New System.Drawing.Point(12, 470)
        Me.lbl_cons_error.Name = "lbl_cons_error"
        Me.lbl_cons_error.Size = New System.Drawing.Size(51, 15)
        Me.lbl_cons_error.TabIndex = 6
        Me.lbl_cons_error.Text = "Label1"
        Me.lbl_cons_error.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(374, 448)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Apellido y Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(625, 448)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "CUIT"
        '
        'txt_cons_cod_constructor
        '
        Me.txt_cons_cod_constructor.Location = New System.Drawing.Point(326, 468)
        Me.txt_cons_cod_constructor.Name = "txt_cons_cod_constructor"
        Me.txt_cons_cod_constructor.Size = New System.Drawing.Size(42, 20)
        Me.txt_cons_cod_constructor.TabIndex = 9
        Me.txt_cons_cod_constructor.Visible = False
        '
        'btn_cons_cerrar
        '
        Me.btn_cons_cerrar.Location = New System.Drawing.Point(773, 415)
        Me.btn_cons_cerrar.Name = "btn_cons_cerrar"
        Me.btn_cons_cerrar.Size = New System.Drawing.Size(142, 23)
        Me.btn_cons_cerrar.TabIndex = 6
        Me.btn_cons_cerrar.Text = "Cerrar"
        Me.btn_cons_cerrar.UseVisualStyleBackColor = True
        '
        'Constructores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 531)
        Me.Controls.Add(Me.btn_cons_cerrar)
        Me.Controls.Add(Me.txt_cons_cod_constructor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_cons_error)
        Me.Controls.Add(Me.txt_cons_nombre)
        Me.Controls.Add(Me.txt_cons_cuit)
        Me.Controls.Add(Me.btn_cons_agregar)
        Me.Controls.Add(Me.btn_cons_eliminar)
        Me.Controls.Add(Me.btn_cons_editar)
        Me.Controls.Add(Me.dvg_cons)
        Me.Name = "Constructores"
        Me.Text = "Constructor"
        CType(Me.dvg_cons, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dvg_cons As DataGridView
    Friend WithEvents btn_cons_editar As Button
    Friend WithEvents btn_cons_eliminar As Button
    Friend WithEvents btn_cons_agregar As Button
    Friend WithEvents txt_cons_cuit As TextBox
    Friend WithEvents txt_cons_nombre As TextBox
    Friend WithEvents lbl_cons_error As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Ape_Nom As DataGridViewTextBoxColumn
    Friend WithEvents cuit As DataGridViewTextBoxColumn
    Friend WithEvents txt_cons_cod_constructor As TextBox
    Friend WithEvents btn_cons_cerrar As Button
End Class
