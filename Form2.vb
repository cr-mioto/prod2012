Public Class FormConfig

    Private Sub FormConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtConnString.Text = My.Settings.Conn
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If Not DbHelper.TestarConexao(txtConnString.Text) Then
            MessageBox.Show("Não foi possível conectar com os dados informados.", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        My.Settings.Conn = txtConnString.Text
        My.Settings.Save()

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class