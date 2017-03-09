<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepeticioCaracter
    Inherits p07p2.Cadenes

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
        Me.tbDosCaracters = New System.Windows.Forms.TextBox()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.GroupBox12.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbDosCaracters
        '
        Me.tbDosCaracters.Location = New System.Drawing.Point(21, 298)
        Me.tbDosCaracters.Name = "tbDosCaracters"
        Me.tbDosCaracters.Size = New System.Drawing.Size(62, 20)
        Me.tbDosCaracters.TabIndex = 16
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.Location = New System.Drawing.Point(19, 279)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(210, 16)
        Me.Label70.TabIndex = 15
        Me.Label70.Text = "Introduix els dos caracters a mirar:"
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.Label71)
        Me.GroupBox12.Location = New System.Drawing.Point(345, 154)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(172, 87)
        Me.GroupBox12.TabIndex = 17
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Notes"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Location = New System.Drawing.Point(12, 17)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(158, 52)
        Me.Label71.TabIndex = 0
        Me.Label71.Text = "Si no introdueixes 2 caracters: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-No s'executara res." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Si introdueix mes de 2:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & _
    "-Nomes s'utilitzaran els 2 primers" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'RepeticioCaracter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(633, 329)
        Me.Controls.Add(Me.GroupBox12)
        Me.Controls.Add(Me.tbDosCaracters)
        Me.Controls.Add(Me.Label70)
        Me.Name = "RepeticioCaracter"
        Me.Controls.SetChildIndex(Me.Label70, 0)
        Me.Controls.SetChildIndex(Me.tbDosCaracters, 0)
        Me.Controls.SetChildIndex(Me.GroupBox12, 0)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbDosCaracters As System.Windows.Forms.TextBox
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents Label71 As System.Windows.Forms.Label

End Class
