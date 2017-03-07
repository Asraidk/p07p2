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
End Class
