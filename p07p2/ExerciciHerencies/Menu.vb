Public Class Menu
    'perque aparegui tal com volem al iniciar el form
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        treeMates.ExpandAll()
    End Sub
    'menu del tree, tindrem el activament dels panels al fer els click en els diferents menus
    Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles treeMates.NodeMouseClick
        Select Case e.Node.Tag
            Case 1
                Triangle.ShowDialog()
            Case 2
                Rodona.ShowDialog()
            Case 3
                Circumferencia.ShowDialog()
            Case 4
                Rectangle.ShowDialog()
            Case 5
                Suma.ShowDialog()
            Case 6
                Resta.ShowDialog()
            Case 7
                Divisio.ShowDialog()
            Case 8
                Multiplicacio.ShowDialog()
            Case 9
                InvertirCadena.ShowDialog()
            Case 10
                ContaLletres.ShowDialog()
            Case 11
                RepeticioCaracter.ShowDialog()
            Case 12
                NumToLletra.ShowDialog()
            Case 13
                Fibonacci.ShowDialog()
            Case 14
                TaulaMulti.ShowDialog()
        End Select
    End Sub

End Class