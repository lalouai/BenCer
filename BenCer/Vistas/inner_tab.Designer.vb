<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inner_tab
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.txt_costo = New System.Windows.Forms.TextBox()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_item = New System.Windows.Forms.TextBox()
        Me.lbl_costo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_subitem = New System.Windows.Forms.TextBox()
        Me.item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grilla
        '
        Me.grilla.AllowUserToOrderColumns = True
        Me.grilla.BackgroundColor = System.Drawing.SystemColors.Control
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item, Me.descripcion, Me.costo})
        Me.grilla.GridColor = System.Drawing.SystemColors.Control
        Me.grilla.Location = New System.Drawing.Point(12, 13)
        Me.grilla.Name = "grilla"
        Me.grilla.RowHeadersVisible = False
        Me.grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grilla.Size = New System.Drawing.Size(754, 367)
        Me.grilla.TabIndex = 5
        '
        'btn_editar
        '
        Me.btn_editar.Location = New System.Drawing.Point(772, 13)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(109, 23)
        Me.btn_editar.TabIndex = 6
        Me.btn_editar.Text = "editar"
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(772, 42)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(109, 23)
        Me.btn_eliminar.TabIndex = 7
        Me.btn_eliminar.Text = "eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(772, 458)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(109, 23)
        Me.btn_agregar.TabIndex = 4
        Me.btn_agregar.Text = "agregar item"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'txt_costo
        '
        Me.txt_costo.Location = New System.Drawing.Point(665, 460)
        Me.txt_costo.Name = "txt_costo"
        Me.txt_costo.Size = New System.Drawing.Size(101, 20)
        Me.txt_costo.TabIndex = 3
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(114, 460)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(545, 20)
        Me.txt_descripcion.TabIndex = 2
        '
        'txt_item
        '
        Me.txt_item.Location = New System.Drawing.Point(12, 460)
        Me.txt_item.Name = "txt_item"
        Me.txt_item.Size = New System.Drawing.Size(45, 20)
        Me.txt_item.TabIndex = 0
        '
        'lbl_costo
        '
        Me.lbl_costo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_costo.AutoSize = True
        Me.lbl_costo.Location = New System.Drawing.Point(725, 401)
        Me.lbl_costo.Name = "lbl_costo"
        Me.lbl_costo.Size = New System.Drawing.Size(39, 13)
        Me.lbl_costo.TabIndex = 8
        Me.lbl_costo.Text = "Label1"
        Me.lbl_costo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(533, 401)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Costo total mano de obra"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_subitem
        '
        Me.txt_subitem.Location = New System.Drawing.Point(63, 460)
        Me.txt_subitem.Name = "txt_subitem"
        Me.txt_subitem.Size = New System.Drawing.Size(45, 20)
        Me.txt_subitem.TabIndex = 1
        '
        'item
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.item.DefaultCellStyle = DataGridViewCellStyle9
        Me.item.HeaderText = "ITEM"
        Me.item.Name = "item"
        Me.item.Width = 50
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Width = 600
        '
        'costo
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.costo.DefaultCellStyle = DataGridViewCellStyle10
        Me.costo.HeaderText = "Costo"
        Me.costo.Name = "costo"
        '
        'inner_tab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 511)
        Me.Controls.Add(Me.txt_subitem)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_costo)
        Me.Controls.Add(Me.txt_item)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.txt_costo)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.grilla)
        Me.Name = "inner_tab"
        Me.Text = "Form1"
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grilla As DataGridView
    Friend WithEvents btn_editar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_agregar As Button
    Friend WithEvents txt_costo As TextBox
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents txt_item As TextBox
    Friend WithEvents lbl_costo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_subitem As TextBox
    Friend WithEvents item As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents costo As DataGridViewTextBoxColumn
End Class
