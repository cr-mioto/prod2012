Module mdSistema
    '*************************************************
    '****                                        *****
    '****  Variáveis de uso geral do sistema     *****
    '****  pode ser usadas por todos os módulos. *****
    '****                                        *****
    '*************************************************

    'Uso Geral
    Public intVFGrid As Integer                 'Armazena um identificador de foco de gridview.
    Public strTP_Material As String             'Sempre armazana o tipo de material.
    Public intGramatura As Integer              'Sempre armazena a gramatura do material.
    Public strAcabmamento As String             'Sempre armazena o tipo de acabamento .
    Public intCli As Integer                    'Armazena código do cliente.
    Public strCli As String                     'Armazena o nome do cliente.
    Public intVen As Integer                    'Armazena o código do vendedor.
    Public strVen As String                     'Armazena o nome do vendedor.
    Public intPed As Integer                    'Armazena o código do pedido.
    Public intEmb As Integer                    'Armazena o código da embalagem.
    Public intAcabamentoID As Integer
    Public strMaq As String                     'Armazena o nome da máquina.
    Public dt_Entrada As Date                   'Sempre armazana a entrada do banco para data.
    Public intID As Integer                     'Sempre armazena a entrada do banco para Código
    Public strUN_Retorno As String              'Retorno do banco para Unidade (PC,Kg,...) 
    Const strVia As String = "A"                'Armazena uma constante para o campo via do banco. (Provisório).  
    Public VF_Report As Integer                 'Armazena a identificação do relatório.
    Public Report_Param As String               'Armazena o nome do relatório a chamado pelo sistema.
    Public Titulo_Janela As String              'Armazena o nome do relatório no titulo do formulário.
    Public dcPinca_1 As Decimal                 'Armazena o número da pinça da máquina.
    Public dcPinca_2 As Decimal                 'Armazena o número da pinça da máquina.
    Public intLocalForm As Integer              'Armazena o local do formulário para gravação ou alteração do dados.
    Public intItem, intFichaId As Integer       'Armazena valores para itens de tabelas e do código das fichas de produção.
    Public intQtde, intMatriz As Integer        'Armazena valores de quantidade simples.
    Public strObs As String                     'Armazena observações de cadastros com até 2000 caracteres.
    Public strTipo As String                    'Armazena dados de ficha técnica.
    Public strCores, strImpressao As String     'Armazena dados de ficha técnica.
    Public strAcabamento, strGaveta As String   'Armazena dados de ficha técnica.
    Public dbTotal_Folhas As Double             'Armazena total de folhas da ficha de produção.
    'Controle de Telas e acessos.
    Public Item_Menu As Integer                 'Variável que define qual modulo de programa.
    Public Tamanho_C As Integer
    Public intAC As Integer                     'Variável que define o tipo de manutenção dos dados . (1-Incluir,2-Editar,3-Visualizar,4-Excluir)
    Public TP_Combo As Integer                  'Variável que defini o tipo de combo box a ser carregado. (1-Maquinas,2-Operadores,3-Tipo Movimento,4-Grupos,5-Materia-Prima)
    Public intVF_Tab As Integer                 'Variável de identificação de Tab que está selecionada no formulário.
    Public VF_Cabecalho As Boolean              'Verifica se o cabecalho de alguma tela foi gravado. (Sim-Gravado /Não-Não Gravado)
    Public strChamada As String                 'Verificar qual rotina de chamada da pesquisa do formulário de pesquisa.
    Public strFuro As String
    Public strNome, strSenha, strSenha2 As String
    Public intNivel As Integer
    Public i As Single                     'Variável do loop For...Next
    Public N_Regs As Single                'Variável que define o número de vezes do loop For...Next 
    Public intItem_Material As Integer     'Variável de item da lista de materiais.
    Public intMatriz_Material As Integer   'Variável de matriz do material.
    Public strComprimento_Material As String
    'Variáveis de cadastros clientes e vendedores
    Public VF_FrmFone, VendID, VF_Busca, intIndFinal, ClienteID, Vf_Man As Integer
    Public Ativado As Boolean
    Public VF_Pesq As String


    'Calculos
    Public VL_Acerto As Integer                 'Variavel para calculo de acero de maquinas

    ' Váriáveis de conexão
    Public Conn As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.Conn)  'Produção
    'Public Conn As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.Local)  'Local (Desenvolvimento Laptop).

    Public Cmd As SqlClient.SqlCommand
    Public strSQL As String

End Module
