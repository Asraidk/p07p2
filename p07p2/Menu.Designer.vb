<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Àrea del triangle")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Àrea de la rodona")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Longitud de la Circumferència")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Àrea Rectangle")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Àrees i Longituds", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Suma de dos números")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Resta de dos números")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Divisió de dos números")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Multiplicació de dos números")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Aritmètica ", New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7, TreeNode8, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Invertir cadena")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mostra quantitat consonant i vocals d'una cadena")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Busqueda de 2 caractes seguit a una frase")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cadenes", New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode12, TreeNode13})
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Transformar un numero enter, a lletres ")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fibornacci de n números")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Taula multiplica de 1 a n")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Altres ", New System.Windows.Forms.TreeNode() {TreeNode15, TreeNode16, TreeNode17})
        Me.treeMates = New System.Windows.Forms.TreeView()
        Me.SuspendLayout()
        '
        'treeMates
        '
        Me.treeMates.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeMates.Location = New System.Drawing.Point(0, 0)
        Me.treeMates.Name = "treeMates"
        TreeNode1.Name = "Nodo1"
        TreeNode1.Tag = "1"
        TreeNode1.Text = "Àrea del triangle"
        TreeNode2.Name = "Nodo2"
        TreeNode2.Tag = "2"
        TreeNode2.Text = "Àrea de la rodona"
        TreeNode3.Name = "Nodo3"
        TreeNode3.Tag = "3"
        TreeNode3.Text = "Longitud de la Circumferència"
        TreeNode4.Name = "Nodo4"
        TreeNode4.Tag = "4"
        TreeNode4.Text = "Àrea Rectangle"
        TreeNode5.Name = "Nodo0"
        TreeNode5.Text = "Àrees i Longituds"
        TreeNode6.Name = "Nodo6"
        TreeNode6.Tag = "5"
        TreeNode6.Text = "Suma de dos números"
        TreeNode7.Name = "Nodo7"
        TreeNode7.Tag = "6"
        TreeNode7.Text = "Resta de dos números"
        TreeNode8.Name = "Nodo8"
        TreeNode8.Tag = "7"
        TreeNode8.Text = "Divisió de dos números"
        TreeNode9.Name = "Nodo9"
        TreeNode9.Tag = "8"
        TreeNode9.Text = "Multiplicació de dos números"
        TreeNode10.Name = "Nodo5"
        TreeNode10.Text = "Aritmètica "
        TreeNode11.Name = "Nodo11"
        TreeNode11.Tag = "9"
        TreeNode11.Text = "Invertir cadena"
        TreeNode12.Name = "Nodo12"
        TreeNode12.Tag = "10"
        TreeNode12.Text = "Mostra quantitat consonant i vocals d'una cadena"
        TreeNode13.Name = "Nodo13"
        TreeNode13.Tag = "11"
        TreeNode13.Text = "Busqueda de 2 caractes seguit a una frase"
        TreeNode14.Name = "Nodo10"
        TreeNode14.Text = "Cadenes"
        TreeNode15.Name = "Nodo15"
        TreeNode15.Tag = "12"
        TreeNode15.Text = "Transformar un numero enter, a lletres "
        TreeNode16.Name = "Nodo16"
        TreeNode16.Tag = "13"
        TreeNode16.Text = "Fibornacci de n números"
        TreeNode17.Name = "Nodo17"
        TreeNode17.Tag = "14"
        TreeNode17.Text = "Taula multiplica de 1 a n"
        TreeNode18.Name = "Nodo14"
        TreeNode18.Text = "Altres "
        Me.treeMates.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode10, TreeNode14, TreeNode18})
        Me.treeMates.Size = New System.Drawing.Size(361, 329)
        Me.treeMates.TabIndex = 1
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 329)
        Me.Controls.Add(Me.treeMates)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents treeMates As System.Windows.Forms.TreeView
End Class
