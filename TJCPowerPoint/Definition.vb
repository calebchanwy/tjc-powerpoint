'Class that acts as a string enum. Defines the keys of the dictionairies used and is
'accessible for all classes

Public Class Definition
    Private Key As String

    'slide definitions as string keys
    Public Shared ReadOnly break As Definition = New Definition("break")
    Public Shared ReadOnly sermonTitle As Definition = New Definition("sermonTitle")
    Public Shared ReadOnly sermonHymnsSlide As Definition = New Definition("sermonHymnsSlide")
    Public Shared ReadOnly bibleVersesSlide As Definition = New Definition("bibleVersesSlide")
    Public Shared ReadOnly hymnalHymnsSlide As Definition = New Definition("hymnalHymnsSlide")
    Public Shared ReadOnly prayerRequests As Definition = New Definition("prayerRequests")
    Public Shared ReadOnly announcements As Definition = New Definition("announcements")
    Public Shared ReadOnly holyCommunion As Definition = New Definition("holyCommunion")
    Public Shared ReadOnly howToPray As Definition = New Definition("howToPray")
    Public Shared ReadOnly turnOffDevices As Definition = New Definition("turnOffDevices")
    Public Shared ReadOnly serviceTimes As Definition = New Definition("serviceTimes")


    'text box definitions as string keys
    Public Shared ReadOnly time As Definition = New Definition("time")
    Public Shared ReadOnly englishTitle As Definition = New Definition("englishTitle")
    Public Shared ReadOnly sermonHymns As Definition = New Definition("sermonHymns")
    Public Shared ReadOnly hymnalHymns As Definition = New Definition("hymnalHymns")
    Public Shared ReadOnly HCHymns As Definition = New Definition("HChymns")
    Private Sub New(key As String)
        Me.Key = key
    End Sub

    Public Overrides Function ToString() As String
        Return Me.Key
    End Function
End Class
