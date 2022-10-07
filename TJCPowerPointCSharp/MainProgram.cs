namespace TJCPowerPointCSharp
{

    public partial class MainProgram : Form
    {
        public MainProgram()
        {

            InitializeComponent();
        }
        private bool mouseDown;
        private Point lastLocation;

        private void MainProgram_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MainProgram_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void MainProgram_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void CloseForm_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void sermonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


    }
}