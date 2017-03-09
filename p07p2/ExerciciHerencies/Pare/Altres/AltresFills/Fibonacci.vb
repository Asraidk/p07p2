Public Class Fibonacci
    'Al carregar el load  apliquem totes les mesures que volem aixi utilitzem la base del pare per donar
    'valora tot 
    Private Sub Fibonacci_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Fibonacci"
        lblOperacio.Text = "Fibonacci"
        lblExplicacio.Text = "Digues cuants numeros de la serie de Fibornacci vols que es mostrin " & vbCrLf & "en la llistaRecorda sempre començara per 1 a n"
        reinicarBoxes()
        MyBase.contador = 0
    End Sub

    'metode que te el pare al que fem override per implementar els calculs que volem fer servir en el fill
    Protected Overrides Sub calculaOperacio()
        Dim a, seguentNumero, i, n As Integer
        Dim b As Integer = 1

        Try
            n = tbConverisoNumero.Text
            If n > -1 Then
                listBoxTaula.Items.Clear()
                listBoxTaula.Items.Add(1)
                For i = 0 To n - 1
                    seguentNumero = a + b
                    a = b
                    b = seguentNumero
                    listBoxTaula.Items.Add(seguentNumero)
                Next
            Else
                MsgBox("No pots introduir numeros mes petits que 0")
            End If

        Catch ex As Exception
            MsgBox("Per calcula la serie necesitem un numero")

        End Try
    End Sub

    'metode que te el pare vuid el farem servir per reinicar els boxes als fills
    Protected Overrides Sub reinicarBoxes()
        tbConverisoNumero.Text = ""
    End Sub
End Class
