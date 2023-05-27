Imports Microsoft
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop

Public Class HymnSelector
    Private nameCollection As String

    'FONT VALUES
    Private Const DefaultFontSize As Integer = 50
    Private Const HighlightedFontSize As Integer = 75
    Private Const HighlightedColorTint As Single = 0
    Private Const DefaultColorTint As Single = 0.05

    'MAXIMUM HYMNS DISPLAYED
    Private maxHymns As Integer

    'Text box in powerpoint
    Private hymnTextBox As PowerPoint.TextRange
    'list box in windows form
    Private hymnListBox As ListBox

    Private prevHighlightedPar As Integer
    Private highlightedParagraph As Integer
    'DEFAULT CONSTRUCTOR
    Public Sub New(name As String, textBox As PowerPoint.TextRange, listBox As ListBox, maxHymns As Integer)
        Me.nameCollection = name
        Me.hymnTextBox = textBox
        Me.hymnListBox = listBox
        Me.maxHymns = maxHymns
    End Sub
    Public Function getName()
        Return nameCollection
    End Function

    Public Sub updateHymns()
        Dim hymnsAsString As String = ""
        Dim hymnsAsArray As New ArrayList
        Dim count = hymnListBox.Items.Count
        Dim index = hymnListBox.SelectedIndex
        If count = 0 Then
            hymnTextBox.Text = " "
        End If

        For Each hymn In hymnListBox.Items
            hymnsAsArray.Add(hymn)
        Next

        If count > maxHymns Then
            If (index + maxHymns) >= count Then
                hymnsAsString = String.Join(vbCr, hymnsAsArray.GetRange(count - maxHymns, maxHymns).ToArray())
            Else
                hymnsAsString = String.Join(vbCr, hymnsAsArray.GetRange(index, maxHymns).ToArray())
            End If
        Else
            'if there are less than the maximum displayed hymns
            hymnsAsString = String.Join(vbCr, hymnsAsArray.ToArray())
        End If

        'handling how selected index changes the highlighted pargarph
        If count <= maxHymns Then
            highlightedParagraph = index + 1
        ElseIf index > count - maxHymns Then
            highlightedParagraph = maxHymns - count + (index + 1)
        Else
            highlightedParagraph = 1
        End If

        'return if no change in hymns and highlighted paragraph
        If hymnTextBox.Text.ToString().Equals(hymnsAsString) And prevHighlightedPar = highlightedParagraph Then
            Return
        End If

        If prevHighlightedPar = 1 Or highlightedParagraph = 1 Then
            'Issue of when changing text, powerpoint assumes formatting of first paragraph for all
            'if highlghted paragraph second paragraph reset styles of first paragraph then change text
            resetParagraph(1)
        End If
        hymnTextBox.Text = hymnsAsString
        highlightCurrentHymn()
        prevHighlightedPar = highlightedParagraph
    End Sub

    Private Sub highlightCurrentHymn()
        ''resetting fonts to highlight selected hymn
        If hymnListBox.Items.Count = 0 Then
            'if no hymns currently in list box do nothing
            Return
        End If
        If hymnListBox.Items.Count = 1 Then
            'if only one hymn, no need to reset style
            highlightParagraph(1)
            Return
        End If
        'resetting styles of previous highlighted paragraph
        resetParagraph(prevHighlightedPar)
        'highlighting paragraph
        highlightParagraph(highlightedParagraph)
    End Sub
    Private Sub resetParagraph(paragraph As Integer)
        If paragraph <= hymnTextBox.Paragraphs.Count And hymnTextBox.Paragraphs(paragraph).Font.Bold Then
            hymnTextBox.Paragraphs(paragraph).Font.Color.TintAndShade = DefaultColorTint
            hymnTextBox.Paragraphs(paragraph).Font.Size = DefaultFontSize
            hymnTextBox.Paragraphs(paragraph).Font.Bold = MsoTriState.msoFalse
        End If
    End Sub

    Private Sub highlightParagraph(paragraph As Integer)
        If paragraph <= hymnTextBox.Paragraphs.Count And hymnTextBox.Paragraphs(paragraph).Font.Bold <> MsoTriState.msoTrue Then
            hymnTextBox.Paragraphs(paragraph).Font.Color.TintAndShade = HighlightedColorTint
            hymnTextBox.Paragraphs(paragraph).Font.Size = HighlightedFontSize
            hymnTextBox.Paragraphs(paragraph).Font.Bold = MsoTriState.msoTrue
        End If
    End Sub
    Public Sub removeCurrentHymn()
        Dim selectedIndex As Integer = hymnListBox.SelectedIndex
        Dim size As Integer = hymnListBox.Items.Count
        If size = 0 Then
            'if there are new hymns to be removed return
            hymnTextBox.Text = " "
            Return
        End If
        If size = 1 Then
            'only one hymn in selection box no need to find new selected hymn
            hymnListBox.Items.Clear()
            hymnTextBox.Text = " "
            Return
        End If
        If selectedIndex = size - 1 Then
            'if hymn is last hymn selected, reselect last hymn
            hymnListBox.Items.RemoveAt(selectedIndex)
            hymnListBox.SelectedIndex = size - 2
            Return
        End If
        'for all other cases, select the next hymn at the same index
        hymnListBox.Items.RemoveAt(selectedIndex)
        hymnListBox.SelectedIndex = selectedIndex
    End Sub

    Public Sub HandleHymnTextBoxKeyDown(e As KeyEventArgs, hymnNo As TextBox)
        If e.KeyCode = Keys.Enter Then
            ' User pressed Enter to submit hymn
            Dim hymnText As String = hymnNo.Text.Replace(vbNewLine, "").Trim()

            If String.IsNullOrEmpty(hymnText) Then
                ' User tried to enter an empty line
                hymnNo.Text = ""
                Return
            End If

            hymnListBox.Items.Add(hymnText)
            hymnNo.Text = ""

            ' If first hymn added, select hymn
            If hymnListBox.Items.Count = 1 Then
                hymnListBox.SelectedIndex = 0
            End If

            updateHymns()

        End If
    End Sub
End Class
