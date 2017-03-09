<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Altres
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
        Me.GroupBox18 = New System.Windows.Forms.GroupBox()
        Me.tbConverisoNumero = New System.Windows.Forms.TextBox()
        Me.lblExplicacio = New System.Windows.Forms.Label()
        Me.GroupBox18.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox18
        '
        Me.GroupBox18.Controls.Add(Me.tbConverisoNumero)
        Me.GroupBox18.Controls.Add(Me.lblExplicacio)
        Me.GroupBox18.Location = New System.Drawing.Point(11, 62)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(364, 87)
        Me.GroupBox18.TabIndex = 13
        Me.GroupBox18.TabStop = False
        Me.GroupBox18.Text = "Enunciat"
        '
        'tbConverisoNumero
        '
        Me.tbConverisoNumero.ContextMenuStrip = Me.cmsTotFuncional
        Me.tbConverisoNumero.Location = New System.Drawing.Point(6, 51)
        Me.tbConverisoNumero.Multiline = True
        Me.tbConverisoNumero.Name = "tbConverisoNumero"
        Me.tbConverisoNumero.Size = New System.Drawing.Size(213, 23)
        Me.tbConverisoNumero.TabIndex = 12
        Me.tbConverisoNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblExplicacio
        '
        Me.lblExplicacio.AutoSize = True
        Me.lblExplicacio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExplicacio.Location = New System.Drawing.Point(6, 16)
        Me.lblExplicacio.Name = "lblExplicacio"
        Me.lblExplicacio.Size = New System.Drawing.Size(351, 32)
        Me.lblExplicacio.TabIndex = 11
        Me.lblExplicacio.Text = "XXXXXXX Aqui anira el text XXXXXXXXXXXXXXXXXXXXXXX" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "XXXXXXXXX Aqui anira el text " & _
    "XXXXXXXXXXXXXXXXXXXXX"
        '
        'Altres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(633, 319)
        Me.Controls.Add(Me.GroupBox18)
        Me.Name = "Altres"
        Me.Controls.SetChildIndex(Me.GroupBox18, 0)
        Me.GroupBox18.ResumeLayout(False)
        Me.GroupBox18.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox18 As System.Windows.Forms.GroupBox
    Friend WithEvents tbConverisoNumero As System.Windows.Forms.TextBox
    Friend WithEvents lblExplicacio As System.Windows.Forms.Label

End Class
