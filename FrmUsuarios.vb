
Imports System.Security.Cryptography
Imports System.Text

Public Class FrmUsuarios

    Private Sub FrmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Select Case intAC
                Case 1
                    Me.Text = "Cadastro de Usuários - Inclusão de Registro"
                    MdRetornoDB.Last_Record_2C()
                    TxtID.Text = intID_Retorno
                    TxtNome.Select()
                    BtnNovo.Visible = True
                Case 2
                    Me.Text = "Cadastro de Usuários - Edição de Registro"
                    Carrega_Campos()
                    BtnNovo.Visible = False

                Case 3
                    Me.Text = "Cadastro de Usuários - Visualizar Registro "

                    'Bloqueando os campos .

                    TxtID.Enabled = False
                    TxtNome.Enabled = False
                    TxtNivel.Enabled = False
                    TxtSenha.Enabled = False
                    TxtSenha2.Enabled = False

                    'Carregando os dados das tabelas.
                    Carrega_Campos()
                    BtnNovo.Visible = False

                Case 4

                    Me.Text = "Cadastro de Usuários - Exclusão de Registro "
                    'Bloqueando os campos .

                    TxtID.Enabled = False
                    TxtNome.Enabled = False
                    TxtNivel.Enabled = False
                    TxtSenha.Enabled = False
                    TxtSenha2.Enabled = False

                    'Carregando os dados das tabelas.

                    Carrega_Campos()

                    BtnNovo.Visible = False

            End Select

        Catch ex As Exception
            ' MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            MsgBox("É necessário selecionar um item da lista.", vbCritical)
            Conn.Close()
            Exit Sub
        End Try

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        'Gravando os Registros.

        intID_Entrada = TxtID.Text

        Grava_Cabecalho()

        Listar_Principal()
    End Sub
    Private Sub Grava_Cabecalho()
        'Manutneção do cadastro de Embalagens.
        Try

            'Carregando as variáveis.
            intID_Entrada = TxtID.Text
            strNome = TxtNome.Text
            intNivel = TxtNivel.Text
            strSenha = TxtSenha.Text
            strSenha2 = TxtSenha2.Text


            'Validando o campo de senhas.

            If strSenha <> strSenha2 Then
                MsgBox("As senhas não conferem favor digitar novamente.", vbExclamation)
                TxtSenha.Select()
                Exit Sub
            End If


            'Criando um HASH para armazenamento das senhas.

            Cripto_Senha()



            Cmd = New SqlClient.SqlCommand("Gerenciador.usp_Man_Usuarios", Conn)
            Cmd.CommandType = CommandType.StoredProcedure

            With Cmd

                .Parameters.Add("@ID", SqlDbType.Int).Value = intID_Entrada
                .Parameters.Add("@NOME", SqlDbType.NVarChar).Value = strNome
                .Parameters.Add("@NIVEL", SqlDbType.Int).Value = intNivel
                .Parameters.Add("@SENHA", SqlDbType.NVarChar).Value = strSenha
                .Parameters.Add("@VF_MAN", SqlDbType.Int).Value = intAC

            End With

            Conn.Open()
            Cmd.ExecuteNonQuery()
            Conn.Close()

            Select Case intAC
                Case 1
                    MsgBox("Usuário gravado com sucesso.", MsgBoxStyle.Information)
                Case 2
                    MsgBox("Usuário alterado com sucesso.", MsgBoxStyle.Information)
                Case 4
                    MsgBox("Usuário excluido com sucesso.", MsgBoxStyle.Information)
            End Select
        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try

    End Sub

    Private Sub Limpa_Campos()

        'Limpa campos do formulário.
        TxtNome.Text = ""
        TxtNivel.Text = ""
        TxtSenha.Text = ""
        TxtSenha2.Text = ""
        MdRetornoDB.Last_Record_2C()
        TxtID.Text = intID_Retorno
        TxtNome.Select()

    End Sub


    Private Sub BtnNovo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnNovo.Click
        Limpa_Campos()
      End Sub


    Private Sub Carrega_Campos()
        'Carrega dados do usuário selecionado.
        'Busca os dados do cabeçalho da embalagem.

        Try

            strSQL = "SELECT Nome,Nivel,Senha FROM Gerenciador.Usuarios WHERE ID='" & intID_Entrada & "'"

            Cmd = New SqlClient.SqlCommand(strSQL, Conn)
            Cmd.CommandType = CommandType.Text

            Conn.Open()

            Dim rd As SqlClient.SqlDataReader = Cmd.ExecuteReader

            While rd.Read

                TxtID.Text = intID_Entrada
                TxtNome.Text = rd.GetString(0)
                TxtNivel.Text = rd.GetInt32(1)
                strSenha = rd.GetString(2)
                Descripto_Senha()

            End While

            rd.Close()
            Conn.Close()

        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub Cripto_Senha()
        'gera o hash e exibe na caixa de texto - HashedPasswordTextBox

        Dim myKey As String
        Dim des As New TripleDESCryptoServiceProvider()
        Dim hashmd5 As New MD5CryptoServiceProvider()

        myKey = "SLN"

        DES.Key = hashmd5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(myKey))
        DES.Mode = CipherMode.ECB
        Dim desdencrypt As ICryptoTransform = DES.CreateEncryptor()
        Dim MyASCIIEncoding = New ASCIIEncoding()
        Dim buff() As Byte = ASCIIEncoding.ASCII.GetBytes(strSenha2)
        strSenha = Convert.ToBase64String(desdencrypt.TransformFinalBlock(buff, 0, buff.Length))


    End Sub

    Private Sub Descripto_Senha()
        'Descriptografa a senha.
        Dim myKey As String
        Dim des As New TripleDESCryptoServiceProvider()
        Dim hashmd5 As New MD5CryptoServiceProvider()

        myKey = "SLN"

        des.Key = hashmd5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(myKey))
        des.Mode = CipherMode.ECB
        Dim desdencrypt As ICryptoTransform = des.CreateDecryptor()
        Dim buff() As Byte = Convert.FromBase64String(strSenha)
        TxtSenha.Text = ASCIIEncoding.ASCII.GetString(desdencrypt.TransformFinalBlock(buff, 0, buff.Length))
        TxtSenha2.Text = TxtSenha.Text

    End Sub

End Class