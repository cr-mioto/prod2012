Public Class FrmConsulta

    Private Sub FrmConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
         Select Case strConsulta
            Case "Cliente"
                ToolStripLabel1.Text = "Nome de Fantasia:"
            Case "Facas"
                ToolStripLabel1.Text = "Medida da Faca:"
            Case "Material"
                ToolStripLabel1.Text = "Tipo Material:"
        End Select
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        'Rotina retorna os campos de Código e Nome preenchidos no formulário das fichas.

        Try

            ' -- *** Busca o nome de fantasia do cliente. *** -- 
            strSQL = "SELECT Razao FROM Vendas.Cliente WHERE ClienteID='" & intID & "'"
            Cmd = New SqlClient.SqlCommand(strSQL, Conn)
            Cmd.CommandType = CommandType.Text

            Conn.Open()

            Dim rd As SqlClient.SqlDataReader = Cmd.ExecuteReader

            Select Case strChamada
                Case "Fichas_Cliente"

                    While rd.Read
                        FrmFichas.Txt3.Text = rd.GetString(0)
                    End While

                    FrmFichas.Txt2.Text = intID

                Case "Embalagem"

                    While rd.Read
                        FrmTecnica.TxtRazao.Text = rd.GetString(0)
                    End While

                    FrmTecnica.TxtCodCli.Text = intID

            End Select

            rd.Close()
            Conn.Close()

            Me.Close()


        Catch ex As Exception
            MsgBox("Erro: " + ex.Message, MsgBoxStyle.Critical)
            Conn.Close()
            Exit Sub
        End Try

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        MdRetornoDB.Consulta()
    End Sub

    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
       
        intID = (DataGridView1.Rows(e.RowIndex).Cells(0).Value)

    End Sub
End Class