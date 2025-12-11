Imports Office = Microsoft.Office.Core
Imports PowerPoint = Microsoft.Office.Interop.PowerPoint
Imports System.IO
Imports System.Xml
Imports System.Threading

' This class is part of the TJC PowerPoint project.
' The TJC PowerPoint is a simple program displaying bible verses, hymns to a projector using Microsoft PowerPoint.
' It also has other purporses to help display usesful information to the projector
' These include:
' How to pray, service times, current time and date, holy communion slides, prayer requests, announcements, hymnal hymns etc.
'
' Initially developed by Joshi Chan (TJC Leicester), from V2 onwards developed by Caleb Chan (TJC London).
' © Copyright 2023 True Jesus Church London.

Public Class MainProgram
    Inherits DraggableForm

    Private ppPres As PowerPoint.Presentation
    Private currentDir As String = Directory.GetCurrentDirectory()
    Private writer As XmlTextWriter = Nothing
    ' Create HymnSelector objects to track and store hymn numbers.
    Private sermonHymns As HymnSelector
    Private hymnalHymns As HymnSelector
    ' Create dictionary objects to reference slide/text range objects.
    Private slideDictionary As Dictionary(Of String, PowerPoint.Slide)
    Private textBoxDictionary As Dictionary(Of String, PowerPoint.TextRange)
    ' Create window form objects for editable slides.
    Private prayerRequestsWindow As BaseSlideEdit
    Private announcementsWindow As BaseSlideEdit
    Private serviceTimesWindow As BaseSlideEdit

    ' Handle application exceptions by displaying a message box upon exception.
    Private Sub Application_ThreadException(sender As Object, e As ThreadExceptionEventArgs)
        MessageBox.Show("An error occurred. Please restart the application" + e.ToString())
        Close()
    End Sub
    ' Handle unhandled exceptions by displaying a message box upon exception.
    Private Sub CurrentDomain_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs)
        MessageBox.Show("An error occurred. Please restart the application" + e.ToString())
        Close()
    End Sub
    ' Constructor of MainProgram.
    Public Sub New()
        InitializeComponent()
        ' Add the event handler for unhandled exceptions
        AddHandler Application.ThreadException, AddressOf Application_ThreadException
        AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf CurrentDomain_UnhandledException
    End Sub
    ' Handle initial load up of windows form
    ' Creates and locates directory, loads up Microsoft PowerPoints, initialises form's controls
    Private Sub MainLoad() Handles MyBase.Load
        Try
            MakeFolder()
            LoadPres()
            createDict()
            ResetServiceDetails()
            handleEditableSlides()
            HandleHC()
            ' Initialise HymnSelector objects.
            sermonHymns = New HymnSelector("sermon", getTextBox(Definition.sermonHymns.ToString()), SermonHymnsListBox)
            hymnalHymns = New HymnSelector("hymnal", getTextBox(Definition.hymnalHymns.ToString()), HymnalListBox)
            ' Set default slide to Break Slide.
            ShowBreakBtn.Checked = True
        Catch ex As Exception
            'Show error box to user if application could not load. Force application to close
            MessageBox.Show("An error occurred while loading the application. Please try again.", "Error")
            Close()
        End Try
    End Sub

    ' Handle closing of the form.
    ' Ensures all processes are safely closed and exited.
    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            'Checking for Null errors due to error elsewhere, ensure safe close of program
            If writer IsNot Nothing Then
                writer.WriteEndElement()
                writer.Close()
            End If
            If ppPres IsNot Nothing Then
                ppPres.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    ' Returns the current directory that the application is located in.
    Public Function getCurrentDirectory()
        Return currentDir
    End Function
    ' Returns a text box object from textbox dictionairy.
    Public Function getTextBox(textBox As String)
        Return textBoxDictionary.Item(textBox)
    End Function
    ' Returns PowerPoint slide object from slide dictionary.
    Public Function getSlide(slideName As String)
        Return slideDictionary.Item(slideName)
    End Function
    ' Reads a text file of a given text file name in the same directory.
    ' Returns string object containing its contents.
    Public Function getTextFile(fileName As String)
        ' If the file exists, return the contents.
        ' If the file does not exist, then create empty text file with the corresponding file name.
        If My.Computer.FileSystem.FileExists(currentDir + "\Files\" + fileName) Then
            Dim text As String
            text = My.Computer.FileSystem.ReadAllText(currentDir + "\Files\" + fileName, System.Text.Encoding.UTF8)
            Return text
        Else
            Using sw As StreamWriter = File.CreateText(currentDir + "\Files\" + fileName)
                sw.WriteLine(" ")
            End Using
            Return ""
        End If
    End Function
    ' Create directory containing required resources.
    ' For each resource that does not already exist, write it to the folder.
    Private Sub MakeFolder()
        If Directory.Exists("\Files") = False Then
            My.Computer.FileSystem.CreateDirectory(currentDir + "\Files")
        End If
        If My.Computer.FileSystem.FileExists(currentDir + "\Files\ServiceWidescreen.pptx") = False Then
            System.IO.File.WriteAllBytes(currentDir + "\Files\ServiceWidescreen.pptx", My.Resources.ServiceWidescreen)
        End If
        If My.Computer.FileSystem.FileExists(currentDir + "\Files\config.xml") = False Then
            System.IO.File.WriteAllText(currentDir + "\Files\config.xml", My.Resources.config)
        End If
    End Sub
    ' Load up the PowerPoint app, along with the matching PowerPoint file.
    ' Set default presentation settings.
    Private Sub LoadPres()
        Dim ppApp As PowerPoint.Application
        ' Create a new instance of PowerPoint application
        ppApp = New PowerPoint.Application
        ' Open the presentation file
        ppPres = ppApp.Presentations.Open(currentDir & "\Files\ServiceWidescreen.pptx", ReadOnly:=Office.MsoTriState.msoFalse, WithWindow:=Office.MsoTriState.msoFalse)
        ' Set slide show settings
        With ppPres.SlideShowSettings
            .ShowPresenterView = False
            .Run()
        End With
    End Sub
    ' Create dictionaries for slide and text box objects.
    Private Sub createDict()
        Dim dict As DictionairyFactory
        dict = New DictionairyFactory(ppPres)
        slideDictionary = dict.getSlideDictionairy()
        textBoxDictionary = dict.getTextBoxDictionairy()
    End Sub
    ' Method that resets the program to the initial running state.
    Private Sub ResetServiceDetails()
        ' Clear the Form's hymns controls.
        SermonHymnTxt.Text = "Enter Hymn"
        HymnalTxt.Text = "Enter Hymn"
        ' Clear the various hymn list boxes and their hymns.
        Dim listBoxesToClear() As ListBox = {SermonHymnsListBox, HymnalListBox}
        For Each listBox In listBoxesToClear
            listBox.Items.Clear()
        Next
        ' Set default values or where appropiate, placeholder texts.
        ServiceTypeTxt.Text = ""
        BookTxt.Text = ""
        VerseTxt.Text = ""
        ChapterTxt.Text = ""
        EnglishTitleTxt.Text = "English Sermon Title"
        ChineseTitleTxt.Text = "中文講道題目"
        ' Reset all relevent text boxes in PowerPoint.
        ' For each textbox key in array below, empty the text.
        Dim textBoxesToReset() As String = {"englishTitle", "chineseTitle", "serviceType", "englishTitle1", "chineseTitle1",
                                        "sermonHymns", "serviceType1", "englishTitle2", "chineseTitle2", "chapterAndVerse",
                                        "englishBook", "chineseBook", "serviceType2", "HChymns", "hymnalHymns",
                                        "serviceType3"}
        For Each textBoxKey In textBoxesToReset
            textBoxDictionary.Item(textBoxKey).Text = " "
        Next
    End Sub
    ' Method to load Holy Communion slide with details from the text files.
    ' If no text file exists, then no names will be displayed.
    Private Sub HandleHC()
        ' Read from bread.txt and update PowerPoint textbox with read content.
        If My.Computer.FileSystem.FileExists(currentDir + "\Files\bread.txt") = True Then
            textBoxDictionary.Item("bread").Text = My.Computer.FileSystem.ReadAllText(currentDir + "\Files\bread.txt")
        End If
        ' Read from cup.txt and update PowerPoint textbox with read content.
        If My.Computer.FileSystem.FileExists(currentDir + "\Files\cup.txt") = True Then
            textBoxDictionary.Item("cup").Text = My.Computer.FileSystem.ReadAllText(currentDir + "\Files\cup.txt")
        End If
    End Sub
    ' Method takes in name, slide key, text box key and title name, creating new BaseSlideEdit Form.
    Private Sub HandleData(title As String, slideKey As String, bodyTextboxKey As String, titleTextboxKey As String, ByRef slideWindow As BaseSlideEdit)
        Dim dataTxt As String = getTextFile($"{title}.txt")
        textBoxDictionary.Item(bodyTextboxKey).Text = dataTxt
        slideWindow = New BaseSlideEdit(title, slideKey, slideDictionary.Item(slideKey))
        slideWindow.setInput(dataTxt)
        slideWindow.setBodyTB(textBoxDictionary.Item(bodyTextboxKey))
        slideWindow.setTitleTB(textBoxDictionary.Item(titleTextboxKey))
    End Sub
    ' Method that initialises editable slides and their BaseSlideEdit objects.
    Private Sub handleEditableSlides()
        HandleData("Announcements", "announcements", "AnnouncementsTxt", "AnnouncementsTitle", announcementsWindow)
        HandleData("Service Times", "serviceTimes", "ServiceTimesTxt", "ServiceTimesTitle", serviceTimesWindow)
        HandleData("Prayer Requests", "prayerRequests", "PrayerRequestsTxt", "PrayerRequestsTitle", prayerRequestsWindow)
    End Sub
    ' Method that changes the font of a given PowerPoint text range object.
    ' Opens a dialog that allows user to select a style and font, and applies font to text box.
    Public Sub ChangeFont(textBox As PowerPoint.TextRange)
        ' Create FontDialog object.
        Dim dialog = New FontDialog()
        ' Set initial font from existing textbox font.
        dialog.Font = New Font(textBox.Font.Name, textBox.Font.Size, GetFontStyleFromTextBox(textBox))

        If dialog.ShowDialog() = DialogResult.OK Then
            SetFontOfTextbox(textBox, dialog.Font)
        End If
    End Sub
    ' Adapter method translates font styles from PowerPoint text boxes (TextRange object) to a FontStyle object.
    Private Function GetFontStyleFromTextBox(textBox As PowerPoint.TextRange) As FontStyle
        Dim style As FontStyle = FontStyle.Regular
        If textBox.Font.Bold Or textBox.Font.Name.Contains("Bold") Then
            style = FontStyle.Bold
        End If
        If textBox.Font.Italic Or textBox.Font.Name.Contains("Italic") Then
            style = FontStyle.Italic
        End If
        If textBox.Font.Underline Or textBox.Font.Name.Contains("Underline") Then
            style = FontStyle.Underline
        End If
        Return style
    End Function
    ' Applies Font object styling to PowerPoint text box.
    Private Sub SetFontOfTextbox(textBox As PowerPoint.TextRange, font As Font)
        textBox.Font.Name = font.Name
        textBox.Font.Size = font.Size
        textBox.Font.Bold = font.Bold
        textBox.Font.Italic = font.Italic
        textBox.Font.Underline = font.Underline
    End Sub
    ' Method that changes the text colour of a given PowerPoint text range object.
    ' Opens a dialog that allows user to select a colour, and applies text colour to the text box.
    Public Sub ChangeColor(textBox As PowerPoint.TextRange)
        ' Create ColorDialog object.
        Dim dialog = New ColorDialog()
        dialog.FullOpen = True
        ' Show Dialog and respond based on result.
        If dialog.ShowDialog() = DialogResult.OK Then
            Dim color = dialog.Color
            ' Handle special case of text boxes which occur in multiple slides.
            ' For each reccurrence, apply the selected colour to occurence.
            Select Case textBox.Text
                Case textBoxDictionary.Item("englishTitle1").Text
                    ApplyColorToTextBoxes(color, "englishTitle", "englishTitle1", "englishTitle2")
                Case textBoxDictionary.Item("chineseTitle1").Text
                    ApplyColorToTextBoxes(color, "chineseTitle", "chineseTitle1", "chineseTitle2")
                Case textBoxDictionary.Item("serviceType1").Text
                    ApplyColorToTextBoxes(color, "serviceType", "serviceType1", "serviceType2", "serviceType3")
                Case Else
                    textBox.Font.Color.RGB = ColorToRGB(color)
            End Select
        End If
    End Sub
    ' Method that takes in a Color object, and any number of text boxes.
    ' Applies the colour to the text of each text box.
    Private Sub ApplyColorToTextBoxes(color As Color, ParamArray textBoxNames() As String)
        ' Convert Color object to RGB values.
        Dim rgbColor As Integer = ColorToRGB(color)
        ' Cycle through each text box and apply the color.
        For Each textBoxName As String In textBoxNames
            If textBoxDictionary.ContainsKey(textBoxName) Then
                textBoxDictionary(textBoxName).Font.Color.RGB = rgbColor
            End If
        Next
    End Sub
    ' Converts Color object to RGB values.
    Private Function ColorToRGB(color As Color) As Integer
        Return Color.FromArgb(255, color.B, color.G, color.R).ToArgb
    End Function
    ' Resizes a given textbox to ensure the text does not exceed one line.
    ' Includes a slight margin.
    Private Sub ResizeToFit(textBox As PowerPoint.TextRange)
        ' Check if already only one line of text. If so, return.
        ' Else, continue to decrease font size until text fits on one line.
        If textBox.Lines.Count = 1 Then
            Return
        Else
            While textBox.Lines.Count >= 2
                textBox.Font.Size -= 1
            End While
            ' Decrease by 1 more to introduce slight margin around text.
            textBox.Font.Size -= 1
        End If
    End Sub
    ' Function that returns whether or not the active slide's index of the PowerPoint presentation matches with a given slide index.
    Public Function IsCurrentSlideIndex(slideIndex As Integer) As Boolean
        Return ppPres.SlideShowWindow.View.Slide.SlideIndex = slideIndex
    End Function
    ' Method that causes the acive PowerPoint presentation to move to a specified slide index.
    Public Sub GoToSlide(slideIndex As Integer)
        ppPres.SlideShowWindow.View.GotoSlide(slideIndex)
    End Sub
    ' Method that is called when only the sermon titles should be displayed.
    Private Sub showTitlesOnly()
        ' Navigate to title slide.
        ppPres.SlideShowWindow.View.GotoSlide(slideDictionary.Item(Definition.sermonTitle.ToString()).SlideIndex)
    End Sub
    ' Method that updates the verses in the PowerPoint presentation and displays the entered verses.
    ' If verses entered is empty, only sermon titles are shown.
    Private Sub UpdateVerse()
        ' If all input fields empty, then the text box should also be empty.
        If String.IsNullOrWhiteSpace(VerseTxt.Text) AndAlso String.IsNullOrWhiteSpace(BookTxt.Text) AndAlso String.IsNullOrWhiteSpace(ChapterTxt.Text) Then
            textBoxDictionary.Item("chapterAndVerse").Text = " "
        ElseIf String.IsNullOrEmpty(BookTxt.Text) OrElse BookTxt.SelectedIndex = -1 Then
            ' When no verse is entered, then only show sermon titles.
            showTitlesOnly()
        Else
            'Update text boxes to display verse details, including chapter, verse and book name.
            Dim commaPos As Integer = InStr(BookTxt.Text, ",")
            textBoxDictionary.Item("englishBook").Text = Mid(BookTxt.Text, 1, commaPos - 1)
            textBoxDictionary.Item("chineseBook").Text = Mid(BookTxt.Text, commaPos + 1)
            textBoxDictionary.Item("chapterAndVerse").Text = $"{ChapterTxt.Text} : {VerseTxt.Text}"
            ResizeToFit(textBoxDictionary.Item("chapterAndVerse"))
            ppPres.SlideShowWindow.View.GotoSlide(slideDictionary.Item("bibleVersesSlide").SlideIndex)
            ' Automatically change to show verses when a verse is entered.
            If ShowVersesBtn.Checked = False Then
                ShowVersesBtn.Checked = True
            End If
        End If
    End Sub
    ' Method that clears the text in the verses text boxes in the PowerPoint presentation.
    Private Sub ClearBibleVerses()
        textBoxDictionary.Item("englishBook").Text = ""
        textBoxDictionary.Item("chineseBook").Text = ""
        textBoxDictionary.Item("chapterAndVerse").Text = ""
    End Sub
    ' Method that clears the Form's input fields.
    Private Sub ClearInputFields()
        BookTxt.Text = ""
        VerseTxt.Text = ""
        ChapterTxt.Text = ""
    End Sub
    ' Method that handles when the ShowHymnal control is checked/unchecked.
    ' Upon checked, PowerPoint presentation goes to the hymnal slide.
    Private Sub ShowHymnal_CheckedChanged(sender As Object, e As EventArgs) Handles ShowHymnalBtn.CheckedChanged
        If ShowHymnalBtn.Checked Then
            ppPres.SlideShowWindow.View.GotoSlide(slideDictionary.Item("hymnalHymnsSlide").SlideIndex)
        End If
    End Sub
    ' Method that handles when the ShowVerses control is checked/unchecked.
    ' On checking, the verse is updated. If unchecked, verses are cleared.
    Private Sub ShowVerses_CheckedChanged(sender As Object, e As EventArgs) Handles ShowVersesBtn.CheckedChanged
        ShowVersesBtn.TabStop = False
        If ShowVersesBtn.Checked Then
            UpdateVerse()
        Else
            ClearBibleVerses()
            ClearInputFields()
        End If
    End Sub

    ' -----------------------------------------------------------------------------------------------------------------------------------------
    ' FOLLOWING METHODS HANDLE ON CLICK ON CONTROLS.
    ' -----------------------------------------------------------------------------------------------------------------------------------------

    ' Method to handle when the ShowSermonHymns control is clicked on.
    Private Sub ShowSermonHymns_Click(sender As Object, e As EventArgs) Handles ShowSermonHymnsBtn.Click
        ' If showing sermon hymns, but there are no hymns to show, only show the sermon titles.
        If ShowSermonHymnsBtn.Checked AndAlso SermonHymnsListBox.Items.Count = 0 Then
            showTitlesOnly()
            Return
        End If
        ' If ShowSermonHymns is checked, but not on sermon hymns slide, then go to slide.
        If ShowSermonHymnsBtn.Checked AndAlso Not IsCurrentSlideIndex(slideDictionary.Item("sermonHymnsSlide").SlideIndex) Then
            GoToSlide(slideDictionary.Item("sermonHymnsSlide").SlideIndex)
        End If
    End Sub
    ' Method to handle when the ShowHymnal control is clicked.
    Private Sub ShowHymnal_Click(sender As Object, e As EventArgs) Handles ShowHymnalBtn.Click
        ' If ShowHymnal is checked, but not on hymnal slide, then go to hymnal slide.
        If ShowHymnalBtn.Checked AndAlso Not IsCurrentSlideIndex(slideDictionary.Item("hymnalHymnsSlide").SlideIndex) Then
            GoToSlide(slideDictionary.Item("hymnalHymnsSlide").SlideIndex)
        End If
    End Sub
    ' Method to handle when the ShowVerses control is clicked.
    Private Sub ShowVerses_Click(sender As Object, e As EventArgs) Handles ShowVersesBtn.Click
        ' If showing bible verses, but there are no verses to show, only show the sermon titles.
        If ShowVersesBtn.Checked AndAlso BookTxt.Text = "" Then
            showTitlesOnly()
            Return
        End If
        ' If ShowVerses is checked, but not on sermon hymns slide, then go to slide.
        If ShowVersesBtn.Checked AndAlso Not IsCurrentSlideIndex(slideDictionary.Item("bibleVersesSlide").SlideIndex) Then
            GoToSlide(slideDictionary.Item("bibleVersesSlide").SlideIndex)
        End If
    End Sub
    ' Handles when updateVerseBtn is clicked.
    Private Sub updateVerseBtn_Click(sender As Object, e As EventArgs) Handles UpdateVerseBtn.Click
        UpdateVerse()
    End Sub
    ' Handles when UpdateTitle control is clicked.
    Private Sub UpdateTitle_Click(sender As Object, e As EventArgs) Handles UpdateTitleBtn.Click
        ' Remove whitespace from the beginnings and ends of the Titles.
        EnglishTitleTxt.Text.Trim()
        ChineseTitleTxt.Text.Trim()

        ' Update text on title slide, sermon slide, and bible verse slide
        Dim englishTitles() As String = {"englishTitle", "englishTitle1", "englishTitle2"}
        For Each textBox In englishTitles
            textBoxDictionary.Item(textBox).Text = EnglishTitleTxt.Text
        Next

        Dim chineseTitles() As String = {"chineseTitle", "chineseTitle1", "chineseTitle2"}
        For Each textBox In chineseTitles
            textBoxDictionary.Item(textBox).Text = ChineseTitleTxt.Text
        Next
        'Resize following text to fit on one line
        Dim resizeTextboxes() As String = {"englishTitle1", "englishTitle2", "chineseTitle1", "chineseTitle2"}
        For Each textBox In resizeTextboxes
            ResizeToFit(getTextBox(textBox))
        Next

        If ShowHymnalBtn.Checked Then
            ' If updated titles during hymnal, return to service hymns
            ShowSermonHymnsBtn.Checked = True
        End If

        ' Update service types
        updateServiceTypes()
    End Sub

    ' -----------------------------------------------------------------------------------------------------------------------------------------
    ' FOLLOWING METHODS HANDLE HYMN SELECTION FOR SERMON HYMNS AND HYMNAL HYMNS.
    ' -----------------------------------------------------------------------------------------------------------------------------------------
    Private Sub HymnNos_GotFocus(sender As Object, e As EventArgs) Handles SermonHymnTxt.GotFocus
        SermonHymnTxt.Text = ""
    End Sub
    Private Sub HymnNos_LostFocus(sender As Object, e As EventArgs) Handles SermonHymnTxt.LostFocus
        SermonHymnTxt.Text = "Enter Hymn"
    End Sub
    Private Sub hymnalHymnNos_GotFocus(sender As Object, e As EventArgs) Handles HymnalTxt.GotFocus
        HymnalTxt.Text = ""
    End Sub
    Private Sub hymnalHymnNos_LostFocus(sender As Object, e As EventArgs) Handles HymnalTxt.LostFocus
        HymnalTxt.Text = "Enter Hymn"
    End Sub
    Private Sub nextHymn_Click(sender As Object, e As EventArgs) Handles NextHymnBtn.Click
        If SermonHymnsListBox.SelectedIndex = SermonHymnsListBox.Items.Count - 1 Then
            Return
        End If
        SermonHymnsListBox.SelectedIndex += 1
    End Sub
    Private Sub hymnalNextHymn_Click(sender As Object, e As EventArgs) Handles HymnalNextHymnBtn.Click
        If HymnalListBox.SelectedIndex = HymnalListBox.Items.Count - 1 Then
            Return
        End If
        HymnalListBox.SelectedIndex += 1
    End Sub

    Private Sub prevHymn_Click(sender As Object, e As EventArgs) Handles PrevHymnBtn.Click
        If SermonHymnsListBox.SelectedIndex = 0 Or SermonHymnsListBox.SelectedIndex = -1 Then
            Return
        End If
        SermonHymnsListBox.SelectedIndex -= 1
    End Sub
    Private Sub hymnalPrevHymn_Click(sender As Object, e As EventArgs) Handles HymnalPrevHymnBtn.Click
        If HymnalListBox.SelectedIndex = 0 Or HymnalListBox.SelectedIndex = -1 Then
            Return
        End If
        HymnalListBox.SelectedIndex -= 1
    End Sub

    Private Sub clearSermonHymnsBtn_Click(sender As Object, e As EventArgs) Handles ClearSermonHymnsBtn.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to clear all hymns?", "Confirm Clear", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            SermonHymnsListBox.Items.Clear()
            sermonHymns.updateHymns()
            showTitlesOnly()
        End If
    End Sub
    Private Sub clearHymnalHymnsBtn_Click(sender As Object, e As EventArgs) Handles ClearHymnalBtn.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to clear all hymns?", "Confirm Clear", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            HymnalListBox.Items.Clear()
            hymnalHymns.updateHymns()
        End If
    End Sub

    'handles deleting from button (sermon hymn)
    Private Sub delHymnBtn_Click(sender As Object, e As EventArgs) Handles DelHymnBtn.Click
        sermonHymns.removeCurrentHymn()
        If SermonHymnsListBox.Items.Count = 0 And Not ShowHymnalBtn.Checked Then
            showTitlesOnly()
        End If
    End Sub
    'handles deleting from button (hymnal hymn)
    Private Sub delHymnalHymnBtn_Click(sender As Object, e As EventArgs) Handles HymnalDelHymnBtn.Click
        hymnalHymns.removeCurrentHymn()
    End Sub

    'Handles deleting hymns from selection box
    Private Sub HymnsSelectionBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SermonHymnsListBox.KeyDown
        If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete Then
            sermonHymns.removeCurrentHymn()
            If SermonHymnsListBox.Items.Count = 0 And Not ShowHymnalBtn.Checked Then
                showTitlesOnly()
            End If
        End If
    End Sub
    Private Sub hymnalHymnsListBox_KeyDown(sender As Object, e As KeyEventArgs) Handles HymnalListBox.KeyDown
        If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete Then
            hymnalHymns.removeCurrentHymn()
        End If
    End Sub
    Private Sub sermonHymnsListBox_IndexChanged(sender As Object, e As EventArgs) Handles SermonHymnsListBox.SelectedIndexChanged
        If SermonHymnsListBox.SelectedIndex = -1 Then
            Return
        End If
        If ShowSermonHymnsBtn.Checked And SermonHymnsListBox.Items.Count > 0 Then
            ShowSermonHymnsBtn.PerformClick()
        End If
        sermonHymns.updateHymns()
    End Sub
    Private Sub hymnalHymnListBox_IndexChanged(sender As Object, e As EventArgs) Handles HymnalListBox.SelectedIndexChanged
        If HymnalListBox.SelectedIndex = -1 Then
            Return
        End If
        hymnalHymns.updateHymns()
    End Sub

    Private Sub sermonHymnNo_KeyDown(sender As Object, e As KeyEventArgs) Handles SermonHymnTxt.KeyDown
        sermonHymns.HandleHymnTextBoxKeyDown(e, SermonHymnTxt)
    End Sub

    Private Sub hymnalHymnNo_KeyDown(sender As Object, e As KeyEventArgs) Handles HymnalTxt.KeyDown
        hymnalHymns.HandleHymnTextBoxKeyDown(e, HymnalTxt)
    End Sub

    ' -----------------------------------------------------------------------------------------------------------------------------------------
    ' FOLLOWING METHODS HANDLE PROJECT SLIDE RADIO GROUP
    ' -----------------------------------------------------------------------------------------------------------------------------------------
    Private Sub GoToSlideIfNotAlreadyChecked(sender As Object, targetSlideName As String)
        Dim radioButton As RadioButton = DirectCast(sender, RadioButton)

        Dim targetSlide As PowerPoint.Slide = slideDictionary.Item(targetSlideName)

        If ppPres.SlideShowWindow.View.Slide.SlideIndex <> targetSlide.SlideIndex AndAlso radioButton.Checked Then
            ppPres.SlideShowWindow.View.GotoSlide(targetSlide.SlideNumber)
        End If
    End Sub
    Private Sub goToBreakBtn_CheckedChanged(sender As Object, e As EventArgs) Handles ShowBreakBtn.CheckedChanged
        ShowBreakBtn.TabStop = False
        GoToSlideIfNotAlreadyChecked(sender, Definition.break.ToString())
    End Sub

    Private Sub goToTimetableBtn_CheckedChanged(sender As Object, e As EventArgs) Handles ShowTimetableBtn.CheckedChanged
        ShowTimetableBtn.TabStop = False
        GoToSlideIfNotAlreadyChecked(sender, Definition.serviceTimes.ToString())
        If ShowTimetableBtn.Checked = False Then
            serviceTimesWindow.HideBrowser()
        Else
            serviceTimesWindow.ShowBrowser()
        End If
    End Sub

    Private Sub goToPRBtn_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPRBtn.CheckedChanged
        ShowPRBtn.TabStop = False
        GoToSlideIfNotAlreadyChecked(sender, Definition.prayerRequests.ToString())
        If ShowPRBtn.Checked = False Then
            prayerRequestsWindow.HideBrowser()
        Else
            prayerRequestsWindow.ShowBrowser()
        End If
    End Sub

    Private Sub goToHowToPrayBtn_CheckedChanged(sender As Object, e As EventArgs) Handles ShowHowToPrayBtn.CheckedChanged
        ShowHowToPrayBtn.TabStop = False
        GoToSlideIfNotAlreadyChecked(sender, Definition.howToPray.ToString())
    End Sub

    Private Sub goToTurnOffDevicesBtn_CheckedChanged(sender As Object, e As EventArgs) Handles ShowOffDevicesBtn.CheckedChanged
        ShowOffDevicesBtn.TabStop = False
        GoToSlideIfNotAlreadyChecked(sender, Definition.turnOffDevices.ToString())
    End Sub

    Private Sub goToAnnouncementsBtn_CheckedChanged(sender As Object, e As EventArgs) Handles ShowAnnouncementsBtn.CheckedChanged
        ShowAnnouncementsBtn.TabStop = False
        GoToSlideIfNotAlreadyChecked(sender, Definition.announcements.ToString())
        If ShowAnnouncementsBtn.Checked = False Then
            announcementsWindow.HideBrowser()
        Else
            announcementsWindow.ShowBrowser()
        End If
    End Sub

    Private Sub goToHCBtn_CheckedChanged(sender As Object, e As EventArgs) Handles ShowHCBtn.CheckedChanged
        ShowHCBtn.TabStop = False
        GoToSlideIfNotAlreadyChecked(sender, Definition.holyCommunion.ToString())
    End Sub

    Public Sub changeBackground()
        Dim img = uploadImage()
        If img IsNot "" Then
            ppPres.SlideMaster.Background.Fill.UserPicture(img)
        End If
    End Sub

    ' Method that loads up file dialog, returning the directory of the image that the user selects.
    ' If cancelled or wrong image file, message box is shown.
    ' Returns the image path as a string.
    Public Function uploadImage()
        Try
            ' Initialise our open file dialog to accept all image files.
            Dim ofd As New OpenFileDialog()
            ofd.InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads")
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"
            If ofd.ShowDialog() = DialogResult.OK Then
                ' User has successfully selected an image, return the selected image path.
                Dim imageFilePath As String = ofd.FileName
                MessageBox.Show("Image was successfully updated.", "Success")
                Return imageFilePath
            Else
                ' User has not selected an image file correctly, show a message box to user and return empty string.
                MessageBox.Show("No image file was selected. Please try again.", "Error")
                Return ""
            End If
        Catch ex As Exception
            ' Upon any exception, show a message box to the user, and return empty string.
            MessageBox.Show("An error occurred while updating the image. Please try again.", "Error")
            Return ""
        End Try
    End Function

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
    Private Sub hymnalHymnColor_Click(sender As Object, e As EventArgs) Handles HymnalHymnColorBtn.Click
        ChangeColor(textBoxDictionary.Item("hymnalHymns"))
    End Sub
    Private Sub hymnalHymnFontBtn_Click(sender As Object, e As EventArgs) Handles HymnalHymnFontBtn.Click
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

    Private Sub OpenPrayerRequestsWindow_Click(sender As Object, e As EventArgs) Handles EditPRBtn.Click
        prayerRequestsWindow.Show()
    End Sub


    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If ShowBreakBtn.Checked Then
            'update time on break slide
            textBoxDictionary.Item("time").Text = DateTime.Now.ToString("HH:mm:ss")
        End If
    End Sub

    Private Sub Titles_KeyDown(sender As Object, e As KeyEventArgs) Handles EnglishTitleTxt.KeyDown, ChineseTitleTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            UpdateTitle_Click(sender, e)
            'Mute ding sound from windows
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub VerseTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles VerseTxt.KeyDown
        'handling both when chapter and verse enter key pressed
        If e.KeyCode = Keys.Enter Then
            UpdateVerse()
            If VerseTxt.Text IsNot "" Then
                BookTxt.Focus()
            End If
            'Mute ding sound from windows
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub Chapter_KeyDown(sender As Object, e As KeyEventArgs) Handles ChapterTxt.KeyDown
        'handling both when chapter and verse enter key pressed
        If e.KeyCode = Keys.Enter Then
            If ChapterTxt.Text IsNot "" Then
                VerseTxt.Focus()
            End If
            'Mute ding sound from windows
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub ServiceType_KeyDown(sender As Object, e As KeyEventArgs) Handles ServiceTypeTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            updateServiceTypes()
            'Mute ding sound from windows
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub updateServiceTypes()
        Dim textBoxKeys As String() = {"serviceType", "serviceType1", "serviceType2", "serviceType3"}
        For Each textBoxKey As String In textBoxKeys
            If textBoxDictionary.ContainsKey(textBoxKey) Then
                textBoxDictionary(textBoxKey).Text = ServiceTypeTxt.Text
            End If
        Next
    End Sub

    'Method that handles the key down event on the BookBox text box
    'When key is etner, handles empty string or incorrect input
    Private Sub BookBox_KeyDown(sender As Object, e As KeyEventArgs) Handles BookTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            If BookTxt.Text = "" Then
                ' Handles when book box is empty
                showTitlesOnly()
                textBoxDictionary.Item("englishBook").Text = " "
                textBoxDictionary.Item("chineseBook").Text = " "
                textBoxDictionary.Item("chapterAndVerse").Text = " "
                VerseTxt.Text = ""
                ChapterTxt.Text = ""
            ElseIf BookTxt.SelectedIndex <> -1 Then
                'Focus onto chapter text box
                ChapterTxt.Focus()
            End If
        End If
    End Sub
    Private Sub ChapterTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles ChapterTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            ChapterTxt.DeselectAll()
            VerseTxt.Focus()
        End If
    End Sub
    Private Sub VerseTxt_GotFocus(sender As Object, e As EventArgs) Handles VerseTxt.GotFocus
        ChapterTxt.DeselectAll()
        VerseTxt.SelectAll()
    End Sub
    Private Sub ChapterTxt_GotFocus(sender As Object, e As EventArgs) Handles ChapterTxt.GotFocus
        ChapterTxt.SelectAll()
    End Sub
    Private Sub Show_AN_Click(sender As Object, e As EventArgs) Handles EditAnnouncementsBtn.Click
        announcementsWindow.Show()
    End Sub

    Private Sub edtHC_Click(sender As Object, e As EventArgs) Handles EditHCBtn.Click
        HolyCommunion.Show()
    End Sub

    Private Sub clearbtn_Click(sender As Object, e As EventArgs) Handles ResetAllBtn.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to reset all sermon details?", "Confirm Reset", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            ResetServiceDetails()
            ShowBreakBtn.Checked = True
        End If

    End Sub

    Private Sub ServiceTimesBtn_Click(sender As Object, e As EventArgs) Handles EditTimetableBtn.Click
        serviceTimesWindow.Show()
    End Sub


    'Following 5 methods deal with moving the chinese and english title up or down to create more/less spacing
    'Needed when English title takes two or more lines
    Private Sub moveUp(textBox As PowerPoint.Shape)
        If textBox.Top >= 5 Then
            textBox.Top = textBox.Top - 5
        End If
    End Sub

    Private Sub moveDown(textBox As PowerPoint.Shape)
        If textBox.Top <= 400 Then
            textBox.Top = textBox.Top + 5
        End If
    End Sub

    Private Sub MoveShapeByOffset(shapeIndex As Integer, offset As Integer)
        Dim targetShape As PowerPoint.Shape = Nothing

        If ShowSermonHymnsBtn.Checked Then
            targetShape = slideDictionary.Item("sermonHymnsSlide").Shapes(shapeIndex)
        ElseIf ShowVersesBtn.Checked Then
            targetShape = slideDictionary.Item("bibleVersesSlide").Shapes(shapeIndex)
        End If

        If targetShape IsNot Nothing Then
            If offset > 0 Then
                moveDown(targetShape)
            ElseIf offset < 0 Then
                moveUp(targetShape)
            End If
        End If
    End Sub

    Private Sub moveEnglishDown_Click(sender As Object, e As EventArgs) Handles EnglishMoveDownBtn.Click
        MoveShapeByOffset(1, 1)
    End Sub

    Private Sub moveEnglishUp_Click(sender As Object, e As EventArgs) Handles EnglishMoveUpBtn.Click
        MoveShapeByOffset(1, -1)
    End Sub

    Private Sub moveChineseUp_Click(sender As Object, e As EventArgs) Handles ChineseMoveUpBtn.Click
        MoveShapeByOffset(2, -1)
    End Sub

    Private Sub moveChineseDown_Click(sender As Object, e As EventArgs) Handles ChineseMoveDownBtn.Click
        MoveShapeByOffset(2, 1)
    End Sub

    Private Sub minForm_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub settingsBtn_Click(sender As Object, e As EventArgs) Handles SettingsBtn.Click
        SettingsForm.Show()
    End Sub

    Private Sub ServiceType_SelectedValueChanged(sender As Object, e As EventArgs) Handles ServiceTypeTxt.SelectedValueChanged
        updateServiceTypes()
    End Sub

    ' -----------------------------------------------------------------------------------------------------------------------------------------
    ' FOLLOWING METHODS HANDLE FORM DRAGGING
    ' -----------------------------------------------------------------------------------------------------------------------------------------
    'Add handlers to specific controls, passing objects back to superclass
    'All passed controls will allow the window to move as the mouse is dragged on it
    Private Sub navBar_MouseDown(sender As Object, e As MouseEventArgs) Handles navBar.MouseDown, HeaderLogo.MouseDown
        MyBase.Form1_MouseDown(sender, e)
    End Sub
    Private Sub navBar_MouseUp(sender As Object, e As MouseEventArgs) Handles navBar.MouseUp, HeaderLogo.MouseUp
        MyBase.Form1_MouseUp(sender, e)
    End Sub
    Private Sub navBar_MouseMove(sender As Object, e As MouseEventArgs) Handles navBar.MouseMove, HeaderLogo.MouseMove
        MyBase.Form1_MouseMove(sender, e)
    End Sub
End Class