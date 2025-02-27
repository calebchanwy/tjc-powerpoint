﻿Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Threading
Imports System.Drawing
Imports System.Windows.Forms
Public Class BaseSlideEdit
    Inherits DraggableForm
    Private slideName As String
    Private slideKey As String
    Private aeroEnabled As Boolean
    Private IsUsingBrowser As Boolean
    'Text boxes
    Private slide As PowerPoint.Slide
    Private titleTB As PowerPoint.TextRange
    Private bodyTB As PowerPoint.TextRange
    Private GSlink As String
    'Image Viewer
    Private iv As ImageViewer
    'Web Browser
    Private webBrowser As WebBrowser

    Public Sub New(nm As String, key As String, s As PowerPoint.Slide)
        iv = New ImageViewer(s)
        webBrowser = New WebBrowser(nm)
        slideName = nm
        slideKey = key
        slide = s

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        loadData()
        header.Text = slideName
        Text = slideName
        iv.addPreviewBox(previewBox)
        iv.updatePreviews()
    End Sub
    'Method that updates form's own internal text box
    Public Sub setInput(txt As String)
        txtInput.Text = txt
    End Sub

    Private Sub loadData()
        Dim xmlDoc As XDocument = XDocument.Load(MainProgram.getCurrentDirectory() + "\Files\config.xml")
        ' Extract google slides link from xml file
        Dim googleSlidesLink As String = xmlDoc.Element("root")?.Element("googleSlides")?.Element(slideKey)?.Value
        setGSLink(googleSlidesLink)
        'Extract image directory from xml file
        Dim imageDirectory As String = xmlDoc.Element("root")?.Element("imageDirectories")?.Element(slideKey)?.Value
        loadImage(imageDirectory)
        'Extract if using google slides or not
        Dim bool As String = xmlDoc.Element("root")?.Element("showBrowser")?.Element(slideKey)?.Value
        setBrowserBool(bool)
    End Sub

    Public Sub setGSLink(link As String)
        If link.Equals("") Then
            useTxtFile.Checked = True
        End If
        GSlink = link
        googleSlidesLink.Text = GSlink
    End Sub

    Public Sub setBrowserBool(bool As String)
        IsUsingBrowser = Boolean.Parse(bool)
        If IsUsingBrowser Then
            useGoogleSlides.Checked = True
        Else
            useTxtFile.Checked = True
        End If
    End Sub

    Public Sub ShowBrowser()
        'check if using browser or not
        If IsUsingBrowser Then
            webBrowser.MaximizeOnScreen(SettingsForm.getScreen())
            webBrowser.refreshBrowser(GSlink)
            webBrowser.Show()
        End If
    End Sub

    Public Sub HideBrowser()
        webBrowser.Hide()
    End Sub


    Private Sub updateLink()
        'update in xml file
        GSlink = googleSlidesLink.Text
        UpdateGSLinkXML(MainProgram.getCurrentDirectory() + "\Files\config.xml", GSlink)

        'update in web browser
        webBrowser.refreshBrowser(GSlink)
    End Sub
    Public Function getGSLink()
        Return GSlink
    End Function
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
        iv.updatePreviews()
    End Sub

    Private Sub insertImage_Click(sender As Object, e As EventArgs) Handles insertImage.Click
        Dim imageFilePath = MainProgram.uploadImage()
        slide.Shapes.AddPicture(imageFilePath, False, True, 0, 0, slide.Master.Width, slide.Master.Height)
        UpdateDirXML(MainProgram.getCurrentDirectory() + "\Files\config.xml", imageFilePath)
        iv.updatePreviews()
    End Sub


    Private Sub delImage_Click(sender As Object, e As EventArgs) Handles delImage.Click
        Try
            If slide.Shapes.Count >= 6 Then
                slide.Shapes(6).Delete()

                Dim imageDirPath As String = Path.Combine(Directory.GetCurrentDirectory(), "Files", slideName.Replace(" ", "") + "Dir.txt")
                UpdateDirXML(MainProgram.getCurrentDirectory() + "\Files\config.xml", "")

                MessageBox.Show("Image was successfully deleted.", "Success")
            Else
                MessageBox.Show("No image is currently inserted.", "Error")
            End If
            iv.updatePreviews()
        Catch ex As Exception
            MessageBox.Show("An error occurred while deleting the image. Please try again.", "Error")
        End Try
    End Sub

    Private Sub UpdateXmlElement(xmlFilePath As String, parentElementName As String, elementName As String, newData As String)
        Dim xmlDoc As XDocument = XDocument.Load(xmlFilePath)

        Dim parentElement As XElement = xmlDoc.Root.Element(parentElementName)
        If parentElement IsNot Nothing Then
            Dim element As XElement = parentElement.Element(elementName)
            If element IsNot Nothing Then
                Dim updatedElement As New XElement(element.Name, element.Attributes(), newData)
                element.ReplaceWith(updatedElement)
                xmlDoc.Save(xmlFilePath)
            End If
        End If
    End Sub

    Private Sub UpdateGSLinkXML(xmlFilePath As String, newData As String)
        UpdateXmlElement(xmlFilePath, "googleSlides", slideKey, newData)
    End Sub

    Private Sub UpdateDirXML(xmlFilePath As String, newData As String)
        UpdateXmlElement(xmlFilePath, "imageDirectories", slideKey, newData)
    End Sub
    Private Sub UpdateShowBrowserXML(xmlFilePath As String, newData As String)
        UpdateXmlElement(xmlFilePath, "showBrowser", slideKey, newData)
    End Sub

    Private Sub TitleColorBtn_Click(sender As Object, e As EventArgs) Handles TitleColorBtn.Click
        MainProgram.ChangeColor(titleTB)
        iv.updatePreviews()
    End Sub

    Private Sub TitleFontBtn_Click(sender As Object, e As EventArgs) Handles TitleFontBtn.Click
        MainProgram.ChangeFont(titleTB)
        iv.updatePreviews()
    End Sub

    Private Sub BodyColorBtn_Click(sender As Object, e As EventArgs) Handles BodyColorBtn.Click
        MainProgram.ChangeColor(bodyTB)
        iv.updatePreviews()
    End Sub

    Private Sub BodyFontBtn_Click(sender As Object, e As EventArgs) Handles BodyFontBtn.Click
        MainProgram.ChangeFont(bodyTB)
        iv.updatePreviews()
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        bodyTB.Text = txtInput.Text
        Try
            iv.updatePreviews()
            updateLink()
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

    Private Sub closeForm_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub
    Private Sub minForm_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub previewBox_Click(sender As Object, e As EventArgs) Handles previewBox.Click, enlargePreviewBtn.Click
        iv.Show()
    End Sub


    Private Sub googleSlidesLink_KeyDown(sender As Object, e As KeyEventArgs) Handles googleSlidesLink.KeyDown
        If e.KeyCode = Keys.Enter Then
            setGSLink(googleSlidesLink.Text)
            updateLink()
            MessageBox.Show("Google link saved", "Save Successful")
        End If
    End Sub

    Private Sub useTxtFile_CheckedChanged(sender As Object, e As EventArgs) Handles useTxtFile.CheckedChanged
        If useTxtFile.Checked Then
            IsUsingBrowser = False
            UpdateShowBrowserXML(MainProgram.getCurrentDirectory() + "\Files\config.xml", "False")
            HideBrowser()
        End If

    End Sub

    Private Sub useGoogleSlides_CheckedChanged(sender As Object, e As EventArgs) Handles useGoogleSlides.CheckedChanged
        If useGoogleSlides.Checked Then
            IsUsingBrowser = True
            UpdateShowBrowserXML(MainProgram.getCurrentDirectory() + "\Files\config.xml", "True")
            If MainProgram.IsCurrentSlideIndex(slide.SlideIndex) Then
                ShowBrowser()
            End If
        End If

    End Sub

    'Ensures that upon closing, the form state is still saved
    Private Sub BaseSlideEdit_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.Closing
        Hide()
        iv.Hide()
        e.Cancel = True
    End Sub

End Class