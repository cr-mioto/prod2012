Public Class FrmFacas

    Private Sub FrmFacas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Verifica qual o tipo de dado a ser alterado e Prepara a Tela.
        Try
            Select Case intAC
                Case 1
                    Me.Text = "Cadastro de Facas - Inclusão de Registro"
                    MdRetornoDB.Last_Record_2C()
                    TP_Combo = 5
                    MdRetornoDB.Carrega_Combo()
                    Txt1.Text = intID_Retorno
                    Txt2.Select()
                Case 2
                    Me.Text = "Cadastro de Facas - Edição de Registro"
                    TP_Combo = 5
                    MdRetornoDB.Carrega_Combo()
                    Carrega_Campos()
                Case 3
                    Me.Text = "Cadastro de Facas - Visualizar Registro "
                    Txt1.Enabled = False
                    DT1.Enabled = False
                    Txt2.Enabled = False
                    Txt3.Enabled = False
                    Txt4.Enabled = False
                    Cbo1.Enabled = False
                    Txt5.Enabled = False
                    Txt6.Enabled = False
                    Txt7.Enabled = False
                    Txt8.Enabled = False
                    Txt9.Enabled = False
                    optAtivo.Enabled = False
                    optDescontinuado.Enabled = False
                    Carrega_Campos()

                Case 4
                    Me.Text = "Cadastro de Facas - Exclusão de Registro "
                    Txt1.Enabled = False
                    DT1.Enabled = False
                    Txt2.Enabled = False
                    Txt3.Enabled = False
                    Txt4.Enabled = False
                    Cbo1.Enabled = False
                    Txt5.Enabled = False
                    Txt6.Enabled = False
                    Txt7.Enabled = False
                    Txt8.Enabled = False
                    Txt9.Enabled = False
                    optAtivo.Enabled = False
                    optDescontinuado.Enabled = False

                    Carrega_Campos()
            End Select

        Catch ex As Exception
            ' MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            MsgBox("É necessário selecionar um item da lista.", vbCritical)
            Conn.Close()
            Exit Sub
        End Try

         End Sub
    Private Sub Carrega_Campos()

        'Rotina que retorna o registro selecionado na lista principal
        'Exibe dados solicitados
        strSQL = "SELECT Id,Medida,Data,TP,TPDescricao,Qtde,Area,Cartao,Micro,Arranjo,Obs,[Status] FROM PRODUCAO.Facas WHERE ID='" & intID_Entrada & "'"

        Cmd = New SqlClient.SqlCommand(strSQL, Conn)
        Cmd.CommandType = CommandType.Text

        Conn.Open()

        Dim rd As SqlClient.SqlDataReader = Cmd.ExecuteReader

        While rd.Read

            intID_Retorno = rd.GetInt32(0)
            strMedida = rd.GetString(1)
            dt_Retorno = rd.GetDateTime(2)
            strTP_Retorno = rd.GetString(3)
            strDescricao_Retorno = rd.GetString(4)
            intQtde = rd.GetInt32(5)
            strArea = rd.GetString(6)
            strCartao = rd.GetString(7)
            strMicro = rd.GetString(8)
            dbArranjo = rd.GetDecimal(9)
            strObs = rd.GetString(10)
            blnStatus = rd.GetBoolean(11)


        End While

        rd.Close()
        Conn.Close()

        Txt1.Text = intID_Retorno
        DT1.Value = dt_Retorno
        Txt2.Text = strMedida
        Txt3.Text = strTP_Retorno
        Cbo1.Text = strDescricao_Retorno
        Txt4.Text = intQtde
        Txt5.Text = strArea
        Txt6.Text = strCartao
        Txt7.Text = strMicro
        Txt8.Text = FormatNumber(dbArranjo)
        Txt9.Text = strObs
        If blnStatus = True Then
            optAtivo.Checked = True
            optDescontinuado.Checked = False
        Else
            optAtivo.Checked = False
            optDescontinuado.Checked = True
        End If


    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub Cbo1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cbo1.SelectedValueChanged
        Try

            'Rotina para retornar o código do grupo

            strSQL = "SELECT TP FROM PRODUCAO.TPFACAS WHERE Descricao='" & Cbo1.Text & "'"

            Cmd = New SqlClient.SqlCommand(strSQL, Conn)
            Cmd.CommandType = CommandType.Text

            Conn.Open()

            Dim rd As SqlClient.SqlDataReader = Cmd.ExecuteReader

            While rd.Read
                strTP_Retorno = rd.GetString(0)
            End While

            Txt3.Text = strTP_Retorno

            rd.Close()
            Conn.Close()

        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        'Carregando as variáveis.
        intID_Entrada = Txt1.Text
        dt_Entrada = DT1.Text
        strMedida = Txt2.Text
        strTP_Entrada = Txt3.Text
        strDescricao_Entrada = Cbo1.Text
        intQtde = Txt4.Text
        strArea = Txt5.Text
        strCartao = Txt6.Text
        strMicro = Txt7.Text
        dbArranjo = Txt8.Text
        strObs = Txt9.Text
        If optAtivo.Checked = True Then
            blnStatus = True
        Else
            blnStatus = False
        End If
        MdManDB.Facas()
        Listar_Principal()
    End Sub
End Class