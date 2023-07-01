Public Class SettingsForm
    Inherits DraggableForm

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        loadScreens()
        loadMaxHymns()
    End Sub

    Private Sub loadMaxHymns()
        maxHCHymns.Text = My.Settings.maxHCHymns.ToString()
        maxHymnalHymns.Text = My.Settings.maxHymnalHymns.ToString()
        maxSermonHymns.Text = My.Settings.maxSermonHymns.ToString()
    End Sub
    Private Sub loadScreens()

        ' Add any initialization after the InitializeComponent() call.
        ' Get the list of screens
        Dim screens As Screen() = Screen.AllScreens

        ' Add each screen to the ComboBox
        For Each screen As Screen In screens
            ' Use the DeviceName property for numbering and Model property for the model name
            DisplayComboBox.Items.Add(screen.DeviceName & " - " & screen.Bounds.Width.ToString() & "x" & screen.Bounds.Height.ToString())
        Next

        ' Load the previously selected display
        Dim selectedDisplay As String = My.Settings.SelectedDisplay

        If Not String.IsNullOrEmpty(selectedDisplay) Then
            Dim selectedIndex As Integer = -1

            ' Find the index based on the selectedDisplay string
            For i As Integer = 0 To DisplayComboBox.Items.Count - 1
                If DisplayComboBox.Items(i).ToString().Contains(selectedDisplay) Then
                    selectedIndex = i
                    Exit For
                End If
            Next

            DisplayComboBox.SelectedIndex = selectedIndex
        End If
    End Sub
    Public Function getScreen() As Screen
        ' Get the selected screen
        Dim selectedScreen As Screen = Nothing

        If DisplayComboBox.SelectedIndex >= 0 Then
            Dim displayAsString = DisplayComboBox.SelectedItem
            For Each screen As Screen In Screen.AllScreens()
                If screen.ToString().Equals(displayAsString) Then
                    Return screen
                End If
            Next
            Return Screen.AllScreens().GetValue(0)
        Else
            Return Screen.AllScreens().GetValue(0)
        End If

    End Function


    Private Sub closeForm_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub
    Private Sub minForm_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub DisplayComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayComboBox.SelectedIndexChanged
        saveScreen()
    End Sub


    Private Sub maxSermonHymns_KeyDown(sender As Object, e As KeyEventArgs) Handles maxSermonHymns.KeyDown, maxHymnalHymns.KeyDown, maxHCHymns.KeyDown
        If e.KeyCode = Keys.Enter Then
            saveMaxHymns()
        End If
    End Sub
    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        saveSettings()
    End Sub

    'Method that will save all settings
    Private Sub saveSettings()
        saveScreen()
        saveMaxHymns()
    End Sub
    'Method to save the settings of all maximum hymns
    Private Sub saveMaxHymns()
        'For each textbox, check if text are all integers, if any are not integers return error
        Dim textBoxes() = {maxSermonHymns, maxHymnalHymns, maxHCHymns}
        For Each textBox In textBoxes
            Dim result As Integer
            If Integer.TryParse(textBox.Text.ToString, result) Then
                If textBox.Name.Equals("maxSermonHymns") Then
                    My.Settings.maxSermonHymns = result
                ElseIf textBox.Name.Equals("maxHymnalHymns") Then
                    My.Settings.maxHymnalHymns = result
                ElseIf textBox.Name.Equals("maxHCHymns") Then
                    My.Settings.maxHCHymns = result
                End If
            Else
                MessageBox.Show("Please enter in a number", "Error")
                Return
            End If
        Next
        MessageBox.Show("Save Successful", "Success")
    End Sub
    'Method to save the selected screen
    Private Sub saveScreen()
        ' Get the selected screen
        Dim selectedScreen As Screen = Screen.AllScreens(DisplayComboBox.SelectedIndex)

        ' Save the selected display
        My.Settings.SelectedDisplay = selectedScreen.DeviceName
        My.Settings.Save()
    End Sub

    'Ensures that upon closing, the form state is still saved
    Private Sub SettingsForm_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.Closing
        Hide()
        e.Cancel = True
    End Sub
End Class