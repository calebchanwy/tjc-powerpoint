<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainProgram
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainProgram))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ServiceTypeTxt = New System.Windows.Forms.ComboBox()
        Me.UpdateTitleBtn = New System.Windows.Forms.Button()
        Me.ResetAllBtn = New System.Windows.Forms.Button()
        Me.EnglishTitleTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EnglishFontBtn = New System.Windows.Forms.Button()
        Me.EnglishColorBtn = New System.Windows.Forms.Button()
        Me.EnglishMoveDownBtn = New System.Windows.Forms.Button()
        Me.EnglishMoveUpBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChineseFontBtn = New System.Windows.Forms.Button()
        Me.ChineseColorBtn = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ChineseTitleTxt = New System.Windows.Forms.TextBox()
        Me.EditSlidePanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.EditHCBtn = New System.Windows.Forms.Button()
        Me.EditTimetableBtn = New System.Windows.Forms.Button()
        Me.EditAnnouncementsBtn = New System.Windows.Forms.Button()
        Me.EditPRBtn = New System.Windows.Forms.Button()
        Me.ProjectSlidePanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.ShowSermonHymnsBtn = New System.Windows.Forms.RadioButton()
        Me.ShowHymnalBtn = New System.Windows.Forms.RadioButton()
        Me.ShowVersesBtn = New System.Windows.Forms.RadioButton()
        Me.ShowPRBtn = New System.Windows.Forms.RadioButton()
        Me.ShowHowToPrayBtn = New System.Windows.Forms.RadioButton()
        Me.ShowBreakBtn = New System.Windows.Forms.RadioButton()
        Me.ShowTimetableBtn = New System.Windows.Forms.RadioButton()
        Me.ShowAnnouncementsBtn = New System.Windows.Forms.RadioButton()
        Me.ShowHCBtn = New System.Windows.Forms.RadioButton()
        Me.ShowOffDevicesBtn = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Title = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ChineseMoveDownBtn = New System.Windows.Forms.Button()
        Me.ChineseMoveUpBtn = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ServiceTypeFontBtn = New System.Windows.Forms.Button()
        Me.ServiceTypeColorBtn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ChapterTxt = New System.Windows.Forms.TextBox()
        Me.BookTxt = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EnglishBookFontBtn = New System.Windows.Forms.Button()
        Me.EnglishBookColorBtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ChineseBookFontBtn = New System.Windows.Forms.Button()
        Me.ChineseBookColorBtn = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BibleHDFont = New System.Windows.Forms.Button()
        Me.BibleHDColor = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.HymnHDFont = New System.Windows.Forms.Button()
        Me.HymnHDColor = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CVColorBtn = New System.Windows.Forms.Button()
        Me.CVFontBtn = New System.Windows.Forms.Button()
        Me.UpdateVerseBtn = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BibleVerseGroupBox = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.VerseTxt = New System.Windows.Forms.TextBox()
        Me.navBar = New System.Windows.Forms.Panel()
        Me.SettingsBtn = New System.Windows.Forms.Button()
        Me.HeaderLogo = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.FontDialog = New System.Windows.Forms.FontDialog()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.hymnTabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.FlowLayoutPanel8 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PrevHymnBtn = New System.Windows.Forms.Button()
        Me.NextHymnBtn = New System.Windows.Forms.Button()
        Me.DelHymnBtn = New System.Windows.Forms.Button()
        Me.HymnFontBtn = New System.Windows.Forms.Button()
        Me.HymnColorBtn = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SermonHymnTxt = New System.Windows.Forms.TextBox()
        Me.ClearSermonHymnsBtn = New System.Windows.Forms.Button()
        Me.SermonHymnsListBox = New System.Windows.Forms.ListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.HymnalPrevHymnBtn = New System.Windows.Forms.Button()
        Me.HymnalNextHymnBtn = New System.Windows.Forms.Button()
        Me.HymnalDelHymnBtn = New System.Windows.Forms.Button()
        Me.HymnalHymnFontBtn = New System.Windows.Forms.Button()
        Me.HymnalHymnColorBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HymnalTxt = New System.Windows.Forms.TextBox()
        Me.ClearHymnalBtn = New System.Windows.Forms.Button()
        Me.HymnalListBox = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.EditSlidePanel.SuspendLayout()
        Me.ProjectSlidePanel.SuspendLayout()
        Me.Title.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.BibleVerseGroupBox.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.navBar.SuspendLayout()
        CType(Me.HeaderLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.hymnTabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.FlowLayoutPanel8.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 371.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ServiceTypeTxt, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(5, 38)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(613, 28)
        Me.TableLayoutPanel1.TabIndex = 37
        '
        'ServiceTypeTxt
        '
        Me.ServiceTypeTxt.AutoCompleteCustomSource.AddRange(New String() {"Sabbath Service 安息日聚會", "Sabbath Bible Study  安息日查經", "Sabbath Afternoon Service 安息日下午聚會", "Friday Evening Service 星期五晚間聚會", "Wednesday Evening Service 星期三晚間聚會", "Bible Study 查經", "End of Year Services 年末特別聚會", "", "Spiritual Convocation 靈恩會", "Evangelistic Service 佈道會", "Special Service 特別聚會", "Fellowship 團契", "Autumn Spiritual Convocation 秋季靈恩會", "Spring Spiritual Convocation 春季靈恩會", "Spiritual Cultivation Seminar 靈修講習會", "NSSC", "YTTC", "AMTC"})
        Me.ServiceTypeTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ServiceTypeTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ServiceTypeTxt.Cursor = System.Windows.Forms.Cursors.Default
        Me.ServiceTypeTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ServiceTypeTxt.DropDownHeight = 100
        Me.ServiceTypeTxt.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ServiceTypeTxt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServiceTypeTxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ServiceTypeTxt.FormattingEnabled = True
        Me.ServiceTypeTxt.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.ServiceTypeTxt.IntegralHeight = False
        Me.ServiceTypeTxt.Items.AddRange(New Object() {"Sabbath Service 安息日聚會", "Sabbath Bible Study  安息日查經", "Sabbath Afternoon Service 安息日下午聚會", "Friday Evening Service 星期五晚間聚會", "Wednesday Evening Service 星期三晚間聚會", "Bible Study 查經", "End of Year Services 年末特別聚會", "Spiritual Convocation 靈恩會", "Evangelistic Service 佈道會", "Special Service 特別聚會", "Fellowship 團契", "Autumn Spiritual Convocation 秋季靈恩會", "Spring Spiritual Convocation 春季靈恩會", "Spiritual Cultivation Seminar 靈修講習會", "NSSC", "YTTC", "AMTC"})
        Me.ServiceTypeTxt.Location = New System.Drawing.Point(0, 3)
        Me.ServiceTypeTxt.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.ServiceTypeTxt.MaxDropDownItems = 5
        Me.ServiceTypeTxt.Name = "ServiceTypeTxt"
        Me.ServiceTypeTxt.Size = New System.Drawing.Size(242, 25)
        Me.ServiceTypeTxt.TabIndex = 33
        Me.ServiceTypeTxt.TabStop = False
        '
        'UpdateTitleBtn
        '
        Me.UpdateTitleBtn.AutoSize = True
        Me.UpdateTitleBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UpdateTitleBtn.BackColor = System.Drawing.Color.Transparent
        Me.UpdateTitleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.UpdateTitleBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdateTitleBtn.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateTitleBtn.ForeColor = System.Drawing.Color.Navy
        Me.UpdateTitleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UpdateTitleBtn.Location = New System.Drawing.Point(1, 32)
        Me.UpdateTitleBtn.Margin = New System.Windows.Forms.Padding(1)
        Me.UpdateTitleBtn.Name = "UpdateTitleBtn"
        Me.UpdateTitleBtn.Size = New System.Drawing.Size(124, 30)
        Me.UpdateTitleBtn.TabIndex = 3
        Me.UpdateTitleBtn.TabStop = False
        Me.UpdateTitleBtn.Text = "Update Title(s)"
        Me.UpdateTitleBtn.UseVisualStyleBackColor = False
        '
        'ResetAllBtn
        '
        Me.ResetAllBtn.AutoSize = True
        Me.ResetAllBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ResetAllBtn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ResetAllBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ResetAllBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ResetAllBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetAllBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ResetAllBtn.Location = New System.Drawing.Point(127, 32)
        Me.ResetAllBtn.Margin = New System.Windows.Forms.Padding(1)
        Me.ResetAllBtn.MinimumSize = New System.Drawing.Size(50, 30)
        Me.ResetAllBtn.Name = "ResetAllBtn"
        Me.ResetAllBtn.Size = New System.Drawing.Size(81, 30)
        Me.ResetAllBtn.TabIndex = 33
        Me.ResetAllBtn.TabStop = False
        Me.ResetAllBtn.Text = "Reset Form"
        Me.ResetAllBtn.UseVisualStyleBackColor = False
        '
        'EnglishTitleTxt
        '
        Me.EnglishTitleTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EnglishTitleTxt.Dock = System.Windows.Forms.DockStyle.Top
        Me.EnglishTitleTxt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnglishTitleTxt.Location = New System.Drawing.Point(5, 66)
        Me.EnglishTitleTxt.Margin = New System.Windows.Forms.Padding(0)
        Me.EnglishTitleTxt.Name = "EnglishTitleTxt"
        Me.EnglishTitleTxt.Size = New System.Drawing.Size(613, 33)
        Me.EnglishTitleTxt.TabIndex = 0
        Me.EnglishTitleTxt.TabStop = False
        Me.EnglishTitleTxt.WordWrap = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "English Title"
        '
        'EnglishFontBtn
        '
        Me.EnglishFontBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EnglishFontBtn.BackgroundImage = CType(resources.GetObject("EnglishFontBtn.BackgroundImage"), System.Drawing.Image)
        Me.EnglishFontBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EnglishFontBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EnglishFontBtn.Location = New System.Drawing.Point(80, 3)
        Me.EnglishFontBtn.Name = "EnglishFontBtn"
        Me.EnglishFontBtn.Size = New System.Drawing.Size(25, 25)
        Me.EnglishFontBtn.TabIndex = 6
        Me.EnglishFontBtn.TabStop = False
        Me.EnglishFontBtn.UseVisualStyleBackColor = True
        '
        'EnglishColorBtn
        '
        Me.EnglishColorBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EnglishColorBtn.BackgroundImage = CType(resources.GetObject("EnglishColorBtn.BackgroundImage"), System.Drawing.Image)
        Me.EnglishColorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EnglishColorBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EnglishColorBtn.Location = New System.Drawing.Point(111, 3)
        Me.EnglishColorBtn.Name = "EnglishColorBtn"
        Me.EnglishColorBtn.Size = New System.Drawing.Size(25, 25)
        Me.EnglishColorBtn.TabIndex = 5
        Me.EnglishColorBtn.TabStop = False
        Me.EnglishColorBtn.UseVisualStyleBackColor = True
        '
        'EnglishMoveDownBtn
        '
        Me.EnglishMoveDownBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EnglishMoveDownBtn.BackgroundImage = CType(resources.GetObject("EnglishMoveDownBtn.BackgroundImage"), System.Drawing.Image)
        Me.EnglishMoveDownBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EnglishMoveDownBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EnglishMoveDownBtn.Location = New System.Drawing.Point(142, 3)
        Me.EnglishMoveDownBtn.Name = "EnglishMoveDownBtn"
        Me.EnglishMoveDownBtn.Size = New System.Drawing.Size(25, 25)
        Me.EnglishMoveDownBtn.TabIndex = 40
        Me.EnglishMoveDownBtn.TabStop = False
        Me.EnglishMoveDownBtn.UseVisualStyleBackColor = True
        '
        'EnglishMoveUpBtn
        '
        Me.EnglishMoveUpBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EnglishMoveUpBtn.BackgroundImage = CType(resources.GetObject("EnglishMoveUpBtn.BackgroundImage"), System.Drawing.Image)
        Me.EnglishMoveUpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EnglishMoveUpBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EnglishMoveUpBtn.Location = New System.Drawing.Point(173, 3)
        Me.EnglishMoveUpBtn.Name = "EnglishMoveUpBtn"
        Me.EnglishMoveUpBtn.Size = New System.Drawing.Size(25, 25)
        Me.EnglishMoveUpBtn.TabIndex = 41
        Me.EnglishMoveUpBtn.TabStop = False
        Me.EnglishMoveUpBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(204, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 15)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Chinese Title"
        '
        'ChineseFontBtn
        '
        Me.ChineseFontBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChineseFontBtn.BackgroundImage = CType(resources.GetObject("ChineseFontBtn.BackgroundImage"), System.Drawing.Image)
        Me.ChineseFontBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ChineseFontBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChineseFontBtn.Location = New System.Drawing.Point(285, 3)
        Me.ChineseFontBtn.Name = "ChineseFontBtn"
        Me.ChineseFontBtn.Size = New System.Drawing.Size(25, 25)
        Me.ChineseFontBtn.TabIndex = 8
        Me.ChineseFontBtn.TabStop = False
        Me.ChineseFontBtn.UseVisualStyleBackColor = True
        '
        'ChineseColorBtn
        '
        Me.ChineseColorBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChineseColorBtn.BackgroundImage = CType(resources.GetObject("ChineseColorBtn.BackgroundImage"), System.Drawing.Image)
        Me.ChineseColorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ChineseColorBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChineseColorBtn.Location = New System.Drawing.Point(316, 3)
        Me.ChineseColorBtn.Name = "ChineseColorBtn"
        Me.ChineseColorBtn.Size = New System.Drawing.Size(25, 25)
        Me.ChineseColorBtn.TabIndex = 7
        Me.ChineseColorBtn.TabStop = False
        Me.ChineseColorBtn.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(5, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 15)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Service Type"
        '
        'ChineseTitleTxt
        '
        Me.ChineseTitleTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ChineseTitleTxt.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChineseTitleTxt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChineseTitleTxt.Location = New System.Drawing.Point(5, 99)
        Me.ChineseTitleTxt.Margin = New System.Windows.Forms.Padding(0)
        Me.ChineseTitleTxt.Name = "ChineseTitleTxt"
        Me.ChineseTitleTxt.Size = New System.Drawing.Size(613, 33)
        Me.ChineseTitleTxt.TabIndex = 1
        Me.ChineseTitleTxt.TabStop = False
        '
        'EditSlidePanel
        '
        Me.EditSlidePanel.AutoSize = True
        Me.EditSlidePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.EditSlidePanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.EditSlidePanel.Controls.Add(Me.EditHCBtn)
        Me.EditSlidePanel.Controls.Add(Me.EditTimetableBtn)
        Me.EditSlidePanel.Controls.Add(Me.EditAnnouncementsBtn)
        Me.EditSlidePanel.Controls.Add(Me.EditPRBtn)
        Me.EditSlidePanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.EditSlidePanel.Location = New System.Drawing.Point(0, 420)
        Me.EditSlidePanel.Name = "EditSlidePanel"
        Me.EditSlidePanel.Size = New System.Drawing.Size(834, 31)
        Me.EditSlidePanel.TabIndex = 30
        '
        'EditHCBtn
        '
        Me.EditHCBtn.AutoSize = True
        Me.EditHCBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.EditHCBtn.BackColor = System.Drawing.Color.Transparent
        Me.EditHCBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditHCBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.EditHCBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditHCBtn.Location = New System.Drawing.Point(3, 3)
        Me.EditHCBtn.Name = "EditHCBtn"
        Me.EditHCBtn.Size = New System.Drawing.Size(116, 24)
        Me.EditHCBtn.TabIndex = 28
        Me.EditHCBtn.TabStop = False
        Me.EditHCBtn.Text = "Holy Communion"
        Me.EditHCBtn.UseVisualStyleBackColor = False
        '
        'EditTimetableBtn
        '
        Me.EditTimetableBtn.AutoSize = True
        Me.EditTimetableBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.EditTimetableBtn.BackColor = System.Drawing.Color.Transparent
        Me.EditTimetableBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditTimetableBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditTimetableBtn.Location = New System.Drawing.Point(125, 3)
        Me.EditTimetableBtn.Name = "EditTimetableBtn"
        Me.EditTimetableBtn.Padding = New System.Windows.Forms.Padding(5, 0, 3, 0)
        Me.EditTimetableBtn.Size = New System.Drawing.Size(78, 25)
        Me.EditTimetableBtn.TabIndex = 29
        Me.EditTimetableBtn.TabStop = False
        Me.EditTimetableBtn.Text = "Timetable"
        Me.EditTimetableBtn.UseVisualStyleBackColor = False
        '
        'EditAnnouncementsBtn
        '
        Me.EditAnnouncementsBtn.AutoSize = True
        Me.EditAnnouncementsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.EditAnnouncementsBtn.BackColor = System.Drawing.Color.Transparent
        Me.EditAnnouncementsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditAnnouncementsBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditAnnouncementsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditAnnouncementsBtn.Location = New System.Drawing.Point(209, 3)
        Me.EditAnnouncementsBtn.Name = "EditAnnouncementsBtn"
        Me.EditAnnouncementsBtn.Padding = New System.Windows.Forms.Padding(5, 0, 3, 0)
        Me.EditAnnouncementsBtn.Size = New System.Drawing.Size(113, 25)
        Me.EditAnnouncementsBtn.TabIndex = 26
        Me.EditAnnouncementsBtn.TabStop = False
        Me.EditAnnouncementsBtn.Text = "Announcements"
        Me.EditAnnouncementsBtn.UseVisualStyleBackColor = False
        '
        'EditPRBtn
        '
        Me.EditPRBtn.AutoSize = True
        Me.EditPRBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.EditPRBtn.BackColor = System.Drawing.Color.Transparent
        Me.EditPRBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditPRBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditPRBtn.Location = New System.Drawing.Point(328, 3)
        Me.EditPRBtn.Name = "EditPRBtn"
        Me.EditPRBtn.Padding = New System.Windows.Forms.Padding(5, 0, 3, 0)
        Me.EditPRBtn.Size = New System.Drawing.Size(108, 25)
        Me.EditPRBtn.TabIndex = 20
        Me.EditPRBtn.TabStop = False
        Me.EditPRBtn.Text = "Prayer Requests"
        Me.EditPRBtn.UseVisualStyleBackColor = False
        '
        'ProjectSlidePanel
        '
        Me.ProjectSlidePanel.AutoSize = True
        Me.ProjectSlidePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ProjectSlidePanel.BackColor = System.Drawing.Color.Transparent
        Me.ProjectSlidePanel.Controls.Add(Me.ShowSermonHymnsBtn)
        Me.ProjectSlidePanel.Controls.Add(Me.ShowHymnalBtn)
        Me.ProjectSlidePanel.Controls.Add(Me.ShowVersesBtn)
        Me.ProjectSlidePanel.Controls.Add(Me.ShowPRBtn)
        Me.ProjectSlidePanel.Controls.Add(Me.ShowHowToPrayBtn)
        Me.ProjectSlidePanel.Controls.Add(Me.ShowBreakBtn)
        Me.ProjectSlidePanel.Controls.Add(Me.ShowTimetableBtn)
        Me.ProjectSlidePanel.Controls.Add(Me.ShowAnnouncementsBtn)
        Me.ProjectSlidePanel.Controls.Add(Me.ShowHCBtn)
        Me.ProjectSlidePanel.Controls.Add(Me.ShowOffDevicesBtn)
        Me.ProjectSlidePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProjectSlidePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.ProjectSlidePanel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ProjectSlidePanel.Location = New System.Drawing.Point(5, 23)
        Me.ProjectSlidePanel.Margin = New System.Windows.Forms.Padding(0)
        Me.ProjectSlidePanel.Name = "ProjectSlidePanel"
        Me.ProjectSlidePanel.Size = New System.Drawing.Size(804, 59)
        Me.ProjectSlidePanel.TabIndex = 11
        '
        'ShowSermonHymnsBtn
        '
        Me.ShowSermonHymnsBtn.Appearance = System.Windows.Forms.Appearance.Button
        Me.ShowSermonHymnsBtn.CausesValidation = False
        Me.ShowSermonHymnsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ShowSermonHymnsBtn.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowSermonHymnsBtn.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ShowSermonHymnsBtn.Image = Global.TJCPowerPoint.My.Resources.Resources.icons8_music_16
        Me.ShowSermonHymnsBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ShowSermonHymnsBtn.Location = New System.Drawing.Point(3, 3)
        Me.ShowSermonHymnsBtn.Name = "ShowSermonHymnsBtn"
        Me.ShowSermonHymnsBtn.Size = New System.Drawing.Size(80, 55)
        Me.ShowSermonHymnsBtn.TabIndex = 0
        Me.ShowSermonHymnsBtn.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Service" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hymns"
        Me.ShowSermonHymnsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ShowSermonHymnsBtn.UseVisualStyleBackColor = True
        '
        'ShowHymnalBtn
        '
        Me.ShowHymnalBtn.Appearance = System.Windows.Forms.Appearance.Button
        Me.ShowHymnalBtn.BackColor = System.Drawing.Color.Transparent
        Me.ShowHymnalBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ShowHymnalBtn.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowHymnalBtn.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ShowHymnalBtn.Image = Global.TJCPowerPoint.My.Resources.Resources.icons8_musical_note_16
        Me.ShowHymnalBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ShowHymnalBtn.Location = New System.Drawing.Point(89, 3)
        Me.ShowHymnalBtn.Name = "ShowHymnalBtn"
        Me.ShowHymnalBtn.Size = New System.Drawing.Size(80, 55)
        Me.ShowHymnalBtn.TabIndex = 2
        Me.ShowHymnalBtn.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hymnal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ShowHymnalBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ShowHymnalBtn.UseVisualStyleBackColor = False
        '
        'ShowVersesBtn
        '
        Me.ShowVersesBtn.Appearance = System.Windows.Forms.Appearance.Button
        Me.ShowVersesBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ShowVersesBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ShowVersesBtn.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowVersesBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ShowVersesBtn.Image = Global.TJCPowerPoint.My.Resources.Resources.icons8_bible_16
        Me.ShowVersesBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ShowVersesBtn.Location = New System.Drawing.Point(175, 3)
        Me.ShowVersesBtn.Name = "ShowVersesBtn"
        Me.ShowVersesBtn.Size = New System.Drawing.Size(0, 55)
        Me.ShowVersesBtn.TabIndex = 1
        Me.ShowVersesBtn.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bible" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Verses" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ShowVersesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ShowVersesBtn.UseVisualStyleBackColor = True
        '
        'ShowPRBtn
        '
        Me.ShowPRBtn.Appearance = System.Windows.Forms.Appearance.Button
        Me.ShowPRBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ShowPRBtn.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowPRBtn.Image = Global.TJCPowerPoint.My.Resources.Resources.icons8_chat_16
        Me.ShowPRBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ShowPRBtn.Location = New System.Drawing.Point(181, 3)
        Me.ShowPRBtn.Name = "ShowPRBtn"
        Me.ShowPRBtn.Size = New System.Drawing.Size(80, 55)
        Me.ShowPRBtn.TabIndex = 4
        Me.ShowPRBtn.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Prayer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Requests"
        Me.ShowPRBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ShowPRBtn.UseVisualStyleBackColor = True
        '
        'ShowHowToPrayBtn
        '
        Me.ShowHowToPrayBtn.Appearance = System.Windows.Forms.Appearance.Button
        Me.ShowHowToPrayBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ShowHowToPrayBtn.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowHowToPrayBtn.Image = Global.TJCPowerPoint.My.Resources.Resources.icons8_question_mark_16
        Me.ShowHowToPrayBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ShowHowToPrayBtn.Location = New System.Drawing.Point(267, 3)
        Me.ShowHowToPrayBtn.Name = "ShowHowToPrayBtn"
        Me.ShowHowToPrayBtn.Size = New System.Drawing.Size(80, 55)
        Me.ShowHowToPrayBtn.TabIndex = 7
        Me.ShowHowToPrayBtn.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "How To Pray" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ShowHowToPrayBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ShowHowToPrayBtn.UseVisualStyleBackColor = True
        '
        'ShowBreakBtn
        '
        Me.ShowBreakBtn.Appearance = System.Windows.Forms.Appearance.Button
        Me.ShowBreakBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ShowBreakBtn.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowBreakBtn.Image = Global.TJCPowerPoint.My.Resources.Resources.icons8_coffee_cup_16
        Me.ShowBreakBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ShowBreakBtn.Location = New System.Drawing.Point(353, 3)
        Me.ShowBreakBtn.Name = "ShowBreakBtn"
        Me.ShowBreakBtn.Size = New System.Drawing.Size(80, 55)
        Me.ShowBreakBtn.TabIndex = 5
        Me.ShowBreakBtn.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Break" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ShowBreakBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ShowBreakBtn.UseVisualStyleBackColor = True
        '
        'ShowTimetableBtn
        '
        Me.ShowTimetableBtn.Appearance = System.Windows.Forms.Appearance.Button
        Me.ShowTimetableBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ShowTimetableBtn.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowTimetableBtn.Image = Global.TJCPowerPoint.My.Resources.Resources.icons8_calendar_16
        Me.ShowTimetableBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ShowTimetableBtn.Location = New System.Drawing.Point(439, 3)
        Me.ShowTimetableBtn.Name = "ShowTimetableBtn"
        Me.ShowTimetableBtn.Size = New System.Drawing.Size(80, 55)
        Me.ShowTimetableBtn.TabIndex = 9
        Me.ShowTimetableBtn.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Timetable" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ShowTimetableBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ShowTimetableBtn.UseVisualStyleBackColor = True
        '
        'ShowAnnouncementsBtn
        '
        Me.ShowAnnouncementsBtn.Appearance = System.Windows.Forms.Appearance.Button
        Me.ShowAnnouncementsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ShowAnnouncementsBtn.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowAnnouncementsBtn.Image = Global.TJCPowerPoint.My.Resources.Resources.icons8_announcement_16
        Me.ShowAnnouncementsBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ShowAnnouncementsBtn.Location = New System.Drawing.Point(525, 3)
        Me.ShowAnnouncementsBtn.Name = "ShowAnnouncementsBtn"
        Me.ShowAnnouncementsBtn.Size = New System.Drawing.Size(105, 55)
        Me.ShowAnnouncementsBtn.TabIndex = 6
        Me.ShowAnnouncementsBtn.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Announcements" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ShowAnnouncementsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ShowAnnouncementsBtn.UseVisualStyleBackColor = True
        '
        'ShowHCBtn
        '
        Me.ShowHCBtn.Appearance = System.Windows.Forms.Appearance.Button
        Me.ShowHCBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ShowHCBtn.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowHCBtn.Image = Global.TJCPowerPoint.My.Resources.Resources.icons8_holy_bible_16
        Me.ShowHCBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ShowHCBtn.Location = New System.Drawing.Point(636, 3)
        Me.ShowHCBtn.Name = "ShowHCBtn"
        Me.ShowHCBtn.Size = New System.Drawing.Size(80, 55)
        Me.ShowHCBtn.TabIndex = 10
        Me.ShowHCBtn.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Holy" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Communion"
        Me.ShowHCBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ShowHCBtn.UseVisualStyleBackColor = True
        '
        'ShowOffDevicesBtn
        '
        Me.ShowOffDevicesBtn.Appearance = System.Windows.Forms.Appearance.Button
        Me.ShowOffDevicesBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ShowOffDevicesBtn.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowOffDevicesBtn.Image = Global.TJCPowerPoint.My.Resources.Resources.icons8_smartphone_16
        Me.ShowOffDevicesBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ShowOffDevicesBtn.Location = New System.Drawing.Point(722, 3)
        Me.ShowOffDevicesBtn.Name = "ShowOffDevicesBtn"
        Me.ShowOffDevicesBtn.Size = New System.Drawing.Size(80, 55)
        Me.ShowOffDevicesBtn.TabIndex = 8
        Me.ShowOffDevicesBtn.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Device" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reminder"
        Me.ShowOffDevicesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ShowOffDevicesBtn.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label12.Location = New System.Drawing.Point(5, 5)
        Me.Label12.Margin = New System.Windows.Forms.Padding(0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(212, 17)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = " PROJECT SLIDE (Select to display)"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Title.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Title.Controls.Add(Me.FlowLayoutPanel3)
        Me.Title.Controls.Add(Me.ChineseTitleTxt)
        Me.Title.Controls.Add(Me.EnglishTitleTxt)
        Me.Title.Controls.Add(Me.TableLayoutPanel1)
        Me.Title.Controls.Add(Me.Label11)
        Me.Title.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Title.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Title.Location = New System.Drawing.Point(3, 0)
        Me.Title.Margin = New System.Windows.Forms.Padding(0)
        Me.Title.MinimumSize = New System.Drawing.Size(550, 0)
        Me.Title.Name = "Title"
        Me.Title.Padding = New System.Windows.Forms.Padding(5)
        Me.Title.Size = New System.Drawing.Size(623, 190)
        Me.Title.TabIndex = 14
        Me.Title.TabStop = False
        Me.Title.Text = "EDIT CONTENT: Sermon Details"
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.AutoSize = True
        Me.FlowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel3.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel3.Controls.Add(Me.EnglishFontBtn)
        Me.FlowLayoutPanel3.Controls.Add(Me.EnglishColorBtn)
        Me.FlowLayoutPanel3.Controls.Add(Me.EnglishMoveDownBtn)
        Me.FlowLayoutPanel3.Controls.Add(Me.EnglishMoveUpBtn)
        Me.FlowLayoutPanel3.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel3.Controls.Add(Me.ChineseFontBtn)
        Me.FlowLayoutPanel3.Controls.Add(Me.ChineseColorBtn)
        Me.FlowLayoutPanel3.Controls.Add(Me.ChineseMoveDownBtn)
        Me.FlowLayoutPanel3.Controls.Add(Me.ChineseMoveUpBtn)
        Me.FlowLayoutPanel3.Controls.Add(Me.Label10)
        Me.FlowLayoutPanel3.Controls.Add(Me.ServiceTypeFontBtn)
        Me.FlowLayoutPanel3.Controls.Add(Me.ServiceTypeColorBtn)
        Me.FlowLayoutPanel3.Controls.Add(Me.UpdateTitleBtn)
        Me.FlowLayoutPanel3.Controls.Add(Me.ResetAllBtn)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(5, 132)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(613, 63)
        Me.FlowLayoutPanel3.TabIndex = 34
        '
        'ChineseMoveDownBtn
        '
        Me.ChineseMoveDownBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChineseMoveDownBtn.BackgroundImage = CType(resources.GetObject("ChineseMoveDownBtn.BackgroundImage"), System.Drawing.Image)
        Me.ChineseMoveDownBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ChineseMoveDownBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChineseMoveDownBtn.Location = New System.Drawing.Point(347, 3)
        Me.ChineseMoveDownBtn.Name = "ChineseMoveDownBtn"
        Me.ChineseMoveDownBtn.Size = New System.Drawing.Size(25, 25)
        Me.ChineseMoveDownBtn.TabIndex = 39
        Me.ChineseMoveDownBtn.TabStop = False
        Me.ChineseMoveDownBtn.UseVisualStyleBackColor = True
        '
        'ChineseMoveUpBtn
        '
        Me.ChineseMoveUpBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChineseMoveUpBtn.AutoSize = True
        Me.ChineseMoveUpBtn.BackgroundImage = CType(resources.GetObject("ChineseMoveUpBtn.BackgroundImage"), System.Drawing.Image)
        Me.ChineseMoveUpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ChineseMoveUpBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChineseMoveUpBtn.Location = New System.Drawing.Point(378, 3)
        Me.ChineseMoveUpBtn.Name = "ChineseMoveUpBtn"
        Me.ChineseMoveUpBtn.Size = New System.Drawing.Size(25, 25)
        Me.ChineseMoveUpBtn.TabIndex = 38
        Me.ChineseMoveUpBtn.TabStop = False
        Me.ChineseMoveUpBtn.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(409, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 15)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Service Type"
        '
        'ServiceTypeFontBtn
        '
        Me.ServiceTypeFontBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ServiceTypeFontBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ServiceTypeFontBtn.BackgroundImage = CType(resources.GetObject("ServiceTypeFontBtn.BackgroundImage"), System.Drawing.Image)
        Me.ServiceTypeFontBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ServiceTypeFontBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ServiceTypeFontBtn.Location = New System.Drawing.Point(487, 3)
        Me.ServiceTypeFontBtn.Name = "ServiceTypeFontBtn"
        Me.ServiceTypeFontBtn.Size = New System.Drawing.Size(24, 25)
        Me.ServiceTypeFontBtn.TabIndex = 15
        Me.ServiceTypeFontBtn.TabStop = False
        Me.ServiceTypeFontBtn.UseVisualStyleBackColor = True
        '
        'ServiceTypeColorBtn
        '
        Me.ServiceTypeColorBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ServiceTypeColorBtn.BackgroundImage = CType(resources.GetObject("ServiceTypeColorBtn.BackgroundImage"), System.Drawing.Image)
        Me.ServiceTypeColorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ServiceTypeColorBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ServiceTypeColorBtn.Location = New System.Drawing.Point(517, 3)
        Me.ServiceTypeColorBtn.Name = "ServiceTypeColorBtn"
        Me.ServiceTypeColorBtn.Size = New System.Drawing.Size(24, 25)
        Me.ServiceTypeColorBtn.TabIndex = 14
        Me.ServiceTypeColorBtn.TabStop = False
        Me.ServiceTypeColorBtn.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(366, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 35)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Chapter"
        '
        'ChapterTxt
        '
        Me.ChapterTxt.AcceptsReturn = True
        Me.ChapterTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ChapterTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChapterTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChapterTxt.HideSelection = False
        Me.ChapterTxt.Location = New System.Drawing.Point(428, 3)
        Me.ChapterTxt.Name = "ChapterTxt"
        Me.ChapterTxt.Size = New System.Drawing.Size(147, 27)
        Me.ChapterTxt.TabIndex = 1
        '
        'BookTxt
        '
        Me.BookTxt.AutoCompleteCustomSource.AddRange(New String() {"Genesis,創 世 紀", "Exodus,出 埃 及 記", "Leviticus,利 未 記", "Numbers,民 數 記", "Deuteronomy,申 命 記", "Joshua,約 書 亞 記", "Judges,士 師 記", "Ruth,路 得 記", "1 Samuel,撒 母 耳 記 上", "2 Samuel,撒 母 耳 記 下", "1 Kings,列 王 紀 上", "2 Kings,列 王 紀 下", "1 Chronicles,歷 代 志 上", "2 Chronicles,歷 代 志 下", "Ezra,以 斯 拉 記", "Nehemiah,尼 希 米 記", "Esther,以 斯 帖 記", "Job,約 伯 記", "Psalms,詩 篇", "Proverbs,箴 言", "Ecclesiastes,傳 道 書", "Song of Songs,雅 歌", "Isaiah,以 賽 亞 書", "Jeremiah,耶 利 米 書", "Lamentations,耶 利 米 哀 歌", "Ezekiel,以 西 結 書", "Daniel,但 以 理 書", "Hosea,何 西 阿 書", "Joel,約 珥 書", "Amos,阿 摩 司 書", "Obadiah,俄 巴 底 亞 書", "Jonah,約 拿 書", "Micah,彌 迦 書", "Nahum,那 鴻 書", "Habakkuk,哈 巴 谷 書", "Zephaniah,西 番 雅 書", "Haggai,哈 該 書", "Zechariah,撒 迦 利 亞", "Malachi,瑪 拉 基 書", "Matthew,馬 太 福 音", "Mark,馬 可 福 音", "Luke,路 加 福 音", "John,約 翰 福 音", "Acts,使 徒 行 傳", "Romans,羅 馬 書", "1 Corinthians,哥 林 多 前 書", "2 Corinthians,哥 林 多 後 書", "Galatians,加 拉 太 書", "Ephesians,以 弗 所 書", "Philippians,腓 立 比 書", "Colossians,歌 羅 西 書", "1 Thessalonians,帖 撒 羅 尼 迦 前 書", "2 Thessalonians,帖 撒 羅 尼 迦 後 書", "1 Timothy,提 摩 太 前 書", "2 Timothy,提 摩 太 後 書", "Titus,提 多 書", "Philemon,腓 利 門 書", "Hebrews,希 伯 來 書", "James,雅 各 書", "1 Peter,彼 得 前 書", "2 Peter,彼 得 後 書", "1 John,約 翰 一 書", "2 John,約 翰 二 書", "3 John,約 翰 三 書", "Jude,猶 大 書", "Revelation,啟 示 錄"})
        Me.BookTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.BookTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BookTxt.Cursor = System.Windows.Forms.Cursors.Default
        Me.BookTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BookTxt.DropDownHeight = 100
        Me.BookTxt.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BookTxt.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookTxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BookTxt.FormattingEnabled = True
        Me.BookTxt.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.BookTxt.IntegralHeight = False
        Me.BookTxt.Items.AddRange(New Object() {"Genesis,創世紀", "Exodus,出埃及記", "Leviticus,利未記", "Numbers,民數記", "Deuteronomy,申命記", "Joshua,約書亞記", "Judges,士師記", "Ruth,路得記", "1 Samuel,撒母耳紀上", "2 Samuel,撒母耳紀下", "1 Kings,列王紀上", "2 Kings,列王紀下", "1 Chronicles,歷代志上", "2 Chronicles,歷代志下", "Ezra,以斯拉記", "Nehemiah,尼希米記", "Esther,以斯帖記", "Job,約伯記", "Psalms,詩篇", "Proverbs,箴言", "Ecclesiastes,傳道書", "Song of Songs,雅歌", "Isaiah,以賽亞書", "Jeremiah,耶利米書", "Lamentations,耶利米哀歌", "Ezekiel,以西結書", "Daniel,但以理書", "Hosea,何西阿書", "Joel,約珥書", "Amos,阿摩司書", "Obadiah,俄巴底亞書", "Jonah,約拿書", "Micah,彌迦書", "Nahum,那鴻書", "Habakkuk,哈巴谷書", "Zephaniah,西番雅書", "Haggai,哈該書", "Zechariah,撒迦利亞", "Malachi,瑪拉基書", "Matthew,馬太福音", "Mark,馬可福音", "Luke,路加福音", "John,約翰福音", "Acts,使徒行傳", "Romans,羅馬書", "1 Corinthians,哥林多前書", "2 Corinthians,哥林多後書", "Galatians,加拉太書", "Ephesians,以弗所書", "Philippians,腓立比書", "Colossians,歌羅西書", "1 Thessalonians,帖撒羅尼迦前書", "2 Thessalonians,帖撒羅尼迦後書", "1 Timothy,提摩太前書", "2 Timothy,提摩太後書", "Titus,提多書", "Philemon,腓利門書", "Hebrews,希伯來書", "James,雅各書", "1 Peter,彼得前書", "2 Peter,彼得後書", "1 John,約翰一書", "2 John,約翰二書", "3 John,約翰三書", "Jude,猶大書", "Revelation,啟示錄"})
        Me.BookTxt.Location = New System.Drawing.Point(53, 3)
        Me.BookTxt.MaxDropDownItems = 5
        Me.BookTxt.Name = "BookTxt"
        Me.BookTxt.Size = New System.Drawing.Size(307, 29)
        Me.BookTxt.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 35)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Book"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(581, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 35)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(609, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 35)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Verse(s)"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "English Book"
        '
        'EnglishBookFontBtn
        '
        Me.EnglishBookFontBtn.BackgroundImage = CType(resources.GetObject("EnglishBookFontBtn.BackgroundImage"), System.Drawing.Image)
        Me.EnglishBookFontBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EnglishBookFontBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EnglishBookFontBtn.Location = New System.Drawing.Point(84, 3)
        Me.EnglishBookFontBtn.Name = "EnglishBookFontBtn"
        Me.EnglishBookFontBtn.Size = New System.Drawing.Size(25, 25)
        Me.EnglishBookFontBtn.TabIndex = 20
        Me.EnglishBookFontBtn.TabStop = False
        Me.EnglishBookFontBtn.UseVisualStyleBackColor = True
        '
        'EnglishBookColorBtn
        '
        Me.EnglishBookColorBtn.BackgroundImage = CType(resources.GetObject("EnglishBookColorBtn.BackgroundImage"), System.Drawing.Image)
        Me.EnglishBookColorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EnglishBookColorBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EnglishBookColorBtn.Location = New System.Drawing.Point(115, 3)
        Me.EnglishBookColorBtn.Name = "EnglishBookColorBtn"
        Me.EnglishBookColorBtn.Size = New System.Drawing.Size(25, 25)
        Me.EnglishBookColorBtn.TabIndex = 19
        Me.EnglishBookColorBtn.TabStop = False
        Me.EnglishBookColorBtn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(146, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 15)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Chinese Book"
        '
        'ChineseBookFontBtn
        '
        Me.ChineseBookFontBtn.BackgroundImage = CType(resources.GetObject("ChineseBookFontBtn.BackgroundImage"), System.Drawing.Image)
        Me.ChineseBookFontBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ChineseBookFontBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChineseBookFontBtn.Location = New System.Drawing.Point(231, 3)
        Me.ChineseBookFontBtn.Name = "ChineseBookFontBtn"
        Me.ChineseBookFontBtn.Size = New System.Drawing.Size(25, 25)
        Me.ChineseBookFontBtn.TabIndex = 24
        Me.ChineseBookFontBtn.TabStop = False
        Me.ChineseBookFontBtn.UseVisualStyleBackColor = True
        '
        'ChineseBookColorBtn
        '
        Me.ChineseBookColorBtn.BackgroundImage = CType(resources.GetObject("ChineseBookColorBtn.BackgroundImage"), System.Drawing.Image)
        Me.ChineseBookColorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ChineseBookColorBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChineseBookColorBtn.Location = New System.Drawing.Point(262, 3)
        Me.ChineseBookColorBtn.Name = "ChineseBookColorBtn"
        Me.ChineseBookColorBtn.Size = New System.Drawing.Size(25, 25)
        Me.ChineseBookColorBtn.TabIndex = 23
        Me.ChineseBookColorBtn.TabStop = False
        Me.ChineseBookColorBtn.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(293, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 15)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Bible Heading"
        '
        'BibleHDFont
        '
        Me.BibleHDFont.BackgroundImage = CType(resources.GetObject("BibleHDFont.BackgroundImage"), System.Drawing.Image)
        Me.BibleHDFont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BibleHDFont.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BibleHDFont.Location = New System.Drawing.Point(380, 3)
        Me.BibleHDFont.Name = "BibleHDFont"
        Me.BibleHDFont.Size = New System.Drawing.Size(25, 25)
        Me.BibleHDFont.TabIndex = 28
        Me.BibleHDFont.TabStop = False
        Me.BibleHDFont.UseVisualStyleBackColor = True
        '
        'BibleHDColor
        '
        Me.BibleHDColor.BackgroundImage = CType(resources.GetObject("BibleHDColor.BackgroundImage"), System.Drawing.Image)
        Me.BibleHDColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BibleHDColor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BibleHDColor.Location = New System.Drawing.Point(411, 3)
        Me.BibleHDColor.Name = "BibleHDColor"
        Me.BibleHDColor.Size = New System.Drawing.Size(25, 25)
        Me.BibleHDColor.TabIndex = 27
        Me.BibleHDColor.TabStop = False
        Me.BibleHDColor.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(442, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 15)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Hymn Heading"
        '
        'HymnHDFont
        '
        Me.HymnHDFont.BackgroundImage = CType(resources.GetObject("HymnHDFont.BackgroundImage"), System.Drawing.Image)
        Me.HymnHDFont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HymnHDFont.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HymnHDFont.Location = New System.Drawing.Point(536, 3)
        Me.HymnHDFont.Name = "HymnHDFont"
        Me.HymnHDFont.Size = New System.Drawing.Size(25, 25)
        Me.HymnHDFont.TabIndex = 30
        Me.HymnHDFont.TabStop = False
        Me.HymnHDFont.UseVisualStyleBackColor = True
        '
        'HymnHDColor
        '
        Me.HymnHDColor.BackgroundImage = CType(resources.GetObject("HymnHDColor.BackgroundImage"), System.Drawing.Image)
        Me.HymnHDColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HymnHDColor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HymnHDColor.Location = New System.Drawing.Point(567, 3)
        Me.HymnHDColor.Name = "HymnHDColor"
        Me.HymnHDColor.Size = New System.Drawing.Size(25, 25)
        Me.HymnHDColor.TabIndex = 29
        Me.HymnHDColor.TabStop = False
        Me.HymnHDColor.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(598, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 15)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Chapter/Verse"
        '
        'CVColorBtn
        '
        Me.CVColorBtn.BackgroundImage = CType(resources.GetObject("CVColorBtn.BackgroundImage"), System.Drawing.Image)
        Me.CVColorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CVColorBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CVColorBtn.Location = New System.Drawing.Point(716, 3)
        Me.CVColorBtn.Name = "CVColorBtn"
        Me.CVColorBtn.Size = New System.Drawing.Size(25, 25)
        Me.CVColorBtn.TabIndex = 4
        Me.CVColorBtn.TabStop = False
        Me.CVColorBtn.UseVisualStyleBackColor = True
        '
        'CVFontBtn
        '
        Me.CVFontBtn.BackgroundImage = CType(resources.GetObject("CVFontBtn.BackgroundImage"), System.Drawing.Image)
        Me.CVFontBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CVFontBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CVFontBtn.Location = New System.Drawing.Point(685, 3)
        Me.CVFontBtn.Name = "CVFontBtn"
        Me.CVFontBtn.Size = New System.Drawing.Size(25, 25)
        Me.CVFontBtn.TabIndex = 6
        Me.CVFontBtn.TabStop = False
        Me.CVFontBtn.UseVisualStyleBackColor = True
        '
        'UpdateVerseBtn
        '
        Me.UpdateVerseBtn.AutoSize = True
        Me.UpdateVerseBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UpdateVerseBtn.BackColor = System.Drawing.Color.Transparent
        Me.UpdateVerseBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdateVerseBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.UpdateVerseBtn.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateVerseBtn.ForeColor = System.Drawing.Color.Navy
        Me.UpdateVerseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UpdateVerseBtn.Location = New System.Drawing.Point(5, 91)
        Me.UpdateVerseBtn.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.UpdateVerseBtn.Name = "UpdateVerseBtn"
        Me.UpdateVerseBtn.Size = New System.Drawing.Size(824, 30)
        Me.UpdateVerseBtn.TabIndex = 3
        Me.UpdateVerseBtn.TabStop = False
        Me.UpdateVerseBtn.Text = "Update Chapter and Verse"
        Me.UpdateVerseBtn.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel1.Controls.Add(Me.EnglishBookFontBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.EnglishBookColorBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel1.Controls.Add(Me.ChineseBookFontBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.ChineseBookColorBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label14)
        Me.FlowLayoutPanel1.Controls.Add(Me.BibleHDFont)
        Me.FlowLayoutPanel1.Controls.Add(Me.BibleHDColor)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label13)
        Me.FlowLayoutPanel1.Controls.Add(Me.HymnHDFont)
        Me.FlowLayoutPanel1.Controls.Add(Me.HymnHDColor)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel1.Controls.Add(Me.CVFontBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.CVColorBtn)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(5, 60)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(824, 31)
        Me.FlowLayoutPanel1.TabIndex = 33
        '
        'BibleVerseGroupBox
        '
        Me.BibleVerseGroupBox.AutoSize = True
        Me.BibleVerseGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BibleVerseGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.BibleVerseGroupBox.Controls.Add(Me.UpdateVerseBtn)
        Me.BibleVerseGroupBox.Controls.Add(Me.FlowLayoutPanel1)
        Me.BibleVerseGroupBox.Controls.Add(Me.TableLayoutPanel4)
        Me.BibleVerseGroupBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.BibleVerseGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BibleVerseGroupBox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BibleVerseGroupBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BibleVerseGroupBox.Location = New System.Drawing.Point(0, 336)
        Me.BibleVerseGroupBox.Margin = New System.Windows.Forms.Padding(0)
        Me.BibleVerseGroupBox.Name = "BibleVerseGroupBox"
        Me.BibleVerseGroupBox.Padding = New System.Windows.Forms.Padding(5)
        Me.BibleVerseGroupBox.Size = New System.Drawing.Size(834, 126)
        Me.BibleVerseGroupBox.TabIndex = 40
        Me.BibleVerseGroupBox.TabStop = False
        Me.BibleVerseGroupBox.Text = "Bible Verse(s)"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.AutoSize = True
        Me.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel4.ColumnCount = 7
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.17065!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.57338!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.25597!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label8, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.BookTxt, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.ChapterTxt, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label7, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.VerseTxt, 5, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label9, 5, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(5, 25)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(824, 35)
        Me.TableLayoutPanel4.TabIndex = 35
        '
        'VerseTxt
        '
        Me.VerseTxt.AcceptsReturn = True
        Me.VerseTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.VerseTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VerseTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerseTxt.Location = New System.Drawing.Point(669, 3)
        Me.VerseTxt.Name = "VerseTxt"
        Me.VerseTxt.Size = New System.Drawing.Size(152, 27)
        Me.VerseTxt.TabIndex = 2
        '
        'navBar
        '
        Me.navBar.AutoSize = True
        Me.navBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.navBar.BackColor = System.Drawing.Color.Transparent
        Me.navBar.BackgroundImage = Global.TJCPowerPoint.My.Resources.Resources.background
        Me.navBar.Controls.Add(Me.SettingsBtn)
        Me.navBar.Controls.Add(Me.HeaderLogo)
        Me.navBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.navBar.Location = New System.Drawing.Point(0, 0)
        Me.navBar.Margin = New System.Windows.Forms.Padding(0)
        Me.navBar.Name = "navBar"
        Me.navBar.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.navBar.Size = New System.Drawing.Size(834, 39)
        Me.navBar.TabIndex = 38
        '
        'SettingsBtn
        '
        Me.SettingsBtn.AutoSize = True
        Me.SettingsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SettingsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SettingsBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.SettingsBtn.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingsBtn.Image = Global.TJCPowerPoint.My.Resources.Resources.icons8_settings_16
        Me.SettingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SettingsBtn.Location = New System.Drawing.Point(746, 5)
        Me.SettingsBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.SettingsBtn.Name = "SettingsBtn"
        Me.SettingsBtn.Padding = New System.Windows.Forms.Padding(2)
        Me.SettingsBtn.Size = New System.Drawing.Size(78, 29)
        Me.SettingsBtn.TabIndex = 9
        Me.SettingsBtn.TabStop = False
        Me.SettingsBtn.Text = "     Settings"
        Me.SettingsBtn.UseVisualStyleBackColor = True
        '
        'HeaderLogo
        '
        Me.HeaderLogo.BackColor = System.Drawing.Color.Transparent
        Me.HeaderLogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.HeaderLogo.Image = Global.TJCPowerPoint.My.Resources.Resources.powerpoint_en_white
        Me.HeaderLogo.InitialImage = Nothing
        Me.HeaderLogo.Location = New System.Drawing.Point(5, 5)
        Me.HeaderLogo.Margin = New System.Windows.Forms.Padding(0)
        Me.HeaderLogo.Name = "HeaderLogo"
        Me.HeaderLogo.Size = New System.Drawing.Size(149, 29)
        Me.HeaderLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.HeaderLogo.TabIndex = 2
        Me.HeaderLogo.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 1000
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.CheckFileExists = True
        Me.SaveFileDialog.FileName = "Settings.ini"
        Me.SaveFileDialog.Filter = "INI Files (*.ini)|*.ini|All Files (*.*)|*.*"""
        Me.SaveFileDialog.RestoreDirectory = True
        '
        'ColorDialog
        '
        Me.ColorDialog.AnyColor = True
        Me.ColorDialog.FullOpen = True
        '
        'FontDialog
        '
        Me.FontDialog.ShowEffects = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.hymnTabControl, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Title, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 146)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(834, 190)
        Me.TableLayoutPanel3.TabIndex = 9
        '
        'hymnTabControl
        '
        Me.hymnTabControl.Controls.Add(Me.TabPage1)
        Me.hymnTabControl.Controls.Add(Me.TabPage2)
        Me.hymnTabControl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hymnTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hymnTabControl.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hymnTabControl.Location = New System.Drawing.Point(626, 0)
        Me.hymnTabControl.Margin = New System.Windows.Forms.Padding(0)
        Me.hymnTabControl.Multiline = True
        Me.hymnTabControl.Name = "hymnTabControl"
        Me.hymnTabControl.Padding = New System.Drawing.Point(0, 0)
        Me.hymnTabControl.SelectedIndex = 0
        Me.hymnTabControl.Size = New System.Drawing.Size(208, 190)
        Me.hymnTabControl.TabIndex = 34
        Me.hymnTabControl.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.FlowLayoutPanel8)
        Me.TabPage1.Controls.Add(Me.SermonHymnTxt)
        Me.TabPage1.Controls.Add(Me.ClearSermonHymnsBtn)
        Me.TabPage1.Controls.Add(Me.SermonHymnsListBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(200, 162)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Sermon Hymns"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel8
        '
        Me.FlowLayoutPanel8.Controls.Add(Me.PrevHymnBtn)
        Me.FlowLayoutPanel8.Controls.Add(Me.NextHymnBtn)
        Me.FlowLayoutPanel8.Controls.Add(Me.DelHymnBtn)
        Me.FlowLayoutPanel8.Controls.Add(Me.HymnFontBtn)
        Me.FlowLayoutPanel8.Controls.Add(Me.HymnColorBtn)
        Me.FlowLayoutPanel8.Controls.Add(Me.PictureBox2)
        Me.FlowLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel8.Location = New System.Drawing.Point(103, 28)
        Me.FlowLayoutPanel8.Name = "FlowLayoutPanel8"
        Me.FlowLayoutPanel8.Size = New System.Drawing.Size(94, 106)
        Me.FlowLayoutPanel8.TabIndex = 54
        '
        'PrevHymnBtn
        '
        Me.PrevHymnBtn.BackgroundImage = CType(resources.GetObject("PrevHymnBtn.BackgroundImage"), System.Drawing.Image)
        Me.PrevHymnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PrevHymnBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PrevHymnBtn.Location = New System.Drawing.Point(3, 3)
        Me.PrevHymnBtn.Name = "PrevHymnBtn"
        Me.PrevHymnBtn.Size = New System.Drawing.Size(25, 25)
        Me.PrevHymnBtn.TabIndex = 49
        Me.PrevHymnBtn.TabStop = False
        Me.PrevHymnBtn.UseVisualStyleBackColor = True
        '
        'NextHymnBtn
        '
        Me.NextHymnBtn.BackgroundImage = CType(resources.GetObject("NextHymnBtn.BackgroundImage"), System.Drawing.Image)
        Me.NextHymnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NextHymnBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NextHymnBtn.Location = New System.Drawing.Point(34, 3)
        Me.NextHymnBtn.Name = "NextHymnBtn"
        Me.NextHymnBtn.Size = New System.Drawing.Size(25, 25)
        Me.NextHymnBtn.TabIndex = 48
        Me.NextHymnBtn.TabStop = False
        Me.NextHymnBtn.UseVisualStyleBackColor = True
        '
        'DelHymnBtn
        '
        Me.DelHymnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DelHymnBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DelHymnBtn.Image = Global.TJCPowerPoint.My.Resources.Resources.icons8_delete_trash_20
        Me.DelHymnBtn.Location = New System.Drawing.Point(65, 3)
        Me.DelHymnBtn.Name = "DelHymnBtn"
        Me.DelHymnBtn.Size = New System.Drawing.Size(25, 25)
        Me.DelHymnBtn.TabIndex = 50
        Me.DelHymnBtn.TabStop = False
        Me.DelHymnBtn.UseVisualStyleBackColor = True
        '
        'HymnFontBtn
        '
        Me.HymnFontBtn.BackgroundImage = CType(resources.GetObject("HymnFontBtn.BackgroundImage"), System.Drawing.Image)
        Me.HymnFontBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HymnFontBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HymnFontBtn.Location = New System.Drawing.Point(3, 34)
        Me.HymnFontBtn.Name = "HymnFontBtn"
        Me.HymnFontBtn.Size = New System.Drawing.Size(25, 25)
        Me.HymnFontBtn.TabIndex = 46
        Me.HymnFontBtn.TabStop = False
        Me.HymnFontBtn.UseVisualStyleBackColor = True
        '
        'HymnColorBtn
        '
        Me.HymnColorBtn.BackgroundImage = CType(resources.GetObject("HymnColorBtn.BackgroundImage"), System.Drawing.Image)
        Me.HymnColorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HymnColorBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HymnColorBtn.Location = New System.Drawing.Point(34, 34)
        Me.HymnColorBtn.Name = "HymnColorBtn"
        Me.HymnColorBtn.Size = New System.Drawing.Size(25, 25)
        Me.HymnColorBtn.TabIndex = 45
        Me.HymnColorBtn.TabStop = False
        Me.HymnColorBtn.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Image = Global.TJCPowerPoint.My.Resources.Resources.icons8_music_16
        Me.PictureBox2.Location = New System.Drawing.Point(65, 34)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 18)
        Me.PictureBox2.TabIndex = 53
        Me.PictureBox2.TabStop = False
        '
        'SermonHymnTxt
        '
        Me.SermonHymnTxt.AcceptsReturn = True
        Me.SermonHymnTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SermonHymnTxt.Dock = System.Windows.Forms.DockStyle.Top
        Me.SermonHymnTxt.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SermonHymnTxt.Location = New System.Drawing.Point(103, 3)
        Me.SermonHymnTxt.Multiline = True
        Me.SermonHymnTxt.Name = "SermonHymnTxt"
        Me.SermonHymnTxt.Size = New System.Drawing.Size(94, 25)
        Me.SermonHymnTxt.TabIndex = 44
        Me.SermonHymnTxt.TabStop = False
        '
        'ClearSermonHymnsBtn
        '
        Me.ClearSermonHymnsBtn.AutoSize = True
        Me.ClearSermonHymnsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClearSermonHymnsBtn.BackColor = System.Drawing.Color.Transparent
        Me.ClearSermonHymnsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClearSermonHymnsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClearSermonHymnsBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ClearSermonHymnsBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearSermonHymnsBtn.ForeColor = System.Drawing.Color.Maroon
        Me.ClearSermonHymnsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClearSermonHymnsBtn.Location = New System.Drawing.Point(103, 134)
        Me.ClearSermonHymnsBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.ClearSermonHymnsBtn.Name = "ClearSermonHymnsBtn"
        Me.ClearSermonHymnsBtn.Size = New System.Drawing.Size(94, 25)
        Me.ClearSermonHymnsBtn.TabIndex = 52
        Me.ClearSermonHymnsBtn.TabStop = False
        Me.ClearSermonHymnsBtn.Text = "Clear All"
        Me.ClearSermonHymnsBtn.UseVisualStyleBackColor = False
        '
        'SermonHymnsListBox
        '
        Me.SermonHymnsListBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SermonHymnsListBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.SermonHymnsListBox.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SermonHymnsListBox.FormatString = "N0"
        Me.SermonHymnsListBox.FormattingEnabled = True
        Me.SermonHymnsListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.SermonHymnsListBox.ItemHeight = 18
        Me.SermonHymnsListBox.Location = New System.Drawing.Point(3, 3)
        Me.SermonHymnsListBox.Name = "SermonHymnsListBox"
        Me.SermonHymnsListBox.ScrollAlwaysVisible = True
        Me.SermonHymnsListBox.Size = New System.Drawing.Size(100, 156)
        Me.SermonHymnsListBox.TabIndex = 47
        Me.SermonHymnsListBox.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.Controls.Add(Me.FlowLayoutPanel2)
        Me.TabPage2.Controls.Add(Me.HymnalTxt)
        Me.TabPage2.Controls.Add(Me.ClearHymnalBtn)
        Me.TabPage2.Controls.Add(Me.HymnalListBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(200, 162)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Hymnal Hymns"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.HymnalPrevHymnBtn)
        Me.FlowLayoutPanel2.Controls.Add(Me.HymnalNextHymnBtn)
        Me.FlowLayoutPanel2.Controls.Add(Me.HymnalDelHymnBtn)
        Me.FlowLayoutPanel2.Controls.Add(Me.HymnalHymnFontBtn)
        Me.FlowLayoutPanel2.Controls.Add(Me.HymnalHymnColorBtn)
        Me.FlowLayoutPanel2.Controls.Add(Me.PictureBox1)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(103, 28)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(94, 106)
        Me.FlowLayoutPanel2.TabIndex = 62
        '
        'HymnalPrevHymnBtn
        '
        Me.HymnalPrevHymnBtn.BackgroundImage = CType(resources.GetObject("HymnalPrevHymnBtn.BackgroundImage"), System.Drawing.Image)
        Me.HymnalPrevHymnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HymnalPrevHymnBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HymnalPrevHymnBtn.Location = New System.Drawing.Point(3, 3)
        Me.HymnalPrevHymnBtn.Name = "HymnalPrevHymnBtn"
        Me.HymnalPrevHymnBtn.Size = New System.Drawing.Size(25, 25)
        Me.HymnalPrevHymnBtn.TabIndex = 58
        Me.HymnalPrevHymnBtn.TabStop = False
        Me.HymnalPrevHymnBtn.UseVisualStyleBackColor = True
        '
        'HymnalNextHymnBtn
        '
        Me.HymnalNextHymnBtn.BackgroundImage = CType(resources.GetObject("HymnalNextHymnBtn.BackgroundImage"), System.Drawing.Image)
        Me.HymnalNextHymnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HymnalNextHymnBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HymnalNextHymnBtn.Location = New System.Drawing.Point(34, 3)
        Me.HymnalNextHymnBtn.Name = "HymnalNextHymnBtn"
        Me.HymnalNextHymnBtn.Size = New System.Drawing.Size(25, 25)
        Me.HymnalNextHymnBtn.TabIndex = 57
        Me.HymnalNextHymnBtn.TabStop = False
        Me.HymnalNextHymnBtn.UseVisualStyleBackColor = True
        '
        'HymnalDelHymnBtn
        '
        Me.HymnalDelHymnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HymnalDelHymnBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HymnalDelHymnBtn.Image = Global.TJCPowerPoint.My.Resources.Resources.icons8_delete_trash_20
        Me.HymnalDelHymnBtn.Location = New System.Drawing.Point(65, 3)
        Me.HymnalDelHymnBtn.Name = "HymnalDelHymnBtn"
        Me.HymnalDelHymnBtn.Size = New System.Drawing.Size(25, 25)
        Me.HymnalDelHymnBtn.TabIndex = 59
        Me.HymnalDelHymnBtn.TabStop = False
        Me.HymnalDelHymnBtn.UseVisualStyleBackColor = True
        '
        'HymnalHymnFontBtn
        '
        Me.HymnalHymnFontBtn.BackgroundImage = CType(resources.GetObject("HymnalHymnFontBtn.BackgroundImage"), System.Drawing.Image)
        Me.HymnalHymnFontBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HymnalHymnFontBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HymnalHymnFontBtn.Location = New System.Drawing.Point(3, 34)
        Me.HymnalHymnFontBtn.Name = "HymnalHymnFontBtn"
        Me.HymnalHymnFontBtn.Size = New System.Drawing.Size(25, 25)
        Me.HymnalHymnFontBtn.TabIndex = 55
        Me.HymnalHymnFontBtn.TabStop = False
        Me.HymnalHymnFontBtn.UseVisualStyleBackColor = True
        '
        'HymnalHymnColorBtn
        '
        Me.HymnalHymnColorBtn.BackgroundImage = CType(resources.GetObject("HymnalHymnColorBtn.BackgroundImage"), System.Drawing.Image)
        Me.HymnalHymnColorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HymnalHymnColorBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HymnalHymnColorBtn.Location = New System.Drawing.Point(34, 34)
        Me.HymnalHymnColorBtn.Name = "HymnalHymnColorBtn"
        Me.HymnalHymnColorBtn.Size = New System.Drawing.Size(25, 25)
        Me.HymnalHymnColorBtn.TabIndex = 54
        Me.HymnalHymnColorBtn.TabStop = False
        Me.HymnalHymnColorBtn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = Global.TJCPowerPoint.My.Resources.Resources.icons8_musical_notes_16
        Me.PictureBox1.Location = New System.Drawing.Point(65, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 30)
        Me.PictureBox1.TabIndex = 61
        Me.PictureBox1.TabStop = False
        '
        'HymnalTxt
        '
        Me.HymnalTxt.AcceptsReturn = True
        Me.HymnalTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HymnalTxt.Dock = System.Windows.Forms.DockStyle.Top
        Me.HymnalTxt.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HymnalTxt.Location = New System.Drawing.Point(103, 3)
        Me.HymnalTxt.Multiline = True
        Me.HymnalTxt.Name = "HymnalTxt"
        Me.HymnalTxt.Size = New System.Drawing.Size(94, 25)
        Me.HymnalTxt.TabIndex = 53
        Me.HymnalTxt.TabStop = False
        '
        'ClearHymnalBtn
        '
        Me.ClearHymnalBtn.AutoSize = True
        Me.ClearHymnalBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClearHymnalBtn.BackColor = System.Drawing.Color.Transparent
        Me.ClearHymnalBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClearHymnalBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClearHymnalBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ClearHymnalBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearHymnalBtn.ForeColor = System.Drawing.Color.Maroon
        Me.ClearHymnalBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClearHymnalBtn.Location = New System.Drawing.Point(103, 134)
        Me.ClearHymnalBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.ClearHymnalBtn.Name = "ClearHymnalBtn"
        Me.ClearHymnalBtn.Size = New System.Drawing.Size(94, 25)
        Me.ClearHymnalBtn.TabIndex = 60
        Me.ClearHymnalBtn.TabStop = False
        Me.ClearHymnalBtn.Text = "Clear All"
        Me.ClearHymnalBtn.UseVisualStyleBackColor = False
        '
        'HymnalListBox
        '
        Me.HymnalListBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HymnalListBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.HymnalListBox.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HymnalListBox.FormatString = "N0"
        Me.HymnalListBox.FormattingEnabled = True
        Me.HymnalListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.HymnalListBox.ItemHeight = 18
        Me.HymnalListBox.Location = New System.Drawing.Point(3, 3)
        Me.HymnalListBox.Name = "HymnalListBox"
        Me.HymnalListBox.ScrollAlwaysVisible = True
        Me.HymnalListBox.Size = New System.Drawing.Size(100, 156)
        Me.HymnalListBox.TabIndex = 56
        Me.HymnalListBox.TabStop = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.ProjectSlidePanel, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.Padding = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(814, 87)
        Me.TableLayoutPanel2.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global.TJCPowerPoint.My.Resources.Resources.background
        Me.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 39)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel2.Size = New System.Drawing.Size(834, 107)
        Me.Panel2.TabIndex = 9
        '
        'MainProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(834, 451)
        Me.Controls.Add(Me.EditSlidePanel)
        Me.Controls.Add(Me.BibleVerseGroupBox)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.navBar)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(850, 490)
        Me.Name = "MainProgram"
        Me.Text = "True Jesus Church PowerPoint"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.EditSlidePanel.ResumeLayout(False)
        Me.EditSlidePanel.PerformLayout()
        Me.ProjectSlidePanel.ResumeLayout(False)
        Me.Title.ResumeLayout(False)
        Me.Title.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.BibleVerseGroupBox.ResumeLayout(False)
        Me.BibleVerseGroupBox.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.navBar.ResumeLayout(False)
        Me.navBar.PerformLayout()
        CType(Me.HeaderLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.hymnTabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.FlowLayoutPanel8.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ServiceTypeTxt As ComboBox
    Friend WithEvents UpdateTitleBtn As Button
    Friend WithEvents ResetAllBtn As Button
    Friend WithEvents EnglishTitleTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents EnglishFontBtn As Button
    Friend WithEvents EnglishColorBtn As Button
    Friend WithEvents EnglishMoveDownBtn As Button
    Friend WithEvents EnglishMoveUpBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ChineseFontBtn As Button
    Friend WithEvents ChineseColorBtn As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents ChineseTitleTxt As TextBox
    Friend WithEvents Title As GroupBox
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents ChineseMoveDownBtn As Button
    Friend WithEvents ChineseMoveUpBtn As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents ServiceTypeFontBtn As Button
    Friend WithEvents ServiceTypeColorBtn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents ChapterTxt As TextBox
    Friend WithEvents BookTxt As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents EnglishBookFontBtn As Button
    Friend WithEvents EnglishBookColorBtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents ChineseBookFontBtn As Button
    Friend WithEvents ChineseBookColorBtn As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents BibleHDFont As Button
    Friend WithEvents BibleHDColor As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents HymnHDFont As Button
    Friend WithEvents HymnHDColor As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents CVColorBtn As Button
    Friend WithEvents CVFontBtn As Button
    Friend WithEvents UpdateVerseBtn As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents BibleVerseGroupBox As GroupBox
    Friend WithEvents navBar As Panel
    Friend WithEvents HeaderLogo As PictureBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Timer As Timer
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents ColorDialog As ColorDialog
    Public WithEvents FontDialog As FontDialog
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents hymnTabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents FlowLayoutPanel8 As FlowLayoutPanel
    Friend WithEvents PrevHymnBtn As Button
    Friend WithEvents NextHymnBtn As Button
    Friend WithEvents DelHymnBtn As Button
    Friend WithEvents HymnFontBtn As Button
    Friend WithEvents HymnColorBtn As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents SermonHymnTxt As TextBox
    Friend WithEvents ClearSermonHymnsBtn As Button
    Friend WithEvents SermonHymnsListBox As ListBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents HymnalPrevHymnBtn As Button
    Friend WithEvents HymnalNextHymnBtn As Button
    Friend WithEvents HymnalDelHymnBtn As Button
    Friend WithEvents HymnalHymnFontBtn As Button
    Friend WithEvents HymnalHymnColorBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents HymnalTxt As TextBox
    Friend WithEvents ClearHymnalBtn As Button
    Friend WithEvents HymnalListBox As ListBox
    Friend WithEvents EditSlidePanel As FlowLayoutPanel
    Friend WithEvents EditHCBtn As Button
    Friend WithEvents EditTimetableBtn As Button
    Friend WithEvents EditAnnouncementsBtn As Button
    Friend WithEvents EditPRBtn As Button
    Friend WithEvents ProjectSlidePanel As FlowLayoutPanel
    Friend WithEvents ShowSermonHymnsBtn As RadioButton
    Friend WithEvents ShowVersesBtn As RadioButton
    Friend WithEvents ShowHymnalBtn As RadioButton
    Friend WithEvents ShowHowToPrayBtn As RadioButton
    Friend WithEvents ShowPRBtn As RadioButton
    Friend WithEvents ShowBreakBtn As RadioButton
    Friend WithEvents ShowTimetableBtn As RadioButton
    Friend WithEvents ShowAnnouncementsBtn As RadioButton
    Friend WithEvents ShowHCBtn As RadioButton
    Friend WithEvents ShowOffDevicesBtn As RadioButton
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents VerseTxt As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SettingsBtn As Button
End Class
