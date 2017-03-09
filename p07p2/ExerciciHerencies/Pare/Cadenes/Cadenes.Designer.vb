<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cadenes
    Inherits p07p2.BasePrimaria

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
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.lblExplicacio = New System.Windows.Forms.Label()
        Me.tbCadena = New System.Windows.Forms.TextBox()
        Me.GroupBox9.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.lblExplicacio)
        Me.GroupBox9.Controls.Add(Me.tbCadena)
        Me.GroupBox9.Location = New System.Drawing.Point(12, 62)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(313, 212)
        Me.GroupBox9.TabIndex = 13
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Enunciat"
        '
        'lblExplicacio
        '
        Me.lblExplicacio.AutoSize = True
        Me.lblExplicacio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExplicacio.Location = New System.Drawing.Point(6, 16)
        Me.lblExplicacio.Name = "lblExplicacio"
        Me.lblExplicacio.Size = New System.Drawing.Size(188, 64)
        Me.lblExplicacio.TabIndex = 11
        Me.lblExplicacio.Text = "textt que implirem en cada cas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "textt que implirem en cada cas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "textt que implire" & _
    "m en cada cas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "textt que implirem en cada cas"
        '
        'tbCadena
        '
        Me.tbCadena.ContextMenuStrip = Me.cmsTotFuncional
        Me.tbCadena.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tbCadena.Location = New System.Drawing.Point(3, 92)
        Me.tbCadena.Multiline = True
        Me.tbCadena.Name = "tbCadena"
        Me.tbCadena.Size = New System.Drawing.Size(307, 117)
        Me.tbCadena.TabIndex = 3
        '
        'Cadenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(633, 319)
        Me.Controls.Add(Me.GroupBox9)
        Me.Name = "Cadenes"
        Me.Controls.SetChildIndex(Me.GroupBox9, 0)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents lblExplicacio As System.Windows.Forms.Label
    Friend WithEvents tbCadena As System.Windows.Forms.TextBox

End Class
