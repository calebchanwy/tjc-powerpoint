<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Announcements
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Announcements))
        Me.UpdateAnnouncements = New System.Windows.Forms.Button()
        Me.LoadAnnouncements = New System.Windows.Forms.Button()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AnnouncementsColorBtn = New System.Windows.Forms.Button()
        Me.AnnouncementsFontBtn = New System.Windows.Forms.Button()
        Me.AnnouncementTxt = New System.Windows.Forms.TextBox()
        Me.header = New System.Windows.Forms.Label()
        Me.AnnouncementsTitleFontBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AnnouncementsTitleColorBtn = New System.Windows.Forms.Button()
        Me.goToAnnouncements = New System.Windows.Forms.Button()
        Me.navBar = New System.Windows.Forms.FlowLayoutPanel()
        Me.closeForm = New System.Windows.Forms.Button()
        Me.minForm = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.navBar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UpdateAnnouncements
        '
        Me.UpdateAnnouncements.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdateAnnouncements.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.UpdateAnnouncements.ForeColor = System.Drawing.Color.Navy
        Me.UpdateAnnouncements.Location = New System.Drawing.Point(17, 388)
        Me.UpdateAnnouncements.Name = "UpdateAnnouncements"
        Me.UpdateAnnouncements.Size = New System.Drawing.Size(187, 41)
        Me.UpdateAnnouncements.TabIndex = 3
        Me.UpdateAnnouncements.Text = "Update Announcements"
        Me.UpdateAnnouncements.UseVisualStyleBackColor = True
        '
        'LoadAnnouncements
        '
        Me.LoadAnnouncements.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoadAnnouncements.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadAnnouncements.ForeColor = System.Drawing.Color.Navy
        Me.LoadAnnouncements.Location = New System.Drawing.Point(213, 388)
        Me.LoadAnnouncements.Name = "LoadAnnouncements"
        Me.LoadAnnouncements.Size = New System.Drawing.Size(165, 42)
        Me.LoadAnnouncements.TabIndex = 3
        Me.LoadAnnouncements.TabStop = False
        Me.LoadAnnouncements.Text = "Insert Announcements"
        Me.LoadAnnouncements.UseVisualStyleBackColor = True
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.DefaultExt = "txt"
        Me.SaveFileDialog.FileName = "Announcements.txt"
        Me.SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"""
        Me.SaveFileDialog.InitialDirectory = "df"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "Announcements.txt"
        Me.OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(694, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Body"
        '
        'AnnouncementsColorBtn
        '
        Me.AnnouncementsColorBtn.BackgroundImage = CType(resources.GetObject("AnnouncementsColorBtn.BackgroundImage"), System.Drawing.Image)
        Me.AnnouncementsColorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AnnouncementsColorBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnnouncementsColorBtn.Location = New System.Drawing.Point(680, 146)
        Me.AnnouncementsColorBtn.Name = "AnnouncementsColorBtn"
        Me.AnnouncementsColorBtn.Size = New System.Drawing.Size(25, 25)
        Me.AnnouncementsColorBtn.TabIndex = 7
        Me.AnnouncementsColorBtn.TabStop = False
        Me.AnnouncementsColorBtn.UseVisualStyleBackColor = True
        '
        'AnnouncementsFontBtn
        '
        Me.AnnouncementsFontBtn.BackgroundImage = CType(resources.GetObject("AnnouncementsFontBtn.BackgroundImage"), System.Drawing.Image)
        Me.AnnouncementsFontBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AnnouncementsFontBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnnouncementsFontBtn.Location = New System.Drawing.Point(711, 146)
        Me.AnnouncementsFontBtn.Name = "AnnouncementsFontBtn"
        Me.AnnouncementsFontBtn.Size = New System.Drawing.Size(25, 25)
        Me.AnnouncementsFontBtn.TabIndex = 8
        Me.AnnouncementsFontBtn.TabStop = False
        Me.AnnouncementsFontBtn.UseVisualStyleBackColor = True
        '
        'AnnouncementTxt
        '
        Me.AnnouncementTxt.AcceptsReturn = True
        Me.AnnouncementTxt.AcceptsTab = True
        Me.AnnouncementTxt.AllowDrop = True
        Me.AnnouncementTxt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.AnnouncementTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AnnouncementTxt.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnnouncementTxt.ForeColor = System.Drawing.Color.Black
        Me.AnnouncementTxt.Location = New System.Drawing.Point(10, 26)
        Me.AnnouncementTxt.Multiline = True
        Me.AnnouncementTxt.Name = "AnnouncementTxt"
        Me.AnnouncementTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.AnnouncementTxt.Size = New System.Drawing.Size(634, 293)
        Me.AnnouncementTxt.TabIndex = 2
        Me.AnnouncementTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AnnouncementTxt.WordWrap = False
        '
        'header
        '
        Me.header.AutoSize = True
        Me.header.BackColor = System.Drawing.Color.Transparent
        Me.header.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.header.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header.ForeColor = System.Drawing.Color.SteelBlue
        Me.header.Location = New System.Drawing.Point(12, 16)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(174, 30)
        Me.header.TabIndex = 16
        Me.header.Text = "Announcements"
        '
        'AnnouncementsTitleFontBtn
        '
        Me.AnnouncementsTitleFontBtn.BackgroundImage = CType(resources.GetObject("AnnouncementsTitleFontBtn.BackgroundImage"), System.Drawing.Image)
        Me.AnnouncementsTitleFontBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AnnouncementsTitleFontBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnnouncementsTitleFontBtn.Location = New System.Drawing.Point(711, 83)
        Me.AnnouncementsTitleFontBtn.Name = "AnnouncementsTitleFontBtn"
        Me.AnnouncementsTitleFontBtn.Size = New System.Drawing.Size(25, 25)
        Me.AnnouncementsTitleFontBtn.TabIndex = 10
        Me.AnnouncementsTitleFontBtn.TabStop = False
        Me.AnnouncementsTitleFontBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(694, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Title"
        '
        'AnnouncementsTitleColorBtn
        '
        Me.AnnouncementsTitleColorBtn.BackgroundImage = CType(resources.GetObject("AnnouncementsTitleColorBtn.BackgroundImage"), System.Drawing.Image)
        Me.AnnouncementsTitleColorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AnnouncementsTitleColorBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnnouncementsTitleColorBtn.Location = New System.Drawing.Point(680, 83)
        Me.AnnouncementsTitleColorBtn.Name = "AnnouncementsTitleColorBtn"
        Me.AnnouncementsTitleColorBtn.Size = New System.Drawing.Size(25, 25)
        Me.AnnouncementsTitleColorBtn.TabIndex = 9
        Me.AnnouncementsTitleColorBtn.TabStop = False
        Me.AnnouncementsTitleColorBtn.UseVisualStyleBackColor = True
        '
        'goToAnnouncements
        '
        Me.goToAnnouncements.Cursor = System.Windows.Forms.Cursors.Hand
        Me.goToAnnouncements.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.goToAnnouncements.Location = New System.Drawing.Point(384, 388)
        Me.goToAnnouncements.Name = "goToAnnouncements"
        Me.goToAnnouncements.Size = New System.Drawing.Size(161, 43)
        Me.goToAnnouncements.TabIndex = 17
        Me.goToAnnouncements.Text = "Go To Announcements"
        Me.goToAnnouncements.UseVisualStyleBackColor = True
        '
        'navBar
        '
        Me.navBar.BackColor = System.Drawing.Color.Transparent
        Me.navBar.Controls.Add(Me.closeForm)
        Me.navBar.Controls.Add(Me.minForm)
        Me.navBar.Cursor = System.Windows.Forms.Cursors.Default
        Me.navBar.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.navBar.Location = New System.Drawing.Point(0, 0)
        Me.navBar.Name = "navBar"
        Me.navBar.Padding = New System.Windows.Forms.Padding(5)
        Me.navBar.Size = New System.Drawing.Size(750, 49)
        Me.navBar.TabIndex = 18
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
        Me.closeForm.Location = New System.Drawing.Point(718, 12)
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
        Me.minForm.Location = New System.Drawing.Point(690, 13)
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
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.AnnouncementTxt)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(650, 325)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Edit Announcements:"
        '
        'Announcements
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.TJCPowerPoint.My.Resources.Resources.border2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(750, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.UpdateAnnouncements)
        Me.Controls.Add(Me.goToAnnouncements)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AnnouncementsTitleColorBtn)
        Me.Controls.Add(Me.AnnouncementsTitleFontBtn)
        Me.Controls.Add(Me.AnnouncementsColorBtn)
        Me.Controls.Add(Me.AnnouncementsFontBtn)
        Me.Controls.Add(Me.LoadAnnouncements)
        Me.Controls.Add(Me.navBar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(750, 450)
        Me.MinimumSize = New System.Drawing.Size(750, 450)
        Me.Name = "Announcements"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Announcements"
        Me.navBar.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UpdateAnnouncements As Button
    Friend WithEvents LoadAnnouncements As Button
    Friend WithEvents AnnouncementsColorBtn As Button
    Friend WithEvents AnnouncementsFontBtn As Button
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents Label1 As Label
    Public WithEvents AnnouncementTxt As TextBox
    Friend WithEvents header As Label
    Friend WithEvents AnnouncementsTitleFontBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents AnnouncementsTitleColorBtn As Button
    Friend WithEvents goToAnnouncements As Button
    Friend WithEvents navBar As FlowLayoutPanel
    Friend WithEvents closeForm As Button
    Friend WithEvents minForm As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
