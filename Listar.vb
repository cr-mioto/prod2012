Module Listar
    Dim cmdListaFones As SqlClient.SqlCommand
    Dim cmdListaSocios As SqlClient.SqlCommand
    Dim cmdListaEnd As SqlClient.SqlCommand
    Dim cmdListaEndCob As SqlClient.SqlCommand
    Dim cmdListaComl As SqlClient.SqlCommand
    Dim cmdSearch As SqlClient.SqlCommand
    Dim StrQuery As String

    Public Sub Listar_Telefones()
        'Lista dados solicitados
        Try

            Conn.Open()
            Select Case VF_FrmFone
                Case 1
                    cmdListaFones = New SqlClient.SqlCommand("Select id_fone,ddd,telefone,ramal,tipo From Vendas.Cliente_fone Where Clienteid=" & ClienteID & "", Conn)
                Case 2
                    cmdListaFones = New SqlClient.SqlCommand("Select id_fone,ddd,telefone,ramal,tipo From VENDAS.VENDEDOR_FONE Where Vendid=" & VendID & "", Conn)
            End Select

            cmdListaFones.CommandType = CommandType.Text

            Dim rdclienteFone As SqlClient.SqlDataReader = cmdListaFones.ExecuteReader

            'Carrega o listview
            While rdclienteFone.Read
                Dim codigo As String = rdclienteFone.Item(0)
                Dim Ls As New ListViewItem(codigo, 0)
                Ls.SubItems.Add(rdclienteFone.Item(1))
                Ls.SubItems.Add(rdclienteFone.Item(2))
                Ls.SubItems.Add(rdclienteFone.Item(3))
                Ls.SubItems.Add(rdclienteFone.Item(4))
                Select Case VF_FrmFone
                    Case 1
                        FrmCliente.ListView1.Items.Add(Ls)
                    Case 2
                        FrmVendedores.ListView1.Items.Add(Ls)
                End Select

            End While

            rdclienteFone.Close()
            Conn.Close()

        Catch ex As Exception
            Conn.Close()
            Exit Sub
        End Try

    End Sub
    Public Sub Lista_Socios()
        'Lista dados solicitados
        Try

            Conn.Open()

            cmdListaSocios = New SqlClient.SqlCommand("Select id_Socio,Nome From Vendas.Cliente_Socios Where Clienteid=" & ClienteID & "", Conn)

            cmdListaSocios.CommandType = CommandType.Text

            Dim rdclienteSocio As SqlClient.SqlDataReader = cmdListaSocios.ExecuteReader

            'Carrega o listview

            While rdclienteSocio.Read
                Dim codigo As String = rdclienteSocio.Item(0)
                Dim Ls As New ListViewItem(codigo, 0)
                Ls.SubItems.Add(rdclienteSocio.Item(1))
                FrmCliente.ListViewSocio.Items.Add(Ls)
            End While

            rdclienteSocio.Close()
            Conn.Close()

        Catch ex As Exception
            Conn.Close()
            Exit Sub
        End Try


    End Sub

    Public Sub Resultado_Pesquisa()
        'Lista dados solicitados
        Conn.Open()

        Select Case VF_Pesq
            '    Case "Clientes"
            '        cmdSearch = New SqlClient.SqlCommand("SELECT CLIENTEID, RAZAO FROM Vendas.Cliente WHERE Fantasia LIKE '" & FrmPrincipal.TextBox1.Text & "%'", Conn)
            '    Case "Transportes"
            '        cmdSearch = New SqlClient.SqlCommand("SELECT TRANSPID, RAZAO FROM Vendas.Transporte WHERE Fantasia LIKE '" & FrmPrincipal.TextBox1.Text & "%'", Conn)
        End Select

        cmdSearch.CommandType = CommandType.Text

        Dim rdSearch As SqlClient.SqlDataReader = cmdSearch.ExecuteReader

        'Carrega o listview

        While rdSearch.Read
            Dim codigo As String = rdSearch.Item(0)
            Dim Ls As New ListViewItem(codigo, 0)
            Ls.SubItems.Add(rdSearch.Item(1))
            FrmPrincipal.ListView1.Items.Add(Ls)
        End While

        rdSearch.Close()
        Conn.Close()

    End Sub
End Module
