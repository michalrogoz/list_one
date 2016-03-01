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
            this.tbX = new System.Windows.Forms.TextBox();
            this.btCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbY = new System.Windows.Forms.TextBox();
            this.lbCelling = new System.Windows.Forms.Label();
            this.lbFloor = new System.Windows.Forms.Label();
            this.lbFractional = new System.Windows.Forms.Label();
            this.lbModulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(65, 26);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(100, 26);
            this.tbX.TabIndex = 0;
            // 
            // btCalculate
            // 
            this.btCalculate.Location = new System.Drawing.Point(209, 26);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(117, 34);
            this.btCalculate.TabIndex = 1;
            this.btCalculate.Text = "Calculate";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "celling (x)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "floor (x)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "fractional part x";
            
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "x mod y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "x";
            
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "y (int)";
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(65, 93);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(100, 26);
            this.tbY.TabIndex = 8;
            // 
            // lbCelling
            // 
            this.lbCelling.AutoSize = true;
            this.lbCelling.Location = new System.Drawing.Point(185, 44);
            this.lbCelling.Name = "lbCelling";
            this.lbCelling.Size = new System.Drawing.Size(14, 20);
            this.lbCelling.TabIndex = 9;
            this.lbCelling.Text = "-";
            // 
            // lbFloor
            // 
            this.lbFloor.AutoSize = true;
            this.lbFloor.Location = new System.Drawing.Point(185, 90);
            this.lbFloor.Name = "lbFloor";
            this.lbFloor.Size = new System.Drawing.Size(14, 20);
            this.lbFloor.TabIndex = 10;
            this.lbFloor.Text = "-";
            // 
            // lbFractional
            // 
            this.lbFractional.AutoSize = true;
            this.lbFractional.Location = new System.Drawing.Point(185, 139);
            this.lbFractional.Name = "lbFractional";
            this.lbFractional.Size = new System.Drawing.Size(14, 20);
            this.lbFractional.TabIndex = 11;
            this.lbFractional.Text = "-";
            // 
            // lbModulo
            // 
            this.lbModulo.AutoSize = true;
            this.lbModulo.Location = new System.Drawing.Point(185, 189);
            this.lbModulo.Name = "lbModulo";
            this.lbModulo.Size = new System.Drawing.Size(14, 20);
            this.lbModulo.TabIndex = 12;
            this.lbModulo.Text = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbModulo);
            this.groupBox1.Controls.Add(this.lbCelling);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbFloor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbFractional);
            this.groupBox1.Location = new System.Drawing.Point(354, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 243);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculations";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 457);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btCalculate);
            this.Controls.Add(this.tbX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Label lbCelling;
        private System.Windows.Forms.Label lbFloor;
        private System.Windows.Forms.Label lbFractional;
        private System.Windows.Forms.Label lbModulo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

