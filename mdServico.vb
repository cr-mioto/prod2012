Module mdServico
    Public intServID As Integer         'Armanzena o código do serviço.
    Public intSetorID As Integer        'Armazena o código do setor. Ps.Colocar no móduolo mdSetor quando pronto.    
    Public strSetor, strOper As String
    Public intMaqID As Integer
    Public intOperID As Integer
    Public intEmbID As Integer
    Public strEmbalagem As String
    Public dbComprimento, dbLargura, dbFolhas, dbM2, dbLinear, dbQtde As Double
    Public strLarguraCx As String
    Public intAcertos, intHoras As Integer
    Public dbComprimentoEX, dbLarguraEX, dbFolhasEX, dbM2EX, dbLinearEX, dbQtdeEX As Double
    Public strLarguraCxEX As String
    Public intAcertosEX, intHorasEX As Integer
    Public intCorteid As Integer
    Public strCorte As String


    Public Sub MAN()
        'Manutenção dos dados.
        Try
            Cmd = New SqlClient.SqlCommand("Producao.usp_Man_Servicos", Conn)
            Cmd.CommandType = CommandType.StoredProcedure

            With Cmd

                .Parameters.Add("@IDSERV", SqlDbType.Int).Value = intID
                .Parameters.Add("@Data", SqlDbType.SmallDateTime).Value = dt_Entrada
                .Parameters.Add("@SETORID", SqlDbType.Int).Value = intSetorID
                .Parameters.Add("@SETOR", SqlDbType.NVarChar).Value = strSetor
                .Parameters.Add("@MAQID", SqlDbType.Int).Value = intMaqID
                .Parameters.Add("@MAQUINA", SqlDbType.NVarChar).Value = strMaq
                .Parameters.Add("@OPERID", SqlDbType.Int).Value = intOperID
                .Parameters.Add("@OPERADOR", SqlDbType.NVarChar).Value = strOper
                .Parameters.Add("@EMBID", SqlDbType.Int).Value = intEmbID
                .Parameters.Add("@EMBALAGEM", SqlDbType.NVarChar).Value = strEmbalagem
                .Parameters.Add("@CORTEID", SqlDbType.Int).Value = intCorteid
                .Parameters.Add("@CORTE", SqlDbType.NVarChar).Value = strCorte
                .Parameters.Add("@OBS", SqlDbType.NVarChar).Value = strObs
                .Parameters.Add("@COMPRIMENTO", SqlDbType.Decimal).Value = dbComprimento
                .Parameters.Add("@LARGURA", SqlDbType.Decimal).Value = dbLargura
                .Parameters.Add("@FOLHAS", SqlDbType.Decimal).Value = dbFolhas
                .Parameters.Add("@M2", SqlDbType.Decimal).Value = dbM2
                .Parameters.Add("@LINEAR", SqlDbType.Decimal).Value = dbLinear
                .Parameters.Add("@QTDE", SqlDbType.Decimal).Value = dbQtde
                .Parameters.Add("@LARGCAIXA", SqlDbType.NVarChar).Value = strLarguraCx
                .Parameters.Add("@ACERTOS", SqlDbType.Int).Value = intAcertos
                .Parameters.Add("@HORAS", SqlDbType.Int).Value = intHoras
                .Parameters.Add("@COMPRIMENTO_EX", SqlDbType.Decimal).Value = dbComprimentoEX
                .Parameters.Add("@LARGURA_EX", SqlDbType.Decimal).Value = dbLarguraEX
                .Parameters.Add("@FOLHAS_EX", SqlDbType.Decimal).Value = dbFolhasEX
                .Parameters.Add("@M2_EX", SqlDbType.Decimal).Value = dbM2EX
                .Parameters.Add("@LINEAR_EX", SqlDbType.Decimal).Value = dbLinearEX
                .Parameters.Add("@QTDE_EX", SqlDbType.Decimal).Value = dbQtdeEX
                .Parameters.Add("@LARGCAIXA_EX", SqlDbType.NVarChar).Value = strLarguraCxEX
                .Parameters.Add("@ACERTOS_EX", SqlDbType.Int).Value = intAcertosEX
                .Parameters.Add("@HORAS_EX", SqlDbType.Int).Value = intHorasEX
                .Parameters.Add("@VF_MAN", SqlDbType.Int).Value = intAC

            End With

            Conn.Open()
            Cmd.ExecuteNonQuery()
            Conn.Close()

            Select Case intAC
                Case 1
                    MsgBox("Registro gravado com Sucesso.", MsgBoxStyle.Information)
                Case 2
                    MsgBox("Registro alterado com Sucesso.", MsgBoxStyle.Information)
                Case 4
                    MsgBox("Registro excluido com Sucesso.", MsgBoxStyle.Information)
            End Select

        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try

    End Sub
    Public Sub Exibir()
        'Rotina que retorna o registro selecionado na lista principal
        'Exibe dados solicitados

        strSQL = "SELECT Producao.Servicos.DATA" _
                & ", Producao.Servicos.SETORID" _
                & ", Producao.Servicos.SETOR" _
                & ", Producao.Servicos.MAQID" _
                & ", Producao.Servicos.MAQUINA" _
                & ", Producao.Servicos.OPERID" _
                & ", Producao.Servicos.OPERADOR" _
                & ", Producao.Servicos.EMBID" _
                & ", Producao.Servicos.EMBALAGEM" _
                & ", Producao.Servicos.CORTEID" _
                & ", Producao.Servicos.CORTE" _
                & ", Producao.Servicos.OBS" _
                & ", Producao.Serv_Normais.COMPRIMENTO" _
                & ", Producao.Serv_Normais.LARGURA" _
                & ", Producao.Serv_Normais.FOLHAS" _
                & ", Producao.Serv_Normais.M2" _
                & ", Producao.Serv_Normais.LINEAR" _
                & ", Producao.Serv_Normais.QTDE" _
                & ", Producao.Serv_Normais.LARGCAIXA" _
                & ", Producao.Serv_Normais.ACERTOS" _
                & ", Producao.Serv_Normais.HORAS" _
                & ", Producao.Serv_Extra.COMPRIMENTO AS ComprimentoEX" _
                & ", Producao.Serv_Extra.LARGURA AS LarguraEX" _
                & ", Producao.Serv_Extra.FOLHAS AS FolhasEX" _
                & ", Producao.Serv_Extra.M2 AS M2EX" _
                & ", Producao.Serv_Extra.LINEAR AS LinearEX" _
                & ", Producao.Serv_Extra.QTDE AS QtdeEX" _
                & ", Producao.Serv_Extra.LARGCAIXA AS LargcaixaEX" _
                & ", Producao.Serv_Extra.ACERTOS AS AcertosEX" _
                & ", Producao.Serv_Extra.HORAS AS HorasEX" _
                & " FROM Producao.Serv_Extra INNER JOIN" _
                & " Producao.Serv_Normais ON Producao.Serv_Extra.IDSERV = Producao.Serv_Normais.IDSERV " _
                & " INNER JOIN" _
                & " Producao.Servicos ON Producao.Serv_Extra.IDSERV = Producao.Servicos.IDSERV " _
                & "WHERE Producao.Servicos.IDSERV='" & intID_Entrada & "'"

        Cmd = New SqlClient.SqlCommand(strSQL, Conn)
        Cmd.CommandType = CommandType.Text

        Conn.Open()

        Dim rd As SqlClient.SqlDataReader = Cmd.ExecuteReader

        While rd.Read
            ' intID_Retorno = rd.GetInt32(0)
            'strDescricao_Retorno = rd.GetString(1)

            dt_Entrada = rd.GetDateTime(0)
            intSetorID = rd.GetInt32(1)
            strSetor = rd.GetString(2)
            intMaqID = rd.GetInt32(3)
            strMaq = rd.GetString(4)
            intOperID = rd.GetInt32(5)
            strOper = rd.GetString(6)
            intEmbID = rd.GetInt32(7)
            strEmbalagem = rd.GetString(8)
            intCorteid = rd.GetInt32(9)
            strCorte = rd.GetString(10)
            strObs = rd.GetString(11)
            dbComprimento = rd.GetDecimal(12)
            dbLargura = rd.GetDecimal(13)
            dbFolhas = rd.GetDecimal(14)
            dbM2 = rd.GetDecimal(15)
            dbLinear = rd.GetDecimal(16)
            dbQtde = rd.GetDecimal(17)
            strLarguraCx = rd.GetString(18)
            intAcertos = rd.GetInt32(19)
            intHoras = rd.GetInt32(20)
            dbComprimentoEX = rd.GetDecimal(21)
            dbLarguraEX = rd.GetDecimal(22)
            dbFolhasEX = rd.GetDecimal(23)
            dbM2EX = rd.GetDecimal(24)
            dbLinearEX = rd.GetDecimal(25)
            dbQtdeEX = rd.GetDecimal(26)
            strLarguraCxEX = rd.GetString(27)
            intAcertosEX = rd.GetInt32(28)
            intHorasEX = rd.GetInt32(29)

        End While
        rd.Close()
        Conn.Close()

    End Sub
End Module
