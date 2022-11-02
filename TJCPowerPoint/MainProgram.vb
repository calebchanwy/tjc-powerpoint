Imports Office = Microsoft.Office.Core
Imports PowerPoint = Microsoft.Office.Interop.PowerPoint
Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Xml
Imports System.Text.RegularExpressions
Imports System.Threading

Public Class MainProgram
    Dim ppApp As New PowerPoint.Application
    Public ppPres As PowerPoint.Presentation
    Public Current As String = Directory.GetCurrentDirectory()
    Dim PrayerRequests As New PrayerRequests
    Dim Writer As XmlTextWriter = Nothing
    Dim RecentFile As String

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


    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MakeFolder()
        LoadPres()
        HandleAnnouncements()
        HandlePR()
        LoadHC()
        LoadPrayerImage()
        LoadTimetableImg()
        'RecentFile = Directory.GetFiles(Current + "\Files\ServiceRecords").OrderByDescending(Function(f) New FileInfo(f).LastWriteTime).First().ToString
        'Dim RecentXML As New XmlDocument()
        'RecentXML.Load(RecentFile)
        'EnglishTitle.Text = RecentXML.DocumentElement.SelectSingleNode("EnglishTitle").InnerText
        'ChineseTitle.Text = RecentXML.DocumentElement.SelectSingleNode("ChineseTitle").InnerText
        'HymnNos.Text = RecentXML.DocumentElement.SelectSingleNode("Hymn").InnerText
        'default opening auto fill
        ShowHymn.Checked = True
        EnglishTitle.Text = "English Sermon Title"
        ChineseTitle.Text = "中文講道題目"
    End Sub


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

    Public Function MakeFolder()
        If Directory.Exists("\Files") = False Then
            My.Computer.FileSystem.CreateDirectory(Current + "\Files")
        End If

        'If Directory.Exists("\Files\ServiceRecords") = False Then
        '    My.Computer.FileSystem.CreateDirectory(Current + "\Files\ServiceRecords")
        '    System.IO.File.WriteAllBytes(Current + "\Files\ServiceRecords\1_Jan_1990_000000.xml", My.Resources.XML)
        'End If

        If My.Computer.FileSystem.FileExists(Current + "\Files\ServiceWidescreen.pptx") = False Then
            System.IO.File.WriteAllBytes(Current + "\Files\ServiceWidescreen.pptx", My.Resources.ServiceWidescreen)
        End If
        Return True
    End Function
    Public Function LoadPres()
        ppApp = CreateObject("PowerPoint.Application")
        ppPres = ppApp.Presentations.Open(Current + "\Files\ServiceWidescreen.pptx", [ReadOnly]:=Office.MsoTriState.msoFalse, WithWindow:=Office.MsoTriState.msoFalse)
        ppPres.Slides(1).Name = "Service/Hymnal"
        ppPres.Slides(2).Name = "Prayer Requests - Image"
        ppPres.Slides(3).Name = "Prayer Requests"
        ppPres.Slides(4).Name = "Announcements"
        ppPres.Slides(5).Name = "Holy Communion"
        ppPres.Slides(6).Name = "How To Pray"
        ppPres.Slides(7).Name = "Turn Off All Devices"
        ppPres.Slides(8).Name = "Service Timetable"
        For i As Integer = 1 To ppPres.Slides.Count
            SlideTrack.Items.Add(ppPres.Slides(i).Name)
        Next
        'InSlide1: 1-English Title, 2 - Chinese Title, 3 - HymnHeader, 4 - Hymns, 5 - BibleHeader, 6 - EnglishBook, 7 - ChineseBook, 8 - Chapter+Verse, 10 - Service Type
        ppPres.Slides(1).Shapes(1).TextFrame.TextRange.Text = " "
        ppPres.Slides(1).Shapes(2).TextFrame.TextRange.Text = " "
        ppPres.Slides(1).Shapes(3).TextFrame.TextRange.Text = "Hymns 詩"
        ppPres.Slides(1).Shapes(4).TextFrame.TextRange.Text = " "
        ppPres.Slides(1).Shapes(5).TextFrame.TextRange.Text = "Bible Verse 經文"
        ppPres.Slides(1).Shapes(6).TextFrame.TextRange.Text = " "
        ppPres.Slides(1).Shapes(7).TextFrame.TextRange.Text = " "
        ppPres.Slides(1).Shapes(8).TextFrame.TextRange.Text = " "
        ppPres.Slides(1).Shapes(10).TextFrame.TextRange.Text = " "
        ppPres.Slides(1).Shapes(5).Visible = Office.MsoTriState.msoFalse
        HandleSettings()
        ppPres.SlideShowSettings.Run()
        SlideTrack.SelectedIndex = 0
        Return True
    End Function

    Public Function LoadHC()
        Dim bread As String
        Dim cup As String
        If My.Computer.FileSystem.FileExists(Current + "\Files\bread.txt") = True Then
            bread = My.Computer.FileSystem.ReadAllText(Current + "\Files\bread.txt")
            ppPres.Slides(5).Shapes(1).TextFrame.TextRange.Text = bread
        End If
        If My.Computer.FileSystem.FileExists(Current + "\Files\cup.txt") = True Then
            cup = My.Computer.FileSystem.ReadAllText(Current + "\Files\cup.txt")
            ppPres.Slides(5).Shapes(2).TextFrame.TextRange.Text = cup
        End If
        Return True
    End Function

    Public Function LoadPrayerImage()
        If My.Computer.FileSystem.FileExists(Current + "\Files\prayerImgDir.txt") = False Then
            System.IO.File.WriteAllText(Current + "\Files\prayerImgDir.txt", "")
        Else
            Dim directory As String
            directory = My.Computer.FileSystem.ReadAllText(Current + "\Files\prayerImgDir.txt")
            If My.Computer.FileSystem.FileExists(directory) = True Then
                ppPres.Slides(2).Shapes.AddPicture(directory, False, True, 0, 0, ppPres.PageSetup.SlideWidth, ppPres.PageSetup.SlideHeight)
            End If
        End If
        Return True
    End Function

    Public Function LoadTimetableImg()
        If My.Computer.FileSystem.FileExists(Current + "\Files\timetableDir.txt") = False Then
            System.IO.File.WriteAllText(Current + "\Files\timetableDir.txt", "")
        Else
            Dim directory As String
            directory = My.Computer.FileSystem.ReadAllText(Current + "\Files\timetableDir.txt")
            If My.Computer.FileSystem.FileExists(directory) = True Then
                ppPres.Slides(8).Shapes.AddPicture(directory, False, True, 0, 0, ppPres.PageSetup.SlideWidth, ppPres.PageSetup.SlideHeight)
            End If
        End If
        Return True
    End Function
    Public Function LoadSettings(str As String)
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
                If two = "3" Then
                    PrayerRequests.PrayerRequestTxt.ForeColor = Color.FromArgb(Convert.ToInt32(FontColor))
                ElseIf two = "4" Then
                    Announcements.AnnouncementTxt.ForeColor = Color.FromArgb(Convert.ToInt32(FontColor))
                End If
            Else
                Dim BGColor As String = Mid(str, InStr(str, "=") + 1, Len(str) - InStr(str, "="))
                ppPres.Slides(two).Background.Fill.ForeColor.RGB = Color.FromArgb(Convert.ToInt32(BGColor)).ToArgb
                If two = "3" Then
                    Dim R As Integer = Color.FromArgb(Convert.ToInt32(BGColor)).R
                    Dim G As Integer = Color.FromArgb(Convert.ToInt32(BGColor)).G
                    Dim B As Integer = Color.FromArgb(Convert.ToInt32(BGColor)).B
                    PrayerRequests.PrayerRequestTxt.BackColor = Color.FromArgb(255, B, G, R)
                    PrayerRequests.Panel.BackColor = Color.FromArgb(255, B, G, R)
                ElseIf two = "4" Then
                    Dim R As Integer = Color.FromArgb(Convert.ToInt32(BGColor)).R
                    Dim G As Integer = Color.FromArgb(Convert.ToInt32(BGColor)).G
                    Dim B As Integer = Color.FromArgb(Convert.ToInt32(BGColor)).B
                    Announcements.AnnouncementTxt.BackColor = Color.FromArgb(255, B, G, R)
                    Announcements.Panel.BackColor = Color.FromArgb(255, B, G, R)
                End If
            End If
        End If
        Return True
    End Function
    Public Function HandleSettings()
        If My.Computer.FileSystem.FileExists(Current + "\Files\Settings.ini") Then
            Dim Settings As Array = File.ReadAllLines(Current + "\Files\Settings.ini")
            For Each str As String In Settings
                LoadSettings(str)
            Next
        Else
            File.WriteAllBytes(Current + "\Files\Settings.ini", My.Resources.Settings)
            Dim Settings As Array = File.ReadAllLines(Current + "\Files\Settings.ini")
            For Each str As String In Settings
                LoadSettings(str)
            Next
        End If
        Return True
    End Function
    Public Function HandleAnnouncements()
        If My.Computer.FileSystem.FileExists(Current + "\Files\Announcements.txt") Then
            Announcements.AnnouncementTxt.Text = File.ReadAllText(Current + "\Files\Announcements.txt", System.Text.Encoding.UTF32)
            ppPres.Slides(4).Shapes(1).TextFrame.TextRange.Text = Announcements.AnnouncementTxt.Text
        Else
            Using sw As StreamWriter = File.CreateText(Current + "\Files\Announcements.txt")
                sw.WriteLine(" ")
            End Using
            Announcements.AnnouncementTxt.Text = File.ReadAllText(Current + "\Files\Announcements.txt", System.Text.Encoding.UTF32)
            ppPres.Slides(4).Shapes(1).TextFrame.TextRange.Text = Announcements.AnnouncementTxt.Text
        End If
        Return True
    End Function
    Public Function HandlePR()
        If My.Computer.FileSystem.FileExists(Current + "\Files\PrayerRequests.txt") Then
            PrayerRequests.PrayerRequestTxt.Text = File.ReadAllText(Current + "\Files\PrayerRequests.txt", System.Text.Encoding.UTF32)
            ppPres.Slides(3).Shapes(1).TextFrame.TextRange.Text = PrayerRequests.PrayerRequestTxt.Text
        Else
            Using sw As StreamWriter = File.CreateText(Current + "\Files\PrayerRequests.txt")
                sw.WriteLine(" ")
            End Using
            PrayerRequests.PrayerRequestTxt.Text = File.ReadAllText(Current + "\Files\PrayerRequests.txt", System.Text.Encoding.UTF32)
            ppPres.Slides(3).Shapes(1).TextFrame.TextRange.Text = PrayerRequests.PrayerRequestTxt.Text
        End If
        Return True
    End Function
    Public Function ChangeFont(i As Integer, j As Integer)
        FontDialog.Font = New Font(ppPres.Slides(i).Shapes(j).TextFrame.TextRange.Font.Name.ToString, ppPres.Slides(i).Shapes(j).TextFrame.TextRange.Font.Size)
        If FontDialog.ShowDialog = DialogResult.OK Then
            ppPres.Slides(i).Shapes(j).TextFrame.TextRange.Font.Name = FontDialog.Font.Name
            ppPres.Slides(i).Shapes(j).TextFrame.TextRange.Font.Size = FontDialog.Font.Size
        End If
        Return True
    End Function
    Public Function ChangeColor(i As Integer, j As Integer)
        If ColorDialog.ShowDialog = DialogResult.OK Then
            Dim Red As Integer = Convert.ToInt32(ColorDialog.Color.R)
            Dim Green As Integer = Convert.ToInt32(ColorDialog.Color.G)
            Dim Blue As Integer = Convert.ToInt32(ColorDialog.Color.B)
            ppPres.Slides(i).Shapes(j).TextFrame.TextRange.Font.Color.RGB = Color.FromArgb(255, Blue, Green, Red).ToArgb
        End If
        Return True
    End Function
    Public Function GetFontAndColor(i As Integer, j As Integer)
        Dim Font As String
        Font = "[F" & i & j & "]=" + ppPres.Slides(i).Shapes(j).TextFrame.TextRange.Font.Name + "," + Convert.ToString(ppPres.Slides(i).Shapes(j).TextFrame.TextRange.Font.Size) +
            vbCrLf + "[C" & i & j & "]=" + Convert.ToString(ppPres.Slides(i).Shapes(j).TextFrame.TextRange.Font.Color.RGB)

        Return Font
    End Function

    '----------------------------FOLLOWING COMMENTED FUNCTIONS REDUNDANT AS NO LONGER SAVING SERVICE RECORDS -----------------------------

    'Public Function MakeXML()
    '    Dim Title As String = Replace(EnglishTitle.Text, " ", "_")
    '    Dim Name As String = Current + "\Files\ServiceRecords\" + Title + (DateTime.Now.ToString("_dd_MMMM_yyyy_HHmmss")) + ".xml"
    '    Dim writer As New XmlTextWriter(Name, System.Text.Encoding.UTF32)
    '    writer.WriteStartDocument(True)
    '    writer.Formatting = Formatting.Indented
    '    writer.Indentation = 2
    '    writer.WriteStartElement("ServiceRecord")
    '    writer.WriteStartElement("Time")
    '    writer.WriteString(DateTime.Now.ToString("HH:mm:ss"))
    '    writer.WriteEndElement()
    '    writer.WriteStartElement("EnglishTitle")
    '    writer.WriteString(EnglishTitle.Text)
    '    writer.WriteEndElement()
    '    writer.WriteStartElement("ChineseTitle")
    '    writer.WriteString(ChineseTitle.Text)
    '    writer.WriteEndElement()
    '    writer.WriteStartElement("Hymn")
    '    writer.WriteString(HymnNos.Text)
    '    writer.WriteEndElement()
    '    Return writer
    'End Function

    'Public Function WriteXML(writer As XmlTextWriter)
    '    Dim commaPos As Integer
    '    commaPos = InStr(BookBox.Text, ",")
    '    writer.WriteStartElement("Bible")
    '    writer.WriteStartElement("Book")
    '    writer.WriteStartElement("English")
    '    writer.WriteString(Mid(BookBox.Text, 1, commaPos - 1))
    '    writer.WriteEndElement()
    '    writer.WriteStartElement("Chinese")
    '    writer.WriteString(Mid(BookBox.Text, commaPos + 1))
    '    writer.WriteEndElement()
    '    writer.WriteStartElement("Chapter")
    '    writer.WriteString(ChapterTxt.Text)
    '    writer.WriteEndElement()
    '    writer.WriteStartElement("Verses")
    '    writer.WriteString(VerseTxt.Text)
    '    writer.WriteEndElement()
    '    writer.WriteEndElement()
    '    writer.WriteEndElement()
    '    Return True
    'End Function

    Private Sub EnglishFontBtn_Click(sender As Object, e As EventArgs) Handles EnglishFontBtn.Click
        ChangeFont(1, 1)
    End Sub
    Private Sub EnglishColorBtn_Click(sender As Object, e As EventArgs) Handles EnglishColorBtn.Click
        ChangeColor(1, 1)
    End Sub
    Private Sub ChineseFontBtn_Click(sender As Object, e As EventArgs) Handles ChineseFontBtn.Click
        ChangeFont(1, 2)
    End Sub
    Private Sub ChineseColorBtn_Click(sender As Object, e As EventArgs) Handles ChineseColorBtn.Click
        ChangeColor(1, 2)
    End Sub
    Private Sub HymnHDFont_Click(sender As Object, e As EventArgs) Handles HymnHDFont.Click
        ChangeFont(1, 3)
    End Sub
    Private Sub HymnHDColor_Click(sender As Object, e As EventArgs) Handles HymnHDColor.Click
        ChangeColor(1, 3)
    End Sub
    Private Sub HymnFontBtn_Click(sender As Object, e As EventArgs) Handles HymnFontBtn.Click
        ChangeFont(1, 4)
    End Sub
    Private Sub HymnColorBtn_Click(sender As Object, e As EventArgs) Handles HymnColorBtn.Click
        ChangeColor(1, 4)
    End Sub
    Private Sub BBibleHDFont_Click(sender As Object, e As EventArgs) Handles BibleHDFont.Click
        ChangeFont(1, 5)
    End Sub

    Private Sub BibleHDColor_Click(sender As Object, e As EventArgs) Handles BibleHDColor.Click
        ChangeColor(1, 5)
    End Sub
    Private Sub EnglishBookFontBtn_Click(sender As Object, e As EventArgs) Handles EnglishBookFontBtn.Click
        ChangeFont(1, 6)
    End Sub
    Private Sub EnglishBookColorBtn_Click(sender As Object, e As EventArgs) Handles EnglishBookColorBtn.Click
        ChangeColor(1, 6)
    End Sub
    Private Sub ChineseBookFontBtn_Click(sender As Object, e As EventArgs) Handles ChineseBookFontBtn.Click
        ChangeFont(1, 7)
    End Sub
    Private Sub ChineseBookColorBtn_Click(sender As Object, e As EventArgs) Handles ChineseBookColorBtn.Click
        ChangeColor(1, 7)
    End Sub
    Private Sub CVFontBtn_Click(sender As Object, e As EventArgs) Handles CVFontBtn.Click
        ChangeFont(1, 8)
    End Sub
    Private Sub CVColorBtn_Click(sender As Object, e As EventArgs) Handles CVColorBtn.Click
        ChangeColor(1, 8)
    End Sub
    Private Sub ServiceTypeFontBtn_Click(sender As Object, e As EventArgs) Handles ServiceTypeFontBtn.Click
        ChangeFont(1, 10)
    End Sub

    Private Sub ServiceTypeColorBtn_Click(sender As Object, e As EventArgs) Handles ServiceTypeColorBtn.Click
        ChangeColor(1, 10)
    End Sub
    Private Sub SlideTrack_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SlideTrack.SelectedIndexChanged
        ppPres.SlideShowWindow.View.GotoSlide(SlideTrack.SelectedIndex + 1)
    End Sub

    Private Sub ShowHymn_CheckedChanged(sender As Object, e As EventArgs) Handles ShowHymn.CheckedChanged
        If ShowHymn.Checked = True Then
            ShowVerses.Checked = False
            ppPres.Slides(1).Shapes(5).Visible = Office.MsoTriState.msoFalse
            ppPres.Slides(1).Shapes(6).Visible = Office.MsoTriState.msoFalse
            ppPres.Slides(1).Shapes(7).Visible = Office.MsoTriState.msoFalse
            ppPres.Slides(1).Shapes(8).Visible = Office.MsoTriState.msoFalse
            'check if hymnal or not
            If HymnalTitle.Text = "Change Title To ""Hymnal""" Then
                ppPres.Slides(1).Shapes(3).Visible = Office.MsoTriState.msoTrue
            Else
                ppPres.Slides(1).Shapes(3).Visible = Office.MsoTriState.msoFalse
            End If
            ppPres.Slides(1).Shapes(4).Visible = Office.MsoTriState.msoTrue
            ppPres.Slides(1).Shapes(6).TextFrame.TextRange.Text = ""
            ppPres.Slides(1).Shapes(7).TextFrame.TextRange.Text = ""
            ppPres.Slides(1).Shapes(8).TextFrame.TextRange.Text = ""
            BookBox.Text = ""
            VerseTxt.Text = ""
            ChapterTxt.Text = ""
            ppPres.Slides(1).Shapes(4).TextFrame.TextRange.Text = HymnNos.Text
        ElseIf ShowHymn.Checked = False And ShowVerses.Checked = False Then
            'user has tried to uncheck hymn, whilst not showing verses
            ShowHymn.Checked = True
        End If
    End Sub
    Private Sub ShowVerses_CheckedChanged(sender As Object, e As EventArgs) Handles ShowVerses.CheckedChanged
        If ShowVerses.Checked = True Then
            ShowHymn.Checked = False
            ppPres.Slides(1).Shapes(3).Visible = Office.MsoTriState.msoFalse
            ppPres.Slides(1).Shapes(4).Visible = Office.MsoTriState.msoFalse
            ppPres.Slides(1).Shapes(5).Visible = Office.MsoTriState.msoTrue
            ppPres.Slides(1).Shapes(6).Visible = Office.MsoTriState.msoTrue
            ppPres.Slides(1).Shapes(7).Visible = Office.MsoTriState.msoTrue
            ppPres.Slides(1).Shapes(8).Visible = Office.MsoTriState.msoTrue
        ElseIf ShowVerses.Checked = False And ShowHymn.Checked = False Then
            'user has tried to uncheck verses, whilst not showing hymns
            ShowVerses.Checked = True
        End If
    End Sub
    Private Sub UpdateVerse_Click(sender As Object, e As EventArgs) Handles UpdateVerse.Click
        'if called when show hymns is checked
        'automatically change to show verses
        If ShowVerses.Checked = False Then
            ShowVerses.Checked = True
            ShowHymn.Checked = False
        End If
        If VerseTxt.Text = "" And BookBox.Text = "" And ChapterTxt.Text = "" Then
            ppPres.Slides(1).Shapes(8).TextFrame.TextRange.Text = ""
        ElseIf BookBox.SelectedIndex <> -1 Then
            Dim commaPos As Integer
            commaPos = InStr(BookBox.Text, ",")
            ppPres.Slides(1).Shapes(6).TextFrame.TextRange.Text = Mid(BookBox.Text, 1, commaPos - 1)
            ppPres.Slides(1).Shapes(7).TextFrame.TextRange.Text = Mid(BookBox.Text, commaPos + 1)
            ppPres.Slides(1).Shapes(8).TextFrame.TextRange.Text = ChapterTxt.Text + " : " + VerseTxt.Text

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
        ppPres.Slides(1).Shapes(1).TextFrame.TextRange.Text = EnglishTitle.Text
        ppPres.Slides(1).Shapes(2).TextFrame.TextRange.Text = ChineseTitle.Text
        HymnalTitle.Text = "Change Title To ""Hymnal"""
        ppPres.Slides(1).Shapes(4).Top = 260
        If ShowHymn.Checked Then
            ppPres.Slides(1).Shapes(3).Visible = True
        End If

    End Sub

    Private Sub HymnalTitle_Click(sender As Object, e As EventArgs) Handles HymnalTitle.Click
        If HymnalTitle.Text = "Change Title To ""Hymnal""" Then
            ppPres.Slides(1).Shapes(1).TextFrame.TextRange.Text = "Hymnal"
            ppPres.Slides(1).Shapes(2).TextFrame.TextRange.Text = "詩頌"
            HymnalTitle.Text = "Change Titles Back To Service Titles"
            ppPres.Slides(1).Shapes(3).Visible = False
            ppPres.Slides(1).Shapes(4).Top = 175

        Else
            ppPres.Slides(1).Shapes(1).TextFrame.TextRange.Text = EnglishTitle.Text
            ppPres.Slides(1).Shapes(2).TextFrame.TextRange.Text = ChineseTitle.Text
            HymnalTitle.Text = "Change Title To ""Hymnal"""
            ppPres.Slides(1).Shapes(3).Visible = True
            ppPres.Slides(1).Shapes(4).Top = 260
        End If


    End Sub

    Private Sub HymnChange_Click(sender As Object, e As EventArgs) Handles HymnChange.Click
        'if called when show hymns is checked
        'automatically change to show verses
        If ShowHymn.Checked = False Then
            ShowHymn.Checked = True
            ShowVerses.Checked = False
        End If
        ppPres.Slides(1).Shapes(4).TextFrame.TextRange.Text = HymnNos.Text
        If HymnalTitle.Text = "Change Title To ""Hymnal""" Then
            ppPres.Slides(1).Shapes(4).Top = 260
            ppPres.Slides(1).Shapes(3).Visible = True
        Else
            ppPres.Slides(1).Shapes(3).Visible = False
            ppPres.Slides(1).Shapes(4).Top = 175
        End If

        'updating hymns on holy communion slide
        'replacing all new lines with commas
        ppPres.Slides(5).Shapes(1).TextFrame.TextRange.Text = "Hymns 詩: " + HymnNos.Text.Replace(vbCrLf, ", ")

    End Sub
    Private Sub ShowPR_Click(sender As Object, e As EventArgs) Handles ShowPR.Click
        PrayerRequests.Show()
    End Sub
    Private Sub BGColor_Click(sender As Object, e As EventArgs) Handles BGColor.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            Dim CurrentSlide As Integer = ppPres.SlideShowWindow.View.CurrentShowPosition
            Dim Red As Integer = Convert.ToInt32(ColorDialog.Color.R)
            Dim Green As Integer = Convert.ToInt32(ColorDialog.Color.G)
            Dim Blue As Integer = Convert.ToInt32(ColorDialog.Color.B)
            ppPres.Slides(CurrentSlide).Background.Fill.ForeColor.RGB = Color.FromArgb(255, Blue, Green, Red).ToArgb
        End If
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click

        Me.Close()
    End Sub
    Private Sub SaveSettings_Click(sender As Object, e As EventArgs) Handles SaveSettings.Click

        Dim CurrentSettings As String
        CurrentSettings =
        GetFontAndColor(1, 1) & vbCrLf &
        GetFontAndColor(1, 2) & vbCrLf &
        GetFontAndColor(1, 4) & vbCrLf &
        GetFontAndColor(1, 9) & vbCrLf &
        GetFontAndColor(1, 6) & vbCrLf &
        GetFontAndColor(1, 7) & vbCrLf &
        GetFontAndColor(1, 8) & vbCrLf &
        GetFontAndColor(3, 1) & vbCrLf &
        GetFontAndColor(3, 2) & vbCrLf &
        GetFontAndColor(4, 1) & vbCrLf &
        GetFontAndColor(4, 2)
        For i As Integer = 1 To 8
            If i <> 3 Then
                CurrentSettings = CurrentSettings + vbCrLf + "[C" & i & "]=" + Convert.ToString(ppPres.Slides(i).Background.Fill.ForeColor.RGB)
            End If
        Next
        Try
            My.Computer.FileSystem.WriteAllText(Current + "\Files\Settings.ini", CurrentSettings, False)
            MessageBox.Show("Save Successful", "Save Successful")
        Catch ex As Exception
            MessageBox.Show("Save Unsuccessful", "Save Unsuccessful")
        End Try
    End Sub

    Private Sub OpenFolder_Click(sender As Object, e As EventArgs) Handles OpenFolder.Click
        Process.Start(Current + "\Files")
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Time.Text = "Time: " + DateTime.Now.ToString("HH:mm:ss  dddd, dd MMMM yyyy")
    End Sub

    Private Sub Titles_KeyDown(sender As Object, e As KeyEventArgs) Handles EnglishTitle.KeyDown, ChineseTitle.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call UpdateTitle_Click(sender, e)
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
            ppPres.Slides(1).Shapes(10).TextFrame.TextRange.Text = ServiceType.Text
        End If
    End Sub

    Private Sub BookBox_KeyDown(sender As Object, e As KeyEventArgs) Handles BookBox.KeyDown
        ' handles when book box is empty, assumes that no verse or chapter should be shown
        If BookBox.Text Is "" And e.KeyCode = Keys.Enter Then
            ppPres.Slides(1).Shapes(6).TextFrame.TextRange.Text = ""
            ppPres.Slides(1).Shapes(7).TextFrame.TextRange.Text = ""
            ppPres.Slides(1).Shapes(8).TextFrame.TextRange.Text = ""
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
        Try
            Dim ofd = New OpenFileDialog()
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Downloads"
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"
            If ofd.ShowDialog = DialogResult.OK Then
                ppPres.Slides(2).Shapes.AddPicture(ofd.FileName, False, True, 0, 0, ppPres.PageSetup.SlideWidth, ppPres.PageSetup.SlideHeight)
                System.IO.File.WriteAllText(Current + "\Files\prayerImgDir.txt", ofd.FileName)
                MessageBox.Show("Prayer Image Was Successfully Updated", "Success")
            Else
                MessageBox.Show("Prayer Image Was Not Successfully Updated. Please Try Again", "Error")
            End If


        Catch ex As Exception
            MessageBox.Show("Prayer Image Was Not Successfully Updated. Please Try Again", "Error")
        End Try

    End Sub

    Private Sub edtHC_Click(sender As Object, e As EventArgs) Handles edtHC.Click
        HolyCommunion.Show()
    End Sub

    Private Sub clearbtn_Click(sender As Object, e As EventArgs) Handles clearbtn.Click
        'resetting bible verses
        ppPres.Slides(1).Shapes(6).TextFrame.TextRange.Text = ""
        ppPres.Slides(1).Shapes(7).TextFrame.TextRange.Text = ""
        ppPres.Slides(1).Shapes(8).TextFrame.TextRange.Text = ""
        BookBox.Text = ""
        VerseTxt.Text = ""
        ChapterTxt.Text = ""
        'resetting titles
        ppPres.Slides(1).Shapes(1).TextFrame.TextRange.Text = ""
        ppPres.Slides(1).Shapes(2).TextFrame.TextRange.Text = ""
        EnglishTitle.Text = ""
        ChineseTitle.Text = ""
        EnglishTitle.Text = "English Sermon Title"
        ChineseTitle.Text = "中文講道題目"
        'Resetting Hymns
        ppPres.Slides(1).Shapes(4).TextFrame.TextRange.Text = ""
        HymnNos.Text = ""
        Call HymnChange_Click(sender, e)
    End Sub

    Private Sub ServiceTimesBtn_Click(sender As Object, e As EventArgs) Handles ServiceTimesBtn.Click
        Try
            Dim ofd = New OpenFileDialog()
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Downloads"
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"
            If ofd.ShowDialog = DialogResult.OK Then
                ppPres.Slides(8).Shapes.AddPicture(ofd.FileName, False, True, 0, 0, ppPres.PageSetup.SlideWidth, ppPres.PageSetup.SlideHeight)
                System.IO.File.WriteAllText(Current + "\Files\timetableDir.txt", ofd.FileName)
                MessageBox.Show("Service Timetable Was Successfully Updated", "Success")
            Else
                MessageBox.Show("Service Timetable Was Not Successfully Updated. Please Try Again", "Error")
            End If


        Catch ex As Exception
            MessageBox.Show("Service Timetable Was Not Successfully Updated. Please Try Again", "Error")
        End Try
    End Sub

    Private Sub minForm_Click(sender As Object, e As EventArgs) Handles minForm.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub closeForm_Click(sender As Object, e As EventArgs) Handles closeForm.Click
        Me.Close()
    End Sub



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

    Private Sub moveChineseUp_Click(sender As Object, e As EventArgs) Handles moveChineseUp.Click
        ppPres.Slides(1).Shapes(2).Top = ppPres.Slides(1).Shapes(2).Top - 10
    End Sub

    Private Sub moveChineseDown_Click(sender As Object, e As EventArgs) Handles moveChineseDown.Click
        ppPres.Slides(1).Shapes(2).Top = ppPres.Slides(1).Shapes(2).Top + 10
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
