namespace bozejko_lab1
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
            this.zadanie1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zadanie2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zadanie3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zadanie1ToolStripMenuItem,
            this.zadanie2ToolStripMenuItem,
            this.zadanie3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zadanie1ToolStripMenuItem
            // 
            this.zadanie1ToolStripMenuItem.Name = "zadanie1ToolStripMenuItem";
            this.zadanie1ToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.zadanie1ToolStripMenuItem.Text = "Zadanie 1";
            this.zadanie1ToolStripMenuItem.Click += new System.EventHandler(this.zadanie1ToolStripMenuItem_Click);
            // 
            // zadanie2ToolStripMenuItem
            // 
            this.zadanie2ToolStripMenuItem.Name = "zadanie2ToolStripMenuItem";
            this.zadanie2ToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.zadanie2ToolStripMenuItem.Text = "Zadanie 2";
            this.zadanie2ToolStripMenuItem.Click += new System.EventHandler(this.zadanie2ToolStripMenuItem_Click);
            // 
            // zadanie3ToolStripMenuItem
            // 
            this.zadanie3ToolStripMenuItem.Name = "zadanie3ToolStripMenuItem";
            this.zadanie3ToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.zadanie3ToolStripMenuItem.Text = "Zadanie 3";
            this.zadanie3ToolStripMenuItem.Click += new System.EventHandler(this.zadanie3ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(60, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 78);
            this.label1.TabIndex = 15;
            this.label1.Text = "Lista zadań nr 1\r\n\r\nWybierz numer zadania z menu.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zadanie1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zadanie2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zadanie3ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

