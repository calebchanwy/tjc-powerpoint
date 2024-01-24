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
        Me.ServiceType = New System.Windows.Forms.ComboBox()
        Me.UpdateTitle = New System.Windows.Forms.Button()
        Me.clearbtn = New System.Windows.Forms.Button()
        Me.EnglishTitle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EnglishFontBtn = New System.Windows.Forms.Button()
        Me.EnglishColorBtn = New System.Windows.Forms.Button()
        Me.moveEnglishDown = New System.Windows.Forms.Button()
        Me.moveEnglishUp = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChineseFontBtn = New System.Windows.Forms.Button()
        Me.ChineseColorBtn = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ChineseTitle = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel7 = New System.Windows.Forms.FlowLayoutPanel()
        Me.edtHC = New System.Windows.Forms.Button()
        Me.ServiceTimesBtn = New System.Windows.Forms.Button()
        Me.Show_AN = New System.Windows.Forms.Button()
        Me.OpenPrayerRequestsWindow = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ShowSermonHymns = New System.Windows.Forms.RadioButton()
        Me.ShowVerses = New System.Windows.Forms.RadioButton()
        Me.ShowHymnal = New System.Windows.Forms.RadioButton()
        Me.goToHowToPrayBtn = New System.Windows.Forms.RadioButton()
        Me.goToPRBtn = New System.Windows.Forms.RadioButton()
        Me.goToBreakBtn = New System.Windows.Forms.RadioButton()
        Me.goToTimetableBtn = New System.Windows.Forms.RadioButton()
        Me.goToAnnouncementsBtn = New System.Windows.Forms.RadioButton()
        Me.goToHCBtn = New System.Windows.Forms.RadioButton()
        Me.goToTurnOffDevicesBtn = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Title = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.moveChineseDown = New System.Windows.Forms.Button()
        Me.moveChineseUp = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ServiceTypeFontBtn = New System.Windows.Forms.Button()
        Me.ServiceTypeColorBtn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ChapterTxt = New System.Windows.Forms.TextBox()
        Me.BookBox = New System.Windows.Forms.ComboBox()
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
        Me.updateVerseBtn = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BibleVerse = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.VerseTxt = New System.Windows.Forms.TextBox()
        Me.settingsBtn = New System.Windows.Forms.RadioButton()
        Me.navBar = New System.Windows.Forms.Panel()
        Me.header = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.FontDialog = New System.Windows.Forms.FontDialog()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.hymnTabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.FlowLayoutPanel8 = New System.Windows.Forms.FlowLayoutPanel()
        Me.prevHymn = New System.Windows.Forms.Button()
        Me.nextHymn = New System.Windows.Forms.Button()
        Me.delHymnBtn = New System.Windows.Forms.Button()
        Me.HymnFontBtn = New System.Windows.Forms.Button()
        Me.HymnColorBtn = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.sermonHymnNo = New System.Windows.Forms.TextBox()
        Me.clearSermonHymnsBtn = New System.Windows.Forms.Button()
        Me.sermonHymnsListBox = New System.Windows.Forms.ListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.hymnalPrevHymn = New System.Windows.Forms.Button()
        Me.hymnalNextHymn = New System.Windows.Forms.Button()
        Me.hymnalDelHymn = New System.Windows.Forms.Button()
        Me.hymnalHymnFont = New System.Windows.Forms.Button()
        Me.hymnalHymnColor = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.hymnalHymnNo = New System.Windows.Forms.TextBox()
        Me.clearHymnalHymns = New System.Windows.Forms.Button()
        Me.hymnalHymnsListBox = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel7.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.Title.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.BibleVerse.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.navBar.SuspendLayout()
        CType(Me.header, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.hymnTabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.FlowLayoutPanel8.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 295.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ServiceType, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.UpdateTitle, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.clearbtn, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(5, 103)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(605, 32)
        Me.TableLayoutPanel1.TabIndex = 37
        '
        'ServiceType
        '
        Me.ServiceType.AutoCompleteCustomSource.AddRange(New String() {"Sabbath Service 安息日聚會", "Sabbath Bible Study", "Sabbath Afternoon Service 安息日聚會", "Friday Evening Sabbath Service", "Wednesday Evening Service", "Bible Study", "End of Year Services", "Spiritual Convocation 靈恩會", "AMTC", "Evangelistic Service 佈道會", "Special Service", "Fellowship", "Autumn Spiritual Convocation 秋天靈恩會", "Spring Spiritual Convocation 春季靈恩會", "NSSC", "YTTC"})
        Me.ServiceType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ServiceType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ServiceType.Cursor = System.Windows.Forms.Cursors.Default
        Me.ServiceType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ServiceType.DropDownHeight = 100
        Me.ServiceType.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ServiceType.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServiceType.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ServiceType.FormattingEnabled = True
        Me.ServiceType.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.ServiceType.IntegralHeight = False
        Me.ServiceType.Items.AddRange(New Object() {"Sabbath Service 安息日聚會", "Sabbath Bible Study", "Sabbath Afternoon Service 安息日聚會", "Friday Evening Sabbath Service", "Wednesday Evening Service", "Bible Study", "End of Year Services", "Spiritual Convocation 靈恩會", "AMTC", "Evangelistic Service 佈道會", "Special Service", "Fellowship", "Autumn Spiritual Convocation 秋天靈恩會", "Spring Spiritual Convocation 春季靈恩會", "NSSC", "YTTC"})
        Me.ServiceType.Location = New System.Drawing.Point(0, 3)
        Me.ServiceType.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.ServiceType.MaxDropDownItems = 5
        Me.ServiceType.Name = "ServiceType"
        Me.ServiceType.Size = New System.Drawing.Size(242, 25)
        Me.ServiceType.TabIndex = 33
        Me.ServiceType.TabStop = False
        '
        'UpdateTitle
        '
        Me.UpdateTitle.AutoSize = True
        Me.UpdateTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UpdateTitle.BackColor = System.Drawing.Color.Transparent
        Me.UpdateTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.UpdateTitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdateTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UpdateTitle.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateTitle.ForeColor = System.Drawing.Color.Navy
        Me.UpdateTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UpdateTitle.Location = New System.Drawing.Point(311, 1)
        Me.UpdateTitle.Margin = New System.Windows.Forms.Padding(1)
        Me.UpdateTitle.Name = "UpdateTitle"
        Me.UpdateTitle.Size = New System.Drawing.Size(293, 30)
        Me.UpdateTitle.TabIndex = 3
        Me.UpdateTitle.TabStop = False
        Me.UpdateTitle.Text = "Update Title(s)"
        Me.UpdateTitle.UseVisualStyleBackColor = False
        '
        'clearbtn
        '
        Me.clearbtn.AutoSize = True
        Me.clearbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.clearbtn.BackColor = System.Drawing.Color.Transparent
        Me.clearbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.clearbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clearbtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clearbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearbtn.ForeColor = System.Drawing.Color.Maroon
        Me.clearbtn.Location = New System.Drawing.Point(243, 1)
        Me.clearbtn.Margin = New System.Windows.Forms.Padding(1)
        Me.clearbtn.MinimumSize = New System.Drawing.Size(50, 30)
        Me.clearbtn.Name = "clearbtn"
        Me.clearbtn.Size = New System.Drawing.Size(66, 30)
        Me.clearbtn.TabIndex = 33
        Me.clearbtn.TabStop = False
        Me.clearbtn.Text = "Reset All"
        Me.clearbtn.UseVisualStyleBackColor = False
        '
        'EnglishTitle
        '
        Me.EnglishTitle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EnglishTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.EnglishTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnglishTitle.Location = New System.Drawing.Point(5, 20)
        Me.EnglishTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.EnglishTitle.Name = "EnglishTitle"
        Me.EnglishTitle.Size = New System.Drawing.Size(605, 33)
        Me.EnglishTitle.TabIndex = 0
        Me.EnglishTitle.TabStop = False
        Me.EnglishTitle.WordWrap = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "English Title"
        '
        'EnglishFontBtn
        '
        Me.EnglishFontBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EnglishFontBtn.BackgroundImage = CType(resources.GetObject("EnglishFontBtn.BackgroundImage"), System.Drawing.Image)
        Me.EnglishFontBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EnglishFontBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EnglishFontBtn.Location = New System.Drawing.Point(79, 3)
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
        Me.EnglishColorBtn.Location = New System.Drawing.Point(110, 3)
        Me.EnglishColorBtn.Name = "EnglishColorBtn"
        Me.EnglishColorBtn.Size = New System.Drawing.Size(25, 25)
        Me.EnglishColorBtn.TabIndex = 5
        Me.EnglishColorBtn.TabStop = False
        Me.EnglishColorBtn.UseVisualStyleBackColor = True
        '
        'moveEnglishDown
        '
        Me.moveEnglishDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.moveEnglishDown.BackgroundImage = CType(resources.GetObject("moveEnglishDown.BackgroundImage"), System.Drawing.Image)
        Me.moveEnglishDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.moveEnglishDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.moveEnglishDown.Location = New System.Drawing.Point(141, 3)
        Me.moveEnglishDown.Name = "moveEnglishDown"
        Me.moveEnglishDown.Size = New System.Drawing.Size(25, 25)
        Me.moveEnglishDown.TabIndex = 40
        Me.moveEnglishDown.TabStop = False
        Me.moveEnglishDown.UseVisualStyleBackColor = True
        '
        'moveEnglishUp
        '
        Me.moveEnglishUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.moveEnglishUp.BackgroundImage = CType(resources.GetObject("moveEnglishUp.BackgroundImage"), System.Drawing.Image)
        Me.moveEnglishUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.moveEnglishUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.moveEnglishUp.Location = New System.Drawing.Point(172, 3)
        Me.moveEnglishUp.Name = "moveEnglishUp"
        Me.moveEnglishUp.Size = New System.Drawing.Size(25, 25)
        Me.moveEnglishUp.TabIndex = 41
        Me.moveEnglishUp.TabStop = False
        Me.moveEnglishUp.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(203, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 15)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Chinese Title"
        '
        'ChineseFontBtn
        '
        Me.ChineseFontBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChineseFontBtn.BackgroundImage = CType(resources.GetObject("ChineseFontBtn.BackgroundImage"), System.Drawing.Image)
        Me.ChineseFontBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ChineseFontBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChineseFontBtn.Location = New System.Drawing.Point(283, 3)
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
        Me.ChineseColorBtn.Location = New System.Drawing.Point(314, 3)
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
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(5, 86)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 17)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Service Type"
        '
        'ChineseTitle
        '
        Me.ChineseTitle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ChineseTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChineseTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChineseTitle.Location = New System.Drawing.Point(5, 53)
        Me.ChineseTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.ChineseTitle.Name = "ChineseTitle"
        Me.ChineseTitle.Size = New System.Drawing.Size(605, 33)
        Me.ChineseTitle.TabIndex = 1
        Me.ChineseTitle.TabStop = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label15, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel7, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel4, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(5, 355)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(824, 105)
        Me.TableLayoutPanel2.TabIndex = 39
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(579, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(242, 17)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Edit Slide"
        '
        'FlowLayoutPanel7
        '
        Me.FlowLayoutPanel7.AutoSize = True
        Me.FlowLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.FlowLayoutPanel7.Controls.Add(Me.edtHC)
        Me.FlowLayoutPanel7.Controls.Add(Me.ServiceTimesBtn)
        Me.FlowLayoutPanel7.Controls.Add(Me.Show_AN)
        Me.FlowLayoutPanel7.Controls.Add(Me.OpenPrayerRequestsWindow)
        Me.FlowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel7.Location = New System.Drawing.Point(579, 20)
        Me.FlowLayoutPanel7.Name = "FlowLayoutPanel7"
        Me.FlowLayoutPanel7.Size = New System.Drawing.Size(242, 62)
        Me.FlowLayoutPanel7.TabIndex = 30
        '
        'edtHC
        '
        Me.edtHC.AutoSize = True
        Me.edtHC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.edtHC.BackColor = System.Drawing.Color.Transparent
        Me.edtHC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.edtHC.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.edtHC.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtHC.Location = New System.Drawing.Point(3, 3)
        Me.edtHC.Name = "edtHC"
        Me.edtHC.Size = New System.Drawing.Size(116, 24)
        Me.edtHC.TabIndex = 28
        Me.edtHC.TabStop = False
        Me.edtHC.Text = "Holy Communion"
        Me.edtHC.UseVisualStyleBackColor = False
        '
        'ServiceTimesBtn
        '
        Me.ServiceTimesBtn.AutoSize = True
        Me.ServiceTimesBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ServiceTimesBtn.BackColor = System.Drawing.Color.Transparent
        Me.ServiceTimesBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ServiceTimesBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServiceTimesBtn.Location = New System.Drawing.Point(125, 3)
        Me.ServiceTimesBtn.Name = "ServiceTimesBtn"
        Me.ServiceTimesBtn.Padding = New System.Windows.Forms.Padding(5, 0, 3, 0)
        Me.ServiceTimesBtn.Size = New System.Drawing.Size(78, 25)
        Me.ServiceTimesBtn.TabIndex = 29
        Me.ServiceTimesBtn.TabStop = False
        Me.ServiceTimesBtn.Text = "Timetable"
        Me.ServiceTimesBtn.UseVisualStyleBackColor = False
        '
        'Show_AN
        '
        Me.Show_AN.AutoSize = True
        Me.Show_AN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Show_AN.BackColor = System.Drawing.Color.Transparent
        Me.Show_AN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Show_AN.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Show_AN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Show_AN.Location = New System.Drawing.Point(3, 34)
        Me.Show_AN.Name = "Show_AN"
        Me.Show_AN.Padding = New System.Windows.Forms.Padding(5, 0, 3, 0)
        Me.Show_AN.Size = New System.Drawing.Size(113, 25)
        Me.Show_AN.TabIndex = 26
        Me.Show_AN.TabStop = False
        Me.Show_AN.Text = "Announcements"
        Me.Show_AN.UseVisualStyleBackColor = False
        '
        'OpenPrayerRequestsWindow
        '
        Me.OpenPrayerRequestsWindow.AutoSize = True
        Me.OpenPrayerRequestsWindow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.OpenPrayerRequestsWindow.BackColor = System.Drawing.Color.Transparent
        Me.OpenPrayerRequestsWindow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OpenPrayerRequestsWindow.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenPrayerRequestsWindow.Location = New System.Drawing.Point(122, 34)
        Me.OpenPrayerRequestsWindow.Name = "OpenPrayerRequestsWindow"
        Me.OpenPrayerRequestsWindow.Padding = New System.Windows.Forms.Padding(5, 0, 3, 0)
        Me.OpenPrayerRequestsWindow.Size = New System.Drawing.Size(108, 25)
        Me.OpenPrayerRequestsWindow.TabIndex = 20
        Me.OpenPrayerRequestsWindow.TabStop = False
        Me.OpenPrayerRequestsWindow.Text = "Prayer Requests"
        Me.OpenPrayerRequestsWindow.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.AutoSize = True
        Me.FlowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.FlowLayoutPanel4.Controls.Add(Me.ShowSermonHymns)
        Me.FlowLayoutPanel4.Controls.Add(Me.ShowVerses)
        Me.FlowLayoutPanel4.Controls.Add(Me.ShowHymnal)
        Me.FlowLayoutPanel4.Controls.Add(Me.goToHowToPrayBtn)
        Me.FlowLayoutPanel4.Controls.Add(Me.goToPRBtn)
        Me.FlowLayoutPanel4.Controls.Add(Me.goToBreakBtn)
        Me.FlowLayoutPanel4.Controls.Add(Me.goToTimetableBtn)
        Me.FlowLayoutPanel4.Controls.Add(Me.goToAnnouncementsBtn)
        Me.FlowLayoutPanel4.Controls.Add(Me.goToHCBtn)
        Me.FlowLayoutPanel4.Controls.Add(Me.goToTurnOffDevicesBtn)
        Me.FlowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(3, 20)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(570, 62)
        Me.FlowLayoutPanel4.TabIndex = 11
        '
        'ShowSermonHymns
        '
        Me.ShowSermonHymns.Appearance = System.Windows.Forms.Appearance.Button
        Me.ShowSermonHymns.AutoSize = True
        Me.ShowSermonHymns.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ShowSermonHymns.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowSermonHymns.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ShowSermonHymns.Image = Global.TJCPowerPoint.My.Resources.Resources.icons8_music_16
        Me.ShowSermonHymns.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ShowSermonHymns.Location = New System.Drawing.Point(3, 3)
        Me.ShowSermonHymns.Name = "ShowSermonHymns"
        Me.ShowSermonHymns.Size = New System.Drawing.Size(112, 25)
        Me.ShowSermonHymns.TabIndex = 0
        Me.ShowSermonHymns.Text = "    Sermon Hymns"
        Me.ShowSermonHymns.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ShowSermonHymns.UseVisualStyleBackColor = True
        '
        'ShowVerses
        '
        Me.ShowVerses.Appearance = System.Windows.Forms.Appearance.Button
        Me.ShowVerses.AutoSize = True
        Me.ShowVerses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ShowVerses.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowVerses.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ShowVerses.Image = Global.TJCPowerPoint.My.Resources.Resources.icons8_holy_bible_16
        Me.ShowVerses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ShowVerses.Location = New System.Drawing.Point(121, 3)
        Me.ShowVerses.Name = "ShowVerses"
        Me.ShowVerses.Size = New System.Drawing.Size(91, 25)
        Me.ShowVerses.TabIndex = 1
        Me.ShowVerses.Text = "    Bible Verses"
        Me.ShowVerses.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ShowVerses.UseVisualStyleBackColor = True
        '
        'ShowHymnal
        '
        Me.ShowHymnal.Appearance = System.Windows.Forms.Appearance.Button
        Me.ShowHymnal.AutoSize = True
        Me.ShowHymnal.BackColor = System.Drawing.Color.Transparent
        Me.ShowHymnal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ShowHymnal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowHymnal.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ShowHymnal.Image = Global.TJCPowerPoint.My.Resources.Resources.icons8_musical_notes_16
        Me.ShowHymnal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ShowHymnal.Location = New System.Drawing.Point(218, 3)
        Me.ShowHymnal.Name = "ShowHymnal"
        Me.ShowHymnal.Size = New System.Drawing.Size(74, 25)
        Me.ShowHymnal.TabIndex = 2
        Me.ShowHymnal.Text = "    Hymnal "
        Me.ShowHymnal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ShowHymnal.UseVisualStyleBackColor = False
        '
        'goToHowToPrayBtn
        '
        Me.goToHowToPrayBtn.Appearance = System.Windows.Forms.Appearance.Button
        Me.goToHowToPrayBtn.AutoSize = True
        Me.goToHowToPrayBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.goToHowToPrayBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.goToHowToPrayBtn.Image = Global.TJCPowerPoint.My.Resources.Resources.icons8_question_mark_16
        Me.goToHowToPrayBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.goToHowToPrayBtn.Location = New System.Drawing.Point(298, 3)
        Me.goToHowToPrayBtn.Name = "goToHowToPrayBtn"
        Me.goToHowToPrayBtn.Size = New System.Drawing.Size(96, 25)
        Me.goToHowToPrayBtn.TabIndex = 7
        Me.goToHowToPrayBtn.Text = "    How To Pray"
        Me.goToHowToPrayBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.goToHowToPrayBtn.UseVisualStyleBackColor = True
        '
        'goToPRBtn
        '
        Me.goToPRBtn.Appearance = System.Windows.Forms.Appearance.Button
        Me.goToPRBtn.AutoSize = True
        Me.goToPRBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.goToPRBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.goToPRBtn.Image = Global.TJCPowerPoint.My.Resources.Resources.icons8_justify_paragraph_16
        Me.goToPRBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.goToPRBtn.Location = New System.Drawing.Point(400, 3)
        Me.goToPRBtn.Name = "goToPRBtn"
        Me.goToPRBtn.Size = New System.Drawing.Size(112, 25)
        Me.goToPRBtn.TabIndex = 4
        Me.goToPRBtn.Text = "    Prayer Requests"
        Me.goToPRBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.goToPRBtn.UseVisualStyleBackColor = True
        '
        'goToBreakBtn
        '
        Me.goToBreakBtn.Appearance = System.Windows.Forms.Appearance.Button
        Me.goToBreakBtn.AutoSize = True
        Me.goToBreakBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.goToBreakBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.goToBreakBtn.Image = Global.TJCPowerPoint.My.Resources.Resources.icons8_cup_16
        Me.goToBreakBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.goToBreakBtn.Location = New System.Drawing.Point(3, 34)
        Me.goToBreakBtn.Name = "goToBreakBtn"
        Me.goToBreakBtn.Size = New System.Drawing.Size(58, 25)
        Me.goToBreakBtn.TabIndex = 5
        Me.goToBreakBtn.Text = "    Break"
        Me.goToBreakBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.goToBreakBtn.UseVisualStyleBackColor = True
        '
        'goToTimetableBtn
        '
        Me.goToTimetableBtn.Appearance = System.Windows.Forms.Appearance.Button
        Me.goToTimetableBtn.AutoSize = True
        Me.goToTimetableBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.goToTimetableBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.goToTimetableBtn.Image = Global.TJCPowerPoint.My.Resources.Resources.icons8_schedule_16
        Me.goToTimetableBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.goToTimetableBtn.Location = New System.Drawing.Point(67, 34)
        Me.goToTimetableBtn.Name = "goToTimetableBtn"
        Me.goToTimetableBtn.Size = New System.Drawing.Size(82, 25)
        Me.goToTimetableBtn.TabIndex = 9
        Me.goToTimetableBtn.Text = "    Timetable"
        Me.goToTimetableBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.goToTimetableBtn.UseVisualStyleBackColor = True
        '
        'goToAnnouncementsBtn
        '
        Me.goToAnnouncementsBtn.Appearance = System.Windows.Forms.Appearance.Button
        Me.goToAnnouncementsBtn.AutoSize = True
        Me.goToAnnouncementsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.goToAnnouncementsBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.goToAnnouncementsBtn.Image = Global.TJCPowerPoint.My.Resources.Resources.icons8_announcement_16
        Me.goToAnnouncementsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.goToAnnouncementsBtn.Location = New System.Drawing.Point(155, 34)
        Me.goToAnnouncementsBtn.Name = "goToAnnouncementsBtn"
        Me.goToAnnouncementsBtn.Size = New System.Drawing.Size(117, 25)
        Me.goToAnnouncementsBtn.TabIndex = 6
        Me.goToAnnouncementsBtn.Text = "    Announcements"
        Me.goToAnnouncementsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.goToAnnouncementsBtn.UseVisualStyleBackColor = True
        '
        'goToHCBtn
        '
        Me.goToHCBtn.Appearance = System.Windows.Forms.Appearance.Button
        Me.goToHCBtn.AutoSize = True
        Me.goToHCBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.goToHCBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.goToHCBtn.Image = Global.TJCPowerPoint.My.Resources.Resources.icons8_holy_bible_16
        Me.goToHCBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.goToHCBtn.Location = New System.Drawing.Point(278, 34)
        Me.goToHCBtn.Name = "goToHCBtn"
        Me.goToHCBtn.Size = New System.Drawing.Size(124, 25)
        Me.goToHCBtn.TabIndex = 10
        Me.goToHCBtn.Text = "    Holy Communion"
        Me.goToHCBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.goToHCBtn.UseVisualStyleBackColor = True
        '
        'goToTurnOffDevicesBtn
        '
        Me.goToTurnOffDevicesBtn.Appearance = System.Windows.Forms.Appearance.Button
        Me.goToTurnOffDevicesBtn.AutoSize = True
        Me.goToTurnOffDevicesBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.goToTurnOffDevicesBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.goToTurnOffDevicesBtn.Image = Global.TJCPowerPoint.My.Resources.Resources.icons8_no_mobile_16
        Me.goToTurnOffDevicesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.goToTurnOffDevicesBtn.Location = New System.Drawing.Point(408, 34)
        Me.goToTurnOffDevicesBtn.Name = "goToTurnOffDevicesBtn"
        Me.goToTurnOffDevicesBtn.Size = New System.Drawing.Size(117, 25)
        Me.goToTurnOffDevicesBtn.TabIndex = 8
        Me.goToTurnOffDevicesBtn.Text = "    Turn Off Devices"
        Me.goToTurnOffDevicesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.goToTurnOffDevicesBtn.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(570, 17)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Project Slide"
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Title.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Title.Controls.Add(Me.FlowLayoutPanel3)
        Me.Title.Controls.Add(Me.TableLayoutPanel1)
        Me.Title.Controls.Add(Me.Label11)
        Me.Title.Controls.Add(Me.ChineseTitle)
        Me.Title.Controls.Add(Me.EnglishTitle)
        Me.Title.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Title.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Title.Location = New System.Drawing.Point(3, 0)
        Me.Title.Margin = New System.Windows.Forms.Padding(0)
        Me.Title.MinimumSize = New System.Drawing.Size(550, 0)
        Me.Title.Name = "Title"
        Me.Title.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Title.Size = New System.Drawing.Size(615, 190)
        Me.Title.TabIndex = 14
        Me.Title.TabStop = False
        Me.Title.Text = "Sermon Titles"
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.AutoSize = True
        Me.FlowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel3.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel3.Controls.Add(Me.EnglishFontBtn)
        Me.FlowLayoutPanel3.Controls.Add(Me.EnglishColorBtn)
        Me.FlowLayoutPanel3.Controls.Add(Me.moveEnglishDown)
        Me.FlowLayoutPanel3.Controls.Add(Me.moveEnglishUp)
        Me.FlowLayoutPanel3.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel3.Controls.Add(Me.ChineseFontBtn)
        Me.FlowLayoutPanel3.Controls.Add(Me.ChineseColorBtn)
        Me.FlowLayoutPanel3.Controls.Add(Me.moveChineseDown)
        Me.FlowLayoutPanel3.Controls.Add(Me.moveChineseUp)
        Me.FlowLayoutPanel3.Controls.Add(Me.Label10)
        Me.FlowLayoutPanel3.Controls.Add(Me.ServiceTypeFontBtn)
        Me.FlowLayoutPanel3.Controls.Add(Me.ServiceTypeColorBtn)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(5, 135)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(605, 31)
        Me.FlowLayoutPanel3.TabIndex = 34
        '
        'moveChineseDown
        '
        Me.moveChineseDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.moveChineseDown.BackgroundImage = CType(resources.GetObject("moveChineseDown.BackgroundImage"), System.Drawing.Image)
        Me.moveChineseDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.moveChineseDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.moveChineseDown.Location = New System.Drawing.Point(345, 3)
        Me.moveChineseDown.Name = "moveChineseDown"
        Me.moveChineseDown.Size = New System.Drawing.Size(25, 25)
        Me.moveChineseDown.TabIndex = 39
        Me.moveChineseDown.TabStop = False
        Me.moveChineseDown.UseVisualStyleBackColor = True
        '
        'moveChineseUp
        '
        Me.moveChineseUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.moveChineseUp.AutoSize = True
        Me.moveChineseUp.BackgroundImage = CType(resources.GetObject("moveChineseUp.BackgroundImage"), System.Drawing.Image)
        Me.moveChineseUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.moveChineseUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.moveChineseUp.Location = New System.Drawing.Point(376, 3)
        Me.moveChineseUp.Name = "moveChineseUp"
        Me.moveChineseUp.Size = New System.Drawing.Size(25, 25)
        Me.moveChineseUp.TabIndex = 38
        Me.moveChineseUp.TabStop = False
        Me.moveChineseUp.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(407, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 15)
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
        Me.ServiceTypeFontBtn.Location = New System.Drawing.Point(484, 3)
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
        Me.ServiceTypeColorBtn.Location = New System.Drawing.Point(514, 3)
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
        Me.Label8.Location = New System.Drawing.Point(361, 0)
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
        Me.ChapterTxt.Location = New System.Drawing.Point(423, 3)
        Me.ChapterTxt.Name = "ChapterTxt"
        Me.ChapterTxt.Size = New System.Drawing.Size(144, 27)
        Me.ChapterTxt.TabIndex = 1
        '
        'BookBox
        '
        Me.BookBox.AutoCompleteCustomSource.AddRange(New String() {"Genesis,創 世 紀", "Exodus,出 埃 及 記", "Leviticus,利 未 記", "Numbers,民 數 記", "Deuteronomy,申 命 記", "Joshua,約 書 亞 記", "Judges,士 師 記", "Ruth,路 得 記", "1 Samuel,撒 母 耳 記 上", "2 Samuel,撒 母 耳 記 下", "1 Kings,列 王 紀 上", "2 Kings,列 王 紀 下", "1 Chronicles,歷 代 志 上", "2 Chronicles,歷 代 志 下", "Ezra,以 斯 拉 記", "Nehemiah,尼 希 米 記", "Esther,以 斯 帖 記", "Job,約 伯 記", "Psalms,詩 篇", "Proverbs,箴 言", "Ecclesiastes,傳 道 書", "Song of Songs,雅 歌", "Isaiah,以 賽 亞 書", "Jeremiah,耶 利 米 書", "Lamentations,耶 利 米 哀 歌", "Ezekiel,以 西 結 書", "Daniel,但 以 理 書", "Hosea,何 西 阿 書", "Joel,約 珥 書", "Amos,阿 摩 司 書", "Obadiah,俄 巴 底 亞 書", "Jonah,約 拿 書", "Micah,彌 迦 書", "Nahum,那 鴻 書", "Habakkuk,哈 巴 谷 書", "Zephaniah,西 番 雅 書", "Haggai,哈 該 書", "Zechariah,撒 迦 利 亞", "Malachi,瑪 拉 基 書", "Matthew,馬 太 福 音", "Mark,馬 可 福 音", "Luke,路 加 福 音", "John,約 翰 福 音", "Acts,使 徒 行 傳", "Romans,羅 馬 書", "1 Corinthians,哥 林 多 前 書", "2 Corinthians,哥 林 多 後 書", "Galatians,加 拉 太 書", "Ephesians,以 弗 所 書", "Philippians,腓 立 比 書", "Colossians,歌 羅 西 書", "1 Thessalonians,帖 撒 羅 尼 迦 前 書", "2 Thessalonians,帖 撒 羅 尼 迦 後 書", "1 Timothy,提 摩 太 前 書", "2 Timothy,提 摩 太 後 書", "Titus,提 多 書", "Philemon,腓 利 門 書", "Hebrews,希 伯 來 書", "James,雅 各 書", "1 Peter,彼 得 前 書", "2 Peter,彼 得 後 書", "1 John,約 翰 一 書", "2 John,約 翰 二 書", "3 John,約 翰 三 書", "Jude,猶 大 書", "Revelation,啟 示 錄"})
        Me.BookBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.BookBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BookBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.BookBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BookBox.DropDownHeight = 100
        Me.BookBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BookBox.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BookBox.FormattingEnabled = True
        Me.BookBox.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.BookBox.IntegralHeight = False
        Me.BookBox.Items.AddRange(New Object() {"Genesis,創世紀", "Exodus,出埃及記", "Leviticus,利未記", "Numbers,民數記", "Deuteronomy,申命記", "Joshua,約書亞記", "Judges,士師記", "Ruth,路得記", "1 Samuel,撒母耳紀上", "2 Samuel,撒母耳紀下", "1 Kings,列王紀上", "2 Kings,列王紀下", "1 Chronicles,歷代志上", "2 Chronicles,歷代志下", "Ezra,以斯拉記", "Nehemiah,尼希米記", "Esther,以斯帖記", "Job,約伯記", "Psalms,詩篇", "Proverbs,箴言", "Ecclesiastes,傳道書", "Song of Songs,雅歌", "Isaiah,以賽亞書", "Jeremiah,耶利米書", "Lamentations,耶利米哀歌", "Ezekiel,以西結書", "Daniel,但以理書", "Hosea,何西阿書", "Joel,約珥書", "Amos,阿摩司書", "Obadiah,俄巴底亞書", "Jonah,約拿書", "Micah,彌迦書", "Nahum,那鴻書", "Habakkuk,哈巴谷書", "Zephaniah,西番雅書", "Haggai,哈該書", "Zechariah,撒迦利亞", "Malachi,瑪拉基書", "Matthew,馬太福音", "Mark,馬可福音", "Luke,路加福音", "John,約翰福音", "Acts,使徒行傳", "Romans,羅馬書", "1 Corinthians,哥林多前書", "2 Corinthians,哥林多後書", "Galatians,加拉太書", "Ephesians,以弗所書", "Philippians,腓立比書", "Colossians,歌羅西書", "1 Thessalonians,帖撒羅尼迦前書", "2 Thessalonians,帖撒羅尼迦後書", "1 Timothy,提摩太前書", "2 Timothy,提摩太後書", "Titus,提多書", "Philemon,腓利門書", "Hebrews,希伯來書", "James,雅各書", "1 Peter,彼得前書", "2 Peter,彼得後書", "1 John,約翰一書", "2 John,約翰二書", "3 John,約翰三書", "Jude,猶大書", "Revelation,啟示錄"})
        Me.BookBox.Location = New System.Drawing.Point(53, 3)
        Me.BookBox.MaxDropDownItems = 5
        Me.BookBox.Name = "BookBox"
        Me.BookBox.Size = New System.Drawing.Size(302, 29)
        Me.BookBox.TabIndex = 0
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
        Me.Label7.Location = New System.Drawing.Point(573, 0)
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
        Me.Label9.Location = New System.Drawing.Point(601, 0)
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
        'updateVerseBtn
        '
        Me.updateVerseBtn.AutoSize = True
        Me.updateVerseBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.updateVerseBtn.BackColor = System.Drawing.Color.Transparent
        Me.updateVerseBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.updateVerseBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.updateVerseBtn.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateVerseBtn.ForeColor = System.Drawing.Color.Navy
        Me.updateVerseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.updateVerseBtn.Location = New System.Drawing.Point(5, 91)
        Me.updateVerseBtn.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.updateVerseBtn.Name = "updateVerseBtn"
        Me.updateVerseBtn.Size = New System.Drawing.Size(814, 30)
        Me.updateVerseBtn.TabIndex = 3
        Me.updateVerseBtn.TabStop = False
        Me.updateVerseBtn.Text = "Update Chapter and Verse"
        Me.updateVerseBtn.UseVisualStyleBackColor = False
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
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(814, 31)
        Me.FlowLayoutPanel1.TabIndex = 33
        '
        'BibleVerse
        '
        Me.BibleVerse.AutoSize = True
        Me.BibleVerse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BibleVerse.BackColor = System.Drawing.Color.Transparent
        Me.BibleVerse.Controls.Add(Me.updateVerseBtn)
        Me.BibleVerse.Controls.Add(Me.FlowLayoutPanel1)
        Me.BibleVerse.Controls.Add(Me.TableLayoutPanel4)
        Me.BibleVerse.Dock = System.Windows.Forms.DockStyle.Top
        Me.BibleVerse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BibleVerse.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BibleVerse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BibleVerse.Location = New System.Drawing.Point(5, 229)
        Me.BibleVerse.Margin = New System.Windows.Forms.Padding(0)
        Me.BibleVerse.Name = "BibleVerse"
        Me.BibleVerse.Padding = New System.Windows.Forms.Padding(5)
        Me.BibleVerse.Size = New System.Drawing.Size(824, 126)
        Me.BibleVerse.TabIndex = 40
        Me.BibleVerse.TabStop = False
        Me.BibleVerse.Text = "Bible Verse(s)"
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
        Me.TableLayoutPanel4.Controls.Add(Me.BookBox, 1, 0)
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
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(814, 35)
        Me.TableLayoutPanel4.TabIndex = 35
        '
        'VerseTxt
        '
        Me.VerseTxt.AcceptsReturn = True
        Me.VerseTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.VerseTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VerseTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerseTxt.Location = New System.Drawing.Point(661, 3)
        Me.VerseTxt.Name = "VerseTxt"
        Me.VerseTxt.Size = New System.Drawing.Size(150, 27)
        Me.VerseTxt.TabIndex = 2
        '
        'settingsBtn
        '
        Me.settingsBtn.Appearance = System.Windows.Forms.Appearance.Button
        Me.settingsBtn.AutoSize = True
        Me.settingsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.settingsBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.settingsBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.settingsBtn.Location = New System.Drawing.Point(759, 5)
        Me.settingsBtn.Name = "settingsBtn"
        Me.settingsBtn.Size = New System.Drawing.Size(60, 29)
        Me.settingsBtn.TabIndex = 8
        Me.settingsBtn.Text = "Settings"
        Me.settingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.settingsBtn.UseVisualStyleBackColor = True
        '
        'navBar
        '
        Me.navBar.AutoSize = True
        Me.navBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.navBar.BackColor = System.Drawing.Color.Transparent
        Me.navBar.Controls.Add(Me.settingsBtn)
        Me.navBar.Controls.Add(Me.header)
        Me.navBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.navBar.Location = New System.Drawing.Point(5, 0)
        Me.navBar.Margin = New System.Windows.Forms.Padding(0)
        Me.navBar.Name = "navBar"
        Me.navBar.Padding = New System.Windows.Forms.Padding(5)
        Me.navBar.Size = New System.Drawing.Size(824, 39)
        Me.navBar.TabIndex = 38
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.Transparent
        Me.header.Cursor = System.Windows.Forms.Cursors.Default
        Me.header.Image = Global.TJCPowerPoint.My.Resources.Resources.tjcpowerpoint
        Me.header.InitialImage = Nothing
        Me.header.Location = New System.Drawing.Point(3, 5)
        Me.header.Margin = New System.Windows.Forms.Padding(0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(330, 29)
        Me.header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.header.TabIndex = 2
        Me.header.TabStop = False
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
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(5, 39)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(824, 190)
        Me.TableLayoutPanel3.TabIndex = 9
        '
        'hymnTabControl
        '
        Me.hymnTabControl.Controls.Add(Me.TabPage1)
        Me.hymnTabControl.Controls.Add(Me.TabPage2)
        Me.hymnTabControl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hymnTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hymnTabControl.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hymnTabControl.Location = New System.Drawing.Point(618, 0)
        Me.hymnTabControl.Margin = New System.Windows.Forms.Padding(0)
        Me.hymnTabControl.Multiline = True
        Me.hymnTabControl.Name = "hymnTabControl"
        Me.hymnTabControl.Padding = New System.Drawing.Point(0, 0)
        Me.hymnTabControl.SelectedIndex = 0
        Me.hymnTabControl.Size = New System.Drawing.Size(206, 190)
        Me.hymnTabControl.TabIndex = 34
        Me.hymnTabControl.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.FlowLayoutPanel8)
        Me.TabPage1.Controls.Add(Me.sermonHymnNo)
        Me.TabPage1.Controls.Add(Me.clearSermonHymnsBtn)
        Me.TabPage1.Controls.Add(Me.sermonHymnsListBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(198, 162)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Sermon Hymns"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel8
        '
        Me.FlowLayoutPanel8.Controls.Add(Me.prevHymn)
        Me.FlowLayoutPanel8.Controls.Add(Me.nextHymn)
        Me.FlowLayoutPanel8.Controls.Add(Me.delHymnBtn)
        Me.FlowLayoutPanel8.Controls.Add(Me.HymnFontBtn)
        Me.FlowLayoutPanel8.Controls.Add(Me.HymnColorBtn)
        Me.FlowLayoutPanel8.Controls.Add(Me.PictureBox2)
        Me.FlowLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel8.Location = New System.Drawing.Point(103, 28)
        Me.FlowLayoutPanel8.Name = "FlowLayoutPanel8"
        Me.FlowLayoutPanel8.Size = New System.Drawing.Size(92, 106)
        Me.FlowLayoutPanel8.TabIndex = 54
        '
        'prevHymn
        '
        Me.prevHymn.BackgroundImage = CType(resources.GetObject("prevHymn.BackgroundImage"), System.Drawing.Image)
        Me.prevHymn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.prevHymn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.prevHymn.Location = New System.Drawing.Point(3, 3)
        Me.prevHymn.Name = "prevHymn"
        Me.prevHymn.Size = New System.Drawing.Size(25, 25)
        Me.prevHymn.TabIndex = 49
        Me.prevHymn.TabStop = False
        Me.prevHymn.UseVisualStyleBackColor = True
        '
        'nextHymn
        '
        Me.nextHymn.BackgroundImage = CType(resources.GetObject("nextHymn.BackgroundImage"), System.Drawing.Image)
        Me.nextHymn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.nextHymn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nextHymn.Location = New System.Drawing.Point(34, 3)
        Me.nextHymn.Name = "nextHymn"
        Me.nextHymn.Size = New System.Drawing.Size(25, 25)
        Me.nextHymn.TabIndex = 48
        Me.nextHymn.TabStop = False
        Me.nextHymn.UseVisualStyleBackColor = True
        '
        'delHymnBtn
        '
        Me.delHymnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.delHymnBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delHymnBtn.Location = New System.Drawing.Point(3, 34)
        Me.delHymnBtn.Name = "delHymnBtn"
        Me.delHymnBtn.Size = New System.Drawing.Size(25, 25)
        Me.delHymnBtn.TabIndex = 50
        Me.delHymnBtn.TabStop = False
        Me.delHymnBtn.UseVisualStyleBackColor = True
        '
        'HymnFontBtn
        '
        Me.HymnFontBtn.BackgroundImage = CType(resources.GetObject("HymnFontBtn.BackgroundImage"), System.Drawing.Image)
        Me.HymnFontBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HymnFontBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HymnFontBtn.Location = New System.Drawing.Point(34, 34)
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
        Me.HymnColorBtn.Location = New System.Drawing.Point(3, 65)
        Me.HymnColorBtn.Name = "HymnColorBtn"
        Me.HymnColorBtn.Size = New System.Drawing.Size(25, 25)
        Me.HymnColorBtn.TabIndex = 45
        Me.HymnColorBtn.TabStop = False
        Me.HymnColorBtn.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(34, 65)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 18)
        Me.PictureBox2.TabIndex = 53
        Me.PictureBox2.TabStop = False
        '
        'sermonHymnNo
        '
        Me.sermonHymnNo.AcceptsReturn = True
        Me.sermonHymnNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.sermonHymnNo.Dock = System.Windows.Forms.DockStyle.Top
        Me.sermonHymnNo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sermonHymnNo.Location = New System.Drawing.Point(103, 3)
        Me.sermonHymnNo.Multiline = True
        Me.sermonHymnNo.Name = "sermonHymnNo"
        Me.sermonHymnNo.Size = New System.Drawing.Size(92, 25)
        Me.sermonHymnNo.TabIndex = 44
        Me.sermonHymnNo.TabStop = False
        '
        'clearSermonHymnsBtn
        '
        Me.clearSermonHymnsBtn.AutoSize = True
        Me.clearSermonHymnsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.clearSermonHymnsBtn.BackColor = System.Drawing.Color.Transparent
        Me.clearSermonHymnsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.clearSermonHymnsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clearSermonHymnsBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.clearSermonHymnsBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearSermonHymnsBtn.ForeColor = System.Drawing.Color.Maroon
        Me.clearSermonHymnsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.clearSermonHymnsBtn.Location = New System.Drawing.Point(103, 134)
        Me.clearSermonHymnsBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.clearSermonHymnsBtn.Name = "clearSermonHymnsBtn"
        Me.clearSermonHymnsBtn.Size = New System.Drawing.Size(92, 25)
        Me.clearSermonHymnsBtn.TabIndex = 52
        Me.clearSermonHymnsBtn.TabStop = False
        Me.clearSermonHymnsBtn.Text = "Clear All"
        Me.clearSermonHymnsBtn.UseVisualStyleBackColor = False
        '
        'sermonHymnsListBox
        '
        Me.sermonHymnsListBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sermonHymnsListBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.sermonHymnsListBox.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sermonHymnsListBox.FormatString = "N0"
        Me.sermonHymnsListBox.FormattingEnabled = True
        Me.sermonHymnsListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.sermonHymnsListBox.ItemHeight = 18
        Me.sermonHymnsListBox.Location = New System.Drawing.Point(3, 3)
        Me.sermonHymnsListBox.Name = "sermonHymnsListBox"
        Me.sermonHymnsListBox.ScrollAlwaysVisible = True
        Me.sermonHymnsListBox.Size = New System.Drawing.Size(100, 156)
        Me.sermonHymnsListBox.TabIndex = 47
        Me.sermonHymnsListBox.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.Controls.Add(Me.FlowLayoutPanel2)
        Me.TabPage2.Controls.Add(Me.hymnalHymnNo)
        Me.TabPage2.Controls.Add(Me.clearHymnalHymns)
        Me.TabPage2.Controls.Add(Me.hymnalHymnsListBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(198, 162)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Hymnal Hymns"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.hymnalPrevHymn)
        Me.FlowLayoutPanel2.Controls.Add(Me.hymnalNextHymn)
        Me.FlowLayoutPanel2.Controls.Add(Me.hymnalDelHymn)
        Me.FlowLayoutPanel2.Controls.Add(Me.hymnalHymnFont)
        Me.FlowLayoutPanel2.Controls.Add(Me.hymnalHymnColor)
        Me.FlowLayoutPanel2.Controls.Add(Me.PictureBox1)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(103, 28)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(92, 106)
        Me.FlowLayoutPanel2.TabIndex = 62
        '
        'hymnalPrevHymn
        '
        Me.hymnalPrevHymn.BackgroundImage = CType(resources.GetObject("hymnalPrevHymn.BackgroundImage"), System.Drawing.Image)
        Me.hymnalPrevHymn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.hymnalPrevHymn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hymnalPrevHymn.Location = New System.Drawing.Point(3, 3)
        Me.hymnalPrevHymn.Name = "hymnalPrevHymn"
        Me.hymnalPrevHymn.Size = New System.Drawing.Size(25, 25)
        Me.hymnalPrevHymn.TabIndex = 58
        Me.hymnalPrevHymn.TabStop = False
        Me.hymnalPrevHymn.UseVisualStyleBackColor = True
        '
        'hymnalNextHymn
        '
        Me.hymnalNextHymn.BackgroundImage = CType(resources.GetObject("hymnalNextHymn.BackgroundImage"), System.Drawing.Image)
        Me.hymnalNextHymn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.hymnalNextHymn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hymnalNextHymn.Location = New System.Drawing.Point(34, 3)
        Me.hymnalNextHymn.Name = "hymnalNextHymn"
        Me.hymnalNextHymn.Size = New System.Drawing.Size(25, 25)
        Me.hymnalNextHymn.TabIndex = 57
        Me.hymnalNextHymn.TabStop = False
        Me.hymnalNextHymn.UseVisualStyleBackColor = True
        '
        'hymnalDelHymn
        '
        Me.hymnalDelHymn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.hymnalDelHymn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hymnalDelHymn.Location = New System.Drawing.Point(3, 34)
        Me.hymnalDelHymn.Name = "hymnalDelHymn"
        Me.hymnalDelHymn.Size = New System.Drawing.Size(25, 25)
        Me.hymnalDelHymn.TabIndex = 59
        Me.hymnalDelHymn.TabStop = False
        Me.hymnalDelHymn.UseVisualStyleBackColor = True
        '
        'hymnalHymnFont
        '
        Me.hymnalHymnFont.BackgroundImage = CType(resources.GetObject("hymnalHymnFont.BackgroundImage"), System.Drawing.Image)
        Me.hymnalHymnFont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.hymnalHymnFont.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hymnalHymnFont.Location = New System.Drawing.Point(34, 34)
        Me.hymnalHymnFont.Name = "hymnalHymnFont"
        Me.hymnalHymnFont.Size = New System.Drawing.Size(25, 25)
        Me.hymnalHymnFont.TabIndex = 55
        Me.hymnalHymnFont.TabStop = False
        Me.hymnalHymnFont.UseVisualStyleBackColor = True
        '
        'hymnalHymnColor
        '
        Me.hymnalHymnColor.BackgroundImage = CType(resources.GetObject("hymnalHymnColor.BackgroundImage"), System.Drawing.Image)
        Me.hymnalHymnColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.hymnalHymnColor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hymnalHymnColor.Location = New System.Drawing.Point(3, 65)
        Me.hymnalHymnColor.Name = "hymnalHymnColor"
        Me.hymnalHymnColor.Size = New System.Drawing.Size(25, 25)
        Me.hymnalHymnColor.TabIndex = 54
        Me.hymnalHymnColor.TabStop = False
        Me.hymnalHymnColor.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(34, 65)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 30)
        Me.PictureBox1.TabIndex = 61
        Me.PictureBox1.TabStop = False
        '
        'hymnalHymnNo
        '
        Me.hymnalHymnNo.AcceptsReturn = True
        Me.hymnalHymnNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.hymnalHymnNo.Dock = System.Windows.Forms.DockStyle.Top
        Me.hymnalHymnNo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hymnalHymnNo.Location = New System.Drawing.Point(103, 3)
        Me.hymnalHymnNo.Multiline = True
        Me.hymnalHymnNo.Name = "hymnalHymnNo"
        Me.hymnalHymnNo.Size = New System.Drawing.Size(92, 25)
        Me.hymnalHymnNo.TabIndex = 53
        Me.hymnalHymnNo.TabStop = False
        '
        'clearHymnalHymns
        '
        Me.clearHymnalHymns.AutoSize = True
        Me.clearHymnalHymns.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.clearHymnalHymns.BackColor = System.Drawing.Color.Transparent
        Me.clearHymnalHymns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.clearHymnalHymns.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clearHymnalHymns.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.clearHymnalHymns.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearHymnalHymns.ForeColor = System.Drawing.Color.Maroon
        Me.clearHymnalHymns.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.clearHymnalHymns.Location = New System.Drawing.Point(103, 134)
        Me.clearHymnalHymns.Margin = New System.Windows.Forms.Padding(0)
        Me.clearHymnalHymns.Name = "clearHymnalHymns"
        Me.clearHymnalHymns.Size = New System.Drawing.Size(92, 25)
        Me.clearHymnalHymns.TabIndex = 60
        Me.clearHymnalHymns.TabStop = False
        Me.clearHymnalHymns.Text = "Clear All"
        Me.clearHymnalHymns.UseVisualStyleBackColor = False
        '
        'hymnalHymnsListBox
        '
        Me.hymnalHymnsListBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hymnalHymnsListBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.hymnalHymnsListBox.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hymnalHymnsListBox.FormatString = "N0"
        Me.hymnalHymnsListBox.FormattingEnabled = True
        Me.hymnalHymnsListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.hymnalHymnsListBox.ItemHeight = 18
        Me.hymnalHymnsListBox.Location = New System.Drawing.Point(3, 3)
        Me.hymnalHymnsListBox.Name = "hymnalHymnsListBox"
        Me.hymnalHymnsListBox.ScrollAlwaysVisible = True
        Me.hymnalHymnsListBox.Size = New System.Drawing.Size(100, 156)
        Me.hymnalHymnsListBox.TabIndex = 56
        Me.hymnalHymnsListBox.TabStop = False
        '
        'MainProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(834, 451)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.BibleVerse)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.navBar)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(850, 490)
        Me.Name = "MainProgram"
        Me.Padding = New System.Windows.Forms.Padding(5, 0, 5, 5)
        Me.Text = "True Jesus Church PowerPoint"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel7.ResumeLayout(False)
        Me.FlowLayoutPanel7.PerformLayout()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.FlowLayoutPanel4.PerformLayout()
        Me.Title.ResumeLayout(False)
        Me.Title.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.BibleVerse.ResumeLayout(False)
        Me.BibleVerse.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.navBar.ResumeLayout(False)
        Me.navBar.PerformLayout()
        CType(Me.header, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ServiceType As ComboBox
    Friend WithEvents UpdateTitle As Button
    Friend WithEvents clearbtn As Button
    Friend WithEvents EnglishTitle As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents EnglishFontBtn As Button
    Friend WithEvents EnglishColorBtn As Button
    Friend WithEvents moveEnglishDown As Button
    Friend WithEvents moveEnglishUp As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ChineseFontBtn As Button
    Friend WithEvents ChineseColorBtn As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents ChineseTitle As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Title As GroupBox
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents moveChineseDown As Button
    Friend WithEvents moveChineseUp As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents ServiceTypeFontBtn As Button
    Friend WithEvents ServiceTypeColorBtn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents ChapterTxt As TextBox
    Friend WithEvents BookBox As ComboBox
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
    Friend WithEvents updateVerseBtn As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents BibleVerse As GroupBox
    Friend WithEvents settingsBtn As RadioButton
    Friend WithEvents navBar As Panel
    Friend WithEvents header As PictureBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Timer As Timer
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents ColorDialog As ColorDialog
    Public WithEvents FontDialog As FontDialog
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents hymnTabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents FlowLayoutPanel8 As FlowLayoutPanel
    Friend WithEvents prevHymn As Button
    Friend WithEvents nextHymn As Button
    Friend WithEvents delHymnBtn As Button
    Friend WithEvents HymnFontBtn As Button
    Friend WithEvents HymnColorBtn As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents sermonHymnNo As TextBox
    Friend WithEvents clearSermonHymnsBtn As Button
    Friend WithEvents sermonHymnsListBox As ListBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents hymnalPrevHymn As Button
    Friend WithEvents hymnalNextHymn As Button
    Friend WithEvents hymnalDelHymn As Button
    Friend WithEvents hymnalHymnFont As Button
    Friend WithEvents hymnalHymnColor As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents hymnalHymnNo As TextBox
    Friend WithEvents clearHymnalHymns As Button
    Friend WithEvents hymnalHymnsListBox As ListBox
    Friend WithEvents FlowLayoutPanel7 As FlowLayoutPanel
    Friend WithEvents edtHC As Button
    Friend WithEvents ServiceTimesBtn As Button
    Friend WithEvents Show_AN As Button
    Friend WithEvents OpenPrayerRequestsWindow As Button
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents ShowSermonHymns As RadioButton
    Friend WithEvents ShowVerses As RadioButton
    Friend WithEvents ShowHymnal As RadioButton
    Friend WithEvents goToHowToPrayBtn As RadioButton
    Friend WithEvents goToPRBtn As RadioButton
    Friend WithEvents goToBreakBtn As RadioButton
    Friend WithEvents goToTimetableBtn As RadioButton
    Friend WithEvents goToAnnouncementsBtn As RadioButton
    Friend WithEvents goToHCBtn As RadioButton
    Friend WithEvents goToTurnOffDevicesBtn As RadioButton
    Friend WithEvents Label15 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents VerseTxt As TextBox
End Class
