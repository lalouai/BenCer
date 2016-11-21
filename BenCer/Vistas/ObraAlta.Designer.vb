<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ObraAlta
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
        Me.lbl_obra_alta_titulo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_obra_alta_cod_persona = New System.Windows.Forms.TextBox()
        Me.lbl_obra_alta_ayuda = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_obra_alta_apellido = New System.Windows.Forms.TextBox()
        Me.txt_obra_alta_nombre = New System.Windows.Forms.TextBox()
        Me.txt_obra_alta_dni = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_obra_alta_constructor = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtp_obra_alta_fecha_inicio = New System.Windows.Forms.DateTimePicker()
        Me.cmb_obra_alta_programa = New System.Windows.Forms.ComboBox()
        Me.cmb_obra_alta_prototipo = New System.Windows.Forms.ComboBox()
        Me.btn_obra_alta_crear = New System.Windows.Forms.Button()
        Me.btn_obra_alta_cancelar = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.dgv_obra_alta_resultados = New System.Windows.Forms.DataGridView()
        Me.DNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_obra_alta_reiniciar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_obra_alta_resultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_obra_alta_titulo
        '
        Me.lbl_obra_alta_titulo.AutoSize = True
        Me.lbl_obra_alta_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_obra_alta_titulo.Location = New System.Drawing.Point(482, 27)
        Me.lbl_obra_alta_titulo.Name = "lbl_obra_alta_titulo"
        Me.lbl_obra_alta_titulo.Size = New System.Drawing.Size(127, 24)
        Me.lbl_obra_alta_titulo.TabIndex = 10
        Me.lbl_obra_alta_titulo.Text = "Alta de Obra"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_obra_alta_cod_persona)
        Me.GroupBox1.Controls.Add(Me.lbl_obra_alta_ayuda)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_obra_alta_apellido)
        Me.GroupBox1.Controls.Add(Me.txt_obra_alta_nombre)
        Me.GroupBox1.Controls.Add(Me.txt_obra_alta_dni)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(38, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(571, 174)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Beneficiario"
        '
        'txt_obra_alta_cod_persona
        '
        Me.txt_obra_alta_cod_persona.Location = New System.Drawing.Point(217, 53)
        Me.txt_obra_alta_cod_persona.Name = "txt_obra_alta_cod_persona"
        Me.txt_obra_alta_cod_persona.Size = New System.Drawing.Size(100, 22)
        Me.txt_obra_alta_cod_persona.TabIndex = 16
        Me.txt_obra_alta_cod_persona.Visible = False
        '
        'lbl_obra_alta_ayuda
        '
        Me.lbl_obra_alta_ayuda.AutoSize = True
        Me.lbl_obra_alta_ayuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_obra_alta_ayuda.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_obra_alta_ayuda.Location = New System.Drawing.Point(303, 73)
        Me.lbl_obra_alta_ayuda.Name = "lbl_obra_alta_ayuda"
        Me.lbl_obra_alta_ayuda.Size = New System.Drawing.Size(230, 13)
        Me.lbl_obra_alta_ayuda.TabIndex = 15
        Me.lbl_obra_alta_ayuda.Text = "Ingrese el DNI de un postulante para comenzar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(66, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(66, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(376, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "DNI"
        '
        'txt_obra_alta_apellido
        '
        Me.txt_obra_alta_apellido.Enabled = False
        Me.txt_obra_alta_apellido.Location = New System.Drawing.Point(217, 136)
        Me.txt_obra_alta_apellido.Name = "txt_obra_alta_apellido"
        Me.txt_obra_alta_apellido.Size = New System.Drawing.Size(316, 22)
        Me.txt_obra_alta_apellido.TabIndex = 11
        '
        'txt_obra_alta_nombre
        '
        Me.txt_obra_alta_nombre.Enabled = False
        Me.txt_obra_alta_nombre.Location = New System.Drawing.Point(217, 93)
        Me.txt_obra_alta_nombre.Name = "txt_obra_alta_nombre"
        Me.txt_obra_alta_nombre.Size = New System.Drawing.Size(316, 22)
        Me.txt_obra_alta_nombre.TabIndex = 10
        '
        'txt_obra_alta_dni
        '
        Me.txt_obra_alta_dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_obra_alta_dni.Location = New System.Drawing.Point(433, 50)
        Me.txt_obra_alta_dni.Name = "txt_obra_alta_dni"
        Me.txt_obra_alta_dni.Size = New System.Drawing.Size(100, 20)
        Me.txt_obra_alta_dni.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cmb_obra_alta_constructor)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.dtp_obra_alta_fecha_inicio)
        Me.GroupBox2.Controls.Add(Me.cmb_obra_alta_programa)
        Me.GroupBox2.Controls.Add(Me.cmb_obra_alta_prototipo)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(38, 249)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(571, 229)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de la Obra"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(52, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Constructor"
        '
        'cmb_obra_alta_constructor
        '
        Me.cmb_obra_alta_constructor.Enabled = False
        Me.cmb_obra_alta_constructor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_obra_alta_constructor.FormattingEnabled = True
        Me.cmb_obra_alta_constructor.Location = New System.Drawing.Point(203, 141)
        Me.cmb_obra_alta_constructor.Name = "cmb_obra_alta_constructor"
        Me.cmb_obra_alta_constructor.Size = New System.Drawing.Size(316, 21)
        Me.cmb_obra_alta_constructor.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(52, 204)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Fecha de Inicio"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(52, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Programa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(52, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Prototipo"
        '
        'dtp_obra_alta_fecha_inicio
        '
        Me.dtp_obra_alta_fecha_inicio.Enabled = False
        Me.dtp_obra_alta_fecha_inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_obra_alta_fecha_inicio.Location = New System.Drawing.Point(203, 198)
        Me.dtp_obra_alta_fecha_inicio.Name = "dtp_obra_alta_fecha_inicio"
        Me.dtp_obra_alta_fecha_inicio.Size = New System.Drawing.Size(216, 20)
        Me.dtp_obra_alta_fecha_inicio.TabIndex = 17
        '
        'cmb_obra_alta_programa
        '
        Me.cmb_obra_alta_programa.Enabled = False
        Me.cmb_obra_alta_programa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_obra_alta_programa.FormattingEnabled = True
        Me.cmb_obra_alta_programa.Location = New System.Drawing.Point(203, 39)
        Me.cmb_obra_alta_programa.Name = "cmb_obra_alta_programa"
        Me.cmb_obra_alta_programa.Size = New System.Drawing.Size(316, 21)
        Me.cmb_obra_alta_programa.TabIndex = 16
        '
        'cmb_obra_alta_prototipo
        '
        Me.cmb_obra_alta_prototipo.Enabled = False
        Me.cmb_obra_alta_prototipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_obra_alta_prototipo.FormattingEnabled = True
        Me.cmb_obra_alta_prototipo.Location = New System.Drawing.Point(203, 89)
        Me.cmb_obra_alta_prototipo.Name = "cmb_obra_alta_prototipo"
        Me.cmb_obra_alta_prototipo.Size = New System.Drawing.Size(316, 21)
        Me.cmb_obra_alta_prototipo.TabIndex = 15
        '
        'btn_obra_alta_crear
        '
        Me.btn_obra_alta_crear.Location = New System.Drawing.Point(533, 498)
        Me.btn_obra_alta_crear.Name = "btn_obra_alta_crear"
        Me.btn_obra_alta_crear.Size = New System.Drawing.Size(75, 23)
        Me.btn_obra_alta_crear.TabIndex = 17
        Me.btn_obra_alta_crear.Text = "Crear"
        Me.btn_obra_alta_crear.UseVisualStyleBackColor = True
        '
        'btn_obra_alta_cancelar
        '
        Me.btn_obra_alta_cancelar.Location = New System.Drawing.Point(452, 498)
        Me.btn_obra_alta_cancelar.Name = "btn_obra_alta_cancelar"
        Me.btn_obra_alta_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_obra_alta_cancelar.TabIndex = 18
        Me.btn_obra_alta_cancelar.Text = "Cancelar"
        Me.btn_obra_alta_cancelar.UseVisualStyleBackColor = True
        '
        'dgv_obra_alta_resultados
        '
        Me.dgv_obra_alta_resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_obra_alta_resultados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DNI, Me.apellido, Me.nombre})
        Me.dgv_obra_alta_resultados.Location = New System.Drawing.Point(666, 54)
        Me.dgv_obra_alta_resultados.Name = "dgv_obra_alta_resultados"
        Me.dgv_obra_alta_resultados.RowHeadersVisible = False
        Me.dgv_obra_alta_resultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_obra_alta_resultados.Size = New System.Drawing.Size(388, 191)
        Me.dgv_obra_alta_resultados.TabIndex = 19
        '
        'DNI
        '
        Me.DNI.DataPropertyName = "nro_doc"
        Me.DNI.HeaderText = "DNI"
        Me.DNI.Name = "DNI"
        Me.DNI.ReadOnly = True
        Me.DNI.Width = 80
        '
        'apellido
        '
        Me.apellido.DataPropertyName = "apellido"
        Me.apellido.HeaderText = "Apellido"
        Me.apellido.Name = "apellido"
        Me.apellido.ReadOnly = True
        Me.apellido.Width = 150
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 150
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(663, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(230, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Selecccione el postulante haciendo doble click"
        '
        'btn_obra_alta_reiniciar
        '
        Me.btn_obra_alta_reiniciar.Location = New System.Drawing.Point(371, 498)
        Me.btn_obra_alta_reiniciar.Name = "btn_obra_alta_reiniciar"
        Me.btn_obra_alta_reiniciar.Size = New System.Drawing.Size(75, 23)
        Me.btn_obra_alta_reiniciar.TabIndex = 20
        Me.btn_obra_alta_reiniciar.Text = "Reiniciar"
        Me.btn_obra_alta_reiniciar.UseVisualStyleBackColor = True
        Me.btn_obra_alta_reiniciar.Visible = False
        '
        'ObraAlta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 546)
        Me.Controls.Add(Me.btn_obra_alta_reiniciar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgv_obra_alta_resultados)
        Me.Controls.Add(Me.btn_obra_alta_cancelar)
        Me.Controls.Add(Me.btn_obra_alta_crear)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_obra_alta_titulo)
        Me.Name = "ObraAlta"
        Me.Text = "ObraAlta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_obra_alta_resultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_obra_alta_titulo As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_obra_alta_apellido As TextBox
    Friend WithEvents txt_obra_alta_nombre As TextBox
    Friend WithEvents txt_obra_alta_dni As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtp_obra_alta_fecha_inicio As DateTimePicker
    Friend WithEvents cmb_obra_alta_programa As ComboBox
    Friend WithEvents cmb_obra_alta_prototipo As ComboBox
    Friend WithEvents btn_obra_alta_crear As Button
    Friend WithEvents btn_obra_alta_cancelar As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents dgv_obra_alta_resultados As DataGridView
    Friend WithEvents DNI As DataGridViewTextBoxColumn
    Friend WithEvents apellido As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_obra_alta_ayuda As Label
    Friend WithEvents btn_obra_alta_reiniciar As Button
    Friend WithEvents txt_obra_alta_cod_persona As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmb_obra_alta_constructor As ComboBox
End Class
