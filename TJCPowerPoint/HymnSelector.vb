Public Class HymnSelector
    Private hymns As New ArrayList
    Private nameCollection As String
    Private selectedIndex As Integer

    'DEFAULT CONSTRUCTOR
    Public Sub New(name As String)
        nameCollection = name
        selectedIndex = 0
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

    Public Sub removeHymn(hymn As String)
        hymns.Remove(hymn)
    End Sub

    Public Function getSelectedIndex()
        Return selectedIndex
    End Function

    Public Sub setSelectedIndex(index As Integer)
        selectedIndex = index
    End Sub

    Public Function GetSelectedHymns(index As Integer, n As Integer)
        Dim totalHymns As Integer = hymns.Count

        ' Check if number of hymns is less than or equal to the requested count
        If totalHymns <= n Then
            Return String.Join(vbCr, hymns)
        Else
            ' Calculate the ending index for the selected hymns
            Dim endIndex As Integer = index + n - 1

            ' If the ending index exceeds the total number of hymns, return the last n hymns
            If endIndex >= totalHymns Then
                Dim startingIndex As Integer = totalHymns - n
                Return String.Join(vbCr, hymns.GetRange(startingIndex, n))
            Else
                Return String.Join(vbCr, hymns.GetRange(index, n))
            End If
        End If
    End Function

End Class
