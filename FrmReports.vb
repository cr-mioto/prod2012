Public Class FrmReports
    Private Sub FrmReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Titulo_Janela

        Select Case VF_Report
            Case 1
                Report_Param = "/Report_Prod2012/ProdMaquinas"
            Case 2
                Report_Param = "/Report_Prod2012/RptProducao_Sintec"
            Case 3
                Report_Param = "/Ficha/OS"
            Case 4
                Report_Param = "/Ficha/Embalagens"
            Case 5
                Report_Param = "/Ficha/Catalogo"
            Case 6
                Report_Param = "/Ficha/Ficha_Cliente"
            Case 7
                Report_Param = "/Ficha/Arquivo_Chapas"
        End Select

        Me.ReportViewer1.ServerReport.ReportPath = Report_Param

        Me.ReportViewer1.RefreshReport()

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class