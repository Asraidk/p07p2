﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Areea
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.lblExplicacio = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tb1)
        Me.GroupBox1.Controls.Add(Me.lblExplicacio)
        Me.GroupBox1.Controls.Add(Me.lbl1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 181)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enunciat"
        '
        'tb1
        '
        Me.tb1.Location = New System.Drawing.Point(103, 116)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(100, 20)
        Me.tb1.TabIndex = 3
        '
        'lblExplicacio
        '
        Me.lblExplicacio.AutoSize = True
        Me.lblExplicacio.Location = New System.Drawing.Point(6, 19)
        Me.lblExplicacio.Name = "lblExplicacio"
        Me.lblExplicacio.Size = New System.Drawing.Size(160, 13)
        Me.lblExplicacio.TabIndex = 2
        Me.lblExplicacio.Text = "Aqui anira el text de l'explicacio: "
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(27, 116)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(35, 13)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "Num1"
        '
        'Areea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(633, 319)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Areea"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb1 As System.Windows.Forms.TextBox
    Friend WithEvents lblExplicacio As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Protected Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
