Public Class FrmServico

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        'Carregando as variáveis  de dados

        intID = Txt1.Text
        dt_Entrada = DT1.Value
        intSetorID = Txt2.Text
        strSetor = Cbo1.Text
        intMaqID = Txt3.Text
        strMaq = Cbo2.Text
        intOperID = Txt4.Text
        strOper = Cbo3.Text
        intEmbID = Txt5a.Text
        strEmbalagem = Txt6.Text
        dbComprimento = Txt7.Text
        dbLargura = Txt8.Text
        dbFolhas = Txt9.Text
        dbM2 = Txt10.Text
        dbLinear = Txt11.Text
        dbQtde = Txt12.Text
        strLarguraCx = Txt13.Text
        intAcertos = Txt14.Text
        intHoras = Txt15.Text
        dbComprimentoEX = Txt16.Text
        dbLarguraEX = Txt17.Text
        dbFolhasEX = Txt18.Text
        dbM2EX = Txt19.Text
        dbLinearEX = Txt20.Text
        dbQtdeEX = Txt21.Text
        strLarguraCxEX = Txt22.Text
        intAcertosEX = Txt23.Text
        intHorasEX = Txt24.Text
        intCorteid = TxtCorte.Text
        strCorte = CboCorte.Text
        strObs = TxtOBS.Text

        mdServico.MAN()
        Listar_Principal()

        If intAC = 1 Then
            Limpa_Campos()
        End If

    End Sub

    Private Sub FrmServico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Verifica qual o tipo de dado a ser alterado e Prepara a Tela.
        Select Case intAC
            Case 1
                Me.Text = "Manutenção de Serviços de Produção - Inclusão de Registro"
                MdRetornoDB.Last_Record_2C()
                Txt1.Text = intID_Retorno
            Case 2
                Me.Text = "Manutenção de Serviços de Produção - Alteração de Registro"
                Carrega_Campos()
            Case 3
                Me.Text = "Manutenção de Serviços de Produção - Visualização de Registro"
                Trava_Campos()
                Carrega_Campos()
            Case 4
                Me.Text = "Manutenção de Serviços de Produção - Exclusão de Registro"
                Trava_Campos()
                Carrega_Campos()
        End Select
    End Sub
    Private Sub Carrega_Campos()
        mdServico.Exibir()

        Txt1.Text = intID_Entrada
        DT1.Value = dt_Entrada
        Txt2.Text = intSetorID
        Cbo1.Text = strSetor
        Txt3.Text = intMaqID
        Cbo2.Text = strMaq
        Txt4.Text = intOperID
        Cbo3.Text = strOper
        Txt5a.Text = intEmbID
        Txt6.Text = strEmbalagem
        TxtCorte.Text = intCorteid
        CboCorte.Text = strCorte
        TxtOBS.Text = strObs
        Txt7.Text = dbComprimento
        Txt8.Text = dbLargura
        Txt9.Text = dbFolhas
        Txt10.Text = dbM2
        Txt11.Text = dbLinear
        Txt12.Text = dbQtde
        Txt13.Text = strLarguraCx
        Txt14.Text = intAcertos
        Txt15.Text = intHoras
        Txt16.Text = dbComprimentoEX
        Txt17.Text = dbLarguraEX
        Txt18.Text = dbFolhasEX
        Txt19.Text = dbM2EX
        Txt20.Text = dbLinearEX
        Txt21.Text = dbQtdeEX
        Txt22.Text = strLarguraCxEX
        Txt23.Text = intAcertosEX
        Txt24.Text = intHorasEX

    End Sub
    Private Sub Trava_Campos()
        'Trava todos os campos do formulário.
        Txt1.Enabled = False
        DT1.Enabled = False
        Txt2.Enabled = False
        Cbo1.Enabled = False
        Txt3.Enabled = False
        Cbo2.Enabled = False
        Txt4.Enabled = False
        Cbo3.Enabled = False
        Txt5a.Enabled = False
        Txt6.Enabled = False
        Txt7.Enabled = False
        Txt8.Enabled = False
        Txt9.Enabled = False
        Txt10.Enabled = False
        Txt11.Enabled = False
        Txt12.Enabled = False
        Txt13.Enabled = False
        Txt14.Enabled = False
        Txt15.Enabled = False
        Txt16.Enabled = False
        Txt17.Enabled = False
        Txt18.Enabled = False
        Txt19.Enabled = False
        Txt20.Enabled = False
        Txt21.Enabled = False
        Txt22.Enabled = False
        Txt23.Enabled = False
        Txt24.Enabled = False
        TxtCorte.Enabled = False
        TxtOBS.Enabled = False
        CboCorte.Enabled = False

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub Cbo1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Cbo1.MouseClick
        TP_Combo = 7
        Cbo1.Items.Clear()
        MdRetornoDB.Carrega_Combo()
    End Sub

    Private Sub Cbo2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Cbo2.MouseClick
        TP_Combo = 1
        Cbo2.Items.Clear()
        MdRetornoDB.Carrega_Combo()
    End Sub

    Private Sub Cbo3_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Cbo3.MouseClick
        TP_Combo = 2
        Cbo3.Items.Clear()
        MdRetornoDB.Carrega_Combo()
    End Sub
    
    Private Sub Cbo1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo1.SelectedIndexChanged
        Try

            'Rotina para retornar o código do Setor

            strSQL = "SELECT ID FROM PRODUCAO.SETOR WHERE Descricao='" & Cbo1.Text & "'"

            Cmd = New SqlClient.SqlCommand(strSQL, Conn)
            Cmd.CommandType = CommandType.Text

            Conn.Open()

            Dim rd As SqlClient.SqlDataReader = Cmd.ExecuteReader

            While rd.Read
                intGRP_Retorno = rd.GetInt32(0)
            End While

            Txt2.Text = intGRP_Retorno

            rd.Close()
            Conn.Close()

        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub Cbo2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo2.SelectedIndexChanged
        Try

            'Rotina para retornar o código do Maquina

            strSQL = "SELECT ID FROM PRODUCAO.MAQUINAS WHERE Descricao='" & Cbo2.Text & "'"

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
    Private Sub Cbo3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo3.SelectedIndexChanged
        Try

            'Rotina para retornar o código do Operador

            strSQL = "SELECT ID FROM PRODUCAO.OPERADORES WHERE Descricao='" & Cbo3.Text & "'"

            Cmd = New SqlClient.SqlCommand(strSQL, Conn)
            Cmd.CommandType = CommandType.Text

            Conn.Open()

            Dim rd As SqlClient.SqlDataReader = Cmd.ExecuteReader

            While rd.Read
                intGRP_Retorno = rd.GetInt32(0)
            End While

            Txt4.Text = intGRP_Retorno

            rd.Close()
            Conn.Close()

        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try
    End Sub

   
    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click

        'Calculo...Normais.

        dbComprimento = Txt7.Text
        dbLargura = Txt8.Text
        dbFolhas = Txt9.Text
        dbM2 = ((dbComprimento * dbLargura * dbFolhas) / 10000)
        Txt10.Text = Format(dbM2, "###,###.#0")

        dbLinear = ((dbComprimento * dbFolhas) / 100)
        Txt11.Text = Format(dbLinear, "###,###.#0")


    End Sub

    Private Sub btnCalc2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc2.Click
        'Calculo...Extra.

        dbComprimentoEX = Txt16.Text
        dbLarguraEX = Txt17.Text
        dbFolhasEX = Txt18.Text

        dbM2EX = ((dbComprimentoEX * dbLarguraEX * dbFolhasEX) / 10000)
        Txt19.Text = Format(dbM2EX, "###,###.#0")

        dbLinearEX = ((dbComprimentoEX * dbFolhasEX) / 100)
        Txt20.Text = Format(dbLinearEX, "###,###.#0")

    End Sub

    Private Sub Txt2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt2.LostFocus
        Try

            'Rotina para retornar o Nome do Setor

            strSQL = "SELECT Descricao FROM PRODUCAO.SETOR WHERE ID='" & Txt2.Text & "'"

            Cmd = New SqlClient.SqlCommand(strSQL, Conn)
            Cmd.CommandType = CommandType.Text

            Conn.Open()

            Dim rd As SqlClient.SqlDataReader = Cmd.ExecuteReader

            While rd.Read
                strDescricao_Retorno = rd.GetString(0)
            End While

            If strDescricao_Retorno = Nothing Then
                MsgBox("Erro: " + "Setor não existente.", MsgBoxStyle.Critical)
                Txt2.Focus()
                Cbo1.Items.Clear()
                Cbo1.Text = ""
                rd.Close()
                Conn.Close()
                Exit Sub
            Else
                Cbo1.Text = strDescricao_Retorno
            End If
            strDescricao_Retorno = Nothing
            rd.Close()
            Conn.Close()

        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try

    End Sub

    Private Sub Txt3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt3.LostFocus
        Try

            'Rotina para retornar o Nome da Maquina.

            strSQL = "SELECT Descricao FROM PRODUCAO.MAQUINAS WHERE ID='" & Txt3.Text & "'"

            Cmd = New SqlClient.SqlCommand(strSQL, Conn)
            Cmd.CommandType = CommandType.Text

            Conn.Open()

            Dim rd As SqlClient.SqlDataReader = Cmd.ExecuteReader

            While rd.Read
                strDescricao_Retorno = rd.GetString(0)
            End While

            If strDescricao_Retorno = Nothing Then
                MsgBox("Erro: " + "Maquina não existente.", MsgBoxStyle.Critical)
                Txt3.Focus()
                Cbo2.Items.Clear()
                Cbo2.Text = ""
                rd.Close()
                Conn.Close()
                Exit Sub
            Else
                Cbo2.Text = strDescricao_Retorno
            End If
            strDescricao_Retorno = Nothing
            rd.Close()
            Conn.Close()

        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub Txt4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt4.LostFocus
        Try

            'Rotina para retornar o código do Operador

            strSQL = "SELECT Descricao FROM PRODUCAO.OPERADORES WHERE ID='" & Txt4.Text & "'"

            Cmd = New SqlClient.SqlCommand(strSQL, Conn)
            Cmd.CommandType = CommandType.Text

            Conn.Open()

            Dim rd As SqlClient.SqlDataReader = Cmd.ExecuteReader

            While rd.Read
                strDescricao_Retorno = rd.GetString(0)
            End While

            If strDescricao_Retorno = Nothing Then
                MsgBox("Erro: " + "Operadore não existente.", MsgBoxStyle.Critical)
                Txt4.Focus()
                Cbo3.Items.Clear()
                Cbo3.Text = ""
                rd.Close()
                Conn.Close()
                Exit Sub
            Else
                Cbo3.Text = strDescricao_Retorno
            End If
            strDescricao_Retorno = Nothing
            rd.Close()
            Conn.Close()

        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub Limpa_Campos()
        'Rotina de Limpeza de campos e variáveis para um novo registro.

        MdRetornoDB.Last_Record_2C()
        Txt1.Text = intID_Retorno

        DT1.Value = Now
        Txt2.Text = ""
        Cbo1.Text = ""
        Txt3.Text = ""
        Cbo2.Text = ""
        Txt4.Text = ""
        Cbo3.Text = ""
        Txt5a.Text = ""
        Txt6.Text = ""
        Txt7.Text = "0"
        Txt8.Text = "0"
        Txt9.Text = "0"
        Txt10.Text = "0"
        Txt11.Text = "0"
        Txt12.Text = "0"
        Txt13.Text = "0"
        Txt14.Text = "0"
        Txt15.Text = "0"
        Txt16.Text = "0"
        Txt17.Text = "0"
        Txt18.Text = "0"
        Txt19.Text = "0"
        Txt20.Text = "0"
        Txt21.Text = "0"
        Txt22.Text = "0"
        Txt23.Text = "0"
        Txt24.Text = "0"
        TxtCorte.Text = ""
        CboCorte.Text = ""
        TxtOBS.Text = ""
        'Limpando as Variáveis...

        intSetorID = 0
        strSetor = ""
        intMaqID = 0
        strMaq = ""
        intOperID = 0
        strOper = ""
        intEmbID = 0
        strEmbalagem = ""
        intCorteid = 0
        strCorte = ""
        strObs = ""
        dbComprimento = 0
        dbLargura = 0
        dbFolhas = 0
        dbM2 = 0
        dbLinear = 0
        dbQtde = 0
        strLarguraCx = ""
        intAcertos = 0
        intHoras = 0
        dbComprimentoEX = 0
        dbLarguraEX = 0
        dbFolhasEX = 0
        dbM2EX = 0
        dbLinearEX = 0
        dbQtdeEX = 0
        strLarguraCxEX = ""
        intAcertosEX = 0
        intHorasEX = 0

        Txt1.Focus()

    End Sub

    Private Sub CboCorte_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboCorte.SelectedIndexChanged
        '***************************************************
        '* Exibe o código correspondente a opção desejada. *
        '***************************************************

        Select Case CboCorte.SelectedIndex
            Case 0
                TxtCorte.Text = 1
            Case 1
                TxtCorte.Text = 2
            Case 2
                TxtCorte.Text = 3
        End Select

    End Sub

    
    Private Sub TxtCorte_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCorte.LostFocus
        Select Case TxtCorte.Text
            Case 1
                CboCorte.Text = "Conjugada"
            Case 2
                CboCorte.Text = "Tampa"
            Case 3
                CboCorte.Text = "Fundo"
        End Select
    End Sub
End Class