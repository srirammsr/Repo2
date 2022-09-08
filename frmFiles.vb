Public Class FrmSavetoTextFile
    Private Sub btnOpenFolder_Click(sender As Object, e As EventArgs) Handles btnOpenFolder.Click
        If (FolderDiag.ShowDialog() = DialogResult.OK) Then
            txtxFolder.Text = FolderDiag.SelectedPath
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Len(Trim(txtFileName.Text)) = 0 Then
            MsgBox("Please provide AddressOf filename", vbInformation)
            Exit Sub
        End If
        Dim FILE_NAME As String = Trim(txtxFolder.Text) & "\" & Trim(txtFileName.Text) & ".txt"
startwriting:
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
            objWriter.Write(txtContent.Text)
            MsgBox("Content saved", MsgBoxStyle.OkOnly + vbInformation, "File Save")
            txtFileName.Text = ""
            txtContent.Text = ""
            objWriter.Close()
        Else
            System.IO.File.Create(FILE_NAME).Dispose()
            GoTo startwriting
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFileName.Click
        OpenFileDiag.InitialDirectory = FolderDiag.SelectedPath
        If OpenFileDiag.ShowDialog() = DialogResult.OK Then
            txtFileName.Text = OpenFileDiag.SafeFileName
            txtContent.Text = System.IO.Path.GetFileNameWithoutExtension(Trim(txtxFolder.Text) & txtFileName.Text)
        End If
    End Sub

    Private Sub FrmSavetoTextFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

