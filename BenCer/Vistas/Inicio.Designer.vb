<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.IndividuosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeneficiariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PostulantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProyectosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PresupuestosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrototiposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConstructoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ObrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CertificacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.p_inicio = New System.Windows.Forms.Panel()
        Me.PagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IndividuosToolStripMenuItem, Me.ProyectosToolStripMenuItem, Me.PresupuestosToolStripMenuItem, Me.ConstructoresToolStripMenuItem, Me.ObrasToolStripMenuItem, Me.SalirToolStripMenuItem, Me.PagosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(636, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'IndividuosToolStripMenuItem
        '
        Me.IndividuosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeneficiariosToolStripMenuItem, Me.PostulantesToolStripMenuItem})
        Me.IndividuosToolStripMenuItem.Name = "IndividuosToolStripMenuItem"
        Me.IndividuosToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.IndividuosToolStripMenuItem.Text = "Individuos"
        '
        'BeneficiariosToolStripMenuItem
        '
        Me.BeneficiariosToolStripMenuItem.Name = "BeneficiariosToolStripMenuItem"
        Me.BeneficiariosToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.BeneficiariosToolStripMenuItem.Text = "Beneficiarios"
        '
        'PostulantesToolStripMenuItem
        '
        Me.PostulantesToolStripMenuItem.Name = "PostulantesToolStripMenuItem"
        Me.PostulantesToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.PostulantesToolStripMenuItem.Text = "Postulantes"
        '
        'ProyectosToolStripMenuItem
        '
        Me.ProyectosToolStripMenuItem.Name = "ProyectosToolStripMenuItem"
        Me.ProyectosToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.ProyectosToolStripMenuItem.Text = "Programas"
        '
        'PresupuestosToolStripMenuItem
        '
        Me.PresupuestosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrototiposToolStripMenuItem})
        Me.PresupuestosToolStripMenuItem.Name = "PresupuestosToolStripMenuItem"
        Me.PresupuestosToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.PresupuestosToolStripMenuItem.Text = "Presupuestos"
        '
        'PrototiposToolStripMenuItem
        '
        Me.PrototiposToolStripMenuItem.Name = "PrototiposToolStripMenuItem"
        Me.PrototiposToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.PrototiposToolStripMenuItem.Text = "Prototipos"
        '
        'ConstructoresToolStripMenuItem
        '
        Me.ConstructoresToolStripMenuItem.Name = "ConstructoresToolStripMenuItem"
        Me.ConstructoresToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.ConstructoresToolStripMenuItem.Text = "Constructores"
        '
        'ObrasToolStripMenuItem
        '
        Me.ObrasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadoToolStripMenuItem, Me.AltaToolStripMenuItem, Me.CertificacionesToolStripMenuItem})
        Me.ObrasToolStripMenuItem.Name = "ObrasToolStripMenuItem"
        Me.ObrasToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.ObrasToolStripMenuItem.Text = "Obras"
        '
        'ListadoToolStripMenuItem
        '
        Me.ListadoToolStripMenuItem.Name = "ListadoToolStripMenuItem"
        Me.ListadoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ListadoToolStripMenuItem.Text = "Listado"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AltaToolStripMenuItem.Text = "Alta"
        '
        'CertificacionesToolStripMenuItem
        '
        Me.CertificacionesToolStripMenuItem.Name = "CertificacionesToolStripMenuItem"
        Me.CertificacionesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CertificacionesToolStripMenuItem.Text = "Certificaciones"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 24)
        Me.PictureBox1.MaximumSize = New System.Drawing.Size(636, 340)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(636, 340)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'p_inicio
        '
        Me.p_inicio.BackColor = System.Drawing.Color.Transparent
        Me.p_inicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.p_inicio.Location = New System.Drawing.Point(0, 24)
        Me.p_inicio.Name = "p_inicio"
        Me.p_inicio.Size = New System.Drawing.Size(636, 340)
        Me.p_inicio.TabIndex = 2
        '
        'PagosToolStripMenuItem
        '
        Me.PagosToolStripMenuItem.Name = "PagosToolStripMenuItem"
        Me.PagosToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.PagosToolStripMenuItem.Text = "Pagos"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 364)
        Me.Controls.Add(Me.p_inicio)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Inicio"
        Me.Text = "BenCer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents IndividuosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProyectosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PresupuestosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConstructoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BeneficiariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PostulantesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ObrasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents p_inicio As Panel
    Friend WithEvents ListadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrototiposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CertificacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagosToolStripMenuItem As ToolStripMenuItem
End Class
