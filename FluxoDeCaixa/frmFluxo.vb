Public Class FrmFluxo

    Private banco As New ConexaoBancovb


    Private Sub FrmFluxo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CarregarExtrato()
        CarregarLancamentosFuturos()
        MudarCoresLinhasGridExtrato()
        MudarCoresLinhasGridLancamentos()






    End Sub

    Private Sub CarregarExtrato()

        Dim dsGrid As New DataSet

        banco.conectar()
        dsGrid = banco.BuscarExtrato("SELECT * FROM MOVIMENTACAO WHERE data_lancamento <= GETDATE() order by log DESC")
        banco.fechar()

        dgvExtrato.DataSource = dsGrid.Tables(0)

        dgvExtrato.Columns(0).Visible = False

        dgvExtrato.Columns(1).HeaderText = "Dt.Lançamento"
        dgvExtrato.Columns(1).Width = 150
        dgvExtrato.Columns(2).HeaderText = "Descrição"
        dgvExtrato.Columns(2).Width = 169
        dgvExtrato.Columns(3).HeaderText = "Valor"
        dgvExtrato.Columns(3).Width = 110
        dgvExtrato.Columns(4).HeaderText = "Tipo OP"
        dgvExtrato.Columns(4).Width = 110

        dgvExtrato.Columns(5).Visible = False

        dgvExtrato.ReadOnly = True

        CalcularSaldoAtual(dsGrid)

        'Ordenar coluna da gridview pela data maior
        'dgvExtrato.Sort(dgvExtrato.Columns(1), System.ComponentModel.ListSortDirection.Descending)



    End Sub

    Private Sub CarregarLancamentosFuturos()

        Dim dsGrid As New DataSet

        banco.conectar()
        dsGrid = banco.BuscarExtrato("SELECT * FROM MOVIMENTACAO WHERE data_lancamento > GETDATE() order by log DESC")
        banco.fechar()
        dgvLancamentosFuturos.DataSource = dsGrid.Tables(0)

        dgvLancamentosFuturos.DataSource = dsGrid.Tables(0)

        dgvLancamentosFuturos.Columns(0).Visible = False
        dgvLancamentosFuturos.Columns(1).HeaderText = "Dt.Lançamento"
        dgvLancamentosFuturos.Columns(1).Width = 80
        dgvLancamentosFuturos.Columns(2).HeaderText = "Descrição"
        dgvLancamentosFuturos.Columns(2).Width = 80
        dgvLancamentosFuturos.Columns(3).HeaderText = "Valor"
        dgvLancamentosFuturos.Columns(3).Width = 110
        dgvLancamentosFuturos.Columns(4).Visible = False
        dgvLancamentosFuturos.Columns(5).Visible = False

        dgvLancamentosFuturos.ReadOnly = True


        CalcularSaldoPrevisto(dsGrid, CDbl(lblSaldoAtual.Text))

    End Sub

    Private Sub MudarCoresLinhasGridExtrato()

        Dim linha As Integer

        For linha = 0 To dgvExtrato.Rows.Count - 1

            If Me.dgvExtrato.Rows(linha).Cells(4).Value.ToString = "CREDITO" Then
                dgvExtrato.Rows(linha).DefaultCellStyle.BackColor = Color.FromArgb(0, 191, 255)
            End If
            If Me.dgvExtrato.Rows(linha).Cells(4).Value.ToString = "DEBITO" Then
                dgvExtrato.Rows(linha).DefaultCellStyle.BackColor = Color.FromArgb(255, 99, 71)
            End If
        Next



    End Sub

    Private Sub MudarCoresLinhasGridLancamentos()

        Dim linha As Integer

        For linha = 0 To dgvLancamentosFuturos.Rows.Count - 1

            If Me.dgvLancamentosFuturos.Rows(linha).Cells(4).Value.ToString = "CREDITO" Then
                dgvLancamentosFuturos.Rows(linha).DefaultCellStyle.BackColor = Color.FromArgb(0, 191, 255)
            End If
            If Me.dgvLancamentosFuturos.Rows(linha).Cells(4).Value.ToString = "DEBITO" Then
                dgvLancamentosFuturos.Rows(linha).DefaultCellStyle.BackColor = Color.FromArgb(255, 99, 71)
            End If
        Next



    End Sub
    Private Sub CalcularSaldoPrevisto(ByVal ds As DataSet, saldoReal As Double)

        Dim tabela As DataTable
        Dim linha As DataRow
        Dim saldo As Double

        saldo = saldoReal

        For Each tabela In ds.Tables
            For Each linha In tabela.Rows
                If linha(4) = "CREDITO" Then
                    saldo = saldo + CDbl(linha(3))

                End If
                If linha(4) = "DEBITO" Then
                    saldo = saldo - CDbl(linha(3))

                End If
            Next
        Next

        If saldo >= 0 Then
            lblSaldoPrevisto.ForeColor = Color.Blue
        Else
            lblSaldoPrevisto.ForeColor = Color.Red

        End If

        lblSaldoPrevisto.Text = saldo.ToString("0.00")

    End Sub


    Private Sub CalcularSaldoAtual(ByVal ds As DataSet)

        Dim tabela As DataTable
        Dim linha As DataRow
        Dim saldo As Double



        For Each tabela In ds.Tables
            For Each linha In tabela.Rows
                If linha(4) = "CREDITO" Then
                    saldo = saldo + CDbl(linha(3))

                End If
                If linha(4) = "DEBITO" Then
                    saldo = saldo - CDbl(linha(3))

                End If
            Next
        Next

        If saldo >= 0 Then
            lblSaldoAtual.ForeColor = Color.Black
        Else
            lblSaldoAtual.ForeColor = Color.Red

        End If

        If saldo > 0 Then
            lblSaldoAtual.ForeColor = Color.Blue

        Else
            lblSaldoAtual.ForeColor = Color.Red
        End If

        lblSaldoAtual.Text = saldo.ToString("0.00")





    End Sub

    Private Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click

        Dim retorno As Integer
        Dim sql As String
        Dim strValor As String

        If txtDescricao.Text = "" Then
            MsgBox("A descrição deve ser informada")
            Exit Sub
        End If

        If cmbTipoOp.SelectedIndex = -1 Then
            MsgBox("O tipo de operaçã deve ser informado")
            Exit Sub
        End If

        If txtValor.Text = "" Then
            MsgBox("O valor deve ser informado")
            Exit Sub
        End If

        strValor = Replace(txtValor.Text, ",", ".")

        sql = "INSERT INTO MOVIMENTACAO (data_lancamento, descricao, tipo, valor, log) VALUES(" +
                "'" + dtpLancamento.Value.ToShortDateString() + "'," +
                "'" + txtDescricao.Text + "'," +
                "'" + cmbTipoOp.Text + "', " + strValor + "," +
                "'" + DateTime.Now + "'" + ")"



        banco.conectar()
        retorno = banco.IncluirRegistro(sql)
        banco.fechar()

        If retorno = 0 Then
            MessageBox.Show("Não foi possivel incluir o registro", "Informação")
        Else
            MessageBox.Show("Registro adicionado com sucesso", "Informação")
        End If

        CarregarExtrato()
        CarregarLancamentosFuturos()
        MudarCoresLinhasGridExtrato()
        MudarCoresLinhasGridLancamentos()

        txtDescricao.Text = ""
        cmbTipoOp.SelectedValue = -1
        txtValor.Text = ""



    End Sub

    Private Sub txtValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValor.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then e.Handled = True
        If e.KeyChar = "," And (InStr(txtValor.Text, ",")) > 0 Then e.Handled = True

    End Sub

    Private Sub dgvExtrato_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvExtrato.CellDoubleClick

        'Exclusão do registro
        Dim result As Integer
        Dim retorno As Integer


        If e.RowIndex = -1 Then
            Exit Sub
        End If

        result = MessageBox.Show("Tem certeza que deseja excluir o registro selecionado ?", "EXCLUSÃO", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then



            banco.conectar()
            retorno = banco.ExcluirRegistro("DELETE FROM MOVIMENTACAO WHERE id = " + dgvExtrato.Rows(e.RowIndex).Cells(0).Value.ToString)

            banco.fechar()

            If retorno <> 0 Then
                MsgBox("Registro excluido com sucesso")
            End If

            CarregarExtrato()
            CarregarLancamentosFuturos()
            MudarCoresLinhasGridExtrato()
            MudarCoresLinhasGridLancamentos()


        End If






    End Sub

    Private Sub dgvLancamentosFuturos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLancamentosFuturos.CellDoubleClick

        'Exclusão do registro
        Dim result As Integer
        Dim retorno As Integer


        If e.RowIndex = -1 Then
            Exit Sub
        End If

        result = MessageBox.Show("Tem certeza que deseja excluir o registro selecionado ?", "EXCLUSÃO", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then



            banco.conectar()
            retorno = banco.ExcluirRegistro("DELETE FROM MOVIMENTACAO WHERE id = " + dgvLancamentosFuturos.Rows(e.RowIndex).Cells(0).Value.ToString)

            banco.fechar()

            If retorno <> 0 Then
                MsgBox("Registro excluido com sucesso")
            End If

            CarregarExtrato()
            CarregarLancamentosFuturos()
            MudarCoresLinhasGridExtrato()
            MudarCoresLinhasGridLancamentos()


        End If



    End Sub

    Private Sub dtpLancamento_Enter(sender As Object, e As EventArgs) Handles dtpLancamento.Enter
        MudarCoresLinhasGridExtrato()

    End Sub

End Class
