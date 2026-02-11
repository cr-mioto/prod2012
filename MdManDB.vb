Module MdManDB
    Public Sub Registros_2C()
        'Inclusão de Registro
        Try

            '*****  Declara um SQLCommand *******

            Cmd = New SqlClient.SqlCommand("Producao.usp_Man_2C", Conn)
            Cmd.CommandType = CommandType.StoredProcedure

            '******  Passando Parametros *******

            With Cmd
                .Parameters.Add("@ID", SqlDbType.Int).Value = intID_Entrada
                .Parameters.Add("@Descricao", SqlDbType.NVarChar).Value = strDescricao_Entrada
                .Parameters.Add("@VF_MAN", SqlDbType.Int).Value = intAC
                .Parameters.Add("@Item_Menu", SqlDbType.Int).Value = Item_Menu
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

            Exit Sub

        Catch ex As Exception

            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try

    End Sub
    Public Sub MP()
        'Manutenção de Matéria-Prima

        Try
            Cmd = New SqlClient.SqlCommand("Producao.usp_Man_MP", Conn)
            Cmd.CommandType = CommandType.StoredProcedure

            With Cmd

                .Parameters.Add("@ID", SqlDbType.Int).Value = intID_Entrada
                .Parameters.Add("@Descricao", SqlDbType.NVarChar).Value = strDescricao_Entrada
                .Parameters.Add("@UN", SqlDbType.NChar).Value = strUN_Entrada
                .Parameters.Add("@GrupoID", SqlDbType.Int).Value = intGRP_Entrada
                .Parameters.Add("@Grupo", SqlDbType.NVarChar).Value = strGRP_Entrada
                .Parameters.Add("@Tipo", SqlDbType.NChar).Value = strTP_Material
                .Parameters.Add("@Gramatura", SqlDbType.Int).Value = intGramatura
                .Parameters.Add("@Medida", SqlDbType.NChar).Value = strMedida
                .Parameters.Add("@AcabamentoID", SqlDbType.Int).Value = intAcabamentoID
                .Parameters.Add("@Acabamento", SqlDbType.NChar).Value = strAcabamento
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
    Public Sub TPFacas()
        'Manutenção de Tipos de Facas

        Try
            Cmd = New SqlClient.SqlCommand("Producao.usp_TP_Facas", Conn)
            Cmd.CommandType = CommandType.StoredProcedure

            With Cmd

                .Parameters.Add("@ID", SqlDbType.Int).Value = intID_Entrada
                .Parameters.Add("@TP", SqlDbType.NVarChar).Value = strTP_Entrada
                .Parameters.Add("@Descricao", SqlDbType.NChar).Value = strDescricao_Entrada
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
    Public Sub Facas()
        'Manutenção do Cadastro de Facas.

        Try
            Cmd = New SqlClient.SqlCommand("Producao.usp_Man_Facas", Conn)
            Cmd.CommandType = CommandType.StoredProcedure

            With Cmd

                .Parameters.Add("@ID", SqlDbType.Int).Value = intID_Entrada
                .Parameters.Add("@Data", SqlDbType.SmallDateTime).Value = dt_Entrada
                .Parameters.Add("@Medida", SqlDbType.NVarChar).Value = strMedida
                .Parameters.Add("@TP", SqlDbType.NChar).Value = strTP_Entrada
                .Parameters.Add("@TPDescricao", SqlDbType.NVarChar).Value = strDescricao_Entrada
                .Parameters.Add("@Qtde", SqlDbType.Int).Value = intQtde
                .Parameters.Add("@Area", SqlDbType.NVarChar).Value = strArea
                .Parameters.Add("@Cartao", SqlDbType.NVarChar).Value = strCartao
                .Parameters.Add("@Micro", SqlDbType.NVarChar).Value = strMicro
                .Parameters.Add("@Arranjo", SqlDbType.Decimal).Value = dbArranjo
                .Parameters.Add("@Obs", SqlDbType.NVarChar).Value = strObs
                .Parameters.Add("@Status", SqlDbType.Bit).Value = blnStatus
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

    Public Sub Fichas()
        'Manutneção do cadastro de fichas.
        Try

            Cmd = New SqlClient.SqlCommand("Producao.usp_Man_Fichas", Conn)
            Cmd.CommandType = CommandType.StoredProcedure

            With Cmd

                .Parameters.Add("@FICHAID", SqlDbType.Int).Value = intID_Entrada
                .Parameters.Add("@EMISSAO", SqlDbType.SmallDateTime).Value = dt_Entrada
                .Parameters.Add("@COD_CLIENTE", SqlDbType.Int).Value = intCli
                .Parameters.Add("@NOME_CLIENTE", SqlDbType.NVarChar).Value = strCli
                .Parameters.Add("@COD_VENDEDOR", SqlDbType.Int).Value = intVen
                .Parameters.Add("@NOME_VENDEDOR", SqlDbType.NVarChar).Value = strVen
                .Parameters.Add("@PEDIDO", SqlDbType.Int).Value = intPed
                .Parameters.Add("@COD_EMBALAGEM", SqlDbType.Int).Value = intEmb
                .Parameters.Add("@COD_GE", SqlDbType.Int).Value = intCodGe
                .Parameters.Add("@QTDE_CAIXA", SqlDbType.Int).Value = intQtde
                .Parameters.Add("@MAQUINA", SqlDbType.NVarChar).Value = strMaq
                .Parameters.Add("@VIA", SqlDbType.NChar).Value = "A"
                .Parameters.Add("@GAVETA", SqlDbType.NChar).Value = strGaveta
                .Parameters.Add("@FURO", SqlDbType.NVarChar).Value = strFuro
                .Parameters.Add("@INFO_FURO", SqlDbType.NVarChar).Value = strInfo_Furo
                .Parameters.Add("@VF_MAN", SqlDbType.Int).Value = intAC

            End With

            Conn.Open()
            Cmd.ExecuteNonQuery()
            Conn.Close()

            Select Case intAC
                Case 1
                    MsgBox("Cabeçalho gravado com sucesso.", MsgBoxStyle.Information)
                Case 2
                    MsgBox("Cabeçalho alterado com sucesso.", MsgBoxStyle.Information)
                Case 4
                    MsgBox("Ficha excluida com sucesso.", MsgBoxStyle.Information)
            End Select
        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try

    End Sub


    Public Sub Fichas_Entregas()
        'Manutenção das entregas das fichas.
        Try

            Cmd = New SqlClient.SqlCommand("Producao.usp_Man_Fichas_Entrega", Conn)
            Cmd.CommandType = CommandType.StoredProcedure


            With Cmd

                .Parameters.Add("@FICHAID", SqlDbType.Int).Value = intID_Entrada
                .Parameters.Add("@ITEM", SqlDbType.Int).Value = intItem
                .Parameters.Add("@DATA", SqlDbType.SmallDateTime).Value = dt_Entrada
                .Parameters.Add("@QTDE", SqlDbType.Int).Value = intQtde
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

    Public Sub Fichas_Obs()
        'Manutenção das Observações das fichas.
        Try

            Cmd = New SqlClient.SqlCommand("Producao.usp_Man_Fichas_Obs", Conn)
            Cmd.CommandType = CommandType.StoredProcedure


            With Cmd

                .Parameters.Add("@FICHAID", SqlDbType.Int).Value = intID_Entrada
                .Parameters.Add("@OBS", SqlDbType.NVarChar).Value = strObs
                .Parameters.Add("@VF_MAN", SqlDbType.Int).Value = intAC

            End With

            Conn.Open()
            Cmd.ExecuteNonQuery()
            Conn.Close()

            Select Case intAC
                Case 1
                    MsgBox("Observações gravadas com sucesso.", MsgBoxStyle.Information)
                Case 2
                    MsgBox("Observações alteradas com sucesso.", MsgBoxStyle.Information)
                Case 4
                    MsgBox("Observações excluidas com sucesso.", MsgBoxStyle.Information)
            End Select

        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub

        End Try
    End Sub

    
End Module
