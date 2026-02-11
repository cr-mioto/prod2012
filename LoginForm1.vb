Imports System.Security.Cryptography
Imports System.Text
Public Class Login
    Private dSenha As String
    Private conexao As String
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        If Not ValidarLogin() Then
            Exit Sub
        End If

        AbrirSistema()

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Application title
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'If the application title is missing, use the application name, without the extension
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        Version.Text = ("Versão " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision)


        ' 🔹 Carrega a string salva na variável (TextBox)
        conexao = My.Settings.Conn

        ' Garante que o ambiente esteja válido antes do login
        If Not ValidarAmbiente() Then
            Application.Exit()
        End If


    End Sub
    Private Sub Descripto_Senha()
        ''Descriptografa a senha.
        'Dim myKey As String
        'Dim des As New TripleDESCryptoServiceProvider()
        'Dim hashmd5 As New MD5CryptoServiceProvider()

        'myKey = "SLN"

        'des.Key = hashmd5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(myKey))
        'des.Mode = CipherMode.ECB
        'Dim desdencrypt As ICryptoTransform = des.CreateDecryptor()
        'Dim buff() As Byte = Convert.FromBase64String(strSenha)
        'dSenha = ASCIIEncoding.ASCII.GetString(desdencrypt.TransformFinalBlock(buff, 0, buff.Length))

    End Sub

    Private Sub AbrirSistema()
        FrmPrincipal.Show()
        Me.Hide()
    End Sub

    Private Function AbrirConfiguracao() As Boolean

        Using frm As New FormConfig
            Return frm.ShowDialog() = DialogResult.OK
        End Using

    End Function

    Private Function ValidarLogin() As Boolean

        Dim sql As String =
        "SELECT Nome, Nivel, Senha
         FROM Gerenciador.Usuarios
         WHERE Nome = @Nome"

        Try
            Using conn As New SqlClient.SqlConnection(conexao)
                Using cmd As New SqlClient.SqlCommand(sql, conn)

                    cmd.Parameters.AddWithValue("@Nome", TxtUser.Text)
                    conn.Open()

                    Using rd As SqlClient.SqlDataReader = cmd.ExecuteReader()

                        If Not rd.Read() Then
                            MsgBox("Usuário não cadastrado.", vbExclamation)
                            Return False
                        End If

                        Dim senhaCriptografada As String = rd.GetString(2)
                        Dim senhaBanco As String =
                        DescriptografarSenha(senhaCriptografada)

                        If senhaBanco <> TxtPass.Text Then
                            MsgBox("Senha incorreta.", vbExclamation)
                            Return False
                        End If

                    End Using
                End Using
            End Using

            Return True

        Catch ex As Exception
            MsgBox("Erro ao validar login: " & ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try


    End Function

    Private Function ValidarAmbiente() As Boolean

        ' Não existe string
        If String.IsNullOrWhiteSpace(conexao) Then
            Return AbrirConfiguracao()
        End If

        ' String existe, mas não conecta
        If Not DbHelper.TestarConexao(conexao) Then
            MessageBox.Show("Conexão inválida. Configure novamente.",
                        "Erro de Conexão",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
            Return AbrirConfiguracao()
        End If

        Return True

    End Function

    Private Function DescriptografarSenha(valor As String) As String

        Dim chave As String = "SLN"

        Using des As New TripleDESCryptoServiceProvider()
            Using md5 As New MD5CryptoServiceProvider()

                des.Key = md5.ComputeHash(Encoding.ASCII.GetBytes(chave))
                des.Mode = CipherMode.ECB
                des.Padding = PaddingMode.PKCS7

                Dim decryptor = des.CreateDecryptor()
                Dim buff = Convert.FromBase64String(valor)

                Return Encoding.ASCII.GetString(
                decryptor.TransformFinalBlock(buff, 0, buff.Length)
            )
            End Using
        End Using

    End Function



End Class
