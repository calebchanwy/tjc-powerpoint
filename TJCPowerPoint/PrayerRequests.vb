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

Imports System.Runtime.InteropServices

Public Class PrayerRequests
    Private directory As String
    Private slideNumber As Integer

    'Method handling when prayer request form is initially loaded
    Private Sub onCreate(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.aeroEnabled = False
        Me.FormBorderStyle = FormBorderStyle.None
        PrayerRequestTxt.Focus()
        directory = MainProgram.CurrentDirectory + "\Files\PrayerRequests.txt"
        If My.Computer.FileSystem.FileExists(directory) Then
            PrayerRequestTxt.Text = IO.File.ReadAllText(directory)
        End If

        'slide number according to order of powerpoint slide
        slideNumber = MainProgram.slideDictionary.Item("prayerRequests").SlideNumber
    End Sub

    'Method handling when form is closed
    Private Sub ClosePrayerRequests_Click(sender As Object, e As EventArgs) Handles closeForm.Click
        Me.Hide()
    End Sub
    Private Sub minForm_Click(sender As Object, e As EventArgs) Handles minForm.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub UpdatePrayerRequests_Click(sender As Object, e As EventArgs) Handles UpdatePrayerRequests.Click
        MainProgram.ppPres.Slides(slideNumber).Shapes(1).TextFrame.TextRange.Text = PrayerRequestTxt.Text
        Try
            My.Computer.FileSystem.WriteAllText(MainProgram.CurrentDirectory + "\Files\PrayerRequests.txt", PrayerRequestTxt.Text, False)
            MessageBox.Show("Save Successful", "Save Successful")
        Catch ex As Exception
            MessageBox.Show("Save Unsuccessful", "Save Unsuccessful")
        End Try

    End Sub
    Private Sub PRFontBtn_Click(sender As Object, e As EventArgs) Handles PRFontBtn.Click
        MainProgram.ChangeFont(MainProgram.textBoxDictionary.Item("prayerRequestsTxt"))
    End Sub
    Private Sub PRColorBtn_Click(sender As Object, e As EventArgs) Handles PRColorBtn.Click
        MainProgram.ChangeColor(MainProgram.textBoxDictionary.Item("prayerRequestsTxt"))
    End Sub
    Private Sub PRTitleFontBtn_Click(sender As Object, e As EventArgs) Handles PRTitleFontBtn.Click
        MainProgram.ChangeFont(MainProgram.textBoxDictionary.Item("prayerRequestsTitle"))
    End Sub
    Private Sub PRTitleColorBtn_Click(sender As Object, e As EventArgs) Handles PRTitleColorBtn.Click
        MainProgram.ChangeColor(MainProgram.textBoxDictionary.Item("prayerRequestsTitle"))
    End Sub

    Private Sub editPrayerImage_Click(sender As Object, e As EventArgs) Handles editPrayerImage.Click
        Call MainProgram.insertPrayerImage()
    End Sub

    Private Sub deletePrayerImage_Click(sender As Object, e As EventArgs) Handles deletePrayerImage.Click
        Call MainProgram.deletePrayerImage()
    End Sub

    Private Sub goToPRSLide_Click(sender As Object, e As EventArgs) Handles goToPRSlide.Click
        MainProgram.goToPRBtn.Checked = True
    End Sub




    'FOLLOWING METHODS DEAL WITH CREATING WINDOW AS A BORDERLESS DROP SHADOW WINDOWS FORM
    'https://stackoverflow.com/questions/16493698/drop-shadow-on-a-borderless-winform#:~:text=1)%20Create%20an%20image%20having,4)%20You%20are%20done!
    Private aeroEnabled As Boolean
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            CheckAeroEnabled()
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = NativeConstants.WS_EX_COMPOSITED
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
                        .leftWidth = 0
                        .rightWidth = 0
                        .topHeight = 0
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
End Class