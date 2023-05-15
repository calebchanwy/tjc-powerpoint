Public Class WebBrowser
    Private src As String

    Private Sub refresh()
        Try
            webView.Source = New Uri(src)
        Catch ex As Exception
        End Try
        Show()
    End Sub

    Public Sub setSource(source As String)
        src = source
        refresh()
    End Sub

End Class