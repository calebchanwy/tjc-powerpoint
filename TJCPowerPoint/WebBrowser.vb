Public Class WebBrowser
    Private src As String

    Public Sub refreshBrowser(src As String)
        Me.src = src
        Try
            webView.Source = New Uri(src)
            Focus()
        Catch ex As Exception
            Hide()
        End Try
    End Sub
    Public Sub MaximizeOnScreen(screen As Screen)
        ' Set the form's WindowState to Maximized
        WindowState = FormWindowState.Normal ' Restore the form to normal state first (if it was minimized)
        StartPosition = FormStartPosition.Manual
        Location = screen.Bounds.Location
        Size = screen.Bounds.Size
        WindowState = FormWindowState.Maximized
    End Sub
End Class