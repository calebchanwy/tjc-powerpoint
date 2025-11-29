Imports Microsoft.Office.Interop
'class that defines all the links between the slide order numbers and the actual objects themselves


Public Class DictionairyFactory
    Private slideDictionary As Dictionary(Of String, PowerPoint.Slide)
    Private textBoxDictionary As Dictionary(Of String, PowerPoint.TextRange)
    Private ppPres As PowerPoint.Presentation


    'DEFAULT CONSTRUCTOR
    Public Sub New(pp As PowerPoint.Presentation)
        ppPres = pp
        MakeSlideDictionairy()
        MakeTextBoxDictionairy()
    End Sub

    Public Function getSlideDictionairy()
        Return slideDictionary
    End Function

    Public Function getTextBoxDictionairy()
        Return textBoxDictionary
    End Function

    'Method to instantiate dictionaries, for edits in powerpoint arrangements and slides CHANGE HERE
    Private Sub MakeSlideDictionairy()
        'ORDER OF SLIDES:
        ' 1 - Break slide
        ' 2 - Service Hymns
        '   2.1 English Title
        '   2.2 Chinese Title
        '   2.3 Hymn Header
        '   2.4 Hymn No
        '   2.5 Service Type
        ' 3 - Bible Verses
        '   3.1 English Title
        '   3.2 Chinese Title
        '   3.3 Bible Verse Header
        '   3.4 English Book
        '   3.5 Chinese Book
        '   3.6 Chapter and Verses
        '   3.7 Service Type
        ' 4 - Hymnal
        '   4.1 Hymn Nos
        ' 5 - Prayer Requests
        ' 5.1 Prayer Requests Text
        '6 - Announcements
        ' 6.1 Announcements Text
        '7 - Holy Communion
        '   7.1 Hymn
        '   7.2 Bread
        '   7.3 Cup
        '8 - How to pray
        '9 - Turn off devices
        '10 - Service Timetable

        'ADD all slides as appears in powerpoint with key as slide name
        slideDictionary = New Dictionary(Of String, PowerPoint.Slide)
        slideDictionary.Add(Definition.break.ToString(), ppPres.Slides(1))
        slideDictionary.Add(Definition.sermonTitle.ToString(), ppPres.Slides(2))
        slideDictionary.Add(Definition.sermonHymnsSlide.ToString(), ppPres.Slides(3))
        slideDictionary.Add(Definition.bibleVersesSlide.ToString(), ppPres.Slides(4))
        slideDictionary.Add(Definition.hymnalHymnsSlide.ToString(), ppPres.Slides(5))
        slideDictionary.Add(Definition.prayerRequests.ToString(), ppPres.Slides(6))
        slideDictionary.Add(Definition.announcements.ToString(), ppPres.Slides(7))
        slideDictionary.Add(Definition.holyCommunion.ToString(), ppPres.Slides(8))
        slideDictionary.Add(Definition.howToPray.ToString(), ppPres.Slides(9))
        slideDictionary.Add(Definition.turnOffDevices.ToString(), ppPres.Slides(10))
        slideDictionary.Add(Definition.serviceTimes.ToString(), ppPres.Slides(11))
    End Sub

    Private Sub MakeTextBoxDictionairy()
        'ADD all shapes as appears in powerpoint with key as shappe name
        textBoxDictionary = New Dictionary(Of String, PowerPoint.TextRange)
        textBoxDictionary.Add("time", slideDictionary.Item("break").Shapes(2).TextFrame.TextRange)
        'title slide
        textBoxDictionary.Add("englishTitle", slideDictionary.Item("sermonTitle").Shapes(1).TextFrame.TextRange)
        textBoxDictionary.Add("chineseTitle", slideDictionary.Item("sermonTitle").Shapes(2).TextFrame.TextRange)
        textBoxDictionary.Add("serviceType", slideDictionary.Item("sermonTitle").Shapes(3).TextFrame.TextRange)
        'sermon hymns slide
        textBoxDictionary.Add("englishTitle1", slideDictionary.Item("sermonHymnsSlide").Shapes(1).TextFrame.TextRange)
        textBoxDictionary.Add("chineseTitle1", slideDictionary.Item("sermonHymnsSlide").Shapes(2).TextFrame.TextRange)
        textBoxDictionary.Add("hymnHeader", slideDictionary.Item("sermonHymnsSlide").Shapes(3).TextFrame.TextRange)
        textBoxDictionary.Add("sermonHymns", slideDictionary.Item("sermonHymnsSlide").Shapes(4).TextFrame.TextRange)
        textBoxDictionary.Add("serviceType1", slideDictionary.Item("sermonHymnsSlide").Shapes(5).TextFrame.TextRange)
        'bible verse slide
        textBoxDictionary.Add("englishTitle2", slideDictionary.Item("bibleVersesSlide").Shapes(1).TextFrame.TextRange)
        textBoxDictionary.Add("chineseTitle2", slideDictionary.Item("bibleVersesSlide").Shapes(2).TextFrame.TextRange)
        textBoxDictionary.Add("bibleHeader", slideDictionary.Item("bibleVersesSlide").Shapes(3).TextFrame.TextRange)
        textBoxDictionary.Add("englishBook", slideDictionary.Item("bibleVersesSlide").Shapes(4).GroupItems(1).TextFrame.TextRange)
        textBoxDictionary.Add("chineseBook", slideDictionary.Item("bibleVersesSlide").Shapes(4).GroupItems(2).TextFrame.TextRange)
        textBoxDictionary.Add("chapterAndVerse", slideDictionary.Item("bibleVersesSlide").Shapes(4).GroupItems(3).TextFrame.TextRange)
        textBoxDictionary.Add("serviceType2", slideDictionary.Item("bibleVersesSlide").Shapes(5).TextFrame.TextRange)
        'hymnal hymn slide
        textBoxDictionary.Add("hymnalHymns", slideDictionary.Item("hymnalHymnsSlide").Shapes(1).TextFrame.TextRange)
        textBoxDictionary.Add("serviceType3", slideDictionary.Item("hymnalHymnsSlide").Shapes(3).TextFrame.TextRange)
        'prayer requests slide
        textBoxDictionary.Add("PrayerRequestsTxt", slideDictionary.Item("prayerRequests").Shapes(1).TextFrame.TextRange)
        textBoxDictionary.Add("PrayerRequestsTitle", slideDictionary.Item("prayerRequests").Shapes(2).TextFrame.TextRange)
        'announcements slide
        textBoxDictionary.Add("AnnouncementsTxt", slideDictionary.Item("announcements").Shapes(1).TextFrame.TextRange)
        textBoxDictionary.Add("AnnouncementsTitle", slideDictionary.Item("announcements").Shapes(2).TextFrame.TextRange)
        'service times slide
        textBoxDictionary.Add("ServiceTimesTxt", slideDictionary.Item(Definition.serviceTimes.ToString()).Shapes(1).TextFrame.TextRange)
        textBoxDictionary.Add("ServiceTimesTitle", slideDictionary.Item(Definition.serviceTimes.ToString()).Shapes(2).TextFrame.TextRange)
        'holy communion slide
        textBoxDictionary.Add("HChymns", slideDictionary.Item("holyCommunion").Shapes(1).TextFrame.TextRange)
        textBoxDictionary.Add("bread", slideDictionary.Item("holyCommunion").Shapes(2).TextFrame.TextRange)
        textBoxDictionary.Add("cup", slideDictionary.Item("holyCommunion").Shapes(3).TextFrame.TextRange)
    End Sub

End Class
