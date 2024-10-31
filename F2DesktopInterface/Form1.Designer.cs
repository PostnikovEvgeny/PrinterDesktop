namespace F2DesktopInterface
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            руководствоПользователяToolStripMenuItem = new ToolStripMenuItem();
            sidebar = new FlowLayoutPanel();
            panel7 = new Panel();
            label1 = new Label();
            menuButton = new PictureBox();
            panel6 = new Panel();
            pnDashboard = new Button();
            panel8 = new Panel();
            pnConsole = new Button();
            panel9 = new Panel();
            pnFiles = new Button();
            panel10 = new Panel();
            pnHistory = new Button();
            panel11 = new Panel();
            pnManage = new Button();
            panel12 = new Panel();
            pnConfiguration = new Button();
            panel13 = new Panel();
            pnSystem = new Button();
            sideBarTimer = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            sidebar.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1246, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { сохранитьToolStripMenuItem, выходToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(48, 20);
            toolStripMenuItem1.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(133, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(133, 22);
            выходToolStripMenuItem.Text = "Выход";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { руководствоПользователяToolStripMenuItem });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(65, 20);
            toolStripMenuItem2.Text = "Справка";
            // 
            // руководствоПользователяToolStripMenuItem
            // 
            руководствоПользователяToolStripMenuItem.Name = "руководствоПользователяToolStripMenuItem";
            руководствоПользователяToolStripMenuItem.Size = new Size(221, 22);
            руководствоПользователяToolStripMenuItem.Text = "Руководство пользователя";
            // 
            // sidebar
            // 
            sidebar.BackColor = SystemColors.ControlLight;
            sidebar.Controls.Add(panel7);
            sidebar.Controls.Add(panel6);
            sidebar.Controls.Add(panel8);
            sidebar.Controls.Add(panel9);
            sidebar.Controls.Add(panel10);
            sidebar.Controls.Add(panel11);
            sidebar.Controls.Add(panel12);
            sidebar.Controls.Add(panel13);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 24);
            sidebar.MaximumSize = new Size(271, 0);
            sidebar.MinimumSize = new Size(81, 717);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(271, 717);
            sidebar.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Controls.Add(label1);
            panel7.Controls.Add(menuButton);
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(268, 65);
            panel7.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 25);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "     Меню";
            // 
            // menuButton
            // 
            menuButton.Cursor = Cursors.Hand;
            menuButton.Image = (Image)resources.GetObject("menuButton.Image");
            menuButton.Location = new Point(26, 20);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(26, 23);
            menuButton.SizeMode = PictureBoxSizeMode.Zoom;
            menuButton.TabIndex = 0;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(pnDashboard);
            panel6.Location = new Point(3, 74);
            panel6.Name = "panel6";
            panel6.Size = new Size(268, 43);
            panel6.TabIndex = 0;
            // 
            // pnDashboard
            // 
            pnDashboard.BackColor = SystemColors.ControlLight;
            pnDashboard.FlatStyle = FlatStyle.Flat;
            pnDashboard.Image = (Image)resources.GetObject("pnDashboard.Image");
            pnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            pnDashboard.Location = new Point(-9, -6);
            pnDashboard.Name = "pnDashboard";
            pnDashboard.Padding = new Padding(30, 0, 0, 0);
            pnDashboard.Size = new Size(299, 56);
            pnDashboard.TabIndex = 0;
            pnDashboard.Text = "                  Панель управления";
            pnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            pnDashboard.UseVisualStyleBackColor = false;
            pnDashboard.Click += pnDashboard_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(pnConsole);
            panel8.Location = new Point(3, 123);
            panel8.Name = "panel8";
            panel8.Size = new Size(268, 43);
            panel8.TabIndex = 1;
            // 
            // pnConsole
            // 
            pnConsole.FlatStyle = FlatStyle.Flat;
            pnConsole.Image = (Image)resources.GetObject("pnConsole.Image");
            pnConsole.ImageAlign = ContentAlignment.MiddleLeft;
            pnConsole.Location = new Point(-9, -6);
            pnConsole.Name = "pnConsole";
            pnConsole.Padding = new Padding(30, 0, 0, 0);
            pnConsole.Size = new Size(299, 56);
            pnConsole.TabIndex = 0;
            pnConsole.Text = "                  Консоль";
            pnConsole.TextAlign = ContentAlignment.MiddleLeft;
            pnConsole.UseVisualStyleBackColor = true;
            pnConsole.Click += pnConsole_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(pnFiles);
            panel9.Location = new Point(3, 172);
            panel9.Name = "panel9";
            panel9.Size = new Size(268, 43);
            panel9.TabIndex = 2;
            // 
            // pnFiles
            // 
            pnFiles.FlatStyle = FlatStyle.Flat;
            pnFiles.Image = (Image)resources.GetObject("pnFiles.Image");
            pnFiles.ImageAlign = ContentAlignment.MiddleLeft;
            pnFiles.Location = new Point(-9, -6);
            pnFiles.Name = "pnFiles";
            pnFiles.Padding = new Padding(30, 0, 0, 0);
            pnFiles.Size = new Size(299, 56);
            pnFiles.TabIndex = 0;
            pnFiles.Text = "                  Файлы";
            pnFiles.TextAlign = ContentAlignment.MiddleLeft;
            pnFiles.UseVisualStyleBackColor = true;
            pnFiles.Click += pnFiles_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(pnHistory);
            panel10.Location = new Point(3, 221);
            panel10.Name = "panel10";
            panel10.Size = new Size(268, 43);
            panel10.TabIndex = 3;
            // 
            // pnHistory
            // 
            pnHistory.FlatStyle = FlatStyle.Flat;
            pnHistory.Image = (Image)resources.GetObject("pnHistory.Image");
            pnHistory.ImageAlign = ContentAlignment.MiddleLeft;
            pnHistory.Location = new Point(-9, -6);
            pnHistory.Name = "pnHistory";
            pnHistory.Padding = new Padding(30, 0, 0, 0);
            pnHistory.Size = new Size(299, 56);
            pnHistory.TabIndex = 0;
            pnHistory.Text = "                  История задач";
            pnHistory.TextAlign = ContentAlignment.MiddleLeft;
            pnHistory.UseVisualStyleBackColor = true;
            pnHistory.Click += pnHistory_Click;
            // 
            // panel11
            // 
            panel11.Controls.Add(pnManage);
            panel11.Location = new Point(3, 270);
            panel11.Name = "panel11";
            panel11.Size = new Size(268, 43);
            panel11.TabIndex = 4;
            // 
            // pnManage
            // 
            pnManage.FlatStyle = FlatStyle.Flat;
            pnManage.Image = (Image)resources.GetObject("pnManage.Image");
            pnManage.ImageAlign = ContentAlignment.MiddleLeft;
            pnManage.Location = new Point(-9, -6);
            pnManage.Name = "pnManage";
            pnManage.Padding = new Padding(30, 0, 0, 0);
            pnManage.Size = new Size(299, 56);
            pnManage.TabIndex = 0;
            pnManage.Text = "                  Управление";
            pnManage.TextAlign = ContentAlignment.MiddleLeft;
            pnManage.UseVisualStyleBackColor = true;
            pnManage.Click += pnManage_Click;
            // 
            // panel12
            // 
            panel12.Controls.Add(pnConfiguration);
            panel12.Location = new Point(3, 319);
            panel12.Name = "panel12";
            panel12.Size = new Size(268, 43);
            panel12.TabIndex = 5;
            // 
            // pnConfiguration
            // 
            pnConfiguration.FlatStyle = FlatStyle.Flat;
            pnConfiguration.Image = (Image)resources.GetObject("pnConfiguration.Image");
            pnConfiguration.ImageAlign = ContentAlignment.MiddleLeft;
            pnConfiguration.Location = new Point(-9, -6);
            pnConfiguration.Name = "pnConfiguration";
            pnConfiguration.Padding = new Padding(30, 0, 0, 0);
            pnConfiguration.Size = new Size(299, 56);
            pnConfiguration.TabIndex = 0;
            pnConfiguration.Text = "                  Конфигурация";
            pnConfiguration.TextAlign = ContentAlignment.MiddleLeft;
            pnConfiguration.UseVisualStyleBackColor = true;
            pnConfiguration.Click += pnConfiguration_Click;
            // 
            // panel13
            // 
            panel13.Controls.Add(pnSystem);
            panel13.Location = new Point(3, 368);
            panel13.Name = "panel13";
            panel13.Size = new Size(268, 43);
            panel13.TabIndex = 6;
            // 
            // pnSystem
            // 
            pnSystem.FlatStyle = FlatStyle.Flat;
            pnSystem.Image = (Image)resources.GetObject("pnSystem.Image");
            pnSystem.ImageAlign = ContentAlignment.MiddleLeft;
            pnSystem.Location = new Point(-9, -6);
            pnSystem.Name = "pnSystem";
            pnSystem.Padding = new Padding(30, 0, 0, 0);
            pnSystem.Size = new Size(299, 56);
            pnSystem.TabIndex = 0;
            pnSystem.Text = "                  Система";
            pnSystem.TextAlign = ContentAlignment.MiddleLeft;
            pnSystem.UseVisualStyleBackColor = true;
            pnSystem.Click += pnSystem_Click;
            // 
            // sideBarTimer
            // 
            sideBarTimer.Interval = 10;
            sideBarTimer.Tick += sideBarTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 741);
            Controls.Add(sidebar);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Управление принтером F2-Lite";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            sidebar.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            panel6.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel13.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem руководствоПользователяToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private FlowLayoutPanel sidebar;
        private Panel panel6;
        private Button pnDashboard;
        private Panel panel7;
        private Panel panel8;
        private Button pnConsole;
        private Panel panel9;
        private Button pnFiles;
        private Panel panel10;
        private Button pnHistory;
        private Panel panel11;
        private Button pnManage;
        private Panel panel12;
        private Button pnConfiguration;
        private Panel panel13;
        private Button pnSystem;
        private PictureBox menuButton;
        private Label label1;
        private System.Windows.Forms.Timer sideBarTimer;
    }
}
