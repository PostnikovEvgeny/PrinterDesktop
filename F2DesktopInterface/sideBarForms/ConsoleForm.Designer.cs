﻿namespace F2DesktopInterface.sideBarForms
{
    partial class ConsoleForm
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
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(48, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(740, 695);
            panel1.TabIndex = 0;
            // 
            // ConsoleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 806);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConsoleForm";
            Text = "ConsoleForm";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
    }
}