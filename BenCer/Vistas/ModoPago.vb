Public Class ModoPago

    Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        btn_mopa_confirma.DialogResult = DialogResult.OK
        btn_mopa_confirma.Text = "Confirma"
        btn_mopa_cancela.DialogResult = DialogResult.Cancel
        btn_mopa_cancela.Text = "Cancela"
        Dim daoFormaPago As DaoFormaPago = New DaoFormaPago
        cmb_mopa_forma_pago.DataSource = daoFormaPago.listar()
        cmb_mopa_forma_pago.DisplayMember = "forma_pago"
        cmb_mopa_forma_pago.ValueMember = "cod_forma_pago"
        lbl_mopa_descripcion_numero.Visible = False
        txt_mopa_numero.Visible = False
    End Sub

    Public ReadOnly Property forma_pago As Integer
        Get
            Return cmb_mopa_forma_pago.SelectedValue
        End Get
    End Property

    Public ReadOnly Property num_cta_cheque As String
        Get
            Return txt_mopa_numero.Text
        End Get
    End Property

    Private Sub cmb_mopa_forma_pago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_mopa_forma_pago.SelectionChangeCommitted

        Select Case cmb_mopa_forma_pago.SelectedValue
            Case 0
                lbl_mopa_descripcion_numero.Visible = False
                txt_mopa_numero.Visible = False
            Case 1
                lbl_mopa_descripcion_numero.Text = "Ingrese el número de cuenta :"
                lbl_mopa_descripcion_numero.Visible = True
                txt_mopa_numero.Visible = True
            Case 2
                lbl_mopa_descripcion_numero.Text = "Ingrese el número de cheque :"
                lbl_mopa_descripcion_numero.Visible = True
                txt_mopa_numero.Visible = True
            Case Else
                lbl_mopa_descripcion_numero.Visible = False
                txt_mopa_numero.Visible = False
        End Select

    End Sub

    Private Sub btn_mopa_confirma_Click(sender As Object, e As EventArgs) Handles btn_mopa_confirma.Click
        If cmb_mopa_forma_pago.SelectedValue > 0 Then
            If cmb_mopa_forma_pago.SelectedValue < 3 AndAlso txt_mopa_numero.Text.Length <= 0 Then
                MsgBox("Lo siento, revise los datos y vuelva a intentar")
                Exit Sub
            End If
        Else
            MsgBox("Por favor elija un a forma de pago")
            Exit Sub
        End If
    End Sub
End Class