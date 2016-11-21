<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Personas
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
        Me.TC = New System.Windows.Forms.TabControl()
        Me.tab_beneficiarios = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_ben_filtrar = New System.Windows.Forms.TextBox()
        Me.dvg_ben = New System.Windows.Forms.DataGridView()
        Me.DNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prototipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ejecutado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cetificar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Obra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tab_postulantes = New System.Windows.Forms.TabPage()
        Me.btn_convertir = New System.Windows.Forms.Button()
        Me.lbl_error = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbTipoDoc = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.btn_crear = New System.Windows.Forms.Button()
        Me.txt_dni = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.dgv_postulantes = New System.Windows.Forms.DataGridView()
        Me.tab_familiares = New System.Windows.Forms.TabPage()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lbl_fam_documento = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lbl_fam_apellido = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_parentezco = New System.Windows.Forms.ComboBox()
        Me.btn_fam_baja_grupo = New System.Windows.Forms.Button()
        Me.btn_fam_editar = New System.Windows.Forms.Button()
        Me.bnt_fam_eliminar = New System.Windows.Forms.Button()
        Me.lbl_fam_error = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmb_fam_estado_civil = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmb_fam_tipo_doc = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_fam_apellidos = New System.Windows.Forms.TextBox()
        Me.lbl_fam_nombre = New System.Windows.Forms.Label()
        Me.btn_fam_crear = New System.Windows.Forms.Button()
        Me.txt_fam_nro_doc = New System.Windows.Forms.TextBox()
        Me.txt_fam_nombres = New System.Windows.Forms.TextBox()
        Me.dgv_fam = New System.Windows.Forms.DataGridView()
        Me.TC.SuspendLayout()
        Me.tab_beneficiarios.SuspendLayout()
        CType(Me.dvg_ben, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_postulantes.SuspendLayout()
        CType(Me.dgv_postulantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_familiares.SuspendLayout()
        CType(Me.dgv_fam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TC
        '
        Me.TC.Controls.Add(Me.tab_beneficiarios)
        Me.TC.Controls.Add(Me.tab_postulantes)
        Me.TC.Controls.Add(Me.tab_familiares)
        Me.TC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TC.Location = New System.Drawing.Point(0, 0)
        Me.TC.Name = "TC"
        Me.TC.SelectedIndex = 0
        Me.TC.Size = New System.Drawing.Size(1011, 747)
        Me.TC.TabIndex = 17
        '
        'tab_beneficiarios
        '
        Me.tab_beneficiarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tab_beneficiarios.Controls.Add(Me.Label1)
        Me.tab_beneficiarios.Controls.Add(Me.txt_ben_filtrar)
        Me.tab_beneficiarios.Controls.Add(Me.dvg_ben)
        Me.tab_beneficiarios.Location = New System.Drawing.Point(4, 22)
        Me.tab_beneficiarios.Name = "tab_beneficiarios"
        Me.tab_beneficiarios.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_beneficiarios.Size = New System.Drawing.Size(1003, 721)
        Me.tab_beneficiarios.TabIndex = 0
        Me.tab_beneficiarios.Text = "Beneficiarios"
        Me.tab_beneficiarios.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(793, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Filtrar"
        '
        'txt_ben_filtrar
        '
        Me.txt_ben_filtrar.Location = New System.Drawing.Point(838, 19)
        Me.txt_ben_filtrar.Name = "txt_ben_filtrar"
        Me.txt_ben_filtrar.Size = New System.Drawing.Size(156, 20)
        Me.txt_ben_filtrar.TabIndex = 48
        '
        'dvg_ben
        '
        Me.dvg_ben.AllowUserToOrderColumns = True
        Me.dvg_ben.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dvg_ben.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvg_ben.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DNI, Me.Apellido, Me.Nombre, Me.Prototipo, Me.Ejecutado, Me.Cetificar, Me.Obra})
        Me.dvg_ben.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dvg_ben.Location = New System.Drawing.Point(8, 45)
        Me.dvg_ben.MultiSelect = False
        Me.dvg_ben.Name = "dvg_ben"
        Me.dvg_ben.RowHeadersVisible = False
        Me.dvg_ben.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvg_ben.Size = New System.Drawing.Size(987, 518)
        Me.dvg_ben.TabIndex = 47
        '
        'DNI
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DNI.DefaultCellStyle = DataGridViewCellStyle1
        Me.DNI.HeaderText = "DNI"
        Me.DNI.Name = "DNI"
        Me.DNI.ReadOnly = True
        Me.DNI.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        Me.Apellido.Width = 200
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 200
        '
        'Prototipo
        '
        Me.Prototipo.HeaderText = "Prototipo"
        Me.Prototipo.Name = "Prototipo"
        Me.Prototipo.ReadOnly = True
        Me.Prototipo.Width = 200
        '
        'Ejecutado
        '
        Me.Ejecutado.HeaderText = "Ejecutado"
        Me.Ejecutado.Name = "Ejecutado"
        Me.Ejecutado.ReadOnly = True
        Me.Ejecutado.Width = 70
        '
        'Cetificar
        '
        Me.Cetificar.HeaderText = "Certificar"
        Me.Cetificar.Name = "Cetificar"
        '
        'Obra
        '
        Me.Obra.HeaderText = "Obra"
        Me.Obra.Name = "Obra"
        Me.Obra.ReadOnly = True
        '
        'tab_postulantes
        '
        Me.tab_postulantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tab_postulantes.Controls.Add(Me.btn_convertir)
        Me.tab_postulantes.Controls.Add(Me.lbl_error)
        Me.tab_postulantes.Controls.Add(Me.Label7)
        Me.tab_postulantes.Controls.Add(Me.cmbEstado)
        Me.tab_postulantes.Controls.Add(Me.Label6)
        Me.tab_postulantes.Controls.Add(Me.Label5)
        Me.tab_postulantes.Controls.Add(Me.Label4)
        Me.tab_postulantes.Controls.Add(Me.Label3)
        Me.tab_postulantes.Controls.Add(Me.cmbTipoDoc)
        Me.tab_postulantes.Controls.Add(Me.Label2)
        Me.tab_postulantes.Controls.Add(Me.txtApellido)
        Me.tab_postulantes.Controls.Add(Me.btn_crear)
        Me.tab_postulantes.Controls.Add(Me.txt_dni)
        Me.tab_postulantes.Controls.Add(Me.txtNombre)
        Me.tab_postulantes.Controls.Add(Me.dgv_postulantes)
        Me.tab_postulantes.Location = New System.Drawing.Point(4, 22)
        Me.tab_postulantes.Name = "tab_postulantes"
        Me.tab_postulantes.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_postulantes.Size = New System.Drawing.Size(1003, 721)
        Me.tab_postulantes.TabIndex = 1
        Me.tab_postulantes.Text = "Postulantes"
        Me.tab_postulantes.UseVisualStyleBackColor = True
        '
        'btn_convertir
        '
        Me.btn_convertir.Location = New System.Drawing.Point(10, 569)
        Me.btn_convertir.Name = "btn_convertir"
        Me.btn_convertir.Size = New System.Drawing.Size(158, 23)
        Me.btn_convertir.TabIndex = 64
        Me.btn_convertir.Text = "Convertir en beneficiario"
        Me.btn_convertir.UseVisualStyleBackColor = True
        '
        'lbl_error
        '
        Me.lbl_error.AutoSize = True
        Me.lbl_error.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_error.ForeColor = System.Drawing.Color.Red
        Me.lbl_error.Location = New System.Drawing.Point(7, 527)
        Me.lbl_error.Name = "lbl_error"
        Me.lbl_error.Size = New System.Drawing.Size(87, 13)
        Me.lbl_error.TabIndex = 63
        Me.lbl_error.Text = "XX-XXX-XXXX"
        Me.lbl_error.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(504, 662)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Estado Civil"
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(572, 659)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(169, 21)
        Me.cmbEstado.TabIndex = 53
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(755, 596)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Apellidos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(764, 574)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Documento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(894, 555)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Número"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(829, 555)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Tipo"
        '
        'cmbTipoDoc
        '
        Me.cmbTipoDoc.FormattingEnabled = True
        Me.cmbTipoDoc.Location = New System.Drawing.Point(832, 571)
        Me.cmbTipoDoc.Name = "cmbTipoDoc"
        Me.cmbTipoDoc.Size = New System.Drawing.Size(59, 21)
        Me.cmbTipoDoc.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(502, 596)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Nombres"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(758, 612)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(236, 20)
        Me.txtApellido.TabIndex = 52
        '
        'btn_crear
        '
        Me.btn_crear.Location = New System.Drawing.Point(919, 690)
        Me.btn_crear.Name = "btn_crear"
        Me.btn_crear.Size = New System.Drawing.Size(75, 23)
        Me.btn_crear.TabIndex = 55
        Me.btn_crear.Text = "Crear"
        Me.btn_crear.UseVisualStyleBackColor = True
        '
        'txt_dni
        '
        Me.txt_dni.Location = New System.Drawing.Point(897, 571)
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.Size = New System.Drawing.Size(97, 20)
        Me.txt_dni.TabIndex = 50
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(505, 612)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(236, 20)
        Me.txtNombre.TabIndex = 51
        '
        'dgv_postulantes
        '
        Me.dgv_postulantes.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_postulantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_postulantes.Location = New System.Drawing.Point(7, 6)
        Me.dgv_postulantes.Name = "dgv_postulantes"
        Me.dgv_postulantes.Size = New System.Drawing.Size(987, 518)
        Me.dgv_postulantes.TabIndex = 48
        '
        'tab_familiares
        '
        Me.tab_familiares.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tab_familiares.Controls.Add(Me.Label18)
        Me.tab_familiares.Controls.Add(Me.lbl_fam_documento)
        Me.tab_familiares.Controls.Add(Me.Label16)
        Me.tab_familiares.Controls.Add(Me.lbl_fam_apellido)
        Me.tab_familiares.Controls.Add(Me.Label17)
        Me.tab_familiares.Controls.Add(Me.Label8)
        Me.tab_familiares.Controls.Add(Me.cmb_parentezco)
        Me.tab_familiares.Controls.Add(Me.btn_fam_baja_grupo)
        Me.tab_familiares.Controls.Add(Me.btn_fam_editar)
        Me.tab_familiares.Controls.Add(Me.bnt_fam_eliminar)
        Me.tab_familiares.Controls.Add(Me.lbl_fam_error)
        Me.tab_familiares.Controls.Add(Me.Label9)
        Me.tab_familiares.Controls.Add(Me.cmb_fam_estado_civil)
        Me.tab_familiares.Controls.Add(Me.Label10)
        Me.tab_familiares.Controls.Add(Me.Label11)
        Me.tab_familiares.Controls.Add(Me.Label12)
        Me.tab_familiares.Controls.Add(Me.Label13)
        Me.tab_familiares.Controls.Add(Me.cmb_fam_tipo_doc)
        Me.tab_familiares.Controls.Add(Me.Label14)
        Me.tab_familiares.Controls.Add(Me.Label15)
        Me.tab_familiares.Controls.Add(Me.txt_fam_apellidos)
        Me.tab_familiares.Controls.Add(Me.lbl_fam_nombre)
        Me.tab_familiares.Controls.Add(Me.btn_fam_crear)
        Me.tab_familiares.Controls.Add(Me.txt_fam_nro_doc)
        Me.tab_familiares.Controls.Add(Me.txt_fam_nombres)
        Me.tab_familiares.Controls.Add(Me.dgv_fam)
        Me.tab_familiares.Location = New System.Drawing.Point(4, 22)
        Me.tab_familiares.Name = "tab_familiares"
        Me.tab_familiares.Size = New System.Drawing.Size(1003, 721)
        Me.tab_familiares.TabIndex = 2
        Me.tab_familiares.Text = "Familiares"
        Me.tab_familiares.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(10, 96)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(62, 13)
        Me.Label18.TabIndex = 88
        Me.Label18.Text = "Documento"
        '
        'lbl_fam_documento
        '
        Me.lbl_fam_documento.AutoSize = True
        Me.lbl_fam_documento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fam_documento.Location = New System.Drawing.Point(106, 93)
        Me.lbl_fam_documento.Name = "lbl_fam_documento"
        Me.lbl_fam_documento.Size = New System.Drawing.Size(99, 16)
        Me.lbl_fam_documento.TabIndex = 87
        Me.lbl_fam_documento.Text = "XX-XXX-XXXX"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(10, 67)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 13)
        Me.Label16.TabIndex = 86
        Me.Label16.Text = "Apellido"
        '
        'lbl_fam_apellido
        '
        Me.lbl_fam_apellido.AutoSize = True
        Me.lbl_fam_apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fam_apellido.Location = New System.Drawing.Point(106, 64)
        Me.lbl_fam_apellido.Name = "lbl_fam_apellido"
        Me.lbl_fam_apellido.Size = New System.Drawing.Size(99, 16)
        Me.lbl_fam_apellido.TabIndex = 85
        Me.lbl_fam_apellido.Text = "XX-XXX-XXXX"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(10, 11)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(91, 16)
        Me.Label17.TabIndex = 84
        Me.Label17.Text = "Beneficiario"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(264, 583)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "Parentezco"
        '
        'cmb_parentezco
        '
        Me.cmb_parentezco.FormattingEnabled = True
        Me.cmb_parentezco.Location = New System.Drawing.Point(332, 580)
        Me.cmb_parentezco.Name = "cmb_parentezco"
        Me.cmb_parentezco.Size = New System.Drawing.Size(169, 21)
        Me.cmb_parentezco.TabIndex = 82
        '
        'btn_fam_baja_grupo
        '
        Me.btn_fam_baja_grupo.Location = New System.Drawing.Point(869, 506)
        Me.btn_fam_baja_grupo.Name = "btn_fam_baja_grupo"
        Me.btn_fam_baja_grupo.Size = New System.Drawing.Size(125, 23)
        Me.btn_fam_baja_grupo.TabIndex = 81
        Me.btn_fam_baja_grupo.Text = "Baja del grupo"
        Me.btn_fam_baja_grupo.UseVisualStyleBackColor = True
        '
        'btn_fam_editar
        '
        Me.btn_fam_editar.Location = New System.Drawing.Point(869, 535)
        Me.btn_fam_editar.Name = "btn_fam_editar"
        Me.btn_fam_editar.Size = New System.Drawing.Size(125, 23)
        Me.btn_fam_editar.TabIndex = 80
        Me.btn_fam_editar.Text = "Editar"
        Me.btn_fam_editar.UseVisualStyleBackColor = True
        '
        'bnt_fam_eliminar
        '
        Me.bnt_fam_eliminar.Location = New System.Drawing.Point(869, 564)
        Me.bnt_fam_eliminar.Name = "bnt_fam_eliminar"
        Me.bnt_fam_eliminar.Size = New System.Drawing.Size(125, 23)
        Me.bnt_fam_eliminar.TabIndex = 79
        Me.bnt_fam_eliminar.Text = "Eliminar"
        Me.bnt_fam_eliminar.UseVisualStyleBackColor = True
        '
        'lbl_fam_error
        '
        Me.lbl_fam_error.AutoSize = True
        Me.lbl_fam_error.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fam_error.ForeColor = System.Drawing.Color.Red
        Me.lbl_fam_error.Location = New System.Drawing.Point(702, 48)
        Me.lbl_fam_error.Name = "lbl_fam_error"
        Me.lbl_fam_error.Size = New System.Drawing.Size(99, 16)
        Me.lbl_fam_error.TabIndex = 78
        Me.lbl_fam_error.Text = "XX-XXX-XXXX"
        Me.lbl_fam_error.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 583)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 77
        Me.Label9.Text = "Estado Civil"
        '
        'cmb_fam_estado_civil
        '
        Me.cmb_fam_estado_civil.FormattingEnabled = True
        Me.cmb_fam_estado_civil.Location = New System.Drawing.Point(79, 580)
        Me.cmb_fam_estado_civil.Name = "cmb_fam_estado_civil"
        Me.cmb_fam_estado_civil.Size = New System.Drawing.Size(169, 21)
        Me.cmb_fam_estado_civil.TabIndex = 68
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(262, 538)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 76
        Me.Label10.Text = "Apellidos"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(271, 516)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 75
        Me.Label11.Text = "Documento"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(401, 497)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 74
        Me.Label12.Text = "Número"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(336, 497)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 13)
        Me.Label13.TabIndex = 73
        Me.Label13.Text = "Tipo"
        '
        'cmb_fam_tipo_doc
        '
        Me.cmb_fam_tipo_doc.FormattingEnabled = True
        Me.cmb_fam_tipo_doc.Location = New System.Drawing.Point(339, 513)
        Me.cmb_fam_tipo_doc.Name = "cmb_fam_tipo_doc"
        Me.cmb_fam_tipo_doc.Size = New System.Drawing.Size(59, 21)
        Me.cmb_fam_tipo_doc.TabIndex = 64
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 538)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 13)
        Me.Label14.TabIndex = 72
        Me.Label14.Text = "Nombres"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 38)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 13)
        Me.Label15.TabIndex = 71
        Me.Label15.Text = "Nombre"
        '
        'txt_fam_apellidos
        '
        Me.txt_fam_apellidos.Location = New System.Drawing.Point(265, 554)
        Me.txt_fam_apellidos.Name = "txt_fam_apellidos"
        Me.txt_fam_apellidos.Size = New System.Drawing.Size(236, 20)
        Me.txt_fam_apellidos.TabIndex = 67
        '
        'lbl_fam_nombre
        '
        Me.lbl_fam_nombre.AutoSize = True
        Me.lbl_fam_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fam_nombre.Location = New System.Drawing.Point(106, 35)
        Me.lbl_fam_nombre.Name = "lbl_fam_nombre"
        Me.lbl_fam_nombre.Size = New System.Drawing.Size(99, 16)
        Me.lbl_fam_nombre.TabIndex = 69
        Me.lbl_fam_nombre.Text = "XX-XXX-XXXX"
        '
        'btn_fam_crear
        '
        Me.btn_fam_crear.Location = New System.Drawing.Point(507, 511)
        Me.btn_fam_crear.Name = "btn_fam_crear"
        Me.btn_fam_crear.Size = New System.Drawing.Size(75, 23)
        Me.btn_fam_crear.TabIndex = 70
        Me.btn_fam_crear.Text = "Crear"
        Me.btn_fam_crear.UseVisualStyleBackColor = True
        '
        'txt_fam_nro_doc
        '
        Me.txt_fam_nro_doc.Location = New System.Drawing.Point(404, 513)
        Me.txt_fam_nro_doc.Name = "txt_fam_nro_doc"
        Me.txt_fam_nro_doc.Size = New System.Drawing.Size(97, 20)
        Me.txt_fam_nro_doc.TabIndex = 65
        '
        'txt_fam_nombres
        '
        Me.txt_fam_nombres.Location = New System.Drawing.Point(12, 554)
        Me.txt_fam_nombres.Name = "txt_fam_nombres"
        Me.txt_fam_nombres.Size = New System.Drawing.Size(236, 20)
        Me.txt_fam_nombres.TabIndex = 66
        '
        'dgv_fam
        '
        Me.dgv_fam.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_fam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_fam.Location = New System.Drawing.Point(3, 136)
        Me.dgv_fam.Name = "dgv_fam"
        Me.dgv_fam.Size = New System.Drawing.Size(995, 358)
        Me.dgv_fam.TabIndex = 48
        '
        'Personas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 747)
        Me.Controls.Add(Me.TC)
        Me.Name = "Personas"
        Me.Text = "Personas"
        Me.TC.ResumeLayout(False)
        Me.tab_beneficiarios.ResumeLayout(False)
        Me.tab_beneficiarios.PerformLayout()
        CType(Me.dvg_ben, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_postulantes.ResumeLayout(False)
        Me.tab_postulantes.PerformLayout()
        CType(Me.dgv_postulantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_familiares.ResumeLayout(False)
        Me.tab_familiares.PerformLayout()
        CType(Me.dgv_fam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TC As TabControl
    Friend WithEvents tab_beneficiarios As TabPage
    Friend WithEvents dvg_ben As DataGridView
    Friend WithEvents tab_postulantes As TabPage
    Friend WithEvents lbl_error As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbTipoDoc As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents btn_crear As Button
    Friend WithEvents txt_dni As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents dgv_postulantes As DataGridView
    Friend WithEvents tab_familiares As TabPage
    Friend WithEvents dgv_fam As DataGridView
    Friend WithEvents btn_fam_baja_grupo As Button
    Friend WithEvents btn_fam_editar As Button
    Friend WithEvents bnt_fam_eliminar As Button
    Friend WithEvents lbl_fam_error As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmb_fam_estado_civil As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cmb_fam_tipo_doc As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_fam_apellidos As TextBox
    Friend WithEvents lbl_fam_nombre As Label
    Friend WithEvents btn_fam_crear As Button
    Friend WithEvents txt_fam_nro_doc As TextBox
    Friend WithEvents txt_fam_nombres As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmb_parentezco As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lbl_fam_documento As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lbl_fam_apellido As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_ben_filtrar As TextBox
    Friend WithEvents btn_convertir As Button
    Friend WithEvents DNI As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Prototipo As DataGridViewTextBoxColumn
    Friend WithEvents Ejecutado As DataGridViewTextBoxColumn
    Friend WithEvents Cetificar As DataGridViewTextBoxColumn
    Friend WithEvents Obra As DataGridViewTextBoxColumn
End Class
