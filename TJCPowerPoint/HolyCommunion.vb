Imports TJCPowerPoint.NativeConstants, TJCPowerPoint.NativeMethods, TJCPowerPoint.NativeStructs
Public Class HolyCommunion
    Private slideNumber As Integer

    'Method called when the form is initially created
    Private Sub onCreate(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bread As String
        Dim cup As String
        If My.Computer.FileSystem.FileExists(MainProgram.Current + "\Files\bread.txt") = True Then
            bread = My.Computer.FileSystem.ReadAllText(MainProgram.Current + "\Files\bread.txt")
            breadTxt.Text = bread
        End If
        If My.Computer.FileSystem.FileExists(MainProgram.Current + "\Files\cup.txt") = True Then
            cup = My.Computer.FileSystem.ReadAllText(MainProgram.Current + "\Files\cup.txt")
            cupTxt.Text = cup
        End If

        Me.aeroEnabled = False
        Me.FormBorderStyle = FormBorderStyle.None
        slideNumber = 4
    End Sub

    'Method handling when form is closed
    Private Sub HCClose_Click(sender As Object, e As EventArgs) Handles HCClose.Click
        Me.Hide()
    End Sub

    Private Sub updateHC_Click(sender As Object, e As EventArgs) Handles updateHC.Click
        MainProgram.ppPres.Slides(slideNumber).Shapes(2).TextFrame.TextRange.Text = breadTxt.Text
        MainProgram.ppPres.Slides(slideNumber).Shapes(3).TextFrame.TextRange.Text = cupTxt.Text
        Try
            My.Computer.FileSystem.WriteAllText(MainProgram.Current + "\Files\bread.txt", breadTxt.Text, False)
            My.Computer.FileSystem.WriteAllText(MainProgram.Current + "\Files\cup.txt", cupTxt.Text, False)
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
End Class