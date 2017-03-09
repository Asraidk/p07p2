<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BasePrimaria
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
        Me.components = New System.ComponentModel.Container()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.gpHora = New System.Windows.Forms.GroupBox()
        Me.Hora = New System.Windows.Forms.Timer(Me.components)
        Me.gpOperacio = New System.Windows.Forms.GroupBox()
        Me.lblOperacio = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnTancar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmsTotFuncional = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.IniciaValorA0ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncrementaEn1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecrementaEn1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CopiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TallarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnganxarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gpHora.SuspendLayout()
        Me.gpOperacio.SuspendLayout()
        Me.cmsTotFuncional.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.Location = New System.Drawing.Point(6, 16)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(57, 20)
        Me.lblHora.TabIndex = 0
        Me.lblHora.Text = "00:00:00"
        '
        'gpHora
        '
        Me.gpHora.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpHora.Controls.Add(Me.lblHora)
        Me.gpHora.Location = New System.Drawing.Point(544, 263)
        Me.gpHora.Name = "gpHora"
        Me.gpHora.Size = New System.Drawing.Size(77, 44)
        Me.gpHora.TabIndex = 1
        Me.gpHora.TabStop = False
        Me.gpHora.Text = "Hora actual"
        '
        'Hora
        '
        Me.Hora.Enabled = True
        Me.Hora.Interval = 1000
        '
        'gpOperacio
        '
        Me.gpOperacio.Controls.Add(Me.lblOperacio)
        Me.gpOperacio.Location = New System.Drawing.Point(12, 12)
        Me.gpOperacio.Name = "gpOperacio"
        Me.gpOperacio.Size = New System.Drawing.Size(253, 44)
        Me.gpOperacio.TabIndex = 2
        Me.gpOperacio.TabStop = False
        Me.gpOperacio.Text = "Operacio actual"
        '
        'lblOperacio
        '
        Me.lblOperacio.AutoSize = True
        Me.lblOperacio.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperacio.Location = New System.Drawing.Point(6, 16)
        Me.lblOperacio.Name = "lblOperacio"
        Me.lblOperacio.Size = New System.Drawing.Size(228, 20)
        Me.lblOperacio.TabIndex = 0
        Me.lblOperacio.Text = "Operacio que es dur a terme ara mateix"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(384, 82)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 3
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(465, 82)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 4
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnTancar
        '
        Me.btnTancar.Location = New System.Drawing.Point(546, 82)
        Me.btnTancar.Name = "btnTancar"
        Me.btnTancar.Size = New System.Drawing.Size(75, 23)
        Me.btnTancar.TabIndex = 5
        Me.btnTancar.Text = "Tancar"
        Me.btnTancar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(381, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Operacio "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(462, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Reiniciar camps"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(543, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Tanca el form"
        '
        'cmsTotFuncional
        '
        Me.cmsTotFuncional.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IniciaValorA0ToolStripMenuItem, Me.IncrementaEn1ToolStripMenuItem, Me.DecrementaEn1ToolStripMenuItem, Me.ToolStripSeparator1, Me.CopiaToolStripMenuItem, Me.TallarToolStripMenuItem, Me.EnganxarToolStripMenuItem})
        Me.cmsTotFuncional.Name = "ContextMenuStrip1"
        Me.cmsTotFuncional.Size = New System.Drawing.Size(168, 142)
        '
        'IniciaValorA0ToolStripMenuItem
        '
        Me.IniciaValorA0ToolStripMenuItem.Name = "IniciaValorA0ToolStripMenuItem"
        Me.IniciaValorA0ToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.IniciaValorA0ToolStripMenuItem.Text = "Inicia valor a 0"
        '
        'IncrementaEn1ToolStripMenuItem
        '
        Me.IncrementaEn1ToolStripMenuItem.Name = "IncrementaEn1ToolStripMenuItem"
        Me.IncrementaEn1ToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.IncrementaEn1ToolStripMenuItem.Text = "Incrementar en 1"
        '
        'DecrementaEn1ToolStripMenuItem
        '
        Me.DecrementaEn1ToolStripMenuItem.Name = "DecrementaEn1ToolStripMenuItem"
        Me.DecrementaEn1ToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.DecrementaEn1ToolStripMenuItem.Text = "Decrementar en 1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(164, 6)
        '
        'CopiaToolStripMenuItem
        '
        Me.CopiaToolStripMenuItem.Name = "CopiaToolStripMenuItem"
        Me.CopiaToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.CopiaToolStripMenuItem.Text = "Copia"
        '
        'TallarToolStripMenuItem
        '
        Me.TallarToolStripMenuItem.Name = "TallarToolStripMenuItem"
        Me.TallarToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.TallarToolStripMenuItem.Text = "Tallar"
        '
        'EnganxarToolStripMenuItem
        '
        Me.EnganxarToolStripMenuItem.Name = "EnganxarToolStripMenuItem"
        Me.EnganxarToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.EnganxarToolStripMenuItem.Text = "Enganxar"
        '
        'BasePrimaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 319)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTancar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.gpOperacio)
        Me.Controls.Add(Me.gpHora)
        Me.Name = "BasePrimaria"
        Me.Text = "Base Primaria"
        Me.gpHora.ResumeLayout(False)
        Me.gpHora.PerformLayout()
        Me.gpOperacio.ResumeLayout(False)
        Me.gpOperacio.PerformLayout()
        Me.cmsTotFuncional.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents gpHora As System.Windows.Forms.GroupBox
    Friend WithEvents Hora As System.Windows.Forms.Timer
    Friend WithEvents gpOperacio As System.Windows.Forms.GroupBox
    Friend WithEvents lblOperacio As System.Windows.Forms.Label
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnTancar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Protected WithEvents cmsTotFuncional As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents IniciaValorA0ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IncrementaEn1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DecrementaEn1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CopiaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TallarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnganxarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
