Public Class ContaLletres
    'Al carregar el load  apliquem totes les mesures que volem aixi utilitzem la base del pare per donar
    'valora tot 
    Private Sub ContaLletres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Contar vocals i consonants"
        lblOperacio.Text = "Contar vocals i consonants"
        lblExplicacio.Text = "Introduix la cadena de caracters," & vbCrLf & "que vols contar els caracters" & vbCrLf & "en el camp en blanc: "
        reinicarBoxes()
        MyBase.contador = 0
    End Sub

    'metode que te el pare al que fem override per implementar els calculs que volem fer servir en el fill
    Protected Overrides Sub calculaOperacio()
        Dim cadenaText As String
        Dim auxiliar As String
        Dim nVocals As Integer = 0
        Dim nConsonants As Integer = 0
        Dim nEspais As Integer = 0

        cadenaText = tbCadena.Text
        For i = 0 To cadenaText.Length - 1 Step +1
            auxiliar = LCase(cadenaText(i))
            Select Case auxiliar
                Case "a", "e", "i", "o", "u"
                    nVocals = nVocals + 1
                Case " "
                    nEspais = nEspais + 1
                Case Else
                    nConsonants = nConsonants + 1
            End Select
        Next
        MsgBox("El numero de vocals es [" + CStr(nVocals) + "] i el de consonants [" + CStr(nConsonants) + "]")
    End Sub
    'metode que te el pare vuid el farem servir per reinicar els boxes als fills
    Protected Overrides Sub reinicarBoxes()
        tbCadena.Text = ""
    End Sub
End Class
