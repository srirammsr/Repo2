Public Class FrmSavetoTextFile
    Private Sub btnOpenFolder_Click(sender As Object, e As EventArgs) Handles btnOpenFolder.Click
        If (FolderDiag.ShowDialog() = DialogResult.OK) Then
            txtxFolder.Text = FolderDiag.SelectedPath
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim FILE_NAME As String = txtxFolder.Text & "\ " & Trim(txtFileName.Text) & ".txt"
startwriting:
        If System.IO.File.Exists(FILE_NAME) = True Then
            My.Computer.FileSystem.WriteAllText(FILE_NAME, txtContent.Text & vbCrLf, True)
            MsgBox("Content saved", MsgBoxStyle.OkOnly + vbInformation, "File Save")
        Else
            System.IO.File.Create(FILE_NAME).Dispose()
            GoTo startwriting
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class

