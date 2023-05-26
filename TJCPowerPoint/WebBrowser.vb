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

End Class