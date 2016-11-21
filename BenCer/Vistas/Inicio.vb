Public Class Inicio

    Private WithEvents personas As Personas
    Private WithEvents presupuestos As Presupuestos

    Private Sub CargarCuadroAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarCuadroAToolStripMenuItem.Click

        p_inicio.Controls.Clear()

        presupuestos = New Presupuestos()
        presupuestos.TopLevel = False
        presupuestos.Visible = True
        presupuestos.FormBorderStyle = FormBorderStyle.None

        p_inicio.Controls.Add(presupuestos)

    End Sub

    Private Sub BeneficiariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeneficiariosToolStripMenuItem.Click
        p_inicio.Controls.Clear()

        Dim personas As Personas = New Personas(0)
        personas.TopLevel = False
        personas.Visible = True
        personas.FormBorderStyle = FormBorderStyle.None
        p_inicio.Controls.Add(personas)


    End Sub

    Private Sub PostulantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PostulantesToolStripMenuItem.Click
        p_inicio.Controls.Clear()

        Dim personas As Personas = New Personas(1)
        personas.TopLevel = False
        personas.Visible = True
        personas.FormBorderStyle = FormBorderStyle.None
        p_inicio.Controls.Add(personas)

    End Sub

    Private Sub ConstructoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConstructoresToolStripMenuItem.Click
        p_inicio.Controls.Clear()

        Dim constructores As Constructores = New Constructores
        With constructores
            .TopLevel = False
            .Visible = True
            .FormBorderStyle = FormBorderStyle.None
        End With

        p_inicio.Controls.Add(constructores)
    End Sub

    Private Sub ProyectosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProyectosToolStripMenuItem.Click
        p_inicio.Controls.Clear()

        Dim programas As Programas = New Programas
        With programas
            .TopLevel = False
            .Visible = True
            .FormBorderStyle = FormBorderStyle.None
        End With

        p_inicio.Controls.Add(programas)
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
        With Obras
            .TopLevel = False
            .Visible = True
            .FormBorderStyle = FormBorderStyle.None
        End With

        p_inicio.Controls.Add(obras)
    End Sub
End Class
