Public Class Beneficiarios

    Private WithEvents controlador As ControladorBeneficiarios


    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        controlador = New ControladorBeneficiarios
        dvg_ben.AutoGenerateColumns = False


        dvg_ben.DataSource = controlador.listaBEneficiarios


        Dim btn_cert As New DataGridViewButtonColumn()
        dvg_ben.Columns.Add(btn_cert)
        btn_cert.HeaderText = "Certificar"
        btn_cert.Text = "Certificar"
        btn_cert.Name = "btn"
        btn_cert.Width = 100
        btn_cert.UseColumnTextForButtonValue = True

        Dim btn_obra As New DataGridViewButtonColumn()
        dvg_ben.Columns.Add(btn_obra)
        btn_obra.HeaderText = "Obra"
        btn_obra.Text = "Ver Obra"
        btn_obra.Name = "btn"
        btn_obra.Width = 100
        btn_obra.UseColumnTextForButtonValue = True


    End Sub




    Private Sub btn_ben_cerrar_Click(sender As Object, e As EventArgs) Handles btn_ben_cerrar.Click
        Dim resultado As Integer = MessageBox.Show("Esta seguro que desea cerrar el modulo?", "Por favor confirme", MessageBoxButtons.YesNo)
        If resultado = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub txt_ben_filtrar_TextChanged(sender As Object, e As EventArgs) Handles txt_ben_filtrar.TextChanged
        dvg_ben.DataSource = controlador.Filtrar(txt_ben_filtrar.Text.ToLower)
    End Sub
End Class