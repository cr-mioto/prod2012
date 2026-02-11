Public NotInheritable Class SplashProducao

    Private Sub SplashProducao_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'If the application title is missing, use the application name, without the extension
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        Version.Text = ("Version " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision)

        Copyright.Text = My.Application.Info.Copyright


        Application.DoEvents()

        ' 1️⃣ Verifica se existe string de conexão
        If String.IsNullOrWhiteSpace(My.Settings.Conn) Then
            AbrirConfiguracao()
            Return
        End If

        ' 2️⃣ Testa a conexão
        If Not DbHelper.TestarConexao(My.Settings.Conn) Then
            MessageBox.Show("Falha ao conectar ao banco de dados. Configure a conexão.",
                            "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            AbrirConfiguracao()
            Return
        End If

        ' 3️⃣ Tudo OK → abre sistema
        AbrirSistema()

    End Sub

    Private Sub AbrirConfiguracao()
        Using frm As New FormConfig
            If frm.ShowDialog() = DialogResult.OK Then
                AbrirSistema()
            Else
                Application.Exit()
            End If
        End Using
    End Sub

    Private Sub AbrirSistema()
        FrmPrincipal.Show()
        Me.Hide()
    End Sub
End Class
