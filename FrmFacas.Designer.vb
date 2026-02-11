<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFacas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Label5 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim SetorIDLabel As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFacas))
        Dim Label10 As System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.DT1 = New System.Windows.Forms.DateTimePicker()
        Me.Txt5 = New System.Windows.Forms.TextBox()
        Me.Txt4 = New System.Windows.Forms.TextBox()
        Me.Txt3 = New System.Windows.Forms.TextBox()
        Me.Cbo1 = New System.Windows.Forms.ComboBox()
        Me.Txt2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt6 = New System.Windows.Forms.TextBox()
        Me.Txt7 = New System.Windows.Forms.TextBox()
        Me.Txt8 = New System.Windows.Forms.TextBox()
        Me.Txt9 = New System.Windows.Forms.TextBox()
        Me.optAtivo = New System.Windows.Forms.RadioButton()
        Me.optDescontinuado = New System.Windows.Forms.RadioButton()
        Label5 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        SetorIDLabel = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label5
        '
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(24, 159)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(98, 18)
        Label5.TabIndex = 54
        Label5.Text = "Área:"
        '
        'Label4
        '
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(24, 127)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(98, 18)
        Label4.TabIndex = 53
        Label4.Text = "Qtde:"
        '
        'Label3
        '
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(24, 95)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(98, 18)
        Label3.TabIndex = 52
        Label3.Text = "Tipo:"
        '
        'SetorIDLabel
        '
        SetorIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SetorIDLabel.Location = New System.Drawing.Point(24, 65)
        SetorIDLabel.Name = "SetorIDLabel"
        SetorIDLabel.Size = New System.Drawing.Size(98, 18)
        SetorIDLabel.TabIndex = 51
        SetorIDLabel.Text = "Medida:"
        '
        'Label6
        '
        Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(24, 223)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(98, 18)
        Label6.TabIndex = 57
        Label6.Text = "Cartão:"
        '
        'Label7
        '
        Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(24, 191)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(98, 18)
        Label7.TabIndex = 58
        Label7.Text = "Micro:"
        '
        'Label8
        '
        Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.Location = New System.Drawing.Point(24, 255)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(98, 18)
        Label8.TabIndex = 61
        Label8.Text = "Arranjo:"
        '
        'Label9
        '
        Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.Location = New System.Drawing.Point(24, 289)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(101, 18)
        Label9.TabIndex = 62
        Label9.Text = "Observações:"
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.Location = New System.Drawing.Point(447, 578)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCancel.Size = New System.Drawing.Size(91, 32)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "&Fechar"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Image)
        Me.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOK.Location = New System.Drawing.Point(350, 578)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnOK.Size = New System.Drawing.Size(91, 32)
        Me.btnOK.TabIndex = 11
        Me.btnOK.Text = "&OK"
        Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'DT1
        '
        Me.DT1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DT1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT1.Location = New System.Drawing.Point(128, 35)
        Me.DT1.Name = "DT1"
        Me.DT1.RightToLeftLayout = True
        Me.DT1.Size = New System.Drawing.Size(111, 24)
        Me.DT1.TabIndex = 1
        '
        'Txt5
        '
        Me.Txt5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt5.Location = New System.Drawing.Point(128, 159)
        Me.Txt5.Name = "Txt5"
        Me.Txt5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Txt5.Size = New System.Drawing.Size(411, 24)
        Me.Txt5.TabIndex = 6
        '
        'Txt4
        '
        Me.Txt4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt4.Location = New System.Drawing.Point(128, 127)
        Me.Txt4.Name = "Txt4"
        Me.Txt4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Txt4.Size = New System.Drawing.Size(411, 24)
        Me.Txt4.TabIndex = 5
        '
        'Txt3
        '
        Me.Txt3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt3.Location = New System.Drawing.Point(128, 95)
        Me.Txt3.Name = "Txt3"
        Me.Txt3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Txt3.Size = New System.Drawing.Size(62, 24)
        Me.Txt3.TabIndex = 3
        '
        'Cbo1
        '
        Me.Cbo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo1.FormattingEnabled = True
        Me.Cbo1.Location = New System.Drawing.Point(201, 95)
        Me.Cbo1.Name = "Cbo1"
        Me.Cbo1.Size = New System.Drawing.Size(337, 26)
        Me.Cbo1.TabIndex = 4
        '
        'Txt2
        '
        Me.Txt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt2.Location = New System.Drawing.Point(128, 63)
        Me.Txt2.Name = "Txt2"
        Me.Txt2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Txt2.Size = New System.Drawing.Size(411, 24)
        Me.Txt2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 18)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Data:"
        '
        'Txt1
        '
        Me.Txt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt1.Location = New System.Drawing.Point(128, 9)
        Me.Txt1.Name = "Txt1"
        Me.Txt1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Txt1.Size = New System.Drawing.Size(111, 24)
        Me.Txt1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 18)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "ID:"
        '
        'Txt6
        '
        Me.Txt6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt6.Location = New System.Drawing.Point(128, 223)
        Me.Txt6.Name = "Txt6"
        Me.Txt6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Txt6.Size = New System.Drawing.Size(411, 24)
        Me.Txt6.TabIndex = 7
        '
        'Txt7
        '
        Me.Txt7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt7.Location = New System.Drawing.Point(128, 191)
        Me.Txt7.Name = "Txt7"
        Me.Txt7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Txt7.Size = New System.Drawing.Size(411, 24)
        Me.Txt7.TabIndex = 8
        '
        'Txt8
        '
        Me.Txt8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt8.Location = New System.Drawing.Point(128, 255)
        Me.Txt8.Name = "Txt8"
        Me.Txt8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Txt8.Size = New System.Drawing.Size(411, 24)
        Me.Txt8.TabIndex = 9
        '
        'Txt9
        '
        Me.Txt9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt9.Location = New System.Drawing.Point(128, 289)
        Me.Txt9.MaxLength = 100
        Me.Txt9.Multiline = True
        Me.Txt9.Name = "Txt9"
        Me.Txt9.Size = New System.Drawing.Size(411, 45)
        Me.Txt9.TabIndex = 10
        '
        'Label10
        '
        Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.Location = New System.Drawing.Point(24, 355)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(101, 18)
        Label10.TabIndex = 63
        Label10.Text = "Status:"
        '
        'optAtivo
        '
        Me.optAtivo.AutoSize = True
        Me.optAtivo.Checked = True
        Me.optAtivo.Location = New System.Drawing.Point(128, 355)
        Me.optAtivo.Name = "optAtivo"
        Me.optAtivo.Size = New System.Drawing.Size(49, 17)
        Me.optAtivo.TabIndex = 64
        Me.optAtivo.TabStop = True
        Me.optAtivo.Text = "Ativo"
        Me.optAtivo.UseVisualStyleBackColor = True
        '
        'optDescontinuado
        '
        Me.optDescontinuado.AutoSize = True
        Me.optDescontinuado.Location = New System.Drawing.Point(256, 355)
        Me.optDescontinuado.Name = "optDescontinuado"
        Me.optDescontinuado.Size = New System.Drawing.Size(97, 17)
        Me.optDescontinuado.TabIndex = 65
        Me.optDescontinuado.Text = "Descontinuado"
        Me.optDescontinuado.UseVisualStyleBackColor = True
        '
        'FrmFacas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 622)
        Me.Controls.Add(Me.optDescontinuado)
        Me.Controls.Add(Me.optAtivo)
        Me.Controls.Add(Label10)
        Me.Controls.Add(Label9)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Me.Txt9)
        Me.Controls.Add(Me.Txt8)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.Txt7)
        Me.Controls.Add(Me.Txt6)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.DT1)
        Me.Controls.Add(Me.Txt5)
        Me.Controls.Add(Me.Txt4)
        Me.Controls.Add(Me.Txt3)
        Me.Controls.Add(Me.Cbo1)
        Me.Controls.Add(Me.Txt2)
        Me.Controls.Add(SetorIDLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmFacas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Facas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents DT1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Txt5 As System.Windows.Forms.TextBox
    Friend WithEvents Txt4 As System.Windows.Forms.TextBox
    Friend WithEvents Txt3 As System.Windows.Forms.TextBox
    Friend WithEvents Cbo1 As System.Windows.Forms.ComboBox
    Friend WithEvents Txt2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txt1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt6 As System.Windows.Forms.TextBox
    Friend WithEvents Txt7 As System.Windows.Forms.TextBox
    Friend WithEvents Txt8 As System.Windows.Forms.TextBox
    Friend WithEvents Txt9 As System.Windows.Forms.TextBox
    Friend WithEvents optAtivo As System.Windows.Forms.RadioButton
    Friend WithEvents optDescontinuado As System.Windows.Forms.RadioButton
End Class
