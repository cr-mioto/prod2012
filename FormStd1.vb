Public Class FrmStd1

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    Private Sub FrmStd1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Verifica qual o tipo de dado a ser alterado e Prepara a Tela.
        Select Case Item_Menu
            '========
            'Maquinas
            '========
            Case 1
                Select Case intAC
                    Case 1
                        Me.Text = "Cadastro de Maquinas - Inclusão de Registro"
                        Label1.Text = "Código: "
                        Label2.Text = "Descrição: "
                        MdRetornoDB.Last_Record_2C()
                        Txt1.Text = intID_Retorno
                        Txt2.Select()
                    Case 2
                        Me.Text = "Cadastro de Maquinas - Edição de Registro"
                        Carrega_Campos()
                    Case 3
                        Me.Text = "Cadastro de Maquinas - Visualizar Registro "
                        Txt1.Enabled = False
                        Txt2.Enabled = False
                        Carrega_Campos()
                    Case 4
                        Me.Text = "Cadastro de Maquinas - Exclusão de Registro "
                        Txt1.Enabled = False
                        Txt2.Enabled = False
                        Carrega_Campos()

                End Select

            Case 2
                '==========
                'Operadores
                '==========
                Select Case intAC
                    Case 1
                        Me.Text = "Cadastro de Operadores - Inclusão de Registro"
                        Label1.Text = "Código: "
                        Label2.Text = "Descrição: "
                        MdRetornoDB.Last_Record_2C()
                        Txt1.Text = intID_Retorno
                        Txt2.Select()
                    Case 2
                        Me.Text = "Cadastro de Operadores - Edição de Registro"
                        Carrega_Campos()
                    Case 3
                        Me.Text = "Cadastro de Opedadores - Visualizar Registro "
                        Txt1.Enabled = False
                        Txt2.Enabled = False
                        Carrega_Campos()
                    Case 4
                        Me.Text = "Cadastro de Operadores - Exclusão de Registro "
                        Txt1.Enabled = False
                        Txt2.Enabled = False
                        Carrega_Campos()
                End Select
            Case 3
                '==================
                'Tipos de Movimento
                '==================
                Select Case intAC
                    Case 1
                        Me.Text = "Cadastro de Tipos de Movimento - Inclusão de Registro"
                        Label1.Text = "Código: "
                        Label2.Text = "Descrição: "
                        MdRetornoDB.Last_Record_2C()
                        Txt1.Text = intID_Retorno
                        Txt2.Select()
                    Case 2
                        Me.Text = "Cadastro de Tipos de Movimento - Edição de Registro"
                        Carrega_Campos()
                    Case 3
                        Me.Text = "Cadastro de Tipos de Movimento - Visualizar Registro "
                        Txt1.Enabled = False
                        Txt2.Enabled = False
                        Carrega_Campos()
                    Case 4
                        Me.Text = "Cadastro de Tipos de Movimento - Exclusão de Registro "
                        Txt1.Enabled = False
                        Txt2.Enabled = False
                        Carrega_Campos()
                End Select
            Case 4
                '==================
                'Grupos
                '==================
                Select Case intAC
                    Case 1
                        Me.Text = "Cadastro de Grupos - Inclusão de Registro"
                        Label1.Text = "Código: "
                        Label2.Text = "Descrição: "
                        MdRetornoDB.Last_Record_2C()
                        Txt1.Text = intID_Retorno
                        Txt2.Select()
                    Case 2
                        Me.Text = "Cadastro de Grupos - Edição de Registro"
                        Carrega_Campos()
                    Case 3
                        Me.Text = "Cadastro de Grupos - Visualizar Registro "
                        Txt1.Enabled = False
                        Txt2.Enabled = False
                        Carrega_Campos()
                    Case 4
                        Me.Text = "Cadastro de Grupos - Exclusão de Registro "
                        Txt1.Enabled = False
                        Txt2.Enabled = False
                        Carrega_Campos()
                End Select
            Case 6
                '==================
                'Setor
                '==================
                Select Case intAC
                    Case 1
                        Me.Text = "Cadastro de Setor - Inclusão de Registro"
                        Label1.Text = "Código: "
                        Label2.Text = "Descrição: "
                        MdRetornoDB.Last_Record_2C()
                        Txt1.Text = intID_Retorno
                        Txt2.Select()
                    Case 2
                        Me.Text = "Cadastro de Setor - Edição de Registro"
                        Carrega_Campos()
                    Case 3
                        Me.Text = "Cadastro de Setor - Visualizar Registro "
                        Txt1.Enabled = False
                        Txt2.Enabled = False
                        Carrega_Campos()
                    Case 4
                        Me.Text = "Cadastro de Setor - Exclusão de Registro "
                        Txt1.Enabled = False
                        Txt2.Enabled = False
                        Carrega_Campos()
                End Select
            Case 9
                '==================
                'Acabamento
                '==================
                Select Case intAC
                    Case 1
                        Me.Text = "Cadastro de Acabamento - Inclusão de Registro"
                        Label1.Text = "Código: "
                        Label2.Text = "Descrição: "
                        MdRetornoDB.Last_Record_2C()
                        Txt1.Text = intID_Retorno
                        Txt2.Select()
                    Case 2
                        Me.Text = "Cadastro de Acabamento - Edição de Registro"
                        Carrega_Campos()
                    Case 3
                        Me.Text = "Cadastro de Acabamento - Visualizar Registro "
                        Txt1.Enabled = False
                        Txt2.Enabled = False
                        Carrega_Campos()
                    Case 4
                        Me.Text = "Cadastro de Acabamento - Exclusão de Registro "
                        Txt1.Enabled = False
                        Txt2.Enabled = False
                        Carrega_Campos()
                End Select

        End Select
    End Sub

    Private Sub Carrega_Campos()
        Label1.Text = "Código: "
        Label2.Text = "Descrição: "
        MdRetornoDB.Exibir_Dados_2C()
        Txt1.Text = intID_Retorno
        Txt2.Text = strDescricao_Retorno
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        intID_Entrada = Txt1.Text
        strDescricao_Entrada = Txt2.Text
        MdManDB.Registros_2C()
        Listar_Principal()
    End Sub
End Class
