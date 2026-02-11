Public Class FrmTPFacas

    Private Sub FrmTPFacas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Verifica qual o tipo de dado a ser alterado e Prepara a Tela.

        Select Case intAC
            Case 1
                Me.Text = "Cadastro de Tipos de Faca - Inclusão de Registro"
                MdRetornoDB.Last_Record_2C()
                Txt1.Text = intID_Retorno
                Txt2.Select()
            Case 2
                Me.Text = "Cadastro de Tipos de Faca - Edição de Registro"
                Carrega_Campos()
            Case 3
                Me.Text = "Cadastro de Tipos de Faca - Visualizar Registro "
                Txt1.Enabled = False
                Txt2.Enabled = False
                Txt3.Enabled = False
                Carrega_Campos()

            Case 4
                Me.Text = "Cadastro de Tipos de Faca - Exclusão de Registro "
                Txt1.Enabled = False
                Txt2.Enabled = False
                Txt3.Enabled = False
                Carrega_Campos()
        End Select
    End Sub
    Private Sub Carrega_Campos()
        'Rotina que retorna o registro selecionado na lista principal
        'Exibe dados solicitados
        strSQL = "SELECT Id,TP,Descricao FROM PRODUCAO.TPFacas WHERE ID='" & intID_Entrada & "'"

        Cmd = New SqlClient.SqlCommand(strSQL, Conn)
        Cmd.CommandType = CommandType.Text

        Conn.Open()

        Dim rd As SqlClient.SqlDataReader = Cmd.ExecuteReader

        While rd.Read

            intID_Retorno = rd.GetInt32(0)
            strTP_Retorno = rd.GetString(1)
            strDescricao_Retorno = rd.GetString(2)

         End While

        rd.Close()
        Conn.Close()

        Txt1.Text = intID_Retorno
        Txt2.Text = strTP_Retorno
        Txt3.Text = strDescricao_Retorno
       
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        intID_Entrada = Txt1.Text
        strTP_Entrada = Txt2.Text
        strDescricao_Entrada = Txt3.Text
        MdManDB.TPFacas()
        Listar_Principal()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class