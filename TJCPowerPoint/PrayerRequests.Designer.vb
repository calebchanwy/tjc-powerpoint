<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrayerRequests
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrayerRequests))
        Me.UpdatePrayerRequests = New System.Windows.Forms.Button()
        Me.ClosePrayerRequests = New System.Windows.Forms.Button()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PRTitleColorBtn = New System.Windows.Forms.Button()
        Me.PRTitleFontBtn = New System.Windows.Forms.Button()
        Me.PRColorBtn = New System.Windows.Forms.Button()
        Me.PRFontBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.editPrayerImage = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.header = New System.Windows.Forms.Label()
        Me.navBar = New System.Windows.Forms.FlowLayoutPanel()
        Me.closeForm = New System.Windows.Forms.Button()
        Me.minForm = New System.Windows.Forms.Button()
        Me.PrayerRequestTxt = New System.Windows.Forms.TextBox()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.deletePrayerImage = New System.Windows.Forms.Button()
        Me.navBar.SuspendLayout()
        Me.Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'UpdatePrayerRequests
        '
        Me.UpdatePrayerRequests.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdatePrayerRequests.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdatePrayerRequests.ForeColor = System.Drawing.Color.Navy
        Me.UpdatePrayerRequests.Location = New System.Drawing.Point(24, 441)
        Me.UpdatePrayerRequests.Name = "UpdatePrayerRequests"
        Me.UpdatePrayerRequests.Size = New System.Drawing.Size(157, 42)
        Me.UpdatePrayerRequests.TabIndex = 3
        Me.UpdatePrayerRequests.Text = "Update Prayer Requests"
        Me.UpdatePrayerRequests.UseVisualStyleBackColor = True
        '
        'ClosePrayerRequests
        '
        Me.ClosePrayerRequests.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClosePrayerRequests.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClosePrayerRequests.Location = New System.Drawing.Point(634, 440)
        Me.ClosePrayerRequests.Name = "ClosePrayerRequests"
        Me.ClosePrayerRequests.Size = New System.Drawing.Size(79, 43)
        Me.ClosePrayerRequests.TabIndex = 4
        Me.ClosePrayerRequests.Text = "Close"
        Me.ClosePrayerRequests.UseVisualStyleBackColor = True
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.DefaultExt = "txt"
        Me.SaveFileDialog.FileName = "PrayerRequests.txt"
        Me.SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"""
        Me.SaveFileDialog.InitialDirectory = "df"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "PrayerRequests.txt"
        Me.OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(663, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Body"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(666, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Title"
        '
        'PRTitleColorBtn
        '
        Me.PRTitleColorBtn.BackgroundImage = CType(resources.GetObject("PRTitleColorBtn.BackgroundImage"), System.Drawing.Image)
        Me.PRTitleColorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PRTitleColorBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PRTitleColorBtn.Location = New System.Drawing.Point(649, 74)
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
        Me.PRTitleFontBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PRTitleFontBtn.Location = New System.Drawing.Point(680, 74)
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
        Me.PRColorBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PRColorBtn.Location = New System.Drawing.Point(649, 136)
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
        Me.PRFontBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PRFontBtn.Location = New System.Drawing.Point(680, 136)
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
        Me.Label3.Location = New System.Drawing.Point(23, 400)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(402, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Representation of font size 22, might not be the same for different font sizes"
        '
        'editPrayerImage
        '
        Me.editPrayerImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editPrayerImage.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editPrayerImage.ForeColor = System.Drawing.Color.Navy
        Me.editPrayerImage.Location = New System.Drawing.Point(187, 441)
        Me.editPrayerImage.Name = "editPrayerImage"
        Me.editPrayerImage.Size = New System.Drawing.Size(79, 42)
        Me.editPrayerImage.TabIndex = 16
        Me.editPrayerImage.Text = "Edit Image"
        Me.editPrayerImage.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(391, 441)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 42)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Go To Prayer Requests"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'header
        '
        Me.header.AutoSize = True
        Me.header.BackColor = System.Drawing.Color.Transparent
        Me.header.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.header.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header.ForeColor = System.Drawing.Color.SteelBlue
        Me.header.Location = New System.Drawing.Point(19, 12)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(197, 32)
        Me.header.TabIndex = 18
        Me.header.Text = "Prayer Requests"
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
        Me.navBar.Size = New System.Drawing.Size(725, 47)
        Me.navBar.TabIndex = 19
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
        Me.closeForm.TabIndex = 11
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
        Me.minForm.TabIndex = 12
        Me.minForm.TabStop = False
        Me.minForm.UseVisualStyleBackColor = False
        '
        'PrayerRequestTxt
        '
        Me.PrayerRequestTxt.AcceptsReturn = True
        Me.PrayerRequestTxt.AcceptsTab = True
        Me.PrayerRequestTxt.AllowDrop = True
        Me.PrayerRequestTxt.BackColor = System.Drawing.Color.White
        Me.PrayerRequestTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PrayerRequestTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrayerRequestTxt.ForeColor = System.Drawing.Color.White
        Me.PrayerRequestTxt.Location = New System.Drawing.Point(2, 2)
        Me.PrayerRequestTxt.Multiline = True
        Me.PrayerRequestTxt.Name = "PrayerRequestTxt"
        Me.PrayerRequestTxt.Size = New System.Drawing.Size(604, 336)
        Me.PrayerRequestTxt.TabIndex = 2
        Me.PrayerRequestTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PrayerRequestTxt.WordWrap = False
        '
        'Panel
        '
        Me.Panel.BackColor = System.Drawing.Color.White
        Me.Panel.Controls.Add(Me.PrayerRequestTxt)
        Me.Panel.Location = New System.Drawing.Point(26, 55)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(607, 342)
        Me.Panel.TabIndex = 14
        '
        'deletePrayerImage
        '
        Me.deletePrayerImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deletePrayerImage.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletePrayerImage.ForeColor = System.Drawing.Color.Maroon
        Me.deletePrayerImage.Location = New System.Drawing.Point(272, 441)
        Me.deletePrayerImage.Name = "deletePrayerImage"
        Me.deletePrayerImage.Size = New System.Drawing.Size(113, 42)
        Me.deletePrayerImage.TabIndex = 20
        Me.deletePrayerImage.Text = "Delete Image"
        Me.deletePrayerImage.UseVisualStyleBackColor = True
        '
        'PrayerRequests
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TJCPowerPoint.My.Resources.Resources.border2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(725, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.deletePrayerImage)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.editPrayerImage)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PRTitleColorBtn)
        Me.Controls.Add(Me.PRTitleFontBtn)
        Me.Controls.Add(Me.PRColorBtn)
        Me.Controls.Add(Me.PRFontBtn)
        Me.Controls.Add(Me.ClosePrayerRequests)
        Me.Controls.Add(Me.UpdatePrayerRequests)
        Me.Controls.Add(Me.navBar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.MaximumSize = New System.Drawing.Size(725, 500)
        Me.MinimumSize = New System.Drawing.Size(725, 500)
        Me.Name = "PrayerRequests"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PrayerRequests"
        Me.navBar.ResumeLayout(False)
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UpdatePrayerRequests As Button
    Friend WithEvents ClosePrayerRequests As Button
    Friend WithEvents PRColorBtn As Button
    Friend WithEvents PRFontBtn As Button
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents PRTitleColorBtn As Button
    Friend WithEvents PRTitleFontBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents editPrayerImage As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents header As Label
    Friend WithEvents navBar As FlowLayoutPanel
    Public WithEvents PrayerRequestTxt As TextBox
    Friend WithEvents Panel As Panel
    Friend WithEvents deletePrayerImage As Button
    Friend WithEvents closeForm As Button
    Friend WithEvents minForm As Button
End Class
