<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainProgram
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainProgram))
        Me.EnglishTitle = New System.Windows.Forms.TextBox()
        Me.ChineseTitle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HymnNos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.HymnChange = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.HymnalTitle = New System.Windows.Forms.Button()
        Me.ServiceTypeFontBtn = New System.Windows.Forms.Button()
        Me.ServiceTypeColorBtn = New System.Windows.Forms.Button()
        Me.ServiceType = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ShowVerses = New System.Windows.Forms.CheckBox()
        Me.ShowHymn = New System.Windows.Forms.CheckBox()
        Me.UpdateTitle = New System.Windows.Forms.Button()
        Me.HymnFontBtn = New System.Windows.Forms.Button()
        Me.HymnColorBtn = New System.Windows.Forms.Button()
        Me.EnglishColorBtn = New System.Windows.Forms.Button()
        Me.EnglishFontBtn = New System.Windows.Forms.Button()
        Me.ChineseFontBtn = New System.Windows.Forms.Button()
        Me.ChineseColorBtn = New System.Windows.Forms.Button()
        Me.BibleVerse = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.clearbtn = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.HymnHDColor = New System.Windows.Forms.Button()
        Me.HymnHDFont = New System.Windows.Forms.Button()
        Me.BibleHDColor = New System.Windows.Forms.Button()
        Me.BibleHDFont = New System.Windows.Forms.Button()
        Me.UpdateVerse = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ChineseBookColorBtn = New System.Windows.Forms.Button()
        Me.ChineseBookFontBtn = New System.Windows.Forms.Button()
        Me.BookBox = New System.Windows.Forms.ComboBox()
        Me.EnglishBookColorBtn = New System.Windows.Forms.Button()
        Me.EnglishBookFontBtn = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.VerseTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CVColorBtn = New System.Windows.Forms.Button()
        Me.ChapterTxt = New System.Windows.Forms.TextBox()
        Me.CVFontBtn = New System.Windows.Forms.Button()
        Me.SaveSettings = New System.Windows.Forms.Button()
        Me.FontDialog = New System.Windows.Forms.FontDialog()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.SlideTrack = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ShowPR = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.OpenFolder = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.Time = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Show_AN = New System.Windows.Forms.Button()
        Me.BGColor = New System.Windows.Forms.Button()
        Me.edtPrayerImg = New System.Windows.Forms.Button()
        Me.edtHC = New System.Windows.Forms.Button()
        Me.Title.SuspendLayout()
        Me.BibleVerse.SuspendLayout()
        Me.SuspendLayout()
        '
        'EnglishTitle
        '
        Me.EnglishTitle.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnglishTitle.Location = New System.Drawing.Point(67, 17)
        Me.EnglishTitle.Name = "EnglishTitle"
        Me.EnglishTitle.Size = New System.Drawing.Size(650, 31)
        Me.EnglishTitle.TabIndex = 0
        Me.EnglishTitle.TabStop = False
        Me.EnglishTitle.WordWrap = False
        '
        'ChineseTitle
        '
        Me.ChineseTitle.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChineseTitle.Location = New System.Drawing.Point(67, 56)
        Me.ChineseTitle.Name = "ChineseTitle"
        Me.ChineseTitle.Size = New System.Drawing.Size(650, 31)
        Me.ChineseTitle.TabIndex = 1
        Me.ChineseTitle.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "English"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Chinese"
        '
        'HymnNos
        '
        Me.HymnNos.Location = New System.Drawing.Point(67, 93)
        Me.HymnNos.Multiline = True
        Me.HymnNos.Name = "HymnNos"
        Me.HymnNos.Size = New System.Drawing.Size(80, 90)
        Me.HymnNos.TabIndex = 4
        Me.HymnNos.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Hymns"
        '
        'HymnChange
        '
        Me.HymnChange.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.HymnChange.FlatAppearance.BorderSize = 0
        Me.HymnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HymnChange.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HymnChange.ForeColor = System.Drawing.Color.Black
        Me.HymnChange.Location = New System.Drawing.Point(154, 124)
        Me.HymnChange.Name = "HymnChange"
        Me.HymnChange.Size = New System.Drawing.Size(68, 58)
        Me.HymnChange.TabIndex = 5
        Me.HymnChange.TabStop = False
        Me.HymnChange.Text = "Change Hymns"
        Me.HymnChange.UseVisualStyleBackColor = False
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.SystemColors.Desktop
        Me.Title.Controls.Add(Me.Label16)
        Me.Title.Controls.Add(Me.HymnalTitle)
        Me.Title.Controls.Add(Me.ServiceTypeFontBtn)
        Me.Title.Controls.Add(Me.ServiceTypeColorBtn)
        Me.Title.Controls.Add(Me.ServiceType)
        Me.Title.Controls.Add(Me.Label11)
        Me.Title.Controls.Add(Me.ShowVerses)
        Me.Title.Controls.Add(Me.ShowHymn)
        Me.Title.Controls.Add(Me.UpdateTitle)
        Me.Title.Controls.Add(Me.EnglishTitle)
        Me.Title.Controls.Add(Me.HymnChange)
        Me.Title.Controls.Add(Me.ChineseTitle)
        Me.Title.Controls.Add(Me.HymnFontBtn)
        Me.Title.Controls.Add(Me.Label1)
        Me.Title.Controls.Add(Me.HymnColorBtn)
        Me.Title.Controls.Add(Me.Label2)
        Me.Title.Controls.Add(Me.Label4)
        Me.Title.Controls.Add(Me.EnglishColorBtn)
        Me.Title.Controls.Add(Me.HymnNos)
        Me.Title.Controls.Add(Me.EnglishFontBtn)
        Me.Title.Controls.Add(Me.ChineseFontBtn)
        Me.Title.Controls.Add(Me.ChineseColorBtn)
        Me.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Title.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Title.Location = New System.Drawing.Point(12, 12)
        Me.Title.Margin = New System.Windows.Forms.Padding(0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(785, 190)
        Me.Title.TabIndex = 14
        Me.Title.TabStop = False
        Me.Title.Text = "Title"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label16.Location = New System.Drawing.Point(326, 143)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(138, 15)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "(press enter to update)"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'HymnalTitle
        '
        Me.HymnalTitle.BackColor = System.Drawing.Color.DarkGray
        Me.HymnalTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HymnalTitle.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HymnalTitle.ForeColor = System.Drawing.Color.Black
        Me.HymnalTitle.Location = New System.Drawing.Point(506, 94)
        Me.HymnalTitle.Name = "HymnalTitle"
        Me.HymnalTitle.Size = New System.Drawing.Size(273, 31)
        Me.HymnalTitle.TabIndex = 20
        Me.HymnalTitle.TabStop = False
        Me.HymnalTitle.Text = "Change Title To ""Hymnal"""
        Me.HymnalTitle.UseVisualStyleBackColor = False
        '
        'ServiceTypeFontBtn
        '
        Me.ServiceTypeFontBtn.BackgroundImage = CType(resources.GetObject("ServiceTypeFontBtn.BackgroundImage"), System.Drawing.Image)
        Me.ServiceTypeFontBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ServiceTypeFontBtn.Location = New System.Drawing.Point(475, 159)
        Me.ServiceTypeFontBtn.Name = "ServiceTypeFontBtn"
        Me.ServiceTypeFontBtn.Size = New System.Drawing.Size(25, 25)
        Me.ServiceTypeFontBtn.TabIndex = 15
        Me.ServiceTypeFontBtn.TabStop = False
        Me.ServiceTypeFontBtn.UseVisualStyleBackColor = True
        '
        'ServiceTypeColorBtn
        '
        Me.ServiceTypeColorBtn.BackgroundImage = CType(resources.GetObject("ServiceTypeColorBtn.BackgroundImage"), System.Drawing.Image)
        Me.ServiceTypeColorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ServiceTypeColorBtn.Location = New System.Drawing.Point(445, 159)
        Me.ServiceTypeColorBtn.Name = "ServiceTypeColorBtn"
        Me.ServiceTypeColorBtn.Size = New System.Drawing.Size(25, 25)
        Me.ServiceTypeColorBtn.TabIndex = 14
        Me.ServiceTypeColorBtn.TabStop = False
        Me.ServiceTypeColorBtn.UseVisualStyleBackColor = True
        '
        'ServiceType
        '
        Me.ServiceType.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServiceType.Location = New System.Drawing.Point(228, 161)
        Me.ServiceType.Name = "ServiceType"
        Me.ServiceType.Size = New System.Drawing.Size(214, 22)
        Me.ServiceType.TabIndex = 6
        Me.ServiceType.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(228, 140)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 18)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Service Type"
        '
        'ShowVerses
        '
        Me.ShowVerses.AutoSize = True
        Me.ShowVerses.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowVerses.Location = New System.Drawing.Point(348, 100)
        Me.ShowVerses.Name = "ShowVerses"
        Me.ShowVerses.Size = New System.Drawing.Size(139, 21)
        Me.ShowVerses.TabIndex = 17
        Me.ShowVerses.TabStop = False
        Me.ShowVerses.Text = "Show Bible Verses"
        Me.ShowVerses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ShowVerses.UseVisualStyleBackColor = True
        '
        'ShowHymn
        '
        Me.ShowHymn.AutoSize = True
        Me.ShowHymn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowHymn.Location = New System.Drawing.Point(237, 100)
        Me.ShowHymn.Name = "ShowHymn"
        Me.ShowHymn.Size = New System.Drawing.Size(107, 21)
        Me.ShowHymn.TabIndex = 18
        Me.ShowHymn.TabStop = False
        Me.ShowHymn.Text = "Show Hymns"
        Me.ShowHymn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ShowHymn.UseVisualStyleBackColor = True
        '
        'UpdateTitle
        '
        Me.UpdateTitle.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.UpdateTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.UpdateTitle.FlatAppearance.BorderSize = 0
        Me.UpdateTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateTitle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateTitle.ForeColor = System.Drawing.Color.Black
        Me.UpdateTitle.Location = New System.Drawing.Point(506, 133)
        Me.UpdateTitle.Name = "UpdateTitle"
        Me.UpdateTitle.Size = New System.Drawing.Size(273, 50)
        Me.UpdateTitle.TabIndex = 3
        Me.UpdateTitle.TabStop = False
        Me.UpdateTitle.Text = "Update Title"
        Me.UpdateTitle.UseVisualStyleBackColor = False
        '
        'HymnFontBtn
        '
        Me.HymnFontBtn.BackgroundImage = CType(resources.GetObject("HymnFontBtn.BackgroundImage"), System.Drawing.Image)
        Me.HymnFontBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HymnFontBtn.Location = New System.Drawing.Point(184, 93)
        Me.HymnFontBtn.Name = "HymnFontBtn"
        Me.HymnFontBtn.Size = New System.Drawing.Size(25, 25)
        Me.HymnFontBtn.TabIndex = 12
        Me.HymnFontBtn.TabStop = False
        Me.HymnFontBtn.UseVisualStyleBackColor = True
        '
        'HymnColorBtn
        '
        Me.HymnColorBtn.BackgroundImage = CType(resources.GetObject("HymnColorBtn.BackgroundImage"), System.Drawing.Image)
        Me.HymnColorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HymnColorBtn.Location = New System.Drawing.Point(153, 93)
        Me.HymnColorBtn.Name = "HymnColorBtn"
        Me.HymnColorBtn.Size = New System.Drawing.Size(25, 25)
        Me.HymnColorBtn.TabIndex = 11
        Me.HymnColorBtn.TabStop = False
        Me.HymnColorBtn.UseVisualStyleBackColor = True
        '
        'EnglishColorBtn
        '
        Me.EnglishColorBtn.BackgroundImage = CType(resources.GetObject("EnglishColorBtn.BackgroundImage"), System.Drawing.Image)
        Me.EnglishColorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EnglishColorBtn.Location = New System.Drawing.Point(723, 17)
        Me.EnglishColorBtn.Name = "EnglishColorBtn"
        Me.EnglishColorBtn.Size = New System.Drawing.Size(25, 25)
        Me.EnglishColorBtn.TabIndex = 5
        Me.EnglishColorBtn.TabStop = False
        Me.EnglishColorBtn.UseVisualStyleBackColor = True
        '
        'EnglishFontBtn
        '
        Me.EnglishFontBtn.BackgroundImage = CType(resources.GetObject("EnglishFontBtn.BackgroundImage"), System.Drawing.Image)
        Me.EnglishFontBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EnglishFontBtn.Location = New System.Drawing.Point(754, 17)
        Me.EnglishFontBtn.Name = "EnglishFontBtn"
        Me.EnglishFontBtn.Size = New System.Drawing.Size(25, 25)
        Me.EnglishFontBtn.TabIndex = 6
        Me.EnglishFontBtn.TabStop = False
        Me.EnglishFontBtn.UseVisualStyleBackColor = True
        '
        'ChineseFontBtn
        '
        Me.ChineseFontBtn.BackgroundImage = CType(resources.GetObject("ChineseFontBtn.BackgroundImage"), System.Drawing.Image)
        Me.ChineseFontBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ChineseFontBtn.Location = New System.Drawing.Point(754, 58)
        Me.ChineseFontBtn.Name = "ChineseFontBtn"
        Me.ChineseFontBtn.Size = New System.Drawing.Size(25, 25)
        Me.ChineseFontBtn.TabIndex = 8
        Me.ChineseFontBtn.TabStop = False
        Me.ChineseFontBtn.UseVisualStyleBackColor = True
        '
        'ChineseColorBtn
        '
        Me.ChineseColorBtn.BackgroundImage = CType(resources.GetObject("ChineseColorBtn.BackgroundImage"), System.Drawing.Image)
        Me.ChineseColorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ChineseColorBtn.Location = New System.Drawing.Point(723, 58)
        Me.ChineseColorBtn.Name = "ChineseColorBtn"
        Me.ChineseColorBtn.Size = New System.Drawing.Size(25, 25)
        Me.ChineseColorBtn.TabIndex = 7
        Me.ChineseColorBtn.TabStop = False
        Me.ChineseColorBtn.UseVisualStyleBackColor = True
        '
        'BibleVerse
        '
        Me.BibleVerse.BackColor = System.Drawing.SystemColors.Control
        Me.BibleVerse.Controls.Add(Me.Label15)
        Me.BibleVerse.Controls.Add(Me.clearbtn)
        Me.BibleVerse.Controls.Add(Me.Label13)
        Me.BibleVerse.Controls.Add(Me.Label14)
        Me.BibleVerse.Controls.Add(Me.HymnHDColor)
        Me.BibleVerse.Controls.Add(Me.HymnHDFont)
        Me.BibleVerse.Controls.Add(Me.BibleHDColor)
        Me.BibleVerse.Controls.Add(Me.BibleHDFont)
        Me.BibleVerse.Controls.Add(Me.UpdateVerse)
        Me.BibleVerse.Controls.Add(Me.Label5)
        Me.BibleVerse.Controls.Add(Me.Label3)
        Me.BibleVerse.Controls.Add(Me.ChineseBookColorBtn)
        Me.BibleVerse.Controls.Add(Me.ChineseBookFontBtn)
        Me.BibleVerse.Controls.Add(Me.BookBox)
        Me.BibleVerse.Controls.Add(Me.EnglishBookColorBtn)
        Me.BibleVerse.Controls.Add(Me.EnglishBookFontBtn)
        Me.BibleVerse.Controls.Add(Me.Label9)
        Me.BibleVerse.Controls.Add(Me.Label8)
        Me.BibleVerse.Controls.Add(Me.Label7)
        Me.BibleVerse.Controls.Add(Me.VerseTxt)
        Me.BibleVerse.Controls.Add(Me.Label6)
        Me.BibleVerse.Controls.Add(Me.CVColorBtn)
        Me.BibleVerse.Controls.Add(Me.ChapterTxt)
        Me.BibleVerse.Controls.Add(Me.CVFontBtn)
        Me.BibleVerse.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BibleVerse.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BibleVerse.Location = New System.Drawing.Point(12, 208)
        Me.BibleVerse.Name = "BibleVerse"
        Me.BibleVerse.Size = New System.Drawing.Size(785, 144)
        Me.BibleVerse.TabIndex = 16
        Me.BibleVerse.TabStop = False
        Me.BibleVerse.Text = "BibleVerse(s)"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(631, 124)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(152, 15)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "(or press enter to update)"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'clearbtn
        '
        Me.clearbtn.BackColor = System.Drawing.SystemColors.Control
        Me.clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.clearbtn.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearbtn.ForeColor = System.Drawing.Color.Black
        Me.clearbtn.Location = New System.Drawing.Point(470, 83)
        Me.clearbtn.Name = "clearbtn"
        Me.clearbtn.Size = New System.Drawing.Size(54, 40)
        Me.clearbtn.TabIndex = 33
        Me.clearbtn.TabStop = False
        Me.clearbtn.Text = "Reset"
        Me.clearbtn.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(321, 79)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 17)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Hymn Heading"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(233, 79)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 17)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Bible Heading"
        '
        'HymnHDColor
        '
        Me.HymnHDColor.BackgroundImage = CType(resources.GetObject("HymnHDColor.BackgroundImage"), System.Drawing.Image)
        Me.HymnHDColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HymnHDColor.Location = New System.Drawing.Point(332, 99)
        Me.HymnHDColor.Name = "HymnHDColor"
        Me.HymnHDColor.Size = New System.Drawing.Size(25, 25)
        Me.HymnHDColor.TabIndex = 29
        Me.HymnHDColor.TabStop = False
        Me.HymnHDColor.UseVisualStyleBackColor = True
        '
        'HymnHDFont
        '
        Me.HymnHDFont.BackgroundImage = CType(resources.GetObject("HymnHDFont.BackgroundImage"), System.Drawing.Image)
        Me.HymnHDFont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HymnHDFont.Location = New System.Drawing.Point(361, 99)
        Me.HymnHDFont.Name = "HymnHDFont"
        Me.HymnHDFont.Size = New System.Drawing.Size(25, 25)
        Me.HymnHDFont.TabIndex = 30
        Me.HymnHDFont.TabStop = False
        Me.HymnHDFont.UseVisualStyleBackColor = True
        '
        'BibleHDColor
        '
        Me.BibleHDColor.BackgroundImage = CType(resources.GetObject("BibleHDColor.BackgroundImage"), System.Drawing.Image)
        Me.BibleHDColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BibleHDColor.Location = New System.Drawing.Point(243, 99)
        Me.BibleHDColor.Name = "BibleHDColor"
        Me.BibleHDColor.Size = New System.Drawing.Size(25, 25)
        Me.BibleHDColor.TabIndex = 27
        Me.BibleHDColor.TabStop = False
        Me.BibleHDColor.UseVisualStyleBackColor = True
        '
        'BibleHDFont
        '
        Me.BibleHDFont.BackgroundImage = CType(resources.GetObject("BibleHDFont.BackgroundImage"), System.Drawing.Image)
        Me.BibleHDFont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BibleHDFont.Location = New System.Drawing.Point(272, 99)
        Me.BibleHDFont.Name = "BibleHDFont"
        Me.BibleHDFont.Size = New System.Drawing.Size(25, 25)
        Me.BibleHDFont.TabIndex = 28
        Me.BibleHDFont.TabStop = False
        Me.BibleHDFont.UseVisualStyleBackColor = True
        '
        'UpdateVerse
        '
        Me.UpdateVerse.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.UpdateVerse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateVerse.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateVerse.ForeColor = System.Drawing.Color.Black
        Me.UpdateVerse.Location = New System.Drawing.Point(530, 83)
        Me.UpdateVerse.Name = "UpdateVerse"
        Me.UpdateVerse.Size = New System.Drawing.Size(249, 40)
        Me.UpdateVerse.TabIndex = 3
        Me.UpdateVerse.TabStop = False
        Me.UpdateVerse.Text = "Update Chapter and Verse"
        Me.UpdateVerse.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(94, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 17)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Chinese Book"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "English Book"
        '
        'ChineseBookColorBtn
        '
        Me.ChineseBookColorBtn.BackgroundImage = CType(resources.GetObject("ChineseBookColorBtn.BackgroundImage"), System.Drawing.Image)
        Me.ChineseBookColorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ChineseBookColorBtn.Location = New System.Drawing.Point(105, 98)
        Me.ChineseBookColorBtn.Name = "ChineseBookColorBtn"
        Me.ChineseBookColorBtn.Size = New System.Drawing.Size(25, 25)
        Me.ChineseBookColorBtn.TabIndex = 23
        Me.ChineseBookColorBtn.TabStop = False
        Me.ChineseBookColorBtn.UseVisualStyleBackColor = True
        '
        'ChineseBookFontBtn
        '
        Me.ChineseBookFontBtn.BackgroundImage = CType(resources.GetObject("ChineseBookFontBtn.BackgroundImage"), System.Drawing.Image)
        Me.ChineseBookFontBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ChineseBookFontBtn.Location = New System.Drawing.Point(134, 98)
        Me.ChineseBookFontBtn.Name = "ChineseBookFontBtn"
        Me.ChineseBookFontBtn.Size = New System.Drawing.Size(25, 25)
        Me.ChineseBookFontBtn.TabIndex = 24
        Me.ChineseBookFontBtn.TabStop = False
        Me.ChineseBookFontBtn.UseVisualStyleBackColor = True
        '
        'BookBox
        '
        Me.BookBox.AutoCompleteCustomSource.AddRange(New String() {"Genesis,創 世 紀", "Exodus,出 埃 及 記", "Leviticus,利 未 記", "Numbers,民 數 記", "Deuteronomy,申 命 記", "Joshua,約 書 亞 記", "Judges,士 師 記", "Ruth,路 得 記", "1 Samuel,撒 母 耳 記 上", "2 Samuel,撒 母 耳 記 下", "1 Kings,列 王 記 上", "2 Kings,列 王 記 下", "1 Chronicles,歷 代 志 上", "2 Chronicles,歷 代 志 下", "Ezra,以 斯 拉 記", "Nehemiah,尼 希 米 記", "Esther,以 斯 帖 記", "Job,約 伯 記", "Psalms,詩 篇", "Proverbs,箴 言", "Ecclesiastes,傳 道 書", "Song of Songs,雅 歌", "Isaiah,以 賽 亞 書", "Jeremiah,耶 利 米 書", "Lamentations,耶 利 米 哀 歌", "Ezekiel,以 西 結 書", "Daniel,但 以 理 書", "Hosea,何 西 阿 書", "Joel,約 珥 書", "Amos,阿 摩 司 書", "Obadiah,俄 巴 底 亞 書", "Jonah,約 拿 書", "Micah,彌 迦 書", "Nahum,那 鴻 書", "Habakkuk,哈 巴 谷 書", "Zephaniah,西 番 雅 書", "Haggai,哈 該 書", "Zechariah,撒 迦 利 亞", "Malachi,瑪 拉 基 書", "Matthew,馬 太 福 音", "Mark,馬 可 福 音", "Luke,路 加 福 音", "John,約 翰 福 音", "Acts,使 徒 行 傳", "Romans,羅 馬 書", "1 Corinthians,哥 林 多 前 書", "2 Corinthians,哥 林 多 後 書", "Galatians,加 拉 太 書", "Ephesians,以 弗 所 書", "Philippians,腓 立 比 書", "Colossians,歌 羅 西 書", "1 Thessalonians,帖 撒 羅 尼 迦 前 書", "2 Thessalonians,帖 撒 羅 尼 迦 後 書", "1 Timothy,提 摩 太 前 書", "2 Timothy,提 摩 太 後 書", "Titus,提 多 書", "Philemon,腓 利 門 書", "Hebrews,希 伯 來 書", "James,雅 各 書", "1 Peter,彼 得 前 書", "2 Peter,彼 得 後 書", "1 John,約 翰 一 書", "2 John,約 翰 二 書", "3 John,約 翰 三 書", "Jude,猶 大 書", "Revelation,啟 示 錄"})
        Me.BookBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.BookBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BookBox.DropDownHeight = 100
        Me.BookBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BookBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BookBox.FormattingEnabled = True
        Me.BookBox.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.BookBox.IntegralHeight = False
        Me.BookBox.Items.AddRange(New Object() {"Genesis,創世紀", "Exodus,出埃及記", "Leviticus,利未記", "Numbers,民數記", "Deuteronomy,申命記", "Joshua,約書亞記", "Judges,士師記", "Ruth,路得記", "1 Samuel,撒母耳記上", "2 Samuel,撒母耳記下", "1 Kings,列王記上", "2 Kings,列王記下", "1 Chronicles,歷代志上", "2 Chronicles,歷代志下", "Ezra,以斯拉記", "Nehemiah,尼希米記", "Esther,以斯帖記", "Job,約伯記", "Psalms,詩篇", "Proverbs,箴言", "Ecclesiastes,傳道書", "Song of Songs,雅歌", "Isaiah,以賽亞書", "Jeremiah,耶利米書", "Lamentations,耶利米哀歌", "Ezekiel,以西結書", "Daniel,但以理書", "Hosea,何西阿書", "Joel,約珥書", "Amos,阿摩司書", "Obadiah,俄巴底亞書", "Jonah,約拿書", "Micah,彌迦書", "Nahum,那鴻書", "Habakkuk,哈巴谷書", "Zephaniah,西番雅書", "Haggai,哈該書", "Zechariah,撒迦利亞", "Malachi,瑪拉基書", "Matthew,馬太福音", "Mark,馬可福音", "Luke,路加福音", "John,約翰福音", "Acts,使徒行傳", "Romans,羅馬書", "1 Corinthians,哥林多前書", "2 Corinthians,哥林多後書", "Galatians,加拉太書", "Ephesians,以弗所書", "Philippians,腓立比書", "Colossians,歌羅西書", "1 Thessalonians,帖撒羅尼迦前書", "2 Thessalonians,帖撒羅尼迦後書", "1 Timothy,提摩太前書", "2 Timothy,提摩太後書", "Titus,提多書", "Philemon,腓利門書", "Hebrews,希伯來書", "James,雅各書", "1 Peter,彼得前書", "2 Peter,彼得後書", "1 John,約翰一書", "2 John,約翰二書", "3 John,約翰三書", "Jude,猶大書", "Revelation,啟示錄"})
        Me.BookBox.Location = New System.Drawing.Point(16, 47)
        Me.BookBox.MaxDropDownItems = 5
        Me.BookBox.Name = "BookBox"
        Me.BookBox.Size = New System.Drawing.Size(392, 27)
        Me.BookBox.TabIndex = 0
        '
        'EnglishBookColorBtn
        '
        Me.EnglishBookColorBtn.BackgroundImage = CType(resources.GetObject("EnglishBookColorBtn.BackgroundImage"), System.Drawing.Image)
        Me.EnglishBookColorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EnglishBookColorBtn.Location = New System.Drawing.Point(16, 98)
        Me.EnglishBookColorBtn.Name = "EnglishBookColorBtn"
        Me.EnglishBookColorBtn.Size = New System.Drawing.Size(25, 25)
        Me.EnglishBookColorBtn.TabIndex = 19
        Me.EnglishBookColorBtn.TabStop = False
        Me.EnglishBookColorBtn.UseVisualStyleBackColor = True
        '
        'EnglishBookFontBtn
        '
        Me.EnglishBookFontBtn.BackgroundImage = CType(resources.GetObject("EnglishBookFontBtn.BackgroundImage"), System.Drawing.Image)
        Me.EnglishBookFontBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EnglishBookFontBtn.Location = New System.Drawing.Point(45, 98)
        Me.EnglishBookFontBtn.Name = "EnglishBookFontBtn"
        Me.EnglishBookFontBtn.Size = New System.Drawing.Size(25, 25)
        Me.EnglishBookFontBtn.TabIndex = 20
        Me.EnglishBookFontBtn.TabStop = False
        Me.EnglishBookFontBtn.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(576, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Verse(s)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(472, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Chapter"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(547, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 32)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = ":"
        '
        'VerseTxt
        '
        Me.VerseTxt.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerseTxt.Location = New System.Drawing.Point(573, 46)
        Me.VerseTxt.Name = "VerseTxt"
        Me.VerseTxt.Size = New System.Drawing.Size(144, 31)
        Me.VerseTxt.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 18)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Book"
        '
        'CVColorBtn
        '
        Me.CVColorBtn.BackgroundImage = CType(resources.GetObject("CVColorBtn.BackgroundImage"), System.Drawing.Image)
        Me.CVColorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CVColorBtn.Location = New System.Drawing.Point(723, 45)
        Me.CVColorBtn.Name = "CVColorBtn"
        Me.CVColorBtn.Size = New System.Drawing.Size(25, 25)
        Me.CVColorBtn.TabIndex = 4
        Me.CVColorBtn.TabStop = False
        Me.CVColorBtn.UseVisualStyleBackColor = True
        '
        'ChapterTxt
        '
        Me.ChapterTxt.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChapterTxt.Location = New System.Drawing.Point(470, 45)
        Me.ChapterTxt.Name = "ChapterTxt"
        Me.ChapterTxt.Size = New System.Drawing.Size(71, 31)
        Me.ChapterTxt.TabIndex = 1
        '
        'CVFontBtn
        '
        Me.CVFontBtn.BackgroundImage = CType(resources.GetObject("CVFontBtn.BackgroundImage"), System.Drawing.Image)
        Me.CVFontBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CVFontBtn.Location = New System.Drawing.Point(754, 45)
        Me.CVFontBtn.Name = "CVFontBtn"
        Me.CVFontBtn.Size = New System.Drawing.Size(25, 25)
        Me.CVFontBtn.TabIndex = 6
        Me.CVFontBtn.TabStop = False
        Me.CVFontBtn.UseVisualStyleBackColor = True
        '
        'SaveSettings
        '
        Me.SaveSettings.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveSettings.Location = New System.Drawing.Point(687, 366)
        Me.SaveSettings.Name = "SaveSettings"
        Me.SaveSettings.Size = New System.Drawing.Size(110, 35)
        Me.SaveSettings.TabIndex = 17
        Me.SaveSettings.TabStop = False
        Me.SaveSettings.Text = "Save Configuration"
        Me.SaveSettings.UseVisualStyleBackColor = True
        '
        'FontDialog
        '
        Me.FontDialog.ShowEffects = False
        '
        'SlideTrack
        '
        Me.SlideTrack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SlideTrack.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlideTrack.FormattingEnabled = True
        Me.SlideTrack.Location = New System.Drawing.Point(120, 366)
        Me.SlideTrack.Name = "SlideTrack"
        Me.SlideTrack.Size = New System.Drawing.Size(160, 24)
        Me.SlideTrack.TabIndex = 4
        Me.SlideTrack.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(19, 366)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 18)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Go To Slide:"
        '
        'ShowPR
        '
        Me.ShowPR.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowPR.Location = New System.Drawing.Point(301, 366)
        Me.ShowPR.Name = "ShowPR"
        Me.ShowPR.Size = New System.Drawing.Size(138, 35)
        Me.ShowPR.TabIndex = 20
        Me.ShowPR.TabStop = False
        Me.ShowPR.Text = "Edit Prayer Requests"
        Me.ShowPR.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.Location = New System.Drawing.Point(687, 407)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(110, 35)
        Me.ExitBtn.TabIndex = 22
        Me.ExitBtn.TabStop = False
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'OpenFolder
        '
        Me.OpenFolder.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenFolder.Location = New System.Drawing.Point(570, 407)
        Me.OpenFolder.Name = "OpenFolder"
        Me.OpenFolder.Size = New System.Drawing.Size(109, 35)
        Me.OpenFolder.TabIndex = 23
        Me.OpenFolder.TabStop = False
        Me.OpenFolder.Text = "Open Folder"
        Me.OpenFolder.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(19, 400)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(230, 16)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Change Current Slide Background Colour"
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.FileName = "Settings.ini"
        Me.SaveFileDialog.Filter = "INI Files (*.ini)|*.ini|All Files (*.*)|*.*"""
        Me.SaveFileDialog.RestoreDirectory = True
        '
        'Time
        '
        Me.Time.AutoSize = True
        Me.Time.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Time.Location = New System.Drawing.Point(19, 421)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(35, 16)
        Me.Time.TabIndex = 25
        Me.Time.Text = "Time:"
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 1000
        '
        'Show_AN
        '
        Me.Show_AN.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Show_AN.Location = New System.Drawing.Point(451, 366)
        Me.Show_AN.Name = "Show_AN"
        Me.Show_AN.Size = New System.Drawing.Size(109, 76)
        Me.Show_AN.TabIndex = 26
        Me.Show_AN.TabStop = False
        Me.Show_AN.Text = "Edit Announcements"
        Me.Show_AN.UseVisualStyleBackColor = True
        '
        'BGColor
        '
        Me.BGColor.BackgroundImage = CType(resources.GetObject("BGColor.BackgroundImage"), System.Drawing.Image)
        Me.BGColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BGColor.Location = New System.Drawing.Point(255, 400)
        Me.BGColor.Name = "BGColor"
        Me.BGColor.Size = New System.Drawing.Size(25, 25)
        Me.BGColor.TabIndex = 23
        Me.BGColor.TabStop = False
        Me.BGColor.UseVisualStyleBackColor = True
        '
        'edtPrayerImg
        '
        Me.edtPrayerImg.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtPrayerImg.Location = New System.Drawing.Point(301, 405)
        Me.edtPrayerImg.Name = "edtPrayerImg"
        Me.edtPrayerImg.Size = New System.Drawing.Size(138, 37)
        Me.edtPrayerImg.TabIndex = 27
        Me.edtPrayerImg.TabStop = False
        Me.edtPrayerImg.Text = "Edit Prayer Image"
        Me.edtPrayerImg.UseVisualStyleBackColor = True
        '
        'edtHC
        '
        Me.edtHC.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtHC.Location = New System.Drawing.Point(570, 366)
        Me.edtHC.Name = "edtHC"
        Me.edtHC.Size = New System.Drawing.Size(109, 35)
        Me.edtHC.TabIndex = 28
        Me.edtHC.TabStop = False
        Me.edtHC.Text = "Holy Communion"
        Me.edtHC.UseVisualStyleBackColor = True
        '
        'MainProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(809, 461)
        Me.Controls.Add(Me.edtHC)
        Me.Controls.Add(Me.edtPrayerImg)
        Me.Controls.Add(Me.Show_AN)
        Me.Controls.Add(Me.Time)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.BGColor)
        Me.Controls.Add(Me.OpenFolder)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.ShowPR)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.SlideTrack)
        Me.Controls.Add(Me.SaveSettings)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.BibleVerse)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(825, 500)
        Me.MinimumSize = New System.Drawing.Size(825, 500)
        Me.Name = "MainProgram"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "True Jesus Church PowerPoint"
        Me.Title.ResumeLayout(False)
        Me.Title.PerformLayout()
        Me.BibleVerse.ResumeLayout(False)
        Me.BibleVerse.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EnglishTitle As TextBox
    Friend WithEvents ChineseTitle As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EnglishColorBtn As Button
    Friend WithEvents EnglishFontBtn As Button
    Friend WithEvents ChineseFontBtn As Button
    Friend WithEvents ChineseColorBtn As Button
    Friend WithEvents HymnNos As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents HymnFontBtn As Button
    Friend WithEvents HymnColorBtn As Button
    Friend WithEvents HymnChange As Button
    Friend WithEvents Title As GroupBox
    Friend WithEvents BibleVerse As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents VerseTxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CVColorBtn As Button
    Friend WithEvents ChapterTxt As TextBox
    Friend WithEvents CVFontBtn As Button
    Friend WithEvents BookBox As ComboBox
    Friend WithEvents EnglishBookColorBtn As Button
    Friend WithEvents EnglishBookFontBtn As Button
    Friend WithEvents SaveSettings As Button
    Friend WithEvents ShowVerses As CheckBox
    Friend WithEvents ShowHymn As CheckBox
    Friend WithEvents UpdateTitle As Button
    Friend WithEvents ColorDialog As ColorDialog
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ChineseBookColorBtn As Button
    Friend WithEvents ChineseBookFontBtn As Button
    Friend WithEvents SlideTrack As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents UpdateVerse As Button
    Friend WithEvents ShowPR As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents OpenFolder As Button
    Friend WithEvents ServiceType As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ServiceTypeFontBtn As Button
    Friend WithEvents ServiceTypeColorBtn As Button
    Friend WithEvents BGColor As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents HymnHDColor As Button
    Friend WithEvents HymnHDFont As Button
    Friend WithEvents BibleHDColor As Button
    Friend WithEvents BibleHDFont As Button
    Friend WithEvents Time As Label
    Friend WithEvents Timer As Timer
    Public WithEvents FontDialog As FontDialog
    Friend WithEvents HymnalTitle As Button
    Friend WithEvents Show_AN As Button
    Friend WithEvents edtPrayerImg As Button
    Friend WithEvents edtHC As Button
    Friend WithEvents clearbtn As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
End Class
