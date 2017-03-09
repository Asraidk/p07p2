Public Class NumToLletra
    'Al carregar el load  apliquem totes les mesures que volem aixi utilitzem la base del pare per donar
    'valora tot 
    Private Sub NumToLletra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Dir numero a lletres"
        lblOperacio.Text = "Dir numero a lletres"
        lblExplicacio.Text = "Digues el numero que vols pasar de codi numeric a lletres:" & vbCrLf & "No pot ser me gran que 999999999"
        reinicarBoxes()
        MyBase.contador = 0
    End Sub

    'metode que te el pare al que fem override per implementar els calculs que volem fer servir en el fill
    Protected Overrides Sub calculaOperacio()
        Try
            If tbConverisoNumero.Text < 0 Or tbConverisoNumero.Text > 999999999 Then
                MsgBox("El numero no esta al rang adequat")
            Else
                MsgBox(Num2Text(tbConverisoNumero.Text))
            End If
        Catch ex As Exception
            MsgBox("No has introduit un numero enter")
        End Try
    End Sub
    'metode extret y modificat de internet
    Public Function Num2Text(ByVal value As Double) As String
        Select Case value
            Case 0 : Num2Text = "Zero"
            Case 1 : Num2Text = "Un"
            Case 2 : Num2Text = "Dos"
            Case 3 : Num2Text = "Tres"
            Case 4 : Num2Text = "Quatre"
            Case 5 : Num2Text = "Cinc"
            Case 6 : Num2Text = "Sis"
            Case 7 : Num2Text = "Set"
            Case 8 : Num2Text = "Vuit"
            Case 9 : Num2Text = "Nou"
            Case 10 : Num2Text = "Deu"
            Case 11 : Num2Text = "Once"
            Case 12 : Num2Text = "Doce"
            Case 13 : Num2Text = "Trece"
            Case 14 : Num2Text = "Catorze"
            Case 15 : Num2Text = "Quince"
            Case 16 : Num2Text = "Setce"
            Case Is < 20 : Num2Text = "Di" & Num2Text(value - 10)
            Case 20 : Num2Text = "Vint"
            Case Is < 30 : Num2Text = "VEINTI" & Num2Text(value - 20)
            Case 30 : Num2Text = "Trenta"
            Case 40 : Num2Text = "Quaranta"
            Case 50 : Num2Text = "Cincuanta"
            Case 60 : Num2Text = "Seixanta"
            Case 70 : Num2Text = "Setanta"
            Case 80 : Num2Text = "Vuitanta"
            Case 90 : Num2Text = "Noranta"
            Case Is < 100 : Num2Text = Num2Text(Int(value \ 10) * 10) & "-" & Num2Text(value Mod 10)
            Case 100 : Num2Text = "Cent"
            Case Is < 200 : Num2Text = "Cent " & Num2Text(value - 100)
            Case 200, 300, 400, 500, 600, 700, 800, 900 : Num2Text = Num2Text(Int(value \ 100)) & "cents"
            Case Is < 1000 : Num2Text = Num2Text(Int(value \ 100) * 100) & " " & Num2Text(value Mod 100)
            Case 1000 : Num2Text = "Mil"
            Case Is < 2000 : Num2Text = "mil " & Num2Text(value Mod 1000)
            Case Is < 1000000 : Num2Text = Num2Text(Int(value \ 1000)) & " mil"
                If value Mod 1000 Then Num2Text = Num2Text & " " & Num2Text(value Mod 1000)
            Case 1000000 : Num2Text = "Un millo"
            Case Is < 2000000 : Num2Text = "Un millo " & Num2Text(value Mod 1000000)
            Case Is < 1000000000000.0# : Num2Text = Num2Text(Int(value / 1000000)) & " Millons "
                If (value - Int(value / 1000000) * 1000000) Then Num2Text = Num2Text & " " & Num2Text(value - Int(value / 1000000) * 1000000)
        End Select
    End Function
    'metode que te el pare vuid el farem servir per reinicar els boxes als fills
    Protected Overrides Sub reinicarBoxes()
        tbConverisoNumero.Text = ""
    End Sub
End Class
