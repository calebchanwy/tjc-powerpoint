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
        Me.CloseAnnouncements = New System.Windows.Forms.Button()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PRColorBtn = New System.Windows.Forms.Button()
        Me.PRFontBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AnnouncementTxt = New System.Windows.Forms.TextBox()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.header = New System.Windows.Forms.Label()
        Me.PRTitleFontBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PRTitleColorBtn = New System.Windows.Forms.Button()
        Me.goToAnnouncements = New System.Windows.Forms.Button()
        Me.navBar = New System.Windows.Forms.FlowLayoutPanel()
        Me.closeForm = New System.Windows.Forms.Button()
        Me.minForm = New System.Windows.Forms.Button()
        Me.Panel.SuspendLayout()
        Me.navBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'UpdateAnnouncements
        '
        Me.UpdateAnnouncements.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateAnnouncements.ForeColor = System.Drawing.Color.Navy
        Me.UpdateAnnouncements.Location = New System.Drawing.Point(20, 397)
        Me.UpdateAnnouncements.Name = "UpdateAnnouncements"
        Me.UpdateAnnouncements.Size = New System.Drawing.Size(198, 43)
        Me.UpdateAnnouncements.TabIndex = 3
        Me.UpdateAnnouncements.Text = "Update Announcements"
        Me.UpdateAnnouncements.UseVisualStyleBackColor = True
        '
        'LoadAnnouncements
        '
        Me.LoadAnnouncements.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadAnnouncements.Location = New System.Drawing.Point(391, 398)
        Me.LoadAnnouncements.Name = "LoadAnnouncements"
        Me.LoadAnnouncements.Size = New System.Drawing.Size(86, 43)
        Me.LoadAnnouncements.TabIndex = 3
        Me.LoadAnnouncements.TabStop = False
        Me.LoadAnnouncements.Text = "Open Folder"
        Me.LoadAnnouncements.UseVisualStyleBackColor = True
        '
        'CloseAnnouncements
        '
        Me.CloseAnnouncements.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseAnnouncements.ForeColor = System.Drawing.Color.Maroon
        Me.CloseAnnouncements.Location = New System.Drawing.Point(627, 398)
        Me.CloseAnnouncements.Name = "CloseAnnouncements"
        Me.CloseAnnouncements.Size = New System.Drawing.Size(86, 42)
        Me.CloseAnnouncements.TabIndex = 4
        Me.CloseAnnouncements.Text = "Close"
        Me.CloseAnnouncements.UseVisualStyleBackColor = True
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
        Me.Label1.Location = New System.Drawing.Point(654, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Body"
        '
        'PRColorBtn
        '
        Me.PRColorBtn.BackgroundImage = CType(resources.GetObject("PRColorBtn.BackgroundImage"), System.Drawing.Image)
        Me.PRColorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PRColorBtn.Location = New System.Drawing.Point(642, 117)
        Me.PRColorBtn.Name = "PRColorBtn"
        Me.PRColorBtn.Size = New System.Drawing.Size(25, 25)
        Me.PRColorBtn.TabIndex = 7
        Me.PRColorBtn.TabStop = False
        Me.PRColorBtn.UseVisualStyleBackColor = True
        '
        'PRFontBtn
        '
        Me.PRFontBtn.BackgroundImage = CType(resources.GetObject("PRFontBtn.BackgroundImage"), System.Drawing.Image)
        Me.PRFontBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PRFontBtn.Location = New System.Drawing.Point(673, 117)
        Me.PRFontBtn.Name = "PRFontBtn"
        Me.PRFontBtn.Size = New System.Drawing.Size(25, 25)
        Me.PRFontBtn.TabIndex = 8
        Me.PRFontBtn.TabStop = False
        Me.PRFontBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 379)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(402, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Representation of font size 22, might not be the same for different font sizes"
        '
        'AnnouncementTxt
        '
        Me.AnnouncementTxt.AcceptsReturn = True
        Me.AnnouncementTxt.AcceptsTab = True
        Me.AnnouncementTxt.AllowDrop = True
        Me.AnnouncementTxt.BackColor = System.Drawing.Color.Black
        Me.AnnouncementTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AnnouncementTxt.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnnouncementTxt.ForeColor = System.Drawing.Color.White
        Me.AnnouncementTxt.Location = New System.Drawing.Point(1, 1)
        Me.AnnouncementTxt.Multiline = True
        Me.AnnouncementTxt.Name = "AnnouncementTxt"
        Me.AnnouncementTxt.Size = New System.Drawing.Size(609, 328)
        Me.AnnouncementTxt.TabIndex = 2
        Me.AnnouncementTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AnnouncementTxt.WordWrap = False
        '
        'Panel
        '
        Me.Panel.BackColor = System.Drawing.Color.Black
        Me.Panel.Controls.Add(Me.AnnouncementTxt)
        Me.Panel.Location = New System.Drawing.Point(20, 48)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(609, 328)
        Me.Panel.TabIndex = 14
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
        'PRTitleFontBtn
        '
        Me.PRTitleFontBtn.BackgroundImage = CType(resources.GetObject("PRTitleFontBtn.BackgroundImage"), System.Drawing.Image)
        Me.PRTitleFontBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PRTitleFontBtn.Location = New System.Drawing.Point(673, 72)
        Me.PRTitleFontBtn.Name = "PRTitleFontBtn"
        Me.PRTitleFontBtn.Size = New System.Drawing.Size(25, 25)
        Me.PRTitleFontBtn.TabIndex = 10
        Me.PRTitleFontBtn.TabStop = False
        Me.PRTitleFontBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(659, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Title"
        '
        'PRTitleColorBtn
        '
        Me.PRTitleColorBtn.BackgroundImage = CType(resources.GetObject("PRTitleColorBtn.BackgroundImage"), System.Drawing.Image)
        Me.PRTitleColorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PRTitleColorBtn.Location = New System.Drawing.Point(642, 72)
        Me.PRTitleColorBtn.Name = "PRTitleColorBtn"
        Me.PRTitleColorBtn.Size = New System.Drawing.Size(25, 25)
        Me.PRTitleColorBtn.TabIndex = 9
        Me.PRTitleColorBtn.TabStop = False
        Me.PRTitleColorBtn.UseVisualStyleBackColor = True
        '
        'goToAnnouncements
        '
        Me.goToAnnouncements.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.goToAnnouncements.Location = New System.Drawing.Point(224, 397)
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
        Me.navBar.Size = New System.Drawing.Size(725, 49)
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
        Me.closeForm.Location = New System.Drawing.Point(693, 12)
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
        Me.minForm.Location = New System.Drawing.Point(665, 13)
        Me.minForm.Margin = New System.Windows.Forms.Padding(8)
        Me.minForm.Name = "minForm"
        Me.minForm.Padding = New System.Windows.Forms.Padding(3)
        Me.minForm.Size = New System.Drawing.Size(13, 13)
        Me.minForm.TabIndex = 20
        Me.minForm.TabStop = False
        Me.minForm.UseVisualStyleBackColor = False
        '
        'Announcements
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TJCPowerPoint.My.Resources.Resources.border2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(725, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.UpdateAnnouncements)
        Me.Controls.Add(Me.goToAnnouncements)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PRTitleColorBtn)
        Me.Controls.Add(Me.PRTitleFontBtn)
        Me.Controls.Add(Me.PRColorBtn)
        Me.Controls.Add(Me.PRFontBtn)
        Me.Controls.Add(Me.CloseAnnouncements)
        Me.Controls.Add(Me.LoadAnnouncements)
        Me.Controls.Add(Me.navBar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(725, 450)
        Me.MinimumSize = New System.Drawing.Size(725, 450)
        Me.Name = "Announcements"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Announcements"
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.navBar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UpdateAnnouncements As Button
    Friend WithEvents LoadAnnouncements As Button
    Friend WithEvents CloseAnnouncements As Button
    Friend WithEvents PRColorBtn As Button
    Friend WithEvents PRFontBtn As Button
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Public WithEvents AnnouncementTxt As TextBox
    Friend WithEvents Panel As Panel
    Friend WithEvents header As Label
    Friend WithEvents PRTitleFontBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PRTitleColorBtn As Button
    Friend WithEvents goToAnnouncements As Button
    Friend WithEvents navBar As FlowLayoutPanel
    Friend WithEvents closeForm As Button
    Friend WithEvents minForm As Button
End Class
