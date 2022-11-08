Imports Ionic.Zip

Public Class MainForm

    Dim sourceFolderPath


    Private Sub Select_Target_Dir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Select_Target_Dir.Click
        FolderBrowserDialog1.ShowDialog()
        sourceFolderPath = FolderBrowserDialog1.SelectedPath
        TextBox_Path.Text = sourceFolderPath
        ProgressBar1.Value = 0
        Dim folder As String = String.Empty
        If sourceFolderPath = "" Then
            Label1.Text = "You did not select source folder path."
        Else
            Dim folders() As String = IO.Directory.GetDirectories(sourceFolderPath)
            If sourceFolderPath <> "" Then
                CheckedListBox1.Items.Clear()
                If folders.Length <> 0 Then
                    Dim childNode As TreeNode = Nothing

                    For Each folder In folders
                        CheckedListBox1.Items.Add(folder)
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub Open_Target_Dir(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Open_Target_Dir.Click
        Process.Start("explorer.exe", sourceFolderPath)
    End Sub

    Private Sub Button_SelectAllOrNothing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_SelectAllOrNothing.Click
        If CheckedListBox1.CheckedItems.Count = 0 Then
            For i As Integer = 0 To CheckedListBox1.Items.Count - 1
                CheckedListBox1.SetItemChecked(i, True)
            Next i
        Else
            For i As Integer = 0 To CheckedListBox1.Items.Count - 1
                CheckedListBox1.SetItemChecked(i, False)
            Next i
        End If
    End Sub

    Private Sub Button_ZipStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_ZipStart.Click

        Dim itemChecked As String
        Dim numCheck As Integer = CheckedListBox1.CheckedItems.Count
        Dim currentProgress As Integer = 0


        If numCheck = 0 Then
            Label1.Text = "There is nothing to zip"
        Else

            For Each itemChecked In CheckedListBox1.CheckedItems

                Using zip As ZipFile = New ZipFile()
                    zip.AddDirectory(itemChecked)
                    zip.Save(itemChecked + ".zip")
                    currentProgress += 1
                    ProgressBar1.Value = 100 * currentProgress / numCheck
                End Using
                Label1.Text = "It has zipped " & currentProgress & "/" & numCheck & " folders so far."
                Me.Refresh()
            Next
            CheckedListBox1.Items.Clear()
            Label1.Text = "They have been successfully zipped."

        End If
    End Sub

    Private Sub LinkLabel_FeedBack_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel_FeedBack.LinkClicked
        System.Diagnostics.Process.Start("mailto:" + "jin828sin@hotmail.com")
    End Sub
End Class
