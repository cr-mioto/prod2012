<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVendedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVendedores))
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.CboMunicip = New System.Windows.Forms.ComboBox
        Me.TxtBairro = New System.Windows.Forms.TextBox
        Me.TxtCEP = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TxtComplemento = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtNumero = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtMsn = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtWeb = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtEmail = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CboUF = New System.Windows.Forms.ComboBox
        Me.DtCad = New System.Windows.Forms.DateTimePicker
        Me.Label22 = New System.Windows.Forms.Label
        Me.TxtEndereco = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.TxtNome = New System.Windows.Forms.TextBox
        Me.TxtRg = New System.Windows.Forms.TextBox
        Me.TxtCPF = New System.Windows.Forms.TextBox
        Me.TxtVendID = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton15 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton30 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton31 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton32 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton14 = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.MskCnpj = New System.Windows.Forms.MaskedTextBox
        Me.TxtInscEstadual = New System.Windows.Forms.TextBox
        Me.TxtFantasia = New System.Windows.Forms.TextBox
        Me.TxtRazao = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.Item = New System.Windows.Forms.ColumnHeader
        Me.DDD = New System.Windows.Forms.ColumnHeader
        Me.Telefone = New System.Windows.Forms.ColumnHeader
        Me.Ramal = New System.Windows.Forms.ColumnHeader
        Me.GroupBox5.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CboMunicip)
        Me.GroupBox5.Controls.Add(Me.TxtBairro)
        Me.GroupBox5.Controls.Add(Me.TxtCEP)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.TxtComplemento)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.TxtNumero)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.TxtMsn)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.TxtWeb)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.TxtEmail)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.CboUF)
        Me.GroupBox5.Controls.Add(Me.DtCad)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.TxtEndereco)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.TxtNome)
        Me.GroupBox5.Controls.Add(Me.TxtRg)
        Me.GroupBox5.Controls.Add(Me.TxtCPF)
        Me.GroupBox5.Controls.Add(Me.TxtVendID)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 40)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(431, 414)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Identificação do Vendedor :"
        '
        'CboMunicip
        '
        Me.CboMunicip.FormattingEnabled = True
        Me.CboMunicip.Location = New System.Drawing.Point(199, 239)
        Me.CboMunicip.Name = "CboMunicip"
        Me.CboMunicip.Size = New System.Drawing.Size(208, 21)
        Me.CboMunicip.TabIndex = 10
        '
        'TxtBairro
        '
        Me.TxtBairro.Location = New System.Drawing.Point(133, 213)
        Me.TxtBairro.Name = "TxtBairro"
        Me.TxtBairro.Size = New System.Drawing.Size(276, 20)
        Me.TxtBairro.TabIndex = 8
        '
        'TxtCEP
        '
        Me.TxtCEP.Location = New System.Drawing.Point(132, 267)
        Me.TxtCEP.Name = "TxtCEP"
        Me.TxtCEP.Size = New System.Drawing.Size(276, 20)
        Me.TxtCEP.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 272)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "CEP :"
        '
        'TxtComplemento
        '
        Me.TxtComplemento.Location = New System.Drawing.Point(131, 187)
        Me.TxtComplemento.Name = "TxtComplemento"
        Me.TxtComplemento.Size = New System.Drawing.Size(276, 20)
        Me.TxtComplemento.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 187)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Complemento :"
        '
        'TxtNumero
        '
        Me.TxtNumero.Location = New System.Drawing.Point(132, 158)
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.Size = New System.Drawing.Size(276, 20)
        Me.TxtNumero.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Número :"
        '
        'TxtMsn
        '
        Me.TxtMsn.Location = New System.Drawing.Point(131, 374)
        Me.TxtMsn.Name = "TxtMsn"
        Me.TxtMsn.Size = New System.Drawing.Size(276, 20)
        Me.TxtMsn.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 374)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "MSN ou ICQ"
        '
        'TxtWeb
        '
        Me.TxtWeb.Location = New System.Drawing.Point(131, 347)
        Me.TxtWeb.Name = "TxtWeb"
        Me.TxtWeb.Size = New System.Drawing.Size(276, 20)
        Me.TxtWeb.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 349)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Web Site:"
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(131, 321)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(276, 20)
        Me.TxtEmail.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 323)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "E-Mail :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "UF/Cidade :"
        '
        'CboUF
        '
        Me.CboUF.FormattingEnabled = True
        Me.CboUF.Location = New System.Drawing.Point(131, 240)
        Me.CboUF.Name = "CboUF"
        Me.CboUF.Size = New System.Drawing.Size(62, 21)
        Me.CboUF.TabIndex = 9
        '
        'DtCad
        '
        Me.DtCad.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtCad.Location = New System.Drawing.Point(131, 294)
        Me.DtCad.Name = "DtCad"
        Me.DtCad.Size = New System.Drawing.Size(277, 20)
        Me.DtCad.TabIndex = 12
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(16, 219)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(40, 13)
        Me.Label22.TabIndex = 17
        Me.Label22.Text = "Bairro :"
        '
        'TxtEndereco
        '
        Me.TxtEndereco.Location = New System.Drawing.Point(132, 129)
        Me.TxtEndereco.Name = "TxtEndereco"
        Me.TxtEndereco.Size = New System.Drawing.Size(276, 20)
        Me.TxtEndereco.TabIndex = 5
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(16, 132)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(59, 13)
        Me.Label21.TabIndex = 15
        Me.Label21.Text = "Endereço :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(16, 298)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 13)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "Data de Cadastro :"
        '
        'TxtNome
        '
        Me.TxtNome.Location = New System.Drawing.Point(132, 103)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(276, 20)
        Me.TxtNome.TabIndex = 4
        '
        'TxtRg
        '
        Me.TxtRg.Location = New System.Drawing.Point(132, 77)
        Me.TxtRg.Name = "TxtRg"
        Me.TxtRg.Size = New System.Drawing.Size(276, 20)
        Me.TxtRg.TabIndex = 3
        '
        'TxtCPF
        '
        Me.TxtCPF.Location = New System.Drawing.Point(132, 51)
        Me.TxtCPF.Name = "TxtCPF"
        Me.TxtCPF.Size = New System.Drawing.Size(276, 20)
        Me.TxtCPF.TabIndex = 2
        '
        'TxtVendID
        '
        Me.TxtVendID.Location = New System.Drawing.Point(322, 25)
        Me.TxtVendID.Name = "TxtVendID"
        Me.TxtVendID.Size = New System.Drawing.Size(86, 20)
        Me.TxtVendID.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 105)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Nome :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 78)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "R.G. :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(16, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(27, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "I.D.:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(16, 53)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "C.P.F. :"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton15, Me.ToolStripButton30, Me.ToolStripButton31, Me.ToolStripButton32, Me.ToolStripSeparator7, Me.ToolStripButton14})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(899, 25)
        Me.ToolStrip2.TabIndex = 11
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripButton15
        '
        Me.ToolStripButton15.Image = CType(resources.GetObject("ToolStripButton15.Image"), System.Drawing.Image)
        Me.ToolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton15.Name = "ToolStripButton15"
        Me.ToolStripButton15.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripButton15.Text = "Novo"
        '
        'ToolStripButton30
        '
        Me.ToolStripButton30.Image = CType(resources.GetObject("ToolStripButton30.Image"), System.Drawing.Image)
        Me.ToolStripButton30.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton30.Name = "ToolStripButton30"
        Me.ToolStripButton30.Size = New System.Drawing.Size(58, 22)
        Me.ToolStripButton30.Text = "Salvar"
        '
        'ToolStripButton31
        '
        Me.ToolStripButton31.Image = CType(resources.GetObject("ToolStripButton31.Image"), System.Drawing.Image)
        Me.ToolStripButton31.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton31.Name = "ToolStripButton31"
        Me.ToolStripButton31.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripButton31.Text = "Alterar"
        '
        'ToolStripButton32
        '
        Me.ToolStripButton32.Enabled = False
        Me.ToolStripButton32.Image = CType(resources.GetObject("ToolStripButton32.Image"), System.Drawing.Image)
        Me.ToolStripButton32.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton32.Name = "ToolStripButton32"
        Me.ToolStripButton32.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripButton32.Text = "Excluir"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton14
        '
        Me.ToolStripButton14.Image = CType(resources.GetObject("ToolStripButton14.Image"), System.Drawing.Image)
        Me.ToolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton14.Name = "ToolStripButton14"
        Me.ToolStripButton14.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripButton14.Text = "Localizar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MskCnpj)
        Me.GroupBox1.Controls.Add(Me.TxtInscEstadual)
        Me.GroupBox1.Controls.Add(Me.TxtFantasia)
        Me.GroupBox1.Controls.Add(Me.TxtRazao)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(449, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(438, 149)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identificação Pessoa Juridica "
        '
        'MskCnpj
        '
        Me.MskCnpj.Location = New System.Drawing.Point(132, 27)
        Me.MskCnpj.Mask = "99,999,999/9999-99"
        Me.MskCnpj.Name = "MskCnpj"
        Me.MskCnpj.Size = New System.Drawing.Size(280, 20)
        Me.MskCnpj.TabIndex = 16
        Me.MskCnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'TxtInscEstadual
        '
        Me.TxtInscEstadual.Location = New System.Drawing.Point(132, 106)
        Me.TxtInscEstadual.Name = "TxtInscEstadual"
        Me.TxtInscEstadual.Size = New System.Drawing.Size(280, 20)
        Me.TxtInscEstadual.TabIndex = 19
        '
        'TxtFantasia
        '
        Me.TxtFantasia.Location = New System.Drawing.Point(132, 79)
        Me.TxtFantasia.Name = "TxtFantasia"
        Me.TxtFantasia.Size = New System.Drawing.Size(280, 20)
        Me.TxtFantasia.TabIndex = 18
        '
        'TxtRazao
        '
        Me.TxtRazao.Location = New System.Drawing.Point(132, 53)
        Me.TxtRazao.Name = "TxtRazao"
        Me.TxtRazao.Size = New System.Drawing.Size(280, 20)
        Me.TxtRazao.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Inscrição Estadual:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nome de Fantasia:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Razão Social:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "C.N.P.J.:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.ListView1)
        Me.GroupBox3.Location = New System.Drawing.Point(449, 198)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(438, 256)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Telefones"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(324, 207)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 28)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Remover"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(324, 172)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 28)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Adicionar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Item, Me.DDD, Me.Telefone, Me.Ramal})
        Me.ListView1.Location = New System.Drawing.Point(19, 24)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(295, 211)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Item
        '
        Me.Item.Text = "Item"
        Me.Item.Width = 40
        '
        'DDD
        '
        Me.DDD.Text = "DDD"
        Me.DDD.Width = 40
        '
        'Telefone
        '
        Me.Telefone.Text = "Telefone"
        Me.Telefone.Width = 70
        '
        'Ramal
        '
        Me.Ramal.Text = "Ramal"
        '
        'FrmVendedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 474)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.GroupBox5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmVendedores"
        Me.Text = "Vendedores"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents CboUF As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TxtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TxtNome As System.Windows.Forms.TextBox
    Friend WithEvents TxtRg As System.Windows.Forms.TextBox
    Friend WithEvents TxtCPF As System.Windows.Forms.TextBox
    Friend WithEvents TxtVendID As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton15 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton30 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton31 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton32 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton14 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MskCnpj As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxtInscEstadual As System.Windows.Forms.TextBox
    Friend WithEvents TxtFantasia As System.Windows.Forms.TextBox
    Friend WithEvents TxtRazao As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Item As System.Windows.Forms.ColumnHeader
    Friend WithEvents DDD As System.Windows.Forms.ColumnHeader
    Friend WithEvents Telefone As System.Windows.Forms.ColumnHeader
    Friend WithEvents Ramal As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TxtMsn As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtWeb As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtComplemento As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtCEP As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CboMunicip As System.Windows.Forms.ComboBox
    Friend WithEvents TxtBairro As System.Windows.Forms.TextBox
    Friend WithEvents DtCad As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
