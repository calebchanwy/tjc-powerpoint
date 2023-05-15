Public Class HymnSelector
    Private hymns As New ArrayList
    Private nameCollection As String

    'DEFAULT CONSTRUCTOR
    Public Sub New(name As String)
        nameCollection = name
    End Sub
    Public Function getName()
        Return nameCollection
    End Function

    Public Function getAllHymns()
        Return hymns
    End Function

    'updates hymns
    Public Sub addHymn(hymn As String)
        hymns.Add(hymn)
    End Sub

    'get an array of n hymns starting from the selected index
    'Handles cases where index+n exceeds number of hymns request
    Public Function getSelectHymns(index As Integer, n As Integer)
        'if number of hymns is less than or equal to request, return hymns
        If hymns.Count <= n Then
            Return hymns
        Else
            'if near top half of hymns, return last n hymns
            If index + n > hymns.Count - 1 Then
                Return hymns.GetRange(hymns.Count - n - 1, n)
            Else
                Return hymns.GetRange(index, n)
            End If
        End If
    End Function
End Class
