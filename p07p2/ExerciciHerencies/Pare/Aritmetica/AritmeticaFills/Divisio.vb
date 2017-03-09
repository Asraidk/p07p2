Public Class Divisio
    'Al carregar el load  apliquem totes les mesures que volem aixi utilitzem la base del pare per donar
    'valora tot 
    Private Sub Divisio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Divisio"
        lblOperacio.Text = "Divisio"
        lblExplicacio.Text = "Per fer la divisio desitjada, " & vbCrLf & "introdueix un numero a cada" & vbCrLf & "camp en blanc:"
        lbl1.Text = "Numero1"
        lbl2.Text = "Numero2"
        reinicarBoxes()
        MyBase.contador = 0
    End Sub

    'metode que te el pare al que fem override per implementar els calculs que volem fer servir en el fill
    Protected Overrides Sub calculaOperacio()
        Dim resultat, numero1, numero2 As Double
        Try
            numero1 = tb1.Text
            numero2 = tb2.Text
            resultat = Format(numero1 / numero2, "0.00")
            MsgBox("La divisio dels dos numeros es [" & resultat & "]")
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
