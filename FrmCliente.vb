Public Class FrmCliente
    Dim IsentoIcms As Boolean
    Dim IsentoCarta As Boolean
    Dim cmdCliente As SqlClient.SqlCommand
    Dim cmdSocio As SqlClient.SqlCommand
    Dim cmdExcluirCliente As SqlClient.SqlCommand
    Dim cmdExibeCliente As SqlClient.SqlCommand
    Dim cmdExibeSocio As SqlClient.SqlCommand
    Dim cmdTel As SqlClient.SqlCommand
    Dim cmdUltimo As SqlClient.SqlCommand
    Dim vl_itemFone As Integer
    Dim vl_itemSocio As Integer
    Dim vl_UFID As Integer
    Dim vl_MunicipID As Integer
    Dim vf_Cliente As Integer
    Dim tp_acao As Integer


    Private Sub FrmCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmPrincipal
        Carrega_Vendedores()
        Carrega_UF()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'FrmEndereco.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'FrmEndereco.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' Grava_Registro()
        VF_FrmFone = 1
        FrmTelefone.Show()

    End Sub

    Private Sub Carrega_Vendedores()

        Dim cmdvendedor As SqlClient.SqlCommand
        cmdvendedor = New SqlClient.SqlCommand("select vendid,nome from vendas.vendedores", Conn)
        cmdvendedor.CommandType = CommandType.Text

        Conn.Open()

        Dim rdvendedor As SqlClient.SqlDataReader = cmdvendedor.ExecuteReader

        Do While rdvendedor.Read()
            CboVendedor.Items.Add(rdvendedor.GetString(1))
        Loop
        rdvendedor.Close()
        Conn.Close()

    End Sub

    Private Sub CboVendedor_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs)
        TxtVendID.Text = CboVendedor.SelectedValue
    End Sub

    Private Sub TxtRazao_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtRazao.LostFocus
        TxtRazao.Text = TxtRazao.Text.ToUpper()
    End Sub

    Private Sub TxtFantasia_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtFantasia.LostFocus
        TxtFantasia.Text = TxtFantasia.Text.ToUpper
    End Sub

    Private Sub Verifica_Checkbox()
        'Verifica box isento icms.
        If ChkIsentoIcms.Checked Then
            IsentoIcms = True
        Else
            IsentoIcms = False
        End If
        'Verifica box isento por carta.
        If ChkIsentoIPI.Checked Then
            IsentoCarta = True
        Else
            IsentoCarta = False
        End If
        'Verifica box Ativado.
        If ChkAtivo.Checked Then
            Ativado = True
        Else
            Ativado = False
        End If

        'Verifica de se é Consumidor Final
        If rdbNConFinal.Checked = True Then
            intIndFinal = 0
        Else
            intIndFinal = 1
        End If

    End Sub

    Private Sub Passa_Param()

        Verifica_Checkbox()

        With cmdCliente
            .Parameters.Add("@CLIENTEID", SqlDbType.Int).Value = TxtID.Text
            .Parameters.Add("@VENDID", SqlDbType.Int).Value = TxtVendID.Text
            .Parameters.Add("@CNPJ", SqlDbType.NVarChar).Value = MskCnpj.Text
            .Parameters.Add("@RAZAO", SqlDbType.NVarChar).Value = TxtRazao.Text
            .Parameters.Add("@FANTASIA", SqlDbType.NVarChar).Value = TxtFantasia.Text
            .Parameters.Add("@INSC_ESTADUAL", SqlDbType.NVarChar).Value = TxtInscEstadual.Text
            .Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = TxtEmail.Text
            .Parameters.Add("@WEBSITE", SqlDbType.NVarChar).Value = TxtWeb.Text
            .Parameters.Add("@CONTATO", SqlDbType.NVarChar).Value = TxtContato.Text
            .Parameters.Add("@FUNCAO_CONTATO", SqlDbType.NVarChar).Value = TxtFuncaoContato.Text
            .Parameters.Add("@MSN", SqlDbType.NVarChar).Value = TxtMsn.Text
            .Parameters.Add("@ICMS_PERCENT", SqlDbType.Decimal).Value = TxtIcms.Text
            .Parameters.Add("@ISENCAO_OFFSET", SqlDbType.Bit).Value = IsentoIcms
            .Parameters.Add("@ISENCAO_CARTA", SqlDbType.Bit).Value = IsentoCarta
            .Parameters.Add("@DATA_VAL_CARTA", SqlDbType.SmallDateTime).Value = DtVal.Text
            .Parameters.Add("@DATA_CAD", SqlDbType.SmallDateTime).Value = DtCad.Text
            .Parameters.Add("@ATIVADO", SqlDbType.Bit).Value = Ativado
            .Parameters.Add("@ENDERECO", SqlDbType.NVarChar).Value = TxtEndereco.Text
            .Parameters.Add("@NUMERO", SqlDbType.Int).Value = TxtNumero.Text
            .Parameters.Add("@BAIRRO", SqlDbType.NVarChar).Value = TxtBairro.Text
            .Parameters.Add("@COMPLEMENTO", SqlDbType.NVarChar).Value = TxtComplemento.Text
            .Parameters.Add("@MUNICIPIO_ID", SqlDbType.Int).Value = vl_MunicipID
            .Parameters.Add("@CIDADE", SqlDbType.NVarChar).Value = CboMunicipio.Text
            .Parameters.Add("@UF_ID", SqlDbType.Int).Value = vl_UFID
            .Parameters.Add("@UF", SqlDbType.NVarChar).Value = CboUF.Text
            .Parameters.Add("@PAIS_ID", SqlDbType.Int).Value = 1058
            .Parameters.Add("@CEP", SqlDbType.NVarChar).Value = TxtCEP.Text
            .Parameters.Add("@END_COB", SqlDbType.NVarChar).Value = TxtEndCob.Text
            .Parameters.Add("@CPF", SqlDbType.NVarChar).Value = TxtCPF.Text
            .Parameters.Add("@IDDest", SqlDbType.Int).Value = TxtCLidDest.Text
            .Parameters.Add("@IndFinal", SqlDbType.Int).Value = intIndFinal
            .Parameters.Add("@IndIEDest", SqlDbType.Int).Value = TxtCLindIEDest.Text
            .Parameters.Add("@ISUF", SqlDbType.NVarChar).Value = TxtIsuf.Text
            .Parameters.Add("@IM", SqlDbType.NVarChar).Value = TxtIm.Text
            .Parameters.Add("Vf_Man", SqlDbType.Int).Value = Vf_Man
        End With


    End Sub
    Private Sub Exibe_Cliente()

        '*********************************************************************************************
        'Autor       : Carlos Mioto
        'Rotina      : Exibir dados do cliente.
        'Criada em   : 30/04/2011
        'Alterada em : 30/03/2015 
        'Descrição   : Incluidas novos campos para adeguar ao novo lay-out XML 3.10 da NF-e.
        '*********************************************************************************************

        Try

            Conn.Open()

            cmdExibeCliente = New SqlClient.SqlCommand("Vendas.SPExibir_Cliente", Conn)
            cmdExibeCliente.CommandType = CommandType.StoredProcedure
            cmdExibeCliente.Parameters.Add("@ClienteID", SqlDbType.Int).Value = ClienteID
            cmdExibeCliente.Parameters.Add("@CNPJ", SqlDbType.NVarChar).Value = MskCnpj.Text
            cmdExibeCliente.Parameters.Add("@CPF", SqlDbType.NVarChar).Value = TxtCPF.Text
            cmdExibeCliente.Parameters.Add("@VF_BUSCA", SqlDbType.Int).Value = VF_Busca


            Dim rdExibeCliente As SqlClient.SqlDataReader = cmdExibeCliente.ExecuteReader

            'Lendo o Reader

            rdExibeCliente.Read()

            Select Case VF_Busca
                Case 0
                    MskCnpj.Text = rdExibeCliente.GetString(0)
                Case 1
                    TxtID.Text = rdExibeCliente.GetInt32(0)
                Case 2
                    TxtID.Text = rdExibeCliente.GetInt32(0)
            End Select

            TxtRazao.Text = rdExibeCliente.GetString(1)
            TxtFantasia.Text = rdExibeCliente.GetString(2)
            TxtInscEstadual.Text = rdExibeCliente.GetString(3)
            TxtVendID.Text = rdExibeCliente.GetInt32(4)
            CboVendedor.Text = rdExibeCliente.GetString(5)
            TxtEndereco.Text = rdExibeCliente.GetString(6)
            TxtNumero.Text = rdExibeCliente.GetInt32(7)
            TxtBairro.Text = rdExibeCliente.GetString(8)
            TxtComplemento.Text = rdExibeCliente.GetString(9)
            CboMunicipio.Text = rdExibeCliente.GetString(10)
            CboUF.Text = rdExibeCliente.GetString(11)
            TxtCEP.Text = rdExibeCliente.GetString(12)
            TxtEndCob.Text = rdExibeCliente.GetString(13)
            DtCad.Text = rdExibeCliente.GetDateTime(14)
            TxtEmail.Text = rdExibeCliente.GetString(15)
            TxtWeb.Text = rdExibeCliente.GetString(16)
            TxtContato.Text = rdExibeCliente.GetString(17)
            TxtFuncaoContato.Text = rdExibeCliente.GetString(18)
            TxtMsn.Text = rdExibeCliente.GetString(19)
            TxtIcms.Text = rdExibeCliente.GetDecimal(20)
            ChkIsentoIcms.Checked = rdExibeCliente.GetBoolean(21)
            ChkIsentoIPI.Checked = rdExibeCliente.GetBoolean(22)
            DtVal.Text = rdExibeCliente.GetDateTime(23)
            ChkAtivo.Checked = rdExibeCliente.GetBoolean(24)
            Select Case VF_Busca
                Case 0
                    TxtCPF.Text = rdExibeCliente.GetSqlString(28)
                Case 1
                    TxtCPF.Text = rdExibeCliente.GetSqlString(28)
                Case 2
                    MskCnpj.Text = rdExibeCliente.GetSqlString(28)
            End Select
            TxtCLidDest.Text = rdExibeCliente.GetSqlInt32(29)
            intIndFinal = rdExibeCliente.GetSqlInt32(30)
            TxtCLindIEDest.Text = rdExibeCliente.GetSqlInt32(31)
            TxtIsuf.Text = rdExibeCliente.GetSqlString(32)
            TxtIm.Text = rdExibeCliente.GetSqlString(33)

            Conn.Close()

            tp_acao = 1

            Busca_ID_UF()
            Busca_Municipio_ID()

            GroupBox3.Enabled = True

            Select Case TxtCLidDest.Text
                Case 1
                    CboidDest.Text = "Operação Interna"
                Case 2
                    CboidDest.Text = "Operação Interestadual"
                Case 3
                    CboidDest.Text = "Exterior"
            End Select

            Select Case intIndFinal
                Case 0
                    rdbNConFinal.Checked = True
                Case 1
                    rdbConFinal.Checked = True
            End Select


            Select Case TxtCLindIEDest.Text
                Case 1
                    CboindIEDest.Text = "Contribuinte do ICMS"
                Case 2
                    CboindIEDest.Text = "ISENTO"
                Case 9
                    CboindIEDest.Text = "Não Contribuinte (Pessoas Fisicas)"
            End Select

        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            tp_acao = 0
            Exit Sub
        End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Removendo telefone

        cmdTel = New SqlClient.SqlCommand("delete From Vendas.Cliente_Fone Where Clienteid=" & ClienteID & " and id_fone=" & vl_itemFone & " ", Conn)
        cmdTel.CommandType = CommandType.Text
        Conn.Open()
        cmdTel.ExecuteNonQuery()
        Conn.Close()
        ListView1.Items.Clear()
        Listar.Listar_Telefones()
    End Sub

    Private Sub ListView1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseClick
        vl_itemFone = ListView1.SelectedItems(0).Text
    End Sub

    Private Sub Exibe_Socio()
        Conn.Open()

        cmdExibeSocio = New SqlClient.SqlCommand("Vendas.SPExibe_Socio", Conn)
        cmdExibeSocio.CommandType = CommandType.StoredProcedure

        cmdExibeSocio.Parameters.Add("@ClienteID", SqlDbType.Int).Value = ClienteID
        cmdExibeSocio.Parameters.Add("@ID_Socio", SqlDbType.Int).Value = vl_itemSocio

        Dim rdExibeSocio As SqlClient.SqlDataReader = cmdExibeSocio.ExecuteReader

        'Lendo o Reader
        rdExibeSocio.Read()
        TxtCPFSocio.Text = rdExibeSocio.GetString(0)
        TxtRgSocio.Text = rdExibeSocio.GetString(1)
        TxtNomeSocio.Text = rdExibeSocio.GetString(2)
        TxtEnderecoSocio.Text = rdExibeSocio.GetString(3)
        TxtCidadeSocio.Text = rdExibeSocio.GetString(4)
        CboUFSocio.Text = rdExibeSocio.GetString(5)
        TxtfoneSocio.Text = rdExibeSocio.GetString(6)
        TxtCelularSocio.Text = rdExibeSocio.GetString(7)
        DtNascSocio.Text = rdExibeSocio.GetDateTime(8)
        CboCivil.Text = rdExibeSocio.GetString(9)
        TxtNomeConj.Text = rdExibeSocio.GetString(10)
        TxtRgConj.Text = rdExibeSocio.GetString(11)
        TxtCpfConj.Text = rdExibeSocio.GetString(12)

        Conn.Close()

    End Sub

    Private Sub ListViewSocio_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListViewSocio.MouseClick
        vl_itemSocio = ListViewSocio.SelectedItems.Item(0).Text
        TxtIdSocio.Text = vl_itemSocio
        Exibe_Socio()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Adiciona Socio
        Try
            'Declara um SQLCommand

            cmdSocio = New SqlClient.SqlCommand("SPIncluir_Socio", Conn)
            cmdSocio.CommandType = CommandType.StoredProcedure

            'Passando Parametros
            Passar_ParamSocio()

            Conn.Open()
            cmdSocio.ExecuteNonQuery()
            Conn.Close()

            Listar.Lista_Socios()

            Exit Sub

        Catch ex As Exception

            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try

    End Sub

    Private Sub Passar_ParamSocio()
        With cmdSocio
            .Parameters.Add("@ID_SOCIO", SqlDbType.Int).Value = TxtIdSocio.Text
            .Parameters.Add("@CPF", SqlDbType.NVarChar).Value = TxtCPFSocio.Text
            .Parameters.Add("@RG", SqlDbType.NVarChar).Value = TxtRgSocio.Text
            .Parameters.Add("@NOME", SqlDbType.NVarChar).Value = TxtNomeSocio.Text
            .Parameters.Add("@ENDERECO", SqlDbType.NVarChar).Value = TxtEnderecoSocio.Text
            .Parameters.Add("@CIDADE", SqlDbType.NVarChar).Value = TxtCidadeSocio.Text
            .Parameters.Add("@UF", SqlDbType.NVarChar).Value = CboUFSocio.Text
            .Parameters.Add("@CIVIL", SqlDbType.NChar).Value = CboCivil.Text
            .Parameters.Add("@DATA_NASC", SqlDbType.SmallDateTime).Value = DtNascSocio.Text
            .Parameters.Add("@FONE", SqlDbType.NVarChar).Value = TxtfoneSocio.Text
            .Parameters.Add("@CELULAR", SqlDbType.NVarChar).Value = TxtCelularSocio.Text
            .Parameters.Add("@CPF_CONJ", SqlDbType.NVarChar).Value = TxtCpfConj.Text
            .Parameters.Add("@RG_CONJ", SqlDbType.NVarChar).Value = TxtRgConj.Text
            .Parameters.Add("@NOME_CONJUGE", SqlDbType.NVarChar).Value = TxtNomeConj.Text
        End With

    End Sub

    Private Sub Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StripBtnNovo.Click
        'Novo Registro
        Conn.Open()
        cmdUltimo = New SqlClient.SqlCommand("Vendas.SPUltimo_Cliente", Conn)
        cmdUltimo.CommandType = CommandType.StoredProcedure

        Dim rdUltimo As SqlClient.SqlDataReader = cmdUltimo.ExecuteReader
        'Lendo o Reader
        rdUltimo.Read()
        Me.TxtID.Text = rdUltimo.GetInt32(0) + 1
        ClienteID = TxtID.Text
        'Limpando os campos

        MskCnpj.Text = ""
        TxtCPF.Text = ""
        TxtRazao.Text = ""
        TxtFantasia.Text = ""
        TxtInscEstadual.Text = ""
        TxtVendID.Text = ""
        CboVendedor.Text = ""
        TxtEndereco.Text = ""
        TxtNumero.Text = ""
        TxtBairro.Text = ""
        TxtComplemento.Text = ""
        CboMunicipio.Text = ""
        CboUF.Text = ""
        TxtCEP.Text = ""
        TxtEndCob.Text = ""
        DtCad.Text = ""
        TxtEmail.Text = ""
        TxtWeb.Text = ""
        TxtContato.Text = ""
        TxtFuncaoContato.Text = ""
        TxtMsn.Text = ""
        TxtIcms.Text = "0,00"
        ChkIsentoIcms.Checked = False
        ChkIsentoIPI.Checked = False
        ChkAtivo.Checked = True
        DtVal.Text = Today
        TxtCLidDest.Text = ""
        CboidDest.Text = ""
        TxtCLindIEDest.Text = ""
        rdbConFinal.Checked = False
        rdbNConFinal.Checked = True
        intIndFinal = 0
        CboindIEDest.Text = ""
        TxtIsuf.Text = ""
        TxtIm.Text = ""
        ListView1.Items.Clear()

        GroupBox3.Enabled = False

        Conn.Close()

    End Sub

    Private Sub ToolStripButton30_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton30.Click
        tp_acao = 0
        Grava_Registro()
        ClienteID = TxtID.Text
        GroupBox3.Enabled = True
    End Sub

    Private Sub ToolStripButton31_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton31.Click

        tp_acao = 1
        ClienteID = TxtID.Text

        'Altera Registro
        Vf_Man = 2

        'Validação do campo e-mail.

        If TxtEmail.Text = "" Then
            MsgBox("E-mail é obrigatório.", MsgBoxStyle.Critical)
            TxtEmail.Focus()
            Exit Sub
        End If

        Try
            'Declara um SQLCommand

            cmdCliente = New SqlClient.SqlCommand("Vendas.usp_Cliente_Man", Conn)
            cmdCliente.CommandType = CommandType.StoredProcedure

            'Passando Parametros
            Passa_Param()

            Conn.Open()
            cmdCliente.ExecuteNonQuery()
            Conn.Close()

            MsgBox("Registro alterado com sucesso.", MsgBoxStyle.Information)

            Exit Sub

        Catch ex As Exception

            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try

    End Sub

    Private Sub ToolStripButton32_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton32.Click
        'Exclusao de Registro
        Try
            cmdCliente = New SqlClient.SqlCommand("SPExcluir_Cliente", Conn)

            cmdCliente.CommandType = CommandType.StoredProcedure

            With cmdExcluirCliente
                .Parameters.Add("@ClienteId", SqlDbType.Int)
                .Parameters("@clienteId").Value = TxtID.Text
            End With

            Conn.Open()

            If MsgBox("A exclusão do cliente eliminará TODOS os registros assossiados.Deseja realmente excluir o registro corrente?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then
                cmdExcluirCliente.ExecuteNonQuery()
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("ERRO: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try
        MsgBox("Registro(s) excluido(s) com sucesso.", MsgBoxStyle.Information)
        Conn.Close()

    End Sub

    Private Sub ToolStripButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton14.Click
        'FrmPrincipal.Panel1.Visible = True
    End Sub


    Private Sub CboVendedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboVendedor.SelectedIndexChanged

        Dim cmdvendedorID As SqlClient.SqlCommand
        cmdvendedorID = New SqlClient.SqlCommand("select vendid from vendas.vendedores where nome='" & CboVendedor.Text & "'", Conn)
        cmdvendedorID.CommandType = CommandType.Text

        'Verifica se a conexão já está aberta
        If Conn.State = ConnectionState.Open Then
            Exit Sub
        End If

        Conn.Open()

        Dim rdvendedorID As SqlClient.SqlDataReader = cmdvendedorID.ExecuteReader

        rdvendedorID.Read()
        TxtVendID.Text = rdvendedorID.GetInt32(0)
        rdvendedorID.Close()

        Conn.Close()
    End Sub

    Private Sub Carrega_UF()
        Dim cmdUF As SqlClient.SqlCommand
        cmdUF = New SqlClient.SqlCommand("select sigla from gerenciador.uf", Conn)
        cmdUF.CommandType = CommandType.Text

        Conn.Open()

        Dim rduf As SqlClient.SqlDataReader = cmdUF.ExecuteReader

        Do While rduf.Read()
            CboUF.Items.Add(rduf.GetString(0))
        Loop
        rduf.Close()
        Conn.Close()

    End Sub

    Private Sub CboUF_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboUF.LostFocus

        'Busca o código do estado 
        Busca_ID_UF()
        'Carrega o combo com os municipios referente ao estado selecionado.
        CboMunicipio.Items.Clear()
        Dim cmdMunicip As SqlClient.SqlCommand
        cmdMunicip = New SqlClient.SqlCommand("select Municipio from gerenciador.municipios where uf='" & CboUF.Text & "'", Conn)
        cmdMunicip.CommandType = CommandType.Text

        Conn.Open()

        Dim rdMunicip As SqlClient.SqlDataReader = cmdMunicip.ExecuteReader

        Do While rdMunicip.Read()
            CboMunicipio.Items.Add(rdMunicip.GetString(0))
        Loop
        rdMunicip.Close()
        Conn.Close()

    End Sub
    Private Sub Carrega_Telefone()

        Me.ListView1.Items.Clear()
        Dim cmdtelefone = New SqlClient.SqlCommand("select id_fone,ddd,telefone,ramal,tipo from vendas.cliente_fone where clienteid='" & TxtID.Text & "'", Conn)
        cmdtelefone.CommandType = CommandType.Text

        Conn.Open()
        Dim rdtelefone As SqlClient.SqlDataReader = cmdtelefone.ExecuteReader

        'Carrega o listview

        While rdtelefone.Read
            Dim codigo As String = rdtelefone.Item(0)
            Dim Ls As New ListViewItem(codigo, 1)
            Ls.SubItems.Add(rdtelefone.Item(1))
            Ls.SubItems.Add(rdtelefone.Item(2))
            Ls.SubItems.Add(rdtelefone.Item(3))
            Ls.SubItems.Add(rdtelefone.Item(4))

            ListView1.Items.Add(Ls)
        End While

        rdtelefone.Close()
        Conn.Close()

    End Sub

    Private Sub CboMunicipio_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboMunicipio.LostFocus
        Try

            Dim cmdMunicip As SqlClient.SqlCommand
            cmdMunicip = New SqlClient.SqlCommand("select Municipio_ID from gerenciador.municipios where MUNICIPIO='" & CboMunicipio.Text & "' AND UF='" & CboUF.Text & "'", Conn)
            cmdMunicip.CommandType = CommandType.Text

            Conn.Open()

            Dim rdMunicip As SqlClient.SqlDataReader = cmdMunicip.ExecuteReader

            rdMunicip.Read()
            vl_MunicipID = rdMunicip.GetInt32(0)
            rdMunicip.Close()
            Conn.Close()

        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try

    End Sub

    Private Sub Busca_ID_UF()
        Try

            'Busca o código do estado 
            Dim cmdUF As SqlClient.SqlCommand
            cmdUF = New SqlClient.SqlCommand("select id_uf from gerenciador.uf Where sigla='" & CboUF.Text & "'", Conn)
            cmdUF.CommandType = CommandType.Text

            Conn.Open()

            Dim rduf As SqlClient.SqlDataReader = cmdUF.ExecuteReader

            rduf.Read()
            vl_UFID = rduf.GetInt32(0)

            rduf.Close()
            Conn.Close()

        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try

    End Sub
    Public Sub Busca_Municipio_ID()
        Try
            Dim cmdMunicip_ID As SqlClient.SqlCommand
            cmdMunicip_ID = New SqlClient.SqlCommand("select Municipio_ID from gerenciador.municipios where municipio='" & CboMunicipio.Text & "'", Conn)
            cmdMunicip_ID.CommandType = CommandType.Text

            Conn.Open()

            Dim rdMunicip_ID As SqlClient.SqlDataReader = cmdMunicip_ID.ExecuteReader

            rdMunicip_ID.Read()
            vl_MunicipID = rdMunicip_ID.GetInt32(0)

            rdMunicip_ID.Close()

            Conn.Close()

        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try

    End Sub
    Private Sub MskCnpj_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MskCnpj.KeyPress

        '**********************************************************************************
        'Autor       : Carlos Mioto
        'Rotina      : Localizar cadastro por CNPJ.
        'Criada em   : 30/04/2011
        'Alterada em : 09/11/2013 
        'Decrição    : Alterada a variável de tipo de busca de vf_cliente p/ VF_Busca. 
        '**********************************************************************************
        VF_Busca = 1
        ClienteID = 0

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            Try

                Exibe_Cliente()
                Carrega_Telefone()
                Listar.Lista_Socios()

            Catch ex As Exception
                MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
                Conn.Close()
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub TxtID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtID.KeyPress
        '**********************************************************************************
        'Autor       : Carlos Mioto
        'Rotina      : Localizar cadastro por ID.
        'Criada em   : 30/04/2011
        'Alterada em : 09/11/2013 
        'Decrição    : Alterada a variável de tipo de busca de vf_cliente p/ VF_Busca. 
        '**********************************************************************************
        VF_Busca = 0

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            Try
                ClienteID = TxtID.Text
                Exibe_Cliente()
                Carrega_Telefone()
                Listar.Lista_Socios()

            Catch ex As Exception
                MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
                Conn.Close()
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub Grava_Registro()

        If tp_acao = 1 Then Exit Sub


        'Grava Registro
        Vf_Man = 1

        'Validação do campo e-mail.

        If TxtEmail.Text = "" Then
            MsgBox("E-mail é obrigatório.", MsgBoxStyle.Critical)
            TxtEmail.Focus()
            Exit Sub
        End If

        Try
            'Declara um SQLCommand

            cmdCliente = New SqlClient.SqlCommand("vendas.usp_Cliente_Man", Conn)
            cmdCliente.CommandType = CommandType.StoredProcedure

            'Passando Parametros
            Passa_Param()

            Conn.Open()
            cmdCliente.ExecuteNonQuery()
            Conn.Close()

            MsgBox("Registro Gravado com Sucesso.", MsgBoxStyle.Information)

            Exit Sub

        Catch ex As Exception

            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try

    End Sub

    Private Sub TxtCPF_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCPF.KeyPress
        '**********************************************************************************
        'Autor       : Carlos Mioto
        'Rotina      : Localizar cadastro por CPF.
        'Criada em   : 30/04/2011
        'Alterada em : 09/11/2013 
        'Decrição    : Alterada a variável de tipo de busca de vf_cliente p/ VF_Busca. 
        '**********************************************************************************
        VF_Busca = 2
        ClienteID = 0

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            Try
                Exibe_Cliente()
                Carrega_Telefone()
                Listar.Lista_Socios()

            Catch ex As Exception
                MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
                Conn.Close()
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub CboidDest_LostFocus(sender As Object, e As EventArgs) Handles CboidDest.LostFocus
        Select Case CboidDest.Text
            Case "Operação Interna"
                TxtCLidDest.Text = 1
            Case "Operação Interestadual"
                TxtCLidDest.Text = 2
            Case "Operação Exterior"
                TxtCLidDest.Text = 3
        End Select
    End Sub

    Private Sub CboindIEDest_LostFocus(sender As Object, e As EventArgs) Handles CboindIEDest.LostFocus
        Select Case CboindIEDest.Text
            Case "Contribuinte do ICMS"
                TxtCLindIEDest.Text = 1
            Case "ISENTO"
                TxtCLindIEDest.Text = 2
            Case "Não Contribuinte (Pessoas Fisicas)"
                TxtCLindIEDest.Text = 9
        End Select
    End Sub
End Class