<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTecnica
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
        Dim Label7 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTecnica))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtCodGE = New System.Windows.Forms.TextBox()
        Me.TxtPeso = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CboStatus = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CboFuro = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtMedida = New System.Windows.Forms.TextBox()
        Me.TxtInfo = New System.Windows.Forms.TextBox()
        Me.TxtGaveta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DtData = New System.Windows.Forms.DateTimePicker()
        Me.CboVend = New System.Windows.Forms.ComboBox()
        Me.CboMaq = New System.Windows.Forms.ComboBox()
        Me.TxtCodVen = New System.Windows.Forms.TextBox()
        Me.BtnFiltroCli = New System.Windows.Forms.Button()
        Me.TxtRazao = New System.Windows.Forms.TextBox()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.TxtCodCli = New System.Windows.Forms.TextBox()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.GridMatriz = New System.Windows.Forms.DataGridView()
        Me.Matriz = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Faca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Medida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Area = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Micro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cartao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cores = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Impressao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Acabamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pinca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PicFoto = New System.Windows.Forms.PictureBox()
        Me.BtnNovo = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TxtObs = New System.Windows.Forms.TextBox()
        Me.BtnFoto = New System.Windows.Forms.Button()
        Me.BtnZoom = New System.Windows.Forms.Button()
        Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridMatriz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(679, 214)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(76, 18)
        Label7.TabIndex = 72
        Label7.Text = "Gaveta :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtCodGE)
        Me.GroupBox1.Controls.Add(Me.TxtPeso)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.CboStatus)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.CboFuro)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TxtMedida)
        Me.GroupBox1.Controls.Add(Me.TxtInfo)
        Me.GroupBox1.Controls.Add(Me.TxtGaveta)
        Me.GroupBox1.Controls.Add(Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DtData)
        Me.GroupBox1.Controls.Add(Me.CboVend)
        Me.GroupBox1.Controls.Add(Me.CboMaq)
        Me.GroupBox1.Controls.Add(Me.TxtCodVen)
        Me.GroupBox1.Controls.Add(Me.BtnFiltroCli)
        Me.GroupBox1.Controls.Add(Me.TxtRazao)
        Me.GroupBox1.Controls.Add(Me.TxtNome)
        Me.GroupBox1.Controls.Add(Me.TxtCodCli)
        Me.GroupBox1.Controls.Add(Me.TxtID)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(828, 252)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TxtCodGE
        '
        Me.TxtCodGE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodGE.Location = New System.Drawing.Point(279, 21)
        Me.TxtCodGE.Name = "TxtCodGE"
        Me.TxtCodGE.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtCodGE.Size = New System.Drawing.Size(98, 24)
        Me.TxtCodGE.TabIndex = 1
        Me.TxtCodGE.Text = "0"
        '
        'TxtPeso
        '
        Me.TxtPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPeso.Location = New System.Drawing.Point(443, 80)
        Me.TxtPeso.Name = "TxtPeso"
        Me.TxtPeso.Size = New System.Drawing.Size(120, 24)
        Me.TxtPeso.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(390, 83)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 18)
        Me.Label12.TabIndex = 78
        Me.Label12.Text = "Peso:"
        '
        'CboStatus
        '
        Me.CboStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboStatus.FormattingEnabled = True
        Me.CboStatus.Items.AddRange(New Object() {"ATIVO", "DESCONTINUADO"})
        Me.CboStatus.Location = New System.Drawing.Point(629, 24)
        Me.CboStatus.Name = "CboStatus"
        Me.CboStatus.Size = New System.Drawing.Size(177, 26)
        Me.CboStatus.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(569, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 18)
        Me.Label11.TabIndex = 76
        Me.Label11.Text = "Status:"
        '
        'CboFuro
        '
        Me.CboFuro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboFuro.FormattingEnabled = True
        Me.CboFuro.Items.AddRange(New Object() {"SIM", "NÂO", "VERIFICAR"})
        Me.CboFuro.Location = New System.Drawing.Point(163, 209)
        Me.CboFuro.Name = "CboFuro"
        Me.CboFuro.Size = New System.Drawing.Size(109, 26)
        Me.CboFuro.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 18)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "Medida:"
        '
        'TxtMedida
        '
        Me.TxtMedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMedida.Location = New System.Drawing.Point(162, 80)
        Me.TxtMedida.Name = "TxtMedida"
        Me.TxtMedida.Size = New System.Drawing.Size(216, 24)
        Me.TxtMedida.TabIndex = 5
        '
        'TxtInfo
        '
        Me.TxtInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInfo.Location = New System.Drawing.Point(325, 211)
        Me.TxtInfo.Name = "TxtInfo"
        Me.TxtInfo.Size = New System.Drawing.Size(348, 24)
        Me.TxtInfo.TabIndex = 13
        '
        'TxtGaveta
        '
        Me.TxtGaveta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtGaveta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGaveta.Location = New System.Drawing.Point(742, 211)
        Me.TxtGaveta.MaxLength = 3
        Me.TxtGaveta.Name = "TxtGaveta"
        Me.TxtGaveta.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtGaveta.Size = New System.Drawing.Size(76, 24)
        Me.TxtGaveta.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(287, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 18)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Info.:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 18)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Furo:"
        '
        'DtData
        '
        Me.DtData.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtData.Location = New System.Drawing.Point(443, 24)
        Me.DtData.Name = "DtData"
        Me.DtData.Size = New System.Drawing.Size(122, 24)
        Me.DtData.TabIndex = 2
        '
        'CboVend
        '
        Me.CboVend.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboVend.FormattingEnabled = True
        Me.CboVend.Location = New System.Drawing.Point(227, 171)
        Me.CboVend.Name = "CboVend"
        Me.CboVend.Size = New System.Drawing.Size(446, 26)
        Me.CboVend.TabIndex = 11
        '
        'CboMaq
        '
        Me.CboMaq.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboMaq.FormattingEnabled = True
        Me.CboMaq.Location = New System.Drawing.Point(162, 109)
        Me.CboMaq.Name = "CboMaq"
        Me.CboMaq.Size = New System.Drawing.Size(231, 26)
        Me.CboMaq.TabIndex = 7
        '
        'TxtCodVen
        '
        Me.TxtCodVen.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodVen.Location = New System.Drawing.Point(162, 171)
        Me.TxtCodVen.Name = "TxtCodVen"
        Me.TxtCodVen.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtCodVen.Size = New System.Drawing.Size(62, 24)
        Me.TxtCodVen.TabIndex = 10
        '
        'BtnFiltroCli
        '
        Me.BtnFiltroCli.Image = CType(resources.GetObject("BtnFiltroCli.Image"), System.Drawing.Image)
        Me.BtnFiltroCli.Location = New System.Drawing.Point(644, 141)
        Me.BtnFiltroCli.Name = "BtnFiltroCli"
        Me.BtnFiltroCli.Size = New System.Drawing.Size(29, 24)
        Me.BtnFiltroCli.TabIndex = 8
        Me.BtnFiltroCli.UseVisualStyleBackColor = True
        '
        'TxtRazao
        '
        Me.TxtRazao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRazao.Location = New System.Drawing.Point(227, 141)
        Me.TxtRazao.Name = "TxtRazao"
        Me.TxtRazao.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtRazao.Size = New System.Drawing.Size(411, 24)
        Me.TxtRazao.TabIndex = 9
        Me.TxtRazao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtNome
        '
        Me.TxtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNome.Location = New System.Drawing.Point(162, 50)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(216, 24)
        Me.TxtNome.TabIndex = 4
        '
        'TxtCodCli
        '
        Me.TxtCodCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodCli.Location = New System.Drawing.Point(162, 141)
        Me.TxtCodCli.Name = "TxtCodCli"
        Me.TxtCodCli.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtCodCli.Size = New System.Drawing.Size(62, 24)
        Me.TxtCodCli.TabIndex = 8
        '
        'TxtID
        '
        Me.TxtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtID.Location = New System.Drawing.Point(162, 21)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(111, 24)
        Me.TxtID.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(390, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 18)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Data:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 174)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 18)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Vendedor:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Cliente:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Maquina:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome da Emb.:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código Embalagem:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ToolStrip1)
        Me.GroupBox2.Controls.Add(Me.GridMatriz)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1186, 239)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 211)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1180, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.PROD2012.My.Resources.Resources.ZoomHS
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(105, 22)
        Me.ToolStripButton1.Text = "Localizar Facas"
        '
        'GridMatriz
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridMatriz.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GridMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridMatriz.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Matriz, Me.Faca, Me.Medida, Me.Tipo, Me.Area, Me.Micro, Me.Cartao, Me.Cores, Me.Impressao, Me.Acabamento, Me.Pinca})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridMatriz.DefaultCellStyle = DataGridViewCellStyle7
        Me.GridMatriz.Location = New System.Drawing.Point(14, 19)
        Me.GridMatriz.Name = "GridMatriz"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridMatriz.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.GridMatriz.Size = New System.Drawing.Size(1155, 170)
        Me.GridMatriz.TabIndex = 15
        '
        'Matriz
        '
        Me.Matriz.HeaderText = "Item"
        Me.Matriz.Name = "Matriz"
        Me.Matriz.Width = 50
        '
        'Faca
        '
        Me.Faca.HeaderText = "Matriz"
        Me.Faca.Name = "Faca"
        '
        'Medida
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Medida.DefaultCellStyle = DataGridViewCellStyle2
        Me.Medida.HeaderText = "Medida"
        Me.Medida.Name = "Medida"
        Me.Medida.ReadOnly = True
        '
        'Tipo
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Tipo.DefaultCellStyle = DataGridViewCellStyle3
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Width = 40
        '
        'Area
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Area.DefaultCellStyle = DataGridViewCellStyle4
        Me.Area.HeaderText = "Área"
        Me.Area.Name = "Area"
        Me.Area.ReadOnly = True
        '
        'Micro
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Micro.DefaultCellStyle = DataGridViewCellStyle5
        Me.Micro.HeaderText = "Micro"
        Me.Micro.Name = "Micro"
        Me.Micro.ReadOnly = True
        '
        'Cartao
        '
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Cartao.DefaultCellStyle = DataGridViewCellStyle6
        Me.Cartao.HeaderText = "Cartão"
        Me.Cartao.Name = "Cartao"
        Me.Cartao.ReadOnly = True
        '
        'Cores
        '
        Me.Cores.HeaderText = "Cores"
        Me.Cores.Name = "Cores"
        Me.Cores.Width = 150
        '
        'Impressao
        '
        Me.Impressao.HeaderText = "Impressão"
        Me.Impressao.Name = "Impressao"
        Me.Impressao.Width = 150
        '
        'Acabamento
        '
        Me.Acabamento.HeaderText = "Acabamento"
        Me.Acabamento.Name = "Acabamento"
        Me.Acabamento.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Acabamento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Acabamento.Width = 200
        '
        'Pinca
        '
        Me.Pinca.HeaderText = "Pinca"
        Me.Pinca.Name = "Pinca"
        Me.Pinca.Width = 50
        '
        'PicFoto
        '
        Me.PicFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PicFoto.Image = CType(resources.GetObject("PicFoto.Image"), System.Drawing.Image)
        Me.PicFoto.InitialImage = CType(resources.GetObject("PicFoto.InitialImage"), System.Drawing.Image)
        Me.PicFoto.Location = New System.Drawing.Point(851, 7)
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.Size = New System.Drawing.Size(348, 247)
        Me.PicFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicFoto.TabIndex = 2
        Me.PicFoto.TabStop = False
        '
        'BtnNovo
        '
        Me.BtnNovo.Image = CType(resources.GetObject("BtnNovo.Image"), System.Drawing.Image)
        Me.BtnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNovo.Location = New System.Drawing.Point(849, 580)
        Me.BtnNovo.Name = "BtnNovo"
        Me.BtnNovo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnNovo.Size = New System.Drawing.Size(91, 32)
        Me.BtnNovo.TabIndex = 16
        Me.BtnNovo.Text = "&Novo"
        Me.BtnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnNovo.UseVisualStyleBackColor = True
        Me.BtnNovo.Visible = False
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(1043, 580)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(91, 32)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "&Imprimir"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.Location = New System.Drawing.Point(1140, 580)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCancel.Size = New System.Drawing.Size(91, 32)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "&Fechar"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Image)
        Me.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOK.Location = New System.Drawing.Point(946, 580)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnOK.Size = New System.Drawing.Size(91, 32)
        Me.btnOK.TabIndex = 17
        Me.btnOK.Text = "&OK"
        Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 284)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1219, 290)
        Me.TabControl1.TabIndex = 14
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1211, 264)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Matrizes"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TxtObs)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1211, 264)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Observações"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TxtObs
        '
        Me.TxtObs.Location = New System.Drawing.Point(25, 19)
        Me.TxtObs.Multiline = True
        Me.TxtObs.Name = "TxtObs"
        Me.TxtObs.Size = New System.Drawing.Size(1158, 202)
        Me.TxtObs.TabIndex = 0
        '
        'BtnFoto
        '
        Me.BtnFoto.Image = CType(resources.GetObject("BtnFoto.Image"), System.Drawing.Image)
        Me.BtnFoto.Location = New System.Drawing.Point(854, 259)
        Me.BtnFoto.Name = "BtnFoto"
        Me.BtnFoto.Size = New System.Drawing.Size(160, 32)
        Me.BtnFoto.TabIndex = 21
        Me.BtnFoto.Text = "Inserir Imagem"
        Me.BtnFoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnFoto.UseVisualStyleBackColor = True
        '
        'BtnZoom
        '
        Me.BtnZoom.Image = CType(resources.GetObject("BtnZoom.Image"), System.Drawing.Image)
        Me.BtnZoom.Location = New System.Drawing.Point(1032, 259)
        Me.BtnZoom.Name = "BtnZoom"
        Me.BtnZoom.Size = New System.Drawing.Size(160, 32)
        Me.BtnZoom.TabIndex = 22
        Me.BtnZoom.Text = "Zoom"
        Me.BtnZoom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnZoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnZoom.UseVisualStyleBackColor = True
        '
        'FrmTecnica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1248, 623)
        Me.Controls.Add(Me.BtnZoom)
        Me.Controls.Add(Me.BtnFoto)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.BtnNovo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.PicFoto)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "FrmTecnica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ficha Técnica"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridMatriz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtID As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNome As System.Windows.Forms.TextBox
    Friend WithEvents CboMaq As System.Windows.Forms.ComboBox
    Friend WithEvents DtData As System.Windows.Forms.DateTimePicker
    Friend WithEvents CboVend As System.Windows.Forms.ComboBox
    Friend WithEvents TxtCodVen As System.Windows.Forms.TextBox
    Friend WithEvents BtnFiltroCli As System.Windows.Forms.Button
    Friend WithEvents TxtRazao As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodCli As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GridMatriz As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Matriz As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Faca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Medida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Area As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Micro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cartao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cores As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Impressao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Acabamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pinca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PicFoto As System.Windows.Forms.PictureBox
    Friend WithEvents TxtInfo As System.Windows.Forms.TextBox
    Friend WithEvents TxtGaveta As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnNovo As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TxtObs As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtMedida As System.Windows.Forms.TextBox
    Friend WithEvents CboFuro As System.Windows.Forms.ComboBox
    Friend WithEvents CboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents BtnFoto As System.Windows.Forms.Button
    Friend WithEvents BtnZoom As System.Windows.Forms.Button
    Friend WithEvents TxtPeso As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtCodGE As TextBox
End Class
