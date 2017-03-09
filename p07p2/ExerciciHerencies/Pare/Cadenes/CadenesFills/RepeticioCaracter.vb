Public Class RepeticioCaracter
    'Al carregar el load  apliquem totes les mesures que volem aixi utilitzem la base del pare per donar
    'valora tot 
    Private Sub RepeticioCaracter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Contar conjunt de caracters"
        lblOperacio.Text = "Contar conjunt de caracters"
        lblExplicacio.Text = "Introduix la cadena de caracters," & vbCrLf & "que vols fer el recomte del conjunt" & vbCrLf & "de els dos caracters en el camp en blanc:"
        reinicarBoxes()
        MyBase.contador = 0
    End Sub

    'metode que te el pare al que fem override per implementar els calculs que volem fer servir en el fill
    Protected Overrides Sub calculaOperacio()
        Dim parellaCaracters, cadenaText As String
        Dim i As Integer
        Dim contadorParelles As Integer = 0
        Dim bandera = True
        parellaCaracters = tbDosCaracters.Text
        cadenaText = tbCadena.Text

        If controlCaracter(bandera) = True Then
            For i = 0 To cadenaText.Length - 2 Step +1
                If parellaCaracters = cadenaText(i) & cadenaText(i + 1) Then
                    contadorParelles = contadorParelles + 1
                End If
            Next
            MsgBox("La parella de caracters <" & CStr(parellaCaracters) & "> esta [" & CStr(contadorParelles) & "] cops al escrit")
        End If
    End Sub
    'metode per comprovar si de veritat el text box es una parella de caracters 
    Function controlCaracter(bandera)

        If tbDosCaracters.TextLength > 2 Then
            tbDosCaracters.Text = tbDosCaracters.Text.Remove(tbDosCaracters.TextLength - 1)
        Else
            If tbDosCaracters.TextLength < 2 Then
                MsgBox("Faltan caracters per introduir en la parella")
                bandera = False
            End If
        End If
        Return bandera
    End Function
    'metode que te el pare vuid el farem servir per reinicar els boxes als fills
    Protected Overrides Sub reinicarBoxes()
        tbCadena.Text = ""
        tbDosCaracters.Text = ""
    End Sub
End Class
