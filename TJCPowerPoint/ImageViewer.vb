Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.PowerPoint
Imports System.IO
Imports System.Threading

Public Class ImageViewer
    Inherits DraggableForm

    Private Const imageWidth = 775
    Private Const imageHeight = 390
    Private previewBoxes As ArrayList
    Private slide As Slide

    Public Sub New(slide As PowerPoint.Slide)
        ' This call is required by the designer.
        InitializeComponent()
        Me.slide = slide
        previewBoxes = New ArrayList()
        addPreviewBox(pictureBox)
    End Sub

    Public Sub addPreviewBox(previewBox As PictureBox)
        previewBoxes.Add(previewBox)
    End Sub

    Public Sub updatePreviews()
        ' Export the slide as an image
        Dim imagePath As String = Path.Combine(Path.GetTempPath(), "slide_preview.png")
        slide.Export(imagePath, "PNG", imageWidth, imageHeight)

        Dim copiedImagePath As String = Path.GetTempFileName() ' Generate a unique temporary file name
        copiedImagePath = Path.ChangeExtension(copiedImagePath, ".png") ' Change the file extension to .png if needed

        ' Make a copy of the image file
        File.Copy(imagePath, copiedImagePath, True)

        ' Display the slide preview from the copied image file
        Using image As Image = Image.FromFile(copiedImagePath)
            For Each preview In previewBoxes
                preview.Image = New Bitmap(image)
            Next
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

    Private Sub closeForm_Click(sender As Object, e As EventArgs) 
        Me.Hide()
    End Sub
    Private Sub minForm_Click(sender As Object, e As EventArgs) 
        Me.WindowState = FormWindowState.Minimized
    End Sub

End Class