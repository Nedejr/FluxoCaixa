Public Class frmPrincipal
    Private Sub FluxoDeCaixaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FluxoDeCaixaToolStripMenuItem.Click

        FrmFluxo.MdiParent = Me
        FrmFluxo.Show()



    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click

        Me.Close()


    End Sub

    Private Sub FiltroPorDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FiltroPorDataToolStripMenuItem.Click
        frmFiltroData.MdiParent = Me
        frmFiltroData.Show()
    End Sub
End Class