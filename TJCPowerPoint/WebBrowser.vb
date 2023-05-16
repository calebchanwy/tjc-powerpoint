Public Class WebBrowser
    Private src As String

    Private Sub refreshBrowser()
        Try
            webView.Source = New Uri(src)
        Catch ex As Exception
        End Try
        Show()
    End Sub

    Public Sub setSource(source As String)
        src = source
        refreshBrowser()
    End Sub

End Class