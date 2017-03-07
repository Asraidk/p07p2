Public Class Menu

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        treeMates.ExpandAll()
    End Sub
    'menu del tree, tindrem el activament dels panels al fer els click en els diferents menus
    Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles treeMates.NodeMouseClick
        Select Case e.Node.Tag
            Case 1
                Triangle.ShowDialog()
            Case 2
            Case 3
            Case 4
            Case 5
            Case 6
            Case 7
            Case 8
            Case 9
            Case 10
            Case 11
            Case 12
            Case 13
            Case 14


        End Select
    End Sub
End Class