<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fibonacci
    Inherits p07p2.Altres

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.listBoxTaula = New System.Windows.Forms.ListBox()
        Me.GroupBox15.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.listBoxTaula)
        Me.GroupBox15.Location = New System.Drawing.Point(31, 155)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(313, 162)
        Me.GroupBox15.TabIndex = 16
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Resultat"
        '
        'listBoxTaula
        '
        Me.listBoxTaula.FormattingEnabled = True
        Me.listBoxTaula.Location = New System.Drawing.Point(14, 23)
        Me.listBoxTaula.Name = "listBoxTaula"
        Me.listBoxTaula.Size = New System.Drawing.Size(275, 134)
        Me.listBoxTaula.TabIndex = 0
        '
        'Fibonacci
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(633, 323)
        Me.Controls.Add(Me.GroupBox15)
        Me.Name = "Fibonacci"
        Me.Controls.SetChildIndex(Me.GroupBox15, 0)
        Me.GroupBox15.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents listBoxTaula As System.Windows.Forms.ListBox

End Class
