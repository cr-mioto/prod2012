Public Class FrmReports
    Private Sub FrmReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Titulo_Janela

        Select Case VF_Report
            Case 1
                Report_Param = "/Reports/ProdMaquinas"
            Case 2
                Report_Param = "/Reports/RptProducao_Sintec"
            Case 3
                Report_Param = "/Reports/OS"
            Case 4
                Report_Param = "/Reports/Embalagens"
            Case 5
                Report_Param = "/Reports/Catalogo"
            Case 6
                Report_Param = "/Reports/Ficha_Cliente"
            Case 7
                Report_Param = "/Reports/Arquivo_Chapas"
        End Select


        Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote

        Me.ReportViewer1.ServerReport.ReportServerUrl = New Uri("http://desktop-h20c2ki/ReportServer")

        Me.ReportViewer1.ServerReport.ReportPath = Report_Param

        Me.ReportViewer1.RefreshReport()

    End Sub
End Class