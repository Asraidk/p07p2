<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Triangle
    Inherits p07p2.Areea

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
        Me.tb2 = New System.Windows.Forms.TextBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tb2)
        Me.GroupBox1.Controls.Add(Me.lbl2)
        Me.GroupBox1.Controls.SetChildIndex(Me.lbl2, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.tb2, 0)
        '
        'tb2
        '
        Me.tb2.Location = New System.Drawing.Point(103, 144)
        Me.tb2.Name = "tb2"
        Me.tb2.Size = New System.Drawing.Size(100, 20)
        Me.tb2.TabIndex = 11
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(27, 144)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(35, 13)
        Me.lbl2.TabIndex = 10
        Me.lbl2.Text = "Num2"
        '
        'Triangle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(633, 319)
        Me.Name = "Triangle"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb2 As System.Windows.Forms.TextBox
    Friend WithEvents lbl2 As System.Windows.Forms.Label

End Class
