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

            If selectedIndex >= 2 Then
                'by default select the second display
                DisplayComboBox.SelectedIndex = 1
            ElseIf selectedIndex >= 0 Then
                DisplayComboBox.SelectedIndex = selectedIndex
            End If
        End If
    End Sub
    Public Function getScreen() As Screen
        ' Get the selected screen
        Dim selectedScreen As Screen = Nothing

        If DisplayComboBox.SelectedIndex >= 0 Then
            selectedScreen = Screen.AllScreens(DisplayComboBox.SelectedIndex)
        End If

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

    Private Sub maxSermonHymns_KeyDown(sender As Object, e As KeyEventArgs) Handles maxSermonHymns.KeyDown, maxHymnalHymns.KeyDown, maxHCHymns.KeyDown

        If e.KeyCode = Keys.Enter Then
            Dim textbox = DirectCast(sender, TextBox)
            Dim result As Integer
            If Integer.TryParse(textbox.Text.ToString, result) Then
                If textbox.Name.Equals("maxSermonHymns") Then
                    My.Settings.maxSermonHymns = result
                ElseIf textbox.Name.Equals("maxHymnalHymns") Then
                    My.Settings.maxHymnalHymns = result
                ElseIf textbox.Name.Equals("maxHCHymns") Then
                    My.Settings.maxHCHymns = result
                End If
                SelectNextControl(sender, True, True, True, False)
                MessageBox.Show("Save Successful")
            Else
                MessageBox.Show("Please enter in a number", "Error")
            End If
        End If
    End Sub

End Class