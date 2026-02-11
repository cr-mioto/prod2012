Public Class FrmConsultaProdMaq

    Private Sub FrmConsultaProdMaq_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.MdiParent = FrmPrincipal

        'Carrega Combo via Data Reader

        Dim CmdListaMaq As SqlClient.SqlCommand

        Conn.Open()

        CmdListaMaq = New SqlClient.SqlCommand("Select MaquinaId,Maquina From Maquinas order by MaquinaID", Conn)
        CmdListaMaq.CommandType = CommandType.Text

        Dim rdLista As SqlClient.SqlDataReader = CmdListaMaq.ExecuteReader

        'Carrega o listview

        While rdLista.Read
            CboMaqBar.Items.Add(rdLista(1).ToString)
        End While

        rdLista.Close()
        Conn.Close()

    End Sub

    Private Sub CboMaqBar_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboMaqBar.SelectedIndexChanged
        TxtCodMaqBar.Text = CboMaqBar.SelectedIndex + 1
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        'Lista dados solicitados

        Conn.Open()

        Dim cmd As New SqlClient.SqlCommand("spProd_por_Maquina", Conn)
        Dim da = New SqlClient.SqlDataAdapter(cmd)
        Dim ds = New DataSet

        da.SelectCommand.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@MaquinaID", SqlDbType.Int).Value = TxtCodMaqBar.Text

        da.Fill(ds, "spProd_por_Maquina")
        DataGrid.DataSource = ds.Tables(0)

        Conn.Close()

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click

        'Lista dados solicitados

        Conn.Open()
        'Carrega Grade de Dados
        Dim dtQuinzena As New DataTable
        Dim daQuinzena As New SqlClient.SqlDataAdapter("SELECT ORDEM, DATA,OperID, SetorID, Folhas, Acertos, Linear, MetrosQuad, FolhasExtras, AcertosExtras, LinearExtras, MetrosQuadExtras,Impressao, Largura_Caixa, Qtde, Valor_Tipo,Largura_Caixa_Extra,Qtde_Extra FROM PRODUCAO_MAQUINAS", Conn)
        daQuinzena.SelectCommand.CommandType = CommandType.Text

        daQuinzena.Fill(dtQuinzena)
        DataGrid.DataSource = dtQuinzena

        Conn.Close()

    End Sub
End Class