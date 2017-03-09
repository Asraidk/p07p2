Public Class Rectangle
    'Al carregar el load  apliquem totes les mesures que volem aixi utilitzem la base del pare per donar
    'valora tot 
    Private Sub Rectangle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Tote el que volem mostrar als labels
        Me.Text = "Area del rectangle"
        lblOperacio.Text = "Area del rectangle"
        lblExplicacio.Text = "Per calcula l'area del rectangle: " & vbCrLf & "(base * alçada), introduieix en els camps" & vbCrLf & "en blanc el que es demana"
        lbl1.Text = "Base"
        lbl2.Text = "Alçada"
        reinicarBoxes()
        MyBase.contador = 0
    End Sub
    'metode que te el pare al que fem override per implementar els calculs que volem fer servir en el fill
    Protected Overrides Sub calculaOperacio()
        Dim resultat, altura, base As Double
        Try
            altura = tb1.Text
            base = tb2.Text
            resultat = altura * base
            MsgBox("L'area del rectangle es[" & resultat & "]")
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
