Public Class FrmMovEstoque

    Private Sub MATERIALBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()

    End Sub

    Private Sub FrmMovEstoque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmPrincipal
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        'Busca o Ultimo Registro

        Try

            'Limpa campos
            TxtQtde.Text = ""
            TxtTPMov.Text = ""
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            CboSetor.Text = ""
            CboUnid.Text = ""
            TxtMat.Text = ""
            TxtSetorID.Text = ""


            'Busca o ultimo registro cadastrado

            Conn.Open()
            Dim cmdUltimoServico = New SqlClient.SqlCommand("SPUltimo_Estoque", Conn)
            cmdUltimoServico.CommandType = CommandType.StoredProcedure

            Dim rdUltimoServico As SqlClient.SqlDataReader = cmdUltimoServico.ExecuteReader
            rdUltimoServico.Read()

            TxtOrdem.Text = rdUltimoServico.GetInt32(0) + 1
            Conn.Close()

        Catch ex As Exception
            MsgBox("ERRO: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        'Incluisao de Registro
        Try
            Dim cmdIncluiMovEst As SqlClient.SqlCommand = New SqlClient.SqlCommand("SPIncluiMovEstoque", Conn)

            cmdIncluiMovEst.CommandType = CommandType.StoredProcedure

            cmdIncluiMovEst.Parameters.Add("@Ordem", SqlDbType.Int)
            cmdIncluiMovEst.Parameters("@Ordem").Value = TxtOrdem.Text

            cmdIncluiMovEst.Parameters.Add("@Data", SqlDbType.SmallDateTime)
            cmdIncluiMovEst.Parameters("@Data").Value = DtMov.Text

            cmdIncluiMovEst.Parameters.Add("@MovimentoID", SqlDbType.Int)
            cmdIncluiMovEst.Parameters("@MovimentoID").Value = TxtTPMov.Text

            cmdIncluiMovEst.Parameters.Add("@MaterialID", SqlDbType.Int)
            cmdIncluiMovEst.Parameters("@MaterialID").Value = TxtMat.Text

            cmdIncluiMovEst.Parameters.Add("@Qtde", SqlDbType.Decimal)
            cmdIncluiMovEst.Parameters("@Qtde").Value = TxtQtde.Text

            cmdIncluiMovEst.Parameters.Add("@Unid", SqlDbType.NChar)
            cmdIncluiMovEst.Parameters("@Unid").Value = CboUnid.Text

            cmdIncluiMovEst.Parameters.Add("@SetorID", SqlDbType.Int)
            cmdIncluiMovEst.Parameters("@setorID").Value = TxtSetorID.Text


            Conn.Open()

            cmdIncluiMovEst.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("ERRO: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try

        MsgBox("Registro Incluido com sucesso.", MsgBoxStyle.Information)
        Conn.Close()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        'ALteracao de Registro
        Try
            Dim cmdAlteraMovEst As SqlClient.SqlCommand = New SqlClient.SqlCommand("SPAlteraMovEstoque", Conn)

            cmdAlteraMovEst.CommandType = CommandType.StoredProcedure

            cmdAlteraMovEst.Parameters.Add("@Ordem", SqlDbType.Int)
            cmdAlteraMovEst.Parameters("@Ordem").Value = TxtOrdem.Text

            cmdAlteraMovEst.Parameters.Add("@Data", SqlDbType.SmallDateTime)
            cmdAlteraMovEst.Parameters("@Data").Value = DtMov.Text

            cmdAlteraMovEst.Parameters.Add("@MovimentoID", SqlDbType.Int)
            cmdAlteraMovEst.Parameters("@MovimentoID").Value = TxtTPMov.Text

            cmdAlteraMovEst.Parameters.Add("@MaterialID", SqlDbType.Int)
            cmdAlteraMovEst.Parameters("@MaterialID").Value = TxtMat.Text

            cmdAlteraMovEst.Parameters.Add("@Qtde", SqlDbType.Decimal)
            cmdAlteraMovEst.Parameters("@Qtde").Value = TxtQtde.Text

            cmdAlteraMovEst.Parameters.Add("@Unid", SqlDbType.NChar)
            cmdAlteraMovEst.Parameters("@Unid").Value = CboUnid.Text

            cmdAlteraMovEst.Parameters.Add("@SetorID", SqlDbType.Int)
            cmdAlteraMovEst.Parameters("@setorID").Value = TxtSetorID.Text

            Conn.Open()

            cmdAlteraMovEst.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("ERRO: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try
        MsgBox("Registro Alterado com sucesso.", MsgBoxStyle.Information)
        Conn.Close()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        'Exclusao de Registro
        Try
            Dim cmdDeleteMovEst As SqlClient.SqlCommand = New SqlClient.SqlCommand("SPDeleteMovEst", Conn)

            cmdDeleteMovEst.CommandType = CommandType.StoredProcedure

            cmdDeleteMovEst.Parameters.Add("@Ordem", SqlDbType.Int)
            cmdDeleteMovEst.Parameters("@Ordem").Value = TxtOrdem.Text


            Conn.Open()

            If MsgBox("Deseja Realmente excluir o registro corrente.", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then
                cmdDeleteMovEst.ExecuteNonQuery()
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

    Private Sub TxtQtde_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtQtde.TextChanged

    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        FrmListMovEstoque.Show()
    End Sub
End Class