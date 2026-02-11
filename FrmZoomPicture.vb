Imports System.IO
Imports System.Data.SqlTypes

Public Class FrmZoomPicture

    Private Sub FrmZoomPicture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Carregar a imagem em tamanho máximo.

        Dim cmdFoto As New SqlClient.SqlCommand("Producao.usp_Busca_Embalagem_Fotos", Conn)
        cmdFoto.CommandType = CommandType.StoredProcedure

        'Passando os parametros.

        With cmdFoto
            .Parameters.Add("@ID", SqlDbType.Int).Value = intID_Entrada
        End With

        Conn.Open()
        Dim dr As SqlClient.SqlDataReader = cmdFoto.ExecuteReader(CommandBehavior.CloseConnection)

        If dr.Read Then
            Dim bytBLOBData(dr.GetBytes(0, 0, Nothing, 0, Integer.MaxValue) - 1) As Byte
            dr.GetBytes(0, 0, bytBLOBData, 0, bytBLOBData.Length)
            Dim stmBLOBData As New MemoryStream(bytBLOBData)
            PicFoto.Image = Image.FromStream(stmBLOBData)
        End If

        dr.Close()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class