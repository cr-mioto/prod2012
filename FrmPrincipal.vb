Public Class FrmPrincipal

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
        End
    End Sub

    Private Sub TreeView1_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseDoubleClick
        'Limpando o combo Filtrar
        cboFiltrar.Text = ""
        cboFiltrar.Items.Clear()
        'Define se o listview é filtrado ou não 0-não 1-sim.
        intFiltro = 0
        strFiltrar = ""

        'Seleciona cadastro de Maquinas
        If TreeView1.SelectedNode.Name = "Maq" Then
            Item_Menu = 1
            Listar_Principal()
        End If

        'Seleciona cadastro de Operadores
        If TreeView1.SelectedNode.Name = "Oper" Then
            Item_Menu = 2
            Listar_Principal()
        End If

        'Seleciona cadastro de Tipos de Movimento
        If TreeView1.SelectedNode.Name = "TpMov" Then
            Item_Menu = 3
            Listar_Principal()
        End If

        'Seleciona cadastro de Grupos
        If TreeView1.SelectedNode.Name = "Grp" Then
            Item_Menu = 4
            Listar_Principal()
        End If

        'Seleciona cadastro de Materiais
        If TreeView1.SelectedNode.Name = "Mat" Then
            Item_Menu = 5
            Listar_Principal()
        End If

        'Seleciona cadastro de Setor
        If TreeView1.SelectedNode.Name = "Setor" Then
            Item_Menu = 6
            Listar_Principal()
        End If
        'Seleciona cadastro de Tipos de Facas
        If TreeView1.SelectedNode.Name = "TiposFacas" Then
            Item_Menu = 7
            Listar_Principal()
        End If
        'Seleciona cadastro de Tipos de Facas
        If TreeView1.SelectedNode.Name = "Facas" Then
            Item_Menu = 8
            Listar_Principal()
            mdFiltro_Principal.Carrega_Combo()
        End If
        'Seleciona cadastro de Acabamento
        If TreeView1.SelectedNode.Name = "Acab" Then
            Item_Menu = 9
            Listar_Principal()
        End If
        'Seleciona Manutenção de Fichas de Produção
        If TreeView1.SelectedNode.Name = "FichaProd" Then
            Item_Menu = 10
            Listar_Principal()
            mdFiltro_Principal.Carrega_Combo()
        End If
        'Seleciona Manutenção de Produção das Maquinas.
        If TreeView1.SelectedNode.Name = "Servico" Then
            Item_Menu = 11
            Listar_Principal()
            mdFiltro_Principal.Carrega_Combo()
        End If
        'Seleciona cadastro de Maquinas
        If TreeView1.SelectedNode.Name = "Embalagens" Then
            Item_Menu = 12
            Listar_Principal()
            mdFiltro_Principal.Carrega_Combo()
        End If

        'Seleciona cadastro de Usuários
        If TreeView1.SelectedNode.Name = "nUsuarios" Then
            If intNivel <> 1 Then
                MsgBox("Usuário sem permissão para acessar este recurso.", vbExclamation)
                Exit Sub
            End If
            Item_Menu = 13
            Listar_Principal()
            ' mdFiltro_Principal.Carrega_Combo()
        End If

    End Sub

  
    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        intAC = 1
        MdProg.Forms()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        intAC = 2
        MdProg.Forms()
    End Sub

    Private Sub btnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizar.Click
        intAC = 3
        MdProg.Forms()
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        intAC = 4
        MdProg.Forms()
    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        intID_Entrada = ListView1.SelectedItems.Item(0).Text
    End Sub

    
    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        'Verifica se o campo está vazio.

        If cboFiltrar.Text = "Período" Then
            'Não faça nada.
        Else
            If TxtFiltar.Text = "" Then
                MsgBox("Informe valor.", MsgBoxStyle.Information)
                TxtFiltar.Select()
            End If
        End If

        Select Case Item_Menu
            Case 8
                If cboFiltrar.Text = "ID" Then
                    strFiltrar = TxtFiltar.Text
                    'Define se o listview é filtrado ou não 0-não 1-sim.
                    intFiltro = 1
                    mdFiltro_Principal.Filtrar()
                Else
                    strFiltrar = TxtFiltar.Text + "%"
                    'Define se o listview é filtrado ou não 0-não 1-sim.
                    intFiltro = 1
                    mdFiltro_Principal.Filtrar()
                End If

            Case 10

                Select Case cboFiltrar.Text
                    Case Is = "ID"
                        strFiltrar = TxtFiltar.Text
                        'Define se o listview é filtrado ou não 0-não 1-sim.
                        intFiltro = 1
                        mdFiltro_Principal.Filtrar()
                    Case Is = "Cod.Embalagem"
                        strFiltrar = TxtFiltar.Text
                        'Define se o listview é filtrado ou não 0-não 1-sim.
                        intFiltro = 1
                        mdFiltro_Principal.Filtrar()
                    Case Is = "Cod.Cliente"
                        strFiltrar = TxtFiltar.Text
                        'Define se o listview é filtrado ou não 0-não 1-sim.
                        intFiltro = 1
                        mdFiltro_Principal.Filtrar()
                    Case Is = "Cod.Vendedor"
                        strFiltrar = TxtFiltar.Text
                        'Define se o listview é filtrado ou não 0-não 1-sim.
                        intFiltro = 1
                        mdFiltro_Principal.Filtrar()
                    Case Is = "Período"
                        intFiltro = 1
                        FrmInterval.Show()
                        'mdFiltro_Principal.Filtrar()
                    Case Else
                End Select

            Case 11
                strFiltrar = TxtFiltar.Text
                intFiltro = 1
                mdFiltro_Principal.Filtrar()

            Case 12

                Select Case cboFiltrar.Text
                    Case Is = "ID"
                        strFiltrar = TxtFiltar.Text
                        'Define se o listview é filtrado ou não 0-não 1-sim.
                        intFiltro = 1
                        mdFiltro_Principal.Filtrar()
                    Case Is = "Nome da Embalagem"
                        strFiltrar = TxtFiltar.Text + "%"
                        'Define se o listview é filtrado ou não 0-não 1-sim.
                        intFiltro = 1
                        mdFiltro_Principal.Filtrar()
                    Case Is = "Cod.Cliente"
                        strFiltrar = TxtFiltar.Text
                        'Define se o listview é filtrado ou não 0-não 1-sim.
                        intFiltro = 1
                        mdFiltro_Principal.Filtrar()
                    Case Is = "Cod.Vendedor"
                        strFiltrar = TxtFiltar.Text
                        'Define se o listview é filtrado ou não 0-não 1-sim.
                        intFiltro = 1
                        mdFiltro_Principal.Filtrar()
                    Case Is = "Medida da Embalagem"
                        strFiltrar = TxtFiltar.Text + "%"
                        'Define se o listview é filtrado ou não 0-não 1-sim.
                        intFiltro = 1
                        mdFiltro_Principal.Filtrar()
                    Case Else

                End Select

        End Select


    End Sub

    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        'Define se o listview é filtrado ou não 0-não 1-sim.
        intFiltro = 0
        TxtFiltar.Text = ""
        cboFiltrar.Text = ""
        Listar_Principal()
    End Sub


    Private Sub AnaliticoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnaliticoToolStripMenuItem.Click
        VF_Report = 1
        Titulo_Janela = "Relatório Análitico de Produção. Versão 1.00 (ProdMaquinas.rdl)"
        FrmReports.Show()
    End Sub

    Private Sub SintéticoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SintéticoToolStripMenuItem.Click
        VF_Report = 2
        Titulo_Janela = "Relatório Sintético de Produção. Versão 1.00 (RptProducao_Sintec.rdl)"
        FrmReports.Show()
    End Sub

    Private Sub FrmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Verifica o nivel de acesso do usuário.
        'Se for 1 - Todos os botões de ação estarão ativos.
        'Se for 2 - Somente os botões de ação Editar/Visualizar/Excluir.
        'Se for 3 - Somente os botões de ação Editar/Visualizar.
        'Se for 4 - Somente o botão de ação Visualizar.

        'Define o valor padrão para as variáveis De/Ate.
        dtDe = FormatDateTime(Today, DateFormat.ShortDate)
        dtAte = FormatDateTime(Today, DateFormat.ShortDate)


        Select Case intNivel
            Case 1
                'Acesso total 
            Case 2
                btnNovo.Visible = False

            Case 3
                btnNovo.Visible = False
                btnExcluir.Visible = False
            Case 4
                btnNovo.Visible = False
                btnEditar.Visible = False
                btnExcluir.Visible = False
        End Select

        'Carrega informações do usuário na barra de status da aplicação.
        StatusUser.Text = "Usuário: " & strNome
        StatusDtHora.Text = "Data: " & Today & " " & "Hora: " & TimeOfDay()
    End Sub

    Private Sub EmbalagensPorVendedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmbalagensPorVendedorToolStripMenuItem.Click
        VF_Report = 4
        Titulo_Janela = "Relatório de Embalagens por Vendedor. Versão 1.00 (Embalagens.rdl)"
        FrmReports.Show()
    End Sub

    Private Sub CatalogoPorVendedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatalogoPorVendedorToolStripMenuItem.Click
        VF_Report = 5
        Titulo_Janela = "Catalogo de Fotos por Vendedor. Versão 1.00 (Catalogo.rdl)"
        FrmReports.Show()
    End Sub
    Private Sub EmbalagensPorClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmbalagensPorClienteToolStripMenuItem.Click
        VF_Report = 6
        Titulo_Janela = "Relatório de Embalagens por Cliente/Período. Versão 1.00 (Ficha_Cliente.rdl)"
        FrmReports.Show()
    End Sub

    Private Sub ListagemDeArquivoDeChapasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListagemDeArquivoDeChapasToolStripMenuItem.Click
        VF_Report = 7
        Titulo_Janela = "Listagem do Arquivo de Chapas. Versão 1.00 (Arquivo_Chapas.rdl)"
        FrmReports.Show()
    End Sub

    
End Class