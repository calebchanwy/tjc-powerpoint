using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Office = Microsoft.Office.Core;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace TJCPowerPoint
{

    public partial class MainProgram
    {
        private PowerPoint.Application ppApp = new PowerPoint.Application();
        public PowerPoint.Presentation ppPres;
        public string Current = Directory.GetCurrentDirectory();
        private TJCPowerPoint.PrayerRequests PrayerRequests = new TJCPowerPoint.PrayerRequests();
        private XmlTextWriter Writer = null;
        private string RecentFile;

        public MainProgram()
        {
            InitializeComponent();
            FontDialog = _FontDialog;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            MakeFolder();
            LoadPres();
            HandleAnnouncements();
            HandlePR();
            LoadHC();
            LoadPrayerImage();
            LoadTimetableImg();
            // RecentFile = Directory.GetFiles(Current + "\Files\ServiceRecords").OrderByDescending(Function(f) New FileInfo(f).LastWriteTime).First().ToString
            // Dim RecentXML As New XmlDocument()
            // RecentXML.Load(RecentFile)
            // EnglishTitle.Text = RecentXML.DocumentElement.SelectSingleNode("EnglishTitle").InnerText
            // ChineseTitle.Text = RecentXML.DocumentElement.SelectSingleNode("ChineseTitle").InnerText
            // HymnNos.Text = RecentXML.DocumentElement.SelectSingleNode("Hymn").InnerText

            // default opening auto fill
            this.ShowHymn.Checked = true;
            this.EnglishTitle.Text = "English Sermon Title";
            this.ChineseTitle.Text = "中文講道題目";
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Checking for Null errors due to error elsewhere, ensure safe close of program
            if (Writer is not null)
            {
                Writer.WriteEndElement();
                Writer.Close();
            }
            if (ppPres is not null)
            {
                ppPres.Close();
            }
        }

        public object MakeFolder()
        {
            if (Directory.Exists(@"\Files") == false)
            {
                TJCPowerPoint.My.MyProject.Computer.FileSystem.CreateDirectory(Current + @"\Files");
            }

            // If Directory.Exists("\Files\ServiceRecords") = False Then
            // My.Computer.FileSystem.CreateDirectory(Current + "\Files\ServiceRecords")
            // System.IO.File.WriteAllBytes(Current + "\Files\ServiceRecords\1_Jan_1990_000000.xml", My.Resources.XML)
            // End If

            if (File.Exists(Current + @"\Files\ServiceWidescreen.pptx") == false)
            {
                File.WriteAllBytes(Current + @"\Files\ServiceWidescreen.pptx", TJCPowerPoint.My.Resources.Resources.ServiceWidescreen);
            }
            return true;
        }
        public object LoadPres()
        {
            Writer = null;
            ppApp = (PowerPoint.Application)Interaction.CreateObject("PowerPoint.Application");
            ppPres = ppApp.Presentations.Open(Current + @"\Files\ServiceWidescreen.pptx", ReadOnly: Office.MsoTriState.msoFalse, WithWindow: Office.MsoTriState.msoFalse);
            ppPres.Slides[1].Name = "Service/Hymnal";
            ppPres.Slides[2].Name = "Prayer Requests - Image";
            ppPres.Slides[3].Name = "Prayer Requests";
            ppPres.Slides[4].Name = "Announcements";
            ppPres.Slides[5].Name = "Holy Communion";
            ppPres.Slides[6].Name = "How To Pray";
            ppPres.Slides[7].Name = "Turn Off All Devices";
            ppPres.Slides[8].Name = "Service Timetable";
            for (int i = 1, loopTo = ppPres.Slides.Count; i <= loopTo; i++)
                this.SlideTrack.Items.Add(ppPres.Slides[i].Name);
            // InSlide1: 1-English Title, 2 - Chinese Title, 3 - HymnHeader, 4 - Hymns, 5 - BibleHeader, 6 - EnglishBook, 7 - ChineseBook, 8 - Chapter+Verse, 10 - Service Type
            ppPres.Slides[1].Shapes[1].TextFrame.TextRange = " ";
            ppPres.Slides[1].Shapes[2].TextFrame.TextRange = " ";
            ppPres.Slides[1].Shapes[4].TextFrame.TextRange = " ";
            ppPres.Slides[1].Shapes[6].TextFrame.TextRange = " ";
            ppPres.Slides[1].Shapes[7].TextFrame.TextRange = " ";
            ppPres.Slides[1].Shapes[8].TextFrame.TextRange = " ";
            ppPres.Slides[1].Shapes[10].TextFrame.TextRange = " ";
            ppPres.Slides[1].Shapes[5].Visible = Office.MsoTriState.msoFalse;
            HandleSettings();
            ppPres.SlideShowSettings.Run();
            this.SlideTrack.SelectedIndex = 0;

            return true;
        }

        public object LoadHC()
        {
            string bread;
            string cup;
            if (File.Exists(Current + @"\Files\bread.txt") == true)
            {
                bread = File.ReadAllText(Current + @"\Files\bread.txt");
                ppPres.Slides[5].Shapes[1].TextFrame.TextRange = bread;
            }
            if (File.Exists(Current + @"\Files\cup.txt") == true)
            {
                cup = File.ReadAllText(Current + @"\Files\cup.txt");
                ppPres.Slides[5].Shapes[2].TextFrame.TextRange = cup;
            }
            return true;
        }

        public object LoadPrayerImage()
        {
            if (File.Exists(Current + @"\Files\prayerImgDir.txt") == false)
            {
                File.WriteAllText(Current + @"\Files\prayerImgDir.txt", "");
            }
            else
            {
                string directory;
                directory = File.ReadAllText(Current + @"\Files\prayerImgDir.txt");
                if (File.Exists(directory) == true)
                {
                    ppPres.Slides[2].Shapes.AddPicture(directory, (Office.MsoTriState)Conversions.ToInteger(false), (Office.MsoTriState)Conversions.ToInteger(true), 0f, 0f, ppPres.PageSetup.SlideWidth, ppPres.PageSetup.SlideHeight);
                }
            }
            return true;
        }

        public object LoadTimetableImg()
        {
            if (File.Exists(Current + @"\Files\timetableDir.txt") == false)
            {
                File.WriteAllText(Current + @"\Files\timetableDir.txt", "");
            }
            else
            {
                string directory;
                directory = File.ReadAllText(Current + @"\Files\timetableDir.txt");
                if (File.Exists(directory) == true)
                {
                    ppPres.Slides[8].Shapes.AddPicture(directory, (Office.MsoTriState)Conversions.ToInteger(false), (Office.MsoTriState)Conversions.ToInteger(true), 0f, 0f, ppPres.PageSetup.SlideWidth, ppPres.PageSetup.SlideHeight);
                }
            }
            return true;
        }
        public object LoadSettings(string str)
        {
            int two = Conversion.Val(str[2]);
            int three = Conversion.Val(str[3]);
            if (Conversions.ToString(str[1]) == "F")
            {
                string FontName = Strings.Mid(str, Strings.InStr(str, "=") + 1, Strings.InStr(str, ",") - Strings.InStr(str, "=") - 1);
                string FontSize = Strings.Mid(str, Strings.InStr(str, ",") + 1, Strings.Len(str) - Strings.InStr(str, ","));
                ppPres.Slides[two].Shapes[three].TextFrame.TextRange.Font.Name = FontName;
                ppPres.Slides[two].Shapes[three].TextFrame.TextRange.Font.Size = Convert.ToSingle(FontSize);
            }
            else if (Conversions.ToString(str[3]) != "]")
            {
                string FontColor = Strings.Mid(str, Strings.InStr(str, "=") + 1, Strings.Len(str) - Strings.InStr(str, "="));
                ppPres.Slides[two].Shapes[three].TextFrame.TextRange.Font.Color = Color.FromArgb(Convert.ToInt32(FontColor)).ToArgb();
                if (two == Conversions.ToDouble("3"))
                {
                    PrayerRequests.PrayerRequestTxt.ForeColor = Color.FromArgb(Convert.ToInt32(FontColor));
                }
                else if (two == Conversions.ToDouble("4"))
                {
                    TJCPowerPoint.My.MyProject.Forms.Announcements.AnnouncementTxt.ForeColor = Color.FromArgb(Convert.ToInt32(FontColor));
                }
            }
            else
            {
                string BGColor = Strings.Mid(str, Strings.InStr(str, "=") + 1, Strings.Len(str) - Strings.InStr(str, "="));
                ppPres.Slides[two].Background.Fill.ForeColor = Color.FromArgb(Convert.ToInt32(BGColor)).ToArgb();
                if (two == Conversions.ToDouble("3"))
                {
                    int R = Color.FromArgb(Convert.ToInt32(BGColor)).R;
                    int G = Color.FromArgb(Convert.ToInt32(BGColor)).G;
                    int B = Color.FromArgb(Convert.ToInt32(BGColor)).B;
                    PrayerRequests.PrayerRequestTxt.BackColor = Color.FromArgb(255, B, G, R);
                    PrayerRequests.Panel.BackColor = Color.FromArgb(255, B, G, R);
                }
                else if (two == Conversions.ToDouble("4"))
                {
                    int R = Color.FromArgb(Convert.ToInt32(BGColor)).R;
                    int G = Color.FromArgb(Convert.ToInt32(BGColor)).G;
                    int B = Color.FromArgb(Convert.ToInt32(BGColor)).B;
                    TJCPowerPoint.My.MyProject.Forms.Announcements.AnnouncementTxt.BackColor = Color.FromArgb(255, B, G, R);
                    TJCPowerPoint.My.MyProject.Forms.Announcements.Panel.BackColor = Color.FromArgb(255, B, G, R);
                }
            }
            return true;
        }
        public object HandleSettings()
        {
            if (File.Exists(Current + @"\Files\Settings.ini"))
            {
                Array Settings = File.ReadAllLines(Current + @"\Files\Settings.ini");
                foreach (string str in Settings)
                    LoadSettings(str);
            }
            else
            {
                File.WriteAllBytes(Current + @"\Files\Settings.ini", TJCPowerPoint.My.Resources.Resources.Settings);
                Array Settings = File.ReadAllLines(Current + @"\Files\Settings.ini");
                foreach (string str in Settings)
                    LoadSettings(str);
            }
            return true;
        }
        public object HandleAnnouncements()
        {
            if (File.Exists(Current + @"\Files\Announcements.txt"))
            {
                TJCPowerPoint.My.MyProject.Forms.Announcements.AnnouncementTxt.Text = File.ReadAllText(Current + @"\Files\Announcements.txt", System.Text.Encoding.UTF32);
                ppPres.Slides[4].Shapes[1].TextFrame.TextRange = TJCPowerPoint.My.MyProject.Forms.Announcements.AnnouncementTxt.Text;
            }
            else
            {
                using (var sw = File.CreateText(Current + @"\Files\Announcements.txt"))
                {
                    sw.WriteLine(" ");
                }
                TJCPowerPoint.My.MyProject.Forms.Announcements.AnnouncementTxt.Text = File.ReadAllText(Current + @"\Files\Announcements.txt", System.Text.Encoding.UTF32);
                ppPres.Slides[4].Shapes[1].TextFrame.TextRange = TJCPowerPoint.My.MyProject.Forms.Announcements.AnnouncementTxt.Text;
            }
            return true;
        }
        public object HandlePR()
        {
            if (File.Exists(Current + @"\Files\PrayerRequests.txt"))
            {
                PrayerRequests.PrayerRequestTxt.Text = File.ReadAllText(Current + @"\Files\PrayerRequests.txt", System.Text.Encoding.UTF32);
                ppPres.Slides[3].Shapes[1].TextFrame.TextRange = PrayerRequests.PrayerRequestTxt.Text;
            }
            else
            {
                using (var sw = File.CreateText(Current + @"\Files\PrayerRequests.txt"))
                {
                    sw.WriteLine(" ");
                }
                PrayerRequests.PrayerRequestTxt.Text = File.ReadAllText(Current + @"\Files\PrayerRequests.txt", System.Text.Encoding.UTF32);
                ppPres.Slides[3].Shapes[1].TextFrame.TextRange = PrayerRequests.PrayerRequestTxt.Text;
            }
            return true;
        }
        public object ChangeFont(int i, int j)
        {
            this.FontDialog.Font = new Font(ppPres.Slides[i].Shapes[j].TextFrame.TextRange.Font.Name.ToString(), ppPres.Slides[i].Shapes[j].TextFrame.TextRange.Font.Size);
            if (this.FontDialog.ShowDialog() == DialogResult.OK)
            {
                ppPres.Slides[i].Shapes[j].TextFrame.TextRange.Font.Name = this.FontDialog.Font.Name;
                ppPres.Slides[i].Shapes[j].TextFrame.TextRange.Font.Size = this.FontDialog.Font.Size;
            }
            return true;
        }
        public object ChangeColor(int i, int j)
        {
            if (this.ColorDialog.ShowDialog() == DialogResult.OK)
            {
                int Red = Convert.ToInt32(this.ColorDialog.Color.R);
                int Green = Convert.ToInt32(this.ColorDialog.Color.G);
                int Blue = Convert.ToInt32(this.ColorDialog.Color.B);
                ppPres.Slides[i].Shapes[j].TextFrame.TextRange.Font.Color = Color.FromArgb(255, Blue, Green, Red).ToArgb();
            }
            return true;
        }
        public object GetFontAndColor(int i, int j)
        {
            string Font;
            Font = "[F" + i + j + "]=" + ppPres.Slides[i].Shapes[j].TextFrame.TextRange.Font.Name + "," + Convert.ToString(ppPres.Slides[i].Shapes[j].TextFrame.TextRange.Font.Size) + Constants.vbCrLf + "[C" + i + j + "]=" + Convert.ToString(ppPres.Slides[i].Shapes[j].TextFrame.TextRange.Font.Color);

            return Font;
        }

        // ----------------------------FOLLOWING COMMENTED FUNCTIONS REDUNDANT AS NO LONGER SAVING SERVICE RECORDS -----------------------------

        // Public Function MakeXML()
        // Dim Title As String = Replace(EnglishTitle.Text, " ", "_")
        // Dim Name As String = Current + "\Files\ServiceRecords\" + Title + (DateTime.Now.ToString("_dd_MMMM_yyyy_HHmmss")) + ".xml"
        // Dim writer As New XmlTextWriter(Name, System.Text.Encoding.UTF32)
        // writer.WriteStartDocument(True)
        // writer.Formatting = Formatting.Indented
        // writer.Indentation = 2
        // writer.WriteStartElement("ServiceRecord")
        // writer.WriteStartElement("Time")
        // writer.WriteString(DateTime.Now.ToString("HH:mm:ss"))
        // writer.WriteEndElement()
        // writer.WriteStartElement("EnglishTitle")
        // writer.WriteString(EnglishTitle.Text)
        // writer.WriteEndElement()
        // writer.WriteStartElement("ChineseTitle")
        // writer.WriteString(ChineseTitle.Text)
        // writer.WriteEndElement()
        // writer.WriteStartElement("Hymn")
        // writer.WriteString(HymnNos.Text)
        // writer.WriteEndElement()
        // Return writer
        // End Function

        // Public Function WriteXML(writer As XmlTextWriter)
        // Dim commaPos As Integer
        // commaPos = InStr(BookBox.Text, ",")
        // writer.WriteStartElement("Bible")
        // writer.WriteStartElement("Book")
        // writer.WriteStartElement("English")
        // writer.WriteString(Mid(BookBox.Text, 1, commaPos - 1))
        // writer.WriteEndElement()
        // writer.WriteStartElement("Chinese")
        // writer.WriteString(Mid(BookBox.Text, commaPos + 1))
        // writer.WriteEndElement()
        // writer.WriteStartElement("Chapter")
        // writer.WriteString(ChapterTxt.Text)
        // writer.WriteEndElement()
        // writer.WriteStartElement("Verses")
        // writer.WriteString(VerseTxt.Text)
        // writer.WriteEndElement()
        // writer.WriteEndElement()
        // writer.WriteEndElement()
        // Return True
        // End Function

        private void EnglishFontBtn_Click(object sender, EventArgs e)
        {
            ChangeFont(1, 1);
        }
        private void EnglishColorBtn_Click(object sender, EventArgs e)
        {
            ChangeColor(1, 1);
        }
        private void ChineseFontBtn_Click(object sender, EventArgs e)
        {
            ChangeFont(1, 2);
        }
        private void ChineseColorBtn_Click(object sender, EventArgs e)
        {
            ChangeColor(1, 2);
        }
        private void HymnHDFont_Click(object sender, EventArgs e)
        {
            ChangeFont(1, 3);
        }
        private void HymnHDColor_Click(object sender, EventArgs e)
        {
            ChangeColor(1, 3);
        }
        private void HymnFontBtn_Click(object sender, EventArgs e)
        {
            ChangeFont(1, 4);
        }
        private void HymnColorBtn_Click(object sender, EventArgs e)
        {
            ChangeColor(1, 4);
        }
        private void BBibleHDFont_Click(object sender, EventArgs e)
        {
            ChangeFont(1, 5);
        }

        private void BibleHDColor_Click(object sender, EventArgs e)
        {
            ChangeColor(1, 5);
        }
        private void EnglishBookFontBtn_Click(object sender, EventArgs e)
        {
            ChangeFont(1, 6);
        }
        private void EnglishBookColorBtn_Click(object sender, EventArgs e)
        {
            ChangeColor(1, 6);
        }
        private void ChineseBookFontBtn_Click(object sender, EventArgs e)
        {
            ChangeFont(1, 7);
        }
        private void ChineseBookColorBtn_Click(object sender, EventArgs e)
        {
            ChangeColor(1, 7);
        }
        private void CVFontBtn_Click(object sender, EventArgs e)
        {
            ChangeFont(1, 8);
        }
        private void CVColorBtn_Click(object sender, EventArgs e)
        {
            ChangeColor(1, 8);
        }
        private void ServiceTypeFontBtn_Click(object sender, EventArgs e)
        {
            ChangeFont(1, 10);
        }

        private void ServiceTypeColorBtn_Click(object sender, EventArgs e)
        {
            ChangeColor(1, 10);
        }
        private void SlideTrack_SelectedIndexChanged(object sender, EventArgs e)
        {
            ppPres.SlideShowWindow.View.GotoSlide(this.SlideTrack.SelectedIndex + 1);
        }
        private void ShowHymn_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ShowHymn.Checked == true)
            {
                this.ShowVerses.Checked = false;
                ppPres.Slides[1].Shapes[5].Visible = Office.MsoTriState.msoFalse;
                ppPres.Slides[1].Shapes[6].Visible = Office.MsoTriState.msoFalse;
                ppPres.Slides[1].Shapes[7].Visible = Office.MsoTriState.msoFalse;
                ppPres.Slides[1].Shapes[8].Visible = Office.MsoTriState.msoFalse;
                ppPres.Slides[1].Shapes[3].Visible = Office.MsoTriState.msoTrue;
                ppPres.Slides[1].Shapes[4].Visible = Office.MsoTriState.msoTrue;
                ppPres.Slides[1].Shapes[6].TextFrame.TextRange = "";
                ppPres.Slides[1].Shapes[7].TextFrame.TextRange = "";
                ppPres.Slides[1].Shapes[8].TextFrame.TextRange = "";
                this.BookBox.Text = "";
                this.VerseTxt.Text = "";
                this.ChapterTxt.Text = "";
                ppPres.Slides[1].Shapes[4].TextFrame.TextRange = this.HymnNos.Text;
            }
            else if (this.ShowHymn.Checked == false & this.ShowVerses.Checked == false)
            {
                // user has tried to uncheck hymn, whilst not showing verses
                this.ShowHymn.Checked = true;
            }
        }
        private void ShowVerses_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ShowVerses.Checked == true)
            {
                this.ShowHymn.Checked = false;
                ppPres.Slides[1].Shapes[3].Visible = Office.MsoTriState.msoFalse;
                ppPres.Slides[1].Shapes[4].Visible = Office.MsoTriState.msoFalse;
                ppPres.Slides[1].Shapes[5].Visible = Office.MsoTriState.msoTrue;
                ppPres.Slides[1].Shapes[6].Visible = Office.MsoTriState.msoTrue;
                ppPres.Slides[1].Shapes[7].Visible = Office.MsoTriState.msoTrue;
                ppPres.Slides[1].Shapes[8].Visible = Office.MsoTriState.msoTrue;
            }
            else if (this.ShowVerses.Checked == false & this.ShowHymn.Checked == false)
            {
                // user has tried to uncheck verses, whilst not showing hymns
                this.ShowVerses.Checked = true;
            }
        }
        private void UpdateVerse_Click(object sender, EventArgs e)
        {
            // if called when show hymns is checked
            // automatically change to show verses
            if (this.ShowVerses.Checked == false)
            {
                this.ShowVerses.Checked = true;
                this.ShowHymn.Checked = false;
            }
            if (string.IsNullOrEmpty(this.VerseTxt.Text) & string.IsNullOrEmpty(this.BookBox.Text) & string.IsNullOrEmpty(this.ChapterTxt.Text))
            {
                ppPres.Slides[1].Shapes[8].TextFrame.TextRange = "";
            }
            else if (this.BookBox.SelectedIndex != -1)
            {
                int commaPos;
                commaPos = Strings.InStr(this.BookBox.Text, ",");
                ppPres.Slides[1].Shapes[6].TextFrame.TextRange = Strings.Mid(this.BookBox.Text, 1, commaPos - 1);
                ppPres.Slides[1].Shapes[7].TextFrame.TextRange = Strings.Mid(this.BookBox.Text, commaPos + 1);
                ppPres.Slides[1].Shapes[8].TextFrame.TextRange = this.ChapterTxt.Text + " : " + this.VerseTxt.Text;

            }
        }

        private void UpdateTitle_Click(object sender, EventArgs e)
        {
            // Removing blank tabs from titles to force centred titles
            if (this.EnglishTitle.Text.Length > 1 & this.ChineseTitle.Text.Length > 1)
            {
                while (Conversions.ToString(this.EnglishTitle.Text[this.EnglishTitle.Text.Length - 1]) == " " | Conversions.ToString(this.EnglishTitle.Text[this.EnglishTitle.Text.Length - 1]) == "	")
                    this.EnglishTitle.Text = this.EnglishTitle.Text.Remove(this.EnglishTitle.Text.Length - 1);
                while (Conversions.ToString(this.ChineseTitle.Text[this.ChineseTitle.Text.Length - 1]) == " " | Conversions.ToString(this.ChineseTitle.Text[this.ChineseTitle.Text.Length - 1]) == "	")
                    this.ChineseTitle.Text = this.ChineseTitle.Text.Remove(this.ChineseTitle.Text.Length - 1);
                // removing blank spaces from beginning
                while (Conversions.ToString(this.EnglishTitle.Text[0]) == " " | Conversions.ToString(this.EnglishTitle.Text[0]) == "	")
                    this.EnglishTitle.Text = this.EnglishTitle.Text.Remove(0, 1);
                while (Conversions.ToString(this.ChineseTitle.Text[0]) == " " | Conversions.ToString(this.ChineseTitle.Text[0]) == "	")
                    this.ChineseTitle.Text = this.ChineseTitle.Text.Remove(0, 1);
            }
            this.HymnalTitle.Text = "Change Title To \"Hymnal\"";
            ppPres.Slides[1].Shapes[1].TextFrame.TextRange = this.EnglishTitle.Text;
            ppPres.Slides[1].Shapes[2].TextFrame.TextRange = this.ChineseTitle.Text;
        }

        private void HymnalTitle_Click(object sender, EventArgs e)
        {
            if (this.HymnalTitle.Text == "Change Title To \"Hymnal\"")
            {
                ppPres.Slides[1].Shapes[1].TextFrame.TextRange = "Hymnal";
                ppPres.Slides[1].Shapes[2].TextFrame.TextRange = "詩頌";
                this.HymnalTitle.Text = "Change Titles Back To Service Titles";
            }
            else
            {
                ppPres.Slides[1].Shapes[1].TextFrame.TextRange = this.EnglishTitle.Text;
                ppPres.Slides[1].Shapes[2].TextFrame.TextRange = this.ChineseTitle.Text;
                this.HymnalTitle.Text = "Change Title To \"Hymnal\"";
            }


        }

        private void HymnChange_Click(object sender, EventArgs e)
        {
            ppPres.Slides[1].Shapes[4].TextFrame.TextRange = this.HymnNos.Text;
        }
        private void ShowPR_Click(object sender, EventArgs e)
        {
            PrayerRequests.Show();
        }
        private void BGColor_Click(object sender, EventArgs e)
        {
            if (this.ColorDialog.ShowDialog() == DialogResult.OK)
            {
                int CurrentSlide = ppPres.SlideShowWindow.View.CurrentShowPosition;
                int Red = Convert.ToInt32(this.ColorDialog.Color.R);
                int Green = Convert.ToInt32(this.ColorDialog.Color.G);
                int Blue = Convert.ToInt32(this.ColorDialog.Color.B);
                ppPres.Slides[CurrentSlide].Background.Fill.ForeColor = Color.FromArgb(255, Blue, Green, Red).ToArgb();
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        private void SaveSettings_Click(object sender, EventArgs e)
        {

            string CurrentSettings;
            CurrentSettings = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(GetFontAndColor(1, 1), Constants.vbCrLf), GetFontAndColor(1, 2)), Constants.vbCrLf), GetFontAndColor(1, 4)), Constants.vbCrLf), GetFontAndColor(1, 9)), Constants.vbCrLf), GetFontAndColor(1, 6)), Constants.vbCrLf), GetFontAndColor(1, 7)), Constants.vbCrLf), GetFontAndColor(1, 8)), Constants.vbCrLf), GetFontAndColor(3, 1)), Constants.vbCrLf), GetFontAndColor(3, 2)), Constants.vbCrLf), GetFontAndColor(4, 1)), Constants.vbCrLf), GetFontAndColor(4, 2)));
            for (int i = 1; i <= 8; i++)
            {
                if (i != 3)
                {
                    CurrentSettings = CurrentSettings + Constants.vbCrLf + "[C" + i + "]=" + Convert.ToString(ppPres.Slides[i].Background.Fill.ForeColor);
                }
            }
            try
            {
                TJCPowerPoint.My.MyProject.Computer.FileSystem.WriteAllText(Current + @"\Files\Settings.ini", CurrentSettings, false);
                MessageBox.Show("Save Successful", "Save Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save Unsuccessful", "Save Unsuccessful");
            }
        }

        private void OpenFolder_Click(object sender, EventArgs e)
        {
            Process.Start(Current + @"\Files");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Time.Text = "Time: " + DateTime.Now.ToString("HH:mm:ss  dddd, dd MMMM yyyy");
        }

        private void Titles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UpdateTitle_Click(sender, e);
            }
        }

        private void Verse_KeyDown(object sender, KeyEventArgs e)
        {
            // handling both when chapter and verse enter key pressed
            if (e.KeyCode == Keys.Enter)
            {
                UpdateVerse_Click(sender, e);
                if (!object.ReferenceEquals(this.VerseTxt.Text, ""))
                {
                    this.SelectNextControl((Control)sender, true, true, true, true);
                }
            }
        }
        private void Chapter_KeyDown(object sender, KeyEventArgs e)
        {
            // handling both when chapter and verse enter key pressed
            if (e.KeyCode == Keys.Enter)
            {
                if (!object.ReferenceEquals(this.ChapterTxt.Text, ""))
                {
                    this.SelectNextControl((Control)sender, true, true, true, true);
                }
            }
        }

        private void ServiceType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ppPres.Slides[1].Shapes[10].TextFrame.TextRange = this.ServiceType.Text;
            }
        }

        private void BookBox_KeyDown(object sender, KeyEventArgs e)
        {
            // handles when book box is empty, assumes that no verse or chapter should be shown
            if (object.ReferenceEquals(this.BookBox.Text, "") & e.KeyCode == Keys.Enter)
            {
                ppPres.Slides[1].Shapes[6].TextFrame.TextRange = "";
                ppPres.Slides[1].Shapes[7].TextFrame.TextRange = "";
                ppPres.Slides[1].Shapes[8].TextFrame.TextRange = "";
                this.VerseTxt.Text = "";
                this.ChapterTxt.Text = "";
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (Conversions.ToBoolean(this.BookBox.SelectedIndex))
                {
                    this.SelectNextControl((Control)sender, true, true, true, true);
                }
            }
        }


        private void Show_AN_Click(object sender, EventArgs e)
        {
            TJCPowerPoint.My.MyProject.Forms.Announcements.Show();
        }

        private void edtPrayerImg_Click(object sender, EventArgs e)
        {
            try
            {
                var ofd = new OpenFileDialog();
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";
                ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ppPres.Slides[2].Shapes.AddPicture(ofd.FileName, (Office.MsoTriState)Conversions.ToInteger(false), (Office.MsoTriState)Conversions.ToInteger(true), 0f, 0f, ppPres.PageSetup.SlideWidth, ppPres.PageSetup.SlideHeight);
                    File.WriteAllText(Current + @"\Files\prayerImgDir.txt", ofd.FileName);
                    MessageBox.Show("Prayer Image Was Successfully Updated", "Success");
                }
                else
                {
                    MessageBox.Show("Prayer Image Was Not Successfully Updated. Please Try Again", "Error");
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Prayer Image Was Not Successfully Updated. Please Try Again", "Error");
            }

        }

        private void edtHC_Click(object sender, EventArgs e)
        {
            TJCPowerPoint.My.MyProject.Forms.HolyCommunion.Show();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            ppPres.Slides[1].Shapes[6].TextFrame.TextRange = "";
            ppPres.Slides[1].Shapes[7].TextFrame.TextRange = "";
            ppPres.Slides[1].Shapes[8].TextFrame.TextRange = "";
            this.BookBox.Text = "";
            this.VerseTxt.Text = "";
            this.ChapterTxt.Text = "";
        }

        private void ServiceTimesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var ofd = new OpenFileDialog();
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";
                ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ppPres.Slides[8].Shapes.AddPicture(ofd.FileName, (Office.MsoTriState)Conversions.ToInteger(false), (Office.MsoTriState)Conversions.ToInteger(true), 0f, 0f, ppPres.PageSetup.SlideWidth, ppPres.PageSetup.SlideHeight);
                    File.WriteAllText(Current + @"\Files\timetableDir.txt", ofd.FileName);
                    MessageBox.Show("Service Timetable Was Successfully Updated", "Success");
                }
                else
                {
                    MessageBox.Show("Service Timetable Was Not Successfully Updated. Please Try Again", "Error");
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Service Timetable Was Not Successfully Updated. Please Try Again", "Error");
            }
        }


    }
}