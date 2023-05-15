Imports Microsoft.Office.Interop
Imports System.Runtime.InteropServices
Imports System.IO
Public Class BaseSlideEdit
    Private slideName As String
    Private slideNumber As Integer
    Private aeroEnabled As Boolean
    'Text boxes
    Private slide As PowerPoint.Slide
    Private titleTB As PowerPoint.TextRange
    Private bodyTB As PowerPoint.TextRange

    Public Sub New(nm As String, s As PowerPoint.Slide)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        slideName = nm
        slide = s
        header.Text = slideName
        aeroEnabled = False
    End Sub
    'Method that updates form's own internal text box
    Public Sub setInput(txt As String)
        txtInput.Text = txt
    End Sub

    Public Sub setTitleTB(tb As PowerPoint.TextRange)
        titleTB = tb
    End Sub

    Public Sub setBodyTB(tb As PowerPoint.TextRange)
        bodyTB = tb
    End Sub

    Public Function getName()
        Return slideName
    End Function

    Public Function getSlide()
        Return slide
    End Function

    Public Sub loadImage(dir As String)
        If My.Computer.FileSystem.FileExists(dir) = True Then
            slide.Shapes.AddPicture(dir, False, True, 0, 0, slide.Master.Width, slide.Master.Height)
        End If
    End Sub

    Private Sub insertImage_Click(sender As Object, e As EventArgs) Handles insertImage.Click
        Try
            Dim ofd = New OpenFileDialog()
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Downloads"
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"
            If ofd.ShowDialog = DialogResult.OK Then
                slide.Shapes.AddPicture(ofd.FileName, False, True, 0, 0, slide.Master.Width, slide.Master.Height)
                System.IO.File.WriteAllText(Directory.GetCurrentDirectory() + "\Files\" + slideName.Replace(" ", "") + "Dir.txt", ofd.FileName)
                MessageBox.Show("Image Was Successfully Updated", "Success")
            Else
                MessageBox.Show("Image Was Not Successfully Updated. Please Try Again", "Error")
            End If
        Catch ex As Exception
            MessageBox.Show("Image Was Not Successfully Updated. Please Try Again", "Error")
        End Try
    End Sub

    Private Sub delImage_Click(sender As Object, e As EventArgs) Handles delImage.Click
        If slide.Shapes.Count >= 6 Then
            slide.Shapes(6).Delete()
            System.IO.File.WriteAllText(Directory.GetCurrentDirectory() + "\Files\" + slideName.Replace(" ", "") + "Dir.txt", "")
        End If
    End Sub

    Private Sub TitleColorBtn_Click(sender As Object, e As EventArgs) Handles TitleColorBtn.Click
        MainProgram.ChangeColor(titleTB)
    End Sub

    Private Sub TitleFontBtn_Click(sender As Object, e As EventArgs) Handles TitleFontBtn.Click
        MainProgram.ChangeFont(titleTB)
    End Sub

    Private Sub BodyColorBtn_Click(sender As Object, e As EventArgs) Handles BodyColorBtn.Click
        MainProgram.ChangeColor(bodyTB)
    End Sub

    Private Sub BodyFontBtn_Click(sender As Object, e As EventArgs) Handles BodyFontBtn.Click
        MainProgram.ChangeFont(bodyTB)
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        bodyTB.Text = txtInput.Text
        Try
            My.Computer.FileSystem.WriteAllText(MainProgram.getCurrentDirectory() + "\Files\" + slideName.Replace(" ", "") + ".txt", txtInput.Text, False)
            MessageBox.Show("Save Successful", "Save Successful")
        Catch ex As Exception
            MessageBox.Show("Save Unsuccessful", "Save Unsuccessful")
        End Try
    End Sub

    Private Sub loadTxtBtn_Click(sender As Object, e As EventArgs) Handles loadTxtBtn.Click
        OpenFileDialog.InitialDirectory = MainProgram.getCurrentDirectory() + "\Files\"
        If OpenFileDialog.ShowDialog = DialogResult.OK Then
            txtInput.Text = IO.File.ReadAllText(OpenFileDialog.FileName)
            Call updateBtn_Click(sender, e)
        End If
    End Sub

    Private Sub closeForm_Click(sender As Object, e As EventArgs) Handles closeForm.Click
        Me.Hide()
    End Sub
    Private Sub minForm_Click(sender As Object, e As EventArgs) Handles minForm.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub goToSlideBtn_Click(sender As Object, e As EventArgs) Handles goToSlideBtn.Click
        MainProgram.goToSlide(slide.SlideNumber)
    End Sub




    'DEALING WITH FORM MOVEMENT
    'https://stackoverflow.com/questions/17392088/allow-a-user-to-move-a-borderless-window
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles navBar.MouseDown, header.MouseDown

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles navBar.MouseUp, header.MouseUp

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles navBar.MouseMove, header.MouseMove

        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

End Class