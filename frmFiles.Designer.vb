<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSavetoTextFile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtxFolder = New System.Windows.Forms.TextBox()
        Me.FolderDiag = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.btnOpenFolder = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnFileName = New System.Windows.Forms.Button()
        Me.OpenFileDiag = New System.Windows.Forms.OpenFileDialog()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "File Name"
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(191, 48)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(170, 23)
        Me.txtFileName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Default Folder"
        '
        'txtxFolder
        '
        Me.txtxFolder.Location = New System.Drawing.Point(191, 14)
        Me.txtxFolder.Name = "txtxFolder"
        Me.txtxFolder.Size = New System.Drawing.Size(369, 23)
        Me.txtxFolder.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(101, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Content"
        '
        'txtContent
        '
        Me.txtContent.AcceptsTab = True
        Me.txtContent.Location = New System.Drawing.Point(191, 89)
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Size = New System.Drawing.Size(416, 236)
        Me.txtContent.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(191, 337)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(76, 29)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(531, 337)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(76, 29)
        Me.BtnClose.TabIndex = 4
        Me.BtnClose.Text = "&Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'btnOpenFolder
        '
        Me.btnOpenFolder.Location = New System.Drawing.Point(577, 14)
        Me.btnOpenFolder.Name = "btnOpenFolder"
        Me.btnOpenFolder.Size = New System.Drawing.Size(30, 20)
        Me.btnOpenFolder.TabIndex = 0
        Me.btnOpenFolder.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Location = New System.Drawing.Point(3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(92, 427)
        Me.Panel1.TabIndex = 6
        '
        'btnFileName
        '
        Me.btnFileName.Location = New System.Drawing.Point(577, 51)
        Me.btnFileName.Name = "btnFileName"
        Me.btnFileName.Size = New System.Drawing.Size(30, 20)
        Me.btnFileName.TabIndex = 7
        Me.btnFileName.Text = "....."
        Me.btnFileName.UseVisualStyleBackColor = True
        '
        'OpenFileDiag
        '
        Me.OpenFileDiag.DefaultExt = "txt"
        Me.OpenFileDiag.FileName = "OpenFileDiag"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(376, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "text files only"
        '
        'FrmSavetoTextFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 427)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnFileName)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnOpenFolder)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtContent)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtxFolder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmSavetoTextFile"
        Me.Text = "Save to text file"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFileName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtxFolder As TextBox
    Friend WithEvents FolderDiag As FolderBrowserDialog
    Friend WithEvents Label3 As Label
    Friend WithEvents txtContent As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents btnOpenFolder As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnFileName As Button
    Friend WithEvents OpenFileDiag As OpenFileDialog
    Friend WithEvents Label4 As Label
End Class
