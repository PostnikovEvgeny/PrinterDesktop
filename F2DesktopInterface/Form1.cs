using F2DesktopInterface.sideBarForms;

namespace F2DesktopInterface
{
    public partial class Form1 : Form
    {
        bool sideBarExpand;
        DashboardForm dashboardForm;
        ConsoleForm consoleForm;
        FilesForm filesForm;
        HistoryForm historyForm;
        ManageForm manageForm;
        ConfigurationForm configurationForm;
        SystemForm systemForm;

        public Form1()
        {
            InitializeComponent();
            sideBarTimer.Start();

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

        private void pnDashboard_Click(object sender, EventArgs e)
        {
            if (dashboardForm == null)
            {
                dashboardForm = new DashboardForm();
                dashboardForm.FormClosed += DashboardForm_Closed;
                dashboardForm.MdiParent = this;
                dashboardForm.Dock = DockStyle.Fill;
                dashboardForm.Show();
            }
            else
            {
                dashboardForm.Activate();
            }
        }

        private void DashboardForm_Closed(object sender, FormClosedEventArgs e)
        {
            dashboardForm = null;
        }

        private void pnConsole_Click(object sender, EventArgs e)
        {
            if (consoleForm == null)
            {
                consoleForm = new ConsoleForm();
                consoleForm.FormClosed += consoleForm_Closed;
                consoleForm.MdiParent = this;
                consoleForm.Dock = DockStyle.Fill;
                consoleForm.Show();
            }
            else
            {
                consoleForm.Activate();
            }
        }
        private void consoleForm_Closed(object sender, FormClosedEventArgs e)
        {
            consoleForm = null;
        }
    }
}
