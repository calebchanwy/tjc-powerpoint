Imports System.Runtime.InteropServices
Imports TJCPowerPoint.NativeConstants, TJCPowerPoint.NativeMethods, TJCPowerPoint.NativeStructs
Public Class Announcements

    Private aeroEnabled As Boolean
    Private slideNumber As Integer

    'Method Announcements_Load dealing when the announcements form initially opens
    Private Sub Announcements_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.aeroEnabled = False
        Me.FormBorderStyle = FormBorderStyle.None
        AnnouncementTxt.Focus()
        'HERE INITALISE THE ANNOUNCEMENT SLIDE NUMBER ACCORDING TO ORDER ON POWERPOINT
        slideNumber = MainProgram.slideDictionary.Item("announcements").SlideNumber()
    End Sub

    Private Sub CloseAnnouncements_Click(sender As Object, e As EventArgs) Handles CloseAnnouncements.Click, closeForm.Click
        Me.Hide()
    End Sub
    Private Sub minForm_Click(sender As Object, e As EventArgs) Handles minForm.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UpdateAnnouncements_Click(sender As Object, e As EventArgs) Handles UpdateAnnouncements.Click
        MainProgram.ppPres.Slides(slideNumber).Shapes(1).TextFrame.TextRange.Text = AnnouncementTxt.Text
        Try
            My.Computer.FileSystem.WriteAllText(MainProgram.CurrentDirectory + "\Files\Announcements.txt", AnnouncementTxt.Text, False)
            MessageBox.Show("Save Successful", "Save Successful")
        Catch ex As Exception
            MessageBox.Show("Save Unsuccessful", "Save Unsuccessful")
        End Try

    End Sub
    Private Sub AnnouncementsFontBtn_Click(sender As Object, e As EventArgs) Handles AnnouncementsFontBtn.Click
        MainProgram.ChangeFont(MainProgram.textBoxDictionary.Item("announcementsTxt"))
    End Sub
    Private Sub PRColorBtn_Click(sender As Object, e As EventArgs) Handles AnnouncementsColorBtn.Click
        MainProgram.ChangeColor(MainProgram.textBoxDictionary.Item("announcementsTxt"))
    End Sub
    Private Sub PRTitleFontBtn_Click(sender As Object, e As EventArgs) Handles AnnouncementsTitleFontBtn.Click
        MainProgram.ChangeFont(MainProgram.textBoxDictionary.Item("announcementsTitle"))
    End Sub
    Private Sub PRTitleColorBtn_Click(sender As Object, e As EventArgs) Handles AnnouncementsTitleColorBtn.Click
        MainProgram.ChangeColor(MainProgram.textBoxDictionary.Item("announcementsTitle"))
    End Sub

    Private Sub LoadAnnouncements_Click(sender As Object, e As EventArgs) Handles LoadAnnouncements.Click
        OpenFileDialog.InitialDirectory = MainProgram.CurrentDirectory + "\Files\"
        If OpenFileDialog.ShowDialog = DialogResult.OK Then
            AnnouncementTxt.Text = IO.File.ReadAllText(OpenFileDialog.FileName)
            Call UpdateAnnouncements_Click(sender, e)
        End If
    End Sub

    Private Sub goToAnnouncements_Click(sender As Object, e As EventArgs) Handles goToAnnouncements.Click
        MainProgram.goToAnnouncementsBtn.Checked = True
    End Sub


    'CREATING DROPDOWN SHADOW AND ROUDED CORNERS
    'https://stackoverflow.com/questions/16493698/drop-shadow-on-a-borderless-winform#:~:text=1)%20Create%20an%20image%20having,4)%20You%20are%20done!
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


    'DEALING WITH FORM MOVEMENT
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

End Class