namespace F2DesktopInterface
{
    public partial class Form1 : Form
    {
        bool sideBarExpand;

        public Form1()
        {
            InitializeComponent();
        }

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {



            if (sideBarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    sideBarTimer.Stop();

                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    sideBarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }
    }
}
