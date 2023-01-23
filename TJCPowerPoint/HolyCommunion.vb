Imports Microsoft
Imports Microsoft.Office.Interop
Imports TJCPowerPoint.NativeConstants, TJCPowerPoint.NativeMethods, TJCPowerPoint.NativeStructs
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

Public Class HolyCommunion
    Private slideNumber As Integer
    Private highlightedParagraph As Integer
    Private prevHighlightedPar As Integer
    Private hymnTextBox As PowerPoint.TextRange

    'Method called when the form is initially created
    Private Sub onCreate(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bread As String
        Dim cup As String
        If My.Computer.FileSystem.FileExists(MainProgram.CurrentDirectory + "\Files\bread.txt") = True Then
            bread = My.Computer.FileSystem.ReadAllText(MainProgram.CurrentDirectory + "\Files\bread.txt")
            breadTxt.Text = bread
        End If
        If My.Computer.FileSystem.FileExists(MainProgram.CurrentDirectory + "\Files\cup.txt") = True Then
            cup = My.Computer.FileSystem.ReadAllText(MainProgram.CurrentDirectory + "\Files\cup.txt")
            cupTxt.Text = cup
        End If

        Me.aeroEnabled = False
        slideNumber = MainProgram.slideDictionary.Item("holyCommunion").SlideNumber
        highlightedParagraph = 1
        hymnTextBox = MainProgram.textBoxDictionary.Item("HChymns")
        HymnNos.Text = "Enter Hymn"
    End Sub

    'Method handling when form is closed
    Private Sub HCClose_Click(sender As Object, e As EventArgs) Handles HCClose.Click, closeForm.Click
        Me.Hide()
    End Sub

    Private Sub minForm_Click(sender As Object, e As EventArgs) Handles minForm.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub updateHC_Click(sender As Object, e As EventArgs) Handles updateHC.Click
        MainProgram.textBoxDictionary.Item("bread").Text = breadTxt.Text
        MainProgram.textBoxDictionary.Item("cup").Text = cupTxt.Text
        Try
            My.Computer.FileSystem.WriteAllText(MainProgram.CurrentDirectory + "\Files\bread.txt", breadTxt.Text, False)
            My.Computer.FileSystem.WriteAllText(MainProgram.CurrentDirectory + "\Files\cup.txt", cupTxt.Text, False)
            MessageBox.Show("Update Successful", "Update Successful")

        Catch ex As Exception
            MessageBox.Show("Update Unsuccessful. Please try again", "Update Unsuccessful")
        End Try

    End Sub

    Private Sub goToHCSlide_Click(sender As Object, e As EventArgs) Handles goToHCSlide.Click
        MainProgram.goToHCBtn.Checked = True
    End Sub


    'HYMN SELECTION --------------------------------------------
    Private Sub updateHymns(textBox As PowerPoint.TextRange)
        Dim hymns As String = ""
        Dim count = HymnsSelectionBox.Items.Count
        Dim index = HymnsSelectionBox.SelectedIndex
        If count = 0 Then
            textBox.Text = " "
        End If
        If count >= 3 Then
            'if selected index less than total items -4 then insert selected hymn and 2 hymns after
            If index < count - 3 Then
                hymns = HymnsSelectionBox.Items(index) + vbCr + HymnsSelectionBox.Items(index + 1) + vbCr + HymnsSelectionBox.Items(index + 2)
            Else
                'insert last three hymns
                hymns = HymnsSelectionBox.Items(count - 3) + vbCr + HymnsSelectionBox.Items(count - 2) + vbCr + HymnsSelectionBox.Items(count - 1)
            End If
        Else
            'if there are two or less hymns
            hymns = String.Join(vbCr, HymnsSelectionBox.Items.Cast(Of String))
        End If
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
        'return if no change in hymns and highlighted paragraph
        If textBox.Text.ToString().Equals(hymns) And prevHighlightedPar = highlightedParagraph Then
            Return
        End If
        'updating hymns on holy communion slide maximum of first three hymn
        If prevHighlightedPar = 1 Or highlightedParagraph = 1 Then
            'Issue of when changing text, powerpoint assumes formatting of first paragraph for all
            'if highlghted paragraph second paragraph reset styles of first paragraph then change text
            resetParagraph(textBox, 1)
        End If
        textBox.Text = hymns
        highlightCurrentHymn(textBox)
        prevHighlightedPar = highlightedParagraph
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
            HymnsSelectionBox.Items.Clear()
            Return
        End If
        If selectedIndex = size - 1 Then
            'if hymn is last hymn selected, reselect last hymn
            HymnsSelectionBox.Items.RemoveAt(selectedIndex)
            HymnsSelectionBox.SelectedIndex = size - 2
            Return
        End If
        'for all other cases, select the next hymn at the same index
        HymnsSelectionBox.Items.RemoveAt(selectedIndex)
        HymnsSelectionBox.SelectedIndex = selectedIndex
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
            textbox.Paragraphs(paragraph).Font.Size = 45
            textbox.Paragraphs(paragraph).Font.Bold = Office.Core.MsoTriState.msoFalse
        End If
    End Sub

    Private Sub highlightParagraph(textbox As PowerPoint.TextRange, paragraph As Integer)
        If paragraph <= textbox.Paragraphs.Count And textbox.Paragraphs(paragraph).Font.Bold <> Office.Core.MsoTriState.msoTrue Then
            textbox.Paragraphs(paragraph).Font.Color.TintAndShade = 0
            textbox.Paragraphs(paragraph).Font.Size = 75
            textbox.Paragraphs(paragraph).Font.Bold = Office.Core.MsoTriState.msoTrue
        End If
    End Sub

    Private Sub delHymnBtn_Click(sender As Object, e As EventArgs) Handles delHymnBtn.Click
        'handles deleting 
        'updating hymns on holy communion slide
        removeCurrentHymn(hymnTextBox)
        If HymnsSelectionBox.Items.Count = 0 Then
            hymnTextBox.Text = " "
        End If
    End Sub
    Private Sub HymnColorBtn_Click(sender As Object, e As EventArgs) Handles HymnColorBtn.Click
        MainProgram.ChangeColor(MainProgram.textBoxDictionary.Item("HChymns"))
    End Sub

    Private Sub HymnFontBtn_Click(sender As Object, e As EventArgs) Handles HymnFontBtn.Click
        MainProgram.ChangeFont(MainProgram.textBoxDictionary.Item("HChymns"))
    End Sub

    Private Sub HymnsSelectionBox_KeyDown(sender As Object, e As KeyEventArgs) Handles HymnsSelectionBox.KeyDown
        If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete Then
            'handles deleting 
            'updating hymns on holy communion slide
            removeCurrentHymn(hymnTextBox)
            If HymnsSelectionBox.Items.Count = 0 Then
                hymnTextBox.Text = " "
            End If
        End If
    End Sub
    Private Sub HymnsSelectionBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles HymnsSelectionBox.SelectedIndexChanged
        If HymnsSelectionBox.SelectedIndex = -1 Then
            Return
        End If
        'updating hymns on holy communion slide
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
    Private Sub HymnNos_GotFocus(sender As Object, e As EventArgs) Handles HymnNos.GotFocus
        HymnNos.Text = ""
    End Sub
    Private Sub HymnNos_LostFocus(sender As Object, e As EventArgs) Handles HymnNos.LostFocus
        HymnNos.Text = "Enter Hymn"
    End Sub


    'FOLLOWING METHODS DEAL WITH FORM MOVEMENT WHEN MOUSE DRAGGED ON TOP NAV BAR
    'https://stackoverflow.com/questions/17392088/allow-a-user-to-move-a-borderless-window
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles navBar.MouseDown, header.MouseDown

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles navBar.MouseUp, header.MouseUp

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles navBar.MouseMove, header.MouseMove

        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub




    'FOLLOWING METHODS DEAL WITH CREATING WINDOW AS A BORDERLESS DROP SHADOW WINDOWS FORM
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
        If Environment.OSVersion.Version.Major >= 6 Then
            Dim enabled As Integer = 0
            Dim response As Integer = NativeMethods.DwmIsCompositionEnabled(enabled)
            aeroEnabled = (enabled = 1)
        Else
            aeroEnabled = False
        End If
    End Sub

End Class