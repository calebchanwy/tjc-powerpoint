<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
    Inherits DraggableForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsForm))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DisplayComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.maxHCHymns = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.maxHymnalHymns = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.maxSermonHymns = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.openFolderBtn = New System.Windows.Forms.Button()
        Me.changeBgBtn = New System.Windows.Forms.Button()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.header = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 40)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(714, 330)
        Me.TableLayoutPanel1.TabIndex = 38
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DisplayComboBox)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 165)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(337, 135)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Projector Display"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 56)
        Me.Label4.MaximumSize = New System.Drawing.Size(330, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(320, 34)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "* Please restart the application for the screen change to take affect"
        '
        'DisplayComboBox
        '
        Me.DisplayComboBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.DisplayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DisplayComboBox.FormattingEnabled = True
        Me.DisplayComboBox.Location = New System.Drawing.Point(5, 27)
        Me.DisplayComboBox.Name = "DisplayComboBox"
        Me.DisplayComboBox.Size = New System.Drawing.Size(327, 29)
        Me.DisplayComboBox.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.maxHCHymns)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.maxHymnalHymns)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.maxSermonHymns)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox2.Size = New System.Drawing.Size(337, 135)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Set Maximum Number Of Hymns"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Holy Communion Hymns:"
        '
        'maxHCHymns
        '
        Me.maxHCHymns.Location = New System.Drawing.Point(229, 106)
        Me.maxHCHymns.Name = "maxHCHymns"
        Me.maxHCHymns.Size = New System.Drawing.Size(100, 29)
        Me.maxHCHymns.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hymnal Hymns:"
        '
        'maxHymnalHymns
        '
        Me.maxHymnalHymns.Location = New System.Drawing.Point(229, 69)
        Me.maxHymnalHymns.Name = "maxHymnalHymns"
        Me.maxHymnalHymns.Size = New System.Drawing.Size(100, 29)
        Me.maxHymnalHymns.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sermon Hymns:"
        '
        'maxSermonHymns
        '
        Me.maxSermonHymns.Location = New System.Drawing.Point(229, 31)
        Me.maxSermonHymns.Name = "maxSermonHymns"
        Me.maxSermonHymns.Size = New System.Drawing.Size(100, 29)
        Me.maxSermonHymns.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.openFolderBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.changeBgBtn)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(360, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(351, 149)
        Me.FlowLayoutPanel1.TabIndex = 39
        '
        'openFolderBtn
        '
        Me.openFolderBtn.AutoSize = True
        Me.openFolderBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.openFolderBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.openFolderBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.openFolderBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.openFolderBtn.Location = New System.Drawing.Point(3, 3)
        Me.openFolderBtn.Name = "openFolderBtn"
        Me.openFolderBtn.Size = New System.Drawing.Size(204, 27)
        Me.openFolderBtn.TabIndex = 37
        Me.openFolderBtn.Text = "Open Configuration Folder"
        Me.openFolderBtn.UseVisualStyleBackColor = True
        '
        'changeBgBtn
        '
        Me.changeBgBtn.AutoSize = True
        Me.changeBgBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.changeBgBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.changeBgBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.changeBgBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.changeBgBtn.Location = New System.Drawing.Point(3, 36)
        Me.changeBgBtn.Name = "changeBgBtn"
        Me.changeBgBtn.Size = New System.Drawing.Size(204, 27)
        Me.changeBgBtn.TabIndex = 38
        Me.changeBgBtn.Text = "Change PowerPoint Background"
        Me.changeBgBtn.UseVisualStyleBackColor = True
        '
        'saveBtn
        '
        Me.saveBtn.AutoSize = True
        Me.saveBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.saveBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.saveBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.ForeColor = System.Drawing.Color.DarkBlue
        Me.saveBtn.Location = New System.Drawing.Point(10, 370)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(714, 31)
        Me.saveBtn.TabIndex = 37
        Me.saveBtn.Text = "Save Settings"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'header
        '
        Me.header.AutoSize = True
        Me.header.BackColor = System.Drawing.Color.Transparent
        Me.header.Cursor = System.Windows.Forms.Cursors.Default
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header.ForeColor = System.Drawing.Color.SteelBlue
        Me.header.Location = New System.Drawing.Point(10, 10)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(93, 30)
        Me.header.TabIndex = 33
        Me.header.Text = "Settings"
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(734, 411)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SettingsForm"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "Settings"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DisplayComboBox As ComboBox
    Friend WithEvents header As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents maxHCHymns As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents maxHymnalHymns As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents maxSermonHymns As TextBox
    Friend WithEvents saveBtn As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents openFolderBtn As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents changeBgBtn As Button
End Class
