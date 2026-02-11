Module MdProg
    Public Sub Forms()
        'Carrega a tela do cadastro correpondente ao selecionado no menu.

        Select Case Item_Menu
            Case 1
                'Tela Cadastro de Máquinas.
                FrmStd1.Show()
            Case 2
                'Tela Cadastro de Operadores.
                FrmStd1.Show()
            Case 3
                'Tela Cadastro de Tipos de Movimento.
                FrmStd1.Show()
            Case 4
                'Tela Cadastro de Grupos.
                FrmStd1.Show()
            Case 5
                'Tela Cadastro de Materia-Prima
                FrmMateriaPrima.Show()
            Case 6
                'Tela Cadastro de Setor
                FrmStd1.Show()
            Case 7
                'Tela Cadastro de Tipos de Facas
                FrmTPFacas.Show()
            Case 8
                'Tela Cadastro de Facas
                FrmFacas.Show()
            Case 9
                'Tela Cadastro de Acabamento.
                FrmStd1.Show()
            Case 10
                'Tela Fichas de Produção.
                FrmFichas.Show()
            Case 11
                'Tela de Serviços.
                FrmServico.Show()
            Case 12
                'Tela de Embalagens
                FrmTecnica.Show()
            Case 13
                'Tela de Embalagens
                FrmUsuarios.Show()
            Case Else


        End Select


    End Sub
End Module
