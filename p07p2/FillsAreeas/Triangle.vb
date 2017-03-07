Public Class Triangle

    Private Sub Triangle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Tote el que volem mostrar als labels
        Me.Text = "Areea del triangle"
        lblOperacio.Text = "Areea del triangle"
        lblExplicacio.Text = "Per calcula l'area de el triangle es:" & vbCrLf & "(base * alçada)/2, introduieix en els camps" & vbCrLf & "en blanc el que es demana"
        lbl1.Text = "Base"
        lbl2.Text = "Alçada"
        reinicarBoxes()
        MyBase.contador = 0
    End Sub
    'metode que te el pare al que fem override per implementar la forma del fer el calcul del triangle
    Protected Overrides Sub calculaOperacio()
        Dim resultat, altura, base As Double
        Try
            altura = tb1.Text
            base = tb2.Text
            resultat = Format((altura * base) / 2, "0.00")
            MsgBox("L'area del triangle es[" & resultat & "]")
        Catch ex As Exception
            MsgBox("No pots introduir valors que no siguin numerics per fer calculs matematics")
        End Try
    End Sub
    'metode que te el pare vuid el farem servir per reinicar els boxes als fills
    Protected Overrides Sub reinicarBoxes()
        tb1.Text = 0
        tb2.Text = 0
    End Sub
End Class
