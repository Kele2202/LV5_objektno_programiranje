namespace OP_LV5_Kelecic
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadExtensionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addedOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.basicOperationsToolStripMenuItem,
            this.addedOperationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadExtensionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // loadExtensionsToolStripMenuItem
            // 
            this.loadExtensionsToolStripMenuItem.Name = "loadExtensionsToolStripMenuItem";
            this.loadExtensionsToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.loadExtensionsToolStripMenuItem.Text = "Load Extensions";
            this.loadExtensionsToolStripMenuItem.Click += new System.EventHandler(this.loadExtensionsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // basicOperationsToolStripMenuItem
            // 
            this.basicOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.subToolStripMenuItem,
            this.mulToolStripMenuItem,
            this.divToolStripMenuItem});
            this.basicOperationsToolStripMenuItem.Name = "basicOperationsToolStripMenuItem";
            this.basicOperationsToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.basicOperationsToolStripMenuItem.Text = "Basic operations";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // subToolStripMenuItem
            // 
            this.subToolStripMenuItem.Name = "subToolStripMenuItem";
            this.subToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.subToolStripMenuItem.Text = "Sub";
            this.subToolStripMenuItem.Click += new System.EventHandler(this.subToolStripMenuItem_Click);
            // 
            // mulToolStripMenuItem
            // 
            this.mulToolStripMenuItem.Name = "mulToolStripMenuItem";
            this.mulToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mulToolStripMenuItem.Text = "Mul";
            this.mulToolStripMenuItem.Click += new System.EventHandler(this.mulToolStripMenuItem_Click);
            // 
            // divToolStripMenuItem
            // 
            this.divToolStripMenuItem.Name = "divToolStripMenuItem";
            this.divToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.divToolStripMenuItem.Text = "Div";
            this.divToolStripMenuItem.Click += new System.EventHandler(this.divToolStripMenuItem_Click);
            // 
            // addedOperationsToolStripMenuItem
            // 
            this.addedOperationsToolStripMenuItem.Name = "addedOperationsToolStripMenuItem";
            this.addedOperationsToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.addedOperationsToolStripMenuItem.Text = "Added operations";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(13, 72);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(26, 13);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "A = ";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(13, 106);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(26, 13);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "B = ";
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(13, 138);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(49, 13);
            this.lblR.TabIndex = 3;
            this.lblR.Text = "Result = ";
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(70, 72);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(100, 20);
            this.tbA.TabIndex = 4;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(70, 106);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(100, 20);
            this.tbB.TabIndex = 5;
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(70, 138);
            this.tbC.Name = "tbC";
            this.tbC.ReadOnly = true;
            this.tbC.Size = new System.Drawing.Size(100, 20);
            this.tbC.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadExtensionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addedOperationsToolStripMenuItem;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbC;
    }
}

