Public Class SettingsForm
    Inherits DraggableForm

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ' Get the list of screens
        Dim screens As Screen() = Screen.AllScreens

        ' Add each screen to the ComboBox
        For Each screen As Screen In screens
            DisplayComboBox.Items.Add(screen.DeviceName)
        Next

        ' Load the previously selected display
        Dim selectedDisplay As String = My.Settings.SelectedDisplay

        If Not String.IsNullOrEmpty(selectedDisplay) Then
            Dim selectedIndex As Integer = DisplayComboBox.FindStringExact(selectedDisplay)

            If selectedIndex >= 0 Then
                DisplayComboBox.SelectedIndex = selectedIndex
            End If
        End If
    End Sub

    Public Function getScreen()
        ' Get the selected screen
        Dim selectedScreen As Screen = Screen.AllScreens(DisplayComboBox.SelectedIndex)
        Return selectedScreen
    End Function


    Private Sub closeForm_Click(sender As Object, e As EventArgs) Handles closeForm.Click
        Me.Hide()
    End Sub
    Private Sub minForm_Click(sender As Object, e As EventArgs) Handles minForm.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub DisplayComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayComboBox.SelectedIndexChanged
        ' Get the selected screen
        Dim selectedScreen As Screen = Screen.AllScreens(DisplayComboBox.SelectedIndex)

        ' Save the selected display
        My.Settings.SelectedDisplay = selectedScreen.DeviceName
        My.Settings.Save()
    End Sub
End Class