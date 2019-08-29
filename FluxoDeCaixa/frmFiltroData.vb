Public Class frmFiltroData

    Private banco As New ConexaoBancovb


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim ds As New DataSet
        Dim strSql As String
        Dim tabela As DataTable
        Dim linhas As DataRow
        Dim totalCredito As Double
        Dim totalDebito As Double




        strSql = "select * from movimentacao where data_lancamento  >= " + "'" + dtpInicial.Value.ToShortDateString() + "'" + " and data_lancamento <= " + "'" + dtpFinal.Value.ToShortDateString() + "' order by log desc"

        banco.conectar()

        ds = banco.BuscarPorData(strSql)

        banco.fechar()
        dgvPorData.DataSource = ds.Tables(0)

        dgvPorData.Columns(0).Visible = False
        dgvPorData.Columns(1).HeaderText = "Dt.Lancamento"
        dgvPorData.Columns(2).HeaderText = "Descrição"
        dgvPorData.Columns(2).Width = 147
        dgvPorData.Columns(3).HeaderText = "Valor"
        dgvPorData.Columns(4).HeaderText = "Tipo"
        dgvPorData.Columns(5).Visible = False
        dgvPorData.Columns(6).Visible = False



        For Each tabela In ds.Tables

            For Each linha In tabela.Rows

                If linha(4) = "CREDITO" Then

                    totalCredito = totalCredito + CDbl(linha(3))

                ElseIf linha(4) = "DEBITO" Then

                    totalDebito = totalDebito + CDbl(linha(3))
                End If

            Next

        Next

        If Chart1.Series.Count > 0 Then

            Chart1.Series.RemoveAt(0)
            Chart1.Series.RemoveAt(0)
            Chart1.ResetAutoValues()

        End If

        Chart1.Series.Add("CREDITOS")
        Chart1.Series.Add("DEBITOS")

        Chart1.Series("CREDITOS").Points.AddXY("", totalCredito)
        Chart1.Series("DEBITOS").Points.AddXY("", totalDebito)







    End Sub

    Private Sub frmFiltroData_Load(sender As Object, e As EventArgs) Handles MyBase.Load





    End Sub
End Class