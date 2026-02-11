Module mdFiltro_Principal

   
    'Variáveis
    Public intFiltro As Integer
    Public strFiltrar As String
    Public intTP_Filtro As Integer


    Public Sub Carrega_Combo()

        ' ****************************************************************
        ' *** Rotina para carregar o combo do filtro da tela principal ***
        ' ****************************************************************
        Select Case Item_Menu
            Case 1
            Case 2
            Case 3
            Case 8
                FrmPrincipal.cboFiltrar.Items.Clear()
                FrmPrincipal.cboFiltrar.Items.Add("ID")
                FrmPrincipal.cboFiltrar.Items.Add("Medida")
                FrmPrincipal.cboFiltrar.Items.Add("Área")
                FrmPrincipal.cboFiltrar.Items.Add("Micro")
                FrmPrincipal.cboFiltrar.Items.Add("Cartão")
                FrmPrincipal.cboFiltrar.Items.Add("Tipo")
                FrmPrincipal.cboFiltrar.Items.Add("OBS.Facas")


            Case 10
                FrmPrincipal.cboFiltrar.Items.Clear()
                FrmPrincipal.cboFiltrar.Items.Add("ID")
                FrmPrincipal.cboFiltrar.Items.Add("Cod.Embalagem")
                FrmPrincipal.cboFiltrar.Items.Add("Cod.Cliente")
                FrmPrincipal.cboFiltrar.Items.Add("Cod.Vendedor")
                FrmPrincipal.cboFiltrar.Items.Add("Período")

            Case 11
                FrmPrincipal.cboFiltrar.Items.Clear()
                FrmPrincipal.cboFiltrar.Items.Add("ID")
                FrmPrincipal.cboFiltrar.Items.Add("SetorID")
                FrmPrincipal.cboFiltrar.Items.Add("MáquinaID")
                FrmPrincipal.cboFiltrar.Items.Add("OperID")

            Case 12

                FrmPrincipal.cboFiltrar.Items.Clear()
                FrmPrincipal.cboFiltrar.Items.Add("ID")
                FrmPrincipal.cboFiltrar.Items.Add("Nome da Embalagem")
                FrmPrincipal.cboFiltrar.Items.Add("Cod.Cliente")
                FrmPrincipal.cboFiltrar.Items.Add("Cod.Vendedor")
                FrmPrincipal.cboFiltrar.Items.Add("Medida da Embalagem")


            Case Else

        End Select

    End Sub
    Public Sub Filtrar()
        ' ***************************************************
        ' *** Rotina de filtro de dados da tela principal ***
        ' ***************************************************

    
        Select Case Item_Menu
            Case 8
                Select Case FrmPrincipal.cboFiltrar.Text
                    Case "ID"
                        intTP_Filtro = 0
                        Listar_Principal()
                    Case "Medida"
                        intTP_Filtro = 1
                        Listar_Principal()
                    Case "Área"
                        intTP_Filtro = 2
                        Listar_Principal()
                    Case "Micro"
                        intTP_Filtro = 3
                        Listar_Principal()
                    Case "Cartão"
                        intTP_Filtro = 4
                        Listar_Principal()
                    Case "Tipo"
                        intTP_Filtro = 5
                        Listar_Principal()
                    Case "OBS.Facas"
                        intTP_Filtro = 6
                        Listar_Principal()
                End Select

            Case 11
                Select Case FrmPrincipal.cboFiltrar.Text
                    Case "ID"
                        intTP_Filtro = 110
                        Listar_Principal()
                    Case "SetorID"
                        intTP_Filtro = 111
                        Listar_Principal()
                    Case "MáquinaID"
                        intTP_Filtro = 112
                        Listar_Principal()
                    Case "OperID"
                        intTP_Filtro = 113
                        Listar_Principal()
                End Select

            Case 10
                Select Case FrmPrincipal.cboFiltrar.Text
                    Case "ID"
                        intTP_Filtro = 118
                        Listar_Principal()
                    Case "Cod.Embalagem"
                        intTP_Filtro = 119
                        Listar_Principal()
                    Case "Cod.Cliente"
                        intTP_Filtro = 120
                        Listar_Principal()
                    Case "Cod.Vendedor"
                        intTP_Filtro = 121
                        Listar_Principal()
                    Case "Período"
                        intTP_Filtro = 123
                        Listar_Principal()
                End Select

            Case 12
                Select Case FrmPrincipal.cboFiltrar.Text
                    Case "ID"
                        intTP_Filtro = 114
                        Listar_Principal()
                    Case "Nome da Embalagem"
                        intTP_Filtro = 115
                        Listar_Principal()
                    Case "Cod.Cliente"
                        intTP_Filtro = 116
                        Listar_Principal()
                    Case "Cod.Vendedor"
                        intTP_Filtro = 117
                        Listar_Principal()
                    Case "Medida da Embalagem"
                        intTP_Filtro = 122
                        Listar_Principal()
                End Select

        End Select
    End Sub
End Module
