Imports System.IO
Imports Microsoft
Imports Microsoft.Office.Interop
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
    Inherits DraggableForm
    Private slide As PowerPoint.Slide
    Private HCHymns As HymnSelector
    Private iv As ImageViewer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ' File paths
        Dim breadFilePath As String = Path.Combine(MainProgram.getCurrentDirectory(), "Files\bread.txt")
        Dim cupFilePath As String = Path.Combine(MainProgram.getCurrentDirectory(), "Files\cup.txt")

        ' Load bread text from file
        If File.Exists(breadFilePath) Then
            breadTxt.Text = File.ReadAllText(breadFilePath)
        End If

        ' Load cup text from file
        If File.Exists(cupFilePath) Then
            cupTxt.Text = File.ReadAllText(cupFilePath)
        End If

        ' Set slide number for holyCommunion
        slide = MainProgram.getSlide("holyCommunion")

        ' Initialize HCHymns
        HCHymns = New HymnSelector("HCHymns", MainProgram.getTextBox(Definition.HCHymns.ToString()), HymnsSelectionBox)

        'Initialise image viewer for slide preview
        iv = New ImageViewer(slide)
        iv.addPreviewBox(previewBox)
        iv.updatePreviews()

        ' Set default text for HymnNos
        HymnNos.Text = "Enter Hymn"

    End Sub


    'Method handling when form is closed
    Private Sub HCClose_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub minForm_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub updateHC_Click(sender As Object, e As EventArgs) Handles updateHC.Click
        MainProgram.getTextBox("bread").Text = breadTxt.Text
        MainProgram.getTextBox("cup").Text = cupTxt.Text
        Try
            My.Computer.FileSystem.WriteAllText(MainProgram.getCurrentDirectory() + "\Files\bread.txt", breadTxt.Text, False)
            My.Computer.FileSystem.WriteAllText(MainProgram.getCurrentDirectory() + "\Files\cup.txt", cupTxt.Text, False)
            MessageBox.Show("Update Successful", "Update Successful")
            iv.updatePreviews()
        Catch ex As Exception
            MessageBox.Show("Update Unsuccessful. Please try again", "Update Unsuccessful")
        End Try
    End Sub

    Private Sub clearHymnsBtn_Click(sender As Object, e As EventArgs) Handles clearHymnsBtn.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to clear all hymns?", "Confirm Clear", MessageBoxButtons.OKCancel)
        If result = DialogResult.Yes Then
            HymnsSelectionBox.Items.Clear()
            HCHymns.updateHymns()
            iv.updatePreviews()
        End If

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


    Private Sub delHymnBtn_Click(sender As Object, e As EventArgs) Handles delHymnBtn.Click
        'handles deleting 
        'updating hymns on holy communion slide
        HCHymns.removeCurrentHymn()
        iv.updatePreviews()
    End Sub
    Private Sub HymnColorBtn_Click(sender As Object, e As EventArgs) Handles HymnColorBtn.Click
        MainProgram.ChangeColor(MainProgram.getTextBox("HChymns"))
        iv.updatePreviews()
    End Sub

    Private Sub HymnFontBtn_Click(sender As Object, e As EventArgs) Handles HymnFontBtn.Click
        MainProgram.ChangeFont(MainProgram.getTextBox("HChymns"))
        iv.updatePreviews()
    End Sub

    Private Sub HymnsSelectionBox_KeyDown(sender As Object, e As KeyEventArgs) Handles HymnsSelectionBox.KeyDown
        If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete Then
            'handles deleting 
            'updating hymns on holy communion slide
            HCHymns.removeCurrentHymn()
            iv.updatePreviews()
        End If
    End Sub
    Private Sub HymnsSelectionBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles HymnsSelectionBox.SelectedIndexChanged
        If HymnsSelectionBox.SelectedIndex = -1 Then
            Return
        End If
        'updating hymns on holy communion slide
        HCHymns.updateHymns()
        iv.updatePreviews()
    End Sub

    Private Sub HymnNos_KeyDown(sender As Object, e As KeyEventArgs) Handles HymnNos.KeyDown
        HCHymns.HandleHymnTextBoxKeyDown(e, HymnNos)
        iv.updatePreviews()
    End Sub
    Private Sub HymnNos_GotFocus(sender As Object, e As EventArgs) Handles HymnNos.GotFocus
        HymnNos.Text = ""
    End Sub
    Private Sub HymnNos_LostFocus(sender As Object, e As EventArgs) Handles HymnNos.LostFocus
        HymnNos.Text = "Enter Hymn"
    End Sub

    Private Sub colorBreadBtn_Click(sender As Object, e As EventArgs) Handles colorBreadBtn.Click
        MainProgram.ChangeColor(MainProgram.getTextBox("bread"))
        iv.updatePreviews()
    End Sub

    Private Sub fontBreadBtn_Click(sender As Object, e As EventArgs) Handles fontBreadBtn.Click
        MainProgram.ChangeFont(MainProgram.getTextBox("bread"))
        iv.updatePreviews()
    End Sub

    Private Sub colorCupBtn_Click(sender As Object, e As EventArgs) Handles colorCupBtn.Click
        MainProgram.ChangeColor(MainProgram.getTextBox("cup"))
        iv.updatePreviews()
    End Sub

    Private Sub fontCupBtn_Click(sender As Object, e As EventArgs) Handles fontCupBtn.Click
        MainProgram.ChangeFont(MainProgram.getTextBox("cup"))
        iv.updatePreviews()
    End Sub

    Private Sub enlargePreviewBtn_Click(sender As Object, e As EventArgs) Handles enlargePreviewBtn.Click
        iv.Show()
    End Sub


    'Add handlers to specific controls, passing objects back to superclass
    'All passed controls will allow the window to move as the mouse is dragged on it
    Private Sub navBar_MouseDown(sender As Object, e As MouseEventArgs) Handles navBar.MouseDown, header.MouseDown
        MyBase.Form1_MouseDown(sender, e)
    End Sub
    Private Sub navBar_MouseUp(sender As Object, e As MouseEventArgs) Handles navBar.MouseUp, header.MouseUp
        MyBase.Form1_MouseUp(sender, e)
    End Sub
    Private Sub navBar_MouseMove(sender As Object, e As MouseEventArgs) Handles navBar.MouseMove, header.MouseMove
        MyBase.Form1_MouseMove(sender, e)
    End Sub

    Private Sub HolyCommunion_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.Closing
        Hide()
        e.Cancel = True
    End Sub
End Class