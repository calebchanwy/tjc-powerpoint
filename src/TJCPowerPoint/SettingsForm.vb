Public Class SettingsForm
    Inherits Form

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        LoadData()
    End Sub

    ''' <summary>
    ''' Loads data and settings into form.
    ''' </summary>
    Private Sub LoadData()
        maxHCHymns.Value = My.Settings.maxHCHymns
        maxHymnalHymns.Value = My.Settings.maxHymnalHymns
        maxSermonHymns.Value = My.Settings.maxSermonHymns

        ' Load available screens to combobox
        Dim screens As Screen() = Screen.AllScreens
        For Each screen As Screen In screens
            DisplayComboBox.Items.Add(screen.DeviceName & " - " & screen.Bounds.Width.ToString() & "x" & screen.Bounds.Height.ToString())
        Next

        ' Select default projector display
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
        Else
            DisplayComboBox.SelectedIndex = 0
        End If
    End Sub

    Public Function getScreen() As Screen
        ' Get the selected screen
        Dim selectedScreen As Screen = Nothing
        If DisplayComboBox.SelectedIndex >= 0 Then
            For Each screen As Screen In Screen.AllScreens()
                If My.Settings.Item("SelectedDisplay").Contains(screen.DeviceName) Then
                    Return screen
                End If
            Next
            Return Screen.AllScreens().GetValue(0)
        Else
            Return Screen.AllScreens().GetValue(0)
        End If

    End Function

    ''' <summary>
    ''' Saves max hymns displayed to settings
    ''' </summary>
    Private Sub SaveSettings()
        SaveScreen()
        saveMaxHymns()
        MessageBox.Show("Save Successful", "Save Successful")
    End Sub
    ''' <summary>
    ''' Saves max hymns displayed to settings
    ''' </summary>
    Private Sub SaveMaxHymns()
        My.Settings.Item("maxSermonHymns") = CInt(maxSermonHymns.Value)
        My.Settings.Item("maxHymnalHymns") = CInt(maxHymnalHymns.Value)
        My.Settings.Item("maxHCHymns") = CInt(maxHCHymns.Value)
        My.Settings.Save()
    End Sub

    ''' <summary>
    ''' Saves selected display to settings
    ''' </summary>
    Private Sub SaveScreen()
        Dim selectedScreen As Screen = Screen.AllScreens(DisplayComboBox.SelectedIndex)
        My.Settings.SelectedDisplay = selectedScreen.DeviceName
        My.Settings.Save()
    End Sub

    Private Sub DisplayComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayComboBox.SelectedIndexChanged
        SaveScreen()
    End Sub
    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        SaveSettings()
    End Sub
    Private Sub openFolderBtn_Click(sender As Object, e As EventArgs) Handles openFolderBtn.Click
        Process.Start(MainProgram.getCurrentDirectory())
    End Sub

    Private Sub changeBgBtn_Click(sender As Object, e As EventArgs) Handles changeBgBtn.Click
        MainProgram.changeBackground()
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.Close()
    End Sub
End Class