<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMovimento
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim MovimentoIDLabel As System.Windows.Forms.Label
        Dim DescricaoLabel As System.Windows.Forms.Label
        Me.MovimentoIDTextBox = New System.Windows.Forms.TextBox()
        Me.DescricaoTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        MovimentoIDLabel = New System.Windows.Forms.Label()
        DescricaoLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MovimentoIDLabel
        '
        MovimentoIDLabel.AutoSize = True
        MovimentoIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MovimentoIDLabel.Location = New System.Drawing.Point(16, 26)
        MovimentoIDLabel.Name = "MovimentoIDLabel"
        MovimentoIDLabel.Size = New System.Drawing.Size(111, 20)
        MovimentoIDLabel.TabIndex = 1
        MovimentoIDLabel.Text = "Movimento ID:"
        AddHandler MovimentoIDLabel.Click, AddressOf Me.MovimentoIDLabel_Click
        '
        'DescricaoLabel
        '
        DescricaoLabel.AutoSize = True
        DescricaoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescricaoLabel.Location = New System.Drawing.Point(16, 58)
        DescricaoLabel.Name = "DescricaoLabel"
        DescricaoLabel.Size = New System.Drawing.Size(84, 20)
        DescricaoLabel.TabIndex = 3
        DescricaoLabel.Text = "Descricao:"
        '
        'MovimentoIDTextBox
        '
        Me.MovimentoIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MovimentoIDTextBox.Location = New System.Drawing.Point(141, 26)
        Me.MovimentoIDTextBox.Name = "MovimentoIDTextBox"
        Me.MovimentoIDTextBox.Size = New System.Drawing.Size(100, 26)
        Me.MovimentoIDTextBox.TabIndex = 2
        '
        'DescricaoTextBox
        '
        Me.DescricaoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescricaoTextBox.Location = New System.Drawing.Point(141, 58)
        Me.DescricaoTextBox.Name = "DescricaoTextBox"
        Me.DescricaoTextBox.Size = New System.Drawing.Size(316, 26)
        Me.DescricaoTextBox.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(MovimentoIDLabel)
        Me.GroupBox1.Controls.Add(Me.MovimentoIDTextBox)
        Me.GroupBox1.Controls.Add(DescricaoLabel)
        Me.GroupBox1.Controls.Add(Me.DescricaoTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(476, 112)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'FrmMovimento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 162)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmMovimento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Tipos de Movimentação"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MovimentoIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescricaoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
