<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prototipos
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
        Me.dvg_prototipo = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_prototipo_cod_prototipo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_prototipo_error = New System.Windows.Forms.Label()
        Me.txt_prototipo_nombre = New System.Windows.Forms.TextBox()
        Me.btn_prototipo_agregar = New System.Windows.Forms.Button()
        Me.btn_prototipo_eliminar = New System.Windows.Forms.Button()
        Me.btn_prototipo_editar = New System.Windows.Forms.Button()
        Me.btn_prototipo_cerrar = New System.Windows.Forms.Button()
        Me.btn_proto_cargar_ppto = New System.Windows.Forms.Button()
        Me.btn_proto_liberar_ppto = New System.Windows.Forms.Button()
        Me.dismisser = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dvg_prototipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dvg_prototipo
        '
        Me.dvg_prototipo.AllowUserToResizeRows = False
        Me.dvg_prototipo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dvg_prototipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvg_prototipo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.nombre})
        Me.dvg_prototipo.Location = New System.Drawing.Point(12, 12)
        Me.dvg_prototipo.Name = "dvg_prototipo"
        Me.dvg_prototipo.RowHeadersVisible = False
        Me.dvg_prototipo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dvg_prototipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvg_prototipo.Size = New System.Drawing.Size(755, 426)
        Me.dvg_prototipo.TabIndex = 2
        '
        'ID
        '
        Me.ID.DataPropertyName = "cod_tipo_obra"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ID.DefaultCellStyle = DataGridViewCellStyle1
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "descripcion"
        Me.nombre.HeaderText = "Prototipo"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 650
        '
        'txt_prototipo_cod_prototipo
        '
        Me.txt_prototipo_cod_prototipo.Location = New System.Drawing.Point(471, 468)
        Me.txt_prototipo_cod_prototipo.Name = "txt_prototipo_cod_prototipo"
        Me.txt_prototipo_cod_prototipo.Size = New System.Drawing.Size(42, 20)
        Me.txt_prototipo_cod_prototipo.TabIndex = 19
        Me.txt_prototipo_cod_prototipo.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(519, 448)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Prototipo"
        '
        'lbl_prototipo_error
        '
        Me.lbl_prototipo_error.AutoSize = True
        Me.lbl_prototipo_error.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_prototipo_error.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prototipo_error.ForeColor = System.Drawing.Color.Red
        Me.lbl_prototipo_error.Location = New System.Drawing.Point(9, 446)
        Me.lbl_prototipo_error.Name = "lbl_prototipo_error"
        Me.lbl_prototipo_error.Size = New System.Drawing.Size(38, 15)
        Me.lbl_prototipo_error.TabIndex = 16
        Me.lbl_prototipo_error.Text = "error"
        Me.lbl_prototipo_error.Visible = False
        '
        'txt_prototipo_nombre
        '
        Me.txt_prototipo_nombre.Location = New System.Drawing.Point(519, 467)
        Me.txt_prototipo_nombre.Name = "txt_prototipo_nombre"
        Me.txt_prototipo_nombre.Size = New System.Drawing.Size(248, 20)
        Me.txt_prototipo_nombre.TabIndex = 0
        '
        'btn_prototipo_agregar
        '
        Me.btn_prototipo_agregar.Location = New System.Drawing.Point(773, 465)
        Me.btn_prototipo_agregar.Name = "btn_prototipo_agregar"
        Me.btn_prototipo_agregar.Size = New System.Drawing.Size(142, 23)
        Me.btn_prototipo_agregar.TabIndex = 1
        Me.btn_prototipo_agregar.Text = "Agregar"
        Me.btn_prototipo_agregar.UseVisualStyleBackColor = True
        '
        'btn_prototipo_eliminar
        '
        Me.btn_prototipo_eliminar.Location = New System.Drawing.Point(773, 41)
        Me.btn_prototipo_eliminar.Name = "btn_prototipo_eliminar"
        Me.btn_prototipo_eliminar.Size = New System.Drawing.Size(142, 23)
        Me.btn_prototipo_eliminar.TabIndex = 4
        Me.btn_prototipo_eliminar.Text = "Eliminar"
        Me.btn_prototipo_eliminar.UseVisualStyleBackColor = True
        '
        'btn_prototipo_editar
        '
        Me.btn_prototipo_editar.Location = New System.Drawing.Point(773, 12)
        Me.btn_prototipo_editar.Name = "btn_prototipo_editar"
        Me.btn_prototipo_editar.Size = New System.Drawing.Size(142, 23)
        Me.btn_prototipo_editar.TabIndex = 3
        Me.btn_prototipo_editar.Text = "Editar"
        Me.btn_prototipo_editar.UseVisualStyleBackColor = True
        '
        'btn_prototipo_cerrar
        '
        Me.btn_prototipo_cerrar.Location = New System.Drawing.Point(773, 415)
        Me.btn_prototipo_cerrar.Name = "btn_prototipo_cerrar"
        Me.btn_prototipo_cerrar.Size = New System.Drawing.Size(142, 23)
        Me.btn_prototipo_cerrar.TabIndex = 5
        Me.btn_prototipo_cerrar.Text = "Cerrar"
        Me.btn_prototipo_cerrar.UseVisualStyleBackColor = True
        '
        'btn_proto_cargar_ppto
        '
        Me.btn_proto_cargar_ppto.Location = New System.Drawing.Point(773, 93)
        Me.btn_proto_cargar_ppto.Name = "btn_proto_cargar_ppto"
        Me.btn_proto_cargar_ppto.Size = New System.Drawing.Size(142, 23)
        Me.btn_proto_cargar_ppto.TabIndex = 20
        Me.btn_proto_cargar_ppto.Text = "Cargar / Ver ppto"
        Me.btn_proto_cargar_ppto.UseVisualStyleBackColor = True
        '
        'btn_proto_liberar_ppto
        '
        Me.btn_proto_liberar_ppto.Location = New System.Drawing.Point(774, 123)
        Me.btn_proto_liberar_ppto.Name = "btn_proto_liberar_ppto"
        Me.btn_proto_liberar_ppto.Size = New System.Drawing.Size(141, 23)
        Me.btn_proto_liberar_ppto.TabIndex = 21
        Me.btn_proto_liberar_ppto.Text = "Eliminar ppto asociado"
        Me.btn_proto_liberar_ppto.UseVisualStyleBackColor = True
        '
        'dismisser
        '
        Me.dismisser.Interval = 4000
        '
        'Prototipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 532)
        Me.Controls.Add(Me.btn_proto_liberar_ppto)
        Me.Controls.Add(Me.btn_proto_cargar_ppto)
        Me.Controls.Add(Me.btn_prototipo_cerrar)
        Me.Controls.Add(Me.dvg_prototipo)
        Me.Controls.Add(Me.txt_prototipo_cod_prototipo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_prototipo_error)
        Me.Controls.Add(Me.txt_prototipo_nombre)
        Me.Controls.Add(Me.btn_prototipo_agregar)
        Me.Controls.Add(Me.btn_prototipo_eliminar)
        Me.Controls.Add(Me.btn_prototipo_editar)
        Me.Name = "Prototipos"
        Me.Text = "Prototipos"
        CType(Me.dvg_prototipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dvg_prototipo As DataGridView
    Friend WithEvents txt_prototipo_cod_prototipo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_prototipo_error As Label
    Friend WithEvents txt_prototipo_nombre As TextBox
    Friend WithEvents btn_prototipo_agregar As Button
    Friend WithEvents btn_prototipo_eliminar As Button
    Friend WithEvents btn_prototipo_editar As Button
    Friend WithEvents btn_prototipo_cerrar As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents btn_proto_cargar_ppto As Button
    Friend WithEvents btn_proto_liberar_ppto As Button
    Friend WithEvents dismisser As Timer
End Class
