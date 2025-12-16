<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
    Inherits Form

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
        Me.Utilities = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.openFolderBtn = New System.Windows.Forms.Button()
        Me.changeBgBtn = New System.Windows.Forms.Button()
        Me.DisplayComboBox = New System.Windows.Forms.ComboBox()
        Me.GeneralSettings = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.maxHCHymns = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.maxSermonHymns = New System.Windows.Forms.NumericUpDown()
        Me.maxHymnalHymns = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.Utilities.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GeneralSettings.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.maxHCHymns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maxSermonHymns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maxHymnalHymns, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Utilities
        '
        Me.Utilities.AutoSize = True
        Me.Utilities.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Utilities.Controls.Add(Me.FlowLayoutPanel1)
        Me.Utilities.Dock = System.Windows.Forms.DockStyle.Top
        Me.Utilities.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Utilities.Location = New System.Drawing.Point(0, 139)
        Me.Utilities.Margin = New System.Windows.Forms.Padding(10)
        Me.Utilities.Name = "Utilities"
        Me.Utilities.Padding = New System.Windows.Forms.Padding(5)
        Me.Utilities.Size = New System.Drawing.Size(664, 65)
        Me.Utilities.TabIndex = 35
        Me.Utilities.TabStop = False
        Me.Utilities.Text = "Utilities"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.openFolderBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.changeBgBtn)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(5, 27)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(654, 33)
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
        Me.openFolderBtn.Size = New System.Drawing.Size(174, 27)
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
        Me.changeBgBtn.Location = New System.Drawing.Point(183, 3)
        Me.changeBgBtn.Name = "changeBgBtn"
        Me.changeBgBtn.Size = New System.Drawing.Size(204, 27)
        Me.changeBgBtn.TabIndex = 38
        Me.changeBgBtn.Text = "Change PowerPoint Background"
        Me.changeBgBtn.UseVisualStyleBackColor = True
        '
        'DisplayComboBox
        '
        Me.DisplayComboBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.DisplayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DisplayComboBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayComboBox.FormattingEnabled = True
        Me.DisplayComboBox.Location = New System.Drawing.Point(138, 5)
        Me.DisplayComboBox.Name = "DisplayComboBox"
        Me.DisplayComboBox.Size = New System.Drawing.Size(511, 25)
        Me.DisplayComboBox.TabIndex = 0
        '
        'GeneralSettings
        '
        Me.GeneralSettings.AutoSize = True
        Me.GeneralSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GeneralSettings.Controls.Add(Me.TableLayoutPanel2)
        Me.GeneralSettings.Controls.Add(Me.TableLayoutPanel1)
        Me.GeneralSettings.Controls.Add(Me.Label4)
        Me.GeneralSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.GeneralSettings.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralSettings.Location = New System.Drawing.Point(0, 0)
        Me.GeneralSettings.Margin = New System.Windows.Forms.Padding(10)
        Me.GeneralSettings.Name = "GeneralSettings"
        Me.GeneralSettings.Padding = New System.Windows.Forms.Padding(5)
        Me.GeneralSettings.Size = New System.Drawing.Size(664, 139)
        Me.GeneralSettings.TabIndex = 36
        Me.GeneralSettings.TabStop = False
        Me.GeneralSettings.Text = "General Settings"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.59925!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.40076!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.DisplayComboBox, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(5, 79)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.Padding = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(654, 55)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label6.Image = Global.TJCPowerPoint.My.Resources.Resources.icons8_info_16
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(138, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(511, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "     Application restart required to apply"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(5, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 31)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Projector Display:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.75471!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.57862!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.75472!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.57862!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.75472!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.57862!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.maxHCHymns, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.maxSermonHymns, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.maxHymnalHymns, 3, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(5, 44)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(654, 35)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(5, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Max Sermon Hymns:"
        '
        'maxHCHymns
        '
        Me.maxHCHymns.Dock = System.Windows.Forms.DockStyle.Fill
        Me.maxHCHymns.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maxHCHymns.Location = New System.Drawing.Point(569, 5)
        Me.maxHCHymns.Name = "maxHCHymns"
        Me.maxHCHymns.Size = New System.Drawing.Size(80, 25)
        Me.maxHCHymns.TabIndex = 37
        Me.maxHCHymns.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(435, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 31)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Max Holy Communion Hymns:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(220, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 31)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Max Hymnal Hymns:"
        '
        'maxSermonHymns
        '
        Me.maxSermonHymns.Dock = System.Windows.Forms.DockStyle.Fill
        Me.maxSermonHymns.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maxSermonHymns.Location = New System.Drawing.Point(139, 5)
        Me.maxSermonHymns.Name = "maxSermonHymns"
        Me.maxSermonHymns.Size = New System.Drawing.Size(75, 25)
        Me.maxSermonHymns.TabIndex = 38
        Me.maxSermonHymns.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'maxHymnalHymns
        '
        Me.maxHymnalHymns.Dock = System.Windows.Forms.DockStyle.Fill
        Me.maxHymnalHymns.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maxHymnalHymns.Location = New System.Drawing.Point(354, 5)
        Me.maxHymnalHymns.Name = "maxHymnalHymns"
        Me.maxHymnalHymns.Size = New System.Drawing.Size(75, 25)
        Me.maxHymnalHymns.TabIndex = 39
        Me.maxHymnalHymns.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label4.Location = New System.Drawing.Point(5, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(410, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Maximum number of hymns that can be displayed at one time per slide"
        '
        'saveBtn
        '
        Me.saveBtn.AutoSize = True
        Me.saveBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.saveBtn.BackgroundImage = Global.TJCPowerPoint.My.Resources.Resources.background
        Me.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.saveBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.saveBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.saveBtn.Location = New System.Drawing.Point(596, 3)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.saveBtn.Size = New System.Drawing.Size(65, 37)
        Me.saveBtn.TabIndex = 37
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'cancelBtn
        '
        Me.cancelBtn.AutoSize = True
        Me.cancelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cancelBtn.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cancelBtn.Location = New System.Drawing.Point(524, 3)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Padding = New System.Windows.Forms.Padding(5)
        Me.cancelBtn.Size = New System.Drawing.Size(66, 37)
        Me.cancelBtn.TabIndex = 39
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoSize = True
        Me.FlowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel2.Controls.Add(Me.saveBtn)
        Me.FlowLayoutPanel2.Controls.Add(Me.cancelBtn)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(10, 358)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(664, 43)
        Me.FlowLayoutPanel2.TabIndex = 40
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.Utilities)
        Me.MainPanel.Controls.Add(Me.GeneralSettings)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(10, 10)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(664, 348)
        Me.MainPanel.TabIndex = 2
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(684, 411)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SettingsForm"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "Settings"
        Me.Utilities.ResumeLayout(False)
        Me.Utilities.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.GeneralSettings.ResumeLayout(False)
        Me.GeneralSettings.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.maxHCHymns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maxSermonHymns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maxHymnalHymns, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DisplayComboBox As ComboBox
    Friend WithEvents Utilities As GroupBox
    Friend WithEvents GeneralSettings As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents saveBtn As Button
    Friend WithEvents openFolderBtn As Button
    Friend WithEvents changeBgBtn As Button
    Friend WithEvents cancelBtn As Button
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents MainPanel As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents maxHCHymns As NumericUpDown
    Friend WithEvents maxSermonHymns As NumericUpDown
    Friend WithEvents maxHymnalHymns As NumericUpDown
End Class
