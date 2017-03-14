<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Presupuestos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_presu_cerrar = New System.Windows.Forms.Button()
        Me.dvg_presupuesto = New System.Windows.Forms.DataGridView()
        Me.item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo_M_Obra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.incidencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_presu_item = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_presupuesto_error = New System.Windows.Forms.Label()
        Me.txt_presu_descripcion = New System.Windows.Forms.TextBox()
        Me.btn_presu_agregar = New System.Windows.Forms.Button()
        Me.btn_presu_eliminar = New System.Windows.Forms.Button()
        Me.btn_presu_editar = New System.Windows.Forms.Button()
        Me.lbl_presu_titulo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_presu_prototipo = New System.Windows.Forms.Label()
        Me.txt_presu_subitem = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_presu_costo_m_obra = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_presu_consolidar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_presu_costo = New System.Windows.Forms.Label()
        Me.dismisser = New System.Windows.Forms.Timer(Me.components)
        Me.btn_ppto_imprimir_foja = New System.Windows.Forms.Button()
        CType(Me.dvg_presupuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_presu_cerrar
        '
        Me.btn_presu_cerrar.Location = New System.Drawing.Point(773, 462)
        Me.btn_presu_cerrar.Name = "btn_presu_cerrar"
        Me.btn_presu_cerrar.Size = New System.Drawing.Size(142, 23)
        Me.btn_presu_cerrar.TabIndex = 26
        Me.btn_presu_cerrar.Text = "Cerrar"
        Me.btn_presu_cerrar.UseVisualStyleBackColor = True
        '
        'dvg_presupuesto
        '
        Me.dvg_presupuesto.AllowUserToResizeRows = False
        Me.dvg_presupuesto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dvg_presupuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvg_presupuesto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item, Me.descripcion, Me.Costo_M_Obra, Me.incidencia})
        Me.dvg_presupuesto.Location = New System.Drawing.Point(12, 59)
        Me.dvg_presupuesto.Name = "dvg_presupuesto"
        Me.dvg_presupuesto.RowHeadersVisible = False
        Me.dvg_presupuesto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvg_presupuesto.Size = New System.Drawing.Size(755, 426)
        Me.dvg_presupuesto.TabIndex = 23
        '
        'item
        '
        Me.item.DataPropertyName = "item"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.item.DefaultCellStyle = DataGridViewCellStyle4
        Me.item.HeaderText = "Item"
        Me.item.Name = "item"
        Me.item.ReadOnly = True
        Me.item.Width = 60
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "Descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 490
        '
        'Costo_M_Obra
        '
        Me.Costo_M_Obra.DataPropertyName = "costo"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        Me.Costo_M_Obra.DefaultCellStyle = DataGridViewCellStyle5
        Me.Costo_M_Obra.HeaderText = "Costo M de Obra"
        Me.Costo_M_Obra.Name = "Costo_M_Obra"
        Me.Costo_M_Obra.ReadOnly = True
        '
        'incidencia
        '
        Me.incidencia.DataPropertyName = "incidencia"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "P"
        Me.incidencia.DefaultCellStyle = DataGridViewCellStyle6
        Me.incidencia.HeaderText = "Incidencia"
        Me.incidencia.Name = "incidencia"
        Me.incidencia.ReadOnly = True
        '
        'txt_presu_item
        '
        Me.txt_presu_item.Location = New System.Drawing.Point(93, 514)
        Me.txt_presu_item.Name = "txt_presu_item"
        Me.txt_presu_item.Size = New System.Drawing.Size(42, 20)
        Me.txt_presu_item.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(209, 498)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Descripción"
        '
        'lbl_presupuesto_error
        '
        Me.lbl_presupuesto_error.AutoSize = True
        Me.lbl_presupuesto_error.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_presupuesto_error.ForeColor = System.Drawing.Color.Red
        Me.lbl_presupuesto_error.Location = New System.Drawing.Point(9, 548)
        Me.lbl_presupuesto_error.Name = "lbl_presupuesto_error"
        Me.lbl_presupuesto_error.Size = New System.Drawing.Size(51, 15)
        Me.lbl_presupuesto_error.TabIndex = 27
        Me.lbl_presupuesto_error.Text = "Label1"
        Me.lbl_presupuesto_error.Visible = False
        '
        'txt_presu_descripcion
        '
        Me.txt_presu_descripcion.Location = New System.Drawing.Point(205, 514)
        Me.txt_presu_descripcion.Name = "txt_presu_descripcion"
        Me.txt_presu_descripcion.Size = New System.Drawing.Size(451, 20)
        Me.txt_presu_descripcion.TabIndex = 2
        '
        'btn_presu_agregar
        '
        Me.btn_presu_agregar.Location = New System.Drawing.Point(773, 512)
        Me.btn_presu_agregar.Name = "btn_presu_agregar"
        Me.btn_presu_agregar.Size = New System.Drawing.Size(142, 23)
        Me.btn_presu_agregar.TabIndex = 4
        Me.btn_presu_agregar.Text = "Agregar"
        Me.btn_presu_agregar.UseVisualStyleBackColor = True
        '
        'btn_presu_eliminar
        '
        Me.btn_presu_eliminar.Location = New System.Drawing.Point(773, 88)
        Me.btn_presu_eliminar.Name = "btn_presu_eliminar"
        Me.btn_presu_eliminar.Size = New System.Drawing.Size(142, 23)
        Me.btn_presu_eliminar.TabIndex = 25
        Me.btn_presu_eliminar.Text = "Eliminar"
        Me.btn_presu_eliminar.UseVisualStyleBackColor = True
        '
        'btn_presu_editar
        '
        Me.btn_presu_editar.Location = New System.Drawing.Point(773, 59)
        Me.btn_presu_editar.Name = "btn_presu_editar"
        Me.btn_presu_editar.Size = New System.Drawing.Size(142, 23)
        Me.btn_presu_editar.TabIndex = 24
        Me.btn_presu_editar.Text = "Editar"
        Me.btn_presu_editar.UseVisualStyleBackColor = True
        '
        'lbl_presu_titulo
        '
        Me.lbl_presu_titulo.AutoSize = True
        Me.lbl_presu_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_presu_titulo.Location = New System.Drawing.Point(758, 16)
        Me.lbl_presu_titulo.Name = "lbl_presu_titulo"
        Me.lbl_presu_titulo.Size = New System.Drawing.Size(157, 26)
        Me.lbl_presu_titulo.TabIndex = 31
        Me.lbl_presu_titulo.Text = "Presupuestos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Prototipo"
        '
        'lbl_presu_prototipo
        '
        Me.lbl_presu_prototipo.AutoSize = True
        Me.lbl_presu_prototipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_presu_prototipo.Location = New System.Drawing.Point(69, 20)
        Me.lbl_presu_prototipo.Name = "lbl_presu_prototipo"
        Me.lbl_presu_prototipo.Size = New System.Drawing.Size(82, 20)
        Me.lbl_presu_prototipo.TabIndex = 33
        Me.lbl_presu_prototipo.Text = "Prototipo"
        '
        'txt_presu_subitem
        '
        Me.txt_presu_subitem.Location = New System.Drawing.Point(157, 514)
        Me.txt_presu_subitem.Name = "txt_presu_subitem"
        Me.txt_presu_subitem.Size = New System.Drawing.Size(42, 20)
        Me.txt_presu_subitem.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(141, 517)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "-"
        '
        'txt_presu_costo_m_obra
        '
        Me.txt_presu_costo_m_obra.Location = New System.Drawing.Point(662, 514)
        Me.txt_presu_costo_m_obra.Name = "txt_presu_costo_m_obra"
        Me.txt_presu_costo_m_obra.Size = New System.Drawing.Size(105, 20)
        Me.txt_presu_costo_m_obra.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(99, 498)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Item"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(154, 498)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Sub Item"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(662, 498)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Costo M de obra"
        '
        'btn_presu_consolidar
        '
        Me.btn_presu_consolidar.Location = New System.Drawing.Point(773, 146)
        Me.btn_presu_consolidar.Name = "btn_presu_consolidar"
        Me.btn_presu_consolidar.Size = New System.Drawing.Size(142, 23)
        Me.btn_presu_consolidar.TabIndex = 40
        Me.btn_presu_consolidar.Text = "Consolidar"
        Me.btn_presu_consolidar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(436, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 13)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Costo total mano de obra"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_presu_costo
        '
        Me.lbl_presu_costo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_presu_costo.AutoSize = True
        Me.lbl_presu_costo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_presu_costo.Location = New System.Drawing.Point(593, 20)
        Me.lbl_presu_costo.Name = "lbl_presu_costo"
        Me.lbl_presu_costo.Size = New System.Drawing.Size(63, 20)
        Me.lbl_presu_costo.TabIndex = 41
        Me.lbl_presu_costo.Text = "Label1"
        Me.lbl_presu_costo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dismisser
        '
        Me.dismisser.Interval = 3000
        '
        'btn_ppto_imprimir_foja
        '
        Me.btn_ppto_imprimir_foja.Location = New System.Drawing.Point(773, 117)
        Me.btn_ppto_imprimir_foja.Name = "btn_ppto_imprimir_foja"
        Me.btn_ppto_imprimir_foja.Size = New System.Drawing.Size(142, 23)
        Me.btn_ppto_imprimir_foja.TabIndex = 43
        Me.btn_ppto_imprimir_foja.Text = "Imprimir"
        Me.btn_ppto_imprimir_foja.UseVisualStyleBackColor = True
        '
        'Presupuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 576)
        Me.Controls.Add(Me.btn_ppto_imprimir_foja)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbl_presu_costo)
        Me.Controls.Add(Me.btn_presu_consolidar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_presu_costo_m_obra)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_presu_subitem)
        Me.Controls.Add(Me.lbl_presu_prototipo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_presu_titulo)
        Me.Controls.Add(Me.btn_presu_cerrar)
        Me.Controls.Add(Me.dvg_presupuesto)
        Me.Controls.Add(Me.txt_presu_item)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_presupuesto_error)
        Me.Controls.Add(Me.txt_presu_descripcion)
        Me.Controls.Add(Me.btn_presu_agregar)
        Me.Controls.Add(Me.btn_presu_eliminar)
        Me.Controls.Add(Me.btn_presu_editar)
        Me.Name = "Presupuestos"
        Me.Text = "Presupuestos"
        CType(Me.dvg_presupuesto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_presu_cerrar As Button
    Friend WithEvents dvg_presupuesto As DataGridView
    Friend WithEvents txt_presu_item As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_presupuesto_error As Label
    Friend WithEvents txt_presu_descripcion As TextBox
    Friend WithEvents btn_presu_agregar As Button
    Friend WithEvents btn_presu_eliminar As Button
    Friend WithEvents btn_presu_editar As Button
    Friend WithEvents lbl_presu_titulo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_presu_prototipo As Label
    Friend WithEvents txt_presu_subitem As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_presu_costo_m_obra As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_presu_consolidar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_presu_costo As Label
    Friend WithEvents item As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Costo_M_Obra As DataGridViewTextBoxColumn
    Friend WithEvents incidencia As DataGridViewTextBoxColumn
    Friend WithEvents dismisser As Timer
    Friend WithEvents btn_ppto_imprimir_foja As Button
End Class
