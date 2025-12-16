<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BaseSlideEdit
    Inherits Form

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
        Me.googleSlidesLink = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.updateBtn = New System.Windows.Forms.Button()
        Me.TitleFontBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TitleColorBtn = New System.Windows.Forms.Button()
        Me.BodyColorBtn = New System.Windows.Forms.Button()
        Me.BodyFontBtn = New System.Windows.Forms.Button()
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
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.previewBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'useTxtFile
        '
        Me.useTxtFile.AutoSize = True
        Me.useTxtFile.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.useTxtFile.Location = New System.Drawing.Point(3, 3)
        Me.useTxtFile.Name = "useTxtFile"
        Me.useTxtFile.Size = New System.Drawing.Size(109, 17)
        Me.useTxtFile.TabIndex = 1
        Me.useTxtFile.Text = ".txt (PowerPoint)"
        Me.useTxtFile.UseVisualStyleBackColor = True
        '
        'useGoogleSlides
        '
        Me.useGoogleSlides.AutoSize = True
        Me.useGoogleSlides.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.useGoogleSlides.Location = New System.Drawing.Point(3, 26)
        Me.useGoogleSlides.Name = "useGoogleSlides"
        Me.useGoogleSlides.Size = New System.Drawing.Size(96, 17)
        Me.useGoogleSlides.TabIndex = 0
        Me.useGoogleSlides.Text = "Google Slides"
        Me.useGoogleSlides.UseVisualStyleBackColor = True
        '
        'googleSlidesLink
        '
        Me.googleSlidesLink.Dock = System.Windows.Forms.DockStyle.Top
        Me.googleSlidesLink.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.googleSlidesLink.Location = New System.Drawing.Point(5, 64)
        Me.googleSlidesLink.Margin = New System.Windows.Forms.Padding(0)
        Me.googleSlidesLink.Name = "googleSlidesLink"
        Me.googleSlidesLink.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.googleSlidesLink.Size = New System.Drawing.Size(495, 23)
        Me.googleSlidesLink.TabIndex = 3
        Me.googleSlidesLink.Text = "https://"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 87)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(278, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "* Ensure to include website protocol. I.e., https:// or http://"
        '
        'txtInput
        '
        Me.txtInput.AcceptsReturn = True
        Me.txtInput.AcceptsTab = True
        Me.txtInput.AllowDrop = True
        Me.txtInput.BackColor = System.Drawing.Color.White
        Me.txtInput.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtInput.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.ForeColor = System.Drawing.Color.Black
        Me.txtInput.Location = New System.Drawing.Point(5, 117)
        Me.txtInput.MinimumSize = New System.Drawing.Size(4, 260)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtInput.Size = New System.Drawing.Size(495, 260)
        Me.txtInput.TabIndex = 2
        Me.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtInput.WordWrap = False
        '
        'updateBtn
        '
        Me.updateBtn.AutoSize = True
        Me.updateBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.updateBtn.BackgroundImage = Global.TJCPowerPoint.My.Resources.Resources.background
        Me.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.updateBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.updateBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateBtn.ForeColor = System.Drawing.Color.White
        Me.updateBtn.Location = New System.Drawing.Point(557, 0)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Padding = New System.Windows.Forms.Padding(40, 5, 40, 5)
        Me.updateBtn.Size = New System.Drawing.Size(173, 40)
        Me.updateBtn.TabIndex = 22
        Me.updateBtn.Text = "Update Slide"
        Me.updateBtn.UseVisualStyleBackColor = True
        '
        'TitleFontBtn
        '
        Me.TitleFontBtn.AutoSize = True
        Me.TitleFontBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TitleFontBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TitleFontBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TitleFontBtn.Image = Global.TJCPowerPoint.My.Resources.Resources.icons8_font_16
        Me.TitleFontBtn.Location = New System.Drawing.Point(35, 3)
        Me.TitleFontBtn.Name = "TitleFontBtn"
        Me.TitleFontBtn.Size = New System.Drawing.Size(22, 22)
        Me.TitleFontBtn.TabIndex = 27
        Me.TitleFontBtn.TabStop = False
        Me.TitleFontBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(88, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 31)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Body"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TitleColorBtn
        '
        Me.TitleColorBtn.AutoSize = True
        Me.TitleColorBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TitleColorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TitleColorBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TitleColorBtn.Image = Global.TJCPowerPoint.My.Resources.Resources.icons8_color_16
        Me.TitleColorBtn.Location = New System.Drawing.Point(63, 3)
        Me.TitleColorBtn.Name = "TitleColorBtn"
        Me.TitleColorBtn.Size = New System.Drawing.Size(22, 22)
        Me.TitleColorBtn.TabIndex = 26
        Me.TitleColorBtn.TabStop = False
        Me.TitleColorBtn.UseVisualStyleBackColor = True
        '
        'BodyColorBtn
        '
        Me.BodyColorBtn.BackgroundImage = CType(resources.GetObject("BodyColorBtn.BackgroundImage"), System.Drawing.Image)
        Me.BodyColorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BodyColorBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BodyColorBtn.Location = New System.Drawing.Point(152, 3)
        Me.BodyColorBtn.Name = "BodyColorBtn"
        Me.BodyColorBtn.Size = New System.Drawing.Size(25, 25)
        Me.BodyColorBtn.TabIndex = 24
        Me.BodyColorBtn.TabStop = False
        Me.BodyColorBtn.UseVisualStyleBackColor = True
        '
        'BodyFontBtn
        '
        Me.BodyFontBtn.BackgroundImage = CType(resources.GetObject("BodyFontBtn.BackgroundImage"), System.Drawing.Image)
        Me.BodyFontBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BodyFontBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BodyFontBtn.Location = New System.Drawing.Point(121, 3)
        Me.BodyFontBtn.Name = "BodyFontBtn"
        Me.BodyFontBtn.Size = New System.Drawing.Size(25, 25)
        Me.BodyFontBtn.TabIndex = 25
        Me.BodyFontBtn.TabStop = False
        Me.BodyFontBtn.UseVisualStyleBackColor = True
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
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.header.Location = New System.Drawing.Point(5, 30)
        Me.header.Margin = New System.Windows.Forms.Padding(0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(76, 17)
        Me.header.TabIndex = 30
        Me.header.Text = "Slide Name"
        Me.header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 31)
        Me.Label2.TabIndex = 29
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'loadTxtBtn
        '
        Me.loadTxtBtn.AutoSize = True
        Me.loadTxtBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.loadTxtBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loadTxtBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.loadTxtBtn.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loadTxtBtn.ForeColor = System.Drawing.SystemColors.Desktop
        Me.loadTxtBtn.Location = New System.Drawing.Point(451, 0)
        Me.loadTxtBtn.Name = "loadTxtBtn"
        Me.loadTxtBtn.Size = New System.Drawing.Size(106, 40)
        Me.loadTxtBtn.TabIndex = 23
        Me.loadTxtBtn.TabStop = False
        Me.loadTxtBtn.Text = "Insert as .txt file"
        Me.loadTxtBtn.UseVisualStyleBackColor = True
        '
        'insertImage
        '
        Me.insertImage.AutoSize = True
        Me.insertImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.insertImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.insertImage.Dock = System.Windows.Forms.DockStyle.Right
        Me.insertImage.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insertImage.ForeColor = System.Drawing.SystemColors.Desktop
        Me.insertImage.Location = New System.Drawing.Point(338, 0)
        Me.insertImage.Name = "insertImage"
        Me.insertImage.Padding = New System.Windows.Forms.Padding(5)
        Me.insertImage.Size = New System.Drawing.Size(113, 40)
        Me.insertImage.TabIndex = 35
        Me.insertImage.TabStop = False
        Me.insertImage.Text = "Insert as Image"
        Me.insertImage.UseVisualStyleBackColor = True
        '
        'delImage
        '
        Me.delImage.AutoSize = True
        Me.delImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.delImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delImage.Dock = System.Windows.Forms.DockStyle.Left
        Me.delImage.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delImage.ForeColor = System.Drawing.Color.DarkRed
        Me.delImage.Location = New System.Drawing.Point(0, 0)
        Me.delImage.Name = "delImage"
        Me.delImage.Size = New System.Drawing.Size(94, 40)
        Me.delImage.TabIndex = 36
        Me.delImage.TabStop = False
        Me.delImage.Text = "Delete Image"
        Me.delImage.UseVisualStyleBackColor = True
        '
        'previewBox
        '
        Me.previewBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.previewBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.previewBox.Image = Global.TJCPowerPoint.My.Resources.Resources.background
        Me.previewBox.Location = New System.Drawing.Point(5, 260)
        Me.previewBox.Name = "previewBox"
        Me.previewBox.Size = New System.Drawing.Size(203, 119)
        Me.previewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.previewBox.TabIndex = 37
        Me.previewBox.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 17)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Preview"
        '
        'enlargePreviewBtn
        '
        Me.enlargePreviewBtn.BackColor = System.Drawing.Color.Transparent
        Me.enlargePreviewBtn.BackgroundImage = CType(resources.GetObject("enlargePreviewBtn.BackgroundImage"), System.Drawing.Image)
        Me.enlargePreviewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.enlargePreviewBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.enlargePreviewBtn.FlatAppearance.BorderSize = 0
        Me.enlargePreviewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.enlargePreviewBtn.Location = New System.Drawing.Point(180, 351)
        Me.enlargePreviewBtn.Name = "enlargePreviewBtn"
        Me.enlargePreviewBtn.Size = New System.Drawing.Size(25, 25)
        Me.enlargePreviewBtn.TabIndex = 39
        Me.enlargePreviewBtn.TabStop = False
        Me.enlargePreviewBtn.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoSize = True
        Me.FlowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel2.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label7)
        Me.FlowLayoutPanel2.Controls.Add(Me.TitleFontBtn)
        Me.FlowLayoutPanel2.Controls.Add(Me.TitleColorBtn)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel2.Controls.Add(Me.BodyFontBtn)
        Me.FlowLayoutPanel2.Controls.Add(Me.BodyColorBtn)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(5, 85)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(203, 31)
        Me.FlowLayoutPanel2.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 31)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Title"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 390.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(730, 390)
        Me.TableLayoutPanel1.TabIndex = 42
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtInput)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.googleSlidesLink)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.header)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(5, 30, 5, 5)
        Me.Panel2.Size = New System.Drawing.Size(505, 384)
        Me.Panel2.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(5, 100)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 17)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Slide Content"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(5, 47)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 17)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Google Slides Link"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.AutoSize = True
        Me.Panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel3.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel3.Controls.Add(Me.FlowLayoutPanel2)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.FlowLayoutPanel3)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.enlargePreviewBtn)
        Me.Panel3.Controls.Add(Me.previewBox)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(514, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel3.Size = New System.Drawing.Size(213, 384)
        Me.Panel3.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 17)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Formatting:"
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.AutoSize = True
        Me.FlowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel3.Controls.Add(Me.useTxtFile)
        Me.FlowLayoutPanel3.Controls.Add(Me.useGoogleSlides)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(5, 22)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(203, 46)
        Me.FlowLayoutPanel3.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 17)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Slide Type:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(10, 10)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 30)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Edit Slide"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Controls.Add(Me.insertImage)
        Me.Panel1.Controls.Add(Me.loadTxtBtn)
        Me.Panel1.Controls.Add(Me.updateBtn)
        Me.Panel1.Controls.Add(Me.delImage)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(10, 400)
        Me.Panel1.MinimumSize = New System.Drawing.Size(0, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(730, 40)
        Me.Panel1.TabIndex = 43
        '
        'BaseSlideEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(750, 450)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "BaseSlideEdit"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "BaseSlideEdit"
        CType(Me.previewBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents useTxtFile As RadioButton
    Friend WithEvents useGoogleSlides As RadioButton
    Friend WithEvents googleSlidesLink As TextBox
    Public WithEvents txtInput As TextBox
    Friend WithEvents updateBtn As Button
    Friend WithEvents TitleFontBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TitleColorBtn As Button
    Friend WithEvents BodyColorBtn As Button
    Friend WithEvents BodyFontBtn As Button
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
    Friend WithEvents Label5 As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
End Class
