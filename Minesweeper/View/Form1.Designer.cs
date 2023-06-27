
namespace Minesweeper
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnHelp = new System.Windows.Forms.ToolStripButton();
            this.BtnReset = new System.Windows.Forms.ToolStripButton();
            this.LblBombs = new System.Windows.Forms.Label();
            this.LblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(42, 210);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 423);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Font = new System.Drawing.Font("Andalus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnHelp,
            this.BtnReset});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.toolStrip1.Size = new System.Drawing.Size(508, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = " ";
            // 
            // BtnHelp
            // 
            this.BtnHelp.BackColor = System.Drawing.Color.Transparent;
            this.BtnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnHelp.Font = new System.Drawing.Font("Arial", 8.25F);
            this.BtnHelp.ForeColor = System.Drawing.Color.Black;
            this.BtnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(32, 22);
            this.BtnHelp.Text = "Help";
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.Transparent;
            this.BtnReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnReset.Font = new System.Drawing.Font("Arial", 8.25F);
            this.BtnReset.ForeColor = System.Drawing.Color.Black;
            this.BtnReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(30, 22);
            this.BtnReset.Text = "Quit";
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click_1);
            // 
            // LblBombs
            // 
            this.LblBombs.AutoSize = true;
            this.LblBombs.BackColor = System.Drawing.Color.Transparent;
            this.LblBombs.Font = new System.Drawing.Font("DS-Digital", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBombs.ForeColor = System.Drawing.Color.Red;
            this.LblBombs.Location = new System.Drawing.Point(56, 78);
            this.LblBombs.Name = "LblBombs";
            this.LblBombs.Size = new System.Drawing.Size(139, 79);
            this.LblBombs.TabIndex = 7;
            this.LblBombs.Text = "010";
            // 
            // LblTimer
            // 
            this.LblTimer.AutoSize = true;
            this.LblTimer.BackColor = System.Drawing.Color.Transparent;
            this.LblTimer.Font = new System.Drawing.Font("DS-Digital", 60F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTimer.ForeColor = System.Drawing.Color.Red;
            this.LblTimer.Location = new System.Drawing.Point(299, 78);
            this.LblTimer.Name = "LblTimer";
            this.LblTimer.Size = new System.Drawing.Size(157, 79);
            this.LblTimer.TabIndex = 8;
            this.LblTimer.Text = "888";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::Minesweeper.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(508, 673);
            this.Controls.Add(this.LblBombs);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.LblTimer);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Traditional Arabic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Minesweeper Game";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnReset;
        private System.Windows.Forms.ToolStripButton BtnHelp;
        private System.Windows.Forms.Label LblBombs;
        private System.Windows.Forms.Label LblTimer;
        private System.Windows.Forms.Timer timer1;
    }
}

