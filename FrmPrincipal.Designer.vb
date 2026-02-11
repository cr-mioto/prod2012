<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Maquinas", 3, 3)
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Operadores", 3, 3)
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tipos de Movimento", 3, 3)
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Acabamento", 3, 3)
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Grupos", 3, 3)
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Materiais", 3, 3)
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Setor", 3, 3)
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tipos de Facas", 3, 3)
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Facas", 3, 3)
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Embalagens", 3, 3)
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cadastros", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9, TreeNode10})
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fichas de Produção", 3, 3)
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Produção Máquinas", 3, 3)
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Estoques", 3, 3)
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Manutenção", 1, 1, New System.Windows.Forms.TreeNode() {TreeNode12, TreeNode13, TreeNode14})
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Usuários", 2, 2)
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gerenciamento", 1, 1, New System.Windows.Forms.TreeNode() {TreeNode16})
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Prod2012", 0, 0, New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode15, TreeNode17})
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatoriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatóriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnaliticoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SintéticoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EmbalagensPorVendedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CatalogoPorVendedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.EmbalagensPorClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ListagemDeArquivoDeChapasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FerramentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusDtHora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.TxtFiltar = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cboFiltrar = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnFiltrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnLimpar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNovo = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnVisualizar = New System.Windows.Forms.ToolStripButton()
        Me.btnExcluir = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStrip4.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem, Me.RelatoriosToolStripMenuItem, Me.FerramentasToolStripMenuItem, Me.SobreToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1106, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SairToolStripMenuItem})
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ArquivoToolStripMenuItem.Text = "&Arquivo"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Image = CType(resources.GetObject("SairToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.SairToolStripMenuItem.Text = "&Sair"
        '
        'RelatoriosToolStripMenuItem
        '
        Me.RelatoriosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RelatóriosToolStripMenuItem})
        Me.RelatoriosToolStripMenuItem.Name = "RelatoriosToolStripMenuItem"
        Me.RelatoriosToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.RelatoriosToolStripMenuItem.Text = "Relatorios"
        '
        'RelatóriosToolStripMenuItem
        '
        Me.RelatóriosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnaliticoToolStripMenuItem, Me.ToolStripMenuItem1, Me.SintéticoToolStripMenuItem, Me.ToolStripMenuItem2, Me.EmbalagensPorVendedorToolStripMenuItem, Me.ToolStripMenuItem3, Me.CatalogoPorVendedorToolStripMenuItem, Me.ToolStripMenuItem4, Me.EmbalagensPorClienteToolStripMenuItem, Me.ToolStripMenuItem5, Me.ListagemDeArquivoDeChapasToolStripMenuItem})
        Me.RelatóriosToolStripMenuItem.Name = "RelatóriosToolStripMenuItem"
        Me.RelatóriosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RelatóriosToolStripMenuItem.Text = "Produção"
        '
        'AnaliticoToolStripMenuItem
        '
        Me.AnaliticoToolStripMenuItem.Name = "AnaliticoToolStripMenuItem"
        Me.AnaliticoToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.AnaliticoToolStripMenuItem.Text = "Análitico"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(245, 6)
        '
        'SintéticoToolStripMenuItem
        '
        Me.SintéticoToolStripMenuItem.Name = "SintéticoToolStripMenuItem"
        Me.SintéticoToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.SintéticoToolStripMenuItem.Text = "Sintético"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(245, 6)
        '
        'EmbalagensPorVendedorToolStripMenuItem
        '
        Me.EmbalagensPorVendedorToolStripMenuItem.Name = "EmbalagensPorVendedorToolStripMenuItem"
        Me.EmbalagensPorVendedorToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.EmbalagensPorVendedorToolStripMenuItem.Text = "Embalagens Ativas por Vendedor"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(245, 6)
        '
        'CatalogoPorVendedorToolStripMenuItem
        '
        Me.CatalogoPorVendedorToolStripMenuItem.Name = "CatalogoPorVendedorToolStripMenuItem"
        Me.CatalogoPorVendedorToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.CatalogoPorVendedorToolStripMenuItem.Text = "Catalogo por Vendedor"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(245, 6)
        '
        'EmbalagensPorClienteToolStripMenuItem
        '
        Me.EmbalagensPorClienteToolStripMenuItem.Name = "EmbalagensPorClienteToolStripMenuItem"
        Me.EmbalagensPorClienteToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.EmbalagensPorClienteToolStripMenuItem.Text = "Embalagens por Cliente"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(245, 6)
        '
        'ListagemDeArquivoDeChapasToolStripMenuItem
        '
        Me.ListagemDeArquivoDeChapasToolStripMenuItem.Name = "ListagemDeArquivoDeChapasToolStripMenuItem"
        Me.ListagemDeArquivoDeChapasToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.ListagemDeArquivoDeChapasToolStripMenuItem.Text = "Listagem do Arquivo de Chapas"
        '
        'FerramentasToolStripMenuItem
        '
        Me.FerramentasToolStripMenuItem.Enabled = False
        Me.FerramentasToolStripMenuItem.Name = "FerramentasToolStripMenuItem"
        Me.FerramentasToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.FerramentasToolStripMenuItem.Text = "Ferramentas"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.Enabled = False
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.SobreToolStripMenuItem.Text = "Sobre..."
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.StatusUser, Me.StatusDtHora})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 623)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1106, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(145, 17)
        Me.ToolStripStatusLabel1.Text = "Cartonagem São Luiz Ltda"
        '
        'StatusUser
        '
        Me.StatusUser.Name = "StatusUser"
        Me.StatusUser.Size = New System.Drawing.Size(50, 17)
        Me.StatusUser.Text = "Usuário:"
        '
        'StatusDtHora
        '
        Me.StatusDtHora.Name = "StatusDtHora"
        Me.StatusDtHora.Size = New System.Drawing.Size(65, 17)
        Me.StatusDtHora.Text = "Data/Hora:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip4)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1106, 599)
        Me.SplitContainer1.SplitterDistance = 223
        Me.SplitContainer1.TabIndex = 5
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.ImageList1
        Me.TreeView1.Location = New System.Drawing.Point(0, 25)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.ImageIndex = 3
        TreeNode1.Name = "Maq"
        TreeNode1.SelectedImageIndex = 3
        TreeNode1.Text = "Maquinas"
        TreeNode2.ImageIndex = 3
        TreeNode2.Name = "Oper"
        TreeNode2.SelectedImageIndex = 3
        TreeNode2.Text = "Operadores"
        TreeNode3.ImageIndex = 3
        TreeNode3.Name = "TpMov"
        TreeNode3.SelectedImageIndex = 3
        TreeNode3.Text = "Tipos de Movimento"
        TreeNode4.ImageIndex = 3
        TreeNode4.Name = "Acab"
        TreeNode4.SelectedImageIndex = 3
        TreeNode4.Text = "Acabamento"
        TreeNode5.ImageIndex = 3
        TreeNode5.Name = "Grp"
        TreeNode5.SelectedImageIndex = 3
        TreeNode5.Text = "Grupos"
        TreeNode6.ImageIndex = 3
        TreeNode6.Name = "Mat"
        TreeNode6.SelectedImageIndex = 3
        TreeNode6.Text = "Materiais"
        TreeNode7.ImageIndex = 3
        TreeNode7.Name = "Setor"
        TreeNode7.SelectedImageIndex = 3
        TreeNode7.Text = "Setor"
        TreeNode8.ImageIndex = 3
        TreeNode8.Name = "TiposFacas"
        TreeNode8.SelectedImageIndex = 3
        TreeNode8.Text = "Tipos de Facas"
        TreeNode9.ImageIndex = 3
        TreeNode9.Name = "Facas"
        TreeNode9.SelectedImageIndex = 3
        TreeNode9.Text = "Facas"
        TreeNode10.ImageIndex = 3
        TreeNode10.Name = "Embalagens"
        TreeNode10.SelectedImageIndex = 3
        TreeNode10.Text = "Embalagens"
        TreeNode11.ImageKey = "Folder.ico"
        TreeNode11.Name = "Root_Cad"
        TreeNode11.SelectedImageKey = "Folder.ico"
        TreeNode11.StateImageKey = "(none)"
        TreeNode11.Text = "Cadastros"
        TreeNode12.ImageIndex = 3
        TreeNode12.Name = "FichaProd"
        TreeNode12.SelectedImageIndex = 3
        TreeNode12.Text = "Fichas de Produção"
        TreeNode13.ImageIndex = 3
        TreeNode13.Name = "Servico"
        TreeNode13.SelectedImageIndex = 3
        TreeNode13.Text = "Produção Máquinas"
        TreeNode14.ImageIndex = 3
        TreeNode14.Name = "Child_Estoque"
        TreeNode14.SelectedImageIndex = 3
        TreeNode14.Text = "Estoques"
        TreeNode15.ImageIndex = 1
        TreeNode15.Name = "Child_Man"
        TreeNode15.SelectedImageIndex = 1
        TreeNode15.Text = "Manutenção"
        TreeNode16.ImageIndex = 2
        TreeNode16.Name = "nUsuarios"
        TreeNode16.SelectedImageIndex = 2
        TreeNode16.Text = "Usuários"
        TreeNode17.ImageIndex = 1
        TreeNode17.Name = "nGerencia"
        TreeNode17.SelectedImageIndex = 1
        TreeNode17.Text = "Gerenciamento"
        TreeNode18.ImageIndex = 0
        TreeNode18.Name = "Prod2012"
        TreeNode18.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode18.SelectedImageIndex = 0
        TreeNode18.Text = "Prod2012"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode18})
        Me.TreeView1.SelectedImageIndex = 0
        Me.TreeView1.Size = New System.Drawing.Size(219, 570)
        Me.TreeView1.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "base_cylinder_32.png")
        Me.ImageList1.Images.SetKeyName(1, "Folder.ico")
        Me.ImageList1.Images.SetKeyName(2, "Properties.png")
        Me.ImageList1.Images.SetKeyName(3, "TableHS.png")
        '
        'ToolStrip4
        '
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2})
        Me.ToolStrip4.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Size = New System.Drawing.Size(219, 25)
        Me.ToolStrip4.TabIndex = 1
        Me.ToolStrip4.Text = "ToolStrip4"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(64, 22)
        Me.ToolStripLabel2.Text = "Programas"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.ListView1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ToolStrip3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.ToolStrip2)
        Me.SplitContainer2.Size = New System.Drawing.Size(879, 599)
        Me.SplitContainer2.SplitterDistance = 751
        Me.SplitContainer2.TabIndex = 0
        '
        'ListView1
        '
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Location = New System.Drawing.Point(0, 25)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(747, 570)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.TxtFiltar, Me.ToolStripSeparator1, Me.cboFiltrar, Me.ToolStripSeparator4, Me.btnFiltrar, Me.ToolStripSeparator3, Me.btnLimpar})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(747, 25)
        Me.ToolStrip3.TabIndex = 0
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(37, 22)
        Me.ToolStripLabel1.Text = "Filtrar"
        '
        'TxtFiltar
        '
        Me.TxtFiltar.Name = "TxtFiltar"
        Me.TxtFiltar.Size = New System.Drawing.Size(150, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'cboFiltrar
        '
        Me.cboFiltrar.Name = "cboFiltrar"
        Me.cboFiltrar.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Image = CType(resources.GetObject("btnFiltrar.Image"), System.Drawing.Image)
        Me.btnFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(57, 22)
        Me.btnFiltrar.Text = "Filtrar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnLimpar
        '
        Me.btnLimpar.Image = CType(resources.GetObject("btnLimpar.Image"), System.Drawing.Image)
        Me.btnLimpar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(94, 22)
        Me.btnLimpar.Text = "Limpar Filtro"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3, Me.ToolStripSeparator2, Me.btnNovo, Me.btnEditar, Me.btnVisualizar, Me.btnExcluir})
        Me.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(120, 191)
        Me.ToolStrip2.TabIndex = 0
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(118, 15)
        Me.ToolStripLabel3.Text = "Ações"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(118, 6)
        '
        'btnNovo
        '
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(118, 36)
        Me.btnNovo.Text = "Novo Registro"
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(118, 36)
        Me.btnEditar.Text = "Editar Registro"
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Image = CType(resources.GetObject("btnVisualizar.Image"), System.Drawing.Image)
        Me.btnVisualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(118, 36)
        Me.btnVisualizar.Text = "Visualizar"
        '
        'btnExcluir
        '
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(118, 36)
        Me.btnExcluir.Text = "Excluir Registro"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 645)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmPrincipal"
        Me.Text = "Produção - 2012 - Sistema de Produção"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ArquivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelatoriosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FerramentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNovo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExcluir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnVisualizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TxtFiltar As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnFiltrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cboFiltrar As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStrip4 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnLimpar As System.Windows.Forms.ToolStripButton
    Friend WithEvents RelatóriosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnaliticoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SintéticoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusDtHora As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EmbalagensPorVendedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CatalogoPorVendedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EmbalagensPorClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ListagemDeArquivoDeChapasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
End Class
