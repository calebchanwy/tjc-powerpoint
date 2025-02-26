public partial class PrayerRequests
{
    private string directory;

    public PrayerRequests()
    {
        InitializeComponent();
        PrayerRequestTxt = _PrayerRequestTxt;
        _PrayerRequestTxt.Name = "PrayerRequestTxt";
    }

    private void ClosePrayerRequests_Click(object sender, EventArgs e)
    {
        this.Hide();
    }

    private void onCreate(object sender, EventArgs e)
    {
        directory = TJCPowerPoint.My.MyProject.Forms.MainProgram.Current + @"\Files\PrayerRequests.txt";
        if (System.IO.File.Exists(directory))
        {
            this.PrayerRequestTxt.Text = System.IO.File.ReadAllText(directory);
        }
    }
    private void UpdatePrayerRequests_Click(object sender, EventArgs e)
    {
        TJCPowerPoint.My.MyProject.MyForms.MainProgram.ppPres.Slides[(object)3].Shapes[(object)1].TextFrame.TextRange = this.PrayerRequestTxt.Text;
        try
        {
            TJCPowerPoint.My.MyProject.Computer.FileSystem.WriteAllText(TJCPowerPoint.My.MyProject.Forms.MainProgram.Current + @"\Files\PrayerRequests.txt", this.PrayerRequestTxt.Text, false);
            MessageBox.Show("Save Successful", "Save Successful");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Save Unsuccessful", "Save Unsuccessful");
        }

    }
    private void PRFontBtn_Click(object sender, EventArgs e)
    {
        TJCPowerPoint.My.MyProject.Forms.MainProgram.ChangeFont(3, 1);
    }
    private void PRColorBtn_Click(object sender, EventArgs e)
    {
        TJCPowerPoint.My.MyProject.Forms.MainProgram.ChangeColor(3, 1);
    }
    private void PRTitleFontBtn_Click(object sender, EventArgs e)
    {
        TJCPowerPoint.My.MyProject.Forms.MainProgram.ChangeFont(3, 2);
    }
    private void PRTitleColorBtn_Click(object sender, EventArgs e)
    {
        TJCPowerPoint.My.MyProject.Forms.MainProgram.ChangeColor(3, 2);
    }

    private void editPrayerImage_Click(object sender, EventArgs e)
    {
        try
        {
            var ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TJCPowerPoint.My.MyProject.MyForms.MainProgram.ppPres.Slides[(object)2].Shapes.AddPicture(ofd.FileName, (Microsoft.Office.Core.MsoTriState)Conversions.ToInteger(false), (Microsoft.Office.Core.MsoTriState)Conversions.ToInteger(true), 0f, 0f, TJCPowerPoint.My.MyProject.MyForms.MainProgram.ppPres.PageSetup.SlideWidth, TJCPowerPoint.My.MyProject.MyForms.MainProgram.ppPres.PageSetup.SlideHeight);
                System.IO.File.WriteAllText(TJCPowerPoint.My.MyProject.Forms.MainProgram.Current + @"\Files\prayerImgDir.txt", ofd.FileName);
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

    private void Button1_Click(object sender, EventArgs e)
    {
        TJCPowerPoint.My.MyProject.MyForms.MainProgram.ppPres.SlideShowWindow.View.GotoSlide(3);
    }


}
