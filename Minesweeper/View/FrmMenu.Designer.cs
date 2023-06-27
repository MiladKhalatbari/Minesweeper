
namespace Minesweeper
{
    partial class FrmMenu
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSingout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCup = new System.Windows.Forms.Label();
            this.BtnHard = new Minesweeper.RoundedButton();
            this.BtnMedium = new Minesweeper.RoundedButton();
            this.BtnEasy = new Minesweeper.RoundedButton();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Location = new System.Drawing.Point(503, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(39, 33);
            this.BtnClose.TabIndex = 8;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(542, 33);
            this.toolStrip2.TabIndex = 10;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnChangePassword,
            this.btnSingout,
            this.btnExit});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripDropDownButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(79, 30);
            this.toolStripDropDownButton1.Text = "Settings";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.btnChangePassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(203, 26);
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnSingout
            // 
            this.btnSingout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.btnSingout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSingout.Name = "btnSingout";
            this.btnSingout.Size = new System.Drawing.Size(203, 26);
            this.btnSingout.Text = "Sing out";
            this.btnSingout.Click += new System.EventHandler(this.btnSingout_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(203, 26);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCup
            // 
            this.lblCup.BackColor = System.Drawing.Color.Transparent;
            this.lblCup.Location = new System.Drawing.Point(23, 44);
            this.lblCup.Name = "lblCup";
            this.lblCup.Size = new System.Drawing.Size(107, 108);
            this.lblCup.TabIndex = 11;
            this.lblCup.Click += new System.EventHandler(this.lblCup_Click);
            // 
            // BtnHard
            // 
            this.BtnHard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.BtnHard.FlatAppearance.BorderSize = 0;
            this.BtnHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BtnHard.Location = new System.Drawing.Point(160, 416);
            this.BtnHard.Name = "BtnHard";
            this.BtnHard.Size = new System.Drawing.Size(220, 60);
            this.BtnHard.TabIndex = 6;
            this.BtnHard.Text = "Hard";
            this.BtnHard.UseVisualStyleBackColor = false;
            this.BtnHard.Click += new System.EventHandler(this.BtnHard_Click);
            // 
            // BtnMedium
            // 
            this.BtnMedium.BackColor = System.Drawing.Color.White;
            this.BtnMedium.FlatAppearance.BorderSize = 0;
            this.BtnMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BtnMedium.Location = new System.Drawing.Point(160, 327);
            this.BtnMedium.Name = "BtnMedium";
            this.BtnMedium.Size = new System.Drawing.Size(220, 60);
            this.BtnMedium.TabIndex = 5;
            this.BtnMedium.Text = "Medium";
            this.BtnMedium.UseVisualStyleBackColor = false;
            this.BtnMedium.Click += new System.EventHandler(this.BtnMedium_Click);
            // 
            // BtnEasy
            // 
            this.BtnEasy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.BtnEasy.FlatAppearance.BorderSize = 0;
            this.BtnEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BtnEasy.Location = new System.Drawing.Point(160, 239);
            this.BtnEasy.Name = "BtnEasy";
            this.BtnEasy.Size = new System.Drawing.Size(220, 60);
            this.BtnEasy.TabIndex = 4;
            this.BtnEasy.Text = "Easy";
            this.BtnEasy.UseVisualStyleBackColor = false;
            this.BtnEasy.Click += new System.EventHandler(this.BtnEasy_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Minesweeper.Properties.Resources.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(542, 566);
            this.Controls.Add(this.lblCup);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnHard);
            this.Controls.Add(this.BtnMedium);
            this.Controls.Add(this.BtnEasy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private RoundedButton BtnEasy;
        private RoundedButton BtnMedium;
        private RoundedButton BtnHard;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem btnChangePassword;
        private System.Windows.Forms.ToolStripMenuItem btnSingout;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.Label lblCup;
    }
}