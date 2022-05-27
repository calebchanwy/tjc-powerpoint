[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
public partial class MainProgram : Form
{

    // Form overrides dispose to clean up the component list.
    [DebuggerNonUserCode()]
    protected override void Dispose(bool disposing)
    {
        try
        {
            if (disposing && components is not null)
            {
                components.Dispose();
            }
        }
        finally
        {
            base.Dispose(disposing);
        }
    }

    // Required by the Windows Form Designer
    private System.ComponentModel.IContainer components;

    // NOTE: The following procedure is required by the Windows Form Designer
    // It can be modified using the Windows Form Designer.  
    // Do not modify it using the code editor.
    [DebuggerStepThrough()]
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainProgram));
        BibleVerse = new GroupBox();
        Label15 = new Label();
        clearbtn = new Button();
        clearbtn.Click += new EventHandler(clearbtn_Click);
        Label13 = new Label();
        Label14 = new Label();
        HymnHDColor = new Button();
        HymnHDColor.Click += new EventHandler(HymnHDColor_Click);
        HymnHDFont = new Button();
        HymnHDFont.Click += new EventHandler(HymnHDFont_Click);
        BibleHDColor = new Button();
        BibleHDColor.Click += new EventHandler(BibleHDColor_Click);
        BibleHDFont = new Button();
        BibleHDFont.Click += new EventHandler(BBibleHDFont_Click);
        UpdateVerse = new Button();
        UpdateVerse.Click += new EventHandler(UpdateVerse_Click);
        Label5 = new Label();
        Label3 = new Label();
        ChineseBookColorBtn = new Button();
        ChineseBookColorBtn.Click += new EventHandler(ChineseBookColorBtn_Click);
        ChineseBookFontBtn = new Button();
        ChineseBookFontBtn.Click += new EventHandler(ChineseBookFontBtn_Click);
        BookBox = new ComboBox();
        BookBox.KeyDown += new KeyEventHandler(BookBox_KeyDown);
        EnglishBookColorBtn = new Button();
        EnglishBookColorBtn.Click += new EventHandler(EnglishBookColorBtn_Click);
        EnglishBookFontBtn = new Button();
        EnglishBookFontBtn.Click += new EventHandler(EnglishBookFontBtn_Click);
        Label9 = new Label();
        Label8 = new Label();
        Label7 = new Label();
        VerseTxt = new TextBox();
        VerseTxt.KeyDown += new KeyEventHandler(Verse_KeyDown);
        Label6 = new Label();
        CVColorBtn = new Button();
        CVColorBtn.Click += new EventHandler(CVColorBtn_Click);
        ChapterTxt = new TextBox();
        ChapterTxt.KeyDown += new KeyEventHandler(Chapter_KeyDown);
        CVFontBtn = new Button();
        CVFontBtn.Click += new EventHandler(CVFontBtn_Click);
        SaveSettings = new Button();
        SaveSettings.Click += new EventHandler(SaveSettings_Click);
        _FontDialog = new FontDialog();
        ColorDialog = new ColorDialog();
        SlideTrack = new ComboBox();
        SlideTrack.SelectedIndexChanged += new EventHandler(SlideTrack_SelectedIndexChanged);
        Label10 = new Label();
        ShowPR = new Button();
        ShowPR.Click += new EventHandler(ShowPR_Click);
        ExitBtn = new Button();
        ExitBtn.Click += new EventHandler(ExitBtn_Click);
        OpenFolder = new Button();
        OpenFolder.Click += new EventHandler(OpenFolder_Click);
        Label12 = new Label();
        SaveFileDialog = new SaveFileDialog();
        Time = new Label();
        Timer = new Timer(components);
        Timer.Tick += new EventHandler(Timer_Tick);
        Show_AN = new Button();
        Show_AN.Click += new EventHandler(Show_AN_Click);
        BGColor = new Button();
        BGColor.Click += new EventHandler(BGColor_Click);
        edtPrayerImg = new Button();
        edtPrayerImg.Click += new EventHandler(edtPrayerImg_Click);
        edtHC = new Button();
        edtHC.Click += new EventHandler(edtHC_Click);
        ServiceTimesBtn = new Button();
        ServiceTimesBtn.Click += new EventHandler(ServiceTimesBtn_Click);
        ChineseColorBtn = new Button();
        ChineseColorBtn.Click += new EventHandler(ChineseColorBtn_Click);
        ChineseFontBtn = new Button();
        ChineseFontBtn.Click += new EventHandler(ChineseFontBtn_Click);
        EnglishFontBtn = new Button();
        EnglishFontBtn.Click += new EventHandler(EnglishFontBtn_Click);
        HymnNos = new TextBox();
        EnglishColorBtn = new Button();
        EnglishColorBtn.Click += new EventHandler(EnglishColorBtn_Click);
        Label4 = new Label();
        Label2 = new Label();
        HymnColorBtn = new Button();
        HymnColorBtn.Click += new EventHandler(HymnColorBtn_Click);
        Label1 = new Label();
        HymnFontBtn = new Button();
        HymnFontBtn.Click += new EventHandler(HymnFontBtn_Click);
        ChineseTitle = new TextBox();
        ChineseTitle.KeyDown += new KeyEventHandler(Titles_KeyDown);
        HymnChange = new Button();
        HymnChange.Click += new EventHandler(HymnChange_Click);
        EnglishTitle = new TextBox();
        EnglishTitle.KeyDown += new KeyEventHandler(Titles_KeyDown);
        UpdateTitle = new Button();
        UpdateTitle.Click += new EventHandler(UpdateTitle_Click);
        ShowVerses = new CheckBox();
        ShowVerses.CheckedChanged += new EventHandler(ShowVerses_CheckedChanged);
        Label11 = new Label();
        ServiceType = new TextBox();
        ServiceType.KeyDown += new KeyEventHandler(ServiceType_KeyDown);
        ServiceTypeColorBtn = new Button();
        ServiceTypeColorBtn.Click += new EventHandler(ServiceTypeColorBtn_Click);
        ServiceTypeFontBtn = new Button();
        ServiceTypeFontBtn.Click += new EventHandler(ServiceTypeFontBtn_Click);
        HymnalTitle = new Button();
        HymnalTitle.Click += new EventHandler(HymnalTitle_Click);
        Label16 = new Label();
        Title = new GroupBox();
        ShowHymn = new CheckBox();
        ShowHymn.CheckedChanged += new EventHandler(ShowHymn_CheckedChanged);
        BibleVerse.SuspendLayout();
        Title.SuspendLayout();
        SuspendLayout();
        // 
        // BibleVerse
        // 
        BibleVerse.BackColor = SystemColors.Control;
        BibleVerse.Controls.Add(Label15);
        BibleVerse.Controls.Add(clearbtn);
        BibleVerse.Controls.Add(Label13);
        BibleVerse.Controls.Add(Label14);
        BibleVerse.Controls.Add(HymnHDColor);
        BibleVerse.Controls.Add(HymnHDFont);
        BibleVerse.Controls.Add(BibleHDColor);
        BibleVerse.Controls.Add(BibleHDFont);
        BibleVerse.Controls.Add(UpdateVerse);
        BibleVerse.Controls.Add(Label5);
        BibleVerse.Controls.Add(Label3);
        BibleVerse.Controls.Add(ChineseBookColorBtn);
        BibleVerse.Controls.Add(ChineseBookFontBtn);
        BibleVerse.Controls.Add(BookBox);
        BibleVerse.Controls.Add(EnglishBookColorBtn);
        BibleVerse.Controls.Add(EnglishBookFontBtn);
        BibleVerse.Controls.Add(Label9);
        BibleVerse.Controls.Add(Label8);
        BibleVerse.Controls.Add(Label7);
        BibleVerse.Controls.Add(VerseTxt);
        BibleVerse.Controls.Add(Label6);
        BibleVerse.Controls.Add(CVColorBtn);
        BibleVerse.Controls.Add(ChapterTxt);
        BibleVerse.Controls.Add(CVFontBtn);
        BibleVerse.Font = new Font("Century Gothic", 9.0f, FontStyle.Underline, GraphicsUnit.Point, 0);
        BibleVerse.ForeColor = SystemColors.ControlDarkDark;
        BibleVerse.Location = new Point(12, 208);
        BibleVerse.Name = "BibleVerse";
        BibleVerse.Size = new Size(785, 144);
        BibleVerse.TabIndex = 16;
        BibleVerse.TabStop = false;
        BibleVerse.Text = "BibleVerse(s)";
        // 
        // Label15
        // 
        Label15.AutoSize = true;
        Label15.Font = new Font("Century Gothic", 8.25f, FontStyle.Italic, GraphicsUnit.Point, 0);
        Label15.ForeColor = Color.Black;
        Label15.Location = new Point(631, 124);
        Label15.Name = "Label15";
        Label15.Size = new Size(152, 15);
        Label15.TabIndex = 29;
        Label15.Text = "(or press enter to update)";
        Label15.TextAlign = ContentAlignment.TopRight;
        // 
        // clearbtn
        // 
        clearbtn.BackColor = SystemColors.Control;
        clearbtn.FlatStyle = FlatStyle.System;
        clearbtn.Font = new Font("Century Gothic", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
        clearbtn.ForeColor = Color.Black;
        clearbtn.Location = new Point(470, 82);
        clearbtn.Name = "clearbtn";
        clearbtn.Size = new Size(54, 42);
        clearbtn.TabIndex = 33;
        clearbtn.TabStop = false;
        clearbtn.Text = "Reset";
        clearbtn.UseVisualStyleBackColor = false;
        // 
        // Label13
        // 
        Label13.AutoSize = true;
        Label13.Font = new Font("Century Gothic", 9.0f, FontStyle.Underline, GraphicsUnit.Point, 0);
        Label13.Location = new Point(321, 79);
        Label13.Name = "Label13";
        Label13.Size = new Size(93, 17);
        Label13.TabIndex = 32;
        Label13.Text = "Hymn Heading";
        // 
        // Label14
        // 
        Label14.AutoSize = true;
        Label14.Font = new Font("Century Gothic", 9.0f, FontStyle.Underline, GraphicsUnit.Point, 0);
        Label14.Location = new Point(233, 79);
        Label14.Name = "Label14";
        Label14.Size = new Size(90, 17);
        Label14.TabIndex = 31;
        Label14.Text = "Bible Heading";
        // 
        // HymnHDColor
        // 
        HymnHDColor.BackgroundImage = (Image)resources.GetObject("HymnHDColor.BackgroundImage");
        HymnHDColor.BackgroundImageLayout = ImageLayout.Stretch;
        HymnHDColor.Location = new Point(332, 99);
        HymnHDColor.Name = "HymnHDColor";
        HymnHDColor.Size = new Size(25, 25);
        HymnHDColor.TabIndex = 29;
        HymnHDColor.TabStop = false;
        HymnHDColor.UseVisualStyleBackColor = true;
        // 
        // HymnHDFont
        // 
        HymnHDFont.BackgroundImage = (Image)resources.GetObject("HymnHDFont.BackgroundImage");
        HymnHDFont.BackgroundImageLayout = ImageLayout.Stretch;
        HymnHDFont.Location = new Point(361, 99);
        HymnHDFont.Name = "HymnHDFont";
        HymnHDFont.Size = new Size(25, 25);
        HymnHDFont.TabIndex = 30;
        HymnHDFont.TabStop = false;
        HymnHDFont.UseVisualStyleBackColor = true;
        // 
        // BibleHDColor
        // 
        BibleHDColor.BackgroundImage = (Image)resources.GetObject("BibleHDColor.BackgroundImage");
        BibleHDColor.BackgroundImageLayout = ImageLayout.Stretch;
        BibleHDColor.Location = new Point(243, 99);
        BibleHDColor.Name = "BibleHDColor";
        BibleHDColor.Size = new Size(25, 25);
        BibleHDColor.TabIndex = 27;
        BibleHDColor.TabStop = false;
        BibleHDColor.UseVisualStyleBackColor = true;
        // 
        // BibleHDFont
        // 
        BibleHDFont.BackgroundImage = (Image)resources.GetObject("BibleHDFont.BackgroundImage");
        BibleHDFont.BackgroundImageLayout = ImageLayout.Stretch;
        BibleHDFont.Location = new Point(272, 99);
        BibleHDFont.Name = "BibleHDFont";
        BibleHDFont.Size = new Size(25, 25);
        BibleHDFont.TabIndex = 28;
        BibleHDFont.TabStop = false;
        BibleHDFont.UseVisualStyleBackColor = true;
        // 
        // UpdateVerse
        // 
        UpdateVerse.BackColor = SystemColors.ActiveCaption;
        UpdateVerse.FlatStyle = FlatStyle.Flat;
        UpdateVerse.Font = new Font("Century Gothic", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
        UpdateVerse.ForeColor = Color.Black;
        UpdateVerse.Location = new Point(530, 83);
        UpdateVerse.Name = "UpdateVerse";
        UpdateVerse.Size = new Size(249, 40);
        UpdateVerse.TabIndex = 3;
        UpdateVerse.TabStop = false;
        UpdateVerse.Text = "Update Chapter and Verse";
        UpdateVerse.UseVisualStyleBackColor = false;
        // 
        // Label5
        // 
        Label5.AutoSize = true;
        Label5.Font = new Font("Century Gothic", 9.0f, FontStyle.Underline, GraphicsUnit.Point, 0);
        Label5.Location = new Point(101, 78);
        Label5.Name = "Label5";
        Label5.Size = new Size(87, 17);
        Label5.TabIndex = 26;
        Label5.Text = "Chinese Book";
        // 
        // Label3
        // 
        Label3.AutoSize = true;
        Label3.Font = new Font("Century Gothic", 9.0f, FontStyle.Underline, GraphicsUnit.Point, 0);
        Label3.Location = new Point(13, 78);
        Label3.Name = "Label3";
        Label3.Size = new Size(79, 17);
        Label3.TabIndex = 25;
        Label3.Text = "English Book";
        // 
        // ChineseBookColorBtn
        // 
        ChineseBookColorBtn.BackgroundImage = (Image)resources.GetObject("ChineseBookColorBtn.BackgroundImage");
        ChineseBookColorBtn.BackgroundImageLayout = ImageLayout.Stretch;
        ChineseBookColorBtn.Location = new Point(112, 98);
        ChineseBookColorBtn.Name = "ChineseBookColorBtn";
        ChineseBookColorBtn.Size = new Size(25, 25);
        ChineseBookColorBtn.TabIndex = 23;
        ChineseBookColorBtn.TabStop = false;
        ChineseBookColorBtn.UseVisualStyleBackColor = true;
        // 
        // ChineseBookFontBtn
        // 
        ChineseBookFontBtn.BackgroundImage = (Image)resources.GetObject("ChineseBookFontBtn.BackgroundImage");
        ChineseBookFontBtn.BackgroundImageLayout = ImageLayout.Stretch;
        ChineseBookFontBtn.Location = new Point(141, 98);
        ChineseBookFontBtn.Name = "ChineseBookFontBtn";
        ChineseBookFontBtn.Size = new Size(25, 25);
        ChineseBookFontBtn.TabIndex = 24;
        ChineseBookFontBtn.TabStop = false;
        ChineseBookFontBtn.UseVisualStyleBackColor = true;
        // 
        // BookBox
        // 
        BookBox.AutoCompleteCustomSource.AddRange(new string[] { "Genesis,創 世 紀", "Exodus,出 埃 及 記", "Leviticus,利 未 記", "Numbers,民 數 記", "Deuteronomy,申 命 記", "Joshua,約 書 亞 記", "Judges,士 師 記", "Ruth,路 得 記", "1 Samuel,撒 母 耳 記 上", "2 Samuel,撒 母 耳 記 下", "1 Kings,列 王 記 上", "2 Kings,列 王 記 下", "1 Chronicles,歷 代 志 上", "2 Chronicles,歷 代 志 下", "Ezra,以 斯 拉 記", "Nehemiah,尼 希 米 記", "Esther,以 斯 帖 記", "Job,約 伯 記", "Psalms,詩 篇", "Proverbs,箴 言", "Ecclesiastes,傳 道 書", "Song of Songs,雅 歌", "Isaiah,以 賽 亞 書", "Jeremiah,耶 利 米 書", "Lamentations,耶 利 米 哀 歌", "Ezekiel,以 西 結 書", "Daniel,但 以 理 書", "Hosea,何 西 阿 書", "Joel,約 珥 書", "Amos,阿 摩 司 書", "Obadiah,俄 巴 底 亞 書", "Jonah,約 拿 書", "Micah,彌 迦 書", "Nahum,那 鴻 書", "Habakkuk,哈 巴 谷 書", "Zephaniah,西 番 雅 書", "Haggai,哈 該 書", "Zechariah,撒 迦 利 亞", "Malachi,瑪 拉 基 書", "Matthew,馬 太 福 音", "Mark,馬 可 福 音", "Luke,路 加 福 音", "John,約 翰 福 音", "Acts,使 徒 行 傳", "Romans,羅 馬 書", "1 Corinthians,哥 林 多 前 書", "2 Corinthians,哥 林 多 後 書", "Galatians,加 拉 太 書", "Ephesians,以 弗 所 書", "Philippians,腓 立 比 書", "Colossians,歌 羅 西 書", "1 Thessalonians,帖 撒 羅 尼 迦 前 書", "2 Thessalonians,帖 撒 羅 尼 迦 後 書", "1 Timothy,提 摩 太 前 書", "2 Timothy,提 摩 太 後 書", "Titus,提 多 書", "Philemon,腓 利 門 書", "Hebrews,希 伯 來 書", "James,雅 各 書", "1 Peter,彼 得 前 書", "2 Peter,彼 得 後 書", "1 John,約 翰 一 書", "2 John,約 翰 二 書", "3 John,約 翰 三 書", "Jude,猶 大 書", "Revelation,啟 示 錄" });
        BookBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        BookBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        BookBox.DropDownHeight = 100;
        BookBox.FlatStyle = FlatStyle.System;
        BookBox.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
        BookBox.ForeColor = SystemColors.WindowText;
        BookBox.FormattingEnabled = true;
        BookBox.ImeMode = ImeMode.On;
        BookBox.IntegralHeight = false;
        BookBox.Items.AddRange(new object[] { "Genesis,創世紀", "Exodus,出埃及記", "Leviticus,利未記", "Numbers,民數記", "Deuteronomy,申命記", "Joshua,約書亞記", "Judges,士師記", "Ruth,路得記", "1 Samuel,撒母耳記上", "2 Samuel,撒母耳記下", "1 Kings,列王記上", "2 Kings,列王記下", "1 Chronicles,歷代志上", "2 Chronicles,歷代志下", "Ezra,以斯拉記", "Nehemiah,尼希米記", "Esther,以斯帖記", "Job,約伯記", "Psalms,詩篇", "Proverbs,箴言", "Ecclesiastes,傳道書", "Song of Songs,雅歌", "Isaiah,以賽亞書", "Jeremiah,耶利米書", "Lamentations,耶利米哀歌", "Ezekiel,以西結書", "Daniel,但以理書", "Hosea,何西阿書", "Joel,約珥書", "Amos,阿摩司書", "Obadiah,俄巴底亞書", "Jonah,約拿書", "Micah,彌迦書", "Nahum,那鴻書", "Habakkuk,哈巴谷書", "Zephaniah,西番雅書", "Haggai,哈該書", "Zechariah,撒迦利亞", "Malachi,瑪拉基書", "Matthew,馬太福音", "Mark,馬可福音", "Luke,路加福音", "John,約翰福音", "Acts,使徒行傳", "Romans,羅馬書", "1 Corinthians,哥林多前書", "2 Corinthians,哥林多後書", "Galatians,加拉太書", "Ephesians,以弗所書", "Philippians,腓立比書", "Colossians,歌羅西書", "1 Thessalonians,帖撒羅尼迦前書", "2 Thessalonians,帖撒羅尼迦後書", "1 Timothy,提摩太前書", "2 Timothy,提摩太後書", "Titus,提多書", "Philemon,腓利門書", "Hebrews,希伯來書", "James,雅各書", "1 Peter,彼得前書", "2 Peter,彼得後書", "1 John,約翰一書", "2 John,約翰二書", "3 John,約翰三書", "Jude,猶大書", "Revelation,啟示錄" });
        BookBox.Location = new Point(16, 47);
        BookBox.MaxDropDownItems = 5;
        BookBox.Name = "BookBox";
        BookBox.Size = new Size(392, 27);
        BookBox.TabIndex = 0;
        // 
        // EnglishBookColorBtn
        // 
        EnglishBookColorBtn.BackgroundImage = (Image)resources.GetObject("EnglishBookColorBtn.BackgroundImage");
        EnglishBookColorBtn.BackgroundImageLayout = ImageLayout.Stretch;
        EnglishBookColorBtn.Location = new Point(23, 98);
        EnglishBookColorBtn.Name = "EnglishBookColorBtn";
        EnglishBookColorBtn.Size = new Size(25, 25);
        EnglishBookColorBtn.TabIndex = 19;
        EnglishBookColorBtn.TabStop = false;
        EnglishBookColorBtn.UseVisualStyleBackColor = true;
        // 
        // EnglishBookFontBtn
        // 
        EnglishBookFontBtn.BackgroundImage = (Image)resources.GetObject("EnglishBookFontBtn.BackgroundImage");
        EnglishBookFontBtn.BackgroundImageLayout = ImageLayout.Stretch;
        EnglishBookFontBtn.Location = new Point(52, 98);
        EnglishBookFontBtn.Name = "EnglishBookFontBtn";
        EnglishBookFontBtn.Size = new Size(25, 25);
        EnglishBookFontBtn.TabIndex = 20;
        EnglishBookFontBtn.TabStop = false;
        EnglishBookFontBtn.UseVisualStyleBackColor = true;
        // 
        // Label9
        // 
        Label9.AutoSize = true;
        Label9.Font = new Font("Century Gothic", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
        Label9.Location = new Point(576, 26);
        Label9.Name = "Label9";
        Label9.Size = new Size(59, 16);
        Label9.TabIndex = 18;
        Label9.Text = "Verse(s)";
        // 
        // Label8
        // 
        Label8.AutoSize = true;
        Label8.Font = new Font("Century Gothic", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
        Label8.Location = new Point(472, 26);
        Label8.Name = "Label8";
        Label8.Size = new Size(60, 16);
        Label8.TabIndex = 17;
        Label8.Text = "Chapter";
        // 
        // Label7
        // 
        Label7.AutoSize = true;
        Label7.BackColor = SystemColors.Control;
        Label7.Font = new Font("Century Gothic", 20.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
        Label7.ForeColor = SystemColors.ControlDarkDark;
        Label7.Location = new Point(547, 43);
        Label7.Name = "Label7";
        Label7.Size = new Size(22, 32);
        Label7.TabIndex = 16;
        Label7.Text = ":";
        // 
        // VerseTxt
        // 
        VerseTxt.Font = new Font("Century Gothic", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
        VerseTxt.Location = new Point(573, 46);
        VerseTxt.Name = "VerseTxt";
        VerseTxt.Size = new Size(144, 31);
        VerseTxt.TabIndex = 2;
        // 
        // Label6
        // 
        Label6.AutoSize = true;
        Label6.Font = new Font("Century Gothic", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
        Label6.Location = new Point(10, 25);
        Label6.Name = "Label6";
        Label6.Size = new Size(46, 18);
        Label6.TabIndex = 10;
        Label6.Text = "Book";
        // 
        // CVColorBtn
        // 
        CVColorBtn.BackgroundImage = (Image)resources.GetObject("CVColorBtn.BackgroundImage");
        CVColorBtn.BackgroundImageLayout = ImageLayout.Stretch;
        CVColorBtn.Location = new Point(723, 45);
        CVColorBtn.Name = "CVColorBtn";
        CVColorBtn.Size = new Size(25, 25);
        CVColorBtn.TabIndex = 4;
        CVColorBtn.TabStop = false;
        CVColorBtn.UseVisualStyleBackColor = true;
        // 
        // ChapterTxt
        // 
        ChapterTxt.Font = new Font("Century Gothic", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
        ChapterTxt.HideSelection = false;
        ChapterTxt.Location = new Point(470, 45);
        ChapterTxt.Name = "ChapterTxt";
        ChapterTxt.Size = new Size(71, 31);
        ChapterTxt.TabIndex = 1;
        // 
        // CVFontBtn
        // 
        CVFontBtn.BackgroundImage = (Image)resources.GetObject("CVFontBtn.BackgroundImage");
        CVFontBtn.BackgroundImageLayout = ImageLayout.Stretch;
        CVFontBtn.Location = new Point(754, 45);
        CVFontBtn.Name = "CVFontBtn";
        CVFontBtn.Size = new Size(25, 25);
        CVFontBtn.TabIndex = 6;
        CVFontBtn.TabStop = false;
        CVFontBtn.UseVisualStyleBackColor = true;
        // 
        // SaveSettings
        // 
        SaveSettings.Font = new Font("Century Gothic", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        SaveSettings.Location = new Point(687, 366);
        SaveSettings.Name = "SaveSettings";
        SaveSettings.Size = new Size(110, 35);
        SaveSettings.TabIndex = 17;
        SaveSettings.TabStop = false;
        SaveSettings.Text = "Save Config";
        SaveSettings.UseVisualStyleBackColor = true;
        // 
        // FontDialog
        // 
        _FontDialog.ShowEffects = false;
        // 
        // SlideTrack
        // 
        SlideTrack.DropDownStyle = ComboBoxStyle.DropDownList;
        SlideTrack.Font = new Font("Century Gothic", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        SlideTrack.FormattingEnabled = true;
        SlideTrack.Location = new Point(114, 366);
        SlideTrack.Name = "SlideTrack";
        SlideTrack.Size = new Size(160, 24);
        SlideTrack.TabIndex = 4;
        SlideTrack.TabStop = false;
        // 
        // Label10
        // 
        Label10.AutoSize = true;
        Label10.Font = new Font("Century Gothic", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
        Label10.Location = new Point(13, 369);
        Label10.Name = "Label10";
        Label10.Size = new Size(95, 18);
        Label10.TabIndex = 19;
        Label10.Text = "Go To Slide:";
        // 
        // ShowPR
        // 
        ShowPR.Font = new Font("Century Gothic", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        ShowPR.Location = new Point(288, 366);
        ShowPR.Name = "ShowPR";
        ShowPR.Size = new Size(138, 35);
        ShowPR.TabIndex = 20;
        ShowPR.TabStop = false;
        ShowPR.Text = "Edit Prayer Requests";
        ShowPR.UseVisualStyleBackColor = true;
        // 
        // ExitBtn
        // 
        ExitBtn.BackColor = Color.White;
        ExitBtn.Font = new Font("Century Gothic", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        ExitBtn.Location = new Point(687, 407);
        ExitBtn.Name = "ExitBtn";
        ExitBtn.Size = new Size(110, 35);
        ExitBtn.TabIndex = 22;
        ExitBtn.TabStop = false;
        ExitBtn.Text = "Exit";
        ExitBtn.UseVisualStyleBackColor = false;
        // 
        // OpenFolder
        // 
        OpenFolder.Font = new Font("Century Gothic", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        OpenFolder.Location = new Point(570, 407);
        OpenFolder.Name = "OpenFolder";
        OpenFolder.Size = new Size(109, 35);
        OpenFolder.TabIndex = 23;
        OpenFolder.TabStop = false;
        OpenFolder.Text = "Open Folder";
        OpenFolder.UseVisualStyleBackColor = true;
        // 
        // Label12
        // 
        Label12.AutoSize = true;
        Label12.Font = new Font("Century Gothic", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        Label12.Location = new Point(13, 401);
        Label12.Name = "Label12";
        Label12.Size = new Size(229, 16);
        Label12.TabIndex = 24;
        Label12.Text = "Change Current Slide Background Colour";
        // 
        // SaveFileDialog
        // 
        SaveFileDialog.FileName = "Settings.ini";
        SaveFileDialog.Filter = "INI Files (*.ini)|*.ini|All Files (*.*)|*.*\"";
        SaveFileDialog.RestoreDirectory = true;
        // 
        // Time
        // 
        Time.AutoSize = true;
        Time.Font = new Font("Century Gothic", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        Time.Location = new Point(13, 423);
        Time.Name = "Time";
        Time.Size = new Size(34, 16);
        Time.TabIndex = 25;
        Time.Text = "Time:";
        // 
        // Timer
        // 
        Timer.Enabled = true;
        Timer.Interval = 1000;
        // 
        // Show_AN
        // 
        Show_AN.Font = new Font("Century Gothic", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        Show_AN.Location = new Point(432, 366);
        Show_AN.Name = "Show_AN";
        Show_AN.Size = new Size(128, 35);
        Show_AN.TabIndex = 26;
        Show_AN.TabStop = false;
        Show_AN.Text = "Edit Announcements";
        Show_AN.UseVisualStyleBackColor = true;
        // 
        // BGColor
        // 
        BGColor.BackgroundImage = (Image)resources.GetObject("BGColor.BackgroundImage");
        BGColor.BackgroundImageLayout = ImageLayout.Stretch;
        BGColor.Location = new Point(249, 396);
        BGColor.Name = "BGColor";
        BGColor.Size = new Size(25, 25);
        BGColor.TabIndex = 23;
        BGColor.TabStop = false;
        BGColor.UseVisualStyleBackColor = true;
        // 
        // edtPrayerImg
        // 
        edtPrayerImg.Font = new Font("Century Gothic", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        edtPrayerImg.Location = new Point(288, 407);
        edtPrayerImg.Name = "edtPrayerImg";
        edtPrayerImg.Size = new Size(138, 37);
        edtPrayerImg.TabIndex = 27;
        edtPrayerImg.TabStop = false;
        edtPrayerImg.Text = "Edit Prayer Image";
        edtPrayerImg.UseVisualStyleBackColor = true;
        // 
        // edtHC
        // 
        edtHC.Font = new Font("Century Gothic", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        edtHC.Location = new Point(570, 366);
        edtHC.Name = "edtHC";
        edtHC.Size = new Size(109, 35);
        edtHC.TabIndex = 28;
        edtHC.TabStop = false;
        edtHC.Text = "Holy Communion";
        edtHC.UseVisualStyleBackColor = true;
        // 
        // ServiceTimesBtn
        // 
        ServiceTimesBtn.Font = new Font("Century Gothic", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        ServiceTimesBtn.Location = new Point(432, 407);
        ServiceTimesBtn.Name = "ServiceTimesBtn";
        ServiceTimesBtn.Size = new Size(128, 35);
        ServiceTimesBtn.TabIndex = 29;
        ServiceTimesBtn.TabStop = false;
        ServiceTimesBtn.Text = "Edit Timetable";
        ServiceTimesBtn.UseVisualStyleBackColor = true;
        // 
        // ChineseColorBtn
        // 
        ChineseColorBtn.BackgroundImage = (Image)resources.GetObject("ChineseColorBtn.BackgroundImage");
        ChineseColorBtn.BackgroundImageLayout = ImageLayout.Stretch;
        ChineseColorBtn.Location = new Point(723, 58);
        ChineseColorBtn.Name = "ChineseColorBtn";
        ChineseColorBtn.Size = new Size(25, 25);
        ChineseColorBtn.TabIndex = 7;
        ChineseColorBtn.TabStop = false;
        ChineseColorBtn.UseVisualStyleBackColor = true;
        // 
        // ChineseFontBtn
        // 
        ChineseFontBtn.BackgroundImage = (Image)resources.GetObject("ChineseFontBtn.BackgroundImage");
        ChineseFontBtn.BackgroundImageLayout = ImageLayout.Stretch;
        ChineseFontBtn.Location = new Point(754, 58);
        ChineseFontBtn.Name = "ChineseFontBtn";
        ChineseFontBtn.Size = new Size(25, 25);
        ChineseFontBtn.TabIndex = 8;
        ChineseFontBtn.TabStop = false;
        ChineseFontBtn.UseVisualStyleBackColor = true;
        // 
        // EnglishFontBtn
        // 
        EnglishFontBtn.BackgroundImage = (Image)resources.GetObject("EnglishFontBtn.BackgroundImage");
        EnglishFontBtn.BackgroundImageLayout = ImageLayout.Stretch;
        EnglishFontBtn.Location = new Point(754, 17);
        EnglishFontBtn.Name = "EnglishFontBtn";
        EnglishFontBtn.Size = new Size(25, 25);
        EnglishFontBtn.TabIndex = 6;
        EnglishFontBtn.TabStop = false;
        EnglishFontBtn.UseVisualStyleBackColor = true;
        // 
        // HymnNos
        // 
        HymnNos.Font = new Font("Century Gothic", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
        HymnNos.Location = new Point(67, 93);
        HymnNos.Multiline = true;
        HymnNos.Name = "HymnNos";
        HymnNos.Size = new Size(80, 90);
        HymnNos.TabIndex = 4;
        HymnNos.TabStop = false;
        // 
        // EnglishColorBtn
        // 
        EnglishColorBtn.BackgroundImage = (Image)resources.GetObject("EnglishColorBtn.BackgroundImage");
        EnglishColorBtn.BackgroundImageLayout = ImageLayout.Stretch;
        EnglishColorBtn.Location = new Point(723, 17);
        EnglishColorBtn.Name = "EnglishColorBtn";
        EnglishColorBtn.Size = new Size(25, 25);
        EnglishColorBtn.TabIndex = 5;
        EnglishColorBtn.TabStop = false;
        EnglishColorBtn.UseVisualStyleBackColor = true;
        // 
        // Label4
        // 
        Label4.AutoSize = true;
        Label4.Font = new Font("Century Gothic", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
        Label4.Location = new Point(6, 94);
        Label4.Name = "Label4";
        Label4.Size = new Size(56, 18);
        Label4.TabIndex = 10;
        Label4.Text = "Hymns";
        // 
        // Label2
        // 
        Label2.AutoSize = true;
        Label2.Font = new Font("Century Gothic", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
        Label2.Location = new Point(1, 58);
        Label2.Name = "Label2";
        Label2.Size = new Size(68, 18);
        Label2.TabIndex = 3;
        Label2.Text = "Chinese";
        // 
        // HymnColorBtn
        // 
        HymnColorBtn.BackgroundImage = (Image)resources.GetObject("HymnColorBtn.BackgroundImage");
        HymnColorBtn.BackgroundImageLayout = ImageLayout.Stretch;
        HymnColorBtn.Location = new Point(153, 93);
        HymnColorBtn.Name = "HymnColorBtn";
        HymnColorBtn.Size = new Size(25, 25);
        HymnColorBtn.TabIndex = 11;
        HymnColorBtn.TabStop = false;
        HymnColorBtn.UseVisualStyleBackColor = true;
        // 
        // Label1
        // 
        Label1.AutoSize = true;
        Label1.Font = new Font("Century Gothic", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
        Label1.Location = new Point(6, 19);
        Label1.Name = "Label1";
        Label1.Size = new Size(58, 18);
        Label1.TabIndex = 2;
        Label1.Text = "English";
        // 
        // HymnFontBtn
        // 
        HymnFontBtn.BackgroundImage = (Image)resources.GetObject("HymnFontBtn.BackgroundImage");
        HymnFontBtn.BackgroundImageLayout = ImageLayout.Stretch;
        HymnFontBtn.Location = new Point(184, 93);
        HymnFontBtn.Name = "HymnFontBtn";
        HymnFontBtn.Size = new Size(25, 25);
        HymnFontBtn.TabIndex = 12;
        HymnFontBtn.TabStop = false;
        HymnFontBtn.UseVisualStyleBackColor = true;
        // 
        // ChineseTitle
        // 
        ChineseTitle.Font = new Font("Century Gothic", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
        ChineseTitle.Location = new Point(67, 56);
        ChineseTitle.Name = "ChineseTitle";
        ChineseTitle.Size = new Size(650, 31);
        ChineseTitle.TabIndex = 1;
        ChineseTitle.TabStop = false;
        // 
        // HymnChange
        // 
        HymnChange.BackColor = SystemColors.ActiveCaption;
        HymnChange.FlatAppearance.BorderSize = 0;
        HymnChange.FlatStyle = FlatStyle.Flat;
        HymnChange.Font = new Font("Century Gothic", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
        HymnChange.ForeColor = Color.Black;
        HymnChange.Location = new Point(154, 124);
        HymnChange.Name = "HymnChange";
        HymnChange.Size = new Size(68, 58);
        HymnChange.TabIndex = 5;
        HymnChange.TabStop = false;
        HymnChange.Text = "Change Hymns";
        HymnChange.UseVisualStyleBackColor = false;
        // 
        // EnglishTitle
        // 
        EnglishTitle.Font = new Font("Century Gothic", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
        EnglishTitle.Location = new Point(67, 17);
        EnglishTitle.Name = "EnglishTitle";
        EnglishTitle.Size = new Size(650, 31);
        EnglishTitle.TabIndex = 0;
        EnglishTitle.TabStop = false;
        EnglishTitle.WordWrap = false;
        // 
        // UpdateTitle
        // 
        UpdateTitle.BackColor = SystemColors.ActiveCaption;
        UpdateTitle.BackgroundImageLayout = ImageLayout.Zoom;
        UpdateTitle.FlatAppearance.BorderSize = 0;
        UpdateTitle.FlatStyle = FlatStyle.Flat;
        UpdateTitle.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
        UpdateTitle.ForeColor = Color.Black;
        UpdateTitle.Location = new Point(506, 133);
        UpdateTitle.Margin = new Padding(0);
        UpdateTitle.Name = "UpdateTitle";
        UpdateTitle.Size = new Size(273, 50);
        UpdateTitle.TabIndex = 3;
        UpdateTitle.TabStop = false;
        UpdateTitle.Text = "Update Title";
        UpdateTitle.UseVisualStyleBackColor = false;
        // 
        // ShowVerses
        // 
        ShowVerses.AutoSize = true;
        ShowVerses.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
        ShowVerses.ForeColor = Color.White;
        ShowVerses.Location = new Point(356, 99);
        ShowVerses.Name = "ShowVerses";
        ShowVerses.Size = new Size(139, 21);
        ShowVerses.TabIndex = 17;
        ShowVerses.TabStop = false;
        ShowVerses.Text = "Show Bible Verses";
        ShowVerses.TextAlign = ContentAlignment.MiddleCenter;
        ShowVerses.UseVisualStyleBackColor = true;
        // 
        // Label11
        // 
        Label11.AutoSize = true;
        Label11.Font = new Font("Century Gothic", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
        Label11.Location = new Point(228, 140);
        Label11.Name = "Label11";
        Label11.Size = new Size(102, 18);
        Label11.TabIndex = 19;
        Label11.Text = "Service Type";
        // 
        // ServiceType
        // 
        ServiceType.Font = new Font("Century Gothic", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
        ServiceType.Location = new Point(228, 161);
        ServiceType.Name = "ServiceType";
        ServiceType.Size = new Size(214, 22);
        ServiceType.TabIndex = 6;
        ServiceType.TabStop = false;
        // 
        // ServiceTypeColorBtn
        // 
        ServiceTypeColorBtn.BackgroundImage = (Image)resources.GetObject("ServiceTypeColorBtn.BackgroundImage");
        ServiceTypeColorBtn.BackgroundImageLayout = ImageLayout.Stretch;
        ServiceTypeColorBtn.Location = new Point(445, 159);
        ServiceTypeColorBtn.Name = "ServiceTypeColorBtn";
        ServiceTypeColorBtn.Size = new Size(25, 25);
        ServiceTypeColorBtn.TabIndex = 14;
        ServiceTypeColorBtn.TabStop = false;
        ServiceTypeColorBtn.UseVisualStyleBackColor = true;
        // 
        // ServiceTypeFontBtn
        // 
        ServiceTypeFontBtn.BackgroundImage = (Image)resources.GetObject("ServiceTypeFontBtn.BackgroundImage");
        ServiceTypeFontBtn.BackgroundImageLayout = ImageLayout.Stretch;
        ServiceTypeFontBtn.Location = new Point(475, 159);
        ServiceTypeFontBtn.Name = "ServiceTypeFontBtn";
        ServiceTypeFontBtn.Size = new Size(25, 25);
        ServiceTypeFontBtn.TabIndex = 15;
        ServiceTypeFontBtn.TabStop = false;
        ServiceTypeFontBtn.UseVisualStyleBackColor = true;
        // 
        // HymnalTitle
        // 
        HymnalTitle.BackColor = Color.Silver;
        HymnalTitle.FlatStyle = FlatStyle.Flat;
        HymnalTitle.Font = new Font("Century Gothic", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
        HymnalTitle.ForeColor = Color.Black;
        HymnalTitle.Location = new Point(506, 94);
        HymnalTitle.Name = "HymnalTitle";
        HymnalTitle.Size = new Size(273, 31);
        HymnalTitle.TabIndex = 20;
        HymnalTitle.TabStop = false;
        HymnalTitle.Text = "Change Title To \"Hymnal\"";
        HymnalTitle.UseVisualStyleBackColor = false;
        // 
        // Label16
        // 
        Label16.AutoSize = true;
        Label16.BackColor = SystemColors.Desktop;
        Label16.Font = new Font("Century Gothic", 8.25f, FontStyle.Italic, GraphicsUnit.Point, 0);
        Label16.ForeColor = SystemColors.AppWorkspace;
        Label16.Location = new Point(326, 143);
        Label16.Name = "Label16";
        Label16.Size = new Size(138, 15);
        Label16.TabIndex = 34;
        Label16.Text = "(press enter to update)";
        Label16.TextAlign = ContentAlignment.TopRight;
        // 
        // Title
        // 
        Title.BackColor = SystemColors.Desktop;
        Title.Controls.Add(ShowHymn);
        Title.Controls.Add(Label16);
        Title.Controls.Add(HymnalTitle);
        Title.Controls.Add(ServiceTypeFontBtn);
        Title.Controls.Add(ServiceTypeColorBtn);
        Title.Controls.Add(ServiceType);
        Title.Controls.Add(Label11);
        Title.Controls.Add(ShowVerses);
        Title.Controls.Add(UpdateTitle);
        Title.Controls.Add(EnglishTitle);
        Title.Controls.Add(HymnChange);
        Title.Controls.Add(ChineseTitle);
        Title.Controls.Add(HymnFontBtn);
        Title.Controls.Add(Label1);
        Title.Controls.Add(HymnColorBtn);
        Title.Controls.Add(Label2);
        Title.Controls.Add(Label4);
        Title.Controls.Add(EnglishColorBtn);
        Title.Controls.Add(HymnNos);
        Title.Controls.Add(EnglishFontBtn);
        Title.Controls.Add(ChineseFontBtn);
        Title.Controls.Add(ChineseColorBtn);
        Title.FlatStyle = FlatStyle.Flat;
        Title.Font = new Font("Century Gothic", 9.0f, FontStyle.Underline, GraphicsUnit.Point, 0);
        Title.ForeColor = SystemColors.ControlDark;
        Title.Location = new Point(12, 12);
        Title.Margin = new Padding(0);
        Title.Name = "Title";
        Title.Size = new Size(785, 190);
        Title.TabIndex = 14;
        Title.TabStop = false;
        Title.Text = "Title";
        // 
        // ShowHymn
        // 
        ShowHymn.AutoSize = true;
        ShowHymn.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
        ShowHymn.ForeColor = Color.White;
        ShowHymn.Location = new Point(233, 99);
        ShowHymn.Name = "ShowHymn";
        ShowHymn.Size = new Size(107, 21);
        ShowHymn.TabIndex = 35;
        ShowHymn.TabStop = false;
        ShowHymn.Text = "Show Hymns";
        ShowHymn.TextAlign = ContentAlignment.MiddleCenter;
        ShowHymn.UseVisualStyleBackColor = true;
        // 
        // MainProgram
        // 
        AutoScaleDimensions = new SizeF(6.0f, 13.0f);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(809, 461);
        Controls.Add(ServiceTimesBtn);
        Controls.Add(edtHC);
        Controls.Add(edtPrayerImg);
        Controls.Add(Show_AN);
        Controls.Add(Time);
        Controls.Add(Label12);
        Controls.Add(BGColor);
        Controls.Add(OpenFolder);
        Controls.Add(ExitBtn);
        Controls.Add(ShowPR);
        Controls.Add(Label10);
        Controls.Add(SlideTrack);
        Controls.Add(SaveSettings);
        Controls.Add(Title);
        Controls.Add(BibleVerse);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximumSize = new Size(825, 500);
        MinimumSize = new Size(825, 500);
        Name = "MainProgram";
        RightToLeft = RightToLeft.No;
        Text = "True Jesus Church PowerPoint";
        BibleVerse.ResumeLayout(false);
        BibleVerse.PerformLayout();
        Title.ResumeLayout(false);
        Title.PerformLayout();
        Load += new EventHandler(Main_Load);
        FormClosing += new FormClosingEventHandler(Main_FormClosing);
        ResumeLayout(false);
        PerformLayout();

    }
    internal GroupBox BibleVerse;
    internal Label Label9;
    internal Label Label8;
    internal Label Label7;
    internal TextBox VerseTxt;
    internal Label Label6;
    internal Button CVColorBtn;
    internal TextBox ChapterTxt;
    internal Button CVFontBtn;
    internal ComboBox BookBox;
    internal Button EnglishBookColorBtn;
    internal Button EnglishBookFontBtn;
    internal Button SaveSettings;
    internal ColorDialog ColorDialog;
    internal Label Label5;
    internal Label Label3;
    internal Button ChineseBookColorBtn;
    internal Button ChineseBookFontBtn;
    internal ComboBox SlideTrack;
    internal Label Label10;
    internal Button UpdateVerse;
    internal Button ShowPR;
    internal Button ExitBtn;
    internal Button OpenFolder;
    internal Button BGColor;
    internal Label Label12;
    internal SaveFileDialog SaveFileDialog;
    internal Label Label13;
    internal Label Label14;
    internal Button HymnHDColor;
    internal Button HymnHDFont;
    internal Button BibleHDColor;
    internal Button BibleHDFont;
    internal Label Time;
    internal Timer Timer;
    private FontDialog _FontDialog;

    public virtual FontDialog FontDialog
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get
        {
            return _FontDialog;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            _FontDialog = value;
        }
    }
    internal Button Show_AN;
    internal Button edtPrayerImg;
    internal Button edtHC;
    internal Button clearbtn;
    internal Label Label15;
    internal Button ServiceTimesBtn;
    internal Button ChineseColorBtn;
    internal Button ChineseFontBtn;
    internal Button EnglishFontBtn;
    internal TextBox HymnNos;
    internal Button EnglishColorBtn;
    internal Label Label4;
    internal Label Label2;
    internal Button HymnColorBtn;
    internal Label Label1;
    internal Button HymnFontBtn;
    internal TextBox ChineseTitle;
    internal Button HymnChange;
    internal TextBox EnglishTitle;
    internal Button UpdateTitle;
    internal CheckBox ShowVerses;
    internal Label Label11;
    internal TextBox ServiceType;
    internal Button ServiceTypeColorBtn;
    internal Button ServiceTypeFontBtn;
    internal Button HymnalTitle;
    internal Label Label16;
    internal GroupBox Title;
    internal CheckBox ShowHymn;
}
