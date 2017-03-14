<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModoPago
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_mopa_forma_pago = New System.Windows.Forms.ComboBox()
        Me.lbl_mopa_descripcion_numero = New System.Windows.Forms.Label()
        Me.txt_mopa_numero = New System.Windows.Forms.TextBox()
        Me.btn_mopa_confirma = New System.Windows.Forms.Button()
        Me.btn_mopa_cancela = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione la forma de pago"
        '
        'cmb_mopa_forma_pago
        '
        Me.cmb_mopa_forma_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_mopa_forma_pago.FormattingEnabled = True
        Me.cmb_mopa_forma_pago.Location = New System.Drawing.Point(160, 6)
        Me.cmb_mopa_forma_pago.Name = "cmb_mopa_forma_pago"
        Me.cmb_mopa_forma_pago.Size = New System.Drawing.Size(362, 21)
        Me.cmb_mopa_forma_pago.TabIndex = 1
        '
        'lbl_mopa_descripcion_numero
        '
        Me.lbl_mopa_descripcion_numero.AutoSize = True
        Me.lbl_mopa_descripcion_numero.Location = New System.Drawing.Point(12, 46)
        Me.lbl_mopa_descripcion_numero.Name = "lbl_mopa_descripcion_numero"
        Me.lbl_mopa_descripcion_numero.Size = New System.Drawing.Size(142, 13)
        Me.lbl_mopa_descripcion_numero.TabIndex = 2
        Me.lbl_mopa_descripcion_numero.Text = "Seleccione la forma de pago"
        '
        'txt_mopa_numero
        '
        Me.txt_mopa_numero.Location = New System.Drawing.Point(160, 43)
        Me.txt_mopa_numero.Name = "txt_mopa_numero"
        Me.txt_mopa_numero.Size = New System.Drawing.Size(362, 20)
        Me.txt_mopa_numero.TabIndex = 3
        Me.txt_mopa_numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_mopa_confirma
        '
        Me.btn_mopa_confirma.Location = New System.Drawing.Point(447, 93)
        Me.btn_mopa_confirma.Name = "btn_mopa_confirma"
        Me.btn_mopa_confirma.Size = New System.Drawing.Size(75, 23)
        Me.btn_mopa_confirma.TabIndex = 4
        Me.btn_mopa_confirma.Text = "Button1"
        Me.btn_mopa_confirma.UseVisualStyleBackColor = True
        '
        'btn_mopa_cancela
        '
        Me.btn_mopa_cancela.Location = New System.Drawing.Point(366, 93)
        Me.btn_mopa_cancela.Name = "btn_mopa_cancela"
        Me.btn_mopa_cancela.Size = New System.Drawing.Size(75, 23)
        Me.btn_mopa_cancela.TabIndex = 5
        Me.btn_mopa_cancela.Text = "Button2"
        Me.btn_mopa_cancela.UseVisualStyleBackColor = True
        '
        'ModoPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 128)
        Me.Controls.Add(Me.btn_mopa_cancela)
        Me.Controls.Add(Me.btn_mopa_confirma)
        Me.Controls.Add(Me.txt_mopa_numero)
        Me.Controls.Add(Me.lbl_mopa_descripcion_numero)
        Me.Controls.Add(Me.cmb_mopa_forma_pago)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ModoPago"
        Me.Text = "ModoPago"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_mopa_forma_pago As ComboBox
    Friend WithEvents lbl_mopa_descripcion_numero As Label
    Friend WithEvents txt_mopa_numero As TextBox
    Friend WithEvents btn_mopa_confirma As Button
    Friend WithEvents btn_mopa_cancela As Button
End Class
