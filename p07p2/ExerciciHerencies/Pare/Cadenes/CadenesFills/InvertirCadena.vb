Public Class InvertirCadena
    'Al carregar el load  apliquem totes les mesures que volem aixi utilitzem la base del pare per donar
    'valora tot 
    Private Sub InvertirCadena_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Invertir cadenas"
        lblOperacio.Text = "Invertir cadenas"
        lblExplicacio.Text = "Introduix la cadena de caracters," & vbCrLf & "que vols que aparegui invertida" & vbCrLf & "en el camp en blanc: " & vbCrLf & "el resultat apareix al mateix camp en blanc"
        reinicarBoxes()
        MyBase.contador = 0
    End Sub

    'metode que te el pare al que fem override per implementar els calculs que volem fer servir en el fill
    Protected Overrides Sub calculaOperacio()
        Dim arrayCadena As String
        Dim arryCadenaInvertida As String = ""
        'Metode fet per mi per invertir una cadena de caracters
        Try
            arrayCadena = tbCadena.Text
            For i = arrayCadena.Length - 1 To 0 Step -1
                arryCadenaInvertida = arryCadenaInvertida + arrayCadena(i)
            Next
            tbCadena.Text = arryCadenaInvertida
        Catch ex As Exception
            MsgBox("Error en fer l'inversa de la cadena", MsgBoxStyle.Information)
        End Try
    End Sub
    'metode que te el pare vuid el farem servir per reinicar els boxes als fills
    Protected Overrides Sub reinicarBoxes()
        tbCadena.Text = ""
    End Sub
End Class
