Public Class WebBrowser
    Inherits Form
    Private src As String

    Public Sub New(name As String)
        InitializeComponent()
        Text = name + " - Web Browser"
    End Sub

    ''' <summary>
    ''' Refreshes and refocuses WebBrowser
    ''' </summary>
    ''' <param name="src">New website link</param>
    Public Sub refreshBrowser(src As String)
        Me.src = src
        Try
            webView.Source = New Uri(src)
            Focus()
        Catch ex As Exception
            Hide()
        End Try
    End Sub
    ''' <summary>
    ''' Maximises WebBrowser on supplied screen
    ''' </summary>
    ''' <param name="screen"></param>
    Public Sub MaximizeOnScreen(screen As Screen)
        WindowState = FormWindowState.Normal ' Restore the form to normal state first (if it was minimized)
        StartPosition = FormStartPosition.Manual
        Location = screen.Bounds.Location
        Size = screen.Bounds.Size
        WindowState = FormWindowState.Maximized
    End Sub

End Class