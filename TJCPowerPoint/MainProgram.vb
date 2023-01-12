Imports Office = Microsoft.Office.Core
Imports PowerPoint = Microsoft.Office.Interop.PowerPoint
Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Xml

Public Class MainProgram
    Dim ppApp As New PowerPoint.Application
    Public ppPres As PowerPoint.Presentation
    Public CurrentDirectory As String = Directory.GetCurrentDirectory()
    Dim PrayerRequests As New PrayerRequests
    Dim Writer As XmlTextWriter = Nothing
    Dim RecentFile As String

    Dim sermonHymns As String = ""
    Dim hymnalHymns As String = ""
    Dim prevSelectedIndex As Integer = -1
    Dim prevSermonHymnSelectedIndex = -1
    Private highlightedParagraph As Integer
    Private prevHighlightedPar As Integer
    Private hymnTextBox As PowerPoint.TextRange ' keep track of which hymn text box is changing

    'Use of a dictionary to easily change slide numbers and shape numbers
    Public slideDictionary As Dictionary(Of String, PowerPoint.Slide)
    Public textBoxDictionary As Dictionary(Of String, PowerPoint.TextRange)


    'Method dealing with what the form will do when it initially opens
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadingScreen.Show()
            LoadingScreen.Activate()
            MakeFolder()
            LoadPres()
            HandleAnnouncements()
            HandlePrayerRequests()
            LoadHC()
            LoadPrayerImage()
            LoadTimetableImg()
        Catch ex As Exception
            Me.Close()
            LoadingScreen.Hide()
        End Try
        LoadingScreen.Hide()
    End Sub



    'Method to deal with the form closing
    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            'Checking for Null errors due to error elsewhere, ensure safe close of program
            If Writer IsNot Nothing Then
                Writer.WriteEndElement()
                Writer.Close()
            End If
            If ppPres IsNot Nothing Then
                ppPres.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    'Method dealing when the exit button is clicked
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click, closeForm.Click
        Me.Close()
    End Sub

    'Method called to create a folder for the files and resources
    Private Sub MakeFolder()
        If Directory.Exists("\Files") = False Then
            My.Computer.FileSystem.CreateDirectory(CurrentDirectory + "\Files")
        End If
        If My.Computer.FileSystem.FileExists(CurrentDirectory + "\Files\ServiceWidescreen.pptx") = False Then
            System.IO.File.WriteAllBytes(CurrentDirectory + "\Files\ServiceWidescreen.pptx", My.Resources.ServiceWidescreen)
        End If
    End Sub

    'Method to instantiate dictionaries, for edits in powerpoint arrangements and slides CHANGE HERE
    Private Sub MakeDictionary()
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
        '   7.2 Hymn
        '   7.3 Bread
        '   7.4 Cup
        '8 - How to pray
        '9 - Turn off devices
        '10 - Service Timetable

        'ADD all slides as appears in powerpoint with key as slide name
        slideDictionary = New Dictionary(Of String, PowerPoint.Slide)
        slideDictionary.Add("break", ppPres.Slides(1))
        slideDictionary.Add("sermonHymnsSlide", ppPres.Slides(2))
        slideDictionary.Add("bibleVersesSlide", ppPres.Slides(3))
        slideDictionary.Add("hymnalHymnsSlide", ppPres.Slides(4))
        slideDictionary.Add("prayerRequests", ppPres.Slides(5))
        slideDictionary.Add("announcements", ppPres.Slides(6))
        slideDictionary.Add("holyCommunion", ppPres.Slides(7))
        slideDictionary.Add("howToPray", ppPres.Slides(8))
        slideDictionary.Add("turnOffDevices", ppPres.Slides(9))
        slideDictionary.Add("serviceTimes", ppPres.Slides(10))
        'ADD all shapes as appears in powerpoint with key as shappe name
        textBoxDictionary = New Dictionary(Of String, PowerPoint.TextRange)
        textBoxDictionary.Add("time", slideDictionary.Item("break").Shapes(1).TextFrame.TextRange)
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
        textBoxDictionary.Add("englishBook", slideDictionary.Item("bibleVersesSlide").Shapes(4).TextFrame.TextRange)
        textBoxDictionary.Add("chineseBook", slideDictionary.Item("bibleVersesSlide").Shapes(5).TextFrame.TextRange)
        textBoxDictionary.Add("chapterAndVerse", slideDictionary.Item("bibleVersesSlide").Shapes(6).TextFrame.TextRange)
        textBoxDictionary.Add("serviceType2", slideDictionary.Item("bibleVersesSlide").Shapes(7).TextFrame.TextRange)
        'hymnal hymn slide
        textBoxDictionary.Add("hymnalHymns", slideDictionary.Item("hymnalHymnsSlide").Shapes(1).TextFrame.TextRange)
        'prayer requests slide
        textBoxDictionary.Add("prayerRequestsTxt", slideDictionary.Item("prayerRequests").Shapes(1).TextFrame.TextRange)
        textBoxDictionary.Add("prayerRequestsTitle", slideDictionary.Item("prayerRequests").Shapes(2).TextFrame.TextRange)
        'announcements slide
        textBoxDictionary.Add("announcementsTxt", slideDictionary.Item("announcements").Shapes(1).TextFrame.TextRange)
        textBoxDictionary.Add("announcementsTitle", slideDictionary.Item("announcements").Shapes(2).TextFrame.TextRange)
        'holy communion slide
        textBoxDictionary.Add("HChymns", slideDictionary.Item("holyCommunion").Shapes(2).TextFrame.TextRange)
        textBoxDictionary.Add("bread", slideDictionary.Item("holyCommunion").Shapes(3).TextFrame.TextRange)
        textBoxDictionary.Add("cup", slideDictionary.Item("holyCommunion").Shapes(4).TextFrame.TextRange)
    End Sub
    'Method to load up the presentation and instantiate slide text boxes
    Private Sub LoadPres()
        ppApp = CreateObject("PowerPoint.Application")
        ppPres = ppApp.Presentations.Open(CurrentDirectory + "\Files\ServiceWidescreen.pptx", [ReadOnly]:=Office.MsoTriState.msoFalse, WithWindow:=Office.MsoTriState.msoFalse)
        ppPres.Slides(1).Name = "Break"
        ppPres.Slides(2).Name = "Service"
        ppPres.Slides(5).Name = "Prayer Requests"
        ppPres.Slides(6).Name = "Announcements"
        ppPres.Slides(7).Name = "Holy Communion"
        ppPres.Slides(8).Name = "How To Pray"
        ppPres.Slides(9).Name = "Turn Off All Devices"
        ppPres.Slides(10).Name = "Service Timetable"
        Dim included() As Integer = {1, 2, 5, 6, 7, 8, 9, 10}
        For Each num As Integer In included
            SlideTrack.Items.Add(ppPres.Slides(num).Name)
        Next
        MakeDictionary()
        HandleSettings()
        ResetServiceDetails()
        ppPres.SlideShowSettings.Run()
        'by default go to break slide and hymntextbox set to service hymns
        SlideTrack.SelectedIndex = 0
        hymnTextBox = textBoxDictionary.Item("sermonHymns")

    End Sub

    'Method that will reset the program to the initial running state
    Private Sub ResetServiceDetails()
        HymnNos.Text = ""
        HymnsSelectionBox.Items.Clear()
        BookBox.Text = ""
        VerseTxt.Text = ""
        ChapterTxt.Text = ""
        EnglishTitle.Text = "English Sermon Title"
        ChineseTitle.Text = "中文講道題目"
        'service slide
        textBoxDictionary.Item("englishTitle1").Text = " "
        textBoxDictionary.Item("chineseTitle1").Text = " "
        textBoxDictionary.Item("sermonHymns").Text = " "
        textBoxDictionary.Item("serviceType1").Text = " "
        'bible verse slide
        textBoxDictionary.Item("englishTitle2").Text = " "
        textBoxDictionary.Item("chineseTitle2").Text = " "
        textBoxDictionary.Item("chapterAndVerse").Text = " "
        textBoxDictionary.Item("englishBook").Text = " "
        textBoxDictionary.Item("chineseBook").Text = " "
        textBoxDictionary.Item("serviceType2").Text = " "
        'holy communion slide
        textBoxDictionary.Item("HChymns").Text = " "
        'Hymnal Slide
        textBoxDictionary.Item("hymnalHymns").Text = " "
    End Sub

    'Method to deal with loading the Holy Communion slide with details from the text files
    'If no text file exists, then no names will be displayed
    Private Sub LoadHC()
        Dim bread As String
        Dim cup As String
        If My.Computer.FileSystem.FileExists(CurrentDirectory + "\Files\bread.txt") = True Then
            bread = My.Computer.FileSystem.ReadAllText(CurrentDirectory + "\Files\bread.txt")
            textBoxDictionary.Item("bread").Text = bread
        End If
        If My.Computer.FileSystem.FileExists(CurrentDirectory + "\Files\cup.txt") = True Then
            cup = My.Computer.FileSystem.ReadAllText(CurrentDirectory + "\Files\cup.txt")
            textBoxDictionary.Item("cup").Text = cup
        End If
    End Sub

    'Method to deal with loading the prayer requests image using directory listed out in text file
    'If no text file exists, then no prayer request image will be loaded
    Public Sub LoadPrayerImage()
        If My.Computer.FileSystem.FileExists(CurrentDirectory + "\Files\prayerImgDir.txt") = False Then
            System.IO.File.WriteAllText(CurrentDirectory + "\Files\prayerImgDir.txt", "")
        Else
            Dim directory As String
            directory = My.Computer.FileSystem.ReadAllText(CurrentDirectory + "\Files\prayerImgDir.txt")
            If My.Computer.FileSystem.FileExists(directory) = True Then
                slideDictionary.Item("prayerRequests").Shapes.AddPicture(directory, False, True, 0, 0, ppPres.PageSetup.SlideWidth, ppPres.PageSetup.SlideHeight)
            End If
        End If
    End Sub

    'Method to deal with loading the timetable image using directory listed out in text file
    'If no text file exists, then no prayer request image will be loaded
    Public Sub LoadTimetableImg()
        If My.Computer.FileSystem.FileExists(CurrentDirectory + "\Files\timetableDir.txt") = False Then
            System.IO.File.WriteAllText(CurrentDirectory + "\Files\timetableDir.txt", "")
        Else
            Dim directory As String
            directory = My.Computer.FileSystem.ReadAllText(CurrentDirectory + "\Files\timetableDir.txt")
            If My.Computer.FileSystem.FileExists(directory) = True Then
                slideDictionary.Item("serviceTimes").Shapes.AddPicture(directory, False, True, 0, 0, ppPres.PageSetup.SlideWidth, ppPres.PageSetup.SlideHeight)
            End If
        End If
    End Sub

    'Function that deals with taking the settings saved in the xml file
    'Applies the colours and fonts of each textbox
    Public Sub LoadSettings(str As String)
        Dim two As Integer = Val(str(2))
        Dim three As Integer = Val(str(3))
        If str(1) = "F" Then
            Dim FontName As String = Mid(str, InStr(str, "=") + 1, InStr(str, ",") - InStr(str, "=") - 1)
            Dim FontSize As String = Mid(str, InStr(str, ",") + 1, Len(str) - InStr(str, ","))
            ppPres.Slides(two).Shapes(three).TextFrame.TextRange.Font.Name = FontName
            ppPres.Slides(two).Shapes(three).TextFrame.TextRange.Font.Size = Convert.ToSingle(FontSize)
        Else
            If str(3) <> "]" Then
                Dim FontColor As String = Mid(str, InStr(str, "=") + 1, Len(str) - InStr(str, "="))
                ppPres.Slides(two).Shapes(three).TextFrame.TextRange.Font.Color.RGB = Color.FromArgb(Convert.ToInt32(FontColor)).ToArgb
                If two = slideDictionary.Item("prayerRequests").SlideNumber.ToString() Then
                    PrayerRequests.PrayerRequestTxt.ForeColor = Color.FromArgb(Convert.ToInt32(FontColor))
                ElseIf two = slideDictionary.Item("announcements").SlideNumber.ToString() Then
                    Announcements.AnnouncementTxt.ForeColor = Color.FromArgb(Convert.ToInt32(FontColor))
                End If
            Else
                Dim BGColor As String = Mid(str, InStr(str, "=") + 1, Len(str) - InStr(str, "="))
                ppPres.Slides(two).Background.Fill.ForeColor.RGB = Color.FromArgb(Convert.ToInt32(BGColor)).ToArgb
                If two = slideDictionary.Item("prayerRequests").SlideNumber.ToString() Then
                    Dim R As Integer = Color.FromArgb(Convert.ToInt32(BGColor)).R
                    Dim G As Integer = Color.FromArgb(Convert.ToInt32(BGColor)).G
                    Dim B As Integer = Color.FromArgb(Convert.ToInt32(BGColor)).B
                    PrayerRequests.PrayerRequestTxt.BackColor = Color.FromArgb(255, B, G, R)
                ElseIf two = slideDictionary.Item("prayerRequests").SlideNumber.ToString() Then
                    Dim R As Integer = Color.FromArgb(Convert.ToInt32(BGColor)).R
                    Dim G As Integer = Color.FromArgb(Convert.ToInt32(BGColor)).G
                    Dim B As Integer = Color.FromArgb(Convert.ToInt32(BGColor)).B
                    Announcements.AnnouncementTxt.BackColor = Color.FromArgb(255, B, G, R)
                End If
            End If
        End If
    End Sub

    Public Sub HandleSettings()
        If My.Computer.FileSystem.FileExists(CurrentDirectory + "\Files\Settings.ini") Then
            Dim Settings As Array = File.ReadAllLines(CurrentDirectory + "\Files\Settings.ini")
            For Each str As String In Settings
                LoadSettings(str)
            Next
        Else
            File.WriteAllBytes(CurrentDirectory + "\Files\Settings.ini", My.Resources.Settings)
            Dim Settings As Array = File.ReadAllLines(CurrentDirectory + "\Files\Settings.ini")
            For Each str As String In Settings
                LoadSettings(str)
            Next
        End If
    End Sub
    Public Sub HandleAnnouncements()
        If My.Computer.FileSystem.FileExists(CurrentDirectory + "\Files\Announcements.txt") Then
            Announcements.AnnouncementTxt.Text = File.ReadAllText(CurrentDirectory + "\Files\Announcements.txt", System.Text.Encoding.UTF32)
            textBoxDictionary.Item("announcementsTxt").Text = Announcements.AnnouncementTxt.Text
        Else
            Using sw As StreamWriter = File.CreateText(CurrentDirectory + "\Files\Announcements.txt")
                sw.WriteLine(" ")
            End Using
            Announcements.AnnouncementTxt.Text = File.ReadAllText(CurrentDirectory + "\Files\Announcements.txt", System.Text.Encoding.UTF32)
            textBoxDictionary.Item("announcementsTxt").Text = Announcements.AnnouncementTxt.Text
        End If
    End Sub
    Public Sub HandlePrayerRequests()
        If My.Computer.FileSystem.FileExists(CurrentDirectory + "\Files\PrayerRequests.txt") Then
            PrayerRequests.PrayerRequestTxt.Text = File.ReadAllText(CurrentDirectory + "\Files\PrayerRequests.txt", System.Text.Encoding.UTF32)
            textBoxDictionary.Item("prayerRequestsTxt").Text = PrayerRequests.PrayerRequestTxt.Text
        Else
            Using sw As StreamWriter = File.CreateText(CurrentDirectory + "\Files\PrayerRequests.txt")
                sw.WriteLine(" ")
            End Using
            PrayerRequests.PrayerRequestTxt.Text = File.ReadAllText(CurrentDirectory + "\Files\PrayerRequests.txt", System.Text.Encoding.UTF32)
           textBoxDictionary.Item("prayerRequestsTxt").Text = PrayerRequests.PrayerRequestTxt.Text
        End If
    End Sub
    Public Sub ChangeFont(textBox As PowerPoint.TextRange)
        FontDialog.Font = New Font(textBox.Font.Name.ToString, textBox.Font.Size)
        If FontDialog.ShowDialog = DialogResult.OK Then
            'Handle cases for where text boxes are same but on separate slides
            Select Case True
                Case textBox.Equals(textBoxDictionary.Item("englishTitle1"))
                    textBoxDictionary.Item("englishTitle1").Font.Name = FontDialog.Font.Name
                    textBoxDictionary.Item("englishTitle1").Font.Size = FontDialog.Font.Size
                    textBoxDictionary.Item("englishTitle1").Font.Bold = FontDialog.Font.Bold
                    textBoxDictionary.Item("englishTitle2").Font.Name = FontDialog.Font.Name
                    textBoxDictionary.Item("englishTitle2").Font.Size = FontDialog.Font.Size
                    textBoxDictionary.Item("englishTitle2").Font.Bold = FontDialog.Font.Bold
                    Return
                Case textBox.Text.Equals(textBoxDictionary.Item("chineseTitle1").Text)
                    textBoxDictionary.Item("chineseTitle1").Font.Name = FontDialog.Font.Name
                    textBoxDictionary.Item("chineseTitle1").Font.Size = FontDialog.Font.Size
                    textBoxDictionary.Item("chineseTitle1").Font.Bold = FontDialog.Font.Bold
                    textBoxDictionary.Item("chineseTitle2").Font.Name = FontDialog.Font.Name
                    textBoxDictionary.Item("chineseTitle2").Font.Size = FontDialog.Font.Size
                    textBoxDictionary.Item("chineseTitle2").Font.Bold = FontDialog.Font.Bold
                    Return
                Case textBox.Text.Equals(textBoxDictionary.Item("serviceType1").Text)
                    textBoxDictionary.Item("serviceType1").Font.Name = FontDialog.Font.Name
                    textBoxDictionary.Item("serviceType1").Font.Size = FontDialog.Font.Size
                    textBoxDictionary.Item("serviceType1").Font.Bold = FontDialog.Font.Bold
                    textBoxDictionary.Item("serviceType2").Font.Name = FontDialog.Font.Name
                    textBoxDictionary.Item("serviceType2").Font.Size = FontDialog.Font.Size
                    textBoxDictionary.Item("serviceType2").Font.Bold = FontDialog.Font.Bold
                    Return
            End Select
            textBox.Font.Name = FontDialog.Font.Name
            textBox.Font.Size = FontDialog.Font.Size
            textBox.Font.Bold = FontDialog.Font.Bold
        End If
    End Sub
    Public Sub ChangeColor(textBox As PowerPoint.TextRange)
        If ColorDialog.ShowDialog = DialogResult.OK Then
            Dim Red As Integer = Convert.ToInt32(ColorDialog.Color.R)
            Dim Green As Integer = Convert.ToInt32(ColorDialog.Color.G)
            Dim Blue As Integer = Convert.ToInt32(ColorDialog.Color.B)
            Dim acolor = Color.FromArgb(255, Blue, Green, Red).ToArgb
            Select Case True
                Case textBox.Text.Equals(textBoxDictionary.Item("englishTitle1").Text)
                    textBoxDictionary.Item("englishTitle1").Font.Color.RGB = acolor
                    textBoxDictionary.Item("englishTitle2").Font.Color.RGB = acolor
                    Return
                Case textBox.Text.Equals(textBoxDictionary.Item("chineseTitle1").Text)
                    textBoxDictionary.Item("chineseTitle1").Font.Color.RGB = acolor
                    textBoxDictionary.Item("chineseTitle2").Font.Color.RGB = acolor
                    Return
                Case textBox.Text.Equals(textBoxDictionary.Item("serviceType1").Text)
                    textBoxDictionary.Item("serviceType1").Font.Color.RGB = acolor
                    textBoxDictionary.Item("serviceType2").Font.Color.RGB = acolor
                    Return
            End Select
            textBox.Font.Color.RGB = acolor
        End If
    End Sub
    Public Function GetFontAndColor(i As Integer, j As Integer)
        Dim Font As String
        Font = "[F" & i & j & "]=" + ppPres.Slides(i).Shapes(j).TextFrame.TextRange.Font.Name + "," + Convert.ToString(ppPres.Slides(i).Shapes(j).TextFrame.TextRange.Font.Size) +
            vbCrLf + "[C" & i & j & "]=" + Convert.ToString(ppPres.Slides(i).Shapes(j).TextFrame.TextRange.Font.Color.RGB)
        Return Font
    End Function


    Private Sub ShowSermonHymns_CheckedChanged(sender As Object, e As EventArgs) Handles ShowSermonHymns.CheckedChanged
        If ShowSermonHymns.Checked Then
            'navigate to service slide
            SlideTrack.SelectedIndex = 1
            ppPres.SlideShowWindow.View.GotoSlide(slideDictionary.Item("sermonHymnsSlide").SlideIndex)
            hymnTextBox = textBoxDictionary.Item("sermonHymns")
            updateHymns(hymnTextBox)
            'remove memory of hymnal hymns
            hymnalHymns = ""
        Else
            'when sermon hymns is unchecked
            'take note of sermon hymns and selected index in memory
            sermonHymns = String.Join(vbNewLine, HymnsSelectionBox.Items.Cast(Of String))
            prevSermonHymnSelectedIndex = HymnsSelectionBox.SelectedIndex
        End If
    End Sub
    Private Sub ShowVerses_CheckedChanged(sender As Object, e As EventArgs) Handles ShowVerses.CheckedChanged
        If ShowVerses.Checked Then
            ppPres.SlideShowWindow.View.GotoSlide(slideDictionary.Item("bibleVersesSlide").SlideIndex)
        Else
            'when show verses is unchecked
            'clearing bible verses
            textBoxDictionary.Item("englishBook").Text = " "
            textBoxDictionary.Item("chineseBook").Text = " "
            textBoxDictionary.Item("chapterAndVerse").Text = " "
            BookBox.Text = ""
            VerseTxt.Text = ""
            ChapterTxt.Text = ""
        End If
    End Sub
    Private Sub ShowHymnal_CheckedChanged(sender As Object, e As EventArgs) Handles ShowHymnal.CheckedChanged
        If ShowHymnal.Checked Then
            ppPres.SlideShowWindow.View.GotoSlide(slideDictionary.Item("hymnalHymnsSlide").SlideIndex)
            hymnTextBox = textBoxDictionary.Item("hymnalHymns")
            HymnsSelectionBox.Items.Clear()
            updateHymns(hymnTextBox)
        Else
            'when hymnal is unchecked
            'take note of hymnal hymns
            hymnalHymns = String.Join(vbNewLine, HymnsSelectionBox.Items.Cast(Of String))
            'clear hymnal hymns
            reinsertHymns(sermonHymns)
            HymnsSelectionBox.SelectedIndex = prevSermonHymnSelectedIndex
            textBoxDictionary.Item("hymnalHymns").Text = ""
        End If
    End Sub

    Private Sub UpdateVerse_Click(sender As Object, e As EventArgs) Handles UpdateVerse.Click
        If VerseTxt.Text = "" And BookBox.Text = "" And ChapterTxt.Text = "" Then
            textBoxDictionary.Item("chapterAndVerse").Text = ""
        ElseIf BookBox.SelectedIndex <> -1 Then
            'if selected proper book update text boxes
            Dim commaPos As Integer
            commaPos = InStr(BookBox.Text, ",")
            textBoxDictionary.Item("englishBook").Text = Mid(BookBox.Text, 1, commaPos - 1)
            textBoxDictionary.Item("chineseBook").Text = Mid(BookBox.Text, commaPos + 1)
            textBoxDictionary.Item("chapterAndVerse").Text = ChapterTxt.Text + " : " + VerseTxt.Text
        End If
        'if called when show hymns is checked
        'automatically change to show verses
        If ShowVerses.Checked = False Then
            ShowVerses.Checked = True
        End If
    End Sub

    Private Sub UpdateTitle_Click(sender As Object, e As EventArgs) Handles UpdateTitle.Click
        'Removing blank tabs from titles to force centred titles
        If EnglishTitle.Text.Length > 1 And ChineseTitle.Text.Length > 1 Then
            While EnglishTitle.Text(EnglishTitle.Text.Length - 1) = " " Or EnglishTitle.Text(EnglishTitle.Text.Length - 1) = "	"
                EnglishTitle.Text = EnglishTitle.Text.Remove(EnglishTitle.Text.Length - 1)
            End While
            While ChineseTitle.Text(ChineseTitle.Text.Length - 1) = " " Or ChineseTitle.Text(ChineseTitle.Text.Length - 1) = "	"
                ChineseTitle.Text = ChineseTitle.Text.Remove(ChineseTitle.Text.Length - 1)
            End While
            'removing blank spaces from beginning
            While EnglishTitle.Text(0) = " " Or EnglishTitle.Text(0) = "	"
                EnglishTitle.Text = EnglishTitle.Text.Remove(0, 1)
            End While
            While ChineseTitle.Text(0) = " " Or ChineseTitle.Text(0) = "	"
                ChineseTitle.Text = ChineseTitle.Text.Remove(0, 1)
            End While
        End If
        'update on sermon slide
        textBoxDictionary.Item("englishTitle1").Text = EnglishTitle.Text
        textBoxDictionary.Item("chineseTitle1").Text = ChineseTitle.Text
        'update on bible verse slide
        textBoxDictionary.Item("englishTitle2").Text = EnglishTitle.Text
        textBoxDictionary.Item("chineseTitle2").Text = ChineseTitle.Text
        If ShowHymnal.Checked Then
            'If updated titles during hymnal, return to service hymns
            ShowSermonHymns.Checked = True
        End If
    End Sub



    'HYMN SELECTION --------------------------------------------
    Private Sub updateHymns(textBox As PowerPoint.TextRange)
        Dim hymns As String = ""
        Dim count = HymnsSelectionBox.Items.Count
        Dim index = HymnsSelectionBox.SelectedIndex
        If count = 0 Then
            textBox.Text = " "
            hideHymnHeader()
            Return
        Else
            showHymnHeader()
        End If

        If count >= 3 Then
            'if selected index less than total items -4 then insert selected hymn and 2 hymns after
            If index < count - 3 Then
                hymns = HymnsSelectionBox.Items(index) + vbCrLf + HymnsSelectionBox.Items(index + 1) + vbCrLf + HymnsSelectionBox.Items(index + 2)
            Else
                'insert last three hymns
                hymns = HymnsSelectionBox.Items(count - 3) + vbCrLf + HymnsSelectionBox.Items(count - 2) + vbCrLf + HymnsSelectionBox.Items(count - 1)
            End If
        Else
            'if there are two or less hymns
            hymns = String.Join(vbCrLf, HymnsSelectionBox.Items.Cast(Of String))
        End If
        'updating hymns on holy communion slide maximum of first three hymn
        If prevHighlightedPar = 1 Or highlightedParagraph = 1 Then
            'Issue of when changing text, powerpoint assumes formatting of first paragraph for all
            'if highlghted paragraph second paragraph reset styles of first paragraph then change text
            resetParagraph(textBox, 1)
        End If
        textBox.Text = hymns

        'changing highlighted paragraph, depending on selection
        'handling how selected index changes the highlighted pargarph
        If count >= 3 Then
            If HymnsSelectionBox.SelectedIndex = HymnsSelectionBox.Items.Count - 1 Then
                highlightedParagraph = 3
            ElseIf HymnsSelectionBox.SelectedIndex = HymnsSelectionBox.Items.Count - 2 Then
                highlightedParagraph = 2
            Else
                highlightedParagraph = 1
            End If
        Else
            highlightedParagraph = HymnsSelectionBox.SelectedIndex + 1
        End If
        highlightCurrentHymn(textBox)
        prevHighlightedPar = highlightedParagraph
    End Sub

    Private Sub reinsertHymns(hymns As String)
        'clear hymns from selection box
        HymnsSelectionBox.Items.Clear()
        'reinsert sermon hymns from previous
        Dim hymnsArr As String()
        hymnsArr = Split(hymns, vbNewLine)
        For Each hymn As String In hymnsArr
            If hymn IsNot "" Then
                HymnsSelectionBox.Items.Add(hymn)
            End If
        Next
    End Sub

    Private Sub highlightCurrentHymn(textBox As PowerPoint.TextRange)
        ''resetting fonts to highlight selected hymn
        If HymnsSelectionBox.Items.Count = 0 Then
            'if no hymns currently in list box do nothing
            Return
        End If
        If HymnsSelectionBox.Items.Count = 1 Then
            'if only one hymn, no need to reset style
            highlightParagraph(textBox, 1)
            Return
        End If
        'resetting styles of previous highlighted paragraph
        resetParagraph(textBox, prevHighlightedPar)
        'highlighting paragraph
        highlightParagraph(textBox, highlightedParagraph)
    End Sub
    Private Sub resetParagraph(textbox As PowerPoint.TextRange, paragraph As Integer)
        If paragraph <= textbox.Paragraphs.Count And textbox.Paragraphs(paragraph).Font.Bold Then
            textbox.Paragraphs(paragraph).Font.Color.TintAndShade = 0.1
            textbox.Paragraphs(paragraph).Font.Size = 40
            textbox.Paragraphs(paragraph).Font.Bold = Office.MsoTriState.msoFalse
        End If
    End Sub

    Private Sub highlightParagraph(textbox As PowerPoint.TextRange, paragraph As Integer)
        If paragraph <= textbox.Paragraphs.Count And textbox.Paragraphs(paragraph).Font.Bold <> Office.MsoTriState.msoTrue Then
            textbox.Paragraphs(paragraph).Font.Color.TintAndShade = 0
            textbox.Paragraphs(paragraph).Font.Size = 60
            textbox.Paragraphs(paragraph).Font.Bold = Office.MsoTriState.msoTrue
        End If
    End Sub
    Private Sub nextHymn_Click(sender As Object, e As EventArgs) Handles nextHymn.Click
        If HymnsSelectionBox.SelectedIndex = HymnsSelectionBox.Items.Count - 1 Then
            Return
        End If
        HymnsSelectionBox.SelectedIndex += 1
    End Sub

    Private Sub prevHymn_Click(sender As Object, e As EventArgs) Handles prevHymn.Click
        If HymnsSelectionBox.SelectedIndex = 0 Then
            Return
        End If
        HymnsSelectionBox.SelectedIndex -= 1
    End Sub
    Private Sub removeCurrentHymn(textBox As PowerPoint.TextRange)
        Dim selectedIndex As Integer = HymnsSelectionBox.SelectedIndex
        Dim size As Integer = HymnsSelectionBox.Items.Count
        If size = 0 Then
            'if there are new hymns to be removed return
            Return
        End If
        If size = 1 Then
            'only one hymn in selection box no need to find new selected hymn
            textBox.Delete()
            HymnsSelectionBox.Items.Clear()
            Return
        End If
        If selectedIndex = size - 1 Then
            'if hymn is last hymn selected, reselect last hymn
            textBox.Paragraphs(selectedIndex + 1).Delete()
            HymnsSelectionBox.Items.RemoveAt(selectedIndex)
            HymnsSelectionBox.SelectedIndex = size - 2
            Return
        End If
        'for all other cases, select the next hymn at the same index
        textBox.Paragraphs(selectedIndex + 1).Delete()
        HymnsSelectionBox.Items.RemoveAt(selectedIndex)
        HymnsSelectionBox.SelectedIndex = selectedIndex
    End Sub


    'handles deleting from button
    Private Sub delHymnBtn_Click(sender As Object, e As EventArgs) Handles delHymnBtn.Click
        removeCurrentHymn(hymnTextBox)
        updateHymns(hymnTextBox)
    End Sub

    'Handles deleting hymns from selection box
    Private Sub HymnsSelectionBox_KeyDown(sender As Object, e As KeyEventArgs) Handles HymnsSelectionBox.KeyDown
        If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete Then
            removeCurrentHymn(hymnTextBox)
            updateHymns(hymnTextBox)
        End If
    End Sub
    Private Sub HymnsSelectionBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles HymnsSelectionBox.SelectedIndexChanged
        If HymnsSelectionBox.SelectedIndex = -1 Then
            Return
        End If
        updateHymns(hymnTextBox)
    End Sub

    Private Sub HymnNos_KeyDown(sender As Object, e As KeyEventArgs) Handles HymnNos.KeyDown
        If e.KeyCode = Keys.Enter Then
            'user pressed enter to submit hymn
            If HymnNos.Text = vbNewLine Or HymnNos.Text = "" Then
                'user tried to enter empty line
                HymnNos.Text = ""
                Return
            End If
            HymnsSelectionBox.Items.Add(HymnNos.Text.Replace(vbNewLine, ""))
            HymnNos.Text = ""
            'if first hymn added, select hymn
            If HymnsSelectionBox.Items.Count.Equals(1) Then
                HymnsSelectionBox.SelectedIndex = 0
            End If
            'only update hymns if selected index one of last three hymns
            If HymnsSelectionBox.SelectedIndex >= HymnsSelectionBox.Items.Count - 3 Then
                updateHymns(hymnTextBox)
            End If
        End If
    End Sub

    Private Sub hideHymnHeader()
        textBoxDictionary.Item("hymnHeader").Text = " "
    End Sub

    Private Sub showHymnHeader()
        textBoxDictionary.Item("hymnHeader").Text = "HYMNS 詩"
    End Sub

    Private Sub EnglishFontBtn_Click(sender As Object, e As EventArgs) Handles EnglishFontBtn.Click
        ChangeFont(textBoxDictionary.Item("englishTitle1"))
    End Sub
    Private Sub EnglishColorBtn_Click(sender As Object, e As EventArgs) Handles EnglishColorBtn.Click
        ChangeColor(textBoxDictionary.Item("englishTitle1"))
    End Sub
    Private Sub ChineseFontBtn_Click(sender As Object, e As EventArgs) Handles ChineseFontBtn.Click
        ChangeFont(textBoxDictionary.Item("chineseTitle1"))
    End Sub
    Private Sub ChineseColorBtn_Click(sender As Object, e As EventArgs) Handles ChineseColorBtn.Click
        ChangeColor(textBoxDictionary.Item("chineseTitle1"))
    End Sub
    Private Sub ServiceTypeFontBtn_Click(sender As Object, e As EventArgs) Handles ServiceTypeFontBtn.Click
        ChangeFont(textBoxDictionary.Item("serviceType1"))
    End Sub
    Private Sub ServiceTypeColorBtn_Click(sender As Object, e As EventArgs) Handles ServiceTypeColorBtn.Click
        ChangeColor(textBoxDictionary.Item("serviceType1"))
    End Sub
    Private Sub HymnHDFont_Click(sender As Object, e As EventArgs) Handles HymnHDFont.Click
        ChangeFont(textBoxDictionary.Item("hymnHeader"))
    End Sub
    Private Sub HymnHDColor_Click(sender As Object, e As EventArgs) Handles HymnHDColor.Click
        ChangeColor(textBoxDictionary.Item("hymnHeader"))
    End Sub
    Private Sub HymnFontBtn_Click(sender As Object, e As EventArgs) Handles HymnFontBtn.Click
        ChangeFont(textBoxDictionary.Item("sermonHymns"))
    End Sub
    Private Sub HymnColorBtn_Click(sender As Object, e As EventArgs) Handles HymnColorBtn.Click
        ChangeColor(textBoxDictionary.Item("sermonHymns"))
    End Sub
    Private Sub BBibleHDFont_Click(sender As Object, e As EventArgs) Handles BibleHDFont.Click
        ChangeFont(textBoxDictionary.Item("bibleHeader"))
    End Sub

    Private Sub BibleHDColor_Click(sender As Object, e As EventArgs) Handles BibleHDColor.Click
        ChangeColor(textBoxDictionary.Item("bibleHeader"))
    End Sub
    Private Sub EnglishBookFontBtn_Click(sender As Object, e As EventArgs) Handles EnglishBookFontBtn.Click
        ChangeFont(textBoxDictionary.Item("englishBook"))
    End Sub
    Private Sub EnglishBookColorBtn_Click(sender As Object, e As EventArgs) Handles EnglishBookColorBtn.Click
        ChangeColor(textBoxDictionary.Item("englishBook"))
    End Sub
    Private Sub ChineseBookFontBtn_Click(sender As Object, e As EventArgs) Handles ChineseBookFontBtn.Click
        ChangeFont(textBoxDictionary.Item("chineseBook"))
    End Sub
    Private Sub ChineseBookColorBtn_Click(sender As Object, e As EventArgs) Handles ChineseBookColorBtn.Click
        ChangeColor(textBoxDictionary.Item("chineseBook"))
    End Sub
    Private Sub CVFontBtn_Click(sender As Object, e As EventArgs) Handles CVFontBtn.Click
        ChangeFont(textBoxDictionary.Item("chapterAndVerse"))
    End Sub
    Private Sub CVColorBtn_Click(sender As Object, e As EventArgs) Handles CVColorBtn.Click
        ChangeColor(textBoxDictionary.Item("chapterAndVerse"))
    End Sub
    Private Sub SlideTrack_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SlideTrack.SelectedIndexChanged
        Select Case SlideTrack.SelectedIndex
            Case 0 To 1
                'Break slide and main service slide
                ppPres.SlideShowWindow.View.GotoSlide(SlideTrack.SelectedIndex + 1)
            Case 2 To 8
                'Prayer Requests, announcements, holy communion,off devices,how to pray, service times
                ppPres.SlideShowWindow.View.GotoSlide(SlideTrack.SelectedIndex + 3)
        End Select
        If SlideTrack.SelectedIndex = 1 Then
            'enable show sermon hymns
            ShowSermonHymns.Checked = True
        End If
    End Sub

    Private Sub OpenPrayerRequestsWindow_Click(sender As Object, e As EventArgs) Handles OpenPrayerRequestsWindow.Click
        PrayerRequests.Show()
    End Sub

    Private Sub SaveSettings_Click(sender As Object, e As EventArgs) Handles SaveSettings.Click
        Dim CurrentSettings As String
        CurrentSettings =
        GetFontAndColor(2, 1) & vbCrLf &
        GetFontAndColor(2, 2) & vbCrLf &
        GetFontAndColor(2, 3) & vbCrLf &
        GetFontAndColor(2, 4) & vbCrLf &
        GetFontAndColor(2, 5) & vbCrLf &
        GetFontAndColor(3, 1) & vbCrLf &
        GetFontAndColor(3, 2) & vbCrLf &
        GetFontAndColor(3, 3) & vbCrLf &
        GetFontAndColor(3, 4) & vbCrLf &
        GetFontAndColor(3, 5) & vbCrLf &
        GetFontAndColor(3, 6) & vbCrLf &
        GetFontAndColor(3, 7) & vbCrLf &
        GetFontAndColor(5, 1) & vbCrLf &
        GetFontAndColor(5, 2) & vbCrLf &
        GetFontAndColor(6, 1) & vbCrLf &
        GetFontAndColor(6, 2) & vbCrLf &
        GetFontAndColor(7, 2)
        Try
            My.Computer.FileSystem.WriteAllText(CurrentDirectory + "\Files\Settings.ini", CurrentSettings, False)
            MessageBox.Show("Save Successful", "Save Successful")
        Catch ex As Exception
            MessageBox.Show("Save Unsuccessful", "Save Unsuccessful")
        End Try
    End Sub

    Private Sub OpenFolder_Click(sender As Object, e As EventArgs) Handles OpenFolder.Click
        openFilesFolder()
    End Sub
    Public Sub openFilesFolder()
        Process.Start(CurrentDirectory + "\Files")
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If SlideTrack.SelectedIndex = 0 Then
            'update time on break slide
            ppPres.Slides(1).Shapes(1).TextFrame.TextRange.Text = DateTime.Now.ToString("HH:mm:ss")
        End If
    End Sub

    Private Sub Titles_KeyDown(sender As Object, e As KeyEventArgs) Handles EnglishTitle.KeyDown, ChineseTitle.KeyDown
        If e.KeyCode = Keys.Enter Then
            UpdateTitle_Click(sender, e)
        End If
    End Sub

    Private Sub Verse_KeyDown(sender As Object, e As KeyEventArgs) Handles VerseTxt.KeyDown
        'handling both when chapter and verse enter key pressed
        If e.KeyCode = Keys.Enter Then
            Call UpdateVerse_Click(sender, e)
            If VerseTxt.Text IsNot "" Then
                SelectNextControl(sender, True, True, True, True)
            End If
        End If
    End Sub
    Private Sub Chapter_KeyDown(sender As Object, e As KeyEventArgs) Handles ChapterTxt.KeyDown
        'handling both when chapter and verse enter key pressed
        If e.KeyCode = Keys.Enter Then
            If ChapterTxt.Text IsNot "" Then
                SelectNextControl(sender, True, True, True, True)
            End If
        End If
    End Sub

    Private Sub ServiceType_KeyDown(sender As Object, e As KeyEventArgs) Handles ServiceType.KeyDown
        If e.KeyCode = Keys.Enter Then
            textBoxDictionary.Item("serviceType1").Text = ServiceType.Text
            textBoxDictionary.Item("serviceType2").Text = ServiceType.Text
        End If
    End Sub

    Private Sub BookBox_KeyDown(sender As Object, e As KeyEventArgs) Handles BookBox.KeyDown
        ' handles when book box is empty, assumes that no verse or chapter should be shown
        If BookBox.Text Is "" And e.KeyCode = Keys.Enter Then
            textBoxDictionary.Item("englishBook").Text = " "
            textBoxDictionary.Item("chineseBook").Text = " "
            textBoxDictionary.Item("chapterAndVerse").Text = " "
            VerseTxt.Text = ""
            ChapterTxt.Text = ""
        ElseIf e.KeyCode = Keys.Enter Then
            If BookBox.SelectedIndex Then
                SelectNextControl(sender, True, True, True, True)
            End If
        End If
    End Sub

    Private Sub Show_AN_Click(sender As Object, e As EventArgs) Handles Show_AN.Click
        Announcements.Show()

    End Sub

    Private Sub edtPrayerImg_Click(sender As Object, e As EventArgs) Handles edtPrayerImg.Click
        insertPrayerImage()
    End Sub

    'Inserting prayer requests as an image, and inserting into powerpoint slide
    Public Sub insertPrayerImage()
        Try
            Dim ofd = New OpenFileDialog()
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Downloads"
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"
            If ofd.ShowDialog = DialogResult.OK Then
                deletePrayerImage()
                ppPres.Slides(5).Shapes.AddPicture(ofd.FileName, False, True, 0, 0, ppPres.PageSetup.SlideWidth, ppPres.PageSetup.SlideHeight)
                System.IO.File.WriteAllText(CurrentDirectory + "\Files\prayerImgDir.txt", ofd.FileName)
                MessageBox.Show("Prayer Image Was Successfully Updated", "Success")
            Else
                MessageBox.Show("Prayer Image Was Not Successfully Updated. Please Try Again", "Error")
            End If
        Catch ex As Exception
            MessageBox.Show("Prayer Image Was Not Successfully Updated. Please Try Again", "Error")
        End Try
    End Sub

    'removing prayer image if exists on slide
    Public Sub deletePrayerImage()
        If slideDictionary.Item("prayerRequests").Shapes.Count >= 6 Then
            slideDictionary.Item("prayerRequests").Shapes(6).Delete()
            System.IO.File.WriteAllText(CurrentDirectory + "\Files\prayerImgDir.txt", "")
        End If
    End Sub

    Private Sub edtHC_Click(sender As Object, e As EventArgs) Handles edtHC.Click
        HolyCommunion.Show()
    End Sub

    Private Sub clearbtn_Click(sender As Object, e As EventArgs) Handles clearbtn.Click
        ResetServiceDetails()
    End Sub

    'Inserting service times as an image, and inserting into powerpoint slide
    Private Sub ServiceTimesBtn_Click(sender As Object, e As EventArgs) Handles ServiceTimesBtn.Click
        Try
            Dim ofd = New OpenFileDialog()
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Downloads"
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"
            If ofd.ShowDialog = DialogResult.OK Then
                slideDictionary.Item("serviceTimes").Shapes.AddPicture(ofd.FileName, False, True, 0, 0, ppPres.PageSetup.SlideWidth, ppPres.PageSetup.SlideHeight)
                System.IO.File.WriteAllText(CurrentDirectory + "\Files\timetableDir.txt", ofd.FileName)
                MessageBox.Show("Service Timetable Was Successfully Updated", "Success")
            Else
                MessageBox.Show("Service Timetable Was Not Successfully Updated. Please Try Again", "Error")
            End If
        Catch ex As Exception
            MessageBox.Show("Service Timetable Was Not Successfully Updated. Please Try Again", "Error")
        End Try
    End Sub


    'Following 5 methods deal with moving the chinese and english title up or down to create more/less spacing
    'Needed when English title takes two or more lines
    Private Sub moveUp(textBox As PowerPoint.Shape)
        If textBox.Top >= 10 Then
            textBox.Top = textBox.Top - 10
        End If
    End Sub

    Private Sub moveDown(textBox As PowerPoint.Shape)
        If textBox.Top <= 200 Then
            textBox.Top = textBox.Top + 10
        End If
    End Sub

    Private Sub moveEnglishDown_Click(sender As Object, e As EventArgs) Handles moveEnglishDown.Click
        If ShowSermonHymns.Checked Then
            moveDown(slideDictionary.Item("sermonHymnsSlide").Shapes(1))
        ElseIf ShowVerses.Checked Then
            moveDown(slideDictionary.Item("bibleVersesSlide").Shapes(1))
        End If
    End Sub

    Private Sub moveEnglishUp_Click(sender As Object, e As EventArgs) Handles moveEnglishUp.Click
        If ShowSermonHymns.Checked Then
            moveUp(slideDictionary.Item("sermonHymnsSlide").Shapes(1))
        ElseIf ShowVerses.Checked Then
            moveUp(slideDictionary.Item("bibleVersesSlide").Shapes(1))
        End If
    End Sub
    Private Sub moveChineseUp_Click(sender As Object, e As EventArgs) Handles moveChineseUp.Click
        If ShowSermonHymns.Checked Then
            moveUp(slideDictionary.Item("sermonHymnsSlide").Shapes(2))
        ElseIf ShowVerses.Checked Then
            moveUp(slideDictionary.Item("bibleVersesSlide").Shapes(2))
        End If
    End Sub
    Private Sub moveChineseDown_Click(sender As Object, e As EventArgs) Handles moveChineseDown.Click
        If ShowSermonHymns.Checked Then
            moveDown(slideDictionary.Item("sermonHymnsSlide").Shapes(2))
        ElseIf ShowVerses.Checked Then
            moveDown(slideDictionary.Item("bibleVersesSlide").Shapes(2))
        End If
    End Sub


    'NAVIGATION BAR
    'Methods dealing with when the close/minimise button are pressed
    Private Sub minForm_Click(sender As Object, e As EventArgs) Handles minForm.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'Following methods deal with the movement of the form
    'If the user drags the mouse on the top navigation bar or the tjc logo,
    'the form will drag to where the user has dragged their moue to
    'Copied from the following stack over
    'https://stackoverflow.com/questions/17392088/allow-a-user-to-move-a-borderless-window
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles topNavBar.MouseDown, TJCLogo.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles topNavBar.MouseUp, TJCLogo.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles topNavBar.MouseMove, TJCLogo.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub


    'Following Code below will enable the windows form to have shadow and similar effects to a windows 7 application
    'Taken from stack overflow post in the following link:
    'https://stackoverflow.com/questions/16493698/drop-shadow-on-a-borderless-winform#:~:text=1)%20Create%20an%20image%20having,4)%20You%20are%20done!
    Private aeroEnabled As Boolean
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            CheckAeroEnabled()
            Dim cp As CreateParams = MyBase.CreateParams
            If Not aeroEnabled Then
                cp.ClassStyle = NativeConstants.CS_DROPSHADOW
                Return cp
            Else
                Return cp
            End If
        End Get
    End Property
    Protected Overrides Sub WndProc(ByRef m As Message)
        Select Case m.Msg
            Case NativeConstants.WM_NCPAINT
                Dim val = 2
                If aeroEnabled Then
                    NativeMethods.DwmSetWindowAttribute(Handle, 2, val, 4)
                    Dim bla As New NativeStructs.MARGINS()
                    With bla
                        .bottomHeight = 1
                        .leftWidth = 1
                        .rightWidth = 1
                        .topHeight = 1
                    End With
                    NativeMethods.DwmExtendFrameIntoClientArea(Handle, bla)
                End If
                Exit Select
        End Select
        MyBase.WndProc(m)
    End Sub
    Private Sub CheckAeroEnabled()
        'assume that OS is above windows 6
        Dim enabled As Integer = 0
        Dim response As Integer = NativeMethods.DwmIsCompositionEnabled(enabled)
        aeroEnabled = (enabled = 1)
    End Sub


End Class

Public Class NativeStructs
    Public Structure MARGINS
        Public leftWidth As Integer
        Public rightWidth As Integer
        Public topHeight As Integer
        Public bottomHeight As Integer
    End Structure
End Class
Public Class NativeMethods
    <DllImport("dwmapi")>
    Public Shared Function DwmExtendFrameIntoClientArea(ByVal hWnd As IntPtr, ByRef pMarInset As NativeStructs.MARGINS) As Integer
    End Function
    <DllImport("dwmapi")>
    Friend Shared Function DwmSetWindowAttribute(ByVal hwnd As IntPtr, ByVal attr As Integer, ByRef attrValue As Integer, ByVal attrSize As Integer) As Integer
    End Function
    <DllImport("dwmapi.dll")>
    Public Shared Function DwmIsCompositionEnabled(ByRef pfEnabled As Integer) As Integer
    End Function
End Class
Public Class NativeConstants
    Public Const CS_DROPSHADOW As Integer = &H20000
    Public Const WM_NCPAINT As Integer = &H85
End Class


