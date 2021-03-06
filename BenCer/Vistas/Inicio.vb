﻿Public Class Inicio

    Private WithEvents postulantes As Postulantes
    Private WithEvents presupuestos As Presupuestos

    Private Sub BeneficiariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeneficiariosToolStripMenuItem.Click
        p_inicio.Controls.Clear()

        Dim beneficiarios As Beneficiarios = New Beneficiarios
        With beneficiarios
            .TopLevel = False
            .Visible = True
            .FormBorderStyle = FormBorderStyle.None
        End With

        p_inicio.Controls.Add(beneficiarios)

    End Sub

    Private Sub PostulantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PostulantesToolStripMenuItem.Click
        p_inicio.Controls.Clear()

        Dim postulantes As Postulantes = New Postulantes

        With postulantes
            .TopLevel = False
            .Visible = True
            .FormBorderStyle = FormBorderStyle.None
        End With

        p_inicio.Controls.Add(postulantes)

    End Sub

    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click
        p_inicio.Controls.Clear()

        Dim obraAlta As ObraAlta = New ObraAlta
        With obraAlta
            .TopLevel = False
            .Visible = True
            .FormBorderStyle = FormBorderStyle.None
        End With

        p_inicio.Controls.Add(obraAlta)
    End Sub

    Private Sub ListadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoToolStripMenuItem.Click
        p_inicio.Controls.Clear()

        Dim obras As Obras = New Obras
        With obras
            .TopLevel = False
            .Visible = True
            .FormBorderStyle = FormBorderStyle.None
        End With

        p_inicio.Controls.Add(obras)
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim resultado As Integer = MessageBox.Show("Esta seguro que desea salir?", "Por favor confirme", MessageBoxButtons.YesNo)

        If resultado = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub PrototiposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrototiposToolStripMenuItem.Click
        p_inicio.Controls.Clear()
        Dim prototipos As Prototipos = New Prototipos
        prototipos = New Prototipos()
        With prototipos
            .TopLevel = False
            .Visible = True
            .FormBorderStyle = FormBorderStyle.None
        End With
        p_inicio.Controls.Add(prototipos)
    End Sub

    Private Sub CertificacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CertificacionesToolStripMenuItem.Click
        p_inicio.Controls.Clear()
        Dim certificaciones As Certificaciones

        certificaciones = New Certificaciones(0)

        With certificaciones
            .TopLevel = False
            .Visible = True
            .FormBorderStyle = FormBorderStyle.None

        End With

        p_inicio.Controls.Add(certificaciones)
    End Sub

    Private Sub BeneficiariosConFinalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeneficiariosConFinalToolStripMenuItem.Click
        p_inicio.Controls.Clear()

        Dim beneficiarios As Beneficiarios = New Beneficiarios(True)
        With beneficiarios
            .TopLevel = False
            .Visible = True
            .FormBorderStyle = FormBorderStyle.None
        End With

        p_inicio.Controls.Add(beneficiarios)
    End Sub

    Private Sub ListarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ListarToolStripMenuItem1.Click
        p_inicio.Controls.Clear()

        Dim constructores As Constructores = New Constructores
        With constructores
            .TopLevel = False
            .Visible = True
            .FormBorderStyle = FormBorderStyle.None
        End With

        p_inicio.Controls.Add(constructores)
    End Sub

    Private Sub ListarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarToolStripMenuItem.Click
        p_inicio.Controls.Clear()

        Dim programas As Programas = New Programas
        With programas
            .TopLevel = False
            .Visible = True
            .FormBorderStyle = FormBorderStyle.None
        End With

        p_inicio.Controls.Add(programas)
    End Sub

    Private Sub ListarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ListarToolStripMenuItem2.Click
        p_inicio.Controls.Clear()

        Dim pagos As Pagos = New Pagos
        With pagos
            .TopLevel = False
            .Visible = True
            .FormBorderStyle = FormBorderStyle.None
        End With

        p_inicio.Controls.Add(pagos)
    End Sub

    Private Sub ListarPorProgramaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarPorProgramaToolStripMenuItem.Click
        p_inicio.Controls.Clear()

        Dim prg_det As ProgramasDetalle = New ProgramasDetalle
        With prg_det
            .TopLevel = False
            .Visible = True
            .FormBorderStyle = FormBorderStyle.None
        End With

        p_inicio.Controls.Add(prg_det)
    End Sub
End Class
