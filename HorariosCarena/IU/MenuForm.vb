Public Class MenuForm
    Private Sub DocentesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DocentesToolStripMenuItem.Click
        Dim frmdocentegrid As New DocentesGrid
        frmdocentegrid.MdiParent = Me
        frmdocentegrid.Show()
    End Sub

    Private Sub AsignaturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignaturasToolStripMenuItem.Click
        Dim frmasignaturagrid As New AsignaturasGrid
        frmasignaturagrid.MdiParent = Me
        frmasignaturagrid.Show()
    End Sub
End Class