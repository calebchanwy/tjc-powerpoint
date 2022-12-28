Imports Microsoft
Imports Microsoft.Office.Interop
Imports TJCPowerPoint.NativeConstants, TJCPowerPoint.NativeMethods, TJCPowerPoint.NativeStructs
Public Class HolyCommunion
    Private slideNumber As Integer

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
        Me.FormBorderStyle = FormBorderStyle.None
        slideNumber = 7
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
        MainProgram.ppPres.SlideShowWindow.View.GotoSlide(slideNumber)
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

    'HYMN SELECTION --------------------------------------------

    Private Sub updateHymns()
        Dim hymns As String = ""
        If HymnsSelectionBox.Items.Count < 4 Then
            hymns = String.Join(vbNewLine, HymnsSelectionBox.Items.Cast(Of String))
        Else
            hymns = HymnsSelectionBox.Items(0) + vbNewLine + HymnsSelectionBox.Items(1) + vbNewLine + HymnsSelectionBox.Items(2)
        End If
        'updating hymns on holy communion slide maximum of first three hymn
        MainProgram.ppPres.Slides(7).Shapes(2).TextFrame.TextRange.Text = hymns
        highlightCurrentHymn(MainProgram.ppPres.Slides(7).Shapes(2).TextFrame.TextRange)
    End Sub
    Private Sub UpdateHymn_Click(sender As Object, e As EventArgs) Handles UpdateHymn.Click
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
            textBox.Paragraphs(HymnsSelectionBox.SelectedIndex + 1).Font.Size = 56
            textBox.Paragraphs(HymnsSelectionBox.SelectedIndex + 1).Font.Bold = Office.Core.MsoTriState.msoTrue
            Return
        End If
        'resetting styles
        textBox.Font.Size = 40
        textBox.Font.Bold = Office.Core.MsoTriState.msoFalse
        'highlighting paragraph
        textBox.Paragraphs(HymnsSelectionBox.SelectedIndex + 1).Font.Size = 56
        textBox.Paragraphs(HymnsSelectionBox.SelectedIndex + 1).Font.Bold = Office.Core.MsoTriState.msoTrue
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
        highlightCurrentHymn(MainProgram.ppPres.Slides(7).Shapes(2).TextFrame.TextRange)
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
End Class