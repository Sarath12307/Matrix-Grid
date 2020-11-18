using System.Threading;
namespace Counter_Thread
{
    partial class FormMatrixGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMatrixGrid));
            this.labelCounter = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.maximizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.threadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resumeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Start = new System.Windows.Forms.ToolStripButton();
            this.Pause = new System.Windows.Forms.ToolStripButton();
            this.menuStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCounter
            // 
            this.labelCounter.AutoSize = true;
            this.labelCounter.Location = new System.Drawing.Point(205, 59);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(0, 17);
            this.labelCounter.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(954, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maximizeToolStripMenuItem,
            this.threadToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(954, 28);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // maximizeToolStripMenuItem
            // 
            this.maximizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.maximizeToolStripMenuItem.Name = "maximizeToolStripMenuItem";
            this.maximizeToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.maximizeToolStripMenuItem.Text = "Max Size";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(92, 26);
            this.toolStripMenuItem2.Text = "4";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(92, 26);
            this.toolStripMenuItem3.Text = "5";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(92, 26);
            this.toolStripMenuItem4.Text = "6";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(92, 26);
            this.toolStripMenuItem5.Text = "7";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // threadToolStripMenuItem1
            // 
            this.threadToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem1,
            this.pauseToolStripMenuItem1,
            this.resumeToolStripMenuItem1});
            this.threadToolStripMenuItem1.Name = "threadToolStripMenuItem1";
            this.threadToolStripMenuItem1.Size = new System.Drawing.Size(67, 24);
            this.threadToolStripMenuItem1.Text = "Thread";
            // 
            // startToolStripMenuItem1
            // 
            this.startToolStripMenuItem1.Name = "startToolStripMenuItem1";
            this.startToolStripMenuItem1.Size = new System.Drawing.Size(136, 26);
            this.startToolStripMenuItem1.Text = "Start";
            this.startToolStripMenuItem1.Click += new System.EventHandler(this.startToolStripMenuItem1_Click);
            // 
            // pauseToolStripMenuItem1
            // 
            this.pauseToolStripMenuItem1.Name = "pauseToolStripMenuItem1";
            this.pauseToolStripMenuItem1.Size = new System.Drawing.Size(136, 26);
            this.pauseToolStripMenuItem1.Text = "Pause";
            this.pauseToolStripMenuItem1.Click += new System.EventHandler(this.pauseToolStripMenuItem1_Click);
            // 
            // resumeToolStripMenuItem1
            // 
            this.resumeToolStripMenuItem1.Name = "resumeToolStripMenuItem1";
            this.resumeToolStripMenuItem1.Size = new System.Drawing.Size(136, 26);
            this.resumeToolStripMenuItem1.Text = "Resume";
            this.resumeToolStripMenuItem1.Click += new System.EventHandler(this.resumeToolStripMenuItem1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Start,
            this.Pause});
            this.toolStrip1.Location = new System.Drawing.Point(0, 52);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(954, 27);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Start
            // 
            this.Start.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Start.Image = ((System.Drawing.Image)(resources.GetObject("Start.Image")));
            this.Start.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(24, 24);
            this.Start.Text = "Start";
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Pause
            // 
            this.Pause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Pause.Image = ((System.Drawing.Image)(resources.GetObject("Pause.Image")));
            this.Pause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(24, 24);
            this.Pause.Text = "Pause";
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // FormMatrixGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(954, 666);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelCounter);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMatrixGrid";
            this.Text = "MatrixGrid";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCounter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public Thread CounterThread;
        public bool bThreadStatus;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem maximizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem threadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resumeToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Start;
        private System.Windows.Forms.ToolStripButton Pause;
    }
}

