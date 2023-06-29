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
        Me.DisplayComboBox = New System.Windows.Forms.ComboBox()
        Me.header = New System.Windows.Forms.Label()
        Me.navBar = New System.Windows.Forms.FlowLayoutPanel()
        Me.closeForm = New System.Windows.Forms.Button()
        Me.minForm = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.maxHCHymns = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.maxHymnalHymns = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.maxSermonHymns = New System.Windows.Forms.TextBox()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.navBar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DisplayComboBox
        '
        Me.DisplayComboBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.DisplayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DisplayComboBox.FormattingEnabled = True
        Me.DisplayComboBox.Location = New System.Drawing.Point(5, 27)
        Me.DisplayComboBox.Name = "DisplayComboBox"
        Me.DisplayComboBox.Size = New System.Drawing.Size(324, 29)
        Me.DisplayComboBox.TabIndex = 0
        '
        'header
        '
        Me.header.AutoSize = True
        Me.header.BackColor = System.Drawing.Color.Transparent
        Me.header.Cursor = System.Windows.Forms.Cursors.Default
        Me.header.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header.ForeColor = System.Drawing.Color.SteelBlue
        Me.header.Location = New System.Drawing.Point(13, 13)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(93, 30)
        Me.header.TabIndex = 33
        Me.header.Text = "Settings"
        '
        'navBar
        '
        Me.navBar.BackColor = System.Drawing.Color.Transparent
        Me.navBar.Controls.Add(Me.closeForm)
        Me.navBar.Controls.Add(Me.minForm)
        Me.navBar.Cursor = System.Windows.Forms.Cursors.Default
        Me.navBar.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.navBar.Location = New System.Drawing.Point(662, 0)
        Me.navBar.Name = "navBar"
        Me.navBar.Padding = New System.Windows.Forms.Padding(5)
        Me.navBar.Size = New System.Drawing.Size(75, 36)
        Me.navBar.TabIndex = 34
        '
        'closeForm
        '
        Me.closeForm.BackColor = System.Drawing.Color.Transparent
        Me.closeForm.BackgroundImage = CType(resources.GetObject("closeForm.BackgroundImage"), System.Drawing.Image)
        Me.closeForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.closeForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeForm.FlatAppearance.BorderSize = 0
        Me.closeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeForm.ForeColor = System.Drawing.Color.Transparent
        Me.closeForm.Location = New System.Drawing.Point(43, 12)
        Me.closeForm.Margin = New System.Windows.Forms.Padding(7)
        Me.closeForm.Name = "closeForm"
        Me.closeForm.Size = New System.Drawing.Size(15, 15)
        Me.closeForm.TabIndex = 19
        Me.closeForm.TabStop = False
        Me.closeForm.UseVisualStyleBackColor = False
        '
        'minForm
        '
        Me.minForm.BackColor = System.Drawing.Color.Transparent
        Me.minForm.BackgroundImage = CType(resources.GetObject("minForm.BackgroundImage"), System.Drawing.Image)
        Me.minForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.minForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minForm.FlatAppearance.BorderSize = 0
        Me.minForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minForm.ForeColor = System.Drawing.Color.Transparent
        Me.minForm.Location = New System.Drawing.Point(15, 13)
        Me.minForm.Margin = New System.Windows.Forms.Padding(8)
        Me.minForm.Name = "minForm"
        Me.minForm.Padding = New System.Windows.Forms.Padding(3)
        Me.minForm.Size = New System.Drawing.Size(13, 13)
        Me.minForm.TabIndex = 20
        Me.minForm.TabStop = False
        Me.minForm.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DisplayComboBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(334, 62)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Projector Display"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.maxHCHymns)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.maxHymnalHymns)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.maxSermonHymns)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 126)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox2.Size = New System.Drawing.Size(334, 146)
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
        Me.maxHCHymns.Location = New System.Drawing.Point(188, 106)
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
        Me.maxHymnalHymns.Location = New System.Drawing.Point(188, 65)
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
        Me.maxSermonHymns.Location = New System.Drawing.Point(188, 27)
        Me.maxSermonHymns.Name = "maxSermonHymns"
        Me.maxSermonHymns.Size = New System.Drawing.Size(100, 29)
        Me.maxSermonHymns.TabIndex = 0
        '
        'saveBtn
        '
        Me.saveBtn.AutoSize = True
        Me.saveBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
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
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TJCPowerPoint.My.Resources.Resources.border33
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(734, 411)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.navBar)
        Me.Controls.Add(Me.header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SettingsForm"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "Settings"
        Me.navBar.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DisplayComboBox As ComboBox
    Friend WithEvents header As Label
    Friend WithEvents navBar As FlowLayoutPanel
    Friend WithEvents closeForm As Button
    Friend WithEvents minForm As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents maxHCHymns As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents maxHymnalHymns As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents maxSermonHymns As TextBox
    Friend WithEvents saveBtn As Button
End Class
