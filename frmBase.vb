Public Class frmBase

    Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        FrmSavetoTextFile.MdiParent = Me
        FrmSavetoTextFile.BringToFront()
    End Sub
End Class