Public Class Rodona
    'Al carregar el load  apliquem totes les mesures que volem aixi utilitzem la base del pare per donar
    'valora tot 
    Private Sub Rodona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Areea de la rodona"
        lblOperacio.Text = "Areea de la rodona"
        lblExplicacio.Text = "Per calcula l'area de la rodona: " & vbCrLf & "pi*radi*radi ,introduieix en els camps" & vbCrLf & "en blanc el que es demana"
        lbl1.Text = "Radi"
        reinicarBoxes()
        MyBase.contador = 0
    End Sub

    'metode que te el pare al que fem override per implementar els calculs que volem fer servir en el fill
    Protected Overrides Sub calculaOperacio()
        Dim radi, resultat As Double
        Try
            radi = tb1.Text
            resultat = Format(Math.PI * radi * radi, "0.00")
            MsgBox("L'area de la rodona es[" & resultat & "]")
        Catch ex As Exception
            MsgBox("No pots introduir valors que no siguin numerics per fer calculs matematics")
        End Try
    End Sub
    'metode que te el pare vuid el farem servir per reinicar els boxes als fills
    Protected Overrides Sub reinicarBoxes()
        tb1.Text = 0
    End Sub

End Class
