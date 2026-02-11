Public Class FrmCalcDiario
    Dim vl_comprimento As Double
    Dim vl_Largura As Double
    Dim vl_folhas As Integer
    Dim m_quadrado As Double
    Dim m_linear As Double

    Private Sub FrmCalcDiario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmPrincipal

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        vl_comprimento = TxtComp.Text
        vl_Largura = TxtLarg.Text
        vl_folhas = TxtFolha.Text

        m_quadrado = ((vl_comprimento * vl_Largura * vl_folhas) / 10000)
        TxtMQuad.Text = Format(m_quadrado, "###,###.#0")

        m_linear = ((vl_comprimento * vl_folhas) / 100)
        TxtLinear.Text = Format(m_linear, "###,###.#0")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Transfere os valores para o formulario FrmServico

        FrmServicos.TxtLinear.Text = TxtLinear.Text
        FrmServicos.TxtMetrosQuad.Text = TxtMQuad.Text
        FrmServicos.TxtFolhas.Text = TxtFolha.Text

        TxtComp.Text = ""
        TxtLarg.Text = ""
        TxtFolha.Text = ""
        TxtMQuad.Text = ""
        TxtLinear.Text = ""

        FrmServicos.TxtAcertos.Focus()



    End Sub

End Class