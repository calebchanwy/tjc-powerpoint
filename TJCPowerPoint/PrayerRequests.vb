Public Class PrayerRequests
    Private Sub ClosePrayerRequests_Click(sender As Object, e As EventArgs) Handles ClosePrayerRequests.Click
        Me.Hide()
    End Sub

    Private Sub UpdatePrayerRequests_Click(sender As Object, e As EventArgs) Handles UpdatePrayerRequests.Click
        MainProgram.ppPres.Slides(2).Shapes(1).TextFrame.TextRange.Text = PrayerRequestTxt.Text
        MainProgram.ppPres.Slides(2).Shapes(2).TextFrame.TextRange.Text = TitleBox.Text
    End Sub
    Private Sub PRFontBtn_Click(sender As Object, e As EventArgs) Handles PRFontBtn.Click
        MainProgram.ChangeFont(2, 1)
    End Sub
    Private Sub PRColorBtn_Click(sender As Object, e As EventArgs) Handles PRColorBtn.Click
        MainProgram.ChangeColor(2, 1)
    End Sub
    Private Sub PRTitleFontBtn_Click(sender As Object, e As EventArgs) Handles PRTitleFontBtn.Click
        MainProgram.ChangeFont(2, 2)
    End Sub
    Private Sub PRTitleColorBtn_Click(sender As Object, e As EventArgs) Handles PRTitleColorBtn.Click
        MainProgram.ChangeColor(2, 2)
    End Sub
    Private Sub SavePrayerRequests_Click(sender As Object, e As EventArgs) Handles SavePrayerRequests.Click
        SaveFileDialog.InitialDirectory = MainProgram.Current + "\Files\"
        If SaveFileDialog.ShowDialog = DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog.FileName, PrayerRequestTxt.Text, False)
        End If
    End Sub

    Private Sub LoadPrayerRequests_Click(sender As Object, e As EventArgs) Handles LoadPrayerRequests.Click
        OpenFileDialog.InitialDirectory = MainProgram.Current + "\Files\"
        If OpenFileDialog.ShowDialog = DialogResult.OK Then
            PrayerRequestTxt.Text = IO.File.ReadAllText(OpenFileDialog.FileName)
        End If
    End Sub

    Private Sub editPrayerImage_Click(sender As Object, e As EventArgs) Handles editPrayerImage.Click
        Dim ofd = New OpenFileDialog()
        ofd.InitialDirectory = MainProgram.Current + "\Files\"
        ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*"
        If ofd.ShowDialog = DialogResult.OK Then
            MainProgram.ppPres.Slides(3).Shapes(1).Delete()
            MainProgram.ppPres.Slides(3).Shapes.AddPicture(ofd.FileName, True, True, 0, 0, MainProgram.ppPres.PageSetup.SlideWidth, MainProgram.ppPres.PageSetup.SlideHeight)
        End If


    End Sub
End Class