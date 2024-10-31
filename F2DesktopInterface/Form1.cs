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

        private void CloseForms(Form form)
        {
            List<Form> list= new List<Form>();
            list.Add(dashboardForm);
            list.Add(consoleForm);
            list.Add(filesForm);
            list.Add(historyForm);
            list.Add(manageForm);
            list.Add(configurationForm);
            list.Add(systemForm);

            foreach(Form f in list)
            {
                if(form != f)
                {
                    if(f!=null)
                    {
                        f.Close();
                    }
                }
            }

        }


        private void DashBoardActivate()
        {
            CloseForms(dashboardForm);
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
                pnDashboard.BackColor = SystemColors.ActiveBorder;
        }
        private void DashboardForm_Closed(object sender, FormClosedEventArgs e)
        {
            dashboardForm = null;
            pnDashboard.BackColor = SystemColors.ControlLight;
        }


        private void ConsoleActivate()
        {
            
            CloseForms(consoleForm);
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
            pnConsole.BackColor = SystemColors.ActiveBorder;
        }
        private void consoleForm_Closed(object sender, FormClosedEventArgs e)
        {
            consoleForm = null;
            pnConsole.BackColor = SystemColors.ControlLight;
        }


        private void FilesActivate()
        {
            CloseForms(filesForm);
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
            pnFiles.BackColor = SystemColors.ActiveBorder;
        }
        private void FilesForm_Closed(object sender, FormClosedEventArgs e)
        {
            filesForm = null;
            pnFiles.BackColor = SystemColors.ControlLight;
        }


        private void HistoryActivate()
        {
            CloseForms(historyForm);
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
            pnHistory.BackColor = SystemColors.ActiveBorder;
        }
        private void HistoryForm_Closed(object sender, FormClosedEventArgs e)
        {
            historyForm = null;
            pnHistory.BackColor = SystemColors.ControlLight;
        }


        private void ManageActivate()
        {
            CloseForms(manageForm);
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
            pnManage.BackColor = SystemColors.ActiveBorder;
        }
        private void ManageForm_Closed(object sender, FormClosedEventArgs e)
        {
            manageForm = null;
            pnManage.BackColor = SystemColors.ControlLight;
        }


        private void ConfigurationActivate()
        {
            CloseForms(configurationForm);
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
            pnConfiguration.BackColor = SystemColors.ActiveBorder;
        }
        private void ConfigurationForm_Closed(object sender, FormClosedEventArgs e)
        {
            configurationForm = null;
            pnConfiguration.BackColor = SystemColors.ControlLight;
        }


        private void SystemActivate()
        {
            CloseForms(systemForm);
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

            pnSystem.BackColor = SystemColors.ActiveBorder;
        }
        private void SystemForm_Closed(object sender, FormClosedEventArgs e)
        {
            systemForm = null;
            pnSystem.BackColor = SystemColors.ControlLight;
        }


        private void pnDashboard_Click(object sender, EventArgs e)
        {
            DashBoardActivate();
        }
        private void pnConsole_Click(object sender, EventArgs e)
        {
            ConsoleActivate();
        }
        private void pnFiles_Click(object sender, EventArgs e)
        {
            FilesActivate();
        }      
        private void pnHistory_Click(object sender, EventArgs e)
        {
            HistoryActivate();
        }
        private void pnManage_Click(object sender, EventArgs e)
        {
            ManageActivate();
        }      
        private void pnConfiguration_Click(object sender, EventArgs e)
        {
            ConfigurationActivate();
        }      
        private void pnSystem_Click(object sender, EventArgs e)
        {
            SystemActivate();
        }       
        private void Form1_Load(object sender, EventArgs e)
        {
            DashBoardActivate();
        }
    }
}
