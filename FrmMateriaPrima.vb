Public Class FrmMateriaPrima

    Private Sub FrmMateriaPrima_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Verifica qual o tipo de dado a ser alterado e Prepara a Tela.

        Select Case intAC
            Case 1
                Me.Text = "Cadastro de Matéria-Prima - Inclusão de Registro"
                MdRetornoDB.Last_Record_2C()
                TP_Combo = 4
                MdRetornoDB.Carrega_Combo()
                Txt1.Text = intID_Retorno
                Txt2.Select()
            Case 2
                Me.Text = "Cadastro de Matéria-Prima - Edição de Registro"
                TP_Combo = 4
                MdRetornoDB.Carrega_Combo()
                Carrega_Campos()
            Case 3
                Me.Text = "Cadastro de Matéria-Prima - Visualizar Registro "
                Txt1.Enabled = False
                Txt2.Enabled = False
                Txt3.Enabled = False
                Txt4.Enabled = False
                Cbo1.Enabled = False
                Txt5.Enabled = False
                Txt6.Enabled = False
                Txt7.Enabled = False
                Txt8.Enabled = False
                Cbo2.Enabled = False
                Carrega_Campos()

            Case 4
                Me.Text = "Cadastro de Matéria-Prima - Exclusão de Registro "
                Txt1.Enabled = False
                Txt2.Enabled = False
                Txt1.Enabled = False
                Txt2.Enabled = False
                Txt3.Enabled = False
                Txt4.Enabled = False
                Cbo1.Enabled = False
                Txt5.Enabled = False
                Txt6.Enabled = False
                Txt7.Enabled = False
                Txt8.Enabled = False
                Cbo2.Enabled = False
                Carrega_Campos()

        End Select
    End Sub
    Private Sub Carrega_Campos()
        'Rotina que retorna o registro selecionado na lista principal
        'Exibe dados solicitados
        strSQL = "SELECT * FROM PRODUCAO.MATERIAIS WHERE ID='" & intID_Entrada & "'"
 
        Cmd = New SqlClient.SqlCommand(strSQL, Conn)
        Cmd.CommandType = CommandType.Text

        Conn.Open()

        Dim rd As SqlClient.SqlDataReader = Cmd.ExecuteReader

        While rd.Read

            intID_Retorno = rd.GetInt32(0)
            strDescricao_Retorno = rd.GetString(1)
            strUN_Retorno = rd.GetString(2)
            intGRP_Retorno = rd.GetInt32(3)
            strGRP_Retorno = rd.GetString(4)
            strTP_Material = rd.GetString(5)
            intGramatura = rd.GetInt32(6)
            strMedida = rd.GetString(7)
            intAcabamentoID = rd.GetInt32(8)
            strAcabamento = rd.GetString(9)

        End While

        rd.Close()
        Conn.Close()

        Txt1.Text = intID_Retorno
        Txt2.Text = strDescricao_Retorno
        Txt3.Text = intGRP_Retorno
        Cbo1.Text = strGRP_Retorno
        Txt4.Text = strUN_Retorno
        Txt5.Text = strTP_Material
        Txt6.Text = intGramatura
        Txt7.Text = strMedida
        Txt8.Text = intAcabamentoID
        Cbo2.Text = strAcabamento

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Try
            intID_Entrada = Txt1.Text
            strDescricao_Entrada = Txt2.Text
            strUN_Entrada = Txt4.Text
            intGRP_Entrada = Txt3.Text
            strGRP_Entrada = Cbo1.Text
            strTP_Material = Txt5.Text
            intGramatura = Txt6.Text
            strMedida = Txt7.Text
            intAcabamentoID = Txt8.Text
            strAcabamento = Cbo2.Text
            MdManDB.MP()
            Listar_Principal()

        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try

    End Sub


    Private Sub Cbo1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cbo1.SelectedValueChanged
        Try

            'Rotina para retornar o código do grupo

            strSQL = "SELECT ID FROM PRODUCAO.GRUPOS WHERE Descricao='" & Cbo1.Text & "'"

            Cmd = New SqlClient.SqlCommand(strSQL, Conn)
            Cmd.CommandType = CommandType.Text

            Conn.Open()

            Dim rd As SqlClient.SqlDataReader = Cmd.ExecuteReader

            While rd.Read
                intGRP_Retorno = rd.GetInt32(0)
            End While

            Txt3.Text = intGRP_Retorno

            rd.Close()
            Conn.Close()

        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try
        
    End Sub
    Private Sub Cbo2_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cbo2.SelectedValueChanged

        Try

            'Rotina para retornar o código de acabamento.

            strSQL = "SELECT ID FROM PRODUCAO.ACABAMENTO WHERE Descricao='" & Cbo2.Text & "'"

            Cmd = New SqlClient.SqlCommand(strSQL, Conn)
            Cmd.CommandType = CommandType.Text

            Conn.Open()

            Dim rd As SqlClient.SqlDataReader = Cmd.ExecuteReader

            While rd.Read
                intGRP_Retorno = rd.GetInt32(0)
            End While

            Txt8.Text = intGRP_Retorno

            rd.Close()
            Conn.Close()

        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try

    End Sub
End Class
