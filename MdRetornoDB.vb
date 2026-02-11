Module MdRetornoDB
   
    Public Sub Last_Record_2C()
        'Rotina que retorna o registro selecionado na lista principal
        Try
            'Lista dados solicitados
            Select Case Item_Menu
                Case 1
                    strSQL = "SELECT MAX(ID) AS ULTIMOID FROM PRODUCAO.MAQUINAS"
                Case 2
                    strSQL = "SELECT MAX(ID) AS ULTIMOID FROM PRODUCAO.OPERADORES"
                Case 3
                    strSQL = "SELECT MAX(ID) AS ULTIMOID FROM PRODUCAO.TP_MOV"
                Case 4
                    strSQL = "SELECT MAX(ID) AS ULTIMOID FROM PRODUCAO.GRUPOS"
                Case 5
                    strSQL = "SELECT MAX(ID) AS ULTIMOID FROM PRODUCAO.MATERIAIS"
                Case 6
                    strSQL = "SELECT MAX(ID) AS ULTIMOID FROM PRODUCAO.SETOR"
                Case 7
                    strSQL = "SELECT MAX(ID) AS ULTIMOID FROM PRODUCAO.TPFacas"
                Case 8
                    strSQL = "SELECT MAX(ID) AS ULTIMOID FROM PRODUCAO.Facas"
                Case 9
                    strSQL = "SELECT MAX(ID) AS ULTIMOID FROM PRODUCAO.ACABAMENTO"
                Case 10
                    strSQL = "SELECT MAX(FICHAID) AS ULTIMOID FROM PRODUCAO.FICHAS"
                Case 11
                    strSQL = "SELECT MAX(IDSERV) AS ULTIMOID FROM PRODUCAO.SERVICOS"
                Case 12
                    strSQL = "SELECT MAX(ID) AS ULTIMOID FROM PRODUCAO.Embalagem"
                Case 13
                    strSQL = "SELECT MAX(ID) AS ULTIMOID FROM Gerenciador.Usuarios"

            End Select

            Cmd = New SqlClient.SqlCommand(strSQL, Conn)
            Cmd.CommandType = CommandType.Text

            Conn.Open()

            Dim rd As SqlClient.SqlDataReader = Cmd.ExecuteReader

            While rd.Read
                intID_Retorno = rd.GetInt32(0) + 1
            End While

            rd.Close()
            Conn.Close()

        Catch ex As Exception
            intID_Retorno = 1
            Conn.Close()
            Exit Sub
        End Try
      
    End Sub
    Public Sub Exibir_Dados_2C()
        'Rotina que retorna o registro selecionado na lista principal

        'Exibe dados solicitados
        Select Case Item_Menu
            Case 1
                strSQL = "SELECT * FROM PRODUCAO.MAQUINAS WHERE ID='" & intID_Entrada & "'"
            Case 2
                strSQL = "SELECT * FROM PRODUCAO.OPERADORES WHERE ID='" & intID_Entrada & "'"
            Case 3
                strSQL = "SELECT * FROM PRODUCAO.TP_MOV WHERE ID='" & intID_Entrada & "'"
            Case 4
                strSQL = "SELECT * FROM PRODUCAO.GRUPOS WHERE ID='" & intID_Entrada & "'"
            Case 6
                strSQL = "SELECT * FROM PRODUCAO.SETOR WHERE ID='" & intID_Entrada & "'"
            Case 9
                strSQL = "SELECT * FROM PRODUCAO.ACABAMENTO WHERE ID='" & intID_Entrada & "'"
        End Select

        Cmd = New SqlClient.SqlCommand(strSQL, Conn)
        Cmd.CommandType = CommandType.Text

        Conn.Open()

        Dim rd As SqlClient.SqlDataReader = Cmd.ExecuteReader

        While rd.Read

            intID_Retorno = rd.GetInt32(0)
            strDescricao_Retorno = rd.GetString(1)

        End While

        rd.Close()
        Conn.Close()
    End Sub


    Public Sub Carrega_Combo()
        'Carrega Combos do formulário selecionado

        'Seleciona os registros
        Select Case TP_Combo
            Case 1
                strSQL = "SELECT * FROM PRODUCAO.MAQUINAS"
            Case 2
                strSQL = "SELECT * FROM PRODUCAO.OPERADORES"
            Case 3
                strSQL = "SELECT * FROM PRODUCAO.TP_MOV"
            Case 4
                strSQL = "SELECT * FROM PRODUCAO.GRUPOS"
            Case 5
                strSQL = "SELECT * FROM PRODUCAO.TPFACAS"
            Case 6
                strSQL = "SELECT NOME FROM VENDAS.VENDEDORES"
            Case 7
                strSQL = "SELECT Descricao FROM PRODUCAO.SETOR"
        End Select

        Cmd = New SqlClient.SqlCommand(strSQL, Conn)
        Cmd.CommandType = CommandType.Text

        Conn.Open()

        Dim rd As SqlClient.SqlDataReader = Cmd.ExecuteReader

        While rd.Read
            Select Case Item_Menu
                Case 1
                    'Reservado
                Case 2
                    'Reservado
                Case 3
                    'Reservado
                Case 4
                    'Reservado
                Case 5
                    'Tela Cadastro de Materia-Prima / Carrega combo do formulário MP
                    FrmMateriaPrima.Cbo1.Items.Add(rd.GetString(1))
                    FrmMateriaPrima.Cbo2.Items.Add(rd.GetString(1))
                Case 8
                    'Tela Cadastro de facas / Carrega combo do formulário Facas
                    FrmFacas.Cbo1.Items.Add(rd.GetString(2))
                Case 10
                    'Tela Fichas de produção / Carrega o combo Vendedor.
                    If TP_Combo = 6 Then
                        FrmFichas.Cbo1.Items.Add(rd.GetString(0))
                    Else
                        FrmFichas.Cbo2.Items.Add(rd.GetString(1))
                    End If
                Case 11
                    'Tela de Serviços.
                    If TP_Combo = 7 Then
                        FrmServico.Cbo1.Items.Add(rd.GetString(0))
                    End If
                    If TP_Combo = 1 Then
                        FrmServico.Cbo2.Items.Add(rd.GetString(1))
                    End If
                    If TP_Combo = 2 Then
                        FrmServico.Cbo3.Items.Add(rd.GetString(1))
                    End If

                Case 12
                    'Carrega o combo Vendedores.
                    If TP_Combo = 1 Then
                        FrmTecnica.CboMaq.Items.Add(rd.GetString(1))
                    End If

                    If TP_Combo = 6 Then
                        FrmTecnica.CboVend.Items.Add(rd.GetString(0))
                    End If

            End Select

        End While

        rd.Close()
        Conn.Close()
    End Sub

    Public Sub Consulta()
        ' Rotina usada para carregar o formulário FrmConsulta.
        Select Case strConsulta
            Case "Cliente"
                strSQL = "SELECT clienteid,fantasia FROM VENDAS.CLIENTE WHERE fantasia like '%" & FrmConsulta.ToolStripTextBox1.Text & "%' ORDER BY CLIENTEID"

            Case "Facas"

                strSQL = "SELECT ID as [Código],Medida,TP as [Tipo], TPDescricao as [Descrição],Area,Cartao as [Cartão],Micro FROM Producao.Facas Where Medida like '%" & FrmConsulta.ToolStripTextBox1.Text & "%' ORDER BY ID"

            Case "Material"

                strSQL = "SELECT ID as [Código],UN,GrupoID as [Cod.Grupo],Grupo,Tipo,Gramatura,Medida,AcabamentoId as [Cod.Acab.],Acabamento FROM Producao.Materiais Where Grupo like '%" & FrmConsulta.ToolStripTextBox1.Text & "%' ORDER BY ID"

            Case Else

        End Select

        Conn.Open()

        Dim cmd As New SqlClient.SqlCommand(strSQL, Conn)
        Dim da = New SqlClient.SqlDataAdapter(cmd)
        Dim ds = New DataSet

        da.SelectCommand.CommandType = CommandType.Text

        da.Fill(ds, strSQL)
        FrmConsulta.DataGridView1.DataSource = ds.Tables(0)

        Conn.Close()


    End Sub

End Module
