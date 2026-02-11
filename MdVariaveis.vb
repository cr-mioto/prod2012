Module MdVariaveis
    '************************
    '* Variáveis de Sistema *
    '************************

     '************************
    '* Variáveis de Calculo *
    '************************

    
    '*******************************
    '* Variáveis de Banco de Dados *
    '*******************************

 
    ' Variáveis de Saída do banco
    Public intID_Retorno As Integer             'Sempre armazena o retorno do banco para Código
    Public intSRT_Retorno As String
    Public strDescricao_Retorno As String       'Retorno do banco para Descrição 
    Public strGRP_Retorno As String             'Retorno do banco para Decricao do Grupo
    Public intGRP_Retorno As String             'Retorno do banco para Código de Grupo  
    Public dt_Retorno As Date                   'Retorno do banco para datas.  
    Public strTP_Retorno As String              'Retorno do banco para Sigla do Tipo de Facas.
    Public strMedida, strArea As String         'Retorno do banco para medida e area.
    Public strMicro, strCartao As String        'Retorno do banco para micro e cartao.
    Public dbArranjo, dbpeso As Double           'Retorno do banco para arranjo e peso decimal.
    Public strConsulta As String
    Public strStatus As String                  'Armazena a sistuação de um cadastro.



    'Armazena o tipo de consulta que formulario FrmConsulta deve retornar.

    ' Variáveis de Entrada do banco
    Public intID_Entrada As Integer             'Sempre armazena a entrada do banco para Código
    Public intSRT_Entrada As Integer
    Public strDescricao_Entrada As String       'Sempre armazana a entrada do banco para Descrição 
    Public strUN_Entrada As String              'Sempre armazana o entrada do banco para Unidade (PC,Kg,...) 
    Public strGRP_Entrada As String             'Sempre armazana o entrada do banco para Decricao do Grupo
    Public intGRP_Entrada As String             'Sempre armazana o entrada do banco para Código de Grupo  
    Public strTP_Entrada As String              'Sempre armazena a entrada do banco para Sigla do Tipo de Facas.
    Public intIDMaterial As Integer
    Public intErro As Integer
    Public tmpexibe As Boolean
    Public strNome_Embalagem, strInfo_Furo As String
    Public blnFuro As Boolean
    Public blnStatus As Boolean
    Public dtDe, dtAte As Date
    Public intCodGe As Integer                  'Armazena o código GE



    Public Sub Listar_Principal()

        'Rotina que preenche o listview principal

        Try

            'Lista dados solicitados
            Cmd = New SqlClient.SqlCommand("Producao.usp_Lista", Conn)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.Add("@Item_Menu", SqlDbType.Int).Value = Item_Menu
            Cmd.Parameters.Add("@Filtrar", SqlDbType.Int).Value = intFiltro
            Cmd.Parameters.Add("@TP_Filtrar", SqlDbType.Int).Value = intTP_Filtro
            Cmd.Parameters.Add("@Conteudo", SqlDbType.NVarChar).Value = strFiltrar
            Cmd.Parameters.Add("@De", SqlDbType.SmallDateTime).Value = dtDe
            Cmd.Parameters.Add("@Ate", SqlDbType.SmallDateTime).Value = dtAte

            Conn.Open()

            Dim rd As SqlClient.SqlDataReader = Cmd.ExecuteReader

            'Limpa o listview
            FrmPrincipal.ListView1.Clear()

            Select Case Item_Menu
                Case 5
                    'Carrega o listview para Materiais
                    With FrmPrincipal.ListView1
                        .Columns.Add(rd.GetName(0), 50, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(1), 190, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(2), 60, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(3), 60, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(4), 190, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(5), 70, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(6), 70, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(7), 70, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(8), 190, HorizontalAlignment.Left)
                    End With

                    While rd.Read
                        Dim codigo As String = rd.Item(0)
                        Dim Ls As New ListViewItem(codigo, 0)
                        Ls.SubItems.Add(rd.Item(1))
                        Ls.SubItems.Add(rd.Item(2))
                        Ls.SubItems.Add(rd.Item(3))
                        Ls.SubItems.Add(rd.Item(4))
                        Ls.SubItems.Add(rd.Item(5))
                        Ls.SubItems.Add(rd.Item(6))
                        Ls.SubItems.Add(rd.Item(7))
                        Ls.SubItems.Add(rd.Item(8))
                        FrmPrincipal.ListView1.Items.Add(Ls)
                    End While

                Case 7
                    'Carrega o listview para Tipos de Facas
                    With FrmPrincipal.ListView1
                        .Columns.Add(rd.GetName(0), 120, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(1), 110, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(2), 190, HorizontalAlignment.Left)
                    End With

                    While rd.Read
                        Dim codigo As String = rd.Item(0)
                        Dim Ls As New ListViewItem(codigo, 0)
                        Ls.SubItems.Add(rd.Item(1))
                        Ls.SubItems.Add(rd.Item(2))
                        FrmPrincipal.ListView1.Items.Add(Ls)
                    End While

                Case 8
                    'Carrega o listview para Tipos de Facas
                    With FrmPrincipal.ListView1
                        .Columns.Add(rd.GetName(0), 55, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(1), 90, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(2), 80, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(3), 50, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(4), 50, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(5), 80, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(7), 80, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(6), 80, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(8), 200, HorizontalAlignment.Left)

                    End With
                    While rd.Read
                        Dim codigo As String = rd.Item(0)
                        Dim Ls As New ListViewItem(codigo, 0)
                        Ls.SubItems.Add(rd.Item(1))
                        Ls.SubItems.Add(rd.Item(2))
                        Ls.SubItems.Add(rd.Item(3))
                        Ls.SubItems.Add(rd.Item(4))
                        Ls.SubItems.Add(rd.Item(5))
                        Ls.SubItems.Add(rd.Item(7))
                        Ls.SubItems.Add(rd.Item(6))
                        Ls.SubItems.Add(rd.Item(8))
                        FrmPrincipal.ListView1.Items.Add(Ls)
                    End While
                Case 10
                    'Carrega o listview para Fichas de Produção
                    With FrmPrincipal.ListView1
                        .Columns.Add(rd.GetName(0), 120, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(1), 110, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(2), 120, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(3), 120, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(4), 120, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(5), 120, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(6), 120, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(7), 120, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(8), 120, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(9), 120, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(10), 120, HorizontalAlignment.Left)
                    End With

                    While rd.Read
                        Dim codigo As String = rd.Item(0)
                        Dim Ls As New ListViewItem(codigo, 0)
                        Ls.SubItems.Add(rd.Item(1))
                        Ls.SubItems.Add(rd.Item(2))
                        Ls.SubItems.Add(rd.Item(3))
                        Ls.SubItems.Add(rd.Item(4))
                        Ls.SubItems.Add(rd.Item(5))
                        Ls.SubItems.Add(rd.Item(6))
                        Ls.SubItems.Add(rd.Item(7))
                        Ls.SubItems.Add(rd.Item(8))
                        Ls.SubItems.Add(rd.Item(9))
                        Ls.SubItems.Add(rd.Item(10))
                        FrmPrincipal.ListView1.Items.Add(Ls)
                    End While
                Case 11
                    'Carrega o listview para Fichas de Produção
                    With FrmPrincipal.ListView1
                        .Columns.Add(rd.GetName(0), 120, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(1), 110, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(2), 120, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(3), 120, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(4), 120, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(5), 120, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(6), 120, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(7), 120, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(8), 120, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(9), 120, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(10), 120, HorizontalAlignment.Left)
                    End With

                    While rd.Read
                        Dim codigo As String = rd.Item(0)
                        Dim Ls As New ListViewItem(codigo, 0)
                        Ls.SubItems.Add(rd.Item(1))
                        Ls.SubItems.Add(rd.Item(2))
                        Ls.SubItems.Add(rd.Item(3))
                        Ls.SubItems.Add(rd.Item(4))
                        Ls.SubItems.Add(rd.Item(5))
                        Ls.SubItems.Add(rd.Item(6))
                        Ls.SubItems.Add(rd.Item(7))
                        Ls.SubItems.Add(rd.Item(8))
                        Ls.SubItems.Add(rd.Item(9))
                        Ls.SubItems.Add(rd.Item(10))
                        FrmPrincipal.ListView1.Items.Add(Ls)
                    End While
                Case 12
                    'Carrega o listview para Embalagens 
                    With FrmPrincipal.ListView1
                        .Columns.Add(rd.GetName(0), 40, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(1), 120, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(2), 120, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(3), 110, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(4), 80, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(5), 250, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(6), 100, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(7), 70, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(8), 250, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(9), 250, HorizontalAlignment.Left)
                    End With

                    While rd.Read
                        Dim codigo As String = rd.Item(0)
                        Dim Ls As New ListViewItem(codigo, 0)
                        Ls.SubItems.Add(rd.Item(1))
                        Ls.SubItems.Add(rd.Item(2))
                        Ls.SubItems.Add(rd.Item(3))
                        Ls.SubItems.Add(rd.Item(4))
                        Ls.SubItems.Add(rd.Item(5))
                        Ls.SubItems.Add(rd.Item(6))
                        Ls.SubItems.Add(rd.Item(7))
                        Ls.SubItems.Add(rd.Item(8))
                        Ls.SubItems.Add(rd.Item(9))
                        FrmPrincipal.ListView1.Items.Add(Ls)
                    End While

                Case Else
                    'Carrega o listview Geral
                    With FrmPrincipal.ListView1
                        .Columns.Add(rd.GetName(0), 120, HorizontalAlignment.Left)
                        .Columns.Add(rd.GetName(1), 110, HorizontalAlignment.Left)
                    End With

                    While rd.Read
                        Dim codigo As String = rd.Item(0)
                        Dim Ls As New ListViewItem(codigo, 0)
                        Ls.SubItems.Add(rd.Item(1))
                        FrmPrincipal.ListView1.Items.Add(Ls)
                    End While
            End Select
            rd.Close()
            Conn.Close()

        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try


    End Sub
End Module
