Imports Office = Microsoft.Office.Core
Imports PowerPoint = Microsoft.Office.Interop.PowerPoint
Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Xml
Imports System.Drawing.Text
'This class is part of the TJC PowerPoint project.
'The TJC PowerPoint is a simple program displaying bible verses, hymns
'to a projector using Microsoft PowerPoint.
'It also has other purporses to help display usesful information to the projector
'These include:
'How to pray, service times, current time and date, holy communion slides, prayer requests
'announcements, hymnal hymns etc.
'
'Initially developed by Joshi Chan (TJC Lecieseter), from V2 onwards developed by Caleb Chan (TJC London)
'© Copyright 2023 True Jesus Church London 


Public Class MainProgram
    Private ppApp As New PowerPoint.Application
    Private ppPres As PowerPoint.Presentation
    Private CurrentDirectory As String = Directory.GetCurrentDirectory()
    Private Writer As XmlTextWriter = Nothing
    Private RecentFile As String

    'keep track of sermon hymns and hymnal hymns
    Private sermonHymns As HymnSelector
    Private hymnalHymns As HymnSelector

    'keeping track of which paragraph was last highlighted
    Private prevSermonHymnsHighlightedPar As Integer
    Private prevHymnalHymnsHighlightedPar As Integer

    'Use of a dictionary to easily change slide numbers and shape numbers
    Private slideDictionary As Dictionary(Of String, PowerPoint.Slide)
    Private textBoxDictionary As Dictionary(Of String, PowerPoint.TextRange)

    Private prayerRequestsWindow As BaseSlideEdit
    Private announcementsWindow As BaseSlideEdit
    Private serviceTimesWindow As BaseSlideEdit

    'CONSTSRUCTOR
    Public Sub New()
        'Method dealing with what the form will do when it initially opens
        InitializeComponent()
    End Sub

    'MAIN LOADER
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadingScreen.Show()
            LoadingScreen.Activate()
            MakeFolder()
            LoadPres()
            HandleAnnouncements()
            HandleServiceTimes()
            HandlePrayerRequests()
            LoadHC()

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


    'GETTERS AND SETTERS'
    Public Function getCurrentDirectory()
        Return CurrentDirectory
    End Function

    Public Function getTextBox(textBox As String)
        Return textBoxDictionary.Item(textBox)
    End Function

    Public Function getSlide(slideName As String)
        Return slideDictionary.Item(slideName)
    End Function

    Public Function getTextFile(fileName As String)
        If My.Computer.FileSystem.FileExists(CurrentDirectory + "\Files\" + fileName) Then
            Dim text As String
            text = My.Computer.FileSystem.ReadAllText(CurrentDirectory + "\Files\" + fileName, System.Text.Encoding.UTF8)
            Console.Write(text)
            Return text
        Else
            Using sw As StreamWriter = File.CreateText(CurrentDirectory + "\Files\" + fileName)
                sw.WriteLine(" ")
            End Using
            Return ""
        End If
    End Function


    'Method called to create a folder for the files and resources
    Private Sub MakeFolder()
        If Directory.Exists("\Files") = False Then
            My.Computer.FileSystem.CreateDirectory(CurrentDirectory + "\Files")
        End If
        If My.Computer.FileSystem.FileExists(CurrentDirectory + "\Files\ServiceWidescreen.pptx") = False Then
            System.IO.File.WriteAllBytes(CurrentDirectory + "\Files\ServiceWidescreen.pptx", My.Resources.ServiceWidescreen)
        End If
        DownloadFonts()
    End Sub

    Private Sub DownloadFonts()
        Dim pfc As New PrivateFontCollection()
        If Directory.Exists("\File\Fonts") = False Then
            My.Computer.FileSystem.CreateDirectory(CurrentDirectory + "\Files\Fonts")
            System.IO.File.WriteAllBytes(CurrentDirectory + "\Files\Fonts\SourceSansPro-Bold.ttf", My.Resources.SourceSansPro_Bold)
            System.IO.File.WriteAllBytes(CurrentDirectory + "\Files\Fonts\SourceSansPro-BoldItalic.ttf", My.Resources.SourceSansPro_BoldItalic)
            System.IO.File.WriteAllBytes(CurrentDirectory + "\Files\Fonts\SourceSansPro-ExtraLight.ttf", My.Resources.SourceSansPro_ExtraLight)
            System.IO.File.WriteAllBytes(CurrentDirectory + "\Files\Fonts\SourceSansPro-ExtraLightItalic.ttf", My.Resources.SourceSansPro_ExtraLightItalic)
            System.IO.File.WriteAllBytes(CurrentDirectory + "\Files\Fonts\SourceSansPro-Italic.ttf", My.Resources.SourceSansPro_Italic)
            System.IO.File.WriteAllBytes(CurrentDirectory + "\Files\Fonts\SourceSansPro-Light.ttf", My.Resources.SourceSansPro_Light)
            System.IO.File.WriteAllBytes(CurrentDirectory + "\Files\Fonts\SourceSansPro-LightItalic.ttf", My.Resources.SourceSansPro_LightItalic)
            System.IO.File.WriteAllBytes(CurrentDirectory + "\Files\Fonts\SourceSansPro-Regular.ttf", My.Resources.SourceSansPro_Regular)
            System.IO.File.WriteAllBytes(CurrentDirectory + "\Files\Fonts\SourceSansPro-SemiBold.ttf", My.Resources.SourceSansPro_SemiBold)
            System.IO.File.WriteAllBytes(CurrentDirectory + "\Files\Fonts\SourceSansPro-SemiBoldItalic.ttf", My.Resources.SourceSansPro_SemiBoldItalic)
        End If
    End Sub


    'Method to load up the presentation and instantiate slide text boxes
    Private Sub LoadPres()
        ppApp = CreateObject("PowerPoint.Application")
        ppPres = ppApp.Presentations.Open(CurrentDirectory + "\Files\ServiceWidescreen.pptx", [ReadOnly]:=Office.MsoTriState.msoFalse, WithWindow:=Office.MsoTriState.msoFalse)
        ppPres.SlideShowSettings.ShowPresenterView = False
        ppPres.PageSetup.FirstSlideNumber = 1
        ppPres.SlideShowSettings.Run()
        Dim dict As DictionairyFactory = New DictionairyFactory(ppPres)
        slideDictionary = dict.getSlideDictionairy()
        textBoxDictionary = dict.getTextBoxDictionairy()

        ResetServiceDetails()
        'by default go to break slide and hymntextbox set to service hymns
        goToBreakBtn.Checked = True
    End Sub

    Public Sub goToSlide(num As Integer)
        ppPres.SlideShowWindow.View.GotoSlide(num)
    End Sub

    'Method that will reset the program to the initial running state
    Private Sub ResetServiceDetails()
        sermonHymnNo.Text = "Enter Hymn"
        hymnalHymnNo.Text = "Enter Hymn"
        sermonHymnsListBox.Items.Clear()
        hymnalHymnsListBox.Items.Clear()
        ServiceType.Text = ""
        BookBox.Text = ""
        VerseTxt.Text = ""
        ChapterTxt.Text = ""
        EnglishTitle.Text = "English Sermon Title"
        ChineseTitle.Text = "中文講道題目"
        'title slide
        textBoxDictionary.Item("englishTitle").Text = " "
        textBoxDictionary.Item("chineseTitle").Text = " "
        textBoxDictionary.Item("serviceType").Text = " "
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
        textBoxDictionary.Item("serviceType3").Text = " "
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

    Public Sub HandleAnnouncements()
        Dim announcementsTxt As String = getTextFile("Announcements.txt")
        textBoxDictionary.Item("AnnouncementsTxt").Text = announcementsTxt
        announcementsWindow = New BaseSlideEdit("Announcements", slideDictionary.Item("announcements"))
        announcementsWindow.setInput(announcementsTxt)
        announcementsWindow.setBodyTB(textBoxDictionary.Item("AnnouncementsTxt"))
        announcementsWindow.setTitleTB(textBoxDictionary.Item("AnnouncementsTitle"))
        announcementsWindow.loadImage(getTextFile("AnnouncementsDir.txt"))
    End Sub

    Public Sub HandleServiceTimes()
        Dim serviceTxt As String = getTextFile("ServiceTimes.txt")
        textBoxDictionary.Item("ServiceTimesTxt").Text = serviceTxt
        serviceTimesWindow = New BaseSlideEdit("Service Times", slideDictionary.Item("serviceTimes"))
        serviceTimesWindow.setInput(serviceTxt)
        serviceTimesWindow.setBodyTB(textBoxDictionary.Item("ServiceTimesTxt"))
        serviceTimesWindow.setTitleTB(textBoxDictionary.Item("ServiceTimesTitle"))
        serviceTimesWindow.loadImage(getTextFile("ServiceTimesDir.txt"))
    End Sub

    Public Sub HandlePrayerRequests()
        Dim prayerRequestsTxt As String = getTextFile("PrayerRequests.txt")
        textBoxDictionary.Item("PrayerRequestsTxt").Text = prayerRequestsTxt
        prayerRequestsWindow = New BaseSlideEdit("Prayer Requests", slideDictionary.Item("prayerRequests"))
        prayerRequestsWindow.setInput(prayerRequestsTxt)
        prayerRequestsWindow.setBodyTB(textBoxDictionary.Item("PrayerRequestsTxt"))
        prayerRequestsWindow.setTitleTB(textBoxDictionary.Item("PrayerRequestsTitle"))
        prayerRequestsWindow.loadImage(getTextFile("PrayerRequestsDir.txt"))
    End Sub
    Public Sub ChangeFont(textBox As PowerPoint.TextRange)
        If textBox.Font.Name IsNot Nothing Then
            FontDialog.Font = New Font(textBox.Font.Name, textBox.Font.Size)
            If textBox.Font.Bold Then
                FontDialog.Font = New Font(textBox.Font.Name, textBox.Font.Size, FontStyle.Bold)
            End If
        End If
        If FontDialog.ShowDialog = DialogResult.OK Then
            'Handle cases for where text boxes are same but on separate slides
            setFontOfTextbox(textBox)
        End If
    End Sub
    Private Sub setFontOfTextbox(textBox As PowerPoint.TextRange)
        textBox.Font.Name = FontDialog.Font.Name
        textBox.Font.Size = FontDialog.Font.Size
        textBox.Font.Bold = FontDialog.Font.Bold
    End Sub
    Public Sub ChangeColor(textBox As PowerPoint.TextRange)
        If ColorDialog.ShowDialog = DialogResult.OK Then
            Dim Red As Integer = Convert.ToInt32(ColorDialog.Color.R)
            Dim Green As Integer = Convert.ToInt32(ColorDialog.Color.G)
            Dim Blue As Integer = Convert.ToInt32(ColorDialog.Color.B)
            Dim acolor = Color.FromArgb(255, Blue, Green, Red).ToArgb
            Select Case True
                Case textBox.Text.Equals(textBoxDictionary.Item("englishTitle1").Text)
                    textBoxDictionary.Item("englishTitle").Font.Color.RGB = acolor
                    textBoxDictionary.Item("englishTitle1").Font.Color.RGB = acolor
                    textBoxDictionary.Item("englishTitle2").Font.Color.RGB = acolor
                    Return
                Case textBox.Text.Equals(textBoxDictionary.Item("chineseTitle1").Text)
                    textBoxDictionary.Item("chineseTitle").Font.Color.RGB = acolor
                    textBoxDictionary.Item("chineseTitle1").Font.Color.RGB = acolor
                    textBoxDictionary.Item("chineseTitle2").Font.Color.RGB = acolor
                    Return
                Case textBox.Text.Equals(textBoxDictionary.Item("serviceType1").Text)
                    textBoxDictionary.Item("serviceType").Font.Color.RGB = acolor
                    textBoxDictionary.Item("serviceType1").Font.Color.RGB = acolor
                    textBoxDictionary.Item("serviceType2").Font.Color.RGB = acolor
                    textBoxDictionary.Item("serviceType3").Font.Color.RGB = acolor
                    Return
            End Select
            textBox.Font.Color.RGB = acolor
        End If
    End Sub

    'Method dealing when the exit button is clicked
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles closeForm.Click
        Me.Close()
    End Sub

    Private Sub ShowSermonHymns_CheckedChanged(sender As Object, e As EventArgs) Handles ShowSermonHymns.CheckedChanged
        ShowSermonHymns.TabStop = False
    End Sub
    Private Sub ShowVerses_CheckedChanged(sender As Object, e As EventArgs) Handles ShowVerses.CheckedChanged
        ShowVerses.TabStop = False
        If ShowVerses.Checked Then
            Call UpdateVerse_Click(sender, e)
        Else
            'clearing bible verses
            textBoxDictionary.Item("englishBook").Text = " "
            textBoxDictionary.Item("chineseBook").Text = " "
            textBoxDictionary.Item("chapterAndVerse").Text = " "
            'when show verses is unchecked
            BookBox.Text = ""
            VerseTxt.Text = ""
            ChapterTxt.Text = ""
        End If
    End Sub
    Private Sub ShowHymnal_CheckedChanged(sender As Object, e As EventArgs) Handles ShowHymnal.CheckedChanged
        ShowHymnal.TabStop = False
        If ShowHymnal.Checked Then
            ppPres.SlideShowWindow.View.GotoSlide(slideDictionary.Item("hymnalHymnsSlide").SlideIndex)
        End If
    End Sub

    'On click methods
    Private Sub ShowSermonHymns_Click(sender As Object, e As EventArgs) Handles ShowSermonHymns.Click
        If ShowSermonHymns.Checked And sermonHymnsListBox.Items.Count = 0 Then
            showTitlesOnly()
        ElseIf ShowSermonHymns.Checked And ppPres.SlideShowWindow.View.Slide.SlideIndex <> slideDictionary.Item("sermonHymnsSlide").SlideIndex Then
            ppPres.SlideShowWindow.View.GotoSlide(slideDictionary.Item("sermonHymnsSlide").SlideIndex)
        End If
    End Sub

    Private Sub ShowHymnal_Click(sender As Object, e As EventArgs) Handles ShowHymnal.Click
        If ShowHymnal.Checked And ppPres.SlideShowWindow.View.Slide.SlideIndex <> slideDictionary.Item("hymnalHymnsSlide").SlideIndex Then
            ppPres.SlideShowWindow.View.GotoSlide(slideDictionary.Item("hymnalHymnsSlide").SlideIndex)
        End If
    End Sub

    Private Sub ShowVerses_Click(sender As Object, e As EventArgs) Handles ShowVerses.Click
        If ShowVerses.Checked And BookBox.Text = "" Then
            showTitlesOnly()
        ElseIf ShowVerses.Checked And ppPres.SlideShowWindow.View.Slide.SlideIndex <> slideDictionary.Item("bibleVersesSlide").SlideIndex Then
            ppPres.SlideShowWindow.View.GotoSlide(slideDictionary.Item("bibleVersesSlide").SlideIndex)
        End If
    End Sub

    Private Sub UpdateVerse_Click(sender As Object, e As EventArgs) Handles UpdateVerse.Click
        If VerseTxt.Text.Equals("") And BookBox.Text.Equals("") And ChapterTxt.Text.Equals("") Then
            textBoxDictionary.Item("chapterAndVerse").Text = " "
        ElseIf BookBox.Text = "" Or BookBox.SelectedIndex = -1 Then
            showTitlesOnly()
        Else
            'if selected proper book update text boxes
            Dim commaPos As Integer
            commaPos = InStr(BookBox.Text, ",")
            textBoxDictionary.Item("englishBook").Text = Mid(BookBox.Text, 1, commaPos - 1)
            textBoxDictionary.Item("chineseBook").Text = Mid(BookBox.Text, commaPos + 1)
            textBoxDictionary.Item("chapterAndVerse").Text = ChapterTxt.Text + " : " + VerseTxt.Text
            ppPres.SlideShowWindow.View.GotoSlide(slideDictionary.Item("bibleVersesSlide").SlideIndex)
            'if called when show hymns is checked
            'automatically change to show verses
            If ShowVerses.Checked = False Then
                ShowVerses.Checked = True
            End If
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
        'update on title slide
        textBoxDictionary.Item("englishTitle").Text = EnglishTitle.Text
        textBoxDictionary.Item("chineseTitle").Text = ChineseTitle.Text
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
        'update service types
        updateServiceTypes()
    End Sub



    '-------------------------------------------HYMN SELECTION --------------------------------------------
    Private Sub updateHymns(textBox As PowerPoint.TextRange, listBox As ListBox)
        Dim hymns As String = ""
        Dim count = listBox.Items.Count
        Dim index = listBox.SelectedIndex
        Dim highlightedParagraph = -1
        Dim prevHighlightedPar = -1
        If hymnTabControl.SelectedIndex = 0 Then
            'has seleted sermon hymns
            prevHighlightedPar = prevSermonHymnsHighlightedPar
        ElseIf hymnTabControl.SelectedIndex = 1 Then
            prevHighlightedPar = prevHymnalHymnsHighlightedPar
        End If
        'ensure that proper slide is selected from showing hymns
        If ShowSermonHymns.Checked Then
            ShowSermonHymns.PerformClick()
        End If
        If count = 0 Then
            textBox.Text = " "
            Return
        End If
        If count >= 3 Then
            'if selected index less than total items -4 then insert selected hymn and 2 hymns after
            If index < count - 3 Then
                hymns = listBox.Items(index) + vbCr + listBox.Items(index + 1) + vbCr + listBox.Items(index + 2)
            Else
                'insert last three hymns
                hymns = listBox.Items(count - 3) + vbCr + listBox.Items(count - 2) + vbCr + listBox.Items(count - 1)
            End If
        Else
            'if there are two or less hymns
            hymns = String.Join(vbCr, listBox.Items.Cast(Of String))
        End If
        'changing highlighted paragraph, depending on selection
        'handling how selected index changes the highlighted pargarph
        If count >= 3 Then
            If listBox.SelectedIndex = listBox.Items.Count - 1 Then
                highlightedParagraph = 3
            ElseIf listBox.SelectedIndex = listBox.Items.Count - 2 Then
                highlightedParagraph = 2
            Else
                highlightedParagraph = 1
            End If
        Else
            highlightedParagraph = listBox.SelectedIndex + 1
        End If
        'return if no change in hymns and highlighted paragraph
        If textBox.Text.ToString().Equals(hymns) And prevHighlightedPar = highlightedParagraph Then
            Return
        End If
        If prevHighlightedPar = 1 Or highlightedParagraph = 1 Then
            'Issue of when changing text, powerpoint assumes formatting of first paragraph for all
            'if highlghted paragraph second paragraph reset styles of first paragraph then change text
            resetParagraph(textBox, 1)
        End If
        textBox.Text = hymns
        highlightCurrentHymn(textBox, listBox, highlightedParagraph, prevHighlightedPar)
        If hymnTabControl.SelectedIndex = 0 Then
            'has seleted sermon hymns
            prevSermonHymnsHighlightedPar = highlightedParagraph
        ElseIf hymnTabControl.SelectedIndex = 1 Then
            prevHymnalHymnsHighlightedPar = highlightedParagraph
        End If
    End Sub

    Private Sub highlightCurrentHymn(textBox As PowerPoint.TextRange, listBox As ListBox, highlightedParagraph As Integer, prevHighlighted As Integer)
        ''resetting fonts to highlight selected hymn
        If listBox.Items.Count = 0 Then
            'if no hymns currently in list box do nothing
            Return
        End If
        If listBox.Items.Count = 1 Then
            'if only one hymn, no need to reset style
            highlightParagraph(textBox, 1)
            Return
        End If
        'resetting styles of previous highlighted paragraph
        resetParagraph(textBox, prevHighlighted)
        'highlighting paragraph
        highlightParagraph(textBox, highlightedParagraph)
    End Sub
    Private Sub resetParagraph(textbox As PowerPoint.TextRange, paragraph As Integer)
        If paragraph <= textbox.Paragraphs.Count And textbox.Paragraphs(paragraph).Font.Bold = Office.MsoTriState.msoTrue Then
            textbox.Paragraphs(paragraph).Font.Color.TintAndShade = 0.05
            textbox.Paragraphs(paragraph).Font.Size = 50
            textbox.Paragraphs(paragraph).Font.Bold = Office.MsoTriState.msoFalse
        End If
    End Sub

    Private Sub highlightParagraph(textbox As PowerPoint.TextRange, paragraph As Integer)
        If paragraph <= textbox.Paragraphs.Count And textbox.Paragraphs(paragraph).Font.Bold <> Office.MsoTriState.msoTrue Then
            textbox.Paragraphs(paragraph).Font.Color.TintAndShade = 0
            textbox.Paragraphs(paragraph).Font.Size = 75
            textbox.Paragraphs(paragraph).Font.Bold = Office.MsoTriState.msoTrue
        End If
    End Sub
    Private Sub nextHymn_Click(sender As Object, e As EventArgs) Handles nextHymn.Click
        If sermonHymnsListBox.SelectedIndex = sermonHymnsListBox.Items.Count - 1 Then
            Return
        End If
        sermonHymnsListBox.SelectedIndex += 1
    End Sub
    Private Sub hymnalNextHymn_Click(sender As Object, e As EventArgs) Handles hymnalNextHymn.Click
        If hymnalHymnsListBox.SelectedIndex = hymnalHymnsListBox.Items.Count - 1 Then
            Return
        End If
        hymnalHymnsListBox.SelectedIndex += 1
    End Sub

    Private Sub prevHymn_Click(sender As Object, e As EventArgs) Handles prevHymn.Click
        If sermonHymnsListBox.SelectedIndex = 0 Or sermonHymnsListBox.SelectedIndex = -1 Then
            Return
        End If
        sermonHymnsListBox.SelectedIndex -= 1
    End Sub
    Private Sub hymnalPrevHymn_Click(sender As Object, e As EventArgs) Handles hymnalPrevHymn.Click
        If hymnalHymnsListBox.SelectedIndex = 0 Or hymnalHymnsListBox.SelectedIndex = -1 Then
            Return
        End If
        hymnalHymnsListBox.SelectedIndex -= 1
    End Sub
    Private Sub removeCurrentHymn(textBox As PowerPoint.TextRange, listBox As ListBox)
        Dim selectedIndex As Integer = listBox.SelectedIndex
        Dim size As Integer = listBox.Items.Count
        If size = 0 Then
            'if there are new hymns to be removed return
            If ShowSermonHymns.Checked Then
                showTitlesOnly()
            End If
            Return
        End If
        If size = 1 Then
            'only one hymn in selection box no need to find new selected hymn
            textBox.Text = " "
            listBox.Items.Clear()
            Return
        End If
        If selectedIndex = size - 1 Then
            'if hymn is last hymn selected, reselect last hymn
            listBox.Items.RemoveAt(selectedIndex)
            listBox.SelectedIndex = size - 2
            Return
        End If
        'for all other cases, select the next hymn at the same index
        listBox.Items.RemoveAt(selectedIndex)
        listBox.SelectedIndex = selectedIndex
    End Sub
    Private Sub clearSermonHymnsBtn_Click(sender As Object, e As EventArgs) Handles clearSermonHymnsBtn.Click
        sermonHymnsListBox.Items.Clear()
        updateHymns(textBoxDictionary.Item("sermonHymns"), sermonHymnsListBox)
    End Sub
    Private Sub clearHymnalHymnsBtn_Click(sender As Object, e As EventArgs) Handles clearHymnalHymns.Click
        hymnalHymnsListBox.Items.Clear()
        updateHymns(textBoxDictionary.Item("hymnalHymns"), hymnalHymnsListBox)
    End Sub

    'handles deleting from button (sermon hymn)
    Private Sub delHymnBtn_Click(sender As Object, e As EventArgs) Handles delHymnBtn.Click
        removeCurrentHymn(textBoxDictionary.Item("sermonHymns"), sermonHymnsListBox)
        If sermonHymnsListBox.Items.Count = 0 And Not ShowHymnal.Checked Then
            showTitlesOnly()
        End If
    End Sub
    'handles deleting from button (hymnal hymn)
    Private Sub delHymnalHymnBtn_Click(sender As Object, e As EventArgs) Handles hymnalDelHymn.Click
        removeCurrentHymn(textBoxDictionary.Item("hymnalHymns"), hymnalHymnsListBox)
    End Sub

    'Handles deleting hymns from selection box
    Private Sub HymnsSelectionBox_KeyDown(sender As Object, e As KeyEventArgs) Handles sermonHymnsListBox.KeyDown
        If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete Then
            removeCurrentHymn(textBoxDictionary.Item("sermonHymns"), sermonHymnsListBox)
            If sermonHymnsListBox.Items.Count = 0 And Not ShowHymnal.Checked Then
                showTitlesOnly()
            End If
        End If
    End Sub
    Private Sub hymnalHymnsListBox_KeyDown(sender As Object, e As KeyEventArgs) Handles hymnalHymnsListBox.KeyDown
        If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete Then
            removeCurrentHymn(textBoxDictionary.Item("hymnalHymns"), hymnalHymnsListBox)
        End If
    End Sub
    Private Sub sermonHymnsListBox_IndexChanged(sender As Object, e As EventArgs) Handles sermonHymnsListBox.SelectedIndexChanged
        If sermonHymnsListBox.SelectedIndex = -1 Then
            Return
        End If
        updateHymns(textBoxDictionary.Item("sermonHymns"), sermonHymnsListBox)
    End Sub
    Private Sub hymnalHymnListBox_IndexChanged(sender As Object, e As EventArgs) Handles hymnalHymnsListBox.SelectedIndexChanged
        If hymnalHymnsListBox.SelectedIndex = -1 Then
            Return
        End If
        updateHymns(textBoxDictionary.Item("hymnalHymns"), hymnalHymnsListBox)
    End Sub

    Private Sub sermonHymnNo_KeyDown(sender As Object, e As KeyEventArgs) Handles sermonHymnNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            'user pressed enter to submit hymn
            If sermonHymnNo.Text = vbNewLine Or sermonHymnNo.Text = "" Then
                'user tried to enter empty line
                sermonHymnNo.Text = ""
                Return
            End If
            sermonHymnsListBox.Items.Add(sermonHymnNo.Text.Replace(vbNewLine, ""))
            sermonHymnNo.Text = ""
            'if first hymn added, select hymn
            If sermonHymnsListBox.Items.Count.Equals(1) Then
                sermonHymnsListBox.SelectedIndex = 0
                Return
            End If
            'only update hymns if selected index one of last three hymns
            If sermonHymnsListBox.SelectedIndex >= sermonHymnsListBox.Items.Count - 3 Then
                updateHymns(textBoxDictionary.Item("sermonHymns"), sermonHymnsListBox)
            End If
        End If
    End Sub
    Private Sub hymnalHymnNo_KeyDown(sender As Object, e As KeyEventArgs) Handles hymnalHymnNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            'user pressed enter to submit hymn
            If hymnalHymnNo.Text = vbNewLine Or hymnalHymnNo.Text = "" Then
                'user tried to enter empty line
                hymnalHymnNo.Text = ""
                Return
            End If
            hymnalHymnsListBox.Items.Add(hymnalHymnNo.Text.Replace(vbNewLine, ""))
            hymnalHymnNo.Text = ""
            'if first hymn added, select hymn
            If hymnalHymnsListBox.Items.Count.Equals(1) Then
                hymnalHymnsListBox.SelectedIndex = 0
                Return
            End If
            'only update hymns if selected index one of last three hymns
            If hymnalHymnsListBox.SelectedIndex >= hymnalHymnsListBox.Items.Count - 3 Then
                updateHymns(textBoxDictionary.Item("hymnalHymns"), hymnalHymnsListBox)
            End If
        End If
    End Sub




    '-----------------------------------------------------------------------------BUTTONS----------------------------------------

    'Project slide radio group
    Private Sub goToBreakBtn_CheckedChanged(sender As Object, e As EventArgs) Handles goToBreakBtn.CheckedChanged, goToBreakBtn.Click
        goToBreakBtn.TabStop = False
        If ppPres.SlideShowWindow.View.Slide.SlideIndex = slideDictionary.Item("break").SlideIndex Then
            Return
        End If
        If goToBreakBtn.Checked Then
            ppPres.SlideShowWindow.View.GotoSlide(slideDictionary.Item("break").SlideNumber)
        End If
    End Sub

    Private Sub goToTimetableBtn_CheckedChanged(sender As Object, e As EventArgs) Handles goToTimetableBtn.CheckedChanged, goToTimetableBtn.Click
        goToTimetableBtn.TabStop = False
        If ppPres.SlideShowWindow.View.Slide.SlideIndex = slideDictionary.Item("serviceTimes").SlideIndex Then
            Return
        End If
        If goToTimetableBtn.Checked Then
            ppPres.SlideShowWindow.View.GotoSlide(slideDictionary.Item("serviceTimes").SlideNumber)
        End If
    End Sub

    Private Sub goToPRBtn_CheckedChanged(sender As Object, e As EventArgs) Handles goToPRBtn.CheckedChanged, goToPRBtn.Click
        goToPRBtn.TabStop = False
        If ppPres.SlideShowWindow.View.Slide.SlideIndex = slideDictionary.Item("prayerRequests").SlideIndex Then
            Return
        End If
        If goToPRBtn.Checked Then
            ppPres.SlideShowWindow.View.GotoSlide(slideDictionary.Item("prayerRequests").SlideNumber)
        End If
    End Sub

    Private Sub goToHowToPrayBtn_CheckedChanged(sender As Object, e As EventArgs) Handles goToHowToPrayBtn.CheckedChanged, goToHowToPrayBtn.Click
        goToHowToPrayBtn.TabStop = False
        If ppPres.SlideShowWindow.View.Slide.SlideIndex = slideDictionary.Item("howToPray").SlideIndex Then
            Return
        End If
        If goToHowToPrayBtn.Checked Then
            ppPres.SlideShowWindow.View.GotoSlide(slideDictionary.Item("howToPray").SlideNumber)
        End If
    End Sub

    Private Sub goToTurnOffDevicesBtn_CheckedChanged(sender As Object, e As EventArgs) Handles goToTurnOffDevicesBtn.CheckedChanged, goToTurnOffDevicesBtn.Click
        goToTurnOffDevicesBtn.TabStop = False
        If ppPres.SlideShowWindow.View.Slide.SlideIndex = slideDictionary.Item("turnOffDevices").SlideIndex Then
            Return
        End If
        If goToTurnOffDevicesBtn.Checked Then
            ppPres.SlideShowWindow.View.GotoSlide(slideDictionary.Item("turnOffDevices").SlideNumber)
        End If
    End Sub

    Private Sub goToAnnouncementsBtn_CheckedChanged(sender As Object, e As EventArgs) Handles goToAnnouncementsBtn.CheckedChanged, goToAnnouncementsBtn.Click
        goToAnnouncementsBtn.TabStop = False
        If ppPres.SlideShowWindow.View.Slide.SlideIndex = slideDictionary.Item("announcements").SlideIndex Then
            Return
        End If
        If goToAnnouncementsBtn.Checked Then
            ppPres.SlideShowWindow.View.GotoSlide(slideDictionary.Item("announcements").SlideNumber)
        End If


    End Sub

    Private Sub goToHCBtn_CheckedChanged(sender As Object, e As EventArgs) Handles goToHCBtn.CheckedChanged, goToHCBtn.Click
        goToHCBtn.TabStop = False
        If ppPres.SlideShowWindow.View.Slide.SlideIndex = slideDictionary.Item("holyCommunion").SlideIndex Then
            Return
        End If
        If goToHCBtn.Checked Then
            ppPres.SlideShowWindow.View.GotoSlide(slideDictionary.Item("holyCommunion").SlideNumber)
        End If
    End Sub
    Private Sub showTitlesOnly()
        'navigate to title slide
        ppPres.SlideShowWindow.View.GotoSlide(slideDictionary.Item("sermonTitle").SlideIndex)
    End Sub
    Private Sub HymnNos_GotFocus(sender As Object, e As EventArgs) Handles sermonHymnNo.GotFocus
        sermonHymnNo.Text = ""
    End Sub
    Private Sub HymnNos_LostFocus(sender As Object, e As EventArgs) Handles sermonHymnNo.LostFocus
        sermonHymnNo.Text = "Enter Hymn"
    End Sub
    Private Sub hymnalHymnNos_GotFocus(sender As Object, e As EventArgs) Handles hymnalHymnNo.GotFocus
        hymnalHymnNo.Text = ""
    End Sub
    Private Sub hymnalHymnNos_LostFocus(sender As Object, e As EventArgs) Handles hymnalHymnNo.LostFocus
        hymnalHymnNo.Text = "Enter Hymn"
    End Sub

    '----------------------------------------FONT AND COLOUR BUTTONS------------------------------------------------------------------------------

    Private Sub EnglishFontBtn_Click(sender As Object, e As EventArgs) Handles EnglishFontBtn.Click
        'change text box depending on slide curretly on
        Dim textBox As String
        Dim currentSlideIndex = ppPres.SlideShowWindow.View.Slide.SlideIndex
        If currentSlideIndex = slideDictionary.Item("sermonHymnsSlide").SlideIndex Then
            textBox = "englishTitle1"
        ElseIf currentSlideIndex = slideDictionary.Item("bibleVersesSlide").SlideIndex Then
            textBox = "englishTitle2"
        Else
            'by default change one on sermon title slide
            textBox = "englishTitle"
        End If
        ChangeFont(textBoxDictionary.Item(textBox))
    End Sub
    Private Sub EnglishColorBtn_Click(sender As Object, e As EventArgs) Handles EnglishColorBtn.Click
        ChangeColor(textBoxDictionary.Item("englishTitle1"))
    End Sub
    Private Sub ChineseFontBtn_Click(sender As Object, e As EventArgs) Handles ChineseFontBtn.Click
        'change text box depending on slide curretly on
        Dim textBox As String
        Dim currentSlideIndex = ppPres.SlideShowWindow.View.Slide.SlideIndex
        If currentSlideIndex = slideDictionary.Item("sermonHymnsSlide").SlideIndex Then
            textBox = "chineseTitle1"
        ElseIf currentSlideIndex = slideDictionary.Item("bibleVersesSlide").SlideIndex Then
            textBox = "chineseTitle2"
        Else
            'by default change one on sermon title slide
            textBox = "chineseTitle"
        End If
        ChangeFont(textBoxDictionary.Item(textBox))
    End Sub
    Private Sub ChineseColorBtn_Click(sender As Object, e As EventArgs) Handles ChineseColorBtn.Click
        ChangeColor(textBoxDictionary.Item("chineseTitle1"))
    End Sub
    Private Sub ServiceTypeFontBtn_Click(sender As Object, e As EventArgs) Handles ServiceTypeFontBtn.Click
        'change text box depending on slide curretly on
        Dim textBox As String
        Dim currentSlideIndex = ppPres.SlideShowWindow.View.Slide.SlideIndex
        If currentSlideIndex = slideDictionary.Item("sermonHymnsSlide").SlideIndex Then
            textBox = "serviceType1"
        ElseIf currentSlideIndex = slideDictionary.Item("bibleVersesSlide").SlideIndex Then
            textBox = "serviceType2"
        Else
            'by default change one on sermon title slide
            textBox = "serviceType"
        End If
        ChangeFont(textBoxDictionary.Item(textBox))
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
    Private Sub hymnalHymnColor_Click(sender As Object, e As EventArgs) Handles hymnalHymnColor.Click
        ChangeColor(textBoxDictionary.Item("hymnalHymns"))
    End Sub
    Private Sub hymnalHymnFontBtn_Click(sender As Object, e As EventArgs) Handles hymnalHymnFont.Click
        ChangeFont(textBoxDictionary.Item("hymnalHymns"))
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

    Private Sub OpenPrayerRequestsWindow_Click(sender As Object, e As EventArgs) Handles OpenPrayerRequestsWindow.Click
        prayerRequestsWindow.Show()
    End Sub

    Private Sub OpenFolder_Click(sender As Object, e As EventArgs)
        openFilesFolder()
    End Sub
    Public Sub openFilesFolder()
        Process.Start(CurrentDirectory + "\Files")
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If goToBreakBtn.Checked Then
            'update time on break slide
            ppPres.Slides(1).Shapes(1).TextFrame.TextRange.Text = DateTime.Now.ToString("HH:mm:ss")
        End If
    End Sub

    Private Sub Titles_KeyDown(sender As Object, e As KeyEventArgs) Handles EnglishTitle.KeyDown, ChineseTitle.KeyDown
        If e.KeyCode = Keys.Enter Then
            UpdateTitle_Click(sender, e)
            'Mute ding sound from windows
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Verse_KeyDown(sender As Object, e As KeyEventArgs) Handles VerseTxt.KeyDown
        'handling both when chapter and verse enter key pressed
        If e.KeyCode = Keys.Enter Then
            Call UpdateVerse_Click(sender, e)
            If VerseTxt.Text IsNot "" Then
                SelectNextControl(sender, True, True, True, True)
            End If
            'Mute ding sound from windows
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub Chapter_KeyDown(sender As Object, e As KeyEventArgs) Handles ChapterTxt.KeyDown
        'handling both when chapter and verse enter key pressed
        If e.KeyCode = Keys.Enter Then
            If ChapterTxt.Text IsNot "" Then
                SelectNextControl(sender, True, True, True, True)
            End If
            'Mute ding sound from windows
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub ServiceType_KeyDown(sender As Object, e As KeyEventArgs) Handles ServiceType.KeyDown
        If e.KeyCode = Keys.Enter Then
            updateServiceTypes()
            'Mute ding sound from windows
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub updateServiceTypes()
        textBoxDictionary.Item("serviceType").Text = ServiceType.Text
        textBoxDictionary.Item("serviceType1").Text = ServiceType.Text
        textBoxDictionary.Item("serviceType2").Text = ServiceType.Text
        textBoxDictionary.Item("serviceType3").Text = ServiceType.Text
    End Sub

    Private Sub BookBox_KeyDown(sender As Object, e As KeyEventArgs) Handles BookBox.KeyDown
        ' handles when book box is empty, assumes that no verse or chapter should be shown
        If BookBox.Text Is "" And e.KeyCode = Keys.Enter Then
            showTitlesOnly()
            textBoxDictionary.Item("englishBook").Text = " "
            textBoxDictionary.Item("chineseBook").Text = " "
            textBoxDictionary.Item("chapterAndVerse").Text = " "
            VerseTxt.Text = ""
            ChapterTxt.Text = ""
            'Mute ding sound from windows
            e.Handled = True
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.Enter Then
            If BookBox.SelectedIndex <> -1 Then
                SelectNextControl(sender, True, True, True, True)
                'Mute ding sound from windows
                e.Handled = True
                e.SuppressKeyPress = True
            End If
        End If

    End Sub

    Private Sub ChapterTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles ChapterTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            ChapterTxt.DeselectAll()
        End If
    End Sub
    Private Sub VerseTxt_GotFocus(sender As Object, e As EventArgs) Handles VerseTxt.GotFocus
        ChapterTxt.DeselectAll()
        VerseTxt.SelectAll()
    End Sub
    Private Sub ChapterTxt_GotFocus(sender As Object, e As EventArgs) Handles ChapterTxt.GotFocus
        ChapterTxt.SelectAll()
    End Sub


    Private Sub Show_AN_Click(sender As Object, e As EventArgs) Handles Show_AN.Click
        announcementsWindow.Show()
    End Sub

    Private Sub edtPrayerImg_Click(sender As Object, e As EventArgs)
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
                slideDictionary.Item("prayerRequests").Shapes.AddPicture(ofd.FileName, False, True, 0, 0, ppPres.PageSetup.SlideWidth, ppPres.PageSetup.SlideHeight)
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
        HolyCommunion.Focus()
    End Sub

    Private Sub clearbtn_Click(sender As Object, e As EventArgs) Handles clearbtn.Click
        ResetServiceDetails()
        showTitlesOnly()
        ShowSermonHymns.Checked = True

    End Sub

    'Inserting service times as an image, and inserting into powerpoint slide
    Private Sub ServiceTimesBtn_Click(sender As Object, e As EventArgs) Handles ServiceTimesBtn.Click
        serviceTimesWindow.Show()
    End Sub


    'Following 5 methods deal with moving the chinese and english title up or down to create more/less spacing
    'Needed when English title takes two or more lines
    Private Sub moveUp(textBox As PowerPoint.Shape)
        If textBox.Top >= 10 Then
            textBox.Top = textBox.Top - 10
        End If
    End Sub

    Private Sub moveDown(textBox As PowerPoint.Shape)
        If textBox.Top <= 400 Then
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


End Class

