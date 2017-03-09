Public Class TaulaMulti
    'Al carregar el load  apliquem totes les mesures que volem aixi utilitzem la base del pare per donar
    'valora tot 
    Private Sub TaulaMulti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Taula multiplicar n"
        lblOperacio.Text = "Taula multiplicar n"
        lblExplicacio.Text = "Mostra la tabla de multiplicar del 1 al numero indicat"
        reinicarBoxes()
        MyBase.contador = 0
    End Sub

    'metode que te el pare al que fem override per implementar els calculs que volem fer servir en el fill
    Protected Overrides Sub calculaOperacio()
        Dim i, numero As Integer
        Dim resultat As Integer

        Try
            numero = tbConverisoNumero.Text
            listBoxTaula.Items.Clear()
            If numero > -1 Then
                For i = 0 To numero
                    resultat = i * numero

                    listBoxTaula.Items.Add(CStr(i) + " * " + CStr(numero) + " = " + CStr(resultat))
                Next
            Else
                numero = numero * (-1)
                For i = 0 To numero
                    resultat = i * numero

                    listBoxTaula.Items.Add(CStr(i) + " * -" + CStr(numero) + " = -" + CStr(resultat))
                Next
            End If
        Catch ex As Exception
            MsgBox("No has introduit un numero al espai corresponen per fel la taula")
        End Try
    End Sub

    'metode que te el pare vuid el farem servir per reinicar els boxes als fills
    Protected Overrides Sub reinicarBoxes()
        tbConverisoNumero.Text = ""
    End Sub
End Class
