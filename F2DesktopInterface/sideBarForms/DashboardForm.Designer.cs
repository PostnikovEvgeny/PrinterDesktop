namespace F2DesktopInterface.sideBarForms
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(30, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 338);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(571, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(489, 338);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(30, 410);
            panel3.Name = "panel3";
            panel3.Size = new Size(489, 338);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Location = new Point(571, 410);
            panel4.Name = "panel4";
            panel4.Size = new Size(227, 338);
            panel4.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Location = new Point(832, 410);
            panel5.Name = "panel5";
            panel5.Size = new Size(228, 338);
            panel5.TabIndex = 2;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 806);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardForm";
            Text = "DashboardForm";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
    }
}