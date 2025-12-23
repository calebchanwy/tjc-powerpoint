Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Threading
Imports System.Windows.Forms
Public Class BaseSlideEdit
    Inherits Form

    Private slideName As String
    Private slideKey As String
    Private slide As PowerPoint.Slide
    Private titleTB As PowerPoint.TextRange
    Private bodyTB As PowerPoint.TextRange

    'Image Viewer
    Private imageViewer As ImageViewer
    Private webBrowser As WebBrowser

    Public Sub New(name As String, key As String, s As PowerPoint.Slide)
        ' Initialize all variables
        imageViewer = New ImageViewer(s)
        webBrowser = New WebBrowser(name)
        slideName = name
        slideKey = key
        slide = s

        ' Initialize component as required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        LoadData()
        header.Text = slideName
        Text = slideName
        imageViewer.addPreviewBox(previewBox)
        imageViewer.updatePreviews()
    End Sub
    Private Sub LoadData()
        Dim link As String = My.Settings(slideKey & "WebLink")
        SetWebLink(link)
        Dim img As String = My.Settings(slideKey & "Image")
        loadImage(img)
        Dim enableWeb As Boolean = My.Settings(slideKey & "EnableWeb")
        SetEnableWeb(enableWeb)
    End Sub

    ''' <summary>
    ''' Updates main content of slide
    ''' </summary>
    ''' <param name="txt"></param>
    Public Sub SetContent(txt As String)
        bodyTB.Text = txt
        txtInput.Text = txt
    End Sub

    Public Sub SetWebLink(link As String)
        My.Settings.Item(slideKey & "WebLink") = link
        If link.Equals("") Then
            useTxtFile.Checked = True
        End If
        googleSlidesLink.Text = link
        webBrowser.refreshBrowser(link)
    End Sub

    Public Sub SetEnableWeb(bool As Boolean)
        My.Settings.Item(slideKey & "EnableWeb") = bool
        If bool Then
            useGoogleSlides.Checked = True
        Else
            useTxtFile.Checked = True
        End If
    End Sub

    Public Sub ShowBrowser()
        If My.Settings.Item(slideKey & "EnableWeb") Then
            webBrowser.MaximizeOnScreen(SettingsForm.getScreen())
            webBrowser.refreshBrowser(My.Settings.Item(slideKey & "WebLink"))
            webBrowser.Show()
        End If
    End Sub

    Public Sub HideBrowser()
        webBrowser.Hide()
    End Sub
    Public Sub setTitleTB(tb As PowerPoint.TextRange)
        titleTB = tb
    End Sub
    Public Sub setBodyTB(tb As PowerPoint.TextRange)
        bodyTB = tb
    End Sub

    Public Sub loadImage(dir As String)
        If My.Computer.FileSystem.FileExists(dir) = True Then
            slide.Shapes.AddPicture(dir, False, True, 0, 0, slide.Master.Width, slide.Master.Height)
        End If
        imageViewer.updatePreviews()
    End Sub

    Private Sub insertImage_Click(sender As Object, e As EventArgs) Handles insertImage.Click
        Dim imageFilePath = MainProgram.uploadImage()
        If Not imageFilePath.Equals("") Then
            slide.Shapes.AddPicture(imageFilePath, False, True, 0, 0, slide.Master.Width, slide.Master.Height)
            My.Settings.Item(slideKey & "Image") = imageFilePath
            imageViewer.updatePreviews()
        End If
    End Sub


    Private Sub delImage_Click(sender As Object, e As EventArgs) Handles delImage.Click
        Try
            If slide.Shapes.Count > 6 Then
                slide.Shapes(7).Delete()
                My.Settings.Item(slideKey & "Image") = ""
                MessageBox.Show("Image was successfully deleted.", "Success")
            Else
                MessageBox.Show("No image is currently inserted.", "Error")
            End If
            imageViewer.updatePreviews()
        Catch ex As Exception
            MessageBox.Show("An error occurred while deleting the image. Please try again.", "Error")
        End Try
    End Sub

    Private Sub TitleColorBtn_Click(sender As Object, e As EventArgs) Handles TitleColorBtn.Click
        MainProgram.ChangeColor(titleTB)
        imageViewer.updatePreviews()
    End Sub

    Private Sub TitleFontBtn_Click(sender As Object, e As EventArgs) Handles TitleFontBtn.Click
        MainProgram.ChangeFont(titleTB)
        imageViewer.updatePreviews()
    End Sub

    Private Sub BodyColorBtn_Click(sender As Object, e As EventArgs) Handles BodyColorBtn.Click
        MainProgram.ChangeColor(bodyTB)
        imageViewer.updatePreviews()
    End Sub

    Private Sub BodyFontBtn_Click(sender As Object, e As EventArgs) Handles BodyFontBtn.Click
        MainProgram.ChangeFont(bodyTB)
        imageViewer.updatePreviews()
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        Try
            SetContent(txtInput.Text)
            imageViewer.updatePreviews()
            SetWebLink(googleSlidesLink.Text)
            My.Settings.Item(slideKey & "Content") = txtInput.Text
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

    Private Sub previewBox_Click(sender As Object, e As EventArgs) Handles previewBox.Click, enlargePreviewBtn.Click
        imageViewer.Show()
    End Sub

    Private Sub googleSlidesLink_KeyDown(sender As Object, e As KeyEventArgs) Handles googleSlidesLink.KeyDown
        If e.KeyCode = Keys.Enter Then
            SetWebLink(googleSlidesLink.Text)
            MessageBox.Show("Google link saved", "Save Successful")
        End If
    End Sub

    Private Sub useTxtFile_CheckedChanged(sender As Object, e As EventArgs) Handles useTxtFile.CheckedChanged
        If useTxtFile.Checked Then
            My.Settings.Item(slideKey & "EnableWeb") = False
            HideBrowser()
        End If

    End Sub

    Private Sub useGoogleSlides_CheckedChanged(sender As Object, e As EventArgs) Handles useGoogleSlides.CheckedChanged
        If useGoogleSlides.Checked Then
            My.Settings.Item(slideKey & "EnableWeb") = True
            If MainProgram.IsCurrentSlideIndex(slide.SlideIndex) Then
                ShowBrowser()
            End If
        End If

    End Sub

    Private Sub BaseSlideEdit_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.Closing
        'Ensure that upon closing, the form state is still saved
        Hide()
        imageViewer.Hide()
        e.Cancel = True
    End Sub

End Class