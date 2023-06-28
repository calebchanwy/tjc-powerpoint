<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BaseSlideEdit
    Inherits DraggableForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BaseSlideEdit))
        Me.useTxtFile = New System.Windows.Forms.RadioButton()
        Me.useGoogleSlides = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.googleSlidesLink = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.closeForm = New System.Windows.Forms.Button()
        Me.minForm = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.updateBtn = New System.Windows.Forms.Button()
        Me.TitleFontBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TitleColorBtn = New System.Windows.Forms.Button()
        Me.BodyColorBtn = New System.Windows.Forms.Button()
        Me.BodyFontBtn = New System.Windows.Forms.Button()
        Me.navBar = New System.Windows.Forms.FlowLayoutPanel()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.header = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.loadTxtBtn = New System.Windows.Forms.Button()
        Me.insertImage = New System.Windows.Forms.Button()
        Me.delImage = New System.Windows.Forms.Button()
        Me.previewBox = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.enlargePreviewBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.navBar.SuspendLayout()
        CType(Me.previewBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'useTxtFile
        '
        Me.useTxtFile.AutoSize = True
        Me.useTxtFile.Location = New System.Drawing.Point(138, 8)
        Me.useTxtFile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.useTxtFile.Name = "useTxtFile"
        Me.useTxtFile.Size = New System.Drawing.Size(149, 24)
        Me.useTxtFile.TabIndex = 1
        Me.useTxtFile.Text = ".txt (PowerPoint)"
        Me.useTxtFile.UseVisualStyleBackColor = True
        '
        'useGoogleSlides
        '
        Me.useGoogleSlides.AutoSize = True
        Me.useGoogleSlides.Location = New System.Drawing.Point(3, 8)
        Me.useGoogleSlides.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.useGoogleSlides.Name = "useGoogleSlides"
        Me.useGoogleSlides.Size = New System.Drawing.Size(133, 24)
        Me.useGoogleSlides.TabIndex = 0
        Me.useGoogleSlides.Text = "Google Slides"
        Me.useGoogleSlides.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 22)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 28)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Google Slides Link:"
        '
        'googleSlidesLink
        '
        Me.googleSlidesLink.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.googleSlidesLink.Location = New System.Drawing.Point(14, 52)
        Me.googleSlidesLink.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.googleSlidesLink.Name = "googleSlidesLink"
        Me.googleSlidesLink.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.googleSlidesLink.Size = New System.Drawing.Size(744, 31)
        Me.googleSlidesLink.TabIndex = 3
        Me.googleSlidesLink.Text = "https://"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.googleSlidesLink)
        Me.GroupBox1.Controls.Add(Me.txtInput)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(26, 88)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(777, 500)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Edit:"
        '
        'txtInput
        '
        Me.txtInput.AcceptsReturn = True
        Me.txtInput.AcceptsTab = True
        Me.txtInput.AllowDrop = True
        Me.txtInput.BackColor = System.Drawing.Color.White
        Me.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInput.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.ForeColor = System.Drawing.Color.Black
        Me.txtInput.Location = New System.Drawing.Point(15, 97)
        Me.txtInput.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtInput.Size = New System.Drawing.Size(744, 380)
        Me.txtInput.TabIndex = 2
        Me.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtInput.WordWrap = False
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
        Me.closeForm.Location = New System.Drawing.Point(62, 19)
        Me.closeForm.Margin = New System.Windows.Forms.Padding(10, 11, 10, 11)
        Me.closeForm.Name = "closeForm"
        Me.closeForm.Size = New System.Drawing.Size(22, 23)
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
        Me.minForm.Location = New System.Drawing.Point(20, 20)
        Me.minForm.Margin = New System.Windows.Forms.Padding(12)
        Me.minForm.Name = "minForm"
        Me.minForm.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.minForm.Size = New System.Drawing.Size(20, 20)
        Me.minForm.TabIndex = 20
        Me.minForm.TabStop = False
        Me.minForm.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.useTxtFile)
        Me.Panel1.Controls.Add(Me.useGoogleSlides)
        Me.Panel1.Location = New System.Drawing.Point(812, 105)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(296, 48)
        Me.Panel1.TabIndex = 34
        '
        'updateBtn
        '
        Me.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.updateBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.updateBtn.ForeColor = System.Drawing.Color.Navy
        Me.updateBtn.Location = New System.Drawing.Point(26, 616)
        Me.updateBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(403, 47)
        Me.updateBtn.TabIndex = 22
        Me.updateBtn.Text = "Update Slide"
        Me.updateBtn.UseVisualStyleBackColor = True
        '
        'TitleFontBtn
        '
        Me.TitleFontBtn.BackgroundImage = CType(resources.GetObject("TitleFontBtn.BackgroundImage"), System.Drawing.Image)
        Me.TitleFontBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TitleFontBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TitleFontBtn.Location = New System.Drawing.Point(891, 191)
        Me.TitleFontBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TitleFontBtn.Name = "TitleFontBtn"
        Me.TitleFontBtn.Size = New System.Drawing.Size(38, 38)
        Me.TitleFontBtn.TabIndex = 27
        Me.TitleFontBtn.TabStop = False
        Me.TitleFontBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1010, 166)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 23)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Body"
        '
        'TitleColorBtn
        '
        Me.TitleColorBtn.BackgroundImage = CType(resources.GetObject("TitleColorBtn.BackgroundImage"), System.Drawing.Image)
        Me.TitleColorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TitleColorBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TitleColorBtn.Location = New System.Drawing.Point(844, 191)
        Me.TitleColorBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TitleColorBtn.Name = "TitleColorBtn"
        Me.TitleColorBtn.Size = New System.Drawing.Size(38, 38)
        Me.TitleColorBtn.TabIndex = 26
        Me.TitleColorBtn.TabStop = False
        Me.TitleColorBtn.UseVisualStyleBackColor = True
        '
        'BodyColorBtn
        '
        Me.BodyColorBtn.BackgroundImage = CType(resources.GetObject("BodyColorBtn.BackgroundImage"), System.Drawing.Image)
        Me.BodyColorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BodyColorBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BodyColorBtn.Location = New System.Drawing.Point(988, 191)
        Me.BodyColorBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BodyColorBtn.Name = "BodyColorBtn"
        Me.BodyColorBtn.Size = New System.Drawing.Size(38, 38)
        Me.BodyColorBtn.TabIndex = 24
        Me.BodyColorBtn.TabStop = False
        Me.BodyColorBtn.UseVisualStyleBackColor = True
        '
        'BodyFontBtn
        '
        Me.BodyFontBtn.BackgroundImage = CType(resources.GetObject("BodyFontBtn.BackgroundImage"), System.Drawing.Image)
        Me.BodyFontBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BodyFontBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BodyFontBtn.Location = New System.Drawing.Point(1035, 191)
        Me.BodyFontBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BodyFontBtn.Name = "BodyFontBtn"
        Me.BodyFontBtn.Size = New System.Drawing.Size(38, 38)
        Me.BodyFontBtn.TabIndex = 25
        Me.BodyFontBtn.TabStop = False
        Me.BodyFontBtn.UseVisualStyleBackColor = True
        '
        'navBar
        '
        Me.navBar.BackColor = System.Drawing.Color.Transparent
        Me.navBar.Controls.Add(Me.closeForm)
        Me.navBar.Controls.Add(Me.minForm)
        Me.navBar.Cursor = System.Windows.Forms.Cursors.Default
        Me.navBar.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.navBar.Location = New System.Drawing.Point(1016, 2)
        Me.navBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.navBar.Name = "navBar"
        Me.navBar.Padding = New System.Windows.Forms.Padding(8)
        Me.navBar.Size = New System.Drawing.Size(110, 49)
        Me.navBar.TabIndex = 32
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "Announcements.txt"
        Me.OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"""
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.DefaultExt = "txt"
        Me.SaveFileDialog.FileName = "Announcements.txt"
        Me.SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"""
        Me.SaveFileDialog.InitialDirectory = "df"
        '
        'header
        '
        Me.header.AutoSize = True
        Me.header.BackColor = System.Drawing.Color.Transparent
        Me.header.Cursor = System.Windows.Forms.Cursors.Default
        Me.header.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header.ForeColor = System.Drawing.Color.SteelBlue
        Me.header.Location = New System.Drawing.Point(18, 26)
        Me.header.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(190, 45)
        Me.header.TabIndex = 30
        Me.header.Text = "Slide Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(866, 166)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 23)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Title"
        '
        'loadTxtBtn
        '
        Me.loadTxtBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loadTxtBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loadTxtBtn.ForeColor = System.Drawing.Color.Navy
        Me.loadTxtBtn.Location = New System.Drawing.Point(693, 616)
        Me.loadTxtBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.loadTxtBtn.Name = "loadTxtBtn"
        Me.loadTxtBtn.Size = New System.Drawing.Size(248, 47)
        Me.loadTxtBtn.TabIndex = 23
        Me.loadTxtBtn.TabStop = False
        Me.loadTxtBtn.Text = "Insert as .txt file"
        Me.loadTxtBtn.UseVisualStyleBackColor = True
        '
        'insertImage
        '
        Me.insertImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.insertImage.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insertImage.ForeColor = System.Drawing.Color.Navy
        Me.insertImage.Location = New System.Drawing.Point(437, 616)
        Me.insertImage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.insertImage.Name = "insertImage"
        Me.insertImage.Size = New System.Drawing.Size(248, 47)
        Me.insertImage.TabIndex = 35
        Me.insertImage.TabStop = False
        Me.insertImage.Text = "Insert as Image"
        Me.insertImage.UseVisualStyleBackColor = True
        '
        'delImage
        '
        Me.delImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delImage.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delImage.ForeColor = System.Drawing.Color.DarkRed
        Me.delImage.Location = New System.Drawing.Point(949, 616)
        Me.delImage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.delImage.Name = "delImage"
        Me.delImage.Size = New System.Drawing.Size(159, 47)
        Me.delImage.TabIndex = 36
        Me.delImage.TabStop = False
        Me.delImage.Text = "Delete Image"
        Me.delImage.UseVisualStyleBackColor = True
        '
        'previewBox
        '
        Me.previewBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.previewBox.Image = Global.TJCPowerPoint.My.Resources.Resources.border1
        Me.previewBox.Location = New System.Drawing.Point(812, 382)
        Me.previewBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.previewBox.Name = "previewBox"
        Me.previewBox.Size = New System.Drawing.Size(294, 182)
        Me.previewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.previewBox.TabIndex = 37
        Me.previewBox.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(812, 351)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 28)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Slide Preview"
        '
        'enlargePreviewBtn
        '
        Me.enlargePreviewBtn.BackColor = System.Drawing.Color.Transparent
        Me.enlargePreviewBtn.BackgroundImage = CType(resources.GetObject("enlargePreviewBtn.BackgroundImage"), System.Drawing.Image)
        Me.enlargePreviewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.enlargePreviewBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.enlargePreviewBtn.FlatAppearance.BorderSize = 0
        Me.enlargePreviewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.enlargePreviewBtn.Location = New System.Drawing.Point(1065, 522)
        Me.enlargePreviewBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.enlargePreviewBtn.Name = "enlargePreviewBtn"
        Me.enlargePreviewBtn.Size = New System.Drawing.Size(38, 38)
        Me.enlargePreviewBtn.TabIndex = 39
        Me.enlargePreviewBtn.TabStop = False
        Me.enlargePreviewBtn.UseVisualStyleBackColor = False
        '
        'BaseSlideEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TJCPowerPoint.My.Resources.Resources.border32
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1125, 692)
        Me.Controls.Add(Me.enlargePreviewBtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.previewBox)
        Me.Controls.Add(Me.delImage)
        Me.Controls.Add(Me.insertImage)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.updateBtn)
        Me.Controls.Add(Me.TitleFontBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TitleColorBtn)
        Me.Controls.Add(Me.BodyColorBtn)
        Me.Controls.Add(Me.BodyFontBtn)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.loadTxtBtn)
        Me.Controls.Add(Me.navBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Name = "BaseSlideEdit"
        Me.Text = "BaseSlideEdit"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.navBar.ResumeLayout(False)
        CType(Me.previewBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents useTxtFile As RadioButton
    Friend WithEvents useGoogleSlides As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents googleSlidesLink As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Public WithEvents txtInput As TextBox
    Friend WithEvents closeForm As Button
    Friend WithEvents minForm As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents updateBtn As Button
    Friend WithEvents TitleFontBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TitleColorBtn As Button
    Friend WithEvents BodyColorBtn As Button
    Friend WithEvents BodyFontBtn As Button
    Friend WithEvents navBar As FlowLayoutPanel
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents header As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents loadTxtBtn As Button
    Friend WithEvents insertImage As Button
    Friend WithEvents delImage As Button
    Friend WithEvents previewBox As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents enlargePreviewBtn As Button
End Class
