Public Class HolyCommunion
    Private Sub HCClose_Click(sender As Object, e As EventArgs) Handles HCClose.Click
        Me.Hide()
    End Sub

    Private Sub updateHC_Click(sender As Object, e As EventArgs) Handles updateHC.Click
        MainProgram.ppPres.Slides(5).Shapes(1).TextFrame.TextRange.Text = breadTxt.Text
        MainProgram.ppPres.Slides(5).Shapes(2).TextFrame.TextRange.Text = cupTxt.Text
        Try
            My.Computer.FileSystem.WriteAllText(MainProgram.Current + "\Files\bread.txt", breadTxt.Text, False)
            My.Computer.FileSystem.WriteAllText(MainProgram.Current + "\Files\cup.txt", cupTxt.Text, False)
            MessageBox.Show("Update Successful", "Update Successful")

        Catch ex As Exception
            MessageBox.Show("Update Unsuccessful. Please try again", "Update Unsuccessful")
        End Try

    End Sub

    Private Sub onCreate(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bread As String
        Dim cup As String
        If My.Computer.FileSystem.FileExists(MainProgram.Current + "\Files\bread.txt") = True Then
            bread = My.Computer.FileSystem.ReadAllText(MainProgram.Current + "\Files\bread.txt")
            breadTxt.Text = bread
        End If
        If My.Computer.FileSystem.FileExists(MainProgram.Current + "\Files\cup.txt") = True Then
            cup = My.Computer.FileSystem.ReadAllText(MainProgram.Current + "\Files\cup.txt")
            cupTxt.Text = cup
        End If
    End Sub
End Class