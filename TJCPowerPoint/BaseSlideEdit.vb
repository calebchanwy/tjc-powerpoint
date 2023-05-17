﻿Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Threading
Public Class BaseSlideEdit
    Inherits DraggableForm
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
        updatePreview()
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
            Dim ofd As New OpenFileDialog()
            ofd.InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads")
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"

            If ofd.ShowDialog() = DialogResult.OK Then
                Dim imageFilePath As String = ofd.FileName
                slide.Shapes.AddPicture(imageFilePath, False, True, 0, 0, slide.Master.Width, slide.Master.Height)

                Dim imageDirPath As String = Path.Combine(Directory.GetCurrentDirectory(), "Files", slideName.Replace(" ", "") + "Dir.txt")
                File.WriteAllText(imageDirPath, imageFilePath)

                MessageBox.Show("Image was successfully updated.", "Success")
            Else
                MessageBox.Show("No image file was selected. Please try again.", "Error")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while updating the image. Please try again.", "Error")
        End Try
    End Sub


    Private Sub delImage_Click(sender As Object, e As EventArgs) Handles delImage.Click
        Try
            If slide.Shapes.Count >= 6 Then
                slide.Shapes(6).Delete()

                Dim imageDirPath As String = Path.Combine(Directory.GetCurrentDirectory(), "Files", slideName.Replace(" ", "") + "Dir.txt")
                File.WriteAllText(imageDirPath, "")

                MessageBox.Show("Image was successfully deleted.", "Success")
            Else
                MessageBox.Show("No image is currently inserted.", "Error")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while deleting the image. Please try again.", "Error")
        End Try
    End Sub


    Private Sub TitleColorBtn_Click(sender As Object, e As EventArgs) Handles TitleColorBtn.Click
        MainProgram.ChangeColor(titleTB)
        updatePreview()
    End Sub

    Private Sub TitleFontBtn_Click(sender As Object, e As EventArgs) Handles TitleFontBtn.Click
        MainProgram.ChangeFont(titleTB)
        updatePreview()
    End Sub

    Private Sub BodyColorBtn_Click(sender As Object, e As EventArgs) Handles BodyColorBtn.Click
        MainProgram.ChangeColor(bodyTB)
        updatePreview()
    End Sub

    Private Sub BodyFontBtn_Click(sender As Object, e As EventArgs) Handles BodyFontBtn.Click
        MainProgram.ChangeFont(bodyTB)
        updatePreview()
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        bodyTB.Text = txtInput.Text
        Try
            updatePreview()
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
        MainProgram.GoToSlide(slide.SlideNumber)
    End Sub

    Private Sub updatePreview()
        ' Export the slide as an image
        Dim imagePath As String = Path.Combine(Path.GetTempPath(), "slide_preview.png")
        slide.Export(imagePath, "PNG", previewBox.Width, previewBox.Height)

        Dim copiedImagePath As String = Path.GetTempFileName() ' Generate a unique temporary file name
        copiedImagePath = Path.ChangeExtension(copiedImagePath, ".png") ' Change the file extension to .png if needed

        ' Make a copy of the image file
        File.Copy(imagePath, copiedImagePath, True)

        ' Display the slide preview from the copied image file
        Using image As Image = Image.FromFile(copiedImagePath)
            previewBox.Image = New Bitmap(image)
        End Using

        ' Clean up temporary files
        DeleteFileWithRetry(imagePath, 3, 500) ' Retry 3 times with a delay of 500 milliseconds between each attempt
        DeleteFileWithRetry(copiedImagePath, 3, 500)
    End Sub

    Private Sub DeleteFileWithRetry(filePath As String, maxRetries As Integer, delayMilliseconds As Integer)
        Dim retries As Integer = 0
        While retries < maxRetries
            Try
                File.Delete(filePath)
                Exit Sub ' File deleted successfully, exit the loop
            Catch ex As IOException
                retries += 1
                Thread.Sleep(delayMilliseconds) ' Introduce a delay before the next retry
            End Try
        End While

        ' File deletion failed even after retries
        ' Handle the failure case here
    End Sub

    Private Sub previewBox_Click(sender As Object, e As EventArgs) Handles previewBox.Click
        updatePreview()
    End Sub
End Class