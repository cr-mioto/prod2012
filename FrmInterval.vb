Public Class FrmInterval

    Private Sub FrmInterval_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dtDe = DTInicial.Value
        dtAte = DTFinal.Value
        mdFiltro_Principal.Filtrar()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class