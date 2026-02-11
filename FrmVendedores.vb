Public Class FrmVendedores
    Dim vl_UFID As Integer
    Dim cmdVendedor As SqlClient.SqlCommand
    Dim cmdUltimo As SqlClient.SqlCommand
    Dim cmdExibeVend As SqlClient.SqlCommand
    Dim cmdTel As SqlClient.SqlCommand
    Dim vl_itemFone As Integer
    Dim VF_Man As Integer
    Private Sub FrmVendedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmPrincipal
        Carrega_UF()
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
        Dim cmdUF As SqlClient.SqlCommand
        cmdUF = New SqlClient.SqlCommand("select id_uf from gerenciador.uf Where sigla='" & CboUF.Text & "'", Conn)
        cmdUF.CommandType = CommandType.Text

        Conn.Open()

        Dim rduf As SqlClient.SqlDataReader = cmdUF.ExecuteReader

        rduf.Read()
        vl_UFID = rduf.GetInt32(0)

        rduf.Close()
        Conn.Close()

        'Carrega o combo com os municipios referente ao estado selecionado.
        CboMunicip.Items.Clear()
        Dim cmdMunicip As SqlClient.SqlCommand
        cmdMunicip = New SqlClient.SqlCommand("select Municipio from gerenciador.municipios where uf='" & CboUF.Text & "'", Conn)
        cmdMunicip.CommandType = CommandType.Text

        Conn.Open()

        Dim rdMunicip As SqlClient.SqlDataReader = cmdMunicip.ExecuteReader

        Do While rdMunicip.Read()
            CboMunicip.Items.Add(rdMunicip.GetString(0))
        Loop
        rdMunicip.Close()
        Conn.Close()

    End Sub
    Private Sub Passa_Param()

        With cmdVendedor
            .Parameters.Add("@VENDID", SqlDbType.Int).Value = TxtVendID.Text
            .Parameters.Add("@CNPJ", SqlDbType.NVarChar).Value = MskCnpj.Text
            .Parameters.Add("@CPF", SqlDbType.NVarChar).Value = TxtCPF.Text
            .Parameters.Add("@RG", SqlDbType.NVarChar).Value = TxtRg.Text
            .Parameters.Add("@Nome", SqlDbType.NVarChar).Value = TxtNome.Text
            .Parameters.Add("@RAZAO", SqlDbType.NVarChar).Value = TxtRazao.Text
            .Parameters.Add("@FANTASIA", SqlDbType.NVarChar).Value = TxtFantasia.Text
            .Parameters.Add("@INSC_ESTADUAL", SqlDbType.NVarChar).Value = TxtInscEstadual.Text
            .Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = TxtEmail.Text
            .Parameters.Add("@URL", SqlDbType.NVarChar).Value = TxtWeb.Text
            .Parameters.Add("@MSN", SqlDbType.NVarChar).Value = TxtMsn.Text
            .Parameters.Add("@DATA_CAD", SqlDbType.SmallDateTime).Value = DtCad.Text
            .Parameters.Add("@ENDERECO", SqlDbType.NVarChar).Value = TxtEndereco.Text
            .Parameters.Add("@NUMERO", SqlDbType.Int).Value = TxtNumero.Text
            .Parameters.Add("@BAIRRO", SqlDbType.NVarChar).Value = TxtBairro.Text
            .Parameters.Add("@COMPLEMENTO", SqlDbType.NVarChar).Value = TxtComplemento.Text
            .Parameters.Add("@CIDADE", SqlDbType.NVarChar).Value = CboMunicip.Text
            .Parameters.Add("@UF", SqlDbType.NVarChar).Value = CboUF.Text
            .Parameters.Add("@CEP", SqlDbType.NVarChar).Value = TxtCEP.Text
            .Parameters.Add("Vf_Man", SqlDbType.Int).Value = VF_Man
        End With

    End Sub

    Private Sub ToolStripButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton15.Click

        'Novo Registro

        Conn.Open()

        cmdUltimo = New SqlClient.SqlCommand("Select MAX(VendId)as UltimoId from Vendas.Vendedores", Conn)
        cmdUltimo.CommandType = CommandType.Text

        Dim rdUltimo As SqlClient.SqlDataReader = cmdUltimo.ExecuteReader
        'Lendo o Reader
        rdUltimo.Read()

        Me.TxtVendID.Text = rdUltimo.GetInt32(0) + 1

        'Limpando os campos

        MskCnpj.Text = ""
        TxtCPF.Text = ""
        TxtRg.Text = ""
        TxtNome.Text = ""
        TxtRazao.Text = ""
        TxtFantasia.Text = ""
        TxtInscEstadual.Text = ""
        TxtEndereco.Text = ""
        TxtNumero.Text = ""
        TxtBairro.Text = ""
        TxtComplemento.Text = ""
        CboMunicip.Text = ""
        CboUF.Text = ""
        TxtCEP.Text = ""
        DtCad.Text = ""
        TxtEmail.Text = ""
        TxtWeb.Text = ""
        TxtMsn.Text = ""

        ListView1.Items.Clear()

        Conn.Close()

    End Sub

    Private Sub ToolStripButton30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton30.Click
        'Grava Registro
        VF_Man = 1
        Try
            'Declara um SQLCommand

            cmdVendedor = New SqlClient.SqlCommand("vendas.usp_Vendedor_Man", Conn)
            cmdVendedor.CommandType = CommandType.StoredProcedure

            'Passando Parametros
            Passa_Param()

            Conn.Open()
            cmdVendedor.ExecuteNonQuery()
            Conn.Close()

            MsgBox("Registro Gravado com Sucesso.", MsgBoxStyle.Information)

            Exit Sub

        Catch ex As Exception

            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try

    End Sub

    Private Sub ToolStripButton31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton31.Click
        'Altera Registro
        VF_Man = 2
        Try
            'Declara um SQLCommand

            cmdVendedor = New SqlClient.SqlCommand("Vendas.usp_Vendedor_Man", Conn)
            cmdVendedor.CommandType = CommandType.StoredProcedure

            'Passando Parametros
            Passa_Param()

            Conn.Open()
            cmdVendedor.ExecuteNonQuery()
            Conn.Close()

            MsgBox("Registro alterado com sucesso.", MsgBoxStyle.Information)

            Exit Sub

        Catch ex As Exception

            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try

    End Sub

    Private Sub TxtVendID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtVendID.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            Try
                VendID = TxtVendID.Text
                Exibe_Vendedor()
                Carrega_Telefone()

            Catch ex As Exception
                MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
                Conn.Close()
                Exit Sub
            End Try
        End If

    End Sub
    Private Sub Exibe_Vendedor()

        Conn.Open()

        cmdExibeVend = New SqlClient.SqlCommand("Vendas.usp_Exibe_Vendedor", Conn)
        cmdExibeVend.CommandType = CommandType.StoredProcedure

        cmdExibeVend.Parameters.Add("@VendID", SqlDbType.Int).Value = TxtVendID.Text

        Dim rdExibeVend As SqlClient.SqlDataReader = cmdExibeVend.ExecuteReader

        'Lendo o Reader

        rdExibeVend.Read()

        TxtCPF.Text = rdExibeVend.GetString(0)
        TxtRg.Text = rdExibeVend.GetString(1)
        TxtNome.Text = rdExibeVend.GetString(2)
        TxtEndereco.Text = rdExibeVend.GetString(3)
        TxtNumero.Text = rdExibeVend.GetInt32(4)
        TxtComplemento.Text = rdExibeVend.GetString(5)
        TxtBairro.Text = rdExibeVend.GetString(6)
        CboUF.Text = rdExibeVend.GetString(7)
        CboMunicip.Text = rdExibeVend.GetString(8)
        TxtCEP.Text = rdExibeVend.GetString(9)
        TxtEmail.Text = rdExibeVend.GetString(10)
        TxtWeb.Text = rdExibeVend.GetString(11)
        TxtMsn.Text = rdExibeVend.GetString(12)
        DtCad.Text = rdExibeVend.GetDateTime(13)
        MskCnpj.Text = rdExibeVend.GetString(14)
        TxtRazao.Text = rdExibeVend.GetString(15)
        TxtFantasia.Text = rdExibeVend.GetString(16)
        TxtInscEstadual.Text = rdExibeVend.GetString(17)

        Conn.Close()

    End Sub

    Private Sub Carrega_Telefone()

        Me.ListView1.Items.Clear()
        Dim cmdtelefone = New SqlClient.SqlCommand("select id_fone,ddd,telefone,ramal,tipo from vendas.vendedor_fone where vendid='" & TxtVendID.Text & "'", Conn)
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

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Removendo telefone

        cmdTel = New SqlClient.SqlCommand("VENDAS.usp_Telefone_Man", Conn)
        cmdTel.CommandType = CommandType.StoredProcedure

        With cmdTel
            .Parameters.Add("CLIENTEID", SqlDbType.Int).Value = 0
            .Parameters.Add("@VENDID", SqlDbType.Int).Value = TxtVendID.Text
            .Parameters.Add("@TRANSPID", SqlDbType.Int).Value = 0
            .Parameters.Add("@ID_FONE", SqlDbType.Int).Value = ListView1.SelectedItems.Item(0).Text
            .Parameters.Add("@DDD", SqlDbType.Int).Value = 0
            .Parameters.Add("@TELEFONE", SqlDbType.NVarChar).Value = ""
            .Parameters.Add("@RAMAL", SqlDbType.NVarChar).Value = ""
            .Parameters.Add("@TIPO", SqlDbType.NVarChar).Value = ""
            .Parameters.Add("@VF_MAN", SqlDbType.Int).Value = 2
            .Parameters.Add("@VF_FORM", SqlDbType.Int).Value = 2
        End With

        Conn.Open()
        cmdTel.ExecuteNonQuery()
        Conn.Close()
        ListView1.Items.Clear()
        Carrega_Telefone()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        VF_FrmFone = 2
        FrmTelefone.Show()
    End Sub
End Class