Public Class FrmServicos
    'Dim Conn As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.Conn)

    Private Sub FrmServicos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.MdiParent = FrmPrincipal

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        'Incluir Registro Principal
        Try

            Dim cmdIncluiProducao As SqlClient.SqlCommand = New SqlClient.SqlCommand("SPInsertMaq", Conn)

            cmdIncluiProducao.CommandType = CommandType.StoredProcedure

            cmdIncluiProducao.Parameters.Add("@data", SqlDbType.SmallDateTime)
            cmdIncluiProducao.Parameters("@data").Value = DateProdMaq.Text

            cmdIncluiProducao.Parameters.Add("@Ordem", SqlDbType.Int)
            cmdIncluiProducao.Parameters("@Ordem").Value = TxtORDEM.Text

            cmdIncluiProducao.Parameters.Add("@OperID", SqlDbType.Int)
            cmdIncluiProducao.Parameters("@OperId").Value = OperIDTextBox.Text

            cmdIncluiProducao.Parameters.Add("@MaquinaId", SqlDbType.Int)
            cmdIncluiProducao.Parameters("@Maquinaid").Value = MaquinaIDTextBox.Text

            cmdIncluiProducao.Parameters.Add("@folhas", SqlDbType.Decimal)
            cmdIncluiProducao.Parameters("@folhas").Value = TxtFolhas.Text

            cmdIncluiProducao.Parameters.Add("@Acertos", SqlDbType.Decimal)
            cmdIncluiProducao.Parameters("@Acertos").Value = TxtAcertos.Text

            cmdIncluiProducao.Parameters.Add("@Linear", SqlDbType.Decimal)
            cmdIncluiProducao.Parameters("@Linear").Value = TxtLinear.Text

            cmdIncluiProducao.Parameters.Add("@MetrosQuad", SqlDbType.Decimal)
            cmdIncluiProducao.Parameters("@metrosQuad").Value = TxtMetrosQuad.Text

            cmdIncluiProducao.Parameters.Add("@Largura_Caixa", SqlDbType.Decimal)
            cmdIncluiProducao.Parameters("@Largura_Caixa").Value = TxtLarguraCx.Text

            cmdIncluiProducao.Parameters.Add("@Qtde", SqlDbType.Decimal)
            cmdIncluiProducao.Parameters("@Qtde").Value = TxtQtde.Text

            cmdIncluiProducao.Parameters.Add("@Valor_Tipo", SqlDbType.Int)
            cmdIncluiProducao.Parameters("@Valor_Tipo").Value = TxtVLTipo.Text

            cmdIncluiProducao.Parameters.Add("@folhasExtras", SqlDbType.Decimal)
            cmdIncluiProducao.Parameters("@folhasExtras").Value = TxtFolhasExtra.Text

            cmdIncluiProducao.Parameters.Add("@AcertosExtras", SqlDbType.Decimal)
            cmdIncluiProducao.Parameters("@AcertosExtras").Value = TxtAcertosExtra.Text

            cmdIncluiProducao.Parameters.Add("@LinearExtras", SqlDbType.Decimal)
            cmdIncluiProducao.Parameters("@LinearExtras").Value = TxtLinearExtra.Text

            cmdIncluiProducao.Parameters.Add("@MetrosQuadExtras", SqlDbType.Decimal)
            cmdIncluiProducao.Parameters("@metrosQuadExtras").Value = TxtMetrosQuadExtra.Text

            cmdIncluiProducao.Parameters.Add("@Impressao", SqlDbType.NVarChar)
            cmdIncluiProducao.Parameters("@Impressao").Value = TxtImpressao.Text

            cmdIncluiProducao.Parameters.Add("@SetorID", SqlDbType.Int)
            cmdIncluiProducao.Parameters("@SetorID").Value = TextBox1.Text

            cmdIncluiProducao.Parameters.Add("@Largura_Caixa_Extra", SqlDbType.Decimal)
            cmdIncluiProducao.Parameters("@Largura_Caixa_Extra").Value = TxtLarguraCxExtra.Text

            cmdIncluiProducao.Parameters.Add("@Qtde_Extra", SqlDbType.Decimal)
            cmdIncluiProducao.Parameters("@Qtde_Extra").Value = TxtQtdeExtra.Text



            Conn.Open()

            cmdIncluiProducao.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox("ERRO: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try

        MsgBox("Registro Incluido com sucesso.", MsgBoxStyle.Information)
        Conn.Close()

    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        
        TxtAcertos.Text = VL_Acerto

        Try

            'Limpa os Campos do Formulario

            TxtImpressao.Text = ""
            TxtFolhas.Text = "0"
            TxtAcertos.Text = "0"
            TxtLinear.Text = "0"
            TxtMetrosQuad.Text = "0"
            TxtFolhasExtra.Text = "0"
            TxtAcertosExtra.Text = "0"
            TxtLinearExtra.Text = "0"
            TxtMetrosQuadExtra.Text = "0"


            'Busca o ultimo registro cadastrado

            Conn.Open()
            Dim cmdUltimoServico = New SqlClient.SqlCommand("SPUltimo_Servico", Conn)
            cmdUltimoServico.CommandType = CommandType.StoredProcedure

            Dim rdUltimoServico As SqlClient.SqlDataReader = cmdUltimoServico.ExecuteReader
            rdUltimoServico.Read()

            TxtORDEM.Text = rdUltimoServico.GetInt32(0) + 1
            Conn.Close()

        Catch ex As Exception
            MsgBox("ERRO: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
        End Try

    End Sub

    Private Sub GroupBox6_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox6.Enter

    End Sub

    Private Sub DateProdMaq_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateProdMaq.ValueChanged

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click

        'Alterar Registro Principal
        Try

            Dim cmdAlteraProducao As SqlClient.SqlCommand = New SqlClient.SqlCommand("SPAlteraProdMaq", Conn)

            cmdAlteraProducao.CommandType = CommandType.StoredProcedure

            cmdAlteraProducao.Parameters.Add("@data", SqlDbType.SmallDateTime)
            cmdAlteraProducao.Parameters("@data").Value = DateProdMaq.Text

            cmdAlteraProducao.Parameters.Add("@Ordem", SqlDbType.Int)
            cmdAlteraProducao.Parameters("@Ordem").Value = TxtORDEM.Text

            cmdAlteraProducao.Parameters.Add("@OperID", SqlDbType.Int)
            cmdAlteraProducao.Parameters("@OperId").Value = OperIDTextBox.Text

            cmdAlteraProducao.Parameters.Add("@MaquinaId", SqlDbType.Int)
            cmdAlteraProducao.Parameters("@MaquinaID").Value = MaquinaIDTextBox.Text

            cmdAlteraProducao.Parameters.Add("@folhas", SqlDbType.Decimal)
            cmdAlteraProducao.Parameters("@folhas").Value = TxtFolhas.Text

            cmdAlteraProducao.Parameters.Add("@Acertos", SqlDbType.Decimal)
            cmdAlteraProducao.Parameters("@Acertos").Value = TxtAcertos.Text

            cmdAlteraProducao.Parameters.Add("@Linear", SqlDbType.Decimal)
            cmdAlteraProducao.Parameters("@Linear").Value = TxtLinear.Text

            cmdAlteraProducao.Parameters.Add("@MetrosQuad", SqlDbType.Decimal)
            cmdAlteraProducao.Parameters("@metrosQuad").Value = TxtMetrosQuad.Text

            cmdAlteraProducao.Parameters.Add("@Largura_Caixa", SqlDbType.Decimal)
            cmdAlteraProducao.Parameters("@Largura_Caixa").Value = TxtLarguraCx.Text

            cmdAlteraProducao.Parameters.Add("@Qtde", SqlDbType.Decimal)
            cmdAlteraProducao.Parameters("@Qtde").Value = TxtQtde.Text

            cmdAlteraProducao.Parameters.Add("@Valor_Tipo", SqlDbType.Int)
            cmdAlteraProducao.Parameters("@Valor_Tipo").Value = TxtVLTipo.Text

            cmdAlteraProducao.Parameters.Add("@folhasExtras", SqlDbType.Decimal)
            cmdAlteraProducao.Parameters("@folhasExtras").Value = TxtFolhasExtra.Text

            cmdAlteraProducao.Parameters.Add("@AcertosExtras", SqlDbType.Decimal)
            cmdAlteraProducao.Parameters("@AcertosExtras").Value = TxtAcertosExtra.Text

            cmdAlteraProducao.Parameters.Add("@LinearExtras", SqlDbType.Decimal)
            cmdAlteraProducao.Parameters("@LinearExtras").Value = TxtLinearExtra.Text

            cmdAlteraProducao.Parameters.Add("@MetrosQuadExtras", SqlDbType.Decimal)
            cmdAlteraProducao.Parameters("@metrosQuadExtras").Value = TxtMetrosQuadExtra.Text

            cmdAlteraProducao.Parameters.Add("@Impressao", SqlDbType.NVarChar)
            cmdAlteraProducao.Parameters("@Impressao").Value = TxtImpressao.Text

            cmdAlteraProducao.Parameters.Add("@SetorID", SqlDbType.Int)
            cmdAlteraProducao.Parameters("@SetorID").Value = TextBox1.Text

            cmdAlteraProducao.Parameters.Add("@Largura_Caixa_Extra", SqlDbType.Decimal)
            cmdAlteraProducao.Parameters("@Largura_Caixa_Extra").Value = TxtLarguraCxExtra.Text

            cmdAlteraProducao.Parameters.Add("@Qtde_Extra", SqlDbType.Decimal)
            cmdAlteraProducao.Parameters("@Qtde_Extra").Value = TxtQtdeExtra.Text


            Conn.Open()

            cmdAlteraProducao.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox("ERRO: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try

        MsgBox("Registro Alterado com sucesso.", MsgBoxStyle.Information)
        Conn.Close()

    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click

        'Buscar Registro Individual
        Try

            Dim cmdDeleteProducao As SqlClient.SqlCommand = New SqlClient.SqlCommand("SPDeleteServico", Conn)

            cmdDeleteProducao.CommandType = CommandType.StoredProcedure

            cmdDeleteProducao.Parameters.Add("@data", SqlDbType.SmallDateTime)
            cmdDeleteProducao.Parameters("@data").Value = DateProdMaq.Text

            cmdDeleteProducao.Parameters.Add("@Ordem", SqlDbType.Int)
            cmdDeleteProducao.Parameters("@Ordem").Value = TxtORDEM.Text

            cmdDeleteProducao.Parameters.Add("@MaquinaId", SqlDbType.Int)
            cmdDeleteProducao.Parameters("@Maquinaid").Value = MaquinaIDTextBox.Text


            Conn.Open()

            If MsgBox("Deseja Realmente excluir o registro corrente.", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then
                cmdDeleteProducao.ExecuteNonQuery()
            Else
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox("ERRO: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try

        MsgBox("Registro Excluido com sucesso.", MsgBoxStyle.Information)
        Conn.Close()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        FrmConsultaProdMaq.Show()
    End Sub

    Private Sub TxtORDEM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtORDEM.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            Retorna_Servico()
        End If

    End Sub

    Private Sub Retorna_Servico()
        Try
            Conn.Open()

            Dim cmdservico = New SqlClient.SqlCommand("SPBusca_Servico", Conn)
            cmdservico.CommandType = CommandType.StoredProcedure

            cmdservico.Parameters.Add("@OrdemID", SqlDbType.Int)
            cmdservico.Parameters("@OrdemID").Value = TxtORDEM.Text

            Dim rdservico As SqlClient.SqlDataReader = cmdservico.ExecuteReader

            'Abrindo o Reader
            rdservico.Read()

            DateProdMaq.Text = rdservico.GetSqlDateTime(1)
            TextBox1.Text = rdservico.GetSqlInt32(6)
            ComboBox3.Text = rdservico.GetSqlString(7)
            MaquinaIDTextBox.Text = rdservico.GetSqlInt32(2)
            ComboBox1.Text = rdservico.GetSqlString(3)
            OperIDTextBox.Text = rdservico.GetSqlInt32(4)
            ComboBox2.Text = rdservico.GetSqlString(5)
            TxtImpressao.Text = rdservico.GetSqlString(16)
            TxtFolhas.Text = rdservico.GetSqlDecimal(8)
            TxtLinear.Text = rdservico.GetSqlDecimal(10)
            TxtMetrosQuad.Text = rdservico.GetSqlDecimal(11)
            TxtAcertos.Text = rdservico.GetSqlDecimal(9)
            TxtFolhasExtra.Text = rdservico.GetSqlDecimal(12)
            TxtLinearExtra.Text = rdservico.GetSqlDecimal(14)
            TxtMetrosQuadExtra.Text = rdservico.GetSqlDecimal(15)
            TxtAcertosExtra.Text = rdservico.GetSqlDecimal(13)
            TxtLarguraCx.Text = rdservico.GetSqlDecimal(17)
            TxtQtde.Text = rdservico.GetSqlDecimal(18)
            TxtVLTipo.Text = rdservico.GetSqlInt32(19)
            TxtLarguraCxExtra.Text = rdservico.GetSqlDecimal(20)
            TxtQtdeExtra.Text = rdservico.GetSqlDecimal(21)



            Conn.Close()

        Catch ex As Exception
            MsgBox("ERRO: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try

    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        FrmCalcDiario.Show()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            TxtVLTipo.Text = 8
        Else
            TxtVLTipo.Text = 0
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            TxtVLTipo.Text = 4
        Else
            TxtVLTipo.Text = 0
        End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = 8 Then
            TxtFolhas.Enabled = False
            TxtLinear.Enabled = False
            TxtMetrosQuad.Enabled = False
            TxtLarguraCx.Enabled = True
            TxtQtde.Enabled = True
            TxtLarguraCxExtra.Enabled = True
            TxtQtdeExtra.Enabled = True
        Else
            TxtFolhas.Enabled = True
            TxtLinear.Enabled = True
            TxtMetrosQuad.Enabled = True
            TxtLarguraCx.Enabled = False
            TxtQtde.Enabled = False
            TxtLarguraCxExtra.Enabled = False
            TxtQtdeExtra.Enabled = False

        End If
    End Sub

End Class