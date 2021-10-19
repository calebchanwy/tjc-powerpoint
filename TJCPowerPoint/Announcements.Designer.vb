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
        Me.AnnouncementTxt = New System.Windows.Forms.TextBox()
        Me.UpdateAnnouncements = New System.Windows.Forms.Button()
        Me.SaveAnnouncements = New System.Windows.Forms.Button()
        Me.LoadAnnouncements = New System.Windows.Forms.Button()
        Me.CloseAnnouncements = New System.Windows.Forms.Button()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PRTitleColorBtn = New System.Windows.Forms.Button()
        Me.PRTitleFontBtn = New System.Windows.Forms.Button()
        Me.PRColorBtn = New System.Windows.Forms.Button()
        Me.PRFontBtn = New System.Windows.Forms.Button()
        Me.TitleBox = New System.Windows.Forms.TextBox()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'AnnouncementTxt
        '
        Me.AnnouncementTxt.AcceptsReturn = True
        Me.AnnouncementTxt.AcceptsTab = True
        Me.AnnouncementTxt.AllowDrop = True
        Me.AnnouncementTxt.BackColor = System.Drawing.Color.Black
        Me.AnnouncementTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AnnouncementTxt.Font = New System.Drawing.Font("Book Antiqua", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnnouncementTxt.ForeColor = System.Drawing.Color.White
        Me.AnnouncementTxt.Location = New System.Drawing.Point(0, 29)
        Me.AnnouncementTxt.Multiline = True
        Me.AnnouncementTxt.Name = "AnnouncementTxt"
        Me.AnnouncementTxt.Size = New System.Drawing.Size(487, 352)
        Me.AnnouncementTxt.TabIndex = 2
        Me.AnnouncementTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AnnouncementTxt.WordWrap = False
        '
        'UpdateAnnouncements
        '
        Me.UpdateAnnouncements.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateAnnouncements.Location = New System.Drawing.Point(508, 103)
        Me.UpdateAnnouncements.Name = "UpdateAnnouncements"
        Me.UpdateAnnouncements.Size = New System.Drawing.Size(68, 142)
        Me.UpdateAnnouncements.TabIndex = 3
        Me.UpdateAnnouncements.Text = "Update Announcements"
        Me.UpdateAnnouncements.UseVisualStyleBackColor = True
        '
        'SaveAnnouncements
        '
        Me.SaveAnnouncements.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveAnnouncements.Location = New System.Drawing.Point(513, 290)
        Me.SaveAnnouncements.Name = "SaveAnnouncements"
        Me.SaveAnnouncements.Size = New System.Drawing.Size(57, 33)
        Me.SaveAnnouncements.TabIndex = 2
        Me.SaveAnnouncements.TabStop = False
        Me.SaveAnnouncements.Text = "Save"
        Me.SaveAnnouncements.UseVisualStyleBackColor = True
        '
        'LoadAnnouncements
        '
        Me.LoadAnnouncements.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadAnnouncements.Location = New System.Drawing.Point(514, 251)
        Me.LoadAnnouncements.Name = "LoadAnnouncements"
        Me.LoadAnnouncements.Size = New System.Drawing.Size(56, 33)
        Me.LoadAnnouncements.TabIndex = 3
        Me.LoadAnnouncements.TabStop = False
        Me.LoadAnnouncements.Text = "Open"
        Me.LoadAnnouncements.UseVisualStyleBackColor = True
        '
        'CloseAnnouncements
        '
        Me.CloseAnnouncements.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseAnnouncements.Location = New System.Drawing.Point(509, 329)
        Me.CloseAnnouncements.Name = "CloseAnnouncements"
        Me.CloseAnnouncements.Size = New System.Drawing.Size(67, 54)
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
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(525, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Body"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(530, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Title"
        '
        'PRTitleColorBtn
        '
        Me.PRTitleColorBtn.BackgroundImage = CType(resources.GetObject("PRTitleColorBtn.BackgroundImage"), System.Drawing.Image)
        Me.PRTitleColorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PRTitleColorBtn.Location = New System.Drawing.Point(513, 22)
        Me.PRTitleColorBtn.Name = "PRTitleColorBtn"
        Me.PRTitleColorBtn.Size = New System.Drawing.Size(25, 25)
        Me.PRTitleColorBtn.TabIndex = 9
        Me.PRTitleColorBtn.TabStop = False
        Me.PRTitleColorBtn.UseVisualStyleBackColor = True
        '
        'PRTitleFontBtn
        '
        Me.PRTitleFontBtn.BackgroundImage = CType(resources.GetObject("PRTitleFontBtn.BackgroundImage"), System.Drawing.Image)
        Me.PRTitleFontBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PRTitleFontBtn.Location = New System.Drawing.Point(544, 22)
        Me.PRTitleFontBtn.Name = "PRTitleFontBtn"
        Me.PRTitleFontBtn.Size = New System.Drawing.Size(25, 25)
        Me.PRTitleFontBtn.TabIndex = 10
        Me.PRTitleFontBtn.TabStop = False
        Me.PRTitleFontBtn.UseVisualStyleBackColor = True
        '
        'PRColorBtn
        '
        Me.PRColorBtn.BackgroundImage = CType(resources.GetObject("PRColorBtn.BackgroundImage"), System.Drawing.Image)
        Me.PRColorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PRColorBtn.Location = New System.Drawing.Point(513, 67)
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
        Me.PRFontBtn.Location = New System.Drawing.Point(544, 67)
        Me.PRFontBtn.Name = "PRFontBtn"
        Me.PRFontBtn.Size = New System.Drawing.Size(25, 25)
        Me.PRFontBtn.TabIndex = 8
        Me.PRFontBtn.TabStop = False
        Me.PRFontBtn.UseVisualStyleBackColor = True
        '
        'TitleBox
        '
        Me.TitleBox.BackColor = System.Drawing.Color.Black
        Me.TitleBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TitleBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleBox.ForeColor = System.Drawing.SystemColors.Info
        Me.TitleBox.Location = New System.Drawing.Point(3, 3)
        Me.TitleBox.Name = "TitleBox"
        Me.TitleBox.Size = New System.Drawing.Size(484, 20)
        Me.TitleBox.TabIndex = 1
        Me.TitleBox.Text = "Announcements"
        Me.TitleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel
        '
        Me.Panel.BackColor = System.Drawing.Color.Black
        Me.Panel.Controls.Add(Me.TitleBox)
        Me.Panel.Controls.Add(Me.AnnouncementTxt)
        Me.Panel.Location = New System.Drawing.Point(3, 2)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(490, 381)
        Me.Panel.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 389)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(403, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Representation of font size 22, might not be the same for different font sizes"
        '
        'Announcements
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 410)
        Me.ControlBox = False
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
        Me.Controls.Add(Me.SaveAnnouncements)
        Me.Controls.Add(Me.UpdateAnnouncements)
        Me.HelpButton = True
        Me.Name = "Announcements"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Announcements"
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UpdateAnnouncements As Button
    Friend WithEvents SaveAnnouncements As Button
    Friend WithEvents LoadAnnouncements As Button
    Friend WithEvents CloseAnnouncements As Button
    Friend WithEvents PRColorBtn As Button
    Friend WithEvents PRFontBtn As Button
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Public WithEvents AnnouncementTxt As TextBox
    Friend WithEvents PRTitleColorBtn As Button
    Friend WithEvents PRTitleFontBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TitleBox As TextBox
    Friend WithEvents Panel As Panel
    Friend WithEvents Label3 As Label
End Class
