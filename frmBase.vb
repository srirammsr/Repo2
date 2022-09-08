Public Class frmBase

    Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        With FrmSavetoTextFile
            .MdiParent = Me
            .Show()
            .BringToFront()
        End With
    End Sub
End Class