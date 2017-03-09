Public Class BasePrimaria

    'Contador per veure cuantas operaciosn de calcul em fet
    Protected contador As Integer = 0
    'Event que exerceix el control del temps en el formulari
    Protected Sub Hora_Tick(sender As Object, e As EventArgs) Handles Hora.Tick
        lblHora.Text = Date.Now.ToLongTimeString
    End Sub
    'Event capturat per tal de mostrar un msg al tancar el form
    Protected Sub BasePrimaria_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MsgBox("Has fet servir la operacio [" & contador & "]")
    End Sub
    'Event que tindra que cridar els metodes de calcul y el control del contador del count
    Protected Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        metodeContaOperacio()
        calculaOperacio()
    End Sub
    'metode que fa els calculs l'implementen els fills
    Protected Overridable Sub metodeContaOperacio()
        contador = contador + 1
    End Sub
    'metode que fa els calculs l'implementen els fills
    Protected Overridable Sub calculaOperacio()

    End Sub
    'event click reiniciar
    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        reinicarBoxes()
    End Sub
    'metode del reinici dels boxes l'implementen els fills
    Protected Overridable Sub reinicarBoxes()

    End Sub
    'event per tancar el form que tenim obert
    Private Sub btnTancar_Click(sender As Object, e As EventArgs) Handles btnTancar.Click
        Me.Close()
    End Sub

    
    'Aqui tindrem tots els metodes que conte el menu strip y com funcionen!!!
    'Metodes numerics, cambis en valors, inicia a 0, augmentar en 1 o decrementar
    Private Sub IniciaValorA0ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IniciaValorA0ToolStripMenuItem.Click
        CType(cmsTotFuncional.SourceControl, TextBox).Text = 0
    End Sub

    Private Sub IncrementaEn1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncrementaEn1ToolStripMenuItem.Click
        Try
            CType(cmsTotFuncional.SourceControl, TextBox).Text = CType(cmsTotFuncional.SourceControl, TextBox).Text + 1
        Catch ex As Exception
            MsgBox("Per poder fer funcion en el camp no deixis espai en blanc o una lletra")
        End Try

    End Sub

    Private Sub DecrementaEn1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecrementaEn1ToolStripMenuItem.Click
        Try
            CType(cmsTotFuncional.SourceControl, TextBox).Text = CType(cmsTotFuncional.SourceControl, TextBox).Text - 1
        Catch ex As Exception
            MsgBox("Per poder fer funcion en el camp no deixis espai en blanc o una lletra")
        End Try
    End Sub

    'metodes funcionals , per exerci accions com borra enganxa i copia
    'copiar
    Private Sub CopiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiaToolStripMenuItem.Click
        Dim info As String
        Try
            info = CType(cmsTotFuncional.SourceControl, TextBox).Text
            My.Computer.Clipboard.SetText(info)
        Catch ex As Exception

        End Try

    End Sub
    'tallar
    Private Sub TallarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TallarToolStripMenuItem.Click
        Dim info As String
        Try
            info = CType(cmsTotFuncional.SourceControl, TextBox).Text
            My.Computer.Clipboard.SetText(info)
            CType(cmsTotFuncional.SourceControl, TextBox).Text = ""
        Catch ex As Exception

        End Try
    End Sub
    'enganxa
    Private Sub EnganxarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnganxarToolStripMenuItem.Click
        Dim info As String
        Try
            info = My.Computer.Clipboard.GetText
            CType(cmsTotFuncional.SourceControl, TextBox).Text = info
        Catch ex As Exception
            MsgBox("No tens res en la memoria per enganxa")
        End Try

    End Sub

    'metode que activa totes les opcion del stripmenu
    Public Sub stripMenuActiu()
        IniciaValorA0ToolStripMenuItem.Enabled = True
        IncrementaEn1ToolStripMenuItem.Enabled = True
        DecrementaEn1ToolStripMenuItem.Enabled = True
    End Sub
    'metode que desactivara certes caracteristicas del strip menu que no son necesaries per alguns panels
    Public Sub stripMenuDescativadesOpcionsNumeriques()
        IniciaValorA0ToolStripMenuItem.Enabled = False
        IncrementaEn1ToolStripMenuItem.Enabled = False
        DecrementaEn1ToolStripMenuItem.Enabled = False
    End Sub
End Class
