Public Class Announcements
    Private Sub CloseAnnouncements_Click(sender As Object, e As EventArgs) Handles CloseAnnouncements.Click
        Me.Hide()
    End Sub

    Private Sub UpdateAnnouncements_Click(sender As Object, e As EventArgs) Handles UpdateAnnouncements.Click
        MainProgram.ppPres.Slides(4).Shapes(1).TextFrame.TextRange.Text = AnnouncementTxt.Text
        MainProgram.ppPres.Slides(4).Shapes(2).TextFrame.TextRange.Text = TitleBox.Text
        Try
            My.Computer.FileSystem.WriteAllText(MainProgram.Current + "\Files\Announcements.txt", AnnouncementTxt.Text, False)
            MessageBox.Show("Save Successful", "Save Successful")
        Catch ex As Exception
            MessageBox.Show("Save Unsuccessful", "Save Unsuccessful")
        End Try

    End Sub
    Private Sub PRFontBtn_Click(sender As Object, e As EventArgs) Handles PRFontBtn.Click
        MainProgram.ChangeFont(4, 1)
    End Sub
    Private Sub PRColorBtn_Click(sender As Object, e As EventArgs) Handles PRColorBtn.Click
        MainProgram.ChangeColor(4, 1)
    End Sub
    Private Sub PRTitleFontBtn_Click(sender As Object, e As EventArgs) Handles PRTitleFontBtn.Click
        MainProgram.ChangeFont(4, 2)
    End Sub
    Private Sub PRTitleColorBtn_Click(sender As Object, e As EventArgs) Handles PRTitleColorBtn.Click
        MainProgram.ChangeColor(4, 2)
    End Sub

    Private Sub LoadAnnouncements_Click(sender As Object, e As EventArgs) Handles LoadAnnouncements.Click
        OpenFileDialog.InitialDirectory = MainProgram.Current + "\Files\"
        If OpenFileDialog.ShowDialog = DialogResult.OK Then
            AnnouncementTxt.Text = IO.File.ReadAllText(OpenFileDialog.FileName)
        End If
    End Sub

    Private Sub Announcements_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AnnouncementTxt_TextChanged(sender As Object, e As EventArgs) Handles AnnouncementTxt.TextChanged

    End Sub

    Private Sub TitleBox_TextChanged(sender As Object, e As EventArgs) Handles TitleBox.TextChanged

    End Sub
End Class