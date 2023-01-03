Imports Microsoft
Imports Microsoft.Office.Interop
Imports TJCPowerPoint.NativeConstants, TJCPowerPoint.NativeMethods, TJCPowerPoint.NativeStructs
Public Class HolyCommunion
    Private slideNumber As Integer
    Private highlightedParagraph As Integer

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
        slideNumber = 7
        highlightedParagraph = 1
    End Sub

    'Method handling when form is closed
    Private Sub HCClose_Click(sender As Object, e As EventArgs) Handles HCClose.Click, closeForm.Click
        Me.Hide()
    End Sub

    Private Sub minForm_Click(sender As Object, e As EventArgs) Handles minForm.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub updateHC_Click(sender As Object, e As EventArgs) Handles updateHC.Click
        MainProgram.ppPres.Slides(slideNumber).Shapes(3).TextFrame.TextRange.Text = breadTxt.Text
        MainProgram.ppPres.Slides(slideNumber).Shapes(4).TextFrame.TextRange.Text = cupTxt.Text
        Try
            My.Computer.FileSystem.WriteAllText(MainProgram.CurrentDirectory + "\Files\bread.txt", breadTxt.Text, False)
            My.Computer.FileSystem.WriteAllText(MainProgram.CurrentDirectory + "\Files\cup.txt", cupTxt.Text, False)
            MessageBox.Show("Update Successful", "Update Successful")

        Catch ex As Exception
            MessageBox.Show("Update Unsuccessful. Please try again", "Update Unsuccessful")
        End Try

    End Sub

    Private Sub goToHCSlide_Click(sender As Object, e As EventArgs) Handles goToHCSlide.Click
        MainProgram.SlideTrack.SelectedIndex = slideNumber - 3
    End Sub


    'HYMN SELECTION --------------------------------------------
    Private Sub updateHymns()
        Dim hymns As String = ""
        Dim count = HymnsSelectionBox.Items.Count
        Dim index = HymnsSelectionBox.SelectedIndex
        If count < 4 Then
            hymns = String.Join(vbCrLf, HymnsSelectionBox.Items.Cast(Of String))
        Else
            If count >= 3 Then
                'if selected index less than total items -4 then insert selected hymn and 2 hymns after
                If index < count - 3 Then
                    hymns = HymnsSelectionBox.Items(index) + vbNewLine + HymnsSelectionBox.Items(index + 1) + vbNewLine + HymnsSelectionBox.Items(index + 2)
                Else
                    'insert last three hymns
                    hymns = HymnsSelectionBox.Items(count - 3) + vbNewLine + HymnsSelectionBox.Items(count - 2) + vbNewLine + HymnsSelectionBox.Items(count - 1)
                End If
            End If
        End If
        'updating hymns on holy communion slide maximum of first three hymn
        MainProgram.ppPres.Slides(7).Shapes(2).TextFrame.TextRange.Text = hymns
        highlightCurrentHymn(MainProgram.ppPres.Slides(7).Shapes(2).TextFrame.TextRange)
    End Sub
    Private Sub UpdateHymn_Click(sender As Object, e As EventArgs)
        updateHymns()
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
        'highlighting paragraph
        highlightParagraph(textBox, highlightedParagraph)
        'resetting styles of non highlighted paragraphs
        If highlightedParagraph - 1 >= 1 Then
            resetParagraph(textBox, highlightedParagraph - 1)
        End If
        If highlightedParagraph + 1 <= textBox.Paragraphs.Count Then
            resetParagraph(textBox, highlightedParagraph + 1)
        End If
    End Sub

    Private Sub resetParagraph(textbox As PowerPoint.TextRange, paragraph As Integer)
        textbox.Paragraphs(paragraph).Font.Color.TintAndShade = 0.05
        textbox.Paragraphs(paragraph).Font.Size = 40
        textbox.Paragraphs(paragraph).Font.Bold = Office.Core.MsoTriState.msoFalse
    End Sub

    Private Sub highlightParagraph(textbox As PowerPoint.TextRange, paragraph As Integer)
        textbox.Paragraphs(paragraph).Font.Color.TintAndShade = 0
        textbox.Paragraphs(paragraph).Font.Size = 56
        textbox.Paragraphs(paragraph).Font.Bold = Office.Core.MsoTriState.msoTrue
    End Sub

    Private Sub delHymnBtn_Click(sender As Object, e As EventArgs) Handles delHymnBtn.Click
        removeCurrentHymn(MainProgram.ppPres.Slides(7).Shapes(2).TextFrame.TextRange)
    End Sub
    Private Sub HymnColorBtn_Click(sender As Object, e As EventArgs) Handles HymnColorBtn.Click
        MainProgram.ChangeColor(slideNumber, 2)
    End Sub

    Private Sub HymnFontBtn_Click(sender As Object, e As EventArgs) Handles HymnFontBtn.Click
        MainProgram.ChangeFont(slideNumber, 2)
    End Sub

    Private Sub HymnsSelectionBox_KeyDown(sender As Object, e As KeyEventArgs) Handles HymnsSelectionBox.KeyDown
        If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete Then
            'handles deleting 
            'updating hymns on holy communion slide
            removeCurrentHymn(MainProgram.ppPres.Slides(7).Shapes(2).TextFrame.TextRange)
        End If
    End Sub
    Private Sub HymnsSelectionBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles HymnsSelectionBox.SelectedIndexChanged
        'updating hymns on holy communion slide
        'handling how selected index changes the highlighted pargarph
        Dim count = HymnsSelectionBox.Items.Count
        If count >= 3 Then
            If HymnsSelectionBox.SelectedIndex = HymnsSelectionBox.Items.Count - 1 Then
                highlightedParagraph = 3
            ElseIf HymnsSelectionBox.SelectedIndex = HymnsSelectionBox.Items.Count - 2 Then
                highlightedParagraph = 2
            ElseIf HymnsSelectionBox.SelectedIndex = HymnsSelectionBox.Items.Count - 3 Then
                highlightedParagraph = 1
            End If
        Else
            highlightedParagraph = HymnsSelectionBox.SelectedIndex + 1
        End If
        updateHymns()
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
            ElseIf HymnsSelectionBox.Items.Count > 3 Then
                'no need to update hymns if count is more than 3
            Else
                updateHymns()
            End If
        End If
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