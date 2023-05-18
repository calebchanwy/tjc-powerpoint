Public Class ImageViewer
    Inherits DraggableForm

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
    End Sub
    Public Sub updateImage(image As Bitmap)
        pictureBox.Image = image
    End Sub
    Private Sub closeForm_Click(sender As Object, e As EventArgs) Handles closeForm.Click
        Me.Hide()
    End Sub
    Private Sub minForm_Click(sender As Object, e As EventArgs) Handles minForm.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

End Class