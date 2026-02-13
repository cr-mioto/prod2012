Imports System.IO
Imports System.Data.SqlTypes

Public Class FrmTecnica

    Private Sub FrmTecnica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Select Case intAC
                Case 1
                    Me.Text = "Cadastro de Embalagens - Inclusão de Registro"
                    MdRetornoDB.Last_Record_2C()
                    TxtID.Text = intID_Retorno
                    TxtNome.Select()
                    BtnNovo.Visible = True
                Case 2
                    Me.Text = "Cadastro de Embalagens - Edição de Registro"
                    Carrega_Cabecalho()
                    Carrega_Matrizes()
                    AtualizaImagem()
                    BtnNovo.Visible = False
                Case 3
                    Me.Text = "Cadastro de Embalagens - Visualizar Registro "

                    'Bloqueando os campos .

                    TxtID.Enabled = False
                    TxtCodGE.Enabled = False
                    TxtNome.Enabled = False
                    TxtMedida.Enabled = False
                    TxtPeso.Enabled = False
                    DtData.Enabled = False
                    CboStatus.Enabled = False
                    CboMaq.Enabled = False
                    TxtCodCli.Enabled = False
                    TxtRazao.Enabled = False
                    TxtCodVen.Enabled = False
                    CboVend.Enabled = False
                    CboFuro.Enabled = False
                    TxtInfo.Enabled = False
                    TxtGaveta.Enabled = False
                    TxtObs.Enabled = False
                    GridMatriz.ReadOnly = True

                    'Carregando os dados das tabelas.

                    Carrega_Cabecalho()
                    Carrega_Matrizes()
                    AtualizaImagem()

                    BtnNovo.Visible = False

                Case 4
                    Me.Text = "Cadastro de Embalagens - Exclusão de Registro "

                    'Bloqueando os campos .

                    TxtID.Enabled = False
                    TxtCodGE.Enabled = False
                    TxtNome.Enabled = False
                    TxtMedida.Enabled = False
                    TxtPeso.Enabled = False
                    DtData.Enabled = False
                    CboStatus.Enabled = False
                    CboMaq.Enabled = False
                    TxtCodCli.Enabled = False
                    TxtRazao.Enabled = False
                    TxtCodVen.Enabled = False
                    CboVend.Enabled = False
                    CboFuro.Enabled = False
                    TxtInfo.Enabled = False
                    TxtGaveta.Enabled = False
                    TxtObs.Enabled = False
                    GridMatriz.ReadOnly = True

                    'Carregando os dados das tabelas.

                    Carrega_Cabecalho()
                    Carrega_Matrizes()
                    AtualizaImagem()

                    BtnNovo.Visible = False

            End Select

        Catch ex As Exception
            ' MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            MsgBox("É necessário selecionar um item da lista.", vbCritical)
            Conn.Close()
            Exit Sub
        End Try


    End Sub


    Private Sub Carrega_Cabecalho()

        'Busca os dados do cabeçalho da embalagem.

        Try

            strSQL = "Producao.usp_Busca_Embalagem"

            Cmd = New SqlClient.SqlCommand(strSQL, Conn)
            Cmd.CommandType = CommandType.StoredProcedure

            With Cmd.Parameters
                .Add("@VF_BUSCA", SqlDbType.Int).Value = 1
                .Add("@ID", SqlDbType.Int).Value = intID_Entrada
            End With

            Conn.Open()

            Dim rd As SqlClient.SqlDataReader = Cmd.ExecuteReader

            While rd.Read
                TxtID.Text = intID_Entrada
                TxtNome.Text = rd.GetString(0)
                TxtMedida.Text = rd.GetString(1)
                DtData.Value = rd.GetDateTime(2)
                CboStatus.Text = rd.GetString(3)
                CboMaq.Text = rd.GetString(4)
                TxtCodCli.Text = rd.GetInt32(5)
                TxtRazao.Text = rd.GetString(6)
                TxtCodVen.Text = rd.GetInt32(7)
                CboVend.Text = rd.GetString(8)
                CboFuro.Text = rd.GetString(9)
                TxtInfo.Text = rd.GetString(10)
                TxtGaveta.Text = rd.GetString(11)
                TxtObs.Text = rd.GetString(12)
                TxtPeso.Text = rd.GetDecimal(13)
                TxtCodGE.Text = rd.GetInt32(14)
            End While

            rd.Close()
            Conn.Close()

        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub CboMaq_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CboMaq.MouseClick
        TP_Combo = 1
        CboMaq.Items.Clear()
        MdRetornoDB.Carrega_Combo()
    End Sub

    Private Sub CboVend_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CboVend.MouseClick
        TP_Combo = 6
        CboVend.Items.Clear()
        MdRetornoDB.Carrega_Combo()
    End Sub


    Private Sub Grava_Cabecalho()
        'Manutneção do cadastro de Embalagens.
        Try

            'Carregando as variáveis.
            intID_Entrada = TxtID.Text
            intCodGe = TxtCodGE.Text
            dt_Entrada = DtData.Value
            strStatus = CboStatus.Text
            intCli = TxtCodCli.Text
            strCli = TxtRazao.Text
            intVen = TxtCodVen.Text
            strVen = CboVend.Text
            strMedida = TxtMedida.Text
            dbpeso = TxtPeso.Text
            strNome_Embalagem = TxtNome.Text
            strMaq = CboMaq.Text
            strFuro = CboFuro.Text
            strInfo_Furo = TxtInfo.Text
            strGaveta = TxtGaveta.Text
            strObs = TxtObs.Text

            Cmd = New SqlClient.SqlCommand("Producao.usp_Man_Embalagem", Conn)
            Cmd.CommandType = CommandType.StoredProcedure

            With Cmd

                .Parameters.Add("@ID", SqlDbType.Int).Value = intID_Entrada
                .Parameters.Add("@Data", SqlDbType.Date).Value = dt_Entrada
                .Parameters.Add("@COD_CLIENTE", SqlDbType.Int).Value = intCli
                .Parameters.Add("@NOME_CLIENTE", SqlDbType.NVarChar).Value = strCli
                .Parameters.Add("@COD_VENDEDOR", SqlDbType.Int).Value = intVen
                .Parameters.Add("@NOME_VENDEDOR", SqlDbType.NVarChar).Value = strVen
                .Parameters.Add("@MEDIDA", SqlDbType.NVarChar).Value = strMedida
                .Parameters.Add("@PESO", SqlDbType.Decimal).Value = dbpeso
                .Parameters.Add("@NOME", SqlDbType.NVarChar).Value = strNome_Embalagem
                .Parameters.Add("@MAQUINA", SqlDbType.NVarChar).Value = strMaq
                .Parameters.Add("@FURO", SqlDbType.NVarChar).Value = strFuro
                .Parameters.Add("@INFO_FURO", SqlDbType.NVarChar).Value = strInfo_Furo
                .Parameters.Add("@GAVETA", SqlDbType.NVarChar).Value = strGaveta
                .Parameters.Add("@OBSERVACOES", SqlDbType.NVarChar).Value = strObs
                .Parameters.Add("@SITUACAO", SqlDbType.NVarChar).Value = strStatus
                .Parameters.Add("@COD_GE", SqlDbType.Int).Value = intCodGe
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
                    MsgBox("Embalagem excluida com sucesso.", MsgBoxStyle.Information)
            End Select
        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        'Gravando os Registros.

        intID_Entrada = TxtID.Text

        Grava_Cabecalho()

        If intAC = 4 Then
            'Se for uma exclusão não gravar as matrizes.
            Listar_Principal()
            Exit Sub
        Else
            'Caso contrário grave as matrizes.
            Grava_Matrizes()
        End If

        Listar_Principal()

    End Sub

    Private Sub TxtCodCli_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodCli.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True

            Try
                intID = TxtCodCli.Text

                ' -- *** Busca o nome de fantasia do cliente. *** -- 
                strSQL = "SELECT Razao FROM Vendas.Cliente WHERE ClienteID='" & intID & "'"
                Cmd = New SqlClient.SqlCommand(strSQL, Conn)
                Cmd.CommandType = CommandType.Text

                Conn.Open()

                Dim rd As SqlClient.SqlDataReader = Cmd.ExecuteReader

                While rd.Read
                    TxtRazao.Text = rd.GetString(0)
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

    Private Sub GridMatriz_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridMatriz.CellEnter
        '  MsgBox(DataGridView2.Rows(e.RowIndex).Cells(1).Value)
        If tmpexibe = True Then
            Exit Sub
        End If

        Dim vf_existe As Boolean

        intID = GridMatriz.Rows(e.RowIndex).Cells(1).Value

        strSQL = "SELECT Medida,TP,TPDescricao,Area,Micro,Cartao FROM Producao.Facas WHERE ID='" & intID & "'"

        Cmd = New SqlClient.SqlCommand(strSQL, Conn)
        Cmd.CommandType = CommandType.Text

        Conn.Open()

        Dim rd As SqlClient.SqlDataReader = Cmd.ExecuteReader

        vf_existe = False

        While rd.Read

            GridMatriz.Rows(e.RowIndex).Cells(2).Value = rd.GetString(0)
            GridMatriz.Rows(e.RowIndex).Cells(3).Value = rd.GetString(1)  '+ " - " + rd.GetString(2)
            GridMatriz.Rows(e.RowIndex).Cells(4).Value = rd.GetString(3)
            GridMatriz.Rows(e.RowIndex).Cells(5).Value = rd.GetString(4)
            GridMatriz.Rows(e.RowIndex).Cells(6).Value = rd.GetString(5)

            vf_existe = True

        End While


        If vf_existe = False Then

            GridMatriz.Rows(e.RowIndex).Cells(2).Value = ""
            GridMatriz.Rows(e.RowIndex).Cells(3).Value = ""
            GridMatriz.Rows(e.RowIndex).Cells(4).Value = ""
            GridMatriz.Rows(e.RowIndex).Cells(5).Value = ""
            GridMatriz.Rows(e.RowIndex).Cells(6).Value = ""

        End If


        rd.Close()
        Conn.Close()
    End Sub


    Private Sub Grava_Matrizes()
        Try

            'Rotina de Gravação de Matrizes.

            Dim i As Single        'Variável do loop For...Next
            Dim N_Regs As Single   'Variável que define o número de vezes do loop For...Next 
            Dim dblPinca As Double 'Variável que armazena o valor das pinças da maquina.

            N_Regs = GridMatriz.Rows.GetRowCount(0) - 1

            For i = 0 To N_Regs

                ' Carregando Variáveis.

                intItem = GridMatriz.Rows.Item(i).Cells.Item(0).Value
                intMatriz = GridMatriz.Rows.Item(i).Cells.Item(1).Value
                strMedida = GridMatriz.Rows.Item(i).Cells.Item(2).Value
                strTipo = GridMatriz.Rows.Item(i).Cells.Item(3).Value
                strArea = GridMatriz.Rows.Item(i).Cells.Item(4).Value
                strMicro = GridMatriz.Rows.Item(i).Cells.Item(5).Value
                strCartao = GridMatriz.Rows.Item(i).Cells.Item(6).Value
                strCores = GridMatriz.Rows.Item(i).Cells.Item(7).Value
                strImpressao = GridMatriz.Rows.Item(i).Cells.Item(8).Value
                strAcabamento = GridMatriz.Rows.Item(i).Cells.Item(9).Value
                dblPinca = GridMatriz.Rows.Item(i).Cells.Item(10).Value

                If i > intItem Then
                    Exit For
                End If

                '    'Declara um SQLCommand

                Cmd = New SqlClient.SqlCommand("Producao.usp_Man_Embalagem_Matriz", Conn)
                Cmd.CommandType = CommandType.StoredProcedure

                'Passando Parametros

                With Cmd
                    .Parameters.Add("@ID", SqlDbType.Int).Value = intID_Entrada
                    .Parameters.Add("@Item", SqlDbType.Int).Value = intItem
                    .Parameters.Add("@Matriz", SqlDbType.Int).Value = intMatriz
                    .Parameters.Add("@Medida", SqlDbType.NVarChar).Value = strMedida
                    .Parameters.Add("@TP", SqlDbType.NVarChar).Value = strTipo
                    .Parameters.Add("@Area", SqlDbType.NVarChar).Value = strArea
                    .Parameters.Add("@Micro", SqlDbType.NVarChar).Value = strMicro
                    .Parameters.Add("@Cartao", SqlDbType.NVarChar).Value = strCartao
                    .Parameters.Add("@Cores", SqlDbType.NVarChar).Value = strCores
                    .Parameters.Add("@Impressao", SqlDbType.NVarChar).Value = strImpressao
                    .Parameters.Add("@Acabamento", SqlDbType.NVarChar).Value = strAcabamento
                    .Parameters.Add("@Pinca", SqlDbType.Decimal).Value = dblPinca
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

    Private Sub CboVend_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboVend.SelectedValueChanged
        Try

            'Rotina para retornar o código do grupo

            strSQL = "SELECT VENDID FROM VENDAS.VENDEDORES WHERE Nome='" & CboVend.Text & "'"

            Cmd = New SqlClient.SqlCommand(strSQL, Conn)
            Cmd.CommandType = CommandType.Text

            Conn.Open()

            Dim rd As SqlClient.SqlDataReader = Cmd.ExecuteReader

            While rd.Read
                intGRP_Retorno = rd.GetInt32(0)
            End While

            TxtCodVen.Text = intGRP_Retorno

            rd.Close()
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

            strSQL = "Producao.usp_Busca_Embalagem"

            Cmd = New SqlClient.SqlCommand(strSQL, Conn)
            Cmd.CommandType = CommandType.StoredProcedure

            With Cmd.Parameters
                .Add("@VF_BUSCA", SqlDbType.Int).Value = 2
                .Add("@ID", SqlDbType.Int).Value = intID_Entrada
            End With

            Conn.Open()

            Dim rd As SqlClient.SqlDataReader = Cmd.ExecuteReader
            i = 0

            While rd.Read

                GridMatriz.Rows.Add(1)

                GridMatriz.Rows.Item(i).Cells.Item(0).Value = rd.GetInt32(0)
                GridMatriz.Columns.Item(0).Width = 30

                GridMatriz.Rows.Item(i).Cells.Item(1).Value = rd.GetInt32(1)
                GridMatriz.Columns.Item(0).Width = 100

                GridMatriz.Rows.Item(i).Cells.Item(2).Value = rd.GetString(2)
                GridMatriz.Columns.Item(2).Width = 100
                GridMatriz.Columns.Item(2).DefaultCellStyle.BackColor = Color.LightSteelBlue

                GridMatriz.Rows.Item(i).Cells.Item(3).Value = rd.GetString(3)
                GridMatriz.Columns.Item(3).Width = 40
                GridMatriz.Columns.Item(3).DefaultCellStyle.BackColor = Color.LightSteelBlue

                GridMatriz.Rows.Item(i).Cells.Item(4).Value = rd.GetString(4)
                GridMatriz.Columns.Item(4).Width = 100
                GridMatriz.Columns.Item(4).DefaultCellStyle.BackColor = Color.LightSteelBlue

                GridMatriz.Rows.Item(i).Cells.Item(5).Value = rd.GetString(5)
                GridMatriz.Columns.Item(5).Width = 100
                GridMatriz.Columns.Item(5).DefaultCellStyle.BackColor = Color.LightSteelBlue

                GridMatriz.Rows.Item(i).Cells.Item(6).Value = rd.GetString(6)
                GridMatriz.Columns.Item(6).Width = 100
                GridMatriz.Columns.Item(6).DefaultCellStyle.BackColor = Color.LightSteelBlue

                GridMatriz.Rows.Item(i).Cells.Item(7).Value = rd.GetString(7)
                GridMatriz.Columns.Item(7).Width = 150

                GridMatriz.Rows.Item(i).Cells.Item(8).Value = rd.GetString(8)
                GridMatriz.Columns.Item(8).Width = 150

                GridMatriz.Rows.Item(i).Cells.Item(9).Value = rd.GetString(9)
                GridMatriz.Columns.Item(9).Width = 150

                GridMatriz.Rows.Item(i).Cells.Item(10).Value = rd.GetDecimal(10)
                GridMatriz.Columns.Item(10).Width = 100

                i = i + 1

            End While

            Conn.Close()
            tmpexibe = False

        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            tmpexibe = False
            Conn.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub BtnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNovo.Click
        Limpa_Campos()
    End Sub
    Private Sub Limpa_Campos()
        'Limpando os dados dos objetos da tela.

        TxtID.Text = ""
        TxtCodGE.Text = "0"
        DtData.Value = Today
        TxtNome.Text = ""
        TxtMedida.Text = ""
        TxtPeso.Text = ""
        CboMaq.Text = ""
        TxtCodCli.Text = ""
        TxtRazao.Text = ""
        TxtCodVen.Text = ""
        CboVend.Text = ""
        CboFuro.Text = ""
        TxtInfo.Text = ""
        TxtGaveta.Text = ""
        TxtObs.Text = ""

        GridMatriz.DataSource = Nothing
        GridMatriz.Rows.Clear()

        MdRetornoDB.Last_Record_2C()
        TxtID.Text = intID_Retorno
        TxtNome.Select()

    End Sub

    Private Sub BtnFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFoto.Click
        'Rotina de Gravação de Imagem.

        'Define variaveis para gravar a imagem
        Dim SalvaImagem As Boolean = False
        Dim nomeArquivo As String = ""

        Try
            'Cria uma caixa de diálogo para buscar a imagem a ser gravada.

            Dim openDlg As OpenFileDialog = New OpenFileDialog()
            openDlg.Filter = "All JPeg files|*.jpg"

            Dim filter As String = openDlg.Filter
            openDlg.Title = "Abrir Arq. JPeg"

            'Abre a caixa de diáglogo para procurar o arquivo a ser usado como imagem.

            If (openDlg.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                nomeArquivo = openDlg.FileName
                SalvaImagem = True
            Else
                Conn.Close()

                Exit Sub

            End If

            'Caso uma imagem é selecionada então inicia a gravação.        

            If SalvaImagem = True Then
                'Carrega a foto
                Dim fsFoto As FileStream
                fsFoto = New FileStream(nomeArquivo, FileMode.Open)

                Dim fiFoto As FileInfo = New FileInfo(nomeArquivo)
                Dim Temp As Long = fiFoto.Length
                Dim lung As Long = Convert.ToInt32(Temp)
                Dim picture(lung) As Byte

                'Comandos para ler a imagem
                fsFoto.Read(picture, 0, lung)
                fsFoto.Close()

                'Cria um novo objeto SqlClient.Command chamando a Stored Procedure criada na base de dados.
                Dim cmdFoto As New SqlClient.SqlCommand("Producao.usp_Man_Embalagem_Fotos", Conn)
                cmdFoto.CommandType = CommandType.StoredProcedure

                'Passando os parametros.

                With cmdFoto
                    .Parameters.Add("@ID", SqlDbType.Int).Value = intID_Entrada
                    .Parameters.Add("@FOTO", SqlDbType.VarBinary).Value = picture
                    .Parameters.Add("@VF_MAN", SqlDbType.Int).Value = intAC
                End With

                Conn.Open()

                cmdFoto.ExecuteNonQuery()
                cmdFoto.Dispose()

                Conn.Close()

                If intAC = 1 Then
                    MsgBox("Imagem gravada com Sucesso.")
                Else
                    MsgBox("Imagem alterada com sucesso.")
                End If

            End If

            AtualizaImagem()

            Conn.Close()

            Exit Sub

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Conn.Close()
            Exit Sub
        End Try

    End Sub

    Private Sub AtualizaImagem()

        'Rotina para exibir foto da embalagem.
        

        Dim cmdFoto As New SqlClient.SqlCommand("Producao.usp_Busca_Embalagem_Fotos", Conn)
        cmdFoto.CommandType = CommandType.StoredProcedure

        'Passando os parametros.

        With cmdFoto
            .Parameters.Add("@ID", SqlDbType.Int).Value = intID_Entrada
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


    Private Sub BtnZoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnZoom.Click
        FrmZoomPicture.Show()
        'AtualizaImagem()
        ' getFile()
    End Sub

    Private Sub getFile()
        Dim cmd As New SqlClient.SqlCommand("Producao.usp_Busca_Embalagem", Conn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd
            .Parameters.Add("@ID", SqlDbType.Int).Value = intID_Entrada
            .Parameters.Add("@VF_BUSCA", SqlDbType.Int).Value = 4
        End With
        Conn.Open()
        Dim dr As SqlClient.SqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        Dim b() As Byte
        Dim f As System.IO.FileStream
        If dr.Read() Then
            f = New System.IO.FileStream("C:\" & "FOTO.JPG", IO.FileMode.Create)
            b = dr("FOTO")
            f.Write(b, 0, b.Length)
            f.Close()
            f = Nothing
        End If
        dr.Close()
        Conn.Close()
    End Sub

    Private Sub BtnFiltroCli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFiltroCli.Click
        strConsulta = "Cliente"
        strChamada = "Embalagem"
        FrmConsulta.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class