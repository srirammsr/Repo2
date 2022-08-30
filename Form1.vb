Public Class Form1
    Private Sub btnOpenFolder_Click(sender As Object, e As EventArgs) Handles btnOpenFolder.Click
        If (FolderDiag.ShowDialog() = DialogResult.OK) Then
            txtxFolder.Text = FolderDiag.SelectedPath
        End If
    End Sub
End Class
