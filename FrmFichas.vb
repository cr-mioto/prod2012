Imports System.IO
Imports System.Data.SqlTypes
Public Class FrmFichas

    Private Sub FrmFichas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Verifica qual o tipo de dado a ser alterado e Prepara a Tela.

        intLocalForm = 0
        VF_Cabecalho = False


        Select Case intAC
            Case 1
                Me.Text = "Manutenção de Fichas de Produção - Inclusão de Registro"

                BtnNovo.Visible = True

                MdRetornoDB.Last_Record_2C()
                TP_Combo = 6
                MdRetornoDB.Carrega_Combo() 'Carrega o combo Vendedor.
                TP_Combo = 1
                MdRetornoDB.Carrega_Combo() 'Carrega o combo Maquinas.
                Txt1.Text = intID_Retorno
                Txt2.Select()

            Case 2
                Me.Text = "Manutenção de Fichas de Produção - Edição de Registro"

                BtnNovo.Visible = False

                Carrega_Cabecalho()
                Carrega_Entregas()
                'tmpexibe = True
                Carrega_Matrizes()

                Carrega_Materiais()

                Carrega_Imagem()


                TP_Combo = 6
                MdRetornoDB.Carrega_Combo() 'Carrega o combo Vendedor.
                TP_Combo = 1
                MdRetornoDB.Carrega_Combo() 'Carrega o combo Maquinas.

            Case 3
                Me.Text = "Manutenção de Fichas de Produção - Visualizar Registro "

                BtnNovo.Visible = False

                Txt1.Enabled = False
                DT1.Enabled = False
                Txt2.Enabled = False
                Txt3.Enabled = False
                BtnFiltroCli.Enabled = False
                Txt4.Enabled = False
                Cbo1.Enabled = False
                Txt5.Enabled = False
                Txt6.Enabled = False
                TxtGaveta.Enabled = False
                TxtCodGe.Enabled = False
                TxtFuro.Enabled = False
                TxtInfoFuro.Enabled = False
                Txt7.Enabled = False
                Cbo2.Enabled = False
                TXT48.Enabled = False
                DataGridView1.ReadOnly = True
                DataGridView2.ReadOnly = True
                DataGridView3.ReadOnly = True

                Carrega_Cabecalho()
                Carrega_Entregas()
                tmpexibe = True
                Carrega_Matrizes()
                Carrega_Materiais()
                Carrega_Imagem()

            Case 4
                Me.Text = "Manutenção de Fichas de Produção - Exclusão de Registro "

                BtnNovo.Visible = False

                Txt1.Enabled = False
                DT1.Enabled = False
                Txt2.Enabled = False
                Txt3.Enabled = False
                BtnFiltroCli.Enabled = False
                Txt4.Enabled = False
                Cbo1.Enabled = False
                Txt5.Enabled = False
                Txt6.Enabled = False
                TxtGaveta.Enabled = False
                TxtFuro.Enabled = False
                TxtInfoFuro.Enabled = False
                Txt7.Enabled = False
                Cbo2.Enabled = False
                TXT48.Enabled = False
                DataGridView1.ReadOnly = True
                DataGridView2.ReadOnly = True
                DataGridView3.ReadOnly = True

                Carrega_Cabecalho()
                Carrega_Entregas()
                tmpexibe = True
                Carrega_Matrizes()
                Carrega_Materiais()
                Carrega_Imagem()

        End Select
    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Listar_Principal()
    End Sub

    Private Sub Cbo1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cbo1.SelectedValueChanged
        Try

            'Rotina para retornar o código do grupo

            strSQL = "SELECT VENDID FROM VENDAS.VENDEDORES WHERE Nome='" & Cbo1.Text & "'"

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

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click


        If VF_Cabecalho = False Then
            Grava_Cabecalho()
            'Valores_Obs()
            Exit Sub
        End If

        'Verifica Tab Pages do formulário.

        Select Case TabControl1.SelectedTab.Name
            Case "Tb_Entrega"
                Entregas()
                Valores_Obs()
            Case "Tb_Matriz1"
                Grava_Matrizes()
                Grava_Materiais()
            Case "Tb_Imagem"
                intLocalForm = 6
        End Select

        'Atualiza os dados do formulário principal.
        Listar_Principal()

    End Sub

    Private Sub BtnFiltroCli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFiltroCli.Click
        strConsulta = "Cliente"
        strChamada = "Fichas_Cliente"
        FrmConsulta.Show()
    End Sub
    Private Sub Valores_Cabecalho()
        Try
            intID_Entrada = Txt1.Text
            dt_Entrada = DT1.Value
            intCli = Txt2.Text
            strCli = Txt3.Text
            intVen = Txt4.Text
            strVen = Cbo1.Text
            intPed = Txt5.Text
            intEmb = Txt6.Text
            intQtde = Txt7.Text
            strMaq = Cbo2.Text
            strGaveta = TxtGaveta.Text
            strFuro = TxtFuro.Text
            strInfo_Furo = TxtInfoFuro.Text
            intCodGe = TxtCodGe.Text

        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try


    End Sub


    Private Sub Grava_Cabecalho()
        'Passando valores.
        Valores_Cabecalho()

        'Manutenção dos Dados.
        MdManDB.Fichas()
        TabControl1.Enabled = True
        VF_Cabecalho = True

    End Sub

    Private Sub Valores_Obs()

        strObs = TXT48.Text

        'Manutenção de dados.
        MdManDB.Fichas_Obs()

    End Sub

    Private Sub Entregas()
        ' Rotina que irá gravar as Entregas do pedido de venda.

        Try

            intItem = DataGridView1.Rows.GetRowCount(0) - 1

            Dim i As Single
            Dim intQtde_Entrega As Integer
            Dim intItem_entrega As Integer
            Dim DT As Date

            For i = 0 To intItem


                intItem_entrega = DataGridView1.Rows.Item(i).Cells.Item(0).Value
                DT = FormatDateTime(DataGridView1.Rows.Item(i).Cells.Item(1).Value, DateFormat.ShortDate)
                intQtde_Entrega = DataGridView1.Rows.Item(i).Cells.Item(2).Value

                If i > intItem_entrega Then
                    Exit For
                End If

                'Declara um SQLCommand

                Cmd = New SqlClient.SqlCommand("Producao.usp_Man_Fichas_Entrega", Conn)
                Cmd.CommandType = CommandType.StoredProcedure

                'Passando Parametros

                With Cmd
                    .Parameters.Add("@FichaID", SqlDbType.Int).Value = intID_Entrada
                    .Parameters.Add("@Item", SqlDbType.Int).Value = intItem_entrega
                    .Parameters.Add("@Data", SqlDbType.Date).Value = DT
                    .Parameters.Add("@Qtde", SqlDbType.Int).Value = intQtde_Entrega
                    .Parameters.Add("@Vf_Man", SqlDbType.Int).Value = intAC
                End With

                'Executando a Query.
                Conn.Open()
                Cmd.ExecuteNonQuery()
                Conn.Close()

            Next

            MsgBox("Entregas gravadas com sucesso.")

        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try

    End Sub

    Private Sub Grava_Matrizes()

        Try

            'Rotina de Gravação de Matrizes.

            Dim i As Single       'Variável do loop For...Next
            Dim N_Regs As Single  'Variável que define o número de vezes do loop For...Next 

            N_Regs = DataGridView2.Rows.GetRowCount(0) - 1

            For i = 0 To N_Regs

                ' Carregando Variáveis.

                intItem = DataGridView2.Rows.Item(i).Cells.Item(0).Value
                intMatriz = DataGridView2.Rows.Item(i).Cells.Item(1).Value
                strMedida = DataGridView2.Rows.Item(i).Cells.Item(2).Value
                strTipo = DataGridView2.Rows.Item(i).Cells.Item(3).Value
                strArea = DataGridView2.Rows.Item(i).Cells.Item(4).Value
                strMicro = DataGridView2.Rows.Item(i).Cells.Item(5).Value
                strCartao = DataGridView2.Rows.Item(i).Cells.Item(6).Value
                strCores = DataGridView2.Rows.Item(i).Cells.Item(7).Value
                strImpressao = DataGridView2.Rows.Item(i).Cells.Item(8).Value
                strAcabamento = DataGridView2.Rows.Item(i).Cells.Item(9).Value

                If i > intItem Then
                    Exit For
                End If

                '    'Declara um SQLCommand

                Cmd = New SqlClient.SqlCommand("Producao.usp_Man_Fichas_Matriz", Conn)
                Cmd.CommandType = CommandType.StoredProcedure

                'Passando Parametros

                With Cmd
                    .Parameters.Add("@FichaID", SqlDbType.Int).Value = intID_Entrada
                    .Parameters.Add("@Item", SqlDbType.Int).Value = intItem
                    .Parameters.Add("@Matriz", SqlDbType.Int).Value = intMatriz
                    .Parameters.Add("@Medida", SqlDbType.NVarChar).Value = strMedida
                    .Parameters.Add("@Tipo", SqlDbType.NVarChar).Value = strTipo
                    .Parameters.Add("@Area", SqlDbType.NVarChar).Value = strArea
                    .Parameters.Add("@Micro", SqlDbType.NVarChar).Value = strMicro
                    .Parameters.Add("@Cartao", SqlDbType.NVarChar).Value = strCartao
                    .Parameters.Add("@Cores", SqlDbType.NVarChar).Value = strCores
                    .Parameters.Add("@Impressao", SqlDbType.NVarChar).Value = strImpressao
                    .Parameters.Add("@Acabamento", SqlDbType.NVarChar).Value = strAcabamento
                    .Parameters.Add("@Vf_Man", SqlDbType.Int).Value = intAC
                End With

                'Executando a Query.

                Conn.Open()
                Cmd.ExecuteNonQuery()
                Conn.Close()

            Next

            MsgBox("Matrizes Gravadas com sucesso.")

        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try

    End Sub


    Private Sub DataGridView2_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellEnter
        '  MsgBox(DataGridView2.Rows(e.RowIndex).Cells(1).Value)
        If tmpexibe = True Then
            Exit Sub
        End If

        Dim vf_existe As Boolean

        intID = DataGridView2.Rows(e.RowIndex).Cells(1).Value

        strSQL = "SELECT Medida,TP,TPDescricao,Area,Micro,Cartao,[status] FROM Producao.Facas WHERE ID='" & intID & "'"

        Cmd = New SqlClient.SqlCommand(strSQL, Conn)
        Cmd.CommandType = CommandType.Text

        Conn.Open()

        Dim rd As SqlClient.SqlDataReader = Cmd.ExecuteReader

        vf_existe = False


        While rd.Read

            DataGridView2.Rows(e.RowIndex).Cells(2).Value = rd.GetString(0)
            DataGridView2.Rows(e.RowIndex).Cells(3).Value = rd.GetString(1)  '+ " - " + rd.GetString(2)
            DataGridView2.Rows(e.RowIndex).Cells(4).Value = rd.GetString(3)
            DataGridView2.Rows(e.RowIndex).Cells(5).Value = rd.GetString(4)
            DataGridView2.Rows(e.RowIndex).Cells(6).Value = rd.GetString(5)

            'Verifica se a faca é ativa.
            If rd.GetBoolean(6) = False Then
                MsgBox("Faca descontinuada.")
                rd.Close()
                Conn.Close()
                Exit Sub
            End If

            vf_existe = True

        End While


        If vf_existe = False Then

            DataGridView2.Rows(e.RowIndex).Cells(2).Value = ""
            DataGridView2.Rows(e.RowIndex).Cells(3).Value = ""
            DataGridView2.Rows(e.RowIndex).Cells(4).Value = ""
            DataGridView2.Rows(e.RowIndex).Cells(5).Value = ""
            DataGridView2.Rows(e.RowIndex).Cells(6).Value = ""

        End If

      


        rd.Close()
        Conn.Close()


    End Sub

    Private Sub DataGridView3_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellEnter

        Dim vf_existe As Boolean

        'If tmpexibe = True Then
        '    Exit Sub
        'End If

        intQtde = Txt7.Text

        intID = DataGridView3.Rows(e.RowIndex).Cells(1).Value

        intIDMaterial = DataGridView3.Rows(e.RowIndex).Cells(2).Value

        intErro = DataGridView3.Rows(e.RowIndex).Cells(5).Value

        strSQL = "Producao.usp_Busca_Material_Ficha"

        Cmd = New SqlClient.SqlCommand(strSQL, Conn)
        Cmd.CommandType = CommandType.StoredProcedure

        'Parametros.
        With Cmd
            .Parameters.Add("@IDFaca", SqlDbType.Int).Value = intID
            .Parameters.Add("@IDMaterial", SqlDbType.Int).Value = intIDMaterial
            .Parameters.Add("@Qtde_Caixa", SqlDbType.Int).Value = intQtde
            .Parameters.Add("@Erro", SqlDbType.Int).Value = intErro
        End With

        Conn.Open()

        Dim rd As SqlClient.SqlDataReader = Cmd.ExecuteReader

        vf_existe = False

        While rd.Read

            dbTotal_Folhas = rd.GetSqlDecimal(5)

            DataGridView3.Rows(e.RowIndex).Cells(6).Value = rd.GetString(0)
            DataGridView3.Rows(e.RowIndex).Cells(7).Value = rd.GetInt32(1)
            DataGridView3.Rows(e.RowIndex).Cells(8).Value = rd.GetString(2)
            DataGridView3.Rows(e.RowIndex).Cells(9).Value = rd.GetString(3)
            DataGridView3.Rows(e.RowIndex).Cells(3).Value = rd.GetDecimal(4)
            DataGridView3.Rows(e.RowIndex).Cells(10).Value = dbTotal_Folhas
            vf_existe = True

        End While

        If vf_existe = False Then

            DataGridView3.Rows(e.RowIndex).Cells(6).Value = ""
            DataGridView3.Rows(e.RowIndex).Cells(7).Value = ""
            DataGridView3.Rows(e.RowIndex).Cells(8).Value = ""
            DataGridView3.Rows(e.RowIndex).Cells(9).Value = ""
            DataGridView3.Rows(e.RowIndex).Cells(3).Value = ""
            DataGridView3.Rows(e.RowIndex).Cells(10).Value = ""

        End If

        rd.Close()
        Conn.Close()

    End Sub

    Private Sub Grava_Materiais()
        'Rotina de inclusão de materiais.
        Try
  
            N_Regs = DataGridView3.Rows.GetRowCount(0) - 1

            For i = 1 To N_Regs

                ' Carregando Variáveis.

                intItem_Material = DataGridView3.Rows.Item(i - 1).Cells.Item(0).Value
                intMatriz_Material = DataGridView3.Rows.Item(i - 1).Cells.Item(1).Value
                intIDMaterial = DataGridView3.Rows.Item(i - 1).Cells.Item(2).Value
                dbArranjo = DataGridView3.Rows.Item(i - 1).Cells.Item(3).Value
                strComprimento_Material = DataGridView3.Rows.Item(i - 1).Cells.Item(4).Value
                intErro = DataGridView3.Rows.Item(i - 1).Cells.Item(5).Value
                strTipo = DataGridView3.Rows.Item(i - 1).Cells.Item(6).Value
                intGramatura = DataGridView3.Rows.Item(i - 1).Cells.Item(7).Value
                strMedida = DataGridView3.Rows.Item(i - 1).Cells.Item(8).Value
                strAcabamento = DataGridView3.Rows.Item(i - 1).Cells.Item(9).Value
                dbTotal_Folhas = DataGridView3.Rows.Item(i - 1).Cells.Item(10).Value


                'If i > intItem_Material Then
                '    Exit For
                'End If

                '   Declara um SQLCommand

                Cmd = New SqlClient.SqlCommand("Producao.usp_Man_Fichas_Materiais", Conn)
                Cmd.CommandType = CommandType.StoredProcedure

                'Passando Parametros

                With Cmd
                    .Parameters.Add("@FichaID", SqlDbType.Int).Value = intID_Entrada
                    .Parameters.Add("@Item", SqlDbType.Int).Value = intItem_Material
                    .Parameters.Add("@Matriz", SqlDbType.Int).Value = intMatriz_Material
                    .Parameters.Add("@MaterialID", SqlDbType.Int).Value = intIDMaterial
                    .Parameters.Add("@Arranjo", SqlDbType.Decimal).Value = dbArranjo
                    .Parameters.Add("@Comprimento", SqlDbType.NVarChar).Value = strComprimento_Material
                    .Parameters.Add("@Erro", SqlDbType.Int).Value = intErro
                    .Parameters.Add("@Tipo", SqlDbType.NChar).Value = strTipo
                    .Parameters.Add("@Gramatura", SqlDbType.Int).Value = intGramatura
                    .Parameters.Add("@Medida", SqlDbType.NVarChar).Value = strMedida
                    .Parameters.Add("@Acabamento", SqlDbType.NVarChar).Value = strAcabamento
                    .Parameters.Add("@Total_Folhas", SqlDbType.Decimal).Value = dbTotal_Folhas
                    .Parameters.Add("@Vf_Man", SqlDbType.Int).Value = intAC
                End With

                'Executando a Query.

                Conn.Open()
                Cmd.ExecuteNonQuery()
                Conn.Close()

            Next

            MsgBox("Materiais gravados com sucesso.")

        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        strConsulta = "Facas"
        strChamada = "Fichas_Facas"
        FrmConsulta.Show()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        strConsulta = "Material"
        strChamada = "Material"
        FrmConsulta.Show()
    End Sub

    Private Sub Carrega_Cabecalho()
        'Rotina que exibe os dados do cabeçalho e observações da ficha.
        Dim strVIA As String

        Try

            strSQL = "Producao.usp_Busca_Ficha"

            Cmd = New SqlClient.SqlCommand(strSQL, Conn)
            Cmd.CommandType = CommandType.StoredProcedure

            With Cmd.Parameters
                .Add("@VF_BUSCA", SqlDbType.Int).Value = 1
                .Add("@FICHAID", SqlDbType.Int).Value = intID_Entrada
            End With

            Conn.Open()

            Dim rd As SqlClient.SqlDataReader = Cmd.ExecuteReader

            While rd.Read

                Txt1.Text = rd.GetInt32(0)
                DT1.Value = rd.GetDateTime(1)
                Txt2.Text = rd.GetInt32(2)
                Txt3.Text = rd.GetString(3)
                Txt4.Text = rd.GetInt32(4)
                Cbo1.Text = rd.GetString(5)
                Txt5.Text = rd.GetInt32(6)
                Txt6.Text = rd.GetInt32(7)
                TxtCodGe.Text = rd.GetInt32(8)
                Txt7.Text = rd.GetInt32(9)
                Cbo2.Text = rd.GetString(10)
                strVIA = rd.GetString(11)
                TxtGaveta.Text = rd.GetString(12)
                TxtFuro.Text = rd.GetString(13)
                TxtInfoFuro.Text = rd.GetString(14)
                TXT48.Text = rd.GetString(15)


            End While

            rd.Close()
            Conn.Close()

        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try


    End Sub

    Private Sub Carrega_Entregas()
        'Carrega a grade de entregas da ficha .

        Try

            strSQL = "Producao.usp_Busca_Ficha"

            '-- *** Removendo as colunas padrões *** --

            DataGridView1.Columns.Remove("item")
            DataGridView1.Columns.Remove("Data")
            DataGridView1.Columns.Remove("Quantidade")

            '-- *** Carregando o Datagrid por Dataset *** --

            Conn.Open()

            Dim cmd As New SqlClient.SqlCommand(strSQL, Conn)
            Dim da = New SqlClient.SqlDataAdapter(cmd)
            Dim ds = New DataSet

            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.selectcommand.parameters.add("@VF_Busca", SqlDbType.Int).Value = 2
            da.selectcommand.parameters.add("@FichaID", SqlDbType.Int).value = intID_Entrada

            da.Fill(ds, strSQL)
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.Columns.Item(0).Width = 52
            DataGridView1.Columns.Item(1).Width = 200
            DataGridView1.Columns.Item(2).Width = 200
            Conn.Close()


        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub Carrega_Matrizes()
        'Carrega os valores de matrizes da ficha.

        tmpexibe = True

        Try

            Dim i As Integer

            '-- *** Carregando o Datagrid  *** --

            strSQL = "Producao.usp_Busca_Ficha"

            Cmd = New SqlClient.SqlCommand(strSQL, Conn)
            Cmd.CommandType = CommandType.StoredProcedure

            With Cmd.Parameters
                .Add("@VF_BUSCA", SqlDbType.Int).Value = 3
                .Add("@FICHAID", SqlDbType.Int).Value = intID_Entrada
            End With

            Conn.Open()

            Dim rd As SqlClient.SqlDataReader = Cmd.ExecuteReader
            i = 0

            While rd.Read

                DataGridView2.Rows.Add(1)

                DataGridView2.Rows.Item(i).Cells.Item(0).Value = rd.GetInt32(0)
                DataGridView2.Columns.Item(0).Width = 30

                DataGridView2.Rows.Item(i).Cells.Item(1).Value = rd.GetInt32(1)
                DataGridView2.Columns.Item(0).Width = 100

                DataGridView2.Rows.Item(i).Cells.Item(2).Value = rd.GetString(2)
                DataGridView2.Columns.Item(2).Width = 100
                DataGridView2.Columns.Item(2).DefaultCellStyle.BackColor = Color.LightSteelBlue

                DataGridView2.Rows.Item(i).Cells.Item(3).Value = rd.GetString(3)
                DataGridView2.Columns.Item(3).Width = 40
                DataGridView2.Columns.Item(3).DefaultCellStyle.BackColor = Color.LightSteelBlue

                DataGridView2.Rows.Item(i).Cells.Item(4).Value = rd.GetString(4)
                DataGridView2.Columns.Item(4).Width = 100
                DataGridView2.Columns.Item(4).DefaultCellStyle.BackColor = Color.LightSteelBlue

                DataGridView2.Rows.Item(i).Cells.Item(5).Value = rd.GetString(5)
                DataGridView2.Columns.Item(5).Width = 100
                DataGridView2.Columns.Item(5).DefaultCellStyle.BackColor = Color.LightSteelBlue

                DataGridView2.Rows.Item(i).Cells.Item(6).Value = rd.GetString(6)
                DataGridView2.Columns.Item(6).Width = 100
                DataGridView2.Columns.Item(6).DefaultCellStyle.BackColor = Color.LightSteelBlue

                DataGridView2.Rows.Item(i).Cells.Item(7).Value = rd.GetString(7)
                DataGridView2.Columns.Item(7).Width = 150

                DataGridView2.Rows.Item(i).Cells.Item(8).Value = rd.GetString(8)
                DataGridView2.Columns.Item(8).Width = 150

                DataGridView2.Rows.Item(i).Cells.Item(9).Value = rd.GetString(9)
                DataGridView2.Columns.Item(9).Width = 100

                i = i + 1

            End While

            Conn.Close()
            tmpexibe = False


        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            tmpexibe = False
            Exit Sub
        End Try
    End Sub


    Private Sub Carrega_Materiais()
        'Rotina para carregar os materiais da ficha

        Try
            Dim i As Integer

            strSQL = "Producao.usp_Busca_Ficha"

            '-- *** Carregando o Datagrid. *** --

            Cmd = New SqlClient.SqlCommand(strSQL, Conn)
            Cmd.CommandType = CommandType.StoredProcedure

            With Cmd.Parameters
                .Add("@VF_BUSCA", SqlDbType.Int).Value = 4
                .Add("@FICHAID", SqlDbType.Int).Value = intID_Entrada
            End With


            Conn.Open()

            Dim rd As SqlClient.SqlDataReader = Cmd.ExecuteReader
            i = 0

            While rd.Read


                DataGridView3.Rows.Add(1)

                DataGridView3.Rows.Item(i).Cells.Item(0).Value = rd.GetInt32(0)
                DataGridView3.Columns.Item(0).Width = 100

                DataGridView3.Rows.Item(i).Cells.Item(1).Value = rd.GetInt32(1)
                DataGridView3.Columns.Item(1).Width = 100

                DataGridView3.Rows.Item(i).Cells.Item(2).Value = rd.GetInt32(2)
                DataGridView3.Columns.Item(2).Width = 100

                DataGridView3.Rows.Item(i).Cells.Item(3).Value = rd.GetDecimal(3)
                DataGridView3.Columns.Item(3).Width = 100
                DataGridView3.Columns.Item(3).DefaultCellStyle.BackColor = Color.LightSteelBlue

                DataGridView3.Rows.Item(i).Cells.Item(4).Value = rd.GetString(4)
                DataGridView3.Columns.Item(4).Width = 100

                DataGridView3.Rows.Item(i).Cells.Item(5).Value = rd.GetInt32(5)
                DataGridView3.Columns.Item(5).Width = 100

                DataGridView3.Rows.Item(i).Cells.Item(6).Value = rd.GetString(6)
                DataGridView3.Columns.Item(6).Width = 100
                DataGridView3.Columns.Item(6).DefaultCellStyle.BackColor = Color.LightSteelBlue

                DataGridView3.Rows.Item(i).Cells.Item(7).Value = rd.GetInt32(7)
                DataGridView3.Columns.Item(7).Width = 100
                DataGridView3.Columns.Item(7).DefaultCellStyle.BackColor = Color.LightSteelBlue

                DataGridView3.Rows.Item(i).Cells.Item(8).Value = rd.GetString(8)
                DataGridView3.Columns.Item(8).Width = 100
                DataGridView3.Columns.Item(8).DefaultCellStyle.BackColor = Color.LightSteelBlue

                DataGridView3.Rows.Item(i).Cells.Item(9).Value = rd.GetString(9)
                DataGridView3.Columns.Item(9).Width = 100
                DataGridView3.Columns.Item(9).DefaultCellStyle.BackColor = Color.LightSteelBlue

                DataGridView3.Rows.Item(i).Cells.Item(10).Value = rd.GetDecimal(10)
                DataGridView3.Columns.Item(10).Width = 100
                DataGridView3.Columns.Item(10).DefaultCellStyle.BackColor = Color.LightGray

                i = i + 1


            End While


            Conn.Close()


        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub

        End Try


    End Sub

    Private Sub Txt2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt2.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True

            Try
                intID = Txt2.Text

                ' -- *** Busca o nome de fantasia do cliente. *** -- 
                strSQL = "SELECT Razao FROM Vendas.Cliente WHERE ClienteID='" & intID & "'"
                Cmd = New SqlClient.SqlCommand(strSQL, Conn)
                Cmd.CommandType = CommandType.Text

                Conn.Open()

                Dim rd As SqlClient.SqlDataReader = Cmd.ExecuteReader

                While rd.Read
                    Txt3.Text = rd.GetString(0)
                End While

                rd.Close()
                Conn.Close()

            Catch ex As Exception
                MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
                Conn.Close()
                Exit Sub
            End Try

        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Titulo_Janela = "Impressão de Ficha de Produção"
        VF_Report = 3
        FrmReports.Show()
    End Sub


    Private Sub Limpa_Campos()
        Dim i As Integer
        'Rotina de limpeza dos campos da tela.

        Txt1.Text = ""
        DT1.Text = ""
        Txt2.Text = ""
        Txt3.Text = ""
        Txt4.Text = ""
        Cbo1.Text = ""
        Txt5.Text = ""
        Txt6.Text = ""
        TxtGaveta.Text = ""
        Txt7.Text = "0"
        Cbo2.Text = ""
        TXT48.Text = ""
        TxtFuro.Text = ""
        TxtInfoFuro.Text = ""

        'Limpando o DataGridView1
        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()

        'Recriando as colunas
        'DataGridView1.Columns.Add("Item", "Item")
        'DataGridView1.Columns(0).Width = 52

        'DataGridView1.Columns.Add("Data", "Data de Entrega")
        'DataGridView1.Columns(1).Width = 200


        'DataGridView1.Columns.Add("Quantidade", "Quantidade")
        'DataGridView1.Columns(2).Width = 200


        'Limpando o DataGridView2
        DataGridView2.DataSource = Nothing
        DataGridView2.Rows.Clear()

        'Limpando o DataGridView3
        DataGridView3.DataSource = Nothing
        DataGridView3.Rows.Clear()

        MdRetornoDB.Last_Record_2C()
        Txt1.Text = intID_Retorno
        Txt2.Select()
        PicFoto.Image = Nothing
        VF_Cabecalho = False

    End Sub

    Private Sub BtnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNovo.Click
        Limpa_Campos()
    End Sub

    Private Sub Carrega_Embalagem()
        'Rotina trará os dados técnico da embalagem cadastrada.

        tmpexibe = True

        Try

            Dim i As Integer

            '-- *** Carregando o Datagrid  *** --

            strSQL = "Producao.usp_Busca_Embalagem"

            Cmd = New SqlClient.SqlCommand(strSQL, Conn)
            Cmd.CommandType = CommandType.StoredProcedure

            With Cmd.Parameters
                .Add("@VF_BUSCA", SqlDbType.Int).Value = 3
                .Add("@ID", SqlDbType.Int).Value = Txt6.Text
            End With

            Conn.Open()

            Dim rd As SqlClient.SqlDataReader = Cmd.ExecuteReader
            i = 0

            While rd.Read

                DataGridView2.Rows.Add(1)

                DataGridView2.Rows.Item(i).Cells.Item(0).Value = rd.GetInt32(0)
                DataGridView2.Columns.Item(0).Width = 30

                DataGridView2.Rows.Item(i).Cells.Item(1).Value = rd.GetInt32(1)
                DataGridView2.Columns.Item(0).Width = 100

                DataGridView2.Rows.Item(i).Cells.Item(2).Value = rd.GetString(2)
                DataGridView2.Columns.Item(2).Width = 100
                DataGridView2.Columns.Item(2).DefaultCellStyle.BackColor = Color.LightSteelBlue

                DataGridView2.Rows.Item(i).Cells.Item(3).Value = rd.GetString(3)
                DataGridView2.Columns.Item(3).Width = 40
                DataGridView2.Columns.Item(3).DefaultCellStyle.BackColor = Color.LightSteelBlue

                DataGridView2.Rows.Item(i).Cells.Item(4).Value = rd.GetString(4)
                DataGridView2.Columns.Item(4).Width = 100
                DataGridView2.Columns.Item(4).DefaultCellStyle.BackColor = Color.LightSteelBlue

                DataGridView2.Rows.Item(i).Cells.Item(5).Value = rd.GetString(5)
                DataGridView2.Columns.Item(5).Width = 100
                DataGridView2.Columns.Item(5).DefaultCellStyle.BackColor = Color.LightSteelBlue

                DataGridView2.Rows.Item(i).Cells.Item(6).Value = rd.GetString(6)
                DataGridView2.Columns.Item(6).Width = 100
                DataGridView2.Columns.Item(6).DefaultCellStyle.BackColor = Color.LightSteelBlue

                DataGridView2.Rows.Item(i).Cells.Item(7).Value = rd.GetString(7)
                DataGridView2.Columns.Item(7).Width = 150

                DataGridView2.Rows.Item(i).Cells.Item(8).Value = rd.GetString(8)
                DataGridView2.Columns.Item(8).Width = 150

                DataGridView2.Rows.Item(i).Cells.Item(9).Value = rd.GetString(9)
                DataGridView2.Columns.Item(9).Width = 100

                i = i + 1

                TxtGaveta.Text = rd.GetString(10)
                Cbo2.Text = rd.GetString(11)
                TxtFuro.Text = rd.GetString(12)
                TxtInfoFuro.Text = rd.GetString(13)

            End While
           
            Conn.Close()
            tmpexibe = False

        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            tmpexibe = False
            Exit Sub
        End Try
    End Sub

    Private Sub Txt6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt6.KeyPress
        'Se a tecla enter for apertada ela buscará os dados da embalagem informada .
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True

            'Limpando o DataGridView2
            DataGridView2.DataSource = Nothing
            DataGridView2.Rows.Clear()

            'Verifica o Status da embalagem primeiro.
            Verifica_Situacao_Embalagem()

            If strStatus = "DESCONTINUADO" Then
                MsgBox("EMBALAGEM DESCONTINUADA.FAVOR VERIFICAR.", vbExclamation, "ATENÇÃO")
                Exit Sub
            End If

            'Carrega os dados da embalagem se passar na verificação.
            Carrega_Embalagem()
            Carrega_Imagem()

        End If

    End Sub

    Private Sub Verifica_Situacao_Embalagem()
        'Rotina de consulta da situação da embalagem.

        Try

            strSQL = "SELECT Situacao FROM Producao.Embalagem WHERE ID='" & Txt6.Text & "'"
            Cmd = New SqlClient.SqlCommand(strSQL, Conn)
            Cmd.CommandType = CommandType.Text

            Conn.Open()

            Dim rd As SqlClient.SqlDataReader = Cmd.ExecuteReader

            While rd.Read
                strStatus = rd.GetString(0)
            End While

            rd.Close()
            Conn.Close()

        Catch ex As Exception
            Conn.Close()
            Exit Sub
        End Try

    End Sub


    Private Sub Carrega_Imagem()
        'Rotian para exibição da imagem da embalagem.

        'Carregar a imagem em tamanho máximo.

        Dim cmdFoto As New SqlClient.SqlCommand("Producao.usp_Busca_Embalagem_Fotos", Conn)
        cmdFoto.CommandType = CommandType.StoredProcedure

        'Passando os parametros.

        With cmdFoto
            .Parameters.Add("@ID", SqlDbType.Int).Value = Txt6.Text
        End With

        Conn.Open()
        Dim dr As SqlClient.SqlDataReader = cmdFoto.ExecuteReader(CommandBehavior.CloseConnection)

        If dr.Read Then
            Dim bytBLOBData(dr.GetBytes(0, 0, Nothing, 0, Integer.MaxValue) - 1) As Byte
            dr.GetBytes(0, 0, bytBLOBData, 0, bytBLOBData.Length)
            Dim stmBLOBData As New MemoryStream(bytBLOBData)
            PicFoto.Image = Image.FromStream(stmBLOBData)
        End If

        dr.Close()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        'Rotina de remoção de item da ficha de produção.
        'Verifica onde está o foco.

        If intVFGrid = 1 Then
            MsgBox("Sou Matrix")
            intAC = 3

        Else
            MsgBox("Sou Material")
            intAC = 3
            Remove_Item()
            Carrega_Materiais()

        End If
    End Sub

    Private Sub DataGridView2_GotFocus(sender As Object, e As EventArgs) Handles DataGridView2.GotFocus
        intVFGrid = 1
    End Sub


    Private Sub DataGridView3_GotFocus(sender As Object, e As EventArgs) Handles DataGridView3.GotFocus
        intVFGrid = 2
    End Sub

    Private Sub Remove_Item()
        Try
            'Verifica qual Stored Procedure rodar.
            Select Case intVFGrid
                Case 1
                    'Roda Stored Procedure Matrizes.
                Case 2
                    'Roda Stored Procedure Materiais.

                    'Declara um SQLCommand

                    Cmd = New SqlClient.SqlCommand("Producao.usp_Man_Fichas_Materiais", Conn)
                    Cmd.CommandType = CommandType.StoredProcedure

                    'Passando Parametros

                    With Cmd
                        .Parameters.Add("@FichaID", SqlDbType.Int).Value = intID_Entrada
                        .Parameters.Add("@Item", SqlDbType.Int).Value = intItem_Material
                        .Parameters.Add("@Matriz", SqlDbType.Int).Value = intMatriz_Material
                        .Parameters.Add("@MaterialID", SqlDbType.Int).Value = intIDMaterial
                        .Parameters.Add("@Arranjo", SqlDbType.Decimal).Value = dbArranjo
                        .Parameters.Add("@Comprimento", SqlDbType.NVarChar).Value = ""
                        .Parameters.Add("@Erro", SqlDbType.Int).Value = intErro
                        .Parameters.Add("@Tipo", SqlDbType.NChar).Value = ""
                        .Parameters.Add("@Gramatura", SqlDbType.Int).Value = intGramatura
                        .Parameters.Add("@Medida", SqlDbType.NVarChar).Value = ""
                        .Parameters.Add("@Acabamento", SqlDbType.NVarChar).Value = ""
                        .Parameters.Add("@Total_Folhas", SqlDbType.Decimal).Value = 1
                        .Parameters.Add("@Vf_Man", SqlDbType.Int).Value = intAC
                    End With

                    'Executando a Query.

                    Conn.Open()
                    Cmd.ExecuteNonQuery()
                    Conn.Close()

            End Select

        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try

    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        intItem_Material = DataGridView1.Rows(e.RowIndex).Cells(0).Value
    End Sub

    Private Sub Txt7_TextChanged(sender As Object, e As EventArgs) Handles Txt7.TextChanged

    End Sub
End Class