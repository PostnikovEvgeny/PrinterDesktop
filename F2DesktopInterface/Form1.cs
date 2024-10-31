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
            DashBoardActivate();
        }

        private void DashboardForm_Closed(object sender, FormClosedEventArgs e)
        {
            dashboardForm = null;
        }

        private void DashBoardActivate()
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
        private void ConsoleActivate()
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
        private void FilesActivate()
        {
            if (filesForm == null)
            {
                filesForm = new FilesForm();
                filesForm.FormClosed += FilesForm_Closed;
                filesForm.MdiParent = this;
                filesForm.Dock = DockStyle.Fill;
                filesForm.Show();
            }
            else
            {
                filesForm.Activate();
            }
        }
        private void HistoryActivate()
        {
            if (historyForm == null)
            {
                historyForm = new HistoryForm();
                historyForm.FormClosed += HistoryForm_Closed;
                historyForm.MdiParent = this;
                historyForm.Dock = DockStyle.Fill;
                historyForm.Show();
            }
            else
            {
                historyForm.Activate();
            }
        }
        private void ManageActivate()
        {
            if (manageForm == null)
            {
                manageForm = new ManageForm();
                manageForm.FormClosed += ManageForm_Closed;
                manageForm.MdiParent = this;
                manageForm.Dock = DockStyle.Fill;
                manageForm.Show();
            }
            else
            {
                manageForm.Activate();
            }
        }
        private void ConfigurationActivate()
        {
            if (configurationForm == null)
            {
                configurationForm = new ConfigurationForm();
                configurationForm.FormClosed += ConfigurationForm_Closed;
                configurationForm.MdiParent = this;
                configurationForm.Dock = DockStyle.Fill;
                configurationForm.Show();
            }
            else
            {
                configurationForm.Activate();
            }
        }
        private void SystemActivate()
        {
            if (systemForm == null)
            {
                systemForm = new SystemForm();
                systemForm.FormClosed += SystemForm_Closed;
                systemForm.MdiParent = this;
                systemForm.Dock = DockStyle.Fill;
                systemForm.Show();
            }
            else
            {
                systemForm.Activate();
            }
        }

        private void pnConsole_Click(object sender, EventArgs e)
        {
            ConsoleActivate();
        }
        private void consoleForm_Closed(object sender, FormClosedEventArgs e)
        {
            consoleForm = null;
        }

        private void pnFiles_Click(object sender, EventArgs e)
        {
            FilesActivate();
        }
        private void FilesForm_Closed(object sender, FormClosedEventArgs e)
        {
            filesForm = null;
        }

        private void pnHistory_Click(object sender, EventArgs e)
        {
            HistoryActivate();
        }
        private void HistoryForm_Closed(object sender, FormClosedEventArgs e)
        {
            historyForm = null;
        }

        private void pnManage_Click(object sender, EventArgs e)
        {
            ManageActivate();
        }
        private void ManageForm_Closed(object sender, FormClosedEventArgs e)
        {
            manageForm = null;
        }

        private void pnConfiguration_Click(object sender, EventArgs e)
        {
            ConfigurationActivate();
        }
        private void ConfigurationForm_Closed(object sender, FormClosedEventArgs e)
        {
            configurationForm = null;
        }

        private void pnSystem_Click(object sender, EventArgs e)
        {
            SystemActivate();
        }
        private void SystemForm_Closed(object sender, FormClosedEventArgs e)
        {
            systemForm = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DashBoardActivate();
        }
    }
}
