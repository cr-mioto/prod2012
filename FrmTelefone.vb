Public Class FrmTelefone
    Dim cmdFone As SqlClient.SqlCommand
    Dim cmdLast_Reg As SqlClient.SqlCommand
    Dim VF_Man As Integer
    Dim Cliente_Id As Integer
    Dim Vendedor_Id As Integer


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Grava Registro
        VF_Man = 1
        Try
            'Declara um SQLCommand

            cmdFone = New SqlClient.SqlCommand("Vendas.usp_Telefone_Man", Conn)
            cmdFone.CommandType = CommandType.StoredProcedure

            Select Case VF_FrmFone
                Case 1
                    With cmdFone
                        .Parameters.Add("CLIENTEID", SqlDbType.Int).Value = ClienteID
                        .Parameters.Add("@VENDID", SqlDbType.Int).Value = 0
                        .Parameters.Add("@TRANSPID", SqlDbType.Int).Value = 0
                    End With

                Case 2
                    With cmdFone
                        Vendedor_Id = FrmVendedores.TxtVendID.Text
                        .Parameters.Add("CLIENTEID", SqlDbType.Int).Value = 0
                        .Parameters.Add("@VENDID", SqlDbType.Int).Value = Vendedor_Id
                        .Parameters.Add("@TRANSPID", SqlDbType.Int).Value = 0
                    End With

                Case 3
                    'With cmdFone
                    '    Transp_ID = FrmTransporte.TxtTranspID.Text
                    '    .Parameters.Add("CLIENTEID", SqlDbType.Int).Value = 0
                    '    .Parameters.Add("@VENDID", SqlDbType.Int).Value = 0
                    '    .Parameters.Add("@TRANSPID", SqlDbType.Int).Value = Transp_ID
                    'End With
            End Select

            'Passando Parametros
            With cmdFone
                .Parameters.Add("@ID_FONE", SqlDbType.Int).Value = TxtItem.Text
                .Parameters.Add("@DDD", SqlDbType.Int).Value = TxtDDD.Text
                .Parameters.Add("@TELEFONE", SqlDbType.NVarChar).Value = TxtFone.Text
                .Parameters.Add("@RAMAL", SqlDbType.NVarChar).Value = TxtRamal.Text
                .Parameters.Add("@TIPO", SqlDbType.NVarChar).Value = CboTipo.Text
                .Parameters.Add("@VF_MAN", SqlDbType.Int).Value = VF_Man
                .Parameters.Add("@VF_FORM", SqlDbType.Int).Value = VF_FrmFone

            End With

            Conn.Open()
            cmdFone.ExecuteNonQuery()
            Conn.Close()

            Select Case VF_FrmFone
                Case 1
                    FrmCliente.ListView1.Items.Clear()
                    Listar.Listar_Telefones()
                Case 2
                    FrmVendedores.ListView1.Items.Clear()
                    Listar.Listar_Telefones()

                Case 3
                    'FrmTransporte.ListView1.Items.Clear()
                    'FrmTransporte.Carrega_Telefone()
            End Select

            MsgBox("Telefone adicionado.", MsgBoxStyle.Information)
            Me.Close()
            Exit Sub

        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Last_Reg()

        'cmdLast_Reg = New SqlClient.SqlCommand("select id_fone from cliente_telefones Where clienteid=" & ClienteID & "", Conn)

        'cmdLast_Reg.CommandType = CommandType.Text

        'Conn.Open()


        'Dim rdLast_reg As SqlClient.SqlDataReader = cmdLast_reg.ExecuteReader
        'Lendo o Reader
        'rdLast_reg.Read()

        'Dim i As Integer

        'For i = 1 To 0

        'Next

        'TxtItem.Text = rdLast_reg.GetInt32(0) + 1

        'Conn.Close()

    End Sub

    Private Sub FrmTelefone_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Last_Fone()
    End Sub

    Private Sub Last_Fone()

        '****************************************************************       
        'Autor    : Carlos Mioto
        'Rotina   : Busca o ultimo registro de telefone da tabela 
        '           Vendas.Cliente_Fone cadastrado e soma 1.
        'Criada em: <26/04/2011> 
        '****************************************************************

        Try
            Dim strSql As String
            Dim cmdtelefone As SqlClient.SqlCommand

            Select Case VF_FrmFone
                Case 1
                    strSql = "select max(id_fone)as UltimoID from vendas.cliente_fone where clienteid=" & ClienteID & ""
                Case 2
                    strSql = "select max(id_fone)as UltimoID from VENDAS.VENDEDOR_FONE where VENDID=" & VendID & ""
                Case 3
                    ' strSql = "select max(id_fone)as UltimoID from VENDAS.TRANSPORTE_FONE where TRANSPID=" & Transp_ID & ""
            End Select

            cmdtelefone = New SqlClient.SqlCommand(strSql, Conn)
            cmdtelefone.CommandType = CommandType.Text

            Conn.Open()

            Dim rdTel As SqlClient.SqlDataReader = cmdtelefone.ExecuteReader

            rdTel.Read()
            TxtItem.Text = rdTel.GetInt32(0) + 1
            rdTel.Close()
            Conn.Close()

        Catch ex As Exception
            TxtItem.Text = 1
            Conn.Close()
        End Try

    End Sub

End Class